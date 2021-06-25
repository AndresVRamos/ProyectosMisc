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
    public partial class OpAritmeticasPotencia : Form
    {
        public OpAritmeticasPotencia()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            var resultado = Aritmetica.OperacionesAritmeticas.Potencia(double.Parse(txtbxValorA.Text), double.Parse(txtbxValorB.Text));
            lblResultado.Text = String.Format("Resultado = {0}", resultado);
        }
    }
}
