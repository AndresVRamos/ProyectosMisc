namespace VistaMatematicca
{
    partial class frmOperacionesAritmeticas
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.cbxArreglo = new System.Windows.Forms.CheckBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(239, 95);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 40);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(24, 45);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 1;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(21, 25);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(41, 17);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Valor";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(21, 81);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(41, 17);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "Valor";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(24, 101);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 3;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(24, 185);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 40);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // cbxArreglo
            // 
            this.cbxArreglo.AutoSize = true;
            this.cbxArreglo.Location = new System.Drawing.Point(239, 46);
            this.cbxArreglo.Name = "cbxArreglo";
            this.cbxArreglo.Size = new System.Drawing.Size(134, 21);
            this.cbxArreglo.TabIndex = 7;
            this.cbxArreglo.Text = "Lista de Número";
            this.cbxArreglo.UseVisualStyleBackColor = true;
            this.cbxArreglo.CheckedChanged += new System.EventHandler(this.cbxArreglo_CheckedChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(239, 163);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(48, 17);
            this.lblContador.TabIndex = 8;
            this.lblContador.Text = "1 de 1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(239, 208);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(34, 17);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "R = ";
            // 
            // frmOperacionesAritmeticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 260);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cbxArreglo);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "frmOperacionesAritmeticas";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.frmOperacionesAritmeticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.CheckBox cbxArreglo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblResultado;
    }
}