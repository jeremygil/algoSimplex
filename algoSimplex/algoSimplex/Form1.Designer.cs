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
            this.tableauContraintes = new System.Windows.Forms.DataGridView();
            this.lblContraintes = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.tableauZ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbContraintes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauContraintes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauZ)).BeginInit();
            this.SuspendLayout();
            // 
            // radioMin
            // 
            this.radioMin.AutoSize = true;
            this.radioMin.Location = new System.Drawing.Point(485, 41);
            this.radioMin.Margin = new System.Windows.Forms.Padding(2);
            this.radioMin.Name = "radioMin";
            this.radioMin.Size = new System.Drawing.Size(51, 17);
            this.radioMin.TabIndex = 2;
            this.radioMin.TabStop = true;
            this.radioMin.Text = "Min ?";
            this.radioMin.UseVisualStyleBackColor = true;
            // 
            // radioMax
            // 
            this.radioMax.AutoSize = true;
            this.radioMax.Location = new System.Drawing.Point(547, 41);
            this.radioMax.Margin = new System.Windows.Forms.Padding(2);
            this.radioMax.Name = "radioMax";
            this.radioMax.Size = new System.Drawing.Size(54, 17);
            this.radioMax.TabIndex = 3;
            this.radioMax.TabStop = true;
            this.radioMax.Text = "Max ?";
            this.radioMax.UseVisualStyleBackColor = true;
            // 
            // lblNbContraintes
            // 
            this.lblNbContraintes.AutoSize = true;
            this.lblNbContraintes.Location = new System.Drawing.Point(12, 14);
            this.lblNbContraintes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbContraintes.Name = "lblNbContraintes";
            this.lblNbContraintes.Size = new System.Drawing.Size(75, 13);
            this.lblNbContraintes.TabIndex = 4;
            this.lblNbContraintes.Text = "nb Contraintes";
            // 
            // rangeBarNbContraintes
            // 
            this.rangeBarNbContraintes.Location = new System.Drawing.Point(91, 14);
            this.rangeBarNbContraintes.Margin = new System.Windows.Forms.Padding(2);
            this.rangeBarNbContraintes.Minimum = 2;
            this.rangeBarNbContraintes.Name = "rangeBarNbContraintes";
            this.rangeBarNbContraintes.Size = new System.Drawing.Size(373, 45);
            this.rangeBarNbContraintes.TabIndex = 5;
            this.rangeBarNbContraintes.Value = 2;
            this.rangeBarNbContraintes.ValueChanged += new System.EventHandler(this.RangeBarNbContraintes_ValueChanged);
            // 
            // lblValueNbContraintes
            // 
            this.lblValueNbContraintes.AutoSize = true;
            this.lblValueNbContraintes.Location = new System.Drawing.Point(265, 6);
            this.lblValueNbContraintes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueNbContraintes.Name = "lblValueNbContraintes";
            this.lblValueNbContraintes.Size = new System.Drawing.Size(33, 13);
            this.lblValueNbContraintes.TabIndex = 6;
            this.lblValueNbContraintes.Text = "value";
            // 
            // lblValueNbVariables
            // 
            this.lblValueNbVariables.AutoSize = true;
            this.lblValueNbVariables.Location = new System.Drawing.Point(265, 56);
            this.lblValueNbVariables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValueNbVariables.Name = "lblValueNbVariables";
            this.lblValueNbVariables.Size = new System.Drawing.Size(33, 13);
            this.lblValueNbVariables.TabIndex = 9;
            this.lblValueNbVariables.Text = "value";
            // 
            // rangeBarNbVariables
            // 
            this.rangeBarNbVariables.Location = new System.Drawing.Point(91, 65);
            this.rangeBarNbVariables.Margin = new System.Windows.Forms.Padding(2);
            this.rangeBarNbVariables.Minimum = 2;
            this.rangeBarNbVariables.Name = "rangeBarNbVariables";
            this.rangeBarNbVariables.Size = new System.Drawing.Size(373, 45);
            this.rangeBarNbVariables.TabIndex = 8;
            this.rangeBarNbVariables.Value = 2;
            this.rangeBarNbVariables.ValueChanged += new System.EventHandler(this.RangeBarNbVariables_ValueChanged);
            // 
            // lblNbVariables
            // 
            this.lblNbVariables.AutoSize = true;
            this.lblNbVariables.Location = new System.Drawing.Point(22, 65);
            this.lblNbVariables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbVariables.Name = "lblNbVariables";
            this.lblNbVariables.Size = new System.Drawing.Size(65, 13);
            this.lblNbVariables.TabIndex = 7;
            this.lblNbVariables.Text = "nb Variables";
            // 
            // tableauContraintes
            // 
            this.tableauContraintes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauContraintes.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableauContraintes.Location = new System.Drawing.Point(21, 195);
            this.tableauContraintes.Margin = new System.Windows.Forms.Padding(2);
            this.tableauContraintes.Name = "tableauContraintes";
            this.tableauContraintes.RowHeadersWidth = 51;
            this.tableauContraintes.RowTemplate.Height = 24;
            this.tableauContraintes.Size = new System.Drawing.Size(585, 140);
            this.tableauContraintes.TabIndex = 10;
            // 
            // lblContraintes
            // 
            this.lblContraintes.AutoSize = true;
            this.lblContraintes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraintes.Location = new System.Drawing.Point(22, 180);
            this.lblContraintes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraintes.Name = "lblContraintes";
            this.lblContraintes.Size = new System.Drawing.Size(71, 13);
            this.lblContraintes.TabIndex = 11;
            this.lblContraintes.Text = "Contraintes";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(22, 97);
            this.lblZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(15, 13);
            this.lblZ.TabIndex = 12;
            this.lblZ.Text = "Z";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(550, 360);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(56, 19);
            this.btnResult.TabIndex = 14;
            this.btnResult.Text = "Résultat";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // tableauZ
            // 
            this.tableauZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauZ.Location = new System.Drawing.Point(21, 113);
            this.tableauZ.Name = "tableauZ";
            this.tableauZ.Size = new System.Drawing.Size(585, 56);
            this.tableauZ.TabIndex = 15;
            // 
            // FSimplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 391);
            this.Controls.Add(this.tableauZ);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblContraintes);
            this.Controls.Add(this.tableauContraintes);
            this.Controls.Add(this.lblValueNbVariables);
            this.Controls.Add(this.rangeBarNbVariables);
            this.Controls.Add(this.lblNbVariables);
            this.Controls.Add(this.lblValueNbContraintes);
            this.Controls.Add(this.rangeBarNbContraintes);
            this.Controls.Add(this.lblNbContraintes);
            this.Controls.Add(this.radioMax);
            this.Controls.Add(this.radioMin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSimplex";
            this.Text = "Algo Simplex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbContraintes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeBarNbVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauContraintes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableauZ)).EndInit();
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
        private System.Windows.Forms.DataGridView tableauContraintes;
        private System.Windows.Forms.Label lblContraintes;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.DataGridView tableauZ;
    }
}

