using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintGraficacion
{
    public partial class frmPaint : Form
    {
        Graphics objetoG;
        Pen miPluma = new Pen(Color.Black, 2);
        int cont = 0;

        Point Punto1;
        Point Punto2;
        Point Punto3;

        Point[] P = new Point[100];


        enum figuras
        {
            Linea,
            Rectangulo,
            Circulo,
            Arco,
            Pie,
            Pentagono,
            Triangulo,
            Poligono
        }

        int x1, x2, y1, y2;

        figuras figuraActiva;

        public frmPaint()
        {
            InitializeComponent();
            objetoG = pbxArea.CreateGraphics();
        }
        
        void PutPixel(int x, int y)
        {
            miPluma.Color = btnColores.BackColor;
            objetoG.DrawRectangle(miPluma, x, y, 1, 1);
        }

        private void pbxArea_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

            switch (figuraActiva)
            {
                case figuras.Linea:
                    try
                    {
                        LineaBresenham(x1, y1, x2, y2);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case figuras.Rectangulo:
                    {
                        graficarRectangulo(x1, y1, x2, y2);
                    }
                    break;
                case figuras.Circulo:
                    {
                        GraficarCirculo(x2, y2, Convert.ToInt32(txtRadio.Text));
                    }
                    break;
                case figuras.Arco:
                    {
                        GraficarArco(x2, y2, Convert.ToInt32(txtRadioArco.Text));
                    }
                    break;
                case figuras.Pie:
                    {
                        graficarPie(x2, y2, Convert.ToInt32(txtRadioPie.Text));
                    }
                    break;
                case figuras.Pentagono:
                    {
                        graficarPentagono(x1, y1, x2, y2);
                    }
                    break;
                case figuras.Triangulo:
                    {
                        graficarTriangulo();
                    }
                    break;
                case figuras.Poligono:
                    {
                        graficarPoligono(Convert.ToInt32(txtLados.Text));
                        cont = 0;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            if (cdgPaletaColores.ShowDialog() == DialogResult.OK)
            {
                btnColores.BackColor = cdgPaletaColores.Color;
            }
        }

        private void rbtCirculo_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtCirculo.Checked)
            {
                figuraActiva = figuras.Circulo;
                lblRadio.Visible = true;
                txtRadio.Visible = true;
            }
            else
            {
                lblRadio.Visible = false;
                txtRadio.Visible = false;
            }

        }

        void LineaBresenham(int x0, int y0, int x1, int y1)
        {
            miPluma.Color = btnColores.BackColor;
            int Dx, Dy, x, y, P, incx = 1, incy = 1;
            bool en_y = false;
            Dy = Math.Abs(y1 - y0);
            Dx = Math.Abs(x1 - x0);
            if (Dx == 0)
            {
                if (y1 < y0)
                    incy = -1;
                y = y0;
                while (y != y1)
                {
                    objetoG.DrawRectangle(miPluma, x0, y, 1, 1);
                    y += incy;
                }
            }
            else
            {
                if (Dy == 0)//pendiente 0
                {
                    if (x1 < x0)
                        incx = -1;
                    x = x0;
                    while (x != x1)
                    {

                        objetoG.DrawRectangle(miPluma, x, y0, 1, 1);
                        x += incx;
                    }
                }
                else
                {
                    if (Dx == Dy)//linea diagonal
                    {
                        y = y0;
                        x = x0;
                        if (y1 < y0)
                            incy = -1;
                        if (x1 < x0)
                            incx = -1;
                        while (x != x1)
                        {
                            //dibujar_punto(x, y);
                            objetoG.DrawRectangle(miPluma, x, y, 1, 1);
                            x += incx;
                            y += incy;
                        }
                    }
                    else
                    {
                        if (Dy > Dx)//recorrer en relacion a y
                        {
                            int aux = x0;
                            x0 = y0;
                            y0 = aux;
                            aux = x1;
                            x1 = y1;
                            y1 = aux;
                            Dy = Math.Abs(y1 - y0);
                            Dx = Math.Abs(x1 - x0);
                            en_y = true;
                        }
                        y = y0;
                        x = x0;
                        P = 2 * Dy - Dx;
                        if (y1 < y0)
                            incy = -1;
                        if (x1 < x0)
                            incx = -1;
                        while (x != x1)
                        {
                            if (en_y)
                                //dibujar_punto(y, x);
                                objetoG.DrawRectangle(miPluma, y, x, 1, 1);
                            else
                                //dibujar_punto(x, y);
                                objetoG.DrawRectangle(miPluma, x, y, 1, 1);
                            if (P > 0)
                            {
                                y += incy;
                                P = P + 2 * Dy - 2 * Dx;
                            }
                            else
                                P = P + 2 * Dy;
                            x += incx;
                        }
                    }
                }
            }
        }

        private void rbtLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtLinea.Checked)
            {
                figuraActiva = figuras.Linea;
            }
        }

        private void rbtRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRectangulo.Checked)
            {
                figuraActiva = figuras.Rectangulo;
            }
        }

        private void rbtArco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtArco.Checked)
            {
                figuraActiva = figuras.Arco;
                lblRadioArco.Visible = true;
                txtRadioArco.Visible = true;
            }
            else
            {
                lblRadioArco.Visible = false;
                txtRadioArco.Visible = false;
            }
        }

        private void rbtPie_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPie.Checked)
            {
                figuraActiva = figuras.Pie;
                lblRadioPie.Visible = true;
                txtRadioPie.Visible = true;
            }
            else
            {
                lblRadioPie.Visible = false;
                txtRadioPie.Visible = false;
            }
        }

        void GraficarCirculo(int x, int y, int r)
        {
            miPluma.Color = btnColores.BackColor;
            int x1 = 0;
            int y1 = r;
            int d = 3 - (2 * r);
            while (x1 <= y1)

            {
                objetoG.DrawRectangle(miPluma, x + x1, y + y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - x1, y + y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x + x1, y - y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - x1, y - y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x + y1, y + x1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - y1, y + x1, 1, 1);
                objetoG.DrawRectangle(miPluma, x + y1, y - x1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - y1, y - x1, 1, 1);

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

        void GraficarArco(int x, int y, int r)
        {
            miPluma.Color = btnColores.BackColor;
            int x1 = 0;
            int y1 = r;
            int d = 3 - (2 * r);
            while (x1 <= y1)

            {
                objetoG.DrawRectangle(miPluma, x + x1, y - y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - x1, y - y1, 1, 1);
                objetoG.DrawRectangle(miPluma, x + y1, y - x1, 1, 1);
                objetoG.DrawRectangle(miPluma, x - y1, y - x1, 1, 1);

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

        void graficarPie(int x, int y, int r)
        {
            miPluma.Color = btnColores.BackColor;
            int x1 = 0;
            int y1 = r;
            int d = 3 - (2 * r);
            while (x1 <= y1)

            {
                
                objetoG.DrawRectangle(miPluma, x + y1, y + x1, 1, 1);
                objetoG.DrawRectangle(miPluma, x + y1, y - x1, 1, 1);

                if (d < 0)

                    d += 4 * x1 + 6;

                else

                {

                    d += 4 * (x1 - y1) + 10;

                    y1--;

                }

                x1++;


            }
            LineaBresenham(x, y, x + 3 * r / 4, y - 2 * r / 3);
            LineaBresenham(x, y, x + 3 * r / 4, y + 2 * r / 3);
        }
        
        void graficarRectangulo(int x1, int y1, int x2, int y2)
        {
            miPluma.Color = btnColores.BackColor;
            /*//Arriba Abajo, Izquierda Derecha
            objetoG.DrawRectangle(miPluma, x1, y1,
                x2 - x1, y2 - y1);
            //Arriba Abajo, Derecha Izquierda
            objetoG.DrawRectangle(miPluma, x2, y1,
                x1 - x2, y2 - y1);
            //Abajo Arriba, Izquierda Derecha
            objetoG.DrawRectangle(miPluma, x1, y2,
                x2 - x1, y1 - y2);
            //Abajo Arriba, Derecha Izquierda
            objetoG.DrawRectangle(miPluma, x2, y2,
                x1 - x2, y1 - y2);

            /*LineaBresenham(x1, y1, x2, y1);
            LineaBresenham(x1, y2, x2, y2);
            LineaBresenham(x1, y1, x1, y2);
            LineaBresenham(x2, y1, x2, y2);*/

            LineaBresenham(x1, y1, x1, y2);
            LineaBresenham(x1, y2, x2, y2);
            LineaBresenham(x2, y2, x2, y1);
            LineaBresenham(x1, y1, x2, y1);
        }

        private void rbtTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTriangulo.Checked)
            {
                figuraActiva = figuras.Triangulo;
            }
        }

        void graficarTriangulo()
        {
            /*Rectangle poligontriangle = new Rectangle(x1, y1, x2 - x1,
                        y2 - y1);

            Point vertice1 = new Point(poligontriangle.Left + (poligontriangle.Width / 2),
                poligontriangle.Top - (poligontriangle.Height / 3));
            Point vertice2 = new Point(poligontriangle.Right, poligontriangle.Bottom);
            Point vertice3 = new Point(poligontriangle.Left, poligontriangle.Bottom);

            miPluma = new Pen(btnColores.BackColor, 1);
            objetoG.DrawPolygon(miPluma, new Point[] { vertice1, vertice2, vertice3 });*/

            LineaBresenham(Punto1.X, Punto1.Y, Punto3.X, Punto3.Y);
            LineaBresenham(Punto3.X, Punto3.Y, Punto2.X, Punto2.Y);
            LineaBresenham(Punto2.X, Punto2.Y, Punto1.X, Punto1.Y);
        }

        private void rbtPentagono_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPentagono.Checked)
            {
                figuraActiva = figuras.Pentagono;
            }
        }

        void graficarPentagono(int x1, int y1, int x2, int y2)
        {
            Rectangle rectangle = new Rectangle(x1, y1, x2 - x1,
                        y2 - y1);

            Point point1 = new Point(rectangle.Left + (rectangle.Width / 2), rectangle.Top - (rectangle.Height / 3));
            Point point2 = new Point(rectangle.Left, rectangle.Bottom);
            Point point3 = new Point(rectangle.Right, rectangle.Bottom);
            Point point4 = new Point(rectangle.Left - (rectangle.Width / 2), rectangle.Top + (rectangle.Height / 3));
            Point point5 = new Point(rectangle.Right + ((rectangle.Right - rectangle.Left) / 2),
            rectangle.Top + (rectangle.Height / 3));
            miPluma = new Pen(btnColores.BackColor, 1);
            //objetoG.DrawPolygon(miPluma, new Point[] { point4, point2, point3, point5, point1 });

            LineaBresenham(point4.X, point4.Y, point2.X, point2.Y);
            LineaBresenham(point2.X, point2.Y, point3.X, point3.Y);
            LineaBresenham(point3.X, point3.Y, point5.X, point5.Y);
            LineaBresenham(point5.X, point5.Y, point1.X, point1.Y);
            LineaBresenham(point1.X, point1.Y, point4.X, point4.Y);
        }

        private void txtLados_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtPoligono_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtPoligono.Checked)
            {
                figuraActiva = figuras.Poligono;
                lblLados.Visible = true;
                txtLados.Visible = true;
            }
            else
            {
                lblLados.Visible = false;
                txtLados.Visible = false;
            }
        }

        private void pbxArea_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = string.Format("X:{0}, Y:{1}", e.X.ToString(), e.Y.ToString());
        }

        private void pbxArea_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            if (rbtTriangulo.Checked)
            {
                cont++;

                switch (cont)
                {
                    case 1:
                        {
                            Punto1 = new Point(e.X, e.Y);
                        }
                        break;
                    case 2:
                        {
                            Punto2 = new Point(e.X, e.Y);
                        }
                        break;
                    case 3:
                        {
                            Punto3 = new Point(e.X, e.Y);
                        }
                        break;
                    default:
                        break;
                }

                if (cont==3)
                {
                    cont = 0;
                }
            }

            if (rbtPoligono.Checked)
            {
                try
                {
                    cont++;
                    int lados = Convert.ToInt32(txtLados.Text);

                    if (cont <= lados)
                    {
                        P[cont].X = e.X;
                        P[cont].Y = e.Y;
                    }
                    else
                    {
                        cont = 0;
                    }

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Porfavor ingrese su cantidad de lados preferida", "Algo salió mal :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cont = 0;
                }
                
            }
            
        }

        void graficarPoligono(int lados)
        {
            for (int i = 1; i < lados; i++)
            {
                LineaBresenham(P[i].X, P[i].Y, P[i + 1].X, P[i + 1].Y);
            }
            LineaBresenham(P[lados].X, P[lados].Y, P[1].X, P[1].Y);
        }

    }
}
