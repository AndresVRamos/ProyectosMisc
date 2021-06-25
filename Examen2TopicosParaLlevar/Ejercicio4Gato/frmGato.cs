using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gato
{
    public partial class frmGato : Form
    {
        Boolean jugadorActual = true;
        int contadorTurnos = 0;

        public frmGato()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button1.Text = "X";
                jugadorActual = false;
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "O";
                jugadorActual = true;
                button1.Enabled = false;

            }
            comprobarGanador();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button2.Text = "X";
                jugadorActual = false;
                button2.Enabled = false;
            }
            else
            {
                button2.Text = "O";
                jugadorActual = true;
                button2.Enabled = false;

            }
            comprobarGanador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button3.Text = "X";
                jugadorActual = false;
                button3.Enabled = false;
            }
            else
            {
                button3.Text = "O";
                jugadorActual = true;
                button3.Enabled = false;
            }
            comprobarGanador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button4.Text = "X";
                jugadorActual = false;
                button4.Enabled = false;
            }
            else
            {
                button4.Text = "O";
                jugadorActual = true;
                button4.Enabled = false;

            }
            comprobarGanador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button5.Text = "X";
                jugadorActual = false;
                button5.Enabled = false;
            }
            else
            {
                button5.Text = "O";
                jugadorActual = true;
                button5.Enabled = false;

            }
            comprobarGanador();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button6.Text = "X";
                jugadorActual = false;
                button6.Enabled = false;
            }
            else
            {
                button6.Text = "O";
                jugadorActual = true;
                button6.Enabled = false;

            }
            comprobarGanador();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button7.Text = "X";
                jugadorActual = false;
                button7.Enabled = false;
            }
            else
            {
                button7.Text = "O";
                jugadorActual = true;
                button7.Enabled = false;

            }
            comprobarGanador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button8.Text = "X";
                jugadorActual = false;
                button8.Enabled = false;
            }
            else
            {
                button8.Text = "O";
                jugadorActual = true;
                button8.Enabled = false;

            }
            comprobarGanador();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jugadorActual)
            {
                button9.Text = "X";
                jugadorActual = false;
                button9.Enabled = false;
            }
            else
            {
                button9.Text = "O";
                jugadorActual = true;
                button9.Enabled = false;
            }
            comprobarGanador();
        }

        public void comprobarGanador()
        {
            contadorTurnos += 1;
            if ((button1.Text == button2.Text && button2.Text == button3.Text && !button1.Enabled) ||
                (button4.Text == button5.Text && button5.Text == button6.Text && !button4.Enabled) ||
                (button7.Text == button8.Text && button8.Text == button9.Text && !button7.Enabled))
            {
                finJuego();

            }

            if ((button1.Text == button4.Text && button4.Text == button7.Text && !button1.Enabled) ||
                (button2.Text == button5.Text && button5.Text == button8.Text && !button2.Enabled) ||
                (button3.Text == button6.Text && button6.Text == button9.Text && !button3.Enabled))
            {
                finJuego();

            }

            if ((button3.Text == button5.Text && button5.Text == button7.Text && !button3.Enabled) ||
                (button1.Text == button5.Text && button5.Text == button9.Text && !button1.Enabled))
            {
                finJuego();
            }

            if (contadorTurnos == 9)
            {
                MessageBox.Show("Empate!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reiniciar();
            }
        }

        public void reiniciar()
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            jugadorActual = true;
            contadorTurnos = 0;
        }

        public void finJuego()
        {
            if (jugadorActual)
            {
                MessageBox.Show("Felicidades, gano O!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reiniciar();
            }
            else
            {
                MessageBox.Show("Felicidades, gano X!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reiniciar();
            }
        }
    }
}
