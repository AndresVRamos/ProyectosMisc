using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCiudades2.Items.RemoveAt(cbxCiudades2.SelectedIndex);
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            cbxCiudades2.Items.Add("Hermosillo");
            cbxCiudades2.Items.Add("Obregon");
            cbxCiudades2.Items.Add("Nueva York");
            cbxCiudades2.Items.Add("Los Angeles");
            cbxCiudades2.Items.Add("Berlin");
            cbxCiudades2.Items.Add("Roma");
            cbxCiudades2.Items.Add("Madrid");
            cbxCiudades2.Items.Add("Minnesota");
            cbxCiudades2.Items.Add("Detroit");
            cbxCiudades2.Items.Add("Cleveland");
            cbxCiudades2.Items.Add("San Francisco");
            cbxCiudades2.Items.Add("Tokyo");
            cbxCiudades2.Items.Add("Sydney");
            cbxCiudades2.Items.Add("Monterrey");
            cbxCiudades2.Items.Add("Londres");
        }
    }
}
