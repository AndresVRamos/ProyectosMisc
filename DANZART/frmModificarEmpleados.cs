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


    public partial class frmModificarEmpleados : Form
    {

        //ConexionSQLServer Conectar = new ConexionSQLServer();
        SqlConnection Conectar = new SqlConnection("Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL);
        public frmModificarEmpleados()
        {
            InitializeComponent();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDMAESTRO FROM MAESTROS", Conectar);
            da.Fill(ds, "MAESTROS");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDMAESTRO";
            cbxBusquedaM.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaM.ValueMember = "IDMAESTRO";
            cbxBusquedaE.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaE.ValueMember = "IDMAESTRO";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM VISTAEMPLEADOS";
            SqlCommand comando = new SqlCommand(cadena, Conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }


        private void frmModificarEmpleados_Load(object sender, EventArgs e)
        {
            cbxSexo.Items.Add("MASCULINO");
            cbxSexo.Items.Add("FEMENINO");
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

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDmaestro.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM MAESTROS WHERE IDMAESTRO = " + tbxIDmaestro.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar);
                Conectar.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Close();
                if (count == 0)
                {
                    string agregar = "INSERT INTO MAESTROS VALUES (" + tbxIDmaestro.Text + ",'" + tbxNombre.Text + "'," + tbxEdad.Text
                      + "," + tbxTelefono.Text + ",'" + cbxSexo.Text + "')";
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
                    MessageBox.Show("El id del Maestro ya existe");
                }
            }
                
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
            
                string modificarEdad = "UPDATE MAESTROS SET NOMBREM = '"+ tbxNombre.Text +"', EDADM = " + tbxEdad.Text + ", TELEFONOM = "+ tbxTelefono.Text + ", SEXO = '"+ tbxEdad.Text +"' where IDMAESTRO = " + tbxIDmaestro.Text;
                //string modificarNombre = "UPDATE MAESTROS SET NOMBREM = '" + tbxNombre.Text + "' where IDMAESTRO = " + tbxIDmaestro.Text;
                //string modificarTelefon = "UPDATE MAESTROS SET TELEFONOM = " + tbxTelefono.Text + " where IDMAESTRO = " + tbxIDmaestro.Text;
                //string modificarSexo = "UPDATE MAESTROS SET SEXO = '" + cbxSexo.Text + "' where IDMAESTRO = " + tbxIDmaestro.Text;
                SqlCommand comandoE = new SqlCommand(modificarEdad, Conectar);
                //SqlCommand comandoN = new SqlCommand(modificarNombre, Conectar);
                //SqlCommand comandoT = new SqlCommand(modificarTelefon, Conectar);
                //SqlCommand comandoS = new SqlCommand(modificarSexo, Conectar);
                Conectar.Open();
                SqlDataReader readerE = comandoE.ExecuteReader();
                if (readerE.Read() == false)
                {
                    readerE.Close();
                    llenardgv();
                    MessageBox.Show("El maestro se Modifico Correctamente");
                }
                else
                {
                    readerE.Close();
                    MessageBox.Show("No se modifico correctamente");
                }

                /*SqlDataReader readerN = comandoN.ExecuteReader();
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

                SqlDataReader readerT = comandoT.ExecuteReader();
                if (readerT.Read() == false)
                {
                    readerT.Close();
                    llenardgv();
                    MessageBox.Show("Registro Telefono Modificado Correctamente");
                }
                else
                {
                    readerT.Close();
                    MessageBox.Show("Error al Modificar el Telefono");
                }

                SqlDataReader readerS = comandoS.ExecuteReader();
                if (readerS.Read() == false)
                {
                    readerS.Close();
                    llenardgv();
                    MessageBox.Show("Maestro Modificado Correctamente");
                }
                else
                {
                    readerS.Close();
                    MessageBox.Show("Error al Modificar el Sexo");
                }*/
                Conectar.Close();

                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE MAESTROS WHERE IDMAESTRO ="+ cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar);
            Conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                llenardgv();
                tbxIDmaestro.Clear();
                tbxNombre.Clear();
                tbxEdad.Clear();
                tbxTelefono.Clear();
                tbxIDmaestro.Enabled = true;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIDmaestro.Clear();
            tbxNombre.Clear();
            tbxEdad.Clear();
            tbxTelefono.Clear();
            tbxIDmaestro.Enabled = true;
        }

        private void tbxIDmaestro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxBusqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM MAESTROS WHERE IDMAESTRO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREM", lblNombre.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre.Text = readerf["NOMBREM"].ToString();
            }
            Conectar.Close();
            lblNombre.Visible = true;
        }

        private void cbxBusquedaM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM MAESTROS WHERE IDMAESTRO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREM", lblNombre2.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre2.Text = readerf["NOMBREM"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM MAESTROS WHERE IDMAESTRO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREM", lblNombre3.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre3.Text = readerf["NOMBREM"].ToString();
            }
            Conectar.Close();
        }

        public void busqueda()
        {
            string cadena = "SELECT * FROM MAESTROS WHERE IDMAESTRO = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar);
            Conectar.Open();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Close();

            string Consulta = "SELECT * FROM MAESTROS WHERE IDMAESTRO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar);
            Conectar.Open();
            comando.Parameters.AddWithValue("NOMBREM", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDMAESTRO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("EDADM", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("TELEFONOM", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("SEXO", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDmaestro.Text = reader["IDMAESTRO"].ToString();
                tbxNombre.Text = reader["NOMBREM"].ToString();
                tbxEdad.Text = reader["EDADM"].ToString();
                tbxTelefono.Text = reader["TELEFONOM"].ToString();
                cbxSexo.Text = reader["SEXO"].ToString();
            }
            Conectar.Close();
            tbxIDmaestro.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            busqueda();
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
