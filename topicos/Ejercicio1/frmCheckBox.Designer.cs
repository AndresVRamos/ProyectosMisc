namespace Ejercicio1
{
    partial class frmCheckBox
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
            this.nudTamano = new System.Windows.Forms.NumericUpDown();
            this.lblResultado = new System.Windows.Forms.Label();
            this.stsBarraButton = new System.Windows.Forms.StatusStrip();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbxNegritas = new System.Windows.Forms.CheckBox();
            this.cbxCursivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamano)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTamano
            // 
            this.nudTamano.Location = new System.Drawing.Point(61, 82);
            this.nudTamano.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTamano.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamano.Name = "nudTamano";
            this.nudTamano.Size = new System.Drawing.Size(120, 22);
            this.nudTamano.TabIndex = 4;
            this.nudTamano.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudTamano.ValueChanged += new System.EventHandler(this.nudTamano_ValueChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(209, 33);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(81, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Hello World";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // stsBarraButton
            // 
            this.stsBarraButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBarraButton.Location = new System.Drawing.Point(0, 196);
            this.stsBarraButton.Name = "stsBarraButton";
            this.stsBarraButton.Size = new System.Drawing.Size(476, 22);
            this.stsBarraButton.TabIndex = 6;
            this.stsBarraButton.Text = "statusStrip1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(199, 131);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 31);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Cerrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbxNegritas
            // 
            this.cbxNegritas.AutoSize = true;
            this.cbxNegritas.Location = new System.Drawing.Point(208, 82);
            this.cbxNegritas.Name = "cbxNegritas";
            this.cbxNegritas.Size = new System.Drawing.Size(83, 21);
            this.cbxNegritas.TabIndex = 9;
            this.cbxNegritas.Text = "Negritas";
            this.cbxNegritas.UseVisualStyleBackColor = true;
            this.cbxNegritas.CheckedChanged += new System.EventHandler(this.cbxNegritas_CheckedChanged);
            // 
            // cbxCursivo
            // 
            this.cbxCursivo.AutoSize = true;
            this.cbxCursivo.Location = new System.Drawing.Point(339, 82);
            this.cbxCursivo.Name = "cbxCursivo";
            this.cbxCursivo.Size = new System.Drawing.Size(77, 21);
            this.cbxCursivo.TabIndex = 8;
            this.cbxCursivo.Text = "Cursivo";
            this.cbxCursivo.UseVisualStyleBackColor = true;
            this.cbxCursivo.CheckedChanged += new System.EventHandler(this.cbxCursivo_CheckedChanged);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 218);
            this.Controls.Add(this.cbxNegritas);
            this.Controls.Add(this.cbxCursivo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.stsBarraButton);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.nudTamano);
            this.Name = "frmCheckBox";
            this.Text = "Check Box";
            this.Load += new System.EventHandler(this.frmCheckBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTamano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudTamano;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.StatusStrip stsBarraButton;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox cbxNegritas;
        private System.Windows.Forms.CheckBox cbxCursivo;
    }
}