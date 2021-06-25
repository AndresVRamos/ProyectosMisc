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

        //ConexionSQLServer Conectar = new ConexionSQLServer();
        SqlConnection Conectar = new SqlConnection("Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL);

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCLASE FROM CLASES", Conectar);
            da.Fill(ds, "CLASES");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDCLASE";
            cbxBusquedaM.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaM.ValueMember = "IDCLASE";
            cbxBusquedaE.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaE.ValueMember = "IDCLASE";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM CLASES";
            SqlCommand comando = new SqlCommand(cadena, Conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void frmModificarClases_Load(object sender, EventArgs e)
        {
            Conectar.Open();
            llenardgv();
            llenacombobox();
            Conectar.Close();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio OpenInicio = new frmInicio();
            OpenInicio.Show();
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
                SqlCommand command = new SqlCommand(sql, Conectar);
                Conectar.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Close();
                if (count == 0)
                {
                    string agregar = "INSERT INTO CLASES VALUES (" + tbxIDclase.Text + ",'" + tbxNombre.Text + "')";
                    SqlCommand comando = new SqlCommand(agregar, Conectar);
                    Conectar.Open();
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
                    Conectar.Close();
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
            buscador();
        }

        public void buscador()
        {
            string cadena = "SELECT * FROM CLASES WHERE IDCLASE = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar);
            Conectar.Open();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Close();

            string Consulta = "SELECT * FROM CLASES WHERE IDCLASE =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar);
            Conectar.Open();
            comando.Parameters.AddWithValue("NOMBREC", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDCLASE", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDclase.Text = reader["IDCLASE"].ToString();
                tbxNombre.Text = reader["NOMBREC"].ToString();
            }
            Conectar.Close();
            tbxIDclase.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarNombre = "UPDATE CLASES SET NOMBREC = '" + tbxNombre.Text + "' where IDCLASE = " + tbxIDclase.Text;
            SqlCommand comandoN = new SqlCommand(modificarNombre, Conectar);
            Conectar.Open();
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
            Conectar.Close();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE CLASES WHERE IDCLASE =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar);
            Conectar.Open();
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
            Conectar.Close();
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

        private void cbxBusqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM CLASES WHERE IDCLASE =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREC", lblNombre.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre.Text = readerf["NOMBREC"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM CLASES WHERE IDCLASE =" + cbxBusquedaM.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREC", lblNombre2.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre2.Text = readerf["NOMBREC"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM CLASES WHERE IDCLASE =" + cbxBusquedaE.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREC", lblNombre3.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre3.Text = readerf["NOMBREC"].ToString();
            }
            Conectar.Close();
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            buscador();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            buscador();
        }

        public void exportarexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndiceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;

                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            llenardgv();
            exportarexcel(dataGridView1);
        }
    }
}
