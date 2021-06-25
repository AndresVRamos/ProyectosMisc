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
    public partial class frmModificarGrupos : Form
    {
        ConexionSQLServer Conectar = new ConexionSQLServer();
        public frmModificarGrupos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio AbrirInicio = new frmInicio();
            AbrirInicio.Show();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDGRUPO FROM GRUPOS", Conectar.Conectarbd);
            da.Fill(ds, "GRUPOS");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDGRUPO";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM VISTAGRUPOS";
            SqlCommand comando = new SqlCommand(cadena, Conectar.Conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void frmModificarGrupos_Load(object sender, EventArgs e)
        {
            Conectar.Abrir();
            llenardgv();
            llenacombobox();
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIDgrupo.Clear();
            tbxNombre.Clear();
            tbxNivel.Clear();
            tbxIDgrupo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDgrupo.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM GRUPOS WHERE IDGRUPO = " + tbxIDgrupo.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar.Conectarbd);
                Conectar.Abrir();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Cerrar();
                if (count == 0)
                {
                    string agregar = "INSERT INTO GRUPOS VALUES (" + tbxIDgrupo.Text + ",'" + tbxNombre.Text + "','" + tbxNivel.Text + "')";
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
                    MessageBox.Show("El Id del grupo ya existe");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT * FROM GRUPOS WHERE IDGRUPO = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Cerrar();

            string Consulta = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar.Conectarbd);
            Conectar.Abrir();
            comando.Parameters.AddWithValue("NOMBREG", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDGRUPO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("NIVEL", cbxBusqueda.Text);

            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDgrupo.Text = reader["IDGRUPO"].ToString();
                tbxNombre.Text = reader["NOMBREG"].ToString();
                tbxNivel.Text = reader["NIVEL"].ToString();
                
            }
            Conectar.Cerrar();
            tbxIDgrupo.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarNombre = "UPDATE GRUPOS SET NOMBREG = '" + tbxNombre.Text + "' where IDGRUPO = " + tbxIDgrupo.Text;
            string modificarNivel = "UPDATE GRUPOS SET NIVEL = '" + tbxNivel.Text + "' where IDGRUPO = " + tbxIDgrupo.Text;
            SqlCommand comandoNom = new SqlCommand(modificarNombre, Conectar.Conectarbd);
            SqlCommand comandoNiv = new SqlCommand(modificarNivel, Conectar.Conectarbd);

            Conectar.Abrir();
            SqlDataReader readerNom = comandoNom.ExecuteReader();
            if (readerNom.Read() == false)
            {
                readerNom.Close();
                llenardgv();
                MessageBox.Show("El Nombre se Modifico Correctamente");
            }
            else
            {
                readerNom.Close();
                MessageBox.Show("No se modifico el Nombre");
            }

            SqlDataReader readerNiv = comandoNiv.ExecuteReader();
            if (readerNiv.Read() == false)
            {
                readerNiv.Close();
                llenardgv();
                MessageBox.Show("El Nivel se Modifico Correctamente");
            }
            else
            {
                readerNiv.Close();
                MessageBox.Show("No se modifico el Nivel");
            }
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                llenardgv();
                tbxIDgrupo.Clear();
                tbxNombre.Clear();
                tbxNivel.Clear();
                tbxIDgrupo.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
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

        private void tbxIDgrupo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
