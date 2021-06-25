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
using System.Collections;
using System.Drawing.Imaging;


namespace Paint
{
    public partial class frmPaint : Form
    {

        enum Figuras
        {
            Lapiz,
            Pluma,
            Pincel,
            Cuadrado,
            Circulo,
            Elipse,
            Linea,
            Borrador,
            Triangulo,
            Pentagono,
            Texto,
            Rellenar
        }
        Figuras figuraActiva;
        Graphics objetoDibujador;
        bool isPainting = false;
        private Point[] puntos;
        Bitmap canvas;
        Dictionary<int, Bitmap> lienzos = new Dictionary<int, Bitmap>();


        private Point primerPunto, segundoPunto;

        public frmPaint()
        {
            InitializeComponent();
            puntos = new Point[0];
            canvas = new Bitmap(1920, 1080);
            btnColor.BackColor = Color.Black;
            cbxTipoLapiz.SelectedIndex = 0;

            Bitmap objBitmap = new Bitmap(imgActual.Width, imgActual.Height);
            lienzos.Add(tbcPrincipal.SelectedIndex, objBitmap);
        }

        public void AgregarPuntos(Point nuevoPunto)
        {
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = nuevoPunto;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAcercaDe = new frmAcercaDe();
            formAcercaDe.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imgActual_MouseMove(object sender, MouseEventArgs e)
        {
            Pen miLapiz = new Pen(btnColor.BackColor, (float)nudGrosor.Value);
            lblCoordenadas.Text = String.Format("X:{0}, Y:{1}", e.X.ToString(), e.Y.ToString());

            switch (figuraActiva)
            {
                case Figuras.Lapiz:
                    lblCoordenadas.Text += " | Funcion: Lapiz";

                    if (isPainting == true)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            PictureBox canvaslienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
                            int tabpage = tbcPrincipal.SelectedIndex;
                            Bitmap canvasObtenido;
                            lienzos.TryGetValue(tabpage, out canvasObtenido);
                            canvaslienzo.Image = canvasObtenido;

                            //imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvasObtenido);
                            statusLbl.Text = "Dibujando";

                            switch (cbxTipoLapiz.Text)
                            {
                                case "Round":
                                    miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                                    miLapiz.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                                    miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                                    objetoDibujador.DrawLines(miLapiz, puntos);
                                    break;
                                case "Diamante":
                                    miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
                                    miLapiz.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                                    miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;

                                    objetoDibujador.DrawLines(miLapiz, puntos);
                                    break;
                                case "Triangulo":
                                    miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
                                    miLapiz.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                                    miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;

                                    objetoDibujador.DrawLines(miLapiz, puntos);
                                    break;
                                case "Cuadrado":
                                    miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.Square;
                                    miLapiz.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                                    miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.Square;

                                    objetoDibujador.DrawLines(miLapiz, puntos);
                                    break;
                                default:
                                    break;
                            }

                        }

                    }
                    break;
                case Figuras.Pluma:
                    
                    break;
                case Figuras.Pincel:
                    lblCoordenadas.Text += " | Funcion: Pincel";
                    if (isPainting == true)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            PictureBox canvaslienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
                            int tabpage = tbcPrincipal.SelectedIndex;
                            Bitmap canvasObtenido;
                            lienzos.TryGetValue(tabpage, out canvasObtenido);
                            canvaslienzo.Image = canvasObtenido;
                            //imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvasObtenido);
                            statusLbl.Text = "Dibujando";
                            Font drawFont = new Font("Arial", (float) nudGrosor.Value);
                            Brush miPincel = new SolidBrush(btnColor.BackColor);
                            objetoDibujador.DrawString("•", drawFont, miPincel, e.X, e.Y);
                        }
                    }
                    break;
                
