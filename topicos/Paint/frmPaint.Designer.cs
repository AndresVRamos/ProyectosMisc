namespace Paint
{
    partial class frmPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnPentagono = new System.Windows.Forms.Button();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.pnlImagenes = new System.Windows.Forms.Panel();
            this.lblTipoImagen = new System.Windows.Forms.Label();
            this.cbxTipoImagen = new System.Windows.Forms.ComboBox();
            this.lblTipoLapiz = new System.Windows.Forms.Label();
            this.cbxTipoLapiz = new System.Windows.Forms.ComboBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.imgMuestraPunto = new System.Windows.Forms.PictureBox();
            this.lblColor1 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnPaleta = new System.Windows.Forms.Button();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imgActual = new System.Windows.Forms.PictureBox();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdgPaletaColores = new System.Windows.Forms.ColorDialog();
            this.ofdAbrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.sfdImagen = new System.Windows.Forms.SaveFileDialog();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevaPestaña = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestraPunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            this.tbcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActual)).BeginInit();
            this.stsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Paint.Properties.Resources.archivo_nuevo;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::Paint.Properties.Resources.abrir_carpeta_con_documento;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::Paint.Properties.Resources.guardar_icono;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::Paint.Properties.Resources.salvar;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = global::Paint.Properties.Resources.imprimir_documento;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(266, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Paint.Properties.Resources.salir_flecha_derecha;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = global::Paint.Properties.Resources.letra_a_mayuscula_y_minuscula;
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(180, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(264, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(348, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnTexto);
            this.panel2.Controls.Add(this.btnPentagono);
            this.panel2.Controls.Add(this.btnRellenar);
            this.panel2.Controls.Add(this.btnTriangulo);
            this.panel2.Controls.Add(this.btnLinea);
            this.panel2.Controls.Add(this.btnCuadrado);
            this.panel2.Controls.Add(this.btnCirculo);
            this.panel2.Controls.Add(this.btnBorrador);
            this.panel2.Controls.Add(this.btnBrush);
            this.panel2.Controls.Add(this.btnLapiz);
            this.panel2.Location = new System.Drawing.Point(12, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 548);
            this.panel2.TabIndex = 0;
            // 
            // btnTexto
            // 
            this.btnTexto.BackColor = System.Drawing.SystemColors.Control;
            this.btnTexto.Image = global::Paint.Properties.Resources.font;
            this.btnTexto.Location = new System.Drawing.Point(65, 227);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(50, 50);
            this.btnTexto.TabIndex = 17;
            this.btnTexto.Text = "\r\n";
            this.btnTexto.UseVisualStyleBackColor = false;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // btnPentagono
            // 
            this.btnPentagono.BackColor = System.Drawing.SystemColors.Control;
            this.btnPentagono.Image = global::Paint.Properties.Resources.pentagon_outline_shape__1_;
            this.btnPentagono.Location = new System.Drawing.Point(8, 227);
            this.btnPentagono.Name = "btnPentagono";
            this.btnPentagono.Size = new System.Drawing.Size(50, 50);
            this.btnPentagono.TabIndex = 16;
            this.btnPentagono.UseVisualStyleBackColor = false;
            this.btnPentagono.Click += new System.EventHandler(this.btnPentagono_Click_1);
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRellenar.Image = global::Paint.Properties.Resources.paint;
            this.btnRellenar.Location = new System.Drawing.Point(8, 171);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(50, 50);
            this.btnRellenar.TabIndex = 15;
            this.btnRellenar.UseVisualStyleBackColor = false;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnTriangulo.Image = global::Paint.Properties.Resources.triangle;
            this.btnTriangulo.Location = new System.Drawing.Point(64, 171);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(50, 50);
            this.btnTriangulo.TabIndex = 14;
            this.btnTriangulo.UseVisualStyleBackColor = false;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.SystemColors.Control;
            this.btnLinea.Image = global::Paint.Properties.Resources.menos_linea_recta_horizontal;
            this.btnLinea.Location = new System.Drawing.Point(64, 59);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(50, 50);
            this.btnLinea.TabIndex = 13;
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.SystemColors.Control;
            this.btnCuadrado.Image = global::Paint.Properties.Resources.casilla_de_verificacion_vacia;
            this.btnCuadrado.Location = new System.Drawing.Point(8, 115);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnCuadrado.TabIndex = 12;
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCirculo.Image = global::Paint.Properties.Resources.vacio;
            this.btnCirculo.Location = new System.Drawing.Point(64, 115);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(50, 50);
            this.btnCirculo.TabIndex = 11;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackColor = System.Drawing.SystemColors.Control;
            this.btnBorrador.Image = global::Paint.Properties.Resources.goma_de_borrar1;
            this.btnBorrador.Location = new System.Drawing.Point(8, 59);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(50, 50);
            this.btnBorrador.TabIndex = 10;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrush.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBrush.Image = global::Paint.Properties.Resources.pincel1;
            this.btnBrush.Location = new System.Drawing.Point(64, 3);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(50, 50);
            this.btnBrush.TabIndex = 9;
            this.btnBrush.UseVisualStyleBackColor = false;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.SystemColors.Control;
            this.btnLapiz.Image = global::Paint.Properties.Resources.editar1;
            this.btnLapiz.Location = new System.Drawing.Point(8, 3);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(50, 50);
            this.btnLapiz.TabIndex = 8;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // pnlImagenes
            // 
            this.pnlImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlImagenes.Controls.Add(this.lblTipoImagen);
            this.pnlImagenes.Controls.Add(this.cbxTipoImagen);
            this.pnlImagenes.Controls.Add(this.lblTipoLapiz);
            this.pnlImagenes.Controls.Add(this.cbxTipoLapiz);
            this.pnlImagenes.Controls.Add(this.lblTexto);
            this.pnlImagenes.Controls.Add(this.txtTexto);
            this.pnlImagenes.Controls.Add(this.imgMuestraPunto);
            this.pnlImagenes.Controls.Add(this.lblColor1);
            this.pnlImagenes.Controls.Add(this.lblColor);
            this.pnlImagenes.Controls.Add(this.nudGrosor);
            this.pnlImagenes.Controls.Add(this.btnColor);
            this.pnlImagenes.Controls.Add(this.btnPaleta);
            this.pnlImagenes.Controls.Add(this.tbcPrincipal);
            this.pnlImagenes.Location = new System.Drawing.Point(141, 92);
            this.pnlImagenes.Name = "pnlImagenes";
            this.pnlImagenes.Size = new System.Drawing.Size(1194, 548);
            this.pnlImagenes.TabIndex = 7;
            this.pnlImagenes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImagenes_Paint);
            // 
            // lblTipoImagen
            // 
            this.lblTipoImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoImagen.AutoSize = true;
            this.lblTipoImagen.Location = new System.Drawing.Point(1097, 424);
            this.lblTipoImagen.Name = "lblTipoImagen";
            this.lblTipoImagen.Size = new System.Drawing.Size(86, 17);
            this.lblTipoImagen.TabIndex = 27;
            this.lblTipoImagen.Text = "Tipo Imagen";
            // 
            // cbxTipoImagen
            // 
            this.cbxTipoImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoImagen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoImagen.FormattingEnabled = true;
            this.cbxTipoImagen.Items.AddRange(new object[] {
            "Center",
            "Stretch",
            "Tile",
            "Zoom"});
            this.cbxTipoImagen.Location = new System.Drawing.Point(1101, 444);
            this.cbxTipoImagen.Name = "cbxTipoImagen";
            this.cbxTipoImagen.Size = new System.Drawing.Size(86, 24);
            this.cbxTipoImagen.TabIndex = 26;
            this.cbxTipoImagen.SelectedIndexChanged += new System.EventHandler(this.cbxTipoImagen_SelectedIndexChanged_1);
            // 
            // lblTipoLapiz
            // 
            this.lblTipoLapiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoLapiz.AutoSize = true;
            this.lblTipoLapiz.Location = new System.Drawing.Point(1097, 309);
            this.lblTipoLapiz.Name = "lblTipoLapiz";
            this.lblTipoLapiz.Size = new System.Drawing.Size(94, 17);
            this.lblTipoLapiz.TabIndex = 25;
            this.lblTipoLapiz.Text = "Tipo de Lapiz";
            // 
            // cbxTipoLapiz
            // 
            this.cbxTipoLapiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoLapiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoLapiz.FormattingEnabled = true;
            this.cbxTipoLapiz.Items.AddRange(new object[] {
            "Round",
            "Diamante",
            "Triangulo",
            "Cuadrado"});
            this.cbxTipoLapiz.Location = new System.Drawing.Point(1101, 331);
            this.cbxTipoLapiz.Name = "cbxTipoLapiz";
            this.cbxTipoLapiz.Size = new System.Drawing.Size(86, 24);
            this.cbxTipoLapiz.TabIndex = 24;
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(1098, 204);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(43, 17);
            this.lblTexto.TabIndex = 23;
            this.lblTexto.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto.Location = new System.Drawing.Point(1100, 224);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(86, 22);
            this.txtTexto.TabIndex = 17;
            // 
            // imgMuestraPunto
            // 
            this.imgMuestraPunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMuestraPunto.Location = new System.Drawing.Point(1113, 140);
            this.imgMuestraPunto.Name = "imgMuestraPunto";
            this.imgMuestraPunto.Size = new System.Drawing.Size(61, 32);
            this.imgMuestraPunto.TabIndex = 21;
            this.imgMuestraPunto.TabStop = false;
            // 
            // lblColor1
            // 
            this.lblColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor1.AutoSize = true;
            this.lblColor1.Location = new System.Drawing.Point(1123, 22);
            this.lblColor1.Name = "lblColor1";
            this.lblColor1.Size = new System.Drawing.Size(41, 17);
            this.lblColor1.TabIndex = 20;
            this.lblColor1.Text = "Color";
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(1114, 92);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 17);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "Tamaño";
            // 
            // nudGrosor
            // 
            this.nudGrosor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGrosor.Location = new System.Drawing.Point(1114, 112);
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(60, 22);
            this.nudGrosor.TabIndex = 18;
            this.nudGrosor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGrosor.ValueChanged += new System.EventHandler(this.nudGrosor_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Location = new System.Drawing.Point(1142, 42);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(45, 42);
            this.btnColor.TabIndex = 17;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnPaleta
            // 
            this.btnPaleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaleta.Image = global::Paint.Properties.Resources.paint_palette__1_;
            this.btnPaleta.Location = new System.Drawing.Point(1097, 42);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(45, 42);
            this.btnPaleta.TabIndex = 16;
            this.btnPaleta.UseVisualStyleBackColor = true;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Location = new System.Drawing.Point(9, 5);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1089, 536);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imgActual);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pestaña 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imgActual
            // 
            this.imgActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgActual.BackColor = System.Drawing.Color.White;
            this.imgActual.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgActual.Location = new System.Drawing.Point(0, 0);
            this.imgActual.Name = "imgActual";
            this.imgActual.Size = new System.Drawing.Size(1081, 507);
            this.imgActual.TabIndex = 1;
            this.imgActual.TabStop = false;
            this.imgActual.SizeChanged += new System.EventHandler(this.imgActual_SizeChanged);
            this.imgActual.Click += new System.EventHandler(this.imgActual_Click);
            this.imgActual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgActual_MouseDown);
            this.imgActual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgActual_MouseMove);
            this.imgActual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgActual_MouseUp);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordenadas,
            this.statusLbl});
            this.stsPrincipal.Location = new System.Drawing.Point(0, 653);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(1353, 25);
            this.stsPrincipal.TabIndex = 8;
            this.stsPrincipal.Text = "statusStrip1";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(95, 20);
            this.lblCoordenadas.Text = "X: null, Y: null";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 20);
            // 
            // ofdAbrirImagen
            // 
            this.ofdAbrirImagen.FileName = "openFileDialog1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = global::Paint.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(96, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 55);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevaPestaña
            // 
            this.btnNuevaPestaña.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevaPestaña.Image = global::Paint.Properties.Resources.anadir;
            this.btnNuevaPestaña.Location = new System.Drawing.Point(12, 31);
            this.btnNuevaPestaña.Name = "btnNuevaPestaña";
            this.btnNuevaPestaña.Size = new System.Drawing.Size(78, 55);
            this.btnNuevaPestaña.TabIndex = 2;
            this.btnNuevaPestaña.UseVisualStyleBackColor = false;
            this.btnNuevaPestaña.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 678);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.pnlImagenes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevaPestaña);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintITH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlImagenes.ResumeLayout(false);
            this.pnlImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMuestraPunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgActual)).EndInit();
            this.stsPrincipal.ResumeLayout(false);
            this.stsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevaPestaña;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnBorrador;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Panel pnlImagenes;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenadas;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox imgActual;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdgPaletaColores;
        private System.Windows.Forms.Label lblColor1;
        private System.Windows.Forms.PictureBox imgMuestraPunto;
        private System.Windows.Forms.OpenFileDialog ofdAbrirImagen;
        private System.Windows.Forms.SaveFileDialog sfdImagen;
        private System.Windows.Forms.Button btnPentagono;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Label lblTipoLapiz;
        private System.Windows.Forms.ComboBox cbxTipoLapiz;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTipoImagen;
        private System.Windows.Forms.ComboBox cbxTipoImagen;
    }
}

