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

namespace VideoClub
{
    public partial class frmLogin : Form 
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
        }

        static string cadena = "Data Source=ANDRESV-PC\\SQLEXPRESS, 1433;Initial Catalog=VIDEOCLUBA;Persist Security Info=True;User ID=sa;Password=12345";
        SqlConnection sqlcon = new SqlConnection(cadena);

        public void login()
        {
            string contrasena = "SELECT USUARIO, CONTRASENA FROM LOGIN WHERE USUARIO ='" + txtUsuario.Text + "' AND CONTRASENA = '" + txtContrasena.Text + "'";
            SqlCommand comando = new SqlCommand(contrasena, sqlcon);
            sqlcon.Open();
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
                frmPrincipal inicio = new frmPrincipal();
                inicio.Show();
            }
            sqlcon.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            claseUsuarios.Instance.usuarioSQL = txtUsuario.Text.Trim();
            claseUsuarios.Instance.contrasenaSQL = txtContrasena.Text.Trim();
            login();
        }

        
    }
}
