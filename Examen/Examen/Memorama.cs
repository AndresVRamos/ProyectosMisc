using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen
{
    public partial class Memorama : Form
    {
        /*int Par1 = 0;
        int Par2 = 0;
        int Par3 = 0;
        int Par4 = 0;*/
        int Contador = 0;

        Boolean revelar1 = false;
        Boolean revelar2 = false;
        Boolean revelar3 = false;
        Boolean revelar4 = false;
        Boolean revelar5 = false;
        Boolean revelar6 = false;
        Boolean revelar7 = false;
        Boolean revelar8 = false;
        Boolean Correcto1 = false;
        Boolean Correcto2 = false;
        Boolean Correcto3 = false;
        Boolean Correcto4 = false;
        Boolean Correcto5 = false;
        Boolean Correcto6 = false;
        Boolean Correcto7 = false;
        Boolean Correcto8 = false;

        public Memorama()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox2.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox4.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox5.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox6.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox7.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox8.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
        }

        public void Comprobar()
        {
            if (Contador == 2)
            {
                if (revelar1 == true && revelar8 == true)
                {
                    Correcto1 = true;
                    Correcto8 = true;
                }

                if (revelar2 == true && revelar4 == true)
                {
                    Correcto4 = true;
                    Correcto2 = true;
                }

                if (revelar3 == true && revelar5 == true)
                {
                    Correcto3 = true;
                    Correcto5 = true;
                }

                if (revelar6 == true && revelar7 == true)
                {
                    Correcto6 = true;
                    Correcto7 = true;
                }

                Reinicio();
                Contador = 0;
                
            }
            if (revelar1 == true && revelar2 == true && revelar3 == true && revelar4 == true
                && revelar5 == true && revelar6 == true && revelar7 == true && revelar8 == true)
            {
                MessageBox.Show("Ganaste", "Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ImagenNegra();
            }
        }

        public void Reinicio()
        {
            if (Correcto1 == false)
            {
                pictureBox1.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar1 = false;
            }
            if (Correcto2 == false)
            {
                pictureBox2.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar2 = false;
            }
            if (Correcto3 == false)
            {
                pictureBox3.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar3 = false;
            }
            if (Correcto4 == false)
            {
                pictureBox4.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar4 = false;
            }
            if (Correcto5 == false)
            {
                pictureBox5.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar5 = false;
            }
            if (Correcto6 == false)
            {
                pictureBox6.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar6 = false;
            }
            if (Correcto7 == false)
            {
                pictureBox7.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar7 = false;
            }
            if (Correcto8 == false)
            {
                pictureBox8.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
                revelar8 = false;
            }
        }

        public void ImagenNegra()
        {
            pictureBox1.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox2.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox3.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox4.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox5.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox6.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox7.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            pictureBox8.Image = Image.FromFile("D:\\Pictures\\Oculto.jpg");
            revelar1 = false;
            revelar2 = false;
            revelar3 = false;
            revelar4 = false;
            revelar5 = false;
            revelar6 = false;
            revelar7 = false;
            revelar8 = false;
            Correcto1 = false;
            Correcto2 = false;
            Correcto3 = false;
            Correcto4 = false;
            Correcto5 = false;
            Correcto6 = false;
            Correcto7 = false;
            Correcto8 = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo1.jpg");
            revelar1 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo2.jpg");
            revelar2 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo3.jpg");
            revelar3 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo2.jpg");
            revelar4 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo3.jpg");
            revelar5 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo4.jpg");
            revelar6 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo4.jpg");
            revelar7 = true;
            Contador++;
            Comprobar();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo1.jpg");
            revelar8 = true;
            Contador++;
            Comprobar();
        }
    }
}
