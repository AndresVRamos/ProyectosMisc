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
using Microsoft.Office.Interop.Excel;

namespace VideoClub
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Clientes Actuales: " + MostrarCantidadClientes().ToString();

        }

        /*CADENA VIEJA (MIA)
         * static string cadena = "Data Source = 26.209.163.41, 1433;Initial Catalog=VIDEOCLUB; Integrated Security=true";*/

        static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";

        SqlConnection sqlcon = new SqlConnection(cadena);

        private int MostrarCantidadClientes()
        {
            sqlcon.Open();
            int Cantidad = 0;

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select DBO.CONTEOCLIENTES()", sqlcon);
                Cantidad = (int)sqlcmd.ExecuteScalar();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                sqlcon.Close();
            }
            return Cantidad;
        }

        private System.Data.DataTable MostrarDatos()
        {
            System.Data.DataTable Dt = new System.Data.DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from CLIENTE", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private string InsertarCliente(string id_credencial, string nombre, string apellido, string direccion, string telefono, string edad)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO CLIENTE VALUES ( '" + id_credencial + "', '" + nombre + "', '" + apellido + "', '" + direccion + "', " + telefono + ", '" + edad + "', '')", sqlcon);
                sqlcmd.ExecuteNonQuery();
                rpta = "Cliente Insertado/a Correctamente";
                
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
                
            }
            sqlcon.Close();
            return rpta;

        }

        private string EliminarCliente(string id_credencial)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DELETE CLIENTE WHERE id_credencial = " + id_credencial, sqlcon);
                int filas = sqlcmd.ExecuteNonQuery();
                if (filas != 0)
                {
                    rpta = "cliente Eliminado Exitosamente";
                }
                else
                {
                    rpta = "No se ha podido modificar al cliente";
                }
                
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido eliminar al cliente.";
            }
            sqlcon.Close();
            return rpta;
        }

        private string ModificarCliente(string id_credencial, string nombre, string apellido, string direccion, string telefono, string edad)
        {
            string rpta = "";
            try
            {

                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE CLIENTE set nombre = '" + nombre + "', apellido = '" + apellido + "', direccion ='" + direccion + "', telefono = '" + telefono + "', edad = '" + edad + "' WHERE id_credencial = '" + id_credencial + "'", sqlcon);
                int filas = sqlcmd.ExecuteNonQuery();
                if (filas != 0)
                {
                    rpta = "Datos Modificados Exitosamente";
                }
                else
                {
                    rpta = "No se ha podido modificar al cliente";
                }
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido modificar al cliente";
            }
            sqlcon.Close();
            return rpta;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InsertarCliente(txtId.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEdad.Text.Trim()), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvClientes.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Clientes Actuales: " + MostrarCantidadClientes().ToString();
            Limpiar();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EliminarCliente(txtId.Text.Trim()));
            dgvClientes.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Clientes Actuales: " + MostrarCantidadClientes().ToString();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ModificarCliente(txtId.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEdad.Text.Trim()));
            dgvClientes.DataSource = MostrarDatos();
            Limpiar();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvClientes.Sort(dgvClientes.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            dgvClientes.Sort(dgvClientes.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            dgvClientes.Sort(dgvClientes.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Descending);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = MostrarDatos();
            bs.Filter = cbxBuscar.Text + " like '%" + txtBuscar.Text + "%'";
            dgvClientes.DataSource = bs;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvClientes.CurrentRow.Cells["id_credencial"].Value.ToString();
            txtNombre.Text = dgvClientes.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells["apellido"].Value.ToString();
            txtDireccion.Text = dgvClientes.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells["telefono"].Value.ToString();
            txtEdad.Text = dgvClientes.CurrentRow.Cells["edad"].Value.ToString();
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

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            exportarexcel(dgvClientes);
        }
    }
}
