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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void frmCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cbxNegritas_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Font = new Font(lblResultado.Font.Name, lblResultado.Font.Size,
                lblResultado.Font.Style ^ FontStyle.Bold);
        }

        private void cbxCursivo_CheckedChanged(object sender, EventArgs e)
        {
            lblResultado.Font = new Font(lblResultado.Font.Name, lblResultado.Font.Size,
                lblResultado.Font.Style ^ FontStyle.Italic);
        }

        private void nudTamano_ValueChanged(object sender, EventArgs e)
        {
            lblResultado.Font = new Font(lblResultado.Font.Name, (float) nudTamano.Value,
                lblResultado.Font.Style);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
