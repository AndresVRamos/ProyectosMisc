using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMatematica
{
    public partial class OpAritmeticasFibonacci : Form
    {
        public OpAritmeticasFibonacci()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var resultado = Aritmetica.OperacionesAritmeticas.SerieFibonacci(double.Parse(txtbxValorA.Text));
            lblResultado.Text = String.Format("Resultado = {0}", resultado);
        }
    }
}
