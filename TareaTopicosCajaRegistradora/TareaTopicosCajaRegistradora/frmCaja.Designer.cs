namespace TareaTopicosCajaRegistradora
{
    partial class Caja
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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lbxProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblSobrante = new System.Windows.Forms.Label();
            this.lbxPrecios = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.cbxTarjeta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(15, 40);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(117, 22);
            this.txtProducto.TabIndex = 0;
            // 
            // lbxProductos
            // 
            this.lbxProductos.FormattingEnabled = true;
            this.lbxProductos.ItemHeight = 16;
            this.lbxProductos.Location = new System.Drawing.Point(281, 20);
            this.lbxProductos.Name = "lbxProductos";
            this.lbxProductos.Size = new System.Drawing.Size(144, 196);
            this.lbxProductos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad Pagada";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(146, 40);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(117, 22);
            this.txtCosto.TabIndex = 1;
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(15, 187);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(117, 22);
            this.txtMontoPagado.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(146, 68);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(146, 184);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(117, 28);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblSobrante
            // 
            this.lblSobrante.AutoSize = true;
            this.lblSobrante.Location = new System.Drawing.Point(278, 292);
            this.lblSobrante.Name = "lblSobrante";
            this.lblSobrante.Size = new System.Drawing.Size(74, 17);
            this.lblSobrante.TabIndex = 11;
            this.lblSobrante.Text = "Sobrante: ";
            this.lblSobrante.Click += new System.EventHandler(this.lblSobrante_Click);
            // 
            // lbxPrecios
            // 
            this.lbxPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxPrecios.FormattingEnabled = true;
            this.lbxPrecios.ItemHeight = 16;
            this.lbxPrecios.Location = new System.Drawing.Point(383, 22);
            this.lbxPrecios.Name = "lbxPrecios";
            this.lbxPrecios.Size = new System.Drawing.Size(41, 192);
            this.lbxPrecios.TabIndex = 12;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(278, 219);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 17);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(278, 267);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 17);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total: ";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(278, 242);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(37, 17);
            this.lblIVA.TabIndex = 15;
            this.lblIVA.Text = "IVA: ";
            // 
            // cbxTarjeta
            // 
            this.cbxTarjeta.AutoSize = true;
            this.cbxTarjeta.Location = new System.Drawing.Point(15, 219);
            this.cbxTarjeta.Name = "cbxTarjeta";
            this.cbxTarjeta.Size = new System.Drawing.Size(75, 21);
            this.cbxTarjeta.TabIndex = 16;
            this.cbxTarjeta.Text = "Tarjeta";
            this.cbxTarjeta.UseVisualStyleBackColor = true;
            this.cbxTarjeta.CheckedChanged += new System.EventHandler(this.cbxTarjeta_CheckedChanged);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 328);
            this.Controls.Add(this.cbxTarjeta);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lbxPrecios);
            this.Controls.Add(this.lblSobrante);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMontoPagado);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProductos);
            this.Controls.Add(this.txtProducto);
            this.Name = "Caja";
            this.Text = "Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ListBox lbxProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblSobrante;
        private System.Windows.Forms.ListBox lbxPrecios;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.CheckBox cbxTarjeta;
    }
}

