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
    public partial class frmVistaMatematica : Form
    {
        public frmVistaMatematica()
        {
            InitializeComponent();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana = new OperacionesAritmeticas();
            objVentana.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana2 = new OpAritmeticasRestar();
            objVentana2.Show();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana3 = new OpAritmeticasMultiplicar();
            objVentana3.Show();
        }

        private void divisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana4 = new OpAritmeticasDivision();
            objVentana4.Show();
        }

        private void potenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana5 = new OpAritmeticasPotencia();
            objVentana5.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana6 = new OpAritmeticasFibonacci();
            objVentana6.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana7 = new OpAritmeticasFactorial();
            objVentana7.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var objVentana8 = new OpGeometricasCirculo();
            objVentana8.Show();
        }

        private void operacionesAritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
