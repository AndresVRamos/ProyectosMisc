namespace Ejericio1
{
    partial class Ejercicio1frm
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
            this.pbxCuadro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimerPunto = new System.Windows.Forms.TextBox();
            this.txtSegundoPunto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCuartoPunto = new System.Windows.Forms.TextBox();
            this.txtTercerPunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCuadro
            // 
            this.pbxCuadro.BackColor = System.Drawing.Color.White;
            this.pbxCuadro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCuadro.Location = new System.Drawing.Point(128, 7);
            this.pbxCuadro.Name = "pbxCuadro";
            this.pbxCuadro.Size = new System.Drawing.Size(801, 450);
            this.pbxCuadro.TabIndex = 0;
            this.pbxCuadro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Punto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Punto:";
            // 
            // txtPrimerPunto
            // 
            this.txtPrimerPunto.Location = new System.Drawing.Point(12, 29);
            this.txtPrimerPunto.Name = "txtPrimerPunto";
            this.txtPrimerPunto.Size = new System.Drawing.Size(100, 22);
            this.txtPrimerPunto.TabIndex = 3;
            // 
            // txtSegundoPunto
            // 
            this.txtSegundoPunto.Location = new System.Drawing.Point(12, 74);
            this.txtSegundoPunto.Name = "txtSegundoPunto";
            this.txtSegundoPunto.Size = new System.Drawing.Size(100, 22);
            this.txtSegundoPunto.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 35);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCuartoPunto
            // 
            this.txtCuartoPunto.Location = new System.Drawing.Point(12, 164);
            this.txtCuartoPunto.Name = "txtCuartoPunto";
            this.txtCuartoPunto.Size = new System.Drawing.Size(100, 22);
            this.txtCuartoPunto.TabIndex = 9;
            // 
            // txtTercerPunto
            // 
            this.txtTercerPunto.Location = new System.Drawing.Point(12, 119);
            this.txtTercerPunto.Name = "txtTercerPunto";
            this.txtTercerPunto.Size = new System.Drawing.Size(100, 22);
            this.txtTercerPunto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cuarto Punto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tercer Punto:";
            // 
            // Ejercicio1frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 464);
            this.Controls.Add(this.txtCuartoPunto);
            this.Controls.Add(this.txtTercerPunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtSegundoPunto);
            this.Controls.Add(this.txtPrimerPunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxCuadro);
            this.Name = "Ejercicio1frm";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCuadro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrimerPunto;
        private System.Windows.Forms.TextBox txtSegundoPunto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCuartoPunto;
        private System.Windows.Forms.TextBox txtTercerPunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

