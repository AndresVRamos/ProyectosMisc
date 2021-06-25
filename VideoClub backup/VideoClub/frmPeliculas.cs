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
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
        }


        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Peliculas Registradas: " + MostrarCantidadPeliculas().ToString();

        }

        static string cadena = "Data Source=26.209.163.41, 1433;Initial Catalog=VIDEOCLUB;Persist Security Info=True;User ID=Admin;Password=1234";
        SqlConnection sqlcon = new SqlConnection(cadena);

        private int MostrarCantidadPeliculas()
        {
            sqlcon.Open();
            int Cantidad = 0;

            try
            {
                SqlCommand sqlcmd = new SqlCommand("select DBO.CONTEOPELICULAS()", sqlcon);
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
                SqlCommand sqlcmd = new SqlCommand("select * from PELICULA", sqlcon);
                SqlDataAdapter Da = new SqlDataAdapter(sqlcmd);
                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            return Dt;
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InsertarPelicula(txtId.Text.Trim(), txtNombre.Text.Trim(), txtDirector.Text.Trim(), txtFechaEstreno.Text.Trim(), txtClasificacion.Text.Trim()), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPeliculas.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Peliculas Registradas: " + MostrarCantidadPeliculas().ToString();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EliminarPelicula(txtId.Text.Trim()), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvPeliculas.DataSource = MostrarDatos();
            lblCantidad.Text = "Cantidad de Peliculas Registradas: " + MostrarCantidadPeliculas().ToString();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ModificarPelicula(txtId.Text.Trim(), txtNombre.Text.Trim(), txtDirector.Text.Trim(), txtFechaEstreno.Text.Trim(), txtClasificacion.Text.Trim()));
            dgvPeliculas.DataSource = MostrarDatos();
            Limpiar();
        }

        private string InsertarPelicula(string id_pelicula, string nombre, string director, string fecha_estreno, string clasificacion)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("INSERT INTO PELICULA VALUES('" + id_pelicula + "', '" + nombre + "', '" + director + "', '" + fecha_estreno + "', '" + clasificacion + "', '')", sqlcon);
                sqlcmd.ExecuteNonQuery();
                rpta = "Pelicula Insertada Correctamente";
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                rpta = "No se pudo insertar la película.";
            }
            sqlcon.Close();
            return rpta;

        }

        private string EliminarPelicula(string id_pelicula)
        {
            string rpta = "";
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand("DELETE PELICULA WHERE id_pelicula = " + id_pelicula, sqlcon);
                int filas = sqlcmd.ExecuteNonQuery();
                if (filas != 0)
                {
                    rpta = "Datos Eliminados Exitosamente.";
                    
                }
                else
                {
                    rpta = "No se ha podido eliminar la película.";
                }
            sqlcon.Close();
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido eliminar la película.";
            }
            sqlcon.Close();
            return rpta;
        }

        private string ModificarPelicula(string id_pelicula, string nombre, string director, string fecha_estreno, string clasificacion)
        {
            string rpta = "";
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE PELICULA set nombre = '" + nombre + "', director = '" + director + "', fecha_estreno ='" + fecha_estreno + "', clasificacion = '" + clasificacion + "' WHERE id_pelicula = '" + id_pelicula + "'", sqlcon);
                int filas = sqlcmd.ExecuteNonQuery();
                if (filas != 0)
                {
                    rpta = "Pelicula Modificada Exitosamente";
                }
                else
                {
                    rpta = "No se ha podido modificar la pelicula.";
                }
            }
            catch (Exception ex)
            {
                rpta = "No se ha podido modificar la pelicula.";
            }
            sqlcon.Close();
            return rpta;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDirector.Clear();
            txtFechaEstreno.Clear();
            txtClasificacion.Clear();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPeliculas.Sort(dgvPeliculas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnASC_Click(object sender, EventArgs e)
        {
            dgvPeliculas.Sort(dgvPeliculas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Ascending);
        }

        private void btnDESC_Click(object sender, EventArgs e)
        {
            dgvPeliculas.Sort(dgvPeliculas.Columns[cbxOrdenar.SelectedIndex], ListSortDirection.Descending);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = MostrarDatos();
            bs.Filter = cbxBuscar.Text + " like '%" + txtBuscar.Text + "%'";
            dgvPeliculas.DataSource = bs;
        }

        private void dgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPeliculas.CurrentRow.Cells["id_pelicula"].Value.ToString();
            txtNombre.Text = dgvPeliculas.CurrentRow.Cells["nombre"].Value.ToString();
            txtDirector.Text = dgvPeliculas.CurrentRow.Cells["director"].Value.ToString();
            txtFechaEstreno.Text = dgvPeliculas.CurrentRow.Cells["fecha_estreno"].Value.ToString();
            txtClasificacion.Text = dgvPeliculas.CurrentRow.Cells["clasificacion"].Value.ToString();
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
            exportarexcel(dgvPeliculas);
        }
    }
}
