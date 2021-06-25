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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbxAutos.Items.Add(txtAuto.Text);
            txtAuto.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbxAutos.SelectedIndex != -1)
            {
                lbxAutos.Items.RemoveAt(lbxAutos.SelectedIndex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbxAutos.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
