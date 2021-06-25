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
    public partial class frmEmpleado : Form
    {

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InsertarEmpleado(txtClave.Text.Trim(), txtPuesto.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim()), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEmpleados.DataSource = MostrarDatos();
            label4.Text = "Cantidad de Empleados Actuales: " + MostrarCantidadEmpleados().ToString();
            Limpiar();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = MostrarDatos();
            label4.Text = "Cantidad de Empleados Actuales: "+MostrarCantidadEmpleados().ToString();
        }

        static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";
        SqlConnection sqlcon = new SqlConnection(cadena);

        private int MostrarCantidadEmpleados()
        {
            sqlcon.Open();
            int Cantidad = 0;

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select DBO.CONTEOEMPLEADOS()", sqlcon);
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
                SqlCommand sqlcmd = new SqlCommand("select * from EMPLEADO", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            return Dt;
        }

        private string InsertarEmpleado(string id_empleado, string puesto, string nombre, string apellido, string telefono)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO EMPLEADO VALUES ('" +id_empleado + "', '" + puesto + "', '" + nombre + "', '" + apellido + "', '" + telefono + "', '')", sqlcon);
                int fila = sqlcmd.ExecuteNonQuery();
                if (fila != 0)
                {
                    rpta = "Datos Insertados Correctamente";
                }
                else
                {
                    rpta = "No se ha podido insertar el empleado";
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido insertar el empleado";
                sqlcon.Close();
            }
            return rpta;

        }

        private string EliminarEmpleado(string id_empleado)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DELETE EMPLEADO WHERE id_empleado = " + id_empleado, sqlcon);
                int fila = sqlcmd.ExecuteNonQuery();
                if (fila != 0)
                {
                    rpta = "Datos Eliminados Correctamente";
                }
                else
                {
                    rpta = "No se ha podido eliminar el empleado";
                }
                sqlcon.Close();
                
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido eliminar el empleado";
                sqlcon.Close();
            }
            return rpta;
        }

        private string ModificarEmpleado(string id_empleado, string puesto, string nombre, string apellido, string telefono)
        {
            string rpta = "";
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE EMPLEADO set puesto = '" + puesto + "', nombre = '" + nombre + "', apellido ='" + apellido + "', telefono = '" + telefono + "' WHERE id_empleado = '"+id_empleado+"'", sqlcon);
                int fila = sqlcmd.ExecuteNonQuery();
                if (fila != 0)
                {
                    rpta = "Datos Modificados Correctamente";
                }
                else
                {
                    rpta = "No se ha podido modificar el empleado";
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            sqlcon.Close();
            return rpta;
        }

        private void Limpiar()
        {
            txtClave.Clear();
            txtPuesto.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EliminarEmpleado(txtClave.Text.Trim()), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEmpleados.DataSource = MostrarDatos();
            label4.Text = "Cantidad de Empleados Actuales: " + MostrarCantidadEmpleados().ToString();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ModificarEmpleado(txtClave.Text.Trim(), txtPuesto.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtTelefono.Text.Trim()));
            dgvEmpleados.DataSource = MostrarDatos();
            Limpiar();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEmpleados.Sort(dgvEmpleados.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Sort(dgvEmpleados.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Sort(dgvEmpleados.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Descending);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = MostrarDatos();
            bs.Filter = cbxBuscar.Text + " like '%" + txtBuscar.Text + "%'";
            dgvEmpleados.DataSource = bs;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClave.Text = dgvEmpleados.CurrentRow.Cells["id_empleado"].Value.ToString();
            txtPuesto.Text = dgvEmpleados.CurrentRow.Cells["puesto"].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells["apellido"].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells["telefono"].Value.ToString();
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
            exportarexcel(dgvEmpleados);
        }
    }
}
