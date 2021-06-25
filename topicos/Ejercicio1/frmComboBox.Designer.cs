namespace Ejercicio1
{
    partial class frmComboBox
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
            this.cbxCiudades2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxCiudades2
            // 
            this.cbxCiudades2.FormattingEnabled = true;
            this.cbxCiudades2.Location = new System.Drawing.Point(46, 39);
            this.cbxCiudades2.Name = "cbxCiudades2";
            this.cbxCiudades2.Size = new System.Drawing.Size(264, 24);
            this.cbxCiudades2.TabIndex = 0;
            this.cbxCiudades2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.cbxCiudades2);
            this.Name = "frmComboBox";
            this.Text = "Combo Box";
            this.Load += new System.EventHandler(this.frmComboBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCiudades2;
    }
}