namespace VideoClub
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRenta = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(149, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "BIENVENIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::VideoClub.Properties.Resources.files_manager_history_10109__1_;
            this.button1.Location = new System.Drawing.Point(405, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 354);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registros Generales";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRenta
            // 
            this.btnRenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRenta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRenta.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRenta.Image")));
            this.btnRenta.Location = new System.Drawing.Point(211, 273);
            this.btnRenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRenta.Name = "btnRenta";
            this.btnRenta.Size = new System.Drawing.Size(188, 174);
            this.btnRenta.TabIndex = 3;
            this.btnRenta.Text = "Renta";
            this.btnRenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenta.UseVisualStyleBackColor = false;
            this.btnRenta.Click += new System.EventHandler(this.btnRenta_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleado.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.Location = new System.Drawing.Point(211, 94);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(188, 174);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCliente.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(17, 273);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente.MaximumSize = new System.Drawing.Size(188, 174);
            this.btnCliente.MinimumSize = new System.Drawing.Size(188, 174);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(188, 174);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPeliculas.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPeliculas.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculas.Image")));
            this.btnPeliculas.Location = new System.Drawing.Point(17, 94);
            this.btnPeliculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(188, 174);
            this.btnPeliculas.TabIndex = 0;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(523, 13);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 28);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoClub.Properties.Resources._51U5MvmtXGL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 475);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenta);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPeliculas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(629, 512);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Club";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnRenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}

