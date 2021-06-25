using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTextBox = new frmTextBox();
            formTextBox.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGroupbox = new frmGroupBox();
            formGroupbox.Show();
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCheckBox = new frmCheckBox();
            formCheckBox.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPictureBox = new frmPictureBox();
            formPictureBox.Show();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRadioButton = new frmRadioButton();
            formRadioButton.Show();
        }

        private void keyPressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formKeyPress = new frmKeyPress();
            formKeyPress.Show();
            
        }

        private void keyPress2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formKeyPress2 = new frmKeyLoggerChafita();
            formKeyPress2.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formListBox = new frmListBox();
            formListBox.Show();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCheckListBox = new frmCheckListBox();
            formCheckListBox.Show();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTreeView = new frmTreeView();
            formTreeView.Show();
        }

        private void comboListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formComboList = new frmListBox2();
            formComboList.Show();
        }

        private void comboListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formComboList = new frmComboList();
            formComboList.Show();
        }

        private void controlBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formComboBox = new frmComboBox();
            formComboBox.Show();
        }

        private void textBoxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formTextBox = new frmTextBox();
            formTextBox.Show();
        }
    }
}
