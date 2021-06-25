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
    public partial class frmMensualidades : Form
    {
        public frmMensualidades()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio objfrmInicio = new frmInicio();
            objfrmInicio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMensualidades_Load(object sender, EventArgs e)
        {
            ConexionSQLServer Conectar = new ConexionSQLServer(); 
            string cadena = "SELECT * FROM VISTAMENSUALIDADES";
            SqlCommand comando = new SqlCommand(cadena, Conectar.Conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarMensualidad Mensualidad = new frmModificarMensualidad();
            this.Hide();
            Mensualidad.Show();
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            exportarexcel(dataGridView1);
        }
    }
}
