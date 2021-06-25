using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbxAutos.Items.Add(txtNombreAuto.Text);
            txtNombreAuto.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreAuto.Text != "")
            {
                lbxAutos.Items.Insert(lbxAutos.SelectedIndex, txtNombreAuto.Text);
                lbxAutos.Items.RemoveAt(lbxAutos.SelectedIndex);
                txtNombreAuto.Clear();
                lblModificar.Text = "";
            }
            else
            {
                lblModificar.Text = "Por favor inserta texto para modificar el valor seleccionado.";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lbxAutos.Items.RemoveAt(lbxAutos.SelectedIndex);
            txtNombreAuto.Clear();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
