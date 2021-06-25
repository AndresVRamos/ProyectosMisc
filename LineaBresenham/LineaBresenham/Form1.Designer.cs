namespace LineaBresenham
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
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.pbxArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(29, 11);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(106, 20);
            this.txtX1.TabIndex = 0;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(29, 63);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(106, 20);
            this.txtX2.TabIndex = 2;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(29, 37);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(106, 20);
            this.txtY1.TabIndex = 1;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(29, 89);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(106, 20);
            this.txtY2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "y1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "y2";
            // 
            // btnDibujar
            // 
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDibujar.Location = new System.Drawing.Point(8, 115);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(127, 37);
            this.btnDibujar.TabIndex = 4;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // pbxArea
            // 
            this.pbxArea.BackColor = System.Drawing.Color.White;
            this.pbxArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxArea.Location = new System.Drawing.Point(141, 11);
            this.pbxArea.Name = "pbxArea";
            this.pbxArea.Size = new System.Drawing.Size(652, 428);
            this.pbxArea.TabIndex = 9;
            this.pbxArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxArea);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Línea de Bresenham";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox pbxArea;
    }
}

