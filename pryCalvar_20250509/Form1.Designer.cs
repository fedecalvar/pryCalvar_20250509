namespace pryCalvar_20250509
{
    partial class frmClubs
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numGrandeza = new System.Windows.Forms.NumericUpDown();
            this.numFrio = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosClub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrandeza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboClubes
            // 
            this.cboClubes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.pbFotosClub.Location = new System.Drawing.Point(28, 56);
            this.pbFotosClub.Name = "pbFotosClub";
            this.pbFotosClub.Size = new System.Drawing.Size(317, 225);
            this.pbFotosClub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotosClub.TabIndex = 2;
            this.pbFotosClub.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grandeza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frio";
            // 
            // numGrandeza
            // 
            this.numGrandeza.Location = new System.Drawing.Point(76, 28);
            this.numGrandeza.Name = "numGrandeza";
            this.numGrandeza.Size = new System.Drawing.Size(48, 20);
            this.numGrandeza.TabIndex = 5;
            // 
            // numFrio
            // 
            this.numFrio.Location = new System.Drawing.Point(76, 63);
            this.numFrio.Name = "numFrio";
            this.numFrio.Size = new System.Drawing.Size(48, 20);
            this.numFrio.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(9, 102);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numFrio);
            this.groupBox1.Controls.Add(this.numGrandeza);
            this.groupBox1.Location = new System.Drawing.Point(375, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas";
            // 
            // frmClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbFotosClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClubes);
            this.Name = "frmClubs";
            this.Text = "Elecciòn";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotosClub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrandeza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClubes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFotosClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numGrandeza;
        private System.Windows.Forms.NumericUpDown numFrio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

