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
    public partial class frmComboList : Form
    {
        public frmComboList()
        {
            InitializeComponent();
        }

        private void frmComboList_Load(object sender, EventArgs e)
        {
            cbxCiudades.Items.Add("Hermosillo");
            cbxCiudades.Items.Add("Obregon");
            cbxCiudades.Items.Add("Nueva York");
            cbxCiudades.Items.Add("Los Angeles");
            cbxCiudades.Items.Add("Berlin");
            cbxCiudades.Items.Add("Roma");
            cbxCiudades.Items.Add("Madrid");
            cbxCiudades.Items.Add("Minnesota");
            cbxCiudades.Items.Add("Detroit");
            cbxCiudades.Items.Add("Cleveland");
            cbxCiudades.Items.Add("San Francisco");
            cbxCiudades.Items.Add("Tokyo");
            cbxCiudades.Items.Add("Sydney");
            cbxCiudades.Items.Add("Monterrey");
            cbxCiudades.Items.Add("Londres");
            txtInput.Visible = false;
            btnAgregar.Visible = false;
        }

        private void cbxCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxCiudadesLista.Items.Add(cbxCiudades.SelectedItem.ToString());
            cbxCiudades.Items.RemoveAt(cbxCiudades.SelectedIndex);
            lbxCiudadesLista.Sorted = true;
            if (cbxCiudades.Items.Count == 0)
            {
                var error = MessageBox.Show("Por favor escriba mas ciudades", "COMBO BOX VACIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxCiudades.Enabled = false;
                txtInput.Visible = true;
                btnAgregar.Visible = true;
            }
            else
            {
                cbxCiudades.Enabled = true;
            }
        }

        private void lbxCiudadesLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cbxCiudades.Items.Add(txtInput.Text);
            txtInput.Clear();
            cbxCiudades.Enabled = true;
        }

        private void cbxCiudades_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
