namespace VideoClub
{
    partial class frmVistaGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaGeneral));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVistaGeneral = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dgvEmpleadosDestacados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientesDestacados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPeliculasPopulares = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFavoritas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosDestacados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDestacados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasPopulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(327, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "Vista General de Rentas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvVistaGeneral
            // 
            this.dgvVistaGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVistaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaGeneral.Location = new System.Drawing.Point(20, 474);
            this.dgvVistaGeneral.Name = "dgvVistaGeneral";
            this.dgvVistaGeneral.RowTemplate.Height = 24;
            this.dgvVistaGeneral.Size = new System.Drawing.Size(1147, 326);
            this.dgvVistaGeneral.TabIndex = 53;
            this.dgvVistaGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVistaGeneral_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Location = new System.Drawing.Point(519, 803);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(147, 42);
            this.btnRegresar.TabIndex = 54;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvEmpleadosDestacados
            // 
            this.dgvEmpleadosDestacados.AllowUserToAddRows = false;
            this.dgvEmpleadosDestacados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEmpleadosDestacados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosDestacados.Location = new System.Drawing.Point(17, 68);
            this.dgvEmpleadosDestacados.Name = "dgvEmpleadosDestacados";
            this.dgvEmpleadosDestacados.RowTemplate.Height = 24;
            this.dgvEmpleadosDestacados.Size = new System.Drawing.Size(458, 134);
            this.dgvEmpleadosDestacados.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 37);
            this.label2.TabIndex = 56;
            this.label2.Text = "Empleados Destacados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvClientesDestacados
            // 
            this.dgvClientesDestacados.AllowUserToAddRows = false;
            this.dgvClientesDestacados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClientesDestacados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesDestacados.Location = new System.Drawing.Point(707, 68);
            this.dgvClientesDestacados.Name = "dgvClientesDestacados";
            this.dgvClientesDestacados.RowTemplate.Height = 24;
            this.dgvClientesDestacados.Size = new System.Drawing.Size(458, 134);
            this.dgvClientesDestacados.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(769, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 37);
            this.label3.TabIndex = 56;
            this.label3.Text = "Clientes más Leales";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvPeliculasPopulares
            // 
            this.dgvPeliculasPopulares.AllowUserToAddRows = false;
            this.dgvPeliculasPopulares.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPeliculasPopulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculasPopulares.Location = new System.Drawing.Point(17, 274);
            this.dgvPeliculasPopulares.Name = "dgvPeliculasPopulares";
            this.dgvPeliculasPopulares.RowTemplate.Height = 24;
            this.dgvPeliculasPopulares.Size = new System.Drawing.Size(481, 134);
            this.dgvPeliculasPopulares.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(7, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 37);
            this.label4.TabIndex = 56;
            this.label4.Text = "Películas más Populares";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(739, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 37);
            this.label5.TabIndex = 57;
            this.label5.Text = "Favoritas del Público";
            // 
            // dgvFavoritas
            // 
            this.dgvFavoritas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFavoritas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavoritas.Location = new System.Drawing.Point(549, 274);
            this.dgvFavoritas.Name = "dgvFavoritas";
            this.dgvFavoritas.RowTemplate.Height = 24;
            this.dgvFavoritas.Size = new System.Drawing.Size(616, 134);
            this.dgvFavoritas.TabIndex = 58;
            // 
            // frmVistaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 872);
            this.Controls.Add(this.dgvFavoritas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPeliculasPopulares);
            this.Controls.Add(this.dgvClientesDestacados);
            this.Controls.Add(this.dgvEmpleadosDestacados);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvVistaGeneral);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVistaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros Generales";
            this.Load += new System.EventHandler(this.frmVistaGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosDestacados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesDestacados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculasPopulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVistaGeneral;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dgvEmpleadosDestacados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientesDestacados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPeliculasPopulares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFavoritas;
    }
}