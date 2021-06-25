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
    public partial class frmModificarAlumnos : Form
    {

        //ConexionSQLServer Conectar = new ConexionSQLServer();
        SqlConnection Conectar = new SqlConnection("Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL);

        public frmModificarAlumnos()
        {
            InitializeComponent();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDGRUPO FROM GRUPOS", Conectar);
            da.Fill(ds, "GRUPOS");
            cbxGrupo.DataSource = ds.Tables[0].DefaultView;
            cbxGrupo.ValueMember = "IDGRUPO";

            DataSet ds2 = new DataSet();
            SqlDataAdapter cbus = new SqlDataAdapter("SELECT IDALUMNO, NOMBRE_A FROM ALUMNOS", Conectar);
            cbus.Fill(ds2, "ALUMNOS");
            cbxBusqueda.DataSource = ds2.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDALUMNO";
            cbxBusquedaM.DataSource = ds2.Tables[0].DefaultView;
            cbxBusquedaM.ValueMember = "IDALUMNO";
            cbxBusquedaE.DataSource = ds2.Tables[0].DefaultView;
            cbxBusquedaE.ValueMember = "IDALUMNO";

        }

        public void llenacombobox2()
        {

            SqlCommand comando = new SqlCommand("SELECT IDALUMNO, NOMBRE_A, APELLIDO_PAT, APELLIDO_MAT FROM ALUMNOS", Conectar);
            Conectar.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbxBusqueda.Items.Add("ID:" + registro["IDALUMNO"].ToString() + "  | " + registro["NOMBRE_A"].ToString() + " " +
                    registro["APELLIDO_PAT"].ToString() + " " + registro["APELLIDO_MAT"].ToString());
            }
            Conectar.Close();

            SqlCommand comando2 = new SqlCommand("SELECT IDGRUPO, NOMBREG FROM GRUPOS", Conectar);
            Conectar.Open();
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cbxGrupo.Items.Add("ID:" + registro2["IDGRUPO"].ToString() + "  | " + registro2["NOMBREG"].ToString());
            }
            Conectar.Close();
        }
        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM VISTAALUMNOS";
            SqlCommand comando = new SqlCommand(cadena, Conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIdalumno.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM ALUMNOS WHERE IDALUMNO = " + tbxIdalumno.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar);
                Conectar.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Close();
                if (count == 0)
                {
                    double alturaN = double.Parse(tbxAltura.Text) / 100;
                    double pesoN = double.Parse(tbxPeso.Text) / 1000;
                    //String Altura = alturaN.ToString() + "M";
                    //String Peso = pesoN.ToString() + "KG";
                    String Altura = alturaN.ToString();
                    String Peso = pesoN.ToString();

                    string agregar = "insert into ALUMNOS values ( " + tbxIdalumno.Text + ",'" + tbxNombre.Text + "','" + tbxApellidoP.Text + "','"
                    + tbxApellidoM.Text + "'," + tbxEdad.Text + ",'" + Peso + "','" + Altura + "','" + tbxDireccion.Text + "',"
                    + tbxTelefono.Text + ",'" + tbxNss.Text + "'," + cbxGrupo.Text + ")";
                    SqlCommand comando = new SqlCommand(agregar, Conectar);
                    Conectar.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read() == false)
                    {
                        reader.Close();
                        MessageBox.Show("Registro Agregado Correctamente");
                        string cadena = "SELECT * FROM VISTAALUMNOS";
                        SqlCommand comando2 = new SqlCommand(cadena, Conectar);
                        SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
                        DataTable tabla2 = new DataTable();
                        adaptador2.Fill(tabla2);
                        dataGridView1.DataSource = tabla2;
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Error al Agregar");
                    }
                    llenacombobox();
                    Conectar.Close();
                }
                else
                {
                    MessageBox.Show("El Id del Alumno ya existe");
                }
            }
        }

        private void ModificarAlumnos_Load(object sender, EventArgs e)
        {
            Conectar.Open();
            llenacombobox();
            llenardgv();
            Conectar.Close();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio objfrmAlumnos = new frmInicio();
            objfrmAlumnos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete ALUMNOS where IDALUMNO = " + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(eliminar, Conectar);
            Conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                string cadena = "SELECT * FROM VISTAALUMNOS";
                SqlCommand comando2 = new SqlCommand(cadena, Conectar);
                SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
                DataTable tabla2 = new DataTable();
                adaptador2.Fill(tabla2);
                dataGridView1.DataSource = tabla2;
                tbxIdalumno.Clear();
                tbxNombre.Clear();
                tbxApellidoM.Clear();
                tbxApellidoP.Clear();
                tbxNss.Clear();
                tbxDireccion.Clear();
                tbxEdad.Clear();
                tbxPeso.Clear();
                tbxAltura.Clear();
                tbxTelefono.Clear();

                tbxIdalumno.Enabled = true;
                LblGrupo.Visible = false;
            }
            else
            {
                reader.Close();
                MessageBox.Show("Error al Eliminar");
            }
            llenacombobox();
            Conectar.Close();

            //btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double alturaN = double.Parse(tbxAltura.Text);
            double pesoN = double.Parse(tbxPeso.Text);
            String Altura = alturaN.ToString();
            String Peso = pesoN.ToString();

            /*
            string modificarNombre = "UPDATE ALUMNOS SET NOMBRE_A = '" + tbxNombre.Text + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarAPEMAT = "UPDATE ALUMNOS SET APELLIDO_MAT = '" + tbxApellidoM.Text + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarAPEPAT = "UPDATE ALUMNOS SET APELLIDO_PAT = '" + tbxApellidoP.Text + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarEdad = "UPDATE ALUMNOS SET EDAD_A = " + tbxEdad.Text + " where IDALUMNO = " + tbxIdalumno.Text;
            string modificarPeso = "UPDATE ALUMNOS SET PESO = '" + Peso + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarAltura = "UPDATE ALUMNOS SET ALTURA = '" + Altura + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarDir = "UPDATE ALUMNOS SET DIRECCION = '" + tbxDireccion.Text + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarTelefono = "UPDATE ALUMNOS SET TELEFONO = " + tbxTelefono.Text + " where IDALUMNO = " + tbxIdalumno.Text;
            string modificarNSS = "UPDATE ALUMNOS SET NSS = '" + tbxNss.Text + "' where IDALUMNO = " + tbxIdalumno.Text;
            string modificarGrupo = "UPDATE ALUMNOS SET IDGRUPO = " + cbxGrupo.Text + " where IDALUMNO = " + tbxIdalumno.Text;

            SqlCommand comandoN = new SqlCommand(modificarNombre, Conectar);
            SqlCommand comandoAM = new SqlCommand(modificarAPEMAT, Conectar);
            SqlCommand comandoAP = new SqlCommand(modificarAPEPAT, Conectar);
            SqlCommand comandoE = new SqlCommand(modificarEdad, Conectar);
            SqlCommand comandoP = new SqlCommand(modificarPeso, Conectar);
            SqlCommand comandoA = new SqlCommand(modificarAltura, Conectar);
            SqlCommand comandoD = new SqlCommand(modificarDir, Conectar);
            SqlCommand comandoT = new SqlCommand(modificarTelefono, Conectar);
            SqlCommand comandoNSS = new SqlCommand(modificarNSS, Conectar);
            SqlCommand comandoG = new SqlCommand(modificarGrupo, Conectar);
            */

            string modificarAlumno = "UPDATE ALUMNOS SET NOMBRE_A = '" + tbxNombre.Text + "', APELLIDO_PAT = '" + tbxApellidoP.Text + "', APELLIDO_MAT = '" + tbxApellidoM.Text + "', EDAD_A = " + tbxEdad.Text + ", PESO = " + tbxPeso.Text + ", ALTURA = " + tbxAltura.Text + ", DIRECCION = '" + tbxDireccion.Text + "', TELEFONO = " + tbxTelefono.Text + ", NSS = '" + tbxNss.Text + "', IDGRUPO = " + cbxGrupo.Text + " WHERE IDALUMNO = " + tbxIdalumno.Text; SqlCommand comandoModificar = new SqlCommand();
            SqlCommand comandoM = new SqlCommand(modificarAlumno, Conectar);
            Conectar.Open();

            SqlDataReader readerM = comandoM.ExecuteReader();
            if (readerM.Read() == false)
            {
                readerM.Close();
                llenardgv();
                MessageBox.Show("El nombre se Modifico Correctamente");
            }
            else
            {
                readerM.Close();
                MessageBox.Show("No se modifico el Nombre");
            }

            Conectar.Close();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        public void busqueda()
        {
            string cadena = "SELECT * FROM ALUMNOS where IDALUMNO = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar);
            Conectar.Open();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Close();

            string Consulta = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar);
            Conectar.Open();
            comando.Parameters.AddWithValue("IDALUMNO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("NOMBRE_A", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("APELLIDO_MAT", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("APELLIDO_PAT", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("EDAD_A", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("PESO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("ALTURA", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("DIRECCION", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("TELEFONO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("NSS", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDGRUPO", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIdalumno.Text = reader["IDALUMNO"].ToString();
                tbxNombre.Text = reader["NOMBRE_A"].ToString();
                tbxApellidoM.Text = reader["APELLIDO_MAT"].ToString();
                tbxApellidoP.Text = reader["APELLIDO_PAT"].ToString();
                tbxEdad.Text = reader["EDAD_A"].ToString();
                tbxPeso.Text = reader["PESO"].ToString();
                tbxAltura.Text = reader["ALTURA"].ToString();
                tbxDireccion.Text = reader["DIRECCION"].ToString();
                tbxTelefono.Text = reader["TELEFONO"].ToString();
                tbxNss.Text = reader["NSS"].ToString();
                cbxGrupo.Text = reader["IDGRUPO"].ToString();
            }
            Conectar.Close();
            //tbxIdalumno.Enabled = false;

            //btnModificar.Enabled = true;
            //btnEliminar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIdalumno.Clear();
            tbxNombre.Clear();
            tbxApellidoM.Clear();
            tbxApellidoP.Clear();
            tbxNss.Clear();
            tbxDireccion.Clear();
            tbxEdad.Clear();
            tbxPeso.Clear();
            tbxAltura.Clear();
            tbxTelefono.Clear();

            tbxIdalumno.Enabled = true;
            LblGrupo.Visible = false;

        }

        private void cbxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxIdalumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxIdalumno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxNss_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo escribir la cantidad en Centimetros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbxPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo escribir la cantidad en gramos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbxGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM GRUPOS WHERE IDGRUPO =" + cbxGrupo.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBREG", LblGrupo.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                LblGrupo.Text = readerf["NOMBREG"].ToString();
            }
            Conectar.Close();
            LblGrupo.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LblGrupo_Click(object sender, EventArgs e)
        {

        }

        private void cbxBusqueda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBRE_A", lblNombre.Text);
            comandof.Parameters.AddWithValue("APELLIDO_PAT", lblApellidoPat.Text);
            comandof.Parameters.AddWithValue("APELLIDO_MAT", lblApellidoMat.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre.Text = readerf["NOMBRE_A"].ToString();
                lblApellidoPat.Text = readerf["APELLIDO_PAT"].ToString();
                lblApellidoMat.Text = readerf["APELLIDO_MAT"].ToString();
            }
            Conectar.Close();
            lblNombre.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            busqueda();
            btnModificar.Enabled = true;
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
        {
            busqueda();
            btnEliminar.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            llenardgv();
            exportarexcel(dataGridView1);
        }

        private void cbxBusquedaM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBRE_A", lblNombre2.Text);
            comandof.Parameters.AddWithValue("APELLIDO_PAT", lblApellidoPat2.Text);
            comandof.Parameters.AddWithValue("APELLIDO_MAT", lblApellidoMat2.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre2.Text = readerf["NOMBRE_A"].ToString();
                lblApellidoPat2.Text = readerf["APELLIDO_PAT"].ToString();
                lblApellidoMat2.Text = readerf["APELLIDO_MAT"].ToString();
            }
            Conectar.Close();
        }

        private void cbxBusquedaE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxBusqueda.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBRE_A", lblNombre3.Text);
            comandof.Parameters.AddWithValue("APELLIDO_PAT", lblApellidoPat3.Text);
            comandof.Parameters.AddWithValue("APELLIDO_MAT", lblApellidoMat3.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblNombre3.Text = readerf["NOMBRE_A"].ToString();
                lblApellidoPat3.Text = readerf["APELLIDO_PAT"].ToString();
                lblApellidoMat3.Text = readerf["APELLIDO_MAT"].ToString();
            }
            Conectar.Close();
        }
    }
}
