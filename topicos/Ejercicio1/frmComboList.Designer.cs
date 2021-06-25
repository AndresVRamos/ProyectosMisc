namespace Ejercicio1
{
    partial class frmComboList
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
            this.cbxCiudades = new System.Windows.Forms.ComboBox();
            this.lbxCiudadesLista = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCiudades
            // 
            this.cbxCiudades.FormattingEnabled = true;
            this.cbxCiudades.Location = new System.Drawing.Point(32, 29);
            this.cbxCiudades.Name = "cbxCiudades";
            this.cbxCiudades.Size = new System.Drawing.Size(121, 24);
            this.cbxCiudades.TabIndex = 0;
            this.cbxCiudades.SelectedIndexChanged += new System.EventHandler(this.cbxCiudades_SelectedIndexChanged);
            this.cbxCiudades.SizeChanged += new System.EventHandler(this.cbxCiudades_SizeChanged);
            // 
            // lbxCiudadesLista
            // 
            this.lbxCiudadesLista.FormattingEnabled = true;
            this.lbxCiudadesLista.ItemHeight = 16;
            this.lbxCiudadesLista.Location = new System.Drawing.Point(238, 29);
            this.lbxCiudadesLista.Name = "lbxCiudadesLista";
            this.lbxCiudadesLista.Size = new System.Drawing.Size(120, 276);
            this.lbxCiudadesLista.TabIndex = 1;
            this.lbxCiudadesLista.SelectedIndexChanged += new System.EventHandler(this.lbxCiudadesLista_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(32, 138);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(121, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(32, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmComboList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 334);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lbxCiudadesLista);
            this.Controls.Add(this.cbxCiudades);
            this.Name = "frmComboList";
            this.Text = "Combo List";
            this.Load += new System.EventHandler(this.frmComboList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCiudades;
        private System.Windows.Forms.ListBox lbxCiudadesLista;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAgregar;
    }
}