namespace pryCalvar_20250509
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboClubes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFotosClub = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosClub)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClubes
            // 
            this.cboClubes.FormattingEnabled = true;
            this.cboClubes.Location = new System.Drawing.Point(28, 29);
            this.cboClubes.Name = "cboClubes";
            this.cboClubes.Size = new System.Drawing.Size(121, 21);
            this.cboClubes.TabIndex = 0;
            this.cboClubes.SelectedIndexChanged += new System.EventHandler(this.cboClubes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clubes";
            // 
            // pbFotosClub
            // 
            this.pbFotosClub.Location = new System.Drawing.Point(28, 78);
            this.pbFotosClub.Name = "pbFotosClub";
            this.pbFotosClub.Size = new System.Drawing.Size(443, 360);
            this.pbFotosClub.TabIndex = 2;
            this.pbFotosClub.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.pbFotosClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClubes);
            this.Name = "Form1";
            this.Text = "Elecciòn";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClubes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFotosClub;
    }
}

