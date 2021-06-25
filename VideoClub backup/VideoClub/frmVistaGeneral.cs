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


namespace VideoClub
{
    public partial class frmVistaGeneral : Form
    {
        public frmVistaGeneral()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmVistaGeneral_Load(object sender, EventArgs e)
        {
            dgvVistaGeneral.DataSource = MostrarDatos();
            dgvEmpleadosDestacados.DataSource = MostrarDatosEmpleados();
            dgvClientesDestacados.DataSource = MostrarDatosClientes();
            dgvPeliculasPopulares.DataSource = MostrarDatosPeliculas();
            dgvFavoritas.DataSource = MostrarDatosFavoritos();

        }

        static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";

        SqlConnection sqlcon = new SqlConnection(cadena);

        private DataTable MostrarDatos()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from VistaGeneral", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private DataTable MostrarDatosFavoritos()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from VistaFavoritos", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private DataTable MostrarDatosEmpleados()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from VistaEmpleadosDestacados", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private DataTable MostrarDatosPeliculas()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from VistaPeliculasMasPopulares", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private DataTable MostrarDatosClientes()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from VistaClientesDestacados", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void dgvVistaGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
