using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenLista
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbxPersonas.Items.Add(txtNombre.Text);
            txtNombre.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                lbxPersonas.Items.Insert(lbxPersonas.SelectedIndex, txtNombre.Text);
                lbxPersonas.Items.RemoveAt(lbxPersonas.SelectedIndex);
                txtNombre.Clear();
                lblModificar.Text = "";
            }
            else
            {
                lblModificar.Text = "Por favor inserta texto para modificar el valor seleccionado.";
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lbxPersonas.Items.RemoveAt(lbxPersonas.SelectedIndex);
            txtNombre.Clear();
        }
    }
}
