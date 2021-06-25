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
    public partial class frmListBox2 : Form
    {
        public frmListBox2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Add(txtInput.Text);
            lbxOutput.Sorted = true;
            txtInput.Clear();
        }
    }
}
