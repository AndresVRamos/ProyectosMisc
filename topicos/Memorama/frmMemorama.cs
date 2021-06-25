using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorama
{
    public partial class frmMemorama : Form
    {
        public frmMemorama()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMemorama_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo1.jpg");
            cargarFotos();
        }

        public int numeroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void cargarFotos()
        {
            
            Random rnd = new Random();
            int num = rnd.Next(8);

            pictureBox1.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox2.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox3.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox4.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox5.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox6.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox7.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox8.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox9.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox10.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox11.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox12.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox13.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox14.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox15.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            pictureBox16.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");

            /*List<PictureBox> listaPictureBoxes = new List<PictureBox>();

            for (int i = 0; i <= 16; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = string.Format("pictureBox{0}", i);
                label1.Text = pic.Name;
                listaPictureBoxes.Add(pic);
                pic.Image = Image.FromFile("D:\\Pictures\\Memorama\\memo" + numeroAleatorio(1, 8) + ".jpg");
            }*/

            //PictureBoxArray = new System.Windows.Forms.PictureBox[espacios];


        }
    }
}
