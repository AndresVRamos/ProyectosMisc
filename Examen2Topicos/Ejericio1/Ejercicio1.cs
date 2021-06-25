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

namespace Ejericio1
{
    public partial class Ejercicio1frm : Form
    {
        Graphics objetoDibujador;
        private Point[] puntos;
        Bitmap canvas;
        private Point primerPunto, segundoPunto, tercerPunto, cuartoPunto;
        public Ejercicio1frm()
        {
            InitializeComponent();
            puntos = new Point[0];
            canvas = new Bitmap(pbxCuadro.Width, pbxCuadro.Height);
        }

        private void Ejercicio1frm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rellenar(Bitmap bitmap, int x, int y, Color color)
        {
            Stack<Point> area = new Stack<Point>();
            pbxCuadro.BackColor = Color.Blue;
            area.Push(primerPunto);

            while (area.Count > 0)
            {
                Point a = area.Pop();
                if (a.X < canvas.Width && a.X > 0 &&
                    a.Y < canvas.Height && a.Y > 0)
                {
                    if (canvas.GetPixel(a.X, a.Y) == pbxCuadro.BackColor)
                    {
                        canvas.SetPixel(a.X, a.Y, Color.Blue);
                        area.Push(new Point(a.X - 1, a.Y));
                        area.Push(new Point(a.X + 1, a.Y));
                        area.Push(new Point(a.X, a.Y - 1));
                        area.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            //pbxCuadro.Refresh();
            return;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Graphics objetoDibujador = pbxCuadro.CreateGraphics();
            int punto1 = int.Parse(txtPrimerPunto.Text);
            int punto2 = int.Parse(txtSegundoPunto.Text);
            int punto3 = int.Parse(txtTercerPunto.Text);
            int punto4 = int.Parse(txtCuartoPunto.Text);
            Pen miLapiz = new Pen(new SolidBrush(Color.Black), 5);
            Rectangle puntos = new Rectangle(punto1, punto2, punto3, punto4);
            objetoDibujador.DrawEllipse(miLapiz, puntos);
            //rellenar(canvas, 1, 1, Color.Blue);
        }
    }
}
