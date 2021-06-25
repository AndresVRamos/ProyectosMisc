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
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarAlumnos objfrmAlumnos = new frmModificarAlumnos();
            objfrmAlumnos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarEmpleados objfrmEmpleados = new frmModificarEmpleados();
            objfrmEmpleados.Show();
        }

        private void horarioDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarHorario objHorario = new frmModificarHorario();
            objHorario.Show();
        }

        private void mensualidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarMensualidad objMensualidades = new frmModificarMensualidad();
            objMensualidades.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarGrupos objfrmGrupos = new frmModificarGrupos();
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

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarClases objclases = new frmModificarClases();
            objclases.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblDiaHora.Text = DateTime.Now.ToString();
        }
    }
}
