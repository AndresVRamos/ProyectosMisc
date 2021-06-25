using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirculodeBresenham
{
    public partial class frmCirculo : Form
    {
        Graphics objetoG;
        Brush br = (Brush)Brushes.Black;
        Pen myPen = new Pen(Color.Black, 1);
        Pen myPen2 = new Pen(Color.PaleVioletRed, 1);

        public frmCirculo()
        {
            InitializeComponent();
            objetoG = pbxArea.CreateGraphics();
        }

        private void frmCirculo_Paint(object sender, PaintEventArgs e)
        {
            objetoG.DrawLine(myPen2, (pbxArea.Width / 2) - 1, 0, (pbxArea.Width / 2) - 1, pbxArea.Height);
            objetoG.DrawLine(myPen2, 0, (pbxArea.Height / 2) + 1, pbxArea.Width, (pbxArea.Height / 2) + 1);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                GraficarCirculo(Int32.Parse(txtX.Text), Int32.Parse(txtY.Text), Int32.Parse(txtR.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Porfavor verifica tu entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void PutPixel(int x, int y)
        {
            objetoG.FillRectangle(br, x, y, 2, 2);
        }

        void GraficarCirculo(int x, int y, int r)
        {
            int x1 = 0;
            int y1 = r;
            int d = 3 - (2 * r);
            while (x1 <= y1)

            {
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) + x1, ((pbxArea.Height/2) - y) + y1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) - x1, ((pbxArea.Height / 2) - y) + y1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) + x1, ((pbxArea.Height / 2) - y) - y1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) - x1, ((pbxArea.Height / 2) - y) - y1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) + y1, ((pbxArea.Height / 2) - y) + x1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) - y1, ((pbxArea.Height / 2) - y) + x1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) + y1, ((pbxArea.Height / 2) - y) - x1, 1, 1);
                System.Threading.Thread.Sleep(50);
                objetoG.DrawRectangle(myPen, (x + pbxArea.Width / 2) - y1, ((pbxArea.Height / 2) - y) - x1, 1, 1);

                if (d < 0)

                    d += 4 * x1 + 6;

                else

                {

                    d += 4 * (x1 - y1) + 10;

                    y1--;

                }

                x1++;

            }
        }
    }
}
