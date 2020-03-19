using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace algoSimplex
{
    public static class Back
    {
        private static ILog LOGGER = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void maximiser()
        {
            Console.Out.WriteLine("Maximiser");
        }

        public static void minimiser()
        {
            Console.Out.WriteLine("Minimiser");
        }

        public static void initialiseTable()
        {

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

        public static double[] updateQuantitePivot(double[] listQuantite, int lignePivot, double valuePivot) {
            listQuantite[lignePivot] = listQuantite[lignePivot] / valuePivot;
            return listQuantite;
        }

        public static double[,] updateContraintePivot(double[,]listContrainte, int lignePivot, int colonnePivot, int nombreVariable)
        {
            double value = listContrainte[lignePivot, colonnePivot];
            for(int i = 0; i < nombreVariable; i++)
            {
                listContrainte[lignePivot, i] = listContrainte[lignePivot, i] / value;
            }

            return listContrainte;
        }

        public static double[] updateQuantite(double[] listQuantite, int lignePivot, int colonnePivot, double[,] listConstrainte)
        {
            for(int i = 0; i < listQuantite.Length; i++)
            {
                if (!i.Equals(lignePivot))
                {
                    listQuantite[i] = listQuantite[i] - (listConstrainte[i, colonnePivot] * listQuantite[lignePivot]);
                }
            }

            return listQuantite;
        }

        public static double[,] updateContrainte(double[,] listConstrainte, int lignePivot, int colonnePivot, int nombreContraintes, int nombreVariables)
        {
            for(int i = 0; i < nombreContraintes; i++)
            {
                if (!i.Equals(lignePivot))
                {
                    double valueMultiplicateur = listConstrainte[i,colonnePivot];

                    for(int j = 0; j < nombreVariables; j++)
                    {
                        listConstrainte[i, j] = listConstrainte[i, j] - (valueMultiplicateur * listConstrainte[lignePivot,j]);
                    }
                }
            }

            return listConstrainte;
        }
    }
}
