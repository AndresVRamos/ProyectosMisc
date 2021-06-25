namespace Ejercicio1
{
    partial class frmCheckListBox
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
            this.clbHabilidades = new System.Windows.Forms.CheckedListBox();
            this.lbxSeleccion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbHabilidades
            // 
            this.clbHabilidades.FormattingEnabled = true;
            this.clbHabilidades.Items.AddRange(new object[] {
            "Analisis de Requerimientos",
            "Lenguaje C#",
            "Lenguaje Python",
            "MVC",
            "Patrones de Diseño",
            "Base de Datos SQL",
            "Entity Framework",
            "Lenguaje PHP",
            "SCRUM"});
            this.clbHabilidades.Location = new System.Drawing.Point(28, 47);
            this.clbHabilidades.Name = "clbHabilidades";
            this.clbHabilidades.Size = new System.Drawing.Size(152, 259);
            this.clbHabilidades.TabIndex = 0;
            this.clbHabilidades.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbHabilidades_ItemCheck);
            this.clbHabilidades.SelectedIndexChanged += new System.EventHandler(this.clbHabilidades_SelectedIndexChanged);
            // 
            // lbxSeleccion
            // 
            this.lbxSeleccion.FormattingEnabled = true;
            this.lbxSeleccion.ItemHeight = 16;
            this.lbxSeleccion.Location = new System.Drawing.Point(203, 46);
            this.lbxSeleccion.Name = "lbxSeleccion";
            this.lbxSeleccion.Size = new System.Drawing.Size(152, 260);
            this.lbxSeleccion.TabIndex = 1;
            // 
            // frmCheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.lbxSeleccion);
            this.Controls.Add(this.clbHabilidades);
            this.Name = "frmCheckListBox";
            this.Text = "frmCheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbHabilidades;
        private System.Windows.Forms.ListBox lbxSeleccion;
    }
}