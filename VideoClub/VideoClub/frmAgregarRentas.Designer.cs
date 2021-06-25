namespace VideoClub
{
    partial class frmAgregarRentas
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
            this.components = new System.ComponentModel.Container();
            this.lblDiaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPelicula = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTerminado = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRentaRegistrada = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblPrecioNeto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentaRegistrada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDiaHora
            // 
            this.lblDiaHora.AutoSize = true;
            this.lblDiaHora.Location = new System.Drawing.Point(12, 416);
            this.lblDiaHora.Name = "lblDiaHora";
            this.lblDiaHora.Size = new System.Drawing.Size(43, 17);
            this.lblDiaHora.TabIndex = 9;
            this.lblDiaHora.Text = "fecha";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(25, 53);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(145, 24);
            this.cbxCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de Empleado";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(25, 118);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(145, 24);
            this.cbxEmpleado.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre de Película";
            // 
            // cbxPelicula
            // 
            this.cbxPelicula.FormattingEnabled = true;
            this.cbxPelicula.Location = new System.Drawing.Point(25, 184);
            this.cbxPelicula.Name = "cbxPelicula";
            this.cbxPelicula.Size = new System.Drawing.Size(145, 24);
            this.cbxPelicula.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 223);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 40);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTerminado
            // 
            this.btnTerminado.Location = new System.Drawing.Point(715, 351);
            this.btnTerminado.Name = "btnTerminado";
            this.btnTerminado.Size = new System.Drawing.Size(117, 34);
            this.btnTerminado.TabIndex = 16;
            this.btnTerminado.Text = "Terminado";
            this.btnTerminado.UseVisualStyleBackColor = true;
            this.btnTerminado.Click += new System.EventHandler(this.btnTerminado_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(424, 363);
            this.dtpFechaEntrega.MinDate = new System.DateTime(2021, 5, 11, 21, 38, 16, 0);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(264, 22);
            this.dtpFechaEntrega.TabIndex = 17;
            this.dtpFechaEntrega.Value = new System.DateTime(2021, 5, 11, 21, 38, 16, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de Entrega";
            // 
            // dgvRentaRegistrada
            // 
            this.dgvRentaRegistrada.AllowUserToAddRows = false;
            this.dgvRentaRegistrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentaRegistrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.NombreEmpleado,
            this.NombrePelicula,
            this.Precio});
            this.dgvRentaRegistrada.Location = new System.Drawing.Point(189, 33);
            this.dgvRentaRegistrada.Name = "dgvRentaRegistrada";
            this.dgvRentaRegistrada.RowHeadersWidth = 51;
            this.dgvRentaRegistrada.RowTemplate.Height = 24;
            this.dgvRentaRegistrada.Size = new System.Drawing.Size(643, 240);
            this.dgvRentaRegistrada.TabIndex = 19;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 125;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "Nombre de Empleado";
            this.NombreEmpleado.MinimumWidth = 6;
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.Width = 125;
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.HeaderText = "Nombre de Película";
            this.NombrePelicula.MinimumWidth = 6;
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lblPrecioNeto);
            this.groupBox1.Controls.Add(this.lblPrecioTotal);
            this.groupBox1.Controls.Add(this.dgvRentaRegistrada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaEntrega);
            this.groupBox1.Controls.Add(this.btnTerminado);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cbxPelicula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 401);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Renta";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(622, 299);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(100, 17);
            this.lblPrecioTotal.TabIndex = 20;
            this.lblPrecioTotal.Text = "Precio Total: 0";
            // 
            // lblPrecioNeto
            // 
            this.lblPrecioNeto.AutoSize = true;
            this.lblPrecioNeto.Location = new System.Drawing.Point(622, 276);
            this.lblPrecioNeto.Name = "lblPrecioNeto";
            this.lblPrecioNeto.Size = new System.Drawing.Size(98, 17);
            this.lblPrecioNeto.TabIndex = 21;
            this.lblPrecioNeto.Text = "Precio Neto: 0";
            // 
            // frmAgregarRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(875, 442);
            this.Controls.Add(this.lblDiaHora);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregarRentas";
            this.Text = "AgregarRentas";
            this.Load += new System.EventHandler(this.AgregarRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentaRegistrada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPelicula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnTerminado;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRentaRegistrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePelicula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblPrecioNeto;
    }
}