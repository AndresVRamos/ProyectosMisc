namespace VistaMatematica
{
    partial class OpGeometricasCirculo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxValorB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxValorA = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Altura";
            // 
            // txtbxValorB
            // 
            this.txtbxValorB.Location = new System.Drawing.Point(15, 84);
            this.txtbxValorB.Name = "txtbxValorB";
            this.txtbxValorB.Size = new System.Drawing.Size(141, 22);
            this.txtbxValorB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Radio";
            // 
            // txtbxValorA
            // 
            this.txtbxValorA.Location = new System.Drawing.Point(15, 29);
            this.txtbxValorA.Name = "txtbxValorA";
            this.txtbxValorA.Size = new System.Drawing.Size(141, 22);
            this.txtbxValorA.TabIndex = 6;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(198, 28);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(107, 37);
            this.btnArea.TabIndex = 11;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(198, 112);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(107, 37);
            this.btnPerimetro.TabIndex = 12;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            // 
            // btnVolumen
            // 
            this.btnVolumen.Location = new System.Drawing.Point(198, 69);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(107, 37);
            this.btnVolumen.TabIndex = 13;
            this.btnVolumen.Text = "Volumen";
            this.btnVolumen.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 132);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(80, 17);
            this.lblResultado.TabIndex = 14;
            this.lblResultado.Text = "Resultado: ";
            // 
            // OpGeometricasCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 189);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxValorB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxValorA);
            this.Name = "OpGeometricasCirculo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxValorB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxValorA;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Label lblResultado;
    }
}