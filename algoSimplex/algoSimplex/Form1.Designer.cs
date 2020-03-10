namespace algoSimplex
{
    partial class fSimplex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioMin = new System.Windows.Forms.RadioButton();
            this.radioMax = new System.Windows.Forms.RadioButton();
            this.lblNbContraintes = new System.Windows.Forms.Label();
            this.rangeBarNbContraintes = new System.Windows.Forms.TrackBar();
            this.lblValueNbContraintes = new System.Windows.Forms.Label();
            this.lblValueNbVariables = new System.Windows.Forms.Label();
            this.rangeBarNbVariables = new System.Windows.Forms.TrackBar();
            this.lblNbVariables = new System.Windows.Forms.Label();
            this.tableauFoncEconom = new System.Windows.Forms.DataGridView();
            this.lblFEconomique = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbContraintes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauFoncEconom)).BeginInit();
            this.SuspendLayout();
            // 
            // radioMin
            // 
            this.radioMin.AutoSize = true;
            this.radioMin.Location = new System.Drawing.Point(642, 59);
            this.radioMin.Name = "radioMin";
            this.radioMin.Size = new System.Drawing.Size(63, 21);
            this.radioMin.TabIndex = 2;
            this.radioMin.TabStop = true;
            this.radioMin.Text = "Min ?";
            this.radioMin.UseVisualStyleBackColor = true;
            // 
            // radioMax
            // 
            this.radioMax.AutoSize = true;
            this.radioMax.Location = new System.Drawing.Point(726, 59);
            this.radioMax.Name = "radioMax";
            this.radioMax.Size = new System.Drawing.Size(66, 21);
            this.radioMax.TabIndex = 3;
            this.radioMax.TabStop = true;
            this.radioMax.Text = "Max ?";
            this.radioMax.UseVisualStyleBackColor = true;
            // 
            // lblNbContraintes
            // 
            this.lblNbContraintes.AutoSize = true;
            this.lblNbContraintes.Location = new System.Drawing.Point(12, 26);
            this.lblNbContraintes.Name = "lblNbContraintes";
            this.lblNbContraintes.Size = new System.Drawing.Size(100, 17);
            this.lblNbContraintes.TabIndex = 4;
            this.lblNbContraintes.Text = "nb Contraintes";
            // 
            // rangeBarNbContraintes
            // 
            this.rangeBarNbContraintes.Location = new System.Drawing.Point(118, 26);
            this.rangeBarNbContraintes.Minimum = 2;
            this.rangeBarNbContraintes.Name = "rangeBarNbContraintes";
            this.rangeBarNbContraintes.Size = new System.Drawing.Size(497, 56);
            this.rangeBarNbContraintes.TabIndex = 5;
            this.rangeBarNbContraintes.Value = 2;
            this.rangeBarNbContraintes.ValueChanged += new System.EventHandler(this.RangeBarNbContraintes_ValueChanged);
            // 
            // lblValueNbContraintes
            // 
            this.lblValueNbContraintes.AutoSize = true;
            this.lblValueNbContraintes.Location = new System.Drawing.Point(350, 15);
            this.lblValueNbContraintes.Name = "lblValueNbContraintes";
            this.lblValueNbContraintes.Size = new System.Drawing.Size(42, 17);
            this.lblValueNbContraintes.TabIndex = 6;
            this.lblValueNbContraintes.Text = "value";
            // 
            // lblValueNbVariables
            // 
            this.lblValueNbVariables.AutoSize = true;
            this.lblValueNbVariables.Location = new System.Drawing.Point(350, 77);
            this.lblValueNbVariables.Name = "lblValueNbVariables";
            this.lblValueNbVariables.Size = new System.Drawing.Size(42, 17);
            this.lblValueNbVariables.TabIndex = 9;
            this.lblValueNbVariables.Text = "value";
            // 
            // rangeBarNbVariables
            // 
            this.rangeBarNbVariables.Location = new System.Drawing.Point(118, 88);
            this.rangeBarNbVariables.Minimum = 2;
            this.rangeBarNbVariables.Name = "rangeBarNbVariables";
            this.rangeBarNbVariables.Size = new System.Drawing.Size(497, 56);
            this.rangeBarNbVariables.TabIndex = 8;
            this.rangeBarNbVariables.Value = 2;
            this.rangeBarNbVariables.ValueChanged += new System.EventHandler(this.RangeBarNbVariables_ValueChanged);
            // 
            // lblNbVariables
            // 
            this.lblNbVariables.AutoSize = true;
            this.lblNbVariables.Location = new System.Drawing.Point(25, 88);
            this.lblNbVariables.Name = "lblNbVariables";
            this.lblNbVariables.Size = new System.Drawing.Size(87, 17);
            this.lblNbVariables.TabIndex = 7;
            this.lblNbVariables.Text = "nb Variables";
            // 
            // tableauFoncEconom
            // 
            this.tableauFoncEconom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauFoncEconom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableauFoncEconom.Location = new System.Drawing.Point(12, 168);
            this.tableauFoncEconom.Name = "tableauFoncEconom";
            this.tableauFoncEconom.RowHeadersWidth = 51;
            this.tableauFoncEconom.RowTemplate.Height = 24;
            this.tableauFoncEconom.Size = new System.Drawing.Size(780, 172);
            this.tableauFoncEconom.TabIndex = 10;
            // 
            // lblFEconomique
            // 
            this.lblFEconomique.AutoSize = true;
            this.lblFEconomique.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEconomique.Location = new System.Drawing.Point(12, 147);
            this.lblFEconomique.Name = "lblFEconomique";
            this.lblFEconomique.Size = new System.Drawing.Size(163, 17);
            this.lblFEconomique.TabIndex = 11;
            this.lblFEconomique.Text = "Fonction Économique";
            // 
            // fSimplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 559);
            this.Controls.Add(this.lblFEconomique);
            this.Controls.Add(this.tableauFoncEconom);
            this.Controls.Add(this.lblValueNbVariables);
            this.Controls.Add(this.rangeBarNbVariables);
            this.Controls.Add(this.lblNbVariables);
            this.Controls.Add(this.lblValueNbContraintes);
            this.Controls.Add(this.rangeBarNbContraintes);
            this.Controls.Add(this.lblNbContraintes);
            this.Controls.Add(this.radioMax);
            this.Controls.Add(this.radioMin);
            this.Name = "fSimplex";
            this.Text = "Algo Simplex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbContraintes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauFoncEconom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioMin;
        private System.Windows.Forms.RadioButton radioMax;
        private System.Windows.Forms.Label lblNbContraintes;
        private System.Windows.Forms.TrackBar rangeBarNbContraintes;
        private System.Windows.Forms.Label lblValueNbContraintes;
        private System.Windows.Forms.Label lblValueNbVariables;
        private System.Windows.Forms.TrackBar rangeBarNbVariables;
        private System.Windows.Forms.Label lblNbVariables;
        private System.Windows.Forms.DataGridView tableauFoncEconom;
        private System.Windows.Forms.Label lblFEconomique;
    }
}

