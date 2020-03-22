using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoSimplex
{
    class InterfaceIHM
    {

        public static void NameColumn(Int32 pNomberColumn, DataGridView pTable, bool verifTab)
        {

            pTable.Columns[0].Name = "X1";
            pTable.Columns[1].Name = "X2";
            if (verifTab == true) {
                pTable.Columns[2].Name = "Opérateur";
                pTable.Columns[3].Name = "Somme";
            }

            switch (pNomberColumn)
            {
                case 2:
                    break;
                case 3:
                    pTable.Columns[2].Name = "X3";
                    if (verifTab == true)
                    {
                        pTable.Columns[3].Name = "Opérateur";
                        pTable.Columns[4].Name = "Somme";
                    }
                    break;
                case 4:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    if (verifTab == true)
                    {
                        pTable.Columns[4].Name = "Opérateur";
                        pTable.Columns[5].Name = "Somme";
                    }
                    break;
                case 5:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    if (verifTab == true)
                    {
                        pTable.Columns[5].Name = "Opérateur";
                        pTable.Columns[6].Name = "Somme";
                    }
                    break;
                case 6:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    if (verifTab == true)
                    {
                        pTable.Columns[6].Name = "Opérateur";
                        pTable.Columns[7].Name = "Somme";
                    }
                    break;
                case 7:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    if (verifTab == true)
                    {
                        pTable.Columns[7].Name = "Opérateur";
                        pTable.Columns[8].Name = "Somme";
                    }
                    break;
                case 8:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    pTable.Columns[7].Name = "X8";
                    if (verifTab == true)
                    {
                        pTable.Columns[8].Name = "Opérateur";
                        pTable.Columns[9].Name = "Somme";
                    }
                    break;
                case 9:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    pTable.Columns[7].Name = "X8";
                    pTable.Columns[8].Name = "X9";
                    if (verifTab == true)
                    {
                        pTable.Columns[9].Name = "Opérateur";
                        pTable.Columns[10].Name = "Somme";
                    }
                    break;

                case 10:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    pTable.Columns[7].Name = "X8";
                    pTable.Columns[8].Name = "X9";
                    pTable.Columns[9].Name = "X10";
                    if (verifTab == true)
                    {
                        pTable.Columns[10].Name = "Opérateur";
                        pTable.Columns[11].Name = "Somme";
                    }
                    break;
            }
        }
    }
}
