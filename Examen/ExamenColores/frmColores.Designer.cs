namespace ExamenColores
{
    partial class frmColores
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
            this.pbxCuadro1 = new System.Windows.Forms.PictureBox();
            this.pbxCuadro2 = new System.Windows.Forms.PictureBox();
            this.pbxCuadro3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCuadro1
            // 
            this.pbxCuadro1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCuadro1.Location = new System.Drawing.Point(16, 13);
            this.pbxCuadro1.Name = "pbxCuadro1";
            this.pbxCuadro1.Size = new System.Drawing.Size(233, 300);
            this.pbxCuadro1.TabIndex = 0;
            this.pbxCuadro1.TabStop = false;
            this.pbxCuadro1.MouseEnter += new System.EventHandler(this.pbxCuadro1_MouseEnter);
            // 
            // pbxCuadro2
            // 
            this.pbxCuadro2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCuadro2.Location = new System.Drawing.Point(271, 13);
            this.pbxCuadro2.Name = "pbxCuadro2";
            this.pbxCuadro2.Size = new System.Drawing.Size(233, 300);
            this.pbxCuadro2.TabIndex = 1;
            this.pbxCuadro2.TabStop = false;
            this.pbxCuadro2.MouseEnter += new System.EventHandler(this.pbxCuadro2_MouseEnter);
            // 
            // pbxCuadro3
            // 
            this.pbxCuadro3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCuadro3.Location = new System.Drawing.Point(526, 13);
            this.pbxCuadro3.Name = "pbxCuadro3";
            this.pbxCuadro3.Size = new System.Drawing.Size(233, 300);
            this.pbxCuadro3.TabIndex = 2;
            this.pbxCuadro3.TabStop = false;
            this.pbxCuadro3.MouseEnter += new System.EventHandler(this.pbxCuadro3_MouseEnter);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 326);
            this.Controls.Add(this.pbxCuadro3);
            this.Controls.Add(this.pbxCuadro2);
            this.Controls.Add(this.pbxCuadro1);
            this.Name = "frmColores";
            this.Text = "Colores";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCuadro1;
        private System.Windows.Forms.PictureBox pbxCuadro2;
        private System.Windows.Forms.PictureBox pbxCuadro3;
    }
}

