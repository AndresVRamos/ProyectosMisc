namespace VistaMatematica
{
    partial class OpAritmeticasPotencia
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxValorB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxValorA = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(177, 153);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(84, 17);
            this.lblResultado.TabIndex = 27;
            this.lblResultado.Text = "Resultado =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Valor";
            // 
            // txtbxValorB
            // 
            this.txtbxValorB.Location = new System.Drawing.Point(15, 84);
            this.txtbxValorB.Name = "txtbxValorB";
            this.txtbxValorB.Size = new System.Drawing.Size(141, 22);
            this.txtbxValorB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Valor";
            // 
            // txtbxValorA
            // 
            this.txtbxValorA.Location = new System.Drawing.Point(15, 29);
            this.txtbxValorA.Name = "txtbxValorA";
            this.txtbxValorA.Size = new System.Drawing.Size(141, 22);
            this.txtbxValorA.TabIndex = 23;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(15, 131);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(141, 60);
            this.btnResultado.TabIndex = 22;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // OpAritmeticasPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 219);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxValorB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxValorA);
            this.Controls.Add(this.btnResultado);
            this.Name = "OpAritmeticasPotencia";
            this.Text = "Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxValorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxValorA;
        private System.Windows.Forms.Button btnResultado;
    }
}