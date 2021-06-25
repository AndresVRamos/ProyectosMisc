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

        ConexionSQLServer Conectar = new ConexionSQLServer();

        public frmModificarAlumnos()
        {
            InitializeComponent();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDGRUPO FROM GRUPOS", Conectar.Conectarbd);
            da.Fill(ds,"GRUPOS");
            cbxGrupo.DataSource = ds.Tables[0].DefaultView;
            cbxGrupo.ValueMember ="IDGRUPO";

            DataSet ds2 = new DataSet();
            SqlDataAdapter cbus = new SqlDataAdapter("SELECT IDALUMNO FROM ALUMNOS", Conectar.Conectarbd);
            cbus.Fill(ds2, "ALUMNOS");
            cbxBusqueda.DataSource = ds2.Tables[0].DefaultView;
            cbxBusqueda.ValueMember ="IDALUMNO";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM VISTAALUMNOS";
            SqlCommand comando = new SqlCommand(cadena, Conectar.Conectarbd);
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
                SqlCommand command = new SqlCommand(sql, Conectar.Conectarbd);
                Conectar.Abrir();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Cerrar();
                if (count == 0)
                {
                    double alturaN = double.Parse(tbxAltura.Text) / 100;
                    double pesoN = double.Parse(tbxPeso.Text) / 1000;
                    String Altura = alturaN.ToString() + "M";
                    String Peso = pesoN.ToString() + "KG";

                    string agregar = "insert into ALUMNOS values ( " + tbxIdalumno.Text + ",'" + tbxNombre.Text + "','" + tbxApellidoP.Text + "','"
                    + tbxApellidoM.Text + "'," + tbxEdad.Text + ",'" + Peso + "','" + Altura + "','" + tbxDireccion.Text + "',"
                    + tbxTelefono.Text + ",'" + tbxNss.Text + "'," + cbxGrupo.Text + ")";
                    SqlCommand comando = new SqlCommand(agregar, Conectar.Conectarbd);
                    Conectar.Abrir();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read() == false)
                    {
                        reader.Close();
                        MessageBox.Show("Registro Agregado Correctamente");
                        string cadena = "SELECT * FROM VISTAALUMNOS";
                        SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
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
                    Conectar.Cerrar();
                }
                else
                {
                    MessageBox.Show("El Id del Alumno ya existe");
                }
            }
        }

        private void ModificarAlumnos_Load(object sender, EventArgs e)
        {
            Conectar.Abrir();
            llenacombobox();
            llenardgv();
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlumnos objfrmAlumnos = new frmAlumnos();
            objfrmAlumnos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete ALUMNOS where IDALUMNO = " + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(eliminar, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                string cadena = "SELECT * FROM VISTAALUMNOS";
                SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
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
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double alturaN = double.Parse(tbxAltura.Text) / 100;
            double pesoN = double.Parse(tbxPeso.Text) / 1000;
            String Altura = alturaN.ToString() + "M";
            String Peso = pesoN.ToString() + "KG";

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

            SqlCommand comandoN = new SqlCommand(modificarNombre, Conectar.Conectarbd);
            SqlCommand comandoAM = new SqlCommand(modificarAPEMAT, Conectar.Conectarbd);
            SqlCommand comandoAP = new SqlCommand(modificarAPEPAT, Conectar.Conectarbd);
            SqlCommand comandoE = new SqlCommand(modificarEdad, Conectar.Conectarbd);
            SqlCommand comandoP = new SqlCommand(modificarPeso, Conectar.Conectarbd);
            SqlCommand comandoA = new SqlCommand(modificarAltura, Conectar.Conectarbd);
            SqlCommand comandoD = new SqlCommand(modificarDir, Conectar.Conectarbd);
            SqlCommand comandoT = new SqlCommand(modificarTelefono, Conectar.Conectarbd);
            SqlCommand comandoNSS = new SqlCommand(modificarNSS, Conectar.Conectarbd);
            SqlCommand comandoG = new SqlCommand(modificarGrupo, Conectar.Conectarbd);

            Conectar.Abrir();
            SqlDataReader readerN = comandoN.ExecuteReader();
            if (readerN.Read() == false)
            {
                readerN.Close();
                llenardgv();
                //MessageBox.Show("El nombre se Modifico Correctamente");
            }
            else
            {
                readerN.Close();
                MessageBox.Show("No se modifico el Nombre");
            }

            SqlDataReader readerAP = comandoAP.ExecuteReader();
            if (readerAP.Read() == false)
            {
                readerAP.Close();
                llenardgv();
                //MessageBox.Show("El Apeliido Materno se Modifico Correctamente");
            }
            else
            {
                readerAP.Close();
                MessageBox.Show("No se modifico el Apellido Materno");
            }

            SqlDataReader readerE = comandoE.ExecuteReader();
            if (readerE.Read() == false)
            {
                readerE.Close();
                llenardgv();
                //MessageBox.Show("El Apeliido Paterno se Modifico Correctamente");
            }
            else
            {
                readerE.Close();
                MessageBox.Show("No se modifico el Apellido Paterno");
            }

            SqlDataReader readerAM = comandoAM.ExecuteReader();
            if (readerAM.Read() == false)
            {
                readerAM.Close();
                llenardgv();
                //MessageBox.Show("El Apeliido Materno se Modifico Correctamente");
            }
            else
            {
                readerAM.Close();
                MessageBox.Show("No se modifico el Apellido Materno");
            }

            SqlDataReader readerP = comandoP.ExecuteReader();
            if (readerP.Read() == false)
            {
                readerP.Close();
                llenardgv();
                //MessageBox.Show("El Peso se Modifico Correctamente");
            }
            else
            {
                readerP.Close();
                MessageBox.Show("No se modifico el Peso");
            }

            SqlDataReader readerA = comandoA.ExecuteReader();
            if (readerA.Read() == false)
            {
                readerA.Close();
                llenardgv();
                //MessageBox.Show("La Altura se Modifico Correctamente");
            }
            else
            {
                readerA.Close();
                MessageBox.Show("No se modifico la Altura");
            }

            SqlDataReader readerD = comandoD.ExecuteReader();
            if (readerD.Read() == false)
            {
                readerD.Close();
                llenardgv();
                //MessageBox.Show("La Direccion se Modifico Correctamente");
            }
            else
            {
                readerD.Close();
                MessageBox.Show("No se modifico la Direccion");
            }

            SqlDataReader readerT = comandoT.ExecuteReader();
            if (readerT.Read() == false)
            {
                readerT.Close();
                llenardgv();
                //MessageBox.Show("El Telefono se Modifico Correctamente");
            }
            else
            {
                readerT.Close();
                MessageBox.Show("No se modifico el Telefono");
            }

            SqlDataReader readerNSS = comandoNSS.ExecuteReader();
            if (readerNSS.Read() == false)
            {
                readerNSS.Close();
                llenardgv();
                //MessageBox.Show("El NSS se Modifico Correctamente");
            }
            else
            {
                readerNSS.Close();
                MessageBox.Show("No se modifico el NSS");
            }

            SqlDataReader readerG = comandoG.ExecuteReader();
            if (readerG.Read() == false)
            {
                readerG.Close();
                llenardgv();
                MessageBox.Show("El Alumno se Modifico Correctamente");
            }
            else
            {
                readerG.Close();
                MessageBox.Show("No se modifico el NSS");
            }
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            string cadena = "SELECT * FROM ALUMNOS where IDALUMNO = "+ cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Cerrar();

            string Consulta = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar.Conectarbd);
            Conectar.Abrir();
            comando.Parameters.AddWithValue("IDALUMNO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("NOMBRE_A", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("APELLIDO_MAT", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("APELLIDO_PAT", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("EDAD_A", cbxBusqueda.Text);
            //comando.Parameters.AddWithValue("PESO", cbxBusqueda.Text);
            //comando.Parameters.AddWithValue("ALTURA", cbxBusqueda.Text);
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
                //tbxPeso.Text = reader["PESO"].ToString();
                //tbxAltura.Text = reader["ALTURA"].ToString();
                tbxDireccion.Text = reader["DIRECCION"].ToString();
                tbxTelefono.Text = reader["TELEFONO"].ToString();
                tbxNss.Text = reader["NSS"].ToString();
                cbxGrupo.Text = reader["IDGRUPO"].ToString();
            }
            Conectar.Cerrar();
            tbxIdalumno.Enabled = false;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
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
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar.Conectarbd);
            Conectar.Abrir();
            comandof.Parameters.AddWithValue("NOMBREG", LblGrupo.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                LblGrupo.Text = readerf["NOMBREG"].ToString();
            }
            Conectar.Cerrar();
            LblGrupo.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
