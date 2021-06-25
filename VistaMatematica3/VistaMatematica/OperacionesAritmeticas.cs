using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aritmetica;

namespace VistaMatematica
{
    public partial class OperacionesAritmeticas : Form
    {
        public OperacionesAritmeticas()
        {
            InitializeComponent();
        }
        public List<double> listaNumeros = new List<double>();

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {
                var resultado = Aritmetica.OperacionesAritmeticas.Sumar(listaNumeros);
                lblResultado.Text = String.Format("Resultado = {0}", resultado);
            }
            else
            {
                var resultado = Aritmetica.OperacionesAritmeticas.Sumar(double.Parse(txtbxValorA.Text),double.Parse(txtbxValorB.Text));
                lblResultado.Text = String.Format("Resultado = {0}",resultado);
            }
        }

        private void cbxArreglo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxArreglo.Checked)
            {
                txtbxValorA.Text = String.Empty;
                lblResultado.Text = String.Empty;
                txtbxValorB.Enabled = false;

            }
            else
            {
                txtbxValorB.Enabled = true;
                listaNumeros.Clear();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtbxValorA.Text.Equals(String.Empty))
            {
                MessageBox.Show("El valor no puede ser vacio");
            }
            else
            {
                listaNumeros.Add(double.Parse(txtbxValorA.Text));
                txtbxValorA.Text = String.Empty;
            }
            
        }
    }
}