                case Figuras.Borrador:
                    lblCoordenadas.Text += " | Funcion: Borrador";
                    if (isPainting)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            PictureBox canvaslienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
                            int tabpage = tbcPrincipal.SelectedIndex;
                            Bitmap canvasObtenido;
                            lienzos.TryGetValue(tabpage, out canvasObtenido);
                            canvaslienzo.Image = canvasObtenido;
                            //imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvasObtenido);
                            statusLbl.Text = " | Borrando";
                            Pen miBorrador = new Pen(imgActual.BackColor, (float)nudGrosor.Value);
                            objetoDibujador.DrawLines(miBorrador, puntos);
                        }

                    }
                    break;
                case Figuras.Texto:
                    lblCoordenadas.Text += " | Funcion: Pincel";
                    if (isPainting == true)
                    {
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 0 && puntos.Length < 2)
                        {
                            PictureBox canvaslienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
                            int tabpage = tbcPrincipal.SelectedIndex;
                            Bitmap canvasObtenido;
                            lienzos.TryGetValue(tabpage, out canvasObtenido);
                            canvaslienzo.Image = canvasObtenido;
                            //imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvasObtenido);
                            statusLbl.Text = "Dibujando";
                            Font drawFont = new Font("Arial", (float)nudGrosor.Value);
                            Brush miPincel = new SolidBrush(btnColor.BackColor);
                            objetoDibujador.DrawString(txtTexto.Text, drawFont, miPincel, e.X, e.Y);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        ArrayList ListaPestaña = new ArrayList();
        int ContarPestaña = 2;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TabPage NuevaPestaña = new TabPage("Pestaña " + ContarPestaña);
            ListaPestaña.Add(NuevaPestaña);
            tbcPrincipal.TabPages.Add(NuevaPestaña);
            ContarPestaña++;
            tbcPrincipal.SelectedTab = NuevaPestaña;

            var newPictureBox = new PictureBox() {
                Location = new Point(0, 0),
                BackColor = Color.White,
                Size = new Size(1079, 507)
            };

            NuevaPestaña.Controls.Add(newPictureBox);
            newPictureBox.MouseMove += (imgActual_MouseMove);
            newPictureBox.MouseDown += (imgActual_MouseDown);
            newPictureBox.MouseUp += (imgActual_MouseUp);
            Bitmap objBitmap = new Bitmap(newPictureBox.Width, newPictureBox.Height);
            lienzos.Add(tbcPrincipal.SelectedIndex, objBitmap);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tbcPrincipal.SelectedTab;
            ListaPestaña.Remove(current_tab);
            tbcPrincipal.TabPages.Remove(current_tab);
            ContarPestaña--;
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
           figuraActiva = Figuras.Lapiz;

        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pincel;
        }

        private void imgActual_MouseDown(object sender, MouseEventArgs e)
        {
            isPainting = true;
            primerPunto = new Point(e.X, e.Y);
            if (figuraActiva == Figuras.Rellenar)
            {
                fill(canvas, e.X, e.Y, canvas.GetPixel(e.X, e.Y));
                imgActual.Image = canvas;
            }

        }

        private void imgActual_MouseUp(object sender, MouseEventArgs e)
        {
            segundoPunto = new Point(e.X, e.Y);
            isPainting = false;
            puntos = new Point[0];
            statusLbl.Text = " | No Dibujando";
            PictureBox canvasLienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
            int tabpage = tbcPrincipal.SelectedIndex;
            Bitmap canvasObtenido;
            lienzos.TryGetValue(tabpage, out canvasObtenido);
            canvasLienzo.Image = canvasObtenido;
            imgActual.Image = (Image)canvas;
            objetoDibujador = Graphics.FromImage(canvasObtenido);
            Pen miLapiz = new Pen(btnColor.BackColor, (float)nudGrosor.Value);
            PictureBox canvaslienzo = tbcPrincipal.SelectedTab.Controls[0] as PictureBox;
            lienzos.TryGetValue(tabpage, out canvasObtenido);
            canvaslienzo.Image = canvasObtenido;
            switch (figuraActiva)
            {
                case Figuras.Cuadrado:
                    //Arriba Abajo, Izquierda Derecha
                    objetoDibujador.DrawRectangle(miLapiz, primerPunto.X, primerPunto.Y,
                         segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);
                    //Arriba Abajo, Derecha Izquierda
                    objetoDibujador.DrawRectangle(miLapiz, segundoPunto.X, primerPunto.Y,
                        primerPunto.X - segundoPunto.X, segundoPunto.Y - primerPunto.Y);
                    //Abajo Arriba, Izquierda Derecha
                    objetoDibujador.DrawRectangle(miLapiz, primerPunto.X, segundoPunto.Y,
                        segundoPunto.X - primerPunto.X, primerPunto.Y - segundoPunto.Y);
                    //Abajo Arriba, Derecha Izquierda
                    objetoDibujador.DrawRectangle(miLapiz, segundoPunto.X, segundoPunto.Y,
                        primerPunto.X - segundoPunto.X, primerPunto.Y - segundoPunto.Y);


                    break;
                case Figuras.Circulo:
                    objetoDibujador.DrawEllipse(miLapiz, primerPunto.X, primerPunto.Y,
                       segundoPunto.X - primerPunto.X, segundoPunto.Y - primerPunto.Y);
                    break;
                case Figuras.Elipse:
                    break;
                case Figuras.Linea:
                    objetoDibujador.DrawLine(miLapiz, primerPunto, segundoPunto);
                    break;
                case Figuras.Pentagono:
                    Point[] verticesPentagono = {new Point(segundoPunto.X - (segundoPunto.X-primerPunto.X) * 2 - (segundoPunto.X - primerPunto.X) / 2, primerPunto.Y - (primerPunto.Y - segundoPunto.Y) / 2),
                                                primerPunto, 
                                                new Point(segundoPunto.X + (segundoPunto.X - primerPunto.X) / 2, primerPunto.Y - (primerPunto.Y - segundoPunto.Y) / 2),
                                                segundoPunto,
                                                new Point(segundoPunto.X - (segundoPunto.X - primerPunto.X) * 2, segundoPunto.Y)};
                    objetoDibujador.DrawPolygon(miLapiz, verticesPentagono);
                    
                    break;
                case Figuras.Triangulo:
                    Point[] vertices = {primerPunto,
                                        segundoPunto,
                                        new Point(segundoPunto.X-(segundoPunto.X-primerPunto.X)*2, segundoPunto.Y)};

                    objetoDibujador.DrawPolygon(miLapiz, vertices);
                    break;
                
                default:
                    break;
            }
        }

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (cdgPaletaColores.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cdgPaletaColores.Color;
            }
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Borrador;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAbrirImagen.Filter = "Archivo Imgen (*.jpg, *.jpeg, *.png, *.bmp) " +
                "| *.jpg; *.jpeg; *.png; *.bmp";
            if (ofdAbrirImagen.ShowDialog() == DialogResult.OK)
            {
                imgActual.BackgroundImage = Image.FromFile(ofdAbrirImagen.FileName);
                cbxTipoImagen.SelectedIndex = 0;
                /*imgActual.BackgroundImageLayout = ImageLayout.Stretch;
                lblTipoImagen.Text = "Stretch";*/
            }
        }

        private void imgActual_Click(object sender, EventArgs e)
        {

        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Linea;
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Cuadrado;
        }

        private void imgActual_SizeChanged(object sender, EventArgs e)
        {
            /*Bitmap canvasTemp = canvas;
            canvas = new Bitmap(imgActual.Width, imgActual.Height);
             */
        }
        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Circulo;
        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pentagono;
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Triangulo;
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Texto;
        }

        private void btnPentagono_Click_1(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Pentagono;
        }

        private void cbxTipoImagen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbxTipoImagen.SelectedIndex)
            {
                case 0:
                    imgActual.BackgroundImageLayout = ImageLayout.Center;
                    break;
                case 1:
                    imgActual.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    imgActual.BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case 3:
                    imgActual.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                default:
                    break;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdImagen.Filter = "Archivo Imgen (*.jpg, *.jpeg, *.png, *.bmp) " +
                                "| *.jpg; *.jpeg; *.png; *.bmp";

            if (sfdImagen.ShowDialog() == DialogResult.OK)
            {
                Bitmap fondo = new Bitmap(imgActual.Width, imgActual.Height);

                var rec = new Rectangle(0, 0, imgActual.Width, imgActual.Height);

                imgActual.DrawToBitmap(fondo, rec);

                fondo.Save(sfdImagen.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void pnlImagenes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            figuraActiva = Figuras.Rellenar;
        }

        private void nudGrosor_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void fill(Bitmap bitmap, int x, int y, Color color)
        {
            Stack<Point> area = new Stack<Point>();
            imgActual.BackColor = canvas.GetPixel(primerPunto.X, primerPunto.Y);
            area.Push(primerPunto);

            while (area.Count > 0)
            {
                Point a = area.Pop();
                if (a.X < canvas.Width && a.X > 0 &&
                    a.Y < canvas.Height && a.Y > 0)
                {
                    if (canvas.GetPixel(a.X, a.Y) == imgActual.BackColor)
                    {
                        canvas.SetPixel(a.X, a.Y, btnColor.BackColor);
                        area.Push(new Point(a.X - 1, a.Y));
                        area.Push(new Point(a.X + 1, a.Y));
                        area.Push(new Point(a.X, a.Y - 1));
                        area.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            imgActual.Refresh();
            return;
        }
    }
}
