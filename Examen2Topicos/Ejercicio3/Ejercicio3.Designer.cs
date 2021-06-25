namespace Ejercicio3
{
    partial class Ejercicio3
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
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.lbxAutos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.ForeColor = System.Drawing.Color.Red;
            this.lblModificar.Location = new System.Drawing.Point(334, 157);
            this.lblModificar.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(0, 17);
            this.lblModificar.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(219, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 47);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(219, 142);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 47);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(219, 86);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 47);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.Location = new System.Drawing.Point(219, 32);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(248, 22);
            this.txtNombreAuto.TabIndex = 7;
            // 
            // lbxAutos
            // 
            this.lbxAutos.FormattingEnabled = true;
            this.lbxAutos.ItemHeight = 16;
            this.lbxAutos.Location = new System.Drawing.Point(12, 12);
            this.lbxAutos.Name = "lbxAutos";
            this.lbxAutos.Size = new System.Drawing.Size(201, 420);
            this.lbxAutos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agregue sus automoviles preferidos";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreAuto);
            this.Controls.Add(this.lbxAutos);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.ListBox lbxAutos;
        private System.Windows.Forms.Label label1;
    }
}

