namespace algoSimplex
{
    partial class FSimplex
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
            this.lblZ = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbContraintes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauFoncEconom)).BeginInit();
            this.SuspendLayout();
            // 
            // radioMin
            // 
            this.radioMin.AutoSize = true;
            this.radioMin.Location = new System.Drawing.Point(658, 132);
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
            this.radioMax.Location = new System.Drawing.Point(742, 132);
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
            this.lblNbContraintes.Location = new System.Drawing.Point(28, 99);
            this.lblNbContraintes.Name = "lblNbContraintes";
            this.lblNbContraintes.Size = new System.Drawing.Size(100, 17);
            this.lblNbContraintes.TabIndex = 4;
            this.lblNbContraintes.Text = "nb Contraintes";
            // 
            // rangeBarNbContraintes
            // 
            this.rangeBarNbContraintes.Location = new System.Drawing.Point(134, 99);
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
            this.lblValueNbContraintes.Location = new System.Drawing.Point(366, 88);
            this.lblValueNbContraintes.Name = "lblValueNbContraintes";
            this.lblValueNbContraintes.Size = new System.Drawing.Size(42, 17);
            this.lblValueNbContraintes.TabIndex = 6;
            this.lblValueNbContraintes.Text = "value";
            // 
            // lblValueNbVariables
            // 
            this.lblValueNbVariables.AutoSize = true;
            this.lblValueNbVariables.Location = new System.Drawing.Point(366, 150);
            this.lblValueNbVariables.Name = "lblValueNbVariables";
            this.lblValueNbVariables.Size = new System.Drawing.Size(42, 17);
            this.lblValueNbVariables.TabIndex = 9;
            this.lblValueNbVariables.Text = "value";
            // 
            // rangeBarNbVariables
            // 
            this.rangeBarNbVariables.Location = new System.Drawing.Point(134, 161);
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
            this.lblNbVariables.Location = new System.Drawing.Point(41, 161);
            this.lblNbVariables.Name = "lblNbVariables";
            this.lblNbVariables.Size = new System.Drawing.Size(87, 17);
            this.lblNbVariables.TabIndex = 7;
            this.lblNbVariables.Text = "nb Variables";
            // 
            // tableauFoncEconom
            // 
            this.tableauFoncEconom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauFoncEconom.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableauFoncEconom.Location = new System.Drawing.Point(28, 240);
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
            this.lblFEconomique.Location = new System.Drawing.Point(28, 220);
            this.lblFEconomique.Name = "lblFEconomique";
            this.lblFEconomique.Size = new System.Drawing.Size(163, 17);
            this.lblFEconomique.TabIndex = 11;
            this.lblFEconomique.Text = "Fonction Économique";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(98, 30);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 17);
            this.lblZ.TabIndex = 12;
            this.lblZ.Text = "Z";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(134, 27);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(497, 22);
            this.txtZ.TabIndex = 13;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(733, 443);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 14;
            this.btnResult.Text = "Résultat";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // FSimplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.lblZ);
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
            this.Name = "FSimplex";
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
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Button btnResult;
    }
}

