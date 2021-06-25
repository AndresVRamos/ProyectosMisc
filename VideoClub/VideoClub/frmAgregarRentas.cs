using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class frmAgregarRentas : Form
    {
        public frmAgregarRentas()
        {
            InitializeComponent();
        }

        string nombreCliente;
        string nombreC;
        string nombreApellidoC;
        string nombreEmpleado;
        string nombreE;
        string nombreApellidoE;
        int claveC;
        int claveE;
        int claveP;
        decimal precioU;
        decimal precioTotal;
        decimal precioNeto;
        decimal precioCont;


        //static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";
        static string cadena = "Data Source=ANDRESV-PC\\SQLEXPRESS, 1433;Initial Catalog=VIDEOCLUBA;Persist Security Info=True;User ID=sa;Password=12345;";

        SqlConnection sqlcon = new SqlConnection(cadena);


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenacombobox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter cliente = new SqlDataAdapter("SELECT nombre FROM ClIENTE", sqlcon);
            cliente.Fill(ds, "CLIENTE");
            cbxCliente.DataSource = ds.Tables[0].DefaultView;
            cbxCliente.ValueMember = "nombre";
            

            DataSet ds2 = new DataSet();
            SqlDataAdapter empleado = new SqlDataAdapter("SELECT nombre FROM EMPLEADO", sqlcon);
            empleado.Fill(ds2, "EMPLEADO");
            cbxEmpleado.DataSource = ds2.Tables[0].DefaultView;
            cbxEmpleado.ValueMember = "nombre";

            DataSet ds3 = new DataSet();
            SqlDataAdapter pelicula = new SqlDataAdapter("SELECT nombre FROM PELICULA", sqlcon);
            pelicula.Fill(ds3, "PELICULA");
            cbxEmpleado.DataSource = ds2.Tables[0].DefaultView;
            cbxEmpleado.ValueMember = "nombre";
        }

        public void llenacombobox2()
        {
            SqlCommand comando = new SqlCommand("SELECT nombre, apellido FROM CLIENTE", sqlcon);
            sqlcon.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cbxCliente.Items.Add(registro["nombre"].ToString() + " " + registro["apellido"].ToString());
            }
            sqlcon.Close();

            SqlCommand comando2 = new SqlCommand("SELECT nombre, apellido FROM EMPLEADO", sqlcon);
            sqlcon.Open();
            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                cbxEmpleado.Items.Add(registro2["nombre"].ToString() + " " + registro2["apellido"].ToString());
            }
            sqlcon.Close();

            SqlCommand comando3 = new SqlCommand("SELECT nombre FROM PELICULA", sqlcon);
            sqlcon.Open();
            SqlDataReader registro3 = comando3.ExecuteReader();
            while (registro3.Read())
            {
                cbxPelicula.Items.Add(registro3["nombre"].ToString());
            }
            sqlcon.Close();
        }

        private void AgregarRentas_Load(object sender, EventArgs e)
        {
            llenacombobox2();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDiaHora.Text = DateTime.Now.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand comando = new SqlCommand("SELECT (precio_unitario) FROM PELICULA WHERE nombre = '" + cbxPelicula.Text.Trim() + "'", sqlcon);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                dgvRentaRegistrada.Rows.Add(cbxCliente.Text.Trim(), cbxEmpleado.Text.Trim(), cbxPelicula.Text.Trim(), String.Format("{0}", registro[0]));
            }

            for (int i = 0; i < dgvRentaRegistrada.Rows.Count; ++i)
            {
                precioCont += Convert.ToDecimal(dgvRentaRegistrada.Rows[i].Cells[3].Value);
            }
            precioTotal = (precioCont * Convert.ToDecimal(1.16));
            precioNeto = precioCont;
            lblPrecioNeto.Text = "Precio Neto: " + precioNeto.ToString();
            lblPrecioTotal.Text = "Precio Total con IVA: " + precioTotal.ToString();
            precioCont = 0;

            sqlcon.Close();

            cbxCliente.Enabled = false;
            cbxEmpleado.Enabled = false;

            
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            InsertarRenta();
            this.Dispose();
        }

        private void InsertarRenta()
        {

            try
            {
                using (sqlcon)
                {
                    sqlcon.Open();

                    string query = "INSERT INTO RENTA (fecha_renta, dia_entrega, id_credencial, id_pelicula, id_empleado, costo_final) VALUES (@param1, @param2, @param3, @param4, @param5, @param6)";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);


                    foreach (DataGridViewRow row in dgvRentaRegistrada.Rows)
                    {
                        //Sacando Clave Cliente
                        nombreApellidoC = row.Cells[0].Value.ToString();
                        nombreC = Regex.Match(nombreApellidoC, @"^([\w\-]+)").ToString();

                        SqlCommand queryNombre = new SqlCommand("SELECT id_credencial FROM CLIENTE WHERE nombre = '" + nombreC + "'", sqlcon);
                        SqlDataReader registro2 = queryNombre.ExecuteReader();

                        while (registro2.Read())
                        {
                            claveC = Convert.ToInt32(registro2[0]);
                        }
                        registro2.Close();

                        //Sacando Clave Empleado
                        nombreApellidoE = row.Cells[1].Value.ToString();
                        nombreE = Regex.Match(nombreApellidoE, @"^([\w\-]+)").ToString();

                        SqlCommand queryNombre2 = new SqlCommand("SELECT id_empleado FROM EMPLEADO WHERE nombre = '" + nombreE + "'", sqlcon);
                        SqlDataReader registro3 = queryNombre2.ExecuteReader();

                        while (registro3.Read())
                        {
                            claveE = Convert.ToInt32(registro3[0]);
                        }
                        registro3.Close();

                        //Sacando Clave Película
                        SqlCommand queryClaveP = new SqlCommand("SELECT id_pelicula FROM PELICULA WHERE nombre = '" + row.Cells[2].Value.ToString() + "'", sqlcon);
                        SqlDataReader registro4 = queryClaveP.ExecuteReader();

                        while (registro4.Read())
                        {
                            claveP = Convert.ToInt32(registro4[0]);
                        }
                        registro4.Close();


                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@param1", DateTime.Now);
                        cmd.Parameters.AddWithValue("@param2", dtpFechaEntrega.Value);
                        cmd.Parameters.AddWithValue("@param3", claveC);
                        cmd.Parameters.AddWithValue("@param4", claveP);
                        cmd.Parameters.AddWithValue("@param5", claveE);
                        cmd.Parameters.AddWithValue("@param6", (Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(1.16)));

                        cmd.ExecuteNonQuery();
                    }

                    sqlcon.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron insertar las rentas.", "Hubo un Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
