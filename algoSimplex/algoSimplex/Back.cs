using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace algoSimplex
{
    public static class Back
    {
        private static ILog LOGGER = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static double[,] listContrainte;
        private static double[] listQuantite;
        private static double[] listZj;
        private static double[] listCjZj;
        private static int[] listCj;
        private static int[] listCp;
        private static double zValue;
        private static int row;
        private static int column;

        public static double[] maximiser(TrackBar trackContrainte, TrackBar trackVariable, DataGridView tableauZ, DataGridView tableauContraintes)
        {
            //Partie initialisation
            initialiseTable(false, trackContrainte, trackVariable, tableauZ, tableauContraintes);
            zValue = calculZ(listCp, listQuantite);
            listZj = calculZj(listCp, listContrainte, row, column);
            listCjZj = calculSoustractionCjZj(listCj, listZj);

            bool verif = true;
            do
            {
                //Partie traitement
                int colonnePivot = maxCjZj(listCjZj);
                int lignePivot = minRatio(calculRatio(listQuantite, listContrainte, colonnePivot));
                listCp = updateCp(listCp, listCj, lignePivot);
                double valuePivot = listContrainte[lignePivot, colonnePivot];
                listQuantite = updateQuantitePivot(listQuantite, lignePivot, valuePivot);
                listContrainte = updateContraintePivot(listContrainte, lignePivot, valuePivot, column);
                listQuantite = updateQuantite(listQuantite, lignePivot, colonnePivot, listContrainte);
                listContrainte = updateContrainte(listContrainte, lignePivot, colonnePivot, row, column);
                zValue = calculZ(listCp, listQuantite);
                listZj = calculZj(listCp, listContrainte, row, column);
                listCjZj = calculSoustractionCjZj(listCj, listZj);
                verif = isFinalMax(listCjZj);
            } while (verif);

            return sendResult(zValue, row, column, listQuantite, listCj, listCp);
        }

        public static double[] minimiser(TrackBar trackContrainte, TrackBar trackVariable, DataGridView tableauZ, DataGridView tableauContraintes)
        {
            initialiseTable(true, trackContrainte, trackVariable, tableauZ, tableauContraintes);
            zValue = calculZ(listCp, listQuantite);
            listZj = calculZj(listCp, listContrainte, row, column);
            listCjZj = calculSoustractionCjZj(listCj, listZj);

            bool verif = true;
            do
            {
                //Partie traitement
                int colonnePivot = minCjZj(listCjZj);
                int lignePivot = minRatio(calculRatio(listQuantite, listContrainte, colonnePivot));
                listCp = updateCp(listCp, listCj, lignePivot);
                double valuePivot = listContrainte[lignePivot, colonnePivot];
                listQuantite = updateQuantitePivot(listQuantite, lignePivot, valuePivot);
                listContrainte = updateContraintePivot(listContrainte, lignePivot, valuePivot, column);
                listQuantite = updateQuantite(listQuantite, lignePivot, colonnePivot, listContrainte);
                listContrainte = updateContrainte(listContrainte, lignePivot, colonnePivot, row, column);
                zValue = calculZ(listCp, listQuantite);
                listZj = calculZj(listCp, listContrainte, row, column);
                listCjZj = calculSoustractionCjZj(listCj, listZj);
                verif = isFinalMin(listCjZj);
            } while (verif);

            return sendResult(zValue, row, column, listQuantite, listCj, listCp);
        }

        public static void initialiseTable(bool minimiser, TrackBar trackContrainte, TrackBar trackVariable, DataGridView tableauZ, DataGridView tableauContraintes)
        {
            row = trackContrainte.Value;
            column = trackVariable.Value;
            zValue = 0;

            //Rempli le tableau des contraintes
            double[,] listConstraintTemp = new double[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    listConstraintTemp[i, j] = Double.Parse(tableauContraintes[j, i].Value.ToString());
                }
            }

            int[,] listVariableEcart = new int[row, column];
            int[,] listVariableArtificiel = new int[row, column];
            int columnEcart = 0;
            int columnArtificiel = 0;
            int colonneoperateur = column + 1;

            for (int i = 0; i < row; i++)
            {
                string operateur = tableauContraintes[i + 1, colonneoperateur].Value.ToString();
                for (int j = 0; j < column; j++)
                {
                    if (i == j)
                    {
                        if (operateur.Contains("<="))
                        {
                            listVariableEcart[i, j] = 1;
                            listVariableArtificiel[i, j] = 0;
                            columnEcart++;
                        }
                        else if (operateur.Contains("="))
                        {
                            listVariableEcart[i, j] = 0;
                            if (minimiser)
                            {
                                listVariableArtificiel[i, j] = Int32.MaxValue;
                            }
                            else
                            {
                                listVariableArtificiel[i, j] = Int32.MinValue;
                            }
                            columnArtificiel++;
                        }
                        else
                        {
                            listVariableEcart[i, j] = -1;
                            if (minimiser)
                            {
                                listVariableArtificiel[i, j] = Int32.MaxValue;
                            }
                            else
                            {
                                listVariableArtificiel[i, j] = Int32.MinValue;
                            }

                            columnArtificiel++;
                            columnEcart++;
                        }

                    }
                    else
                    {
                        listVariableEcart[i, j] = 0;
                        listVariableArtificiel[i, j] = 0;
                    }
                }
            }

            int tailleMax = row + columnEcart + columnArtificiel;
            listContrainte = new double[row, tailleMax];
            int valueEcart = 0;
            int valueArtificielle = 0;

            for (int i = 0; i < row; i++)
            {
                valueEcart = 0;
                valueArtificielle = 0;
                for (int j = 0; j < column; j++)
                {
                    listContrainte[i, j] = listConstraintTemp[i, j];
                }
                for (int k = column; k < column + columnEcart; k++)
                {
                    listContrainte[i, k] = listVariableEcart[i, valueEcart];
                    valueEcart++;
                }
                for (int l = column + columnEcart; l < tailleMax; l++)
                {
                    listContrainte[i, l] = listVariableArtificiel[i, valueArtificielle];
                    valueArtificielle++;
                }
            }

            //Remplir le tableau des Cj            
            listCj = new int[tailleMax];
            for (int i = 0; i < tailleMax; i++)
            {
                if (i < row)
                {
                    listCj[i] = Int32.Parse(tableauZ[i, 0].Value.ToString());
                }
                else if (i < (row + columnEcart))
                {
                    listCj[i] = 0;
                }
                else
                {
                    if (minimiser)
                    {
                        listCj[i] = Int32.MaxValue;
                    }
                    else
                    {
                        listCj[i] = Int32.MinValue;
                    }
                }
            }

            //Rempli le tableau de Cp
            listCp = new int[row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < tailleMax - row; j++)
                {
                    if (i == j)
                    {
                        if (listVariableEcart[i, j] < 0)
                        {
                            listCp[i] = listVariableArtificiel[i, j];
                        }
                        else
                        {
                            listCp[i] = listVariableEcart[i, j];
                        }
                    }
                }
            }

            //Rempli le tableau de Quantité
            listQuantite = new double[row];
            int colonneQuantite = column + 2;
            for (int i = 0; i < row; i++)
            {
                listQuantite[i] = Double.Parse(tableauContraintes[i + 1 , colonneQuantite].Value.ToString());
            }

            listZj = new double[listCj.Length];
            listCjZj = new double[listCj.Length];

        }

        public static double calculZ(int[] listCP, double[] listQuantite)
        {
            double valeurZ = 0;
            if (listCP.Length.Equals(listQuantite.Length))
            {
                for (int i = 0; i < listCP.Length; i++)
                {
                    valeurZ += Convert.ToDouble(listCP[i]) * listQuantite[i];
                }
                LOGGER.Info("Valeur de Z : " + valeurZ);
                return valeurZ;
            }
            return 0;
        }

        public static double[] calculZj(int[] listCP, double[,] listContrainte, int pRow, int pColumn)
        {
            double[] valeurZj = new double[pColumn];

            for (int row = 0; row < pRow; row++)
            {
                double value = 0;
                for (int column = 0; column < pColumn; column++)
                {
                    LOGGER.Info("Valeur boucle :" + value);
                    value += listCP[row] * listContrainte[row, column];
                }
                LOGGER.Info("Value :" + value);
                valeurZj[row] = value;
                LOGGER.Info("ValeurZj :" + valeurZj[row]);
            }

            return valeurZj;
        }

        public static double[] calculSoustractionCjZj(int[] listCj, double[] listZj)
        {
            double[] result = new double[listCj.Length];

            for (int i = 0; i < listCj.Length; i++)
            {
                result[i] = listCj[i] - listZj[i];
            }

            return result;
        }

        public static int minCjZj(double[] listCjZj)
        {
            double value = Int32.MaxValue;
            int result = 0;
            for (int i = 0; i < listCjZj.Length; i++)
            {
                value = Math.Min(value, listCjZj[i]);
            }

            for (int i = 0; i < listCjZj.Length; i++)
            {
                if (value.Equals(listCjZj[i]))
                {
                    result = i;
                }
            }

            return result;
        }

        public static int maxCjZj(double[] listCjZj)
        {
            double value = Int32.MinValue;
            int result = 0;
            for (int i = 0; i < listCjZj.Length; i++)
            {
                value = Math.Max(value, listCjZj[i]);
            }

            for (int i = 0; i < listCjZj.Length; i++)
            {
                if (value.Equals(listCjZj[i]))
                {
                    result = i;
                }
            }

            return result;
        }

        public static double[] calculRatio(double[] listQuantite, double[,] listContrainte, int valeurPlace)
        {
            double[] result = new double[listQuantite.Length];

            for (int i = 0; i < listQuantite.Length; i++)
            {
                result[i] = listQuantite[i] / listContrainte[i, valeurPlace];
            }

            return result;
        }

        public static int minRatio(double[] ratio)
        {
            double value = Int32.MaxValue;
            int result = 0;
            for (int i = 0; i < ratio.Length; i++)
            {
                value = Math.Min(value, ratio[i]);
            }

            for (int i = 0; i < ratio.Length; i++)
            {
                if (value.Equals(ratio[i]))
                {
                    result = i;
                }
            }

            return result;
        }

        public static int[] updateCp(int[] listCp, int[] listCj, int ratio)
        {
            listCp[ratio] = listCj[ratio];
            return listCp;
        }

        public static double[] updateQuantitePivot(double[] listQuantite, int lignePivot, double valuePivot)
        {
            listQuantite[lignePivot] = listQuantite[lignePivot] / valuePivot;
            return listQuantite;
        }

        public static double[,] updateContraintePivot(double[,] listContrainte, int lignePivot, double valuePivot, int column)
        {
            for (int i = 0; i < column; i++)
            {
                listContrainte[lignePivot, i] = listContrainte[lignePivot, i] / valuePivot;
            }

            return listContrainte;
        }

        public static double[] updateQuantite(double[] listQuantite, int lignePivot, int colonnePivot, double[,] listConstrainte)
        {
            for (int i = 0; i < listQuantite.Length; i++)
            {
                if (!i.Equals(lignePivot))
                {
                    listQuantite[i] = listQuantite[i] - (listConstrainte[i, colonnePivot] * listQuantite[lignePivot]);
                }
            }

            return listQuantite;
        }

        public static double[,] updateContrainte(double[,] listConstrainte, int lignePivot, int colonnePivot, int nombreContraintes, int columns)
        {
            for (int i = 0; i < nombreContraintes; i++)
            {
                if (!i.Equals(lignePivot))
                {
                    double valueMultiplicateur = listConstrainte[i, colonnePivot];

                    for (int j = 0; j < columns; j++)
                    {
                        listConstrainte[i, j] = listConstrainte[i, j] - (valueMultiplicateur * listConstrainte[lignePivot, j]);
                    }
                }
            }

            return listConstrainte;
        }

        public static bool isFinalMax(double[] listCjZj)
        {
            int compteur = 0;

            for (int i = 0; i < listCjZj.Length; i++)
            {
                if (listCjZj[i] <= 0)
                {
                    compteur++;
                }
            }

            if (compteur.Equals(listCjZj.Length))
            {
                return false;
            }

            return true;
        }

        public static bool isFinalMin(double[] listCjZj)
        {
            int compteur = 0;

            for (int i = 0; i < listCjZj.Length; i++)
            {
                if (listCjZj[i] >= 0)
                {
                    compteur++;
                }
            }

            if (compteur.Equals(listCjZj.Length))
            {
                return false;
            }

            return true;
        }

        public static double[] sendResult(double valueZ, int row, int column, double[] listQuantite, int[] listCj, int[] listCP)
        {
            int tailleTableResult = column + 1;
            double[] result = new double[tailleTableResult];

            result[0] = valueZ;

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (listCj[i].Equals(listCp[j]))
                    {
                        result[i + 1] = listQuantite[j];
                    }
                }
            }

            return result;
        }

    }
}
