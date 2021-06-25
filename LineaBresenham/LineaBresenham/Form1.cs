using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LineaBresenham
{
    public partial class Form1 : Form
    {
        Graphics objetoG;
        Brush br = (Brush)Brushes.Black;
        Pen myPen = new Pen(Color.PaleVioletRed, 1);

        public Form1()
        {
            InitializeComponent();
            objetoG = pbxArea.CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                GraficarLinea(Int32.Parse(txtX1.Text), Int32.Parse(txtY1.Text), Int32.Parse(txtX2.Text), Int32.Parse(txtY2.Text));
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

        void GraficarLinea(int x1, int y1, int x2, int y2)
        {
            int slope;
            int dx, dy, incE, incNE, d, x, y;

            if (x1 > x2)
            {
                GraficarLinea(x2, y2, x1, y1);
                return;
            }
            dx = x2 - x1;
            dy = y2 - y1;

            if (dy < 0)
            {
                slope = -1;
                dy = -dy;
            }
            else
            { slope = 1; }

            incE = 2 * dy;
            incNE = 2 * dy - 2 * dx;
            d = 2 * dy - dx;
            y = y1;

            for (x = x1; x <= x2; x++)
            {
                System.Threading.Thread.Sleep(100);
                PutPixel(x + (pbxArea.Width/2), (pbxArea.Height/2) - y); if (d <= 0)
                { d += incE; }
                else { d += incNE; y += slope; }
                
            }
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            objetoG.DrawLine(myPen, (pbxArea.Width / 2) - 1, 0, (pbxArea.Width / 2) - 1, pbxArea.Height);
            objetoG.DrawLine(myPen, 0, (pbxArea.Height / 2) + 1, pbxArea.Width, (pbxArea.Height / 2) + 1);
        }
        
    }
}
