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
    public partial class frmInscribir : Form
    {
        public frmInscribir()
        {
            InitializeComponent();
        }

        ConexionSQLServer Conectar = new ConexionSQLServer();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio objfrmInicio = new frmInicio();
            objfrmInicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDLOGIN FROM LOGINS", Conectar.Conectarbd);
            da.Fill(ds, "LOGINS");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDLOGIN";

        }

        private void frmInscribir_Load(object sender, EventArgs e)
        {
            tbxNuevaContra.Enabled = false;
            Conectar.Abrir();
            llenacombobox();
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM LOGINS WHERE IDLOGIN = " + tbxIDlogin.Text + " ;";
            SqlCommand command = new SqlCommand(sql, Conectar.Conectarbd);
            Conectar.Abrir();
            int count = Convert.ToInt32(command.ExecuteScalar());
            Conectar.Cerrar();
            if (count == 0)
            {
                string agregar = "INSERT INTO LOGINS VALUES (" + tbxIDlogin.Text + ",'" + tbxNomUsu.Text + "','" + tbxContra.Text
                  + "')";
                SqlCommand comando = new SqlCommand(agregar, Conectar.Conectarbd);
                Conectar.Abrir();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read() == false)
                {
                    reader.Close();
                    MessageBox.Show("Registro Agregado Correctamente");
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Error al Agregar");
                }
                Conectar.Cerrar();
                llenacombobox();
            }
            else
            {
                MessageBox.Show("El id del Login ya existe");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIDlogin.Clear();
            tbxNomUsu.Clear();
            tbxContra.Clear();
            tbxNuevaContra.Clear();
            tbxIDlogin.Enabled = true;
            tbxNuevaContra.Enabled = false;
            tbxNomUsu.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT * FROM LOGINS WHERE IDLOGIN = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            //dataGridView1.DataSource = tabla2;
            Conectar.Cerrar();

            string Consulta = "SELECT * FROM LOGINS WHERE IDLOGIN =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar.Conectarbd);
            Conectar.Abrir();
            comando.Parameters.AddWithValue("IDLOGIN", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("USUARIO", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDlogin.Text = reader["IDLOGIN"].ToString();
                tbxNomUsu.Text = reader["USUARIO"].ToString();
            }
            Conectar.Cerrar();
            tbxIDlogin.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            tbxNuevaContra.Enabled = true;
            tbxNomUsu.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarContra = "UPDATE LOGINS SET USUARIO = '" + tbxNomUsu.Text +"', CONTRASENA = '"+tbxNuevaContra.Text+ "' where IDLOGIN = (SELECT IDLOGIN FROM LOGINS WHERE USUARIO = '"+tbxNomUsu.Text+"' AND CONTRASENA = '"+tbxContra.Text+"')" ;
            
            SqlCommand comandoC = new SqlCommand(modificarContra, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader readerC = comandoC.ExecuteReader();
            if (readerC.Read() == false)
            {
                readerC.Close();
                //llenardgv();
                MessageBox.Show("Se modifico correctamente la Contraseña");
            }
            else
            {
                readerC.Close();
                MessageBox.Show("No se modifico la edad");
            }
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE LOGINS WHERE IDLOGIN =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
            }
            else
            {
                reader.Close();
                MessageBox.Show("Error al Eliminar");
            }
            Conectar.Cerrar();
            llenacombobox();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void tbxIDlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
