using System;

using System.Collections;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace JuegoMemorama

{
    public partial class Form1 : Form
    {
        int TamanioColumnasFilas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;



        public Form1()
        {
            InitializeComponent();
            iniciarJuego();
        }

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }

            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());

            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }

            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;

            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;
            
            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2)
            {
                Movimientos++;
                lblRecord.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);

                //  2 Veces se realizo el evento del click

                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {

                            MessageBox.Show("El juego termino");

                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                }
            }
        }

        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);

            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.img11;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                    break;
            }

            return TmpImg;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void LblRecord_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;

            if (TiempoVirarCarta == 1)
            {
                CartaTemporal1.Image = Properties.Resources.Girada;
                CartaTemporal2.Image = Properties.Resources.Girada;
                CartasSeleccionadas.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}