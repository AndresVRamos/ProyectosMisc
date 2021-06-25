using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodosCajaRegistradora;

namespace TareaTopicosCajaRegistradora
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
            lblSobrante.Visible = false;
        }

        List<double> precio = new List<double>();
        double subtotal;
        double IVA;
        double total;
        bool tarjeta;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double costo = double.Parse(txtCosto.Text);
            precio.Add(costo);
            lbxProductos.Items.Add(txtProducto.Text);
            txtProducto.Clear();
            lbxPrecios.Items.Add(costo);
            txtCosto.Clear();

            subtotal = precio.Sum();
            lblSubtotal.Text = "Subtotal: " + subtotal;

            IVA = MetodosCaja.calcularIVA(subtotal);
            lblIVA.Text = "IVA: " + IVA;

            total = MetodosCaja.calcularTotal(subtotal, IVA);
            lblTotal.Text = "Total: " + total;

        }

        private void lblSobrante_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            lblSobrante.Visible = true;
            double monto = double.Parse(txtMontoPagado.Text);
            double sobro = MetodosCaja.metodoPago(monto, total);
            if (monto > total)
            {
                lblSobrante.Text = "Sobrante: " + sobro.ToString();
            }
            else
            {
                MessageBox.Show("La cantidad pagada es menor a la cantidad cobrada.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void cbxTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTarjeta.Checked)
            {
                tarjeta = true;
                total = total + (total * .02);
                lblTotal.Text = "Total: " + total;
            }
            else
            {
                tarjeta = false;
                total = total - (total * .02);
                lblTotal.Text = "Total: " + total;
            }
        }
    }
}