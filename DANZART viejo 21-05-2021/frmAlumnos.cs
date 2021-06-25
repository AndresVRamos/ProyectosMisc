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
using Microsoft.Office.Tools.Excel;

namespace DANZART
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarAlumnos objmodificarAlumnos = new frmModificarAlumnos();
            objmodificarAlumnos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio objfrmInicio = new frmInicio();
            objfrmInicio.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            ConexionSQLServer Conectar = new ConexionSQLServer();
            Conectar.Abrir();
            string cadena = "SELECT * FROM VISTAALUMNOS";
            SqlCommand comando = new SqlCommand(cadena,Conectar.Conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            System.Data.DataTable tabla = new System.Data.DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            exportarexcel(dataGridView1);
        }
    }
}
