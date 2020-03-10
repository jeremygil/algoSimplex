using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoSimplex
{
    class Back
    {
        public void maximiser()
        {

        }

        public double calculZ(int[] listCP, int[] listQuantite)
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

        public List<double> calculZj(int[] listCP, int[,] listContrainte)
        {
            List<double> valeurZJ = new List<double>();



            return valeurZJ;
        }

    }
}
