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

        public static double calculZ(int[] listCP, int[] listQuantite)
        {
            double valeurZ = 0;
            if (listCP.Length.Equals(listQuantite.Length))
            {
                for (int i = 0; i < listCP.Length; i++)
                {
                        valeurZ += Convert.ToDouble(listCP[i]) * Convert.ToDouble(listQuantite[i]);
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

            for(int i = 0; i < listCj.Length; i++)
            {
                result[i] = listCj[i] - listZj[i];
            }

            return result;
        }

        public static int minCjZJ(double[] listCjZj)
        {
            double value = Int32.MaxValue;
            int result = 0;
            for(int i = 0; i < listCjZj.Length; i++)
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

        public static int maxCjZJ(double[] listCjZj)
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


    }
}
