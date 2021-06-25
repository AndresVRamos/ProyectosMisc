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
    public partial class frmKeyPress : Form
    {
        public frmKeyPress()
        {
            InitializeComponent();
        }

        private void frmKeyPress_Load(object sender, EventArgs e)
        {
            
        }

        private void frmKeyPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblTeclaPresionada.Text = e.KeyChar.ToString();
        }

        private void frmKeyPress_KeyDown(object sender, KeyEventArgs e)
        {
            lblALT.Text = e.Alt ? "Si" : "NO";
            lblSHIFT.Text = e.Shift ? "SI" : "NO";
            lblCTRL.Text = e.Control ? "SI" : "NO";
            lblKEYCODE.Text = e.KeyCode.ToString();
            lblKEYDATA.Text = e.KeyData.ToString();
            lblKEYVALUE.Text = e.KeyValue.ToString();
        }
    }
}
