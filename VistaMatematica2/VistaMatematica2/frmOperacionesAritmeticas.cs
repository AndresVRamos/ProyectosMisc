using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritmeticav2;


namespace VistaMatematicca
{
    public partial class frmOperacionesAritmeticas : Form
    {
        public frmOperacionesAritmeticas()
        {
            InitializeComponent();
        }

        public List<double> listaNumeros = new List<double>();

        private void frmOperacionesAritmeticas_Load(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {
                txtValor2.Enabled = false;
                lblValor2.Enabled = false;
                btnSiguiente.Enabled = true;
            }
            else
            {
                txtValor2.Enabled = true;
                lblValor2.Enabled = true;
                btnSiguiente.Enabled = false;
                listaNumeros.Clear();
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {
                var resultado = OperacionesAritmeticas.Sumar(listaNumeros);
                lblResultado.Text =
                    string.Format("R = {0}", resultado);

            }
            else
            {
                txtValor2.Enabled = true;
                var resultado = OperacionesAritmeticas.Sumar(double.Parse(txtValor1.Text), double.Parse(txtValor2.Text));
                lblResultado.Text =
                    string.Format("R = {0}", resultado);
            }
        }

        private void cbxArreglo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {
                txtValor1.Text = string.Empty;
                lblResultado.Text = string.Empty;
                txtValor2.Enabled = false;
                lblValor2.Enabled = false;
                btnSiguiente.Enabled = true;
            }
            else
            {
                txtValor2.Enabled = true;
                lblValor2.Enabled = true;
                btnSiguiente.Enabled = false;
                listaNumeros.Clear();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text.Equals(string.Empty))
            {
                MessageBox.Show("El valor no puede ser vacio");
            }
            else
            {
                listaNumeros.Add(double.Parse(txtValor1.Text));
                txtValor1.Text = string.Empty;
            }
        }
    }
}
