using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoSimplex
{
    class interfaceIHM
    {

        public static void NameColumn(Int32 pNomberColumn, DataGridView pTable)
        {

            pTable.Columns[0].Name = "X1";
            pTable.Columns[1].Name = "X2";

            switch (pNomberColumn)
            {
                case 2:
                    break;
                case 3:
                    pTable.Columns[2].Name = "X3";
                    break;
                case 4:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    break;
                case 5:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    break;
                case 6:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    break;
                case 7:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    break;
                case 8:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    pTable.Columns[7].Name = "X8";
                    break;
                case 9:
                    pTable.Columns[2].Name = "X3";
                    pTable.Columns[3].Name = "X4";
                    pTable.Columns[4].Name = "X5";
                    pTable.Columns[5].Name = "X6";
                    pTable.Columns[6].Name = "X7";
                    pTable.Columns[7].Name = "X8";
                    pTable.Columns[8].Name = "X9";
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
                    break;
            }
        }
    }
}
