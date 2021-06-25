namespace Ejercicio1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyPressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyPress2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeNosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlesToolStripMenuItem
            // 
            this.controlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlBoxToolStripMenuItem,
            this.groupBoxToolStripMenuItem,
            this.checkBoxToolStripMenuItem,
            this.textBoxToolStripMenuItem,
            this.radioButtonToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.keyPressToolStripMenuItem,
            this.keyPress2ToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.checkListBoxToolStripMenuItem,
            this.treeViewToolStripMenuItem,
            this.comboListToolStripMenuItem,
            this.comboListToolStripMenuItem1,
            this.comboBoxToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            this.controlesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.controlesToolStripMenuItem.Text = "Controles";
            // 
            // controlBoxToolStripMenuItem
            // 
            this.controlBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.controles;
            this.controlBoxToolStripMenuItem.Name = "controlBoxToolStripMenuItem";
            this.controlBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.controlBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.controlBoxToolStripMenuItem.Text = "ControlBox";
            this.controlBoxToolStripMenuItem.Click += new System.EventHandler(this.controlBoxToolStripMenuItem_Click);
            // 
            // groupBoxToolStripMenuItem
            // 
            this.groupBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.marcos_de_cuadros;
            this.groupBoxToolStripMenuItem.Name = "groupBoxToolStripMenuItem";
            this.groupBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.groupBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.groupBoxToolStripMenuItem.Text = "GroupBox";
            this.groupBoxToolStripMenuItem.Click += new System.EventHandler(this.groupBoxToolStripMenuItem_Click);
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.tick;
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // textBoxToolStripMenuItem
            // 
            this.textBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.documento_de_texto;
            this.textBoxToolStripMenuItem.Name = "textBoxToolStripMenuItem";
            this.textBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.textBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.textBoxToolStripMenuItem.Text = "TextBox";
            this.textBoxToolStripMenuItem.Click += new System.EventHandler(this.textBoxToolStripMenuItem_Click_1);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.radio_on_button;
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.picture;
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // keyPressToolStripMenuItem
            // 
            this.keyPressToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.keyboard;
            this.keyPressToolStripMenuItem.Name = "keyPressToolStripMenuItem";
            this.keyPressToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.keyPressToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.keyPressToolStripMenuItem.Text = "KeyPress";
            this.keyPressToolStripMenuItem.Click += new System.EventHandler(this.keyPressToolStripMenuItem_Click);
            // 
            // keyPress2ToolStripMenuItem
            // 
            this.keyPress2ToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.typing;
            this.keyPress2ToolStripMenuItem.Name = "keyPress2ToolStripMenuItem";
            this.keyPress2ToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.keyPress2ToolStripMenuItem.Text = "KeyPress2";
            this.keyPress2ToolStripMenuItem.Click += new System.EventHandler(this.keyPress2ToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.list__1_;
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // checkListBoxToolStripMenuItem
            // 
            this.checkListBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.list;
            this.checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            this.checkListBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.checkListBoxToolStripMenuItem.Text = "CheckListBox";
            this.checkListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkListBoxToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.tree_structure;
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // comboListToolStripMenuItem
            // 
            this.comboListToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.package;
            this.comboListToolStripMenuItem.Name = "comboListToolStripMenuItem";
            this.comboListToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.comboListToolStripMenuItem.Text = "ListBox 2";
            this.comboListToolStripMenuItem.Click += new System.EventHandler(this.comboListToolStripMenuItem_Click);
            // 
            // comboListToolStripMenuItem1
            // 
            this.comboListToolStripMenuItem1.Image = global::Ejercicio1.Properties.Resources.order;
            this.comboListToolStripMenuItem1.Name = "comboListToolStripMenuItem1";
            this.comboListToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.comboListToolStripMenuItem1.Text = "Combo List";
            this.comboListToolStripMenuItem1.Click += new System.EventHandler(this.comboListToolStripMenuItem1_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.box;
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.comboBoxToolStripMenuItem.Text = "Combo Box";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.salida;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeNosotrosToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // acercaDeNosotrosToolStripMenuItem
            // 
            this.acercaDeNosotrosToolStripMenuItem.Image = global::Ejercicio1.Properties.Resources.sobre_nosotros;
            this.acercaDeNosotrosToolStripMenuItem.Name = "acercaDeNosotrosToolStripMenuItem";
            this.acercaDeNosotrosToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.acercaDeNosotrosToolStripMenuItem.Text = "Acerca de Nosotros";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 538);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyPressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyPress2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
    }
}

