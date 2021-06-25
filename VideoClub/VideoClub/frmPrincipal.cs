using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPelicula = new frmPeliculas();
            formPelicula.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formEmpleado = new frmEmpleado();
            formEmpleado.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCliente = new frmClientes();
            formCliente.Show();
        }

        private void btnRenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formRenta = new frmRentas();
            formRenta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formVistaGeneral = new frmVistaGeneral();
            formVistaGeneral.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
