namespace Ejercicio1
{
    partial class frmTreeView
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
            this.tvwDirectorio = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvwDirectorio
            // 
            this.tvwDirectorio.Location = new System.Drawing.Point(31, 31);
            this.tvwDirectorio.Name = "tvwDirectorio";
            this.tvwDirectorio.Size = new System.Drawing.Size(472, 612);
            this.tvwDirectorio.TabIndex = 0;
            this.tvwDirectorio.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwDirectorio_AfterSelect);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 674);
            this.Controls.Add(this.tvwDirectorio);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.Load += new System.EventHandler(this.frmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwDirectorio;
    }
}