﻿using System;
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
    public partial class frmModificarMensualidad : Form
    {
        public frmModificarMensualidad()
        {
            InitializeComponent();
        }

        //ConexionSQLServer Conectar = new ConexionSQLServer();
        SqlConnection Conectar = new SqlConnection("Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL);
        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDMENSUALIDAD FROM MENSUALIDADES", Conectar);
            da.Fill(ds, "MENSUALIDADES");
            cbxBusqueda.DataSource = ds.Tables[0].DefaultView;
            cbxBusqueda.ValueMember = "IDMENSUALIDAD";
            cbxBusquedaC.DataSource = ds.Tables[0].DefaultView;
            cbxBusquedaC.ValueMember = "IDMENSUALIDAD";

            DataSet ds2 = new DataSet();
            SqlDataAdapter cbus = new SqlDataAdapter("SELECT IDALUMNO FROM ALUMNOS", Conectar);
            cbus.Fill(ds2, "ALUMNOS");
            cbxAlumno.DataSource = ds2.Tables[0].DefaultView;
            cbxAlumno.ValueMember = "IDALUMNO";

        }

        public void llenardgv()
        {
            //conexion.Open();
            string cadena = "SELECT * FROM MENSUALIDADES";
            SqlCommand comando = new SqlCommand(cadena, Conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio Men = new frmInicio();
            this.Hide();
            Men.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmModificarMensualidad_Load(object sender, EventArgs e)
        {
            Conectar.Open();
            llenardgv();
            llenacombobox();
            Conectar.Close();

            btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIDMensualidad.Clear();
            tbxIDMensualidad.Enabled = true;
            //btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            lblAlumno.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIDMensualidad.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                string sql = "SELECT COUNT(*) FROM MENSUALIDADES WHERE IDMENSUALIDAD = " + tbxIDMensualidad.Text + " ;";
                SqlCommand command = new SqlCommand(sql, Conectar);
                Conectar.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                Conectar.Close();
                if (count == 0)
                {
                    string agregar = "INSERT INTO MENSUALIDADES VALUES (" + tbxIDMensualidad.Text + "," + cbxAlumno.Text + ",'" + dtInicio.Value.ToShortDateString() +
                    "','" + dtFin.Value.ToShortDateString() + "')";
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
                    MessageBox.Show("El Id de la mensualidad ya existe");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "SELECT * FROM MENSUALIDADES WHERE IDMENSUALIDAD = " + cbxBusqueda.Text;
            SqlCommand comando2 = new SqlCommand(cadena, Conectar);
            Conectar.Open();
            SqlDataAdapter adaptador2 = new SqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            dataGridView1.DataSource = tabla2;
            Conectar.Close();

            string Consulta = "SELECT * FROM MENSUALIDADES WHERE IDMENSUALIDAD =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Consulta, Conectar);
            Conectar.Open();
            comando.Parameters.AddWithValue("IDMENSUALIDAD", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("IDALUMNO", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("FECHA_INI", cbxBusqueda.Text);
            comando.Parameters.AddWithValue("FECHA_FIN", cbxBusqueda.Text);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                tbxIDMensualidad.Text = reader["IDMENSUALIDAD"].ToString();
                cbxAlumno.Text = reader["IDALUMNO"].ToString();
                dtInicio.Text = reader["FECHA_INI"].ToString();
                dtFin.Text = reader["FECHA_FIN"].ToString();
                lblAlumno.Visible = false;
            }
            Conectar.Close();
            tbxIDMensualidad.Enabled = false;
            btnModificar.Enabled = true;
            //btnEliminar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificarIDAlumno = "UPDATE MENSUALIDADES SET IDALUMNO = " + cbxAlumno.Text + ", FECHA_INI = '"+ dtInicio.Text +"', FECHA_FIN = '"+ dtFin.Text +"' where IDMENSUALIDAD = " + tbxIDMensualidad.Text;
            //string modificarfecha1 = "UPDATE MENSUALIDADES SET FECHA_INI = '" + dtInicio.Text + "' where IDMENSUALIDAD = " + tbxIDMensualidad.Text;
            //string modificarfecha2 = "UPDATE MENSUALIDADES SET FECHA_FIN = '" + dtFin.Text + "' where IDMENSUALIDAD = " + tbxIDMensualidad.Text;
            SqlCommand comandoID = new SqlCommand(modificarIDAlumno, Conectar);
            //SqlCommand comandoC = new SqlCommand(modificarfecha1, Conectar);
            //SqlCommand comandoI = new SqlCommand(modificarfecha2, Conectar);
            Conectar.Open();
            SqlDataReader readerID = comandoID.ExecuteReader();
            if (readerID.Read() == false)
            {
                readerID.Close();
                llenardgv();
                MessageBox.Show("Registro Modificado Correctamente");
            }
            else
            {
                readerID.Close();
                MessageBox.Show("Error al Modificar la Mensualidad");
            }

            /*SqlDataReader readerC = comandoC.ExecuteReader();
            if (readerC.Read() == false)
            {
                readerC.Close();
                llenardgv();
                //MessageBox.Show("Registro Cantidad modificado correctamente");
            }
            else
            {
                readerC.Close();
                MessageBox.Show("Error al Modificar la fecha de pago");
            }

            SqlDataReader readerI = comandoI.ExecuteReader();
            if (readerI.Read() == false)
            {
                readerI.Close();
                llenardgv();
                MessageBox.Show("Registro Mensualidades modificado correctamente");
            }
            else
            {
                readerI.Close();
                MessageBox.Show("Error al Modificar la fecha de vencimiento");
            }*/

            Conectar.Close();

            btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE MENSUALIDADES WHERE IDMENSUALIDAD =" + cbxBusqueda.Text;
            SqlCommand comando = new SqlCommand(Eliminar, Conectar);
            Conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read() == false)
            {
                reader.Close();
                MessageBox.Show("Registro Eliminado Correctamente");
                llenardgv();
                tbxIDMensualidad.Clear();
                tbxIDMensualidad.Enabled = true;
                //btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                lblAlumno.Visible = false;
            }
            else
            {
                reader.Close();
                MessageBox.Show("Error al Eliminar");
            }
            Conectar.Close();
            llenacombobox();

            btnModificar.Enabled = false;
            //btnEliminar.Enabled = false;
        }

        private void tbxIDMensualidad_KeyPress(object sender, KeyPressEventArgs e)
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


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Consultaf = "SELECT * FROM ALUMNOS WHERE IDALUMNO =" + cbxAlumno.Text;
            SqlCommand comandof = new SqlCommand(Consultaf, Conectar);
            Conectar.Open();
            comandof.Parameters.AddWithValue("NOMBRE_A", lblAlumno.Text);
            SqlDataReader readerf = comandof.ExecuteReader();
            if (readerf.Read())
            {
                lblAlumno.Text = readerf["NOMBRE_A"].ToString();
            }
            Conectar.Close();
            lblAlumno.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
