﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Xceed.Wpf.Toolkit;

namespace algoSimplex
{
    public partial class FSimplex : Form
    {
        public FSimplex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblValueNbContraintes.Text = Convert.ToString(this.rangeBarNbContraintes.Value);
            this.lblValueNbVariables.Text = Convert.ToString(this.rangeBarNbVariables.Value);

            //fonction economique
            Int32 nombreVarariables = (Int32)this.rangeBarNbVariables.Value;
            Int32 nombreContraintes = (Int32)this.rangeBarNbContraintes.Value;

            /*Chargement tableau fonction économique*/
            tableauFoncEconom.RowCount = nombreContraintes + 1;
            tableauFoncEconom.AllowUserToAddRows = false;
            tableauFoncEconom.ColumnCount = nombreVarariables;

            InterfaceIHM.NameColumn(nombreVarariables, tableauFoncEconom);
        }

        private void RangeBarNbContraintes_ValueChanged(object sender, EventArgs e)
        {
            this.lblValueNbContraintes.Text = Convert.ToString(this.rangeBarNbContraintes.Value);
            //fonction economique
            Int32 nombreContraintes = (Int32)this.rangeBarNbContraintes.Value;

            /*Chargement tableau fonction économique*/
            tableauFoncEconom.RowCount = nombreContraintes;

       
        }

        private void RangeBarNbVariables_ValueChanged(object sender, EventArgs e)
        {
            this.lblValueNbVariables.Text = Convert.ToString(this.rangeBarNbVariables.Value);
            Int32 nombreVarariables = (Int32)this.rangeBarNbVariables.Value;

            /*Chargement tableau fonction économique*/
            tableauFoncEconom.ColumnCount = nombreVarariables;
            InterfaceIHM.NameColumn(nombreVarariables, tableauFoncEconom);
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            FResultat FResultat = new FResultat(tableauFoncEconom);
            FResultat.Show();
            this.Hide();
        }
    }
}
