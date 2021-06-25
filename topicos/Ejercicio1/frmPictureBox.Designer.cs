namespace Ejercicio1
{
    partial class frmPictureBox
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
            this.pbxFotos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFotos
            // 
            this.pbxFotos.Location = new System.Drawing.Point(18, 15);
            this.pbxFotos.Name = "pbxFotos";
            this.pbxFotos.Size = new System.Drawing.Size(458, 312);
            this.pbxFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxFotos.TabIndex = 0;
            this.pbxFotos.TabStop = false;
            this.pbxFotos.Click += new System.EventHandler(this.pbxFotos_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.pbxFotos);
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            this.Load += new System.EventHandler(this.frmPictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFotos;
    }
}