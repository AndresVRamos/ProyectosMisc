namespace PaintGraficacion
{
    partial class frmPaint
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxArea = new System.Windows.Forms.PictureBox();
            this.rbtLinea = new System.Windows.Forms.RadioButton();
            this.lblFiguras = new System.Windows.Forms.Label();
            this.rbtRectangulo = new System.Windows.Forms.RadioButton();
            this.rbtArco = new System.Windows.Forms.RadioButton();
            this.rbtPie = new System.Windows.Forms.RadioButton();
            this.rbtCirculo = new System.Windows.Forms.RadioButton();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.cdgPaletaColores = new System.Windows.Forms.ColorDialog();
            this.btnColores = new System.Windows.Forms.Button();
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadioArco = new System.Windows.Forms.Label();
            this.txtRadioArco = new System.Windows.Forms.TextBox();
            this.lblRadioPie = new System.Windows.Forms.Label();
            this.txtRadioPie = new System.Windows.Forms.TextBox();
            this.rbtTriangulo = new System.Windows.Forms.RadioButton();
            this.rbtPentagono = new System.Windows.Forms.RadioButton();
            this.rbtPoligono = new System.Windows.Forms.RadioButton();
            this.lblLados = new System.Windows.Forms.Label();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordenadas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(95, 20);
            this.lblCoordenadas.Text = "X: null, Y: null";
            // 
            // pbxArea
            // 
            this.pbxArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArea.BackColor = System.Drawing.SystemColors.Control;
            this.pbxArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbxArea.Location = new System.Drawing.Point(119, 12);
            this.pbxArea.Name = "pbxArea";
            this.pbxArea.Size = new System.Drawing.Size(669, 598);
            this.pbxArea.TabIndex = 1;
            this.pbxArea.TabStop = false;
            this.pbxArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxArea_MouseDown);
            this.pbxArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxArea_MouseMove);
            this.pbxArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxArea_MouseUp);
            // 
            // rbtLinea
            // 
            this.rbtLinea.AutoSize = true;
            this.rbtLinea.Location = new System.Drawing.Point(12, 43);
            this.rbtLinea.Name = "rbtLinea";
            this.rbtLinea.Size = new System.Drawing.Size(64, 21);
            this.rbtLinea.TabIndex = 2;
            this.rbtLinea.TabStop = true;
            this.rbtLinea.Text = "Línea";
            this.rbtLinea.UseVisualStyleBackColor = true;
            this.rbtLinea.CheckedChanged += new System.EventHandler(this.rbtLinea_CheckedChanged);
            // 
            // lblFiguras
            // 
            this.lblFiguras.AutoSize = true;
            this.lblFiguras.Location = new System.Drawing.Point(13, 13);
            this.lblFiguras.Name = "lblFiguras";
            this.lblFiguras.Size = new System.Drawing.Size(55, 17);
            this.lblFiguras.TabIndex = 3;
            this.lblFiguras.Text = "Figuras";
            // 
            // rbtRectangulo
            // 
            this.rbtRectangulo.AutoSize = true;
            this.rbtRectangulo.Location = new System.Drawing.Point(12, 136);
            this.rbtRectangulo.Name = "rbtRectangulo";
            this.rbtRectangulo.Size = new System.Drawing.Size(101, 21);
            this.rbtRectangulo.TabIndex = 4;
            this.rbtRectangulo.TabStop = true;
            this.rbtRectangulo.Text = "Rectángulo";
            this.rbtRectangulo.UseVisualStyleBackColor = true;
            this.rbtRectangulo.CheckedChanged += new System.EventHandler(this.rbtRectangulo_CheckedChanged);
            // 
            // rbtArco
            // 
            this.rbtArco.AutoSize = true;
            this.rbtArco.Location = new System.Drawing.Point(12, 285);
            this.rbtArco.Name = "rbtArco";
            this.rbtArco.Size = new System.Drawing.Size(58, 21);
            this.rbtArco.TabIndex = 5;
            this.rbtArco.TabStop = true;
            this.rbtArco.Text = "Arco";
            this.rbtArco.UseVisualStyleBackColor = true;
            this.rbtArco.CheckedChanged += new System.EventHandler(this.rbtArco_CheckedChanged);
            // 
            // rbtPie
            // 
            this.rbtPie.AutoSize = true;
            this.rbtPie.Location = new System.Drawing.Point(12, 335);
            this.rbtPie.Name = "rbtPie";
            this.rbtPie.Size = new System.Drawing.Size(49, 21);
            this.rbtPie.TabIndex = 6;
            this.rbtPie.TabStop = true;
            this.rbtPie.Text = "Pie";
            this.rbtPie.UseVisualStyleBackColor = true;
            this.rbtPie.CheckedChanged += new System.EventHandler(this.rbtPie_CheckedChanged);
            // 
            // rbtCirculo
            // 
            this.rbtCirculo.AutoSize = true;
            this.rbtCirculo.Location = new System.Drawing.Point(12, 234);
            this.rbtCirculo.Name = "rbtCirculo";
            this.rbtCirculo.Size = new System.Drawing.Size(72, 21);
            this.rbtCirculo.TabIndex = 7;
            this.rbtCirculo.TabStop = true;
            this.rbtCirculo.Text = "Círculo";
            this.rbtCirculo.UseVisualStyleBackColor = true;
            this.rbtCirculo.CheckedChanged += new System.EventHandler(this.rbtCirculo_CheckedChanged);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(12, 453);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(101, 31);
            this.btnDibujar.TabIndex = 8;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnColores
            // 
            this.btnColores.BackColor = System.Drawing.Color.Black;
            this.btnColores.Location = new System.Drawing.Point(12, 568);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(101, 42);
            this.btnColores.TabIndex = 9;
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(12, 260);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(13, 17);
            this.lblRadio.TabIndex = 13;
            this.lblRadio.Text = "r";
            this.lblRadio.Visible = false;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(31, 257);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(53, 22);
            this.txtRadio.TabIndex = 12;
            this.txtRadio.Visible = false;
            // 
            // lblRadioArco
            // 
            this.lblRadioArco.AutoSize = true;
            this.lblRadioArco.Location = new System.Drawing.Point(12, 310);
            this.lblRadioArco.Name = "lblRadioArco";
            this.lblRadioArco.Size = new System.Drawing.Size(13, 17);
            this.lblRadioArco.TabIndex = 15;
            this.lblRadioArco.Text = "r";
            this.lblRadioArco.Visible = false;
            // 
            // txtRadioArco
            // 
            this.txtRadioArco.Location = new System.Drawing.Point(31, 307);
            this.txtRadioArco.Name = "txtRadioArco";
            this.txtRadioArco.Size = new System.Drawing.Size(53, 22);
            this.txtRadioArco.TabIndex = 14;
            this.txtRadioArco.Visible = false;
            // 
            // lblRadioPie
            // 
            this.lblRadioPie.AutoSize = true;
            this.lblRadioPie.Location = new System.Drawing.Point(12, 361);
            this.lblRadioPie.Name = "lblRadioPie";
            this.lblRadioPie.Size = new System.Drawing.Size(13, 17);
            this.lblRadioPie.TabIndex = 17;
            this.lblRadioPie.Text = "r";
            this.lblRadioPie.Visible = false;
            // 
            // txtRadioPie
            // 
            this.txtRadioPie.Location = new System.Drawing.Point(31, 358);
            this.txtRadioPie.Name = "txtRadioPie";
            this.txtRadioPie.Size = new System.Drawing.Size(53, 22);
            this.txtRadioPie.TabIndex = 16;
            this.txtRadioPie.Visible = false;
            // 
            // rbtTriangulo
            // 
            this.rbtTriangulo.AutoSize = true;
            this.rbtTriangulo.Location = new System.Drawing.Point(12, 91);
            this.rbtTriangulo.Name = "rbtTriangulo";
            this.rbtTriangulo.Size = new System.Drawing.Size(89, 21);
            this.rbtTriangulo.TabIndex = 18;
            this.rbtTriangulo.TabStop = true;
            this.rbtTriangulo.Text = "Triángulo";
            this.rbtTriangulo.UseVisualStyleBackColor = true;
            this.rbtTriangulo.CheckedChanged += new System.EventHandler(this.rbtTriangulo_CheckedChanged);
            // 
            // rbtPentagono
            // 
            this.rbtPentagono.AutoSize = true;
            this.rbtPentagono.Location = new System.Drawing.Point(12, 187);
            this.rbtPentagono.Name = "rbtPentagono";
            this.rbtPentagono.Size = new System.Drawing.Size(98, 21);
            this.rbtPentagono.TabIndex = 19;
            this.rbtPentagono.TabStop = true;
            this.rbtPentagono.Text = "Pentagono";
            this.rbtPentagono.UseVisualStyleBackColor = true;
            this.rbtPentagono.CheckedChanged += new System.EventHandler(this.rbtPentagono_CheckedChanged);
            // 
            // rbtPoligono
            // 
            this.rbtPoligono.AutoSize = true;
            this.rbtPoligono.Location = new System.Drawing.Point(12, 386);
            this.rbtPoligono.Name = "rbtPoligono";
            this.rbtPoligono.Size = new System.Drawing.Size(84, 21);
            this.rbtPoligono.TabIndex = 20;
            this.rbtPoligono.TabStop = true;
            this.rbtPoligono.Text = "Polígono";
            this.rbtPoligono.UseVisualStyleBackColor = true;
            this.rbtPoligono.CheckedChanged += new System.EventHandler(this.rbtPoligono_CheckedChanged_1);
            // 
            // lblLados
            // 
            this.lblLados.AutoSize = true;
            this.lblLados.Location = new System.Drawing.Point(12, 410);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(16, 17);
            this.lblLados.TabIndex = 21;
            this.lblLados.Text = "L";
            this.lblLados.Visible = false;
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(31, 407);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(53, 22);
            this.txtLados.TabIndex = 22;
            this.txtLados.Visible = false;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.lblLados);
            this.Controls.Add(this.rbtPoligono);
            this.Controls.Add(this.rbtPentagono);
            this.Controls.Add(this.rbtTriangulo);
            this.Controls.Add(this.lblRadioPie);
            this.Controls.Add(this.txtRadioPie);
            this.Controls.Add(this.lblRadioArco);
            this.Controls.Add(this.txtRadioArco);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.rbtCirculo);
            this.Controls.Add(this.rbtPie);
            this.Controls.Add(this.rbtArco);
            this.Controls.Add(this.rbtRectangulo);
            this.Controls.Add(this.lblFiguras);
            this.Controls.Add(this.rbtLinea);
            this.Controls.Add(this.pbxArea);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmPaint";
            this.Text = "Paint Graficación";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenadas;
        private System.Windows.Forms.PictureBox pbxArea;
        private System.Windows.Forms.RadioButton rbtLinea;
        private System.Windows.Forms.Label lblFiguras;
        private System.Windows.Forms.RadioButton rbtRectangulo;
        private System.Windows.Forms.RadioButton rbtArco;
        private System.Windows.Forms.RadioButton rbtPie;
        private System.Windows.Forms.RadioButton rbtCirculo;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.ColorDialog cdgPaletaColores;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadioArco;
        private System.Windows.Forms.TextBox txtRadioArco;
        private System.Windows.Forms.Label lblRadioPie;
        private System.Windows.Forms.TextBox txtRadioPie;
        private System.Windows.Forms.RadioButton rbtTriangulo;
        private System.Windows.Forms.RadioButton rbtPentagono;
        private System.Windows.Forms.RadioButton rbtPoligono;
        private System.Windows.Forms.Label lblLados;
        private System.Windows.Forms.TextBox txtLados;
    }
}

