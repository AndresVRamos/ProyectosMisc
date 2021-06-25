namespace VistaMatematica
{
    partial class frmVistaMatematica
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.operacionesAritmeticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesGeometricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesAlgebraicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesAritmeticasToolStripMenuItem,
            this.operacionesGeometricasToolStripMenuItem,
            this.operacionesAlgebraicasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(657, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.UseWaitCursor = true;
            // 
            // operacionesAritmeticasToolStripMenuItem
            // 
            this.operacionesAritmeticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisonToolStripMenuItem,
            this.potenciaToolStripMenuItem,
            this.fibonacciToolStripMenuItem,
            this.factorialToolStripMenuItem});
            this.operacionesAritmeticasToolStripMenuItem.Name = "operacionesAritmeticasToolStripMenuItem";
            this.operacionesAritmeticasToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.operacionesAritmeticasToolStripMenuItem.Text = "Operaciones Aritmeticas";
            this.operacionesAritmeticasToolStripMenuItem.Click += new System.EventHandler(this.operacionesAritmeticasToolStripMenuItem_Click);
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            this.multiplicacionToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // divisonToolStripMenuItem
            // 
            this.divisonToolStripMenuItem.Name = "divisonToolStripMenuItem";
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.divisonToolStripMenuItem.Text = "Divison";
            this.divisonToolStripMenuItem.Click += new System.EventHandler(this.divisonToolStripMenuItem_Click);
            // 
            // potenciaToolStripMenuItem
            // 
            this.potenciaToolStripMenuItem.Name = "potenciaToolStripMenuItem";
            this.potenciaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.potenciaToolStripMenuItem.Text = "Potencia";
            this.potenciaToolStripMenuItem.Click += new System.EventHandler(this.potenciaToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // operacionesGeometricasToolStripMenuItem
            // 
            this.operacionesGeometricasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.trianguloToolStripMenuItem,
            this.rectanguloToolStripMenuItem});
            this.operacionesGeometricasToolStripMenuItem.Name = "operacionesGeometricasToolStripMenuItem";
            this.operacionesGeometricasToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.operacionesGeometricasToolStripMenuItem.Text = "Operaciones Geometricas";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.rectanguloToolStripMenuItem.Text = "Rectangulo";
            // 
            // operacionesAlgebraicasToolStripMenuItem
            // 
            this.operacionesAlgebraicasToolStripMenuItem.Name = "operacionesAlgebraicasToolStripMenuItem";
            this.operacionesAlgebraicasToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.operacionesAlgebraicasToolStripMenuItem.Text = "Operaciones Algebraicas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaMatematica.Properties.Resources.Logo_ITH_FA;
            this.pictureBox1.Location = new System.Drawing.Point(18, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vista Matematica";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Andrés Valenzuela Ramos";
            this.label2.UseWaitCursor = true;
            // 
            // frmVistaMatematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmVistaMatematica";
            this.Text = "87";
            this.UseWaitCursor = true;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem operacionesAritmeticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesGeometricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesAlgebraicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

