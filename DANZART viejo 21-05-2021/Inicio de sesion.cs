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
            Conectar.Abrir();
            string pass = "SELECT USUARIO, CONTRASENA FROM LOGINS WHERE USUARIO ='" + txbUsuario.Text + "' AND CONTRASENA = '" + txbPass.Text + "'";
            SqlCommand comando = new SqlCommand(pass, Conectar.Conectarbd);
            
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
            Conectar.Cerrar();
        }
        
        private void Inicio_de_sesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logins2();
        }
    }
}
