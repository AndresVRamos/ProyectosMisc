using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DANZART
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           // SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-B1N3P89;Initial Catalog=ACADEMIA;Integrated Security=True");
           // conexion.Open();
        }
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlumnos objfrmAlumnos = new frmAlumnos();
            objfrmAlumnos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleados objfrmEmpleados = new frmEmpleados();
            objfrmEmpleados.Show();
        }

        private void horarioDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHorario objHorario = new frmHorario();
            objHorario.Show();
        }

        private void mensualidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMensualidades objMensualidades = new frmMensualidades();
            objMensualidades.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGrupos objfrmGrupos = new frmGrupos();
            objfrmGrupos.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAcercaDe objfrmAcercaDe = new frmAcercaDe();
            objfrmAcercaDe.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInscribir objinscribir = new frmInscribir();
            objinscribir.Show();
        }
    }
}
