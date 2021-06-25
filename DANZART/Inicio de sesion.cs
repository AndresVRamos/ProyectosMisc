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
using System.Configuration;

namespace DANZART
{
    public partial class Inicio_de_sesion : Form
    {
        ConexionSQLServer Conectar = new ConexionSQLServer();

        public Inicio_de_sesion()
        {
            InitializeComponent();
        }
        /*
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT USUARIO, CONTRASENA FROM LOGINS WHERE USUARIO='" + txbUsuario.Text + "' AND CONTRASENA = '" + txbPass.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("LOGIN EXITOSO");
                            frmInicio inicio = new frmInicio();
                            inicio.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("DATO INCORRECTO");
                        }

                    }
                    conexion.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        */
        
        public void logins2()
        {
            //Conectar.Abrir();
            string Cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=ACADEMIA;Persist Security Info=True;User ID=Admin;Password=admin1";
            SqlConnection bdc = new SqlConnection(Cadena);
            //bdc.ConnectionString = Cadena;
            string pass = "SELECT USUARIO, CONTRASENA FROM LOGINS WHERE USUARIO ='" + txbUsuario.Text + "' AND CONTRASENA = '" + txbPass.Text + "'";

            SqlCommand comando = new SqlCommand(pass, bdc);

            bdc.Open();
            
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false) 
            {
                reader.Close();
                MessageBox.Show("Contraseña o Usuario Incorrecta");
            }
            else
            {
                reader.Close();
                MessageBox.Show("Bienvenido");
                this.Hide();
                frmInicio inicio = new frmInicio();
                inicio.Show();
            }
            //Conectar.Cerrar();
            bdc.Close();
        }
        
        private void Inicio_de_sesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            ClaseUsuarios.Instance.usuarioSQL = txbUsuario.Text.Trim();
            ClaseUsuarios.Instance.contrasenaSQL = txbPass.Text.Trim();
            logins2();
        }
    }
}
