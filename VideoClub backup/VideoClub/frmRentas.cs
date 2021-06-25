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
    public partial class frmRentas : Form
    {
        public frmRentas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRentas_Load(object sender, EventArgs e)
        {
            dgvRentas.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Rentas Registradas: " + MostrarCantidadRentas().ToString();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvRentas.Sort(dgvRentas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";

        SqlConnection sqlcon = new SqlConnection(cadena);

        private int MostrarCantidadRentas()
        {
            sqlcon.Open();
            int Cantidad = 0;

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select DBO.CONTEORENTAS()", sqlcon);
                Cantidad = (int)sqlcmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            sqlcon.Close();
            return Cantidad;
        }

        private System.Data.DataTable MostrarDatos()
        {
            System.Data.DataTable Dt = new System.Data.DataTable();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select * from RENTA", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InsertarRenta(txtFecha.Text.Trim(), txtDias.Text.Trim(), txtIdCliente.Text.Trim(), txtIdPelicula.Text.Trim(), txtIdEmpleado.Text.Trim()), "Datos Insertados Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvRentas.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Rentas Registradas: " + MostrarCantidadRentas().ToString();
            Limpiar();
        }

        private string InsertarRenta(string fecha_renta, string dias_renta, string id_credencial, string id_pelicula, string id_empleado)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("EXECUTE dbo.INSERTAR_RENTA '" + fecha_renta + "', '" + dias_renta + "', '" + id_credencial + "', '" + id_pelicula + "', '" + id_empleado + "', ''", sqlcon);
                sqlcmd.ExecuteNonQuery();
                rpta = "Renta Realizada Correctamente";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
                sqlcon.Close();
            }
            return rpta;

        }

        private void Limpiar()
        {
            txtFecha.Clear();
            txtDias.Clear();
            txtIdCliente.Clear();
            txtIdPelicula.Clear();
            txtIdEmpleado.Clear();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            dgvRentas.Sort(dgvRentas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            dgvRentas.Sort(dgvRentas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Descending);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            string msg = "";
            try
            {
                bs.DataSource = MostrarDatos();
                bs.Filter = cbxBuscar.Text + " like '%" + txtBuscar.Text + "%'";
                dgvRentas.DataSource = bs;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás Seguro/a de que quieres Limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show(LimpiarRentas(), "Registo Reestablecido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRentas.DataSource = MostrarDatos();
            }
            lblCantidad.Text = "Cantidad de Rentas Registradas: " + MostrarCantidadRentas().ToString();
        }

        private string LimpiarRentas()
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DELETE RENTA \n" +
                    "UPDATE PELICULA SET popularidad = 0 \n" +
                    "UPDATE CLIENTE SET rentas_realizadas = 0 \n" +
                    "UPDATE EMPLEADO set rentas_registradas = 0", sqlcon);
                sqlcmd.ExecuteNonQuery();
                rpta = "Rentas Limpiadas Correctamente";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
                sqlcon.Close();
            }
            return rpta;
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

        private void dgvRentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            exportarexcel(dgvRentas);
        }
    }
}
