using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio4Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        double primerNumero;
        double segundoNumero;
        double resultado;
        string operacion;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void ntmPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primerNumero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primerNumero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primerNumero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primerNumero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(txtPantalla.Text);
            switch (operacion)
            {
                case "+":
                    {
                        resultado = primerNumero + segundoNumero;
                        txtPantalla.Text = resultado.ToString();
                        break;
                    }
                case "-":
                    {
                        resultado = primerNumero - segundoNumero;
                        txtPantalla.Text = resultado.ToString();
                        break;
                    }
                case "*":
                    {
                        resultado = primerNumero * segundoNumero;
                        txtPantalla.Text = resultado.ToString();
                        break;
                    }
                case "/":
                    {
                        if (segundoNumero != 0)
                        {
                            resultado = primerNumero / segundoNumero;
                            txtPantalla.Text = resultado.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        
                        break;
                    }

            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }
    }
}
