using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoSimplex
{
    public static class Back
    {
        public static void maximiser()
        {
            Console.Out.WriteLine("Maximiser");
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
                return valeurZ;
            }
            return 0;
        }

        public static List<double> calculZj(int[] listCP, int[,] listContrainte, int pRow, int pColumn)
        {
            List<double> valeurZj = new List<double>();

            for(int row = 0; row < pRow; row++)
            {
                double value = 0;
                for (int column = 0; column < pColumn; column++)
                {
                    value += listCP[row] * listContrainte[row, column];
                }
                valeurZj.Add(value);
            }

            return valeurZj;
        }

    }
}
