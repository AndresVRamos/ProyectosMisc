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

using System.IO;

namespace DANZART
{
    public partial class frmModificarClases : Form
    {
        public frmModificarClases()
        {
            InitializeComponent();
        }

        ConexionSQLServer Conectar = new ConexionSQLServer();
        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCLASE FROM CLASES", Conectar.Conectarbd);
            da.Fill(ds, "CLASES");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDCLASE";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM CLASES";
            SqlCommand comando = new SqlCommand(cadena, Conectar.Conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void frmModificarClases_Load(object sender, EventArgs e)
        {
            Conectar.Abrir();
            llenardgv();
            llenacombobox();
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio AbrirInicio = new frmInicio();
            AbrirInicio.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIDclase.Clear();
            tbxNombre.Clear();
            tbxIDclase.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDclase.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM ClASES WHERE IDCLASE = " + tbxIDclase.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar.Conectarbd);
                Conectar.Abrir();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Cerrar();
                if (count == 0)
                {
                    string agregar = "INSERT INTO CLASES VALUES (" + tbxIDclase.Text + ",'" + tbxNombre.Text + "')";
                    SqlCommand comando = new SqlCommand(agregar, Conectar.Conectarbd);
                    Conectar.Abrir();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read() == false)
                    {
                        reader.Close();
                        MessageBox.Show("Registro Agregado Correctamente");
                        llenardgv();
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
                    MessageBox.Show("El Id de la clase ya existe");
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT * FROM CLASES WHERE IDCLASE = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Cerrar();

            string Consulta = "SELECT * FROM CLASES WHERE IDCLASE =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar.Conectarbd);
            Conectar.Abrir();
            comando.Parameters.AddWithValue("NOMBREC", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDCLASE", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDclase.Text = reader["IDCLASE"].ToString();
                tbxNombre.Text = reader["NOMBREC"].ToString();
            }
            Conectar.Cerrar();
            tbxIDclase.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarNombre = "UPDATE CLASES SET NOMBREC = '" + tbxNombre.Text + "' where IDCLASE = " + tbxIDclase.Text;
            SqlCommand comandoN = new SqlCommand(modificarNombre, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader readerN = comandoN.ExecuteReader();
            if (readerN.Read() == false)
            {
                readerN.Close();
                llenardgv();
                MessageBox.Show("Registro Nombre Modificado Correctamente");
            }
            else
            {
                readerN.Close();
                MessageBox.Show("Error al Modificar el Nombre");
            }
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE CLASES WHERE IDCLASE =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                llenardgv();
                tbxIDclase.Clear();
                tbxNombre.Clear();
                tbxIDclase.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
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

        private void tbxIDclase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbxBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
