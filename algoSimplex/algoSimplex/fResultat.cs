using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoSimplex
{
    public partial class FResultat : Form
    {
        private double[] result;

        public FResultat(double[] result)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.result = result;
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            FSimplex FSimplex = new FSimplex();
            FSimplex.Show();
            this.Close();
        }

        private void FResultat_Load(object sender, EventArgs e)
        {
            //this.dataResult.DataSource = tableauFoncEconom.DataSource;
        }
    }
}
