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
        //ConexionSQLServer Conectar = new ConexionSQLServer();
        SqlConnection Conectar = new SqlConnection("Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL);
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
            frmInicio OpenInicio = new frmInicio();
            OpenInicio.Show();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDGRUPO FROM GRUPOS", Conectar);
            da.Fill(ds, "GRUPOS");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDGRUPO";
            cbxBusquedaM.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaM.ValueMember = "IDGRUPO";
            cbxBusquedaE.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaE.ValueMember = "IDGRUPO";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM VISTAGRUPOS";
            SqlCommand comando = new SqlCommand(cadena, Conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void frmModificarGrupos_Load(object sender, EventArgs e)
        {
            Conectar.Open();
            llenardgv();
            llenacombobox();
            Conectar.Close();

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
                SqlCommand command = new SqlCommand(sql, Conectar);
                Conectar.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Close();
                if (count == 0)
                {
                    string agregar = "INSERT INTO GRUPOS VALUES (" + tbxIDgrupo.Text + ",'" + tbxNombre.Text + "','" + tbxNivel.Text + "')";
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
                    MessageBox.Show("El Id del grupo ya existe");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar()
        {
            string cadena = "SELECT * FROM GRUPOS WHERE IDGRUPO = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar);
            Conectar.Open();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Close();

            string Consulta = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar);
            Conectar.Open();
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
            Conectar.Close();
            tbxIDgrupo.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarNombre = "UPDATE GRUPOS SET NOMBREG = '" + tbxNombre.Text + "', NIVEL = '"+ tbxNivel.Text +"' where IDGRUPO = " + tbxIDgrupo.Text;
            //string modificarNivel = "UPDATE GRUPOS SET NIVEL = '" + tbxNivel.Text + "' where IDGRUPO = " + tbxIDgrupo.Text;
            SqlCommand comandoNom = new SqlCommand(modificarNombre, Conectar);
            //SqlCommand comandoNiv = new SqlCommand(modificarNivel, Conectar);

            Conectar.Open();
            SqlDataReader readerNom = comandoNom.ExecuteReader();
            if (readerNom.Read() == false)
            {
                readerNom.Close();
                llenardgv();
                MessageBox.Show("El Grupo se Modifico Correctamente");
            }
            else
            {
                readerNom.Close();
                MessageBox.Show("No se modifico Correctamente");
            }

            /*SqlDataReader readerNiv = comandoNiv.ExecuteReader();
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
            }*/
            Conectar.Close();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar);
            Conectar.Open();
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
            Conectar.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbxBusqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREG", lblNombre.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre.Text = readerf["NOMBREG"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREG", lblNombre2.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre2.Text = readerf["NOMBREG"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREG", lblNombre3.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre3.Text = readerf["NOMBREG"].ToString();
            }
            Conectar.Close();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            buscar();
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
