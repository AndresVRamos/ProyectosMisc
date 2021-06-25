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
    public partial class frmModificarHorario : Form
    {
        ConexionSQLServer Conectar = new ConexionSQLServer();
        public frmModificarHorario()
        {
            InitializeComponent();
        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDIMPARTEN FROM IMPARTEN", Conectar.Conectarbd);
            da.Fill(ds, "IMPARTEN");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDIMPARTEN";
            cbxBusquedaM.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaM.ValueMember = "IDIMPARTEN";
            cbxBusquedaE.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaE.ValueMember = "IDIMPARTEN";

            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT IDCLASE FROM CLASES", Conectar.Conectarbd);
            da2.Fill(ds2, "CLASES");
            cbxClase.DataSource = ds2.Tables[0].DefaultView;
            cbxClase.ValueMember = "IDCLASE";

            DataSet ds3 = new DataSet();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT IDGRUPO FROM GRUPOS", Conectar.Conectarbd);
            da3.Fill(ds3, "GRUPOS");
            cbxGrupo.DataSource = ds3.Tables[0].DefaultView;
            cbxGrupo.ValueMember = "IDGRUPO";

            DataSet ds4 = new DataSet();
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT IDMAESTRO FROM MAESTROS", Conectar.Conectarbd);
            da4.Fill(ds4, "MAESTROS");
            cbxMaestro.DataSource = ds4.Tables[0].DefaultView;
            cbxMaestro.ValueMember = "IDMAESTRO";
        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT IDIMPARTEN, IDGRUPO, IDCLASE, IDMAESTRO, HORA, DIA FROM IMPARTEN";
            SqlCommand comando = new SqlCommand(cadena, Conectar.Conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void frmModificarHorario_Load(object sender, EventArgs e)
        {
            cbxDia.Items.Add("LUNES");
            cbxDia.Items.Add("MARTES");
            cbxDia.Items.Add("MIERCOLES");
            cbxDia.Items.Add("JUEVES");
            cbxDia.Items.Add("VIERNES");
            cbxDia.Items.Add("SABADO");
            cbxDia.Items.Add("DOMIGO");
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
            tbxIDhorario.Clear();
            tbxHora.Clear();
            tbxIDhorario.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDhorario.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM IMPARTEN WHERE IDIMPARTEN = " + tbxIDhorario.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar.Conectarbd);
                Conectar.Abrir();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Cerrar();
                if (count == 0)
                {
                    string agregar = "INSERT INTO IMPARTEN VALUES (" + cbxGrupo.Text + "," + cbxClase.Text + "," + cbxMaestro.Text
                      + ",'" + tbxHora.Text + "','" + cbxDia.Text + "'," + tbxIDhorario.Text + ")";
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
                    MessageBox.Show("El id de Imparten ya existe");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscador();
        }
        public void buscador()
        {
            string cadena = "SELECT * FROM IMPARTEN WHERE IDIMPARTEN = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Cerrar();

            string Consulta = "SELECT * FROM IMPARTEN WHERE IDIMPARTEN =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar.Conectarbd);
            Conectar.Abrir();
            comando.Parameters.AddWithValue("IDIMPARTEN", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDGRUPO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDCLASE", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDMAESTRO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("HORA", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("DIA", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDhorario.Text = reader["IDIMPARTEN"].ToString();
                tbxHora.Text = reader["HORA"].ToString();
                cbxDia.Text = reader["DIA"].ToString();
                cbxGrupo.Text = reader["IDGRUPO"].ToString();
                cbxClase.Text = reader["IDCLASE"].ToString();
                cbxMaestro.Text = reader["IDMAESTRO"].ToString();
            }
            Conectar.Cerrar();
            tbxIDhorario.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarIDGrupo = "UPDATE IMPARTEN SET IDGRUPO = " + cbxGrupo.Text + " where IDIMPARTEN = " + tbxIDhorario.Text;
            string modificarIDClase = "UPDATE IMPARTEN SET IDCLASE = " + cbxClase.Text + " where IDIMPARTEN = " + tbxIDhorario.Text;
            string modificarIDMaestro = "UPDATE IMPARTEN SET IDMAESTRO = " + cbxMaestro.Text + " where IDIMPARTEN = " + tbxIDhorario.Text;
            string modificarHora = "UPDATE IMPARTEN SET HORA = '" + tbxHora.Text + "' where IDIMPARTEN = " + tbxIDhorario.Text;
            string modificarDia = "UPDATE IMPARTEN SET DIA = '" + cbxDia.Text + "' where IDIMPARTEN = " + tbxIDhorario.Text;
            SqlCommand comandoG = new SqlCommand(modificarIDGrupo, Conectar.Conectarbd);
            SqlCommand comandoC = new SqlCommand(modificarIDClase, Conectar.Conectarbd);
            SqlCommand comandoM = new SqlCommand(modificarIDMaestro, Conectar.Conectarbd);
            SqlCommand comandoH = new SqlCommand(modificarHora, Conectar.Conectarbd);
            SqlCommand comandoD = new SqlCommand(modificarDia, Conectar.Conectarbd);


            Conectar.Abrir();
            SqlDataReader readerG = comandoG.ExecuteReader();
            if (readerG.Read() == false)
            {
                readerG.Close();
                llenardgv();
                //MessageBox.Show("La Edad se Modifico Correctamente");
            }
            else
            {
                readerG.Close();
                MessageBox.Show("No se modifico el Grupo");
            }

            SqlDataReader readerC = comandoC.ExecuteReader();
            if (readerC.Read() == false)
            {
                readerC.Close();
                llenardgv();
                //MessageBox.Show("Registro Nombre Modificado Correctamente");
            }
            else
            {
                readerC.Close();
                MessageBox.Show("Error al Modificar la Clase");
            }

            SqlDataReader readerM = comandoM.ExecuteReader();
            if (readerM.Read() == false)
            {
                readerM.Close();
                llenardgv();
                //MessageBox.Show("Registro Telefono Modificado Correctamente");
            }
            else
            {
                readerM.Close();
                MessageBox.Show("Error al Modificar el Maestro");
            }

            SqlDataReader readerH = comandoH.ExecuteReader();
            if (readerH.Read() == false)
            {
                readerH.Close();
                llenardgv();
                //MessageBox.Show("Registro Sexo Modificado Correctamente");
            }
            else
            {
                readerH.Close();
                MessageBox.Show("Error al Modificar la Hora");
            }

            SqlDataReader readerD = comandoD.ExecuteReader();
            if (readerD.Read() == false)
            {
                readerD.Close();
                llenardgv();
                MessageBox.Show("Se actualizo todo correctamente");
            }
            else
            {
                readerD.Close();
                MessageBox.Show("Error al Modificar el Dia");
            }
            Conectar.Cerrar();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE IMPARTEN WHERE IDIMPARTEN =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar.Conectarbd);
            Conectar.Abrir();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                llenardgv();
                tbxIDhorario.Clear();
                tbxHora.Clear();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Error al Eliminar");
            }
            Conectar.Cerrar();
            llenacombobox();

            tbxIDhorario.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            buscador();
        }

        private void btnBuscarE_Click(object sender, EventArgs e)
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
