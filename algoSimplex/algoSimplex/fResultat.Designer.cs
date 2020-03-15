namespace algoSimplex
{
    partial class FResultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataResult = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResult
            // 
            this.dataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResult.Location = new System.Drawing.Point(12, 22);
            this.dataResult.Name = "dataResult";
            this.dataResult.RowHeadersWidth = 51;
            this.dataResult.RowTemplate.Height = 24;
            this.dataResult.Size = new System.Drawing.Size(776, 271);
            this.dataResult.TabIndex = 0;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(713, 302);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // FResultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dataResult);
            this.Name = "FResultat";
            this.Text = "fResultat";
            this.Load += new System.EventHandler(this.FResultat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResult;
        private System.Windows.Forms.Button btnRetour;
    }
}