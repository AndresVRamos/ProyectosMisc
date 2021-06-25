using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficando
{
    public partial class GraficandoForm : Form
    {
        public GraficandoForm()
        {
            InitializeComponent();
        }

        private void GraficandoForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graficoObj = e.Graphics;
            Pen myPen = new Pen(Color.Black, 10);
            Pen myPenAzul = new Pen(Color.DodgerBlue, 10);
            Pen myPenGris = new Pen(Color.Gray, 10);
            graficoObj.DrawLine(myPen, 100, 150, 190, 150);
            
            //Cabeza Izquierda
            graficoObj.DrawLine(myPen, 80, 160, 100, 160);
            graficoObj.DrawLine(myPen, 75, 165, 75, 185);
            graficoObj.DrawLine(myPen, 65, 185, 65, 225);
            graficoObj.DrawLine(myPen, 75, 225, 75, 245);
            graficoObj.DrawLine(myPen, 65, 235, 65, 265);
            graficoObj.DrawLine(myPen, 70, 270, 90, 270);
            graficoObj.DrawLine(myPen, 60, 280, 110, 280);
            
            //Cabeza Derecha
            graficoObj.DrawLine(myPen, 190, 160, 210, 160);
            graficoObj.DrawLine(myPen, 215, 165, 215, 185);
            graficoObj.DrawLine(myPen, 225, 185, 225, 225);
            graficoObj.DrawLine(myPen, 215, 225, 215, 245);
            graficoObj.DrawLine(myPen, 225, 235, 225, 265);
            graficoObj.DrawLine(myPen, 200, 270, 220, 270);
            graficoObj.DrawLine(myPen, 180, 280, 230, 280);

            graficoObj.DrawLine(myPen, 70, 290, 220, 290);

            //Cara
            graficoObj.DrawLine(myPen, 90, 200, 120, 200);
            graficoObj.DrawLine(myPen, 90, 210, 120, 210);
            graficoObj.DrawLine(myPen, 90, 220, 120, 220);
            graficoObj.DrawLine(myPen, 170, 200, 200, 200);
            graficoObj.DrawLine(myPen, 170, 210, 200, 210);
            graficoObj.DrawLine(myPen, 170, 220, 200, 220);
            graficoObj.DrawLine(myPen, 145, 215, 145, 235);
            graficoObj.DrawLine(myPen, 130, 230, 160, 230);
            graficoObj.DrawLine(myPen, 95, 235, 95, 255);
            graficoObj.DrawLine(myPen, 195, 235, 195, 255);
            graficoObj.DrawLine(myPen, 90, 250, 200, 250);
            graficoObj.DrawLine(myPen, 100, 260, 110, 260);
            graficoObj.DrawLine(myPen, 120, 260, 130, 260);
            graficoObj.DrawLine(myPen, 140, 260, 150, 260);
            graficoObj.DrawLine(myPen, 160, 260, 170, 260);
            graficoObj.DrawLine(myPen, 180, 260, 190, 260);
            graficoObj.DrawLine(myPen, 110, 270, 180, 270);
            graficoObj.DrawLine(myPen, 130, 230, 160, 230);

            //Hombro Izquierdo
            graficoObj.DrawLine(myPen, 55, 285, 55, 305);
            graficoObj.DrawLine(myPen, 45, 295, 45, 315);
            graficoObj.DrawLine(myPen, 35, 315, 35, 345);
            graficoObj.DrawLine(myPen, 45, 345, 45, 355);
            graficoObj.DrawLine(myPen, 50, 360, 70, 360);
            graficoObj.DrawLine(myPen, 60, 370, 90, 370);
            graficoObj.DrawLine(myPen, 85, 345, 85, 375);
            graficoObj.DrawLine(myPen, 95, 335, 95, 345);
            graficoObj.DrawLine(myPen, 85, 325, 85, 335);
            graficoObj.DrawLine(myPen, 60, 320, 80, 320);
            graficoObj.DrawLine(myPen, 80, 310, 90, 310);
            graficoObj.DrawLine(myPen, 90, 320, 120, 320);
            graficoObj.DrawLine(myPen, 75, 265, 75, 305);

            graficoObj.DrawLine(myPen, 100, 300, 110, 300);
            graficoObj.DrawLine(myPen, 140, 300, 150, 300);
            graficoObj.DrawLine(myPen, 180, 300, 190, 300);
            graficoObj.DrawLine(myPen, 215, 265, 215, 305);

            //Hombro Derecho
            graficoObj.DrawLine(myPen, 235, 285, 235, 305);
            graficoObj.DrawLine(myPen, 245, 295, 245, 315);
            graficoObj.DrawLine(myPen, 255, 315, 255, 345);
            graficoObj.DrawLine(myPen, 245, 345, 245, 355);
            graficoObj.DrawLine(myPen, 220, 360, 240, 360);
            graficoObj.DrawLine(myPen, 200, 370, 230, 370);
            graficoObj.DrawLine(myPen, 205, 345, 205, 375);
            graficoObj.DrawLine(myPen, 190, 340, 200, 340);
            graficoObj.DrawLine(myPen, 200, 330, 210, 330);
            graficoObj.DrawLine(myPen, 210, 320, 230, 320);
            graficoObj.DrawLine(myPen, 200, 310, 210, 310);
            graficoObj.DrawLine(myPen, 170, 320, 200, 320);

            //Pecho
            graficoObj.DrawLine(myPen, 110, 310, 140, 310);
            graficoObj.DrawLine(myPen, 140, 320, 150, 320);
            graficoObj.DrawLine(myPen, 150, 310, 180, 310);
            graficoObj.DrawLine(myPen, 110, 340, 130, 340);
            graficoObj.DrawLine(myPen, 160, 340, 180, 340);
            graficoObj.DrawLine(myPen, 110, 360, 180, 360);
            graficoObj.DrawLine(myPen, 115, 305, 115, 365);
            graficoObj.DrawLine(myPen, 175, 305, 175, 365);
            graficoObj.DrawLine(myPen, 110, 370, 180, 370);
            graficoObj.DrawLine(myPen, 110, 360, 180, 360);

            //Piernas
            graficoObj.DrawLine(myPen, 60, 380, 230, 380);
            graficoObj.DrawLine(myPen, 50, 390, 240, 390);
            graficoObj.DrawLine(myPen, 50, 400, 140, 400);
            graficoObj.DrawLine(myPen, 150, 400, 240, 400);
            graficoObj.DrawLine(myPen, 60, 410, 130, 410);
            graficoObj.DrawLine(myPen, 40, 420, 70, 420);
            graficoObj.DrawLine(myPen, 40, 430, 50, 430);
            graficoObj.DrawLine(myPen, 50, 440, 110, 440);
            graficoObj.DrawLine(myPen, 110, 430, 130, 430);
            graficoObj.DrawLine(myPen, 120, 420, 130, 420);
            graficoObj.DrawLine(myPen, 110, 360, 180, 360);
            graficoObj.DrawLine(myPen, 160, 410, 230, 410);
            graficoObj.DrawLine(myPen, 160, 420, 170, 420);
            graficoObj.DrawLine(myPen, 160, 430, 180, 430);
            graficoObj.DrawLine(myPen, 180, 440, 250, 440);
            graficoObj.DrawLine(myPen, 250, 430, 260, 430);
            graficoObj.DrawLine(myPen, 220, 420, 250, 420);
            graficoObj.DrawLine(myPen, 110, 360, 180, 360);

            graficoObj.DrawLine(myPenAzul, 65, 285, 65, 315);
            graficoObj.DrawLine(myPenAzul, 50, 310, 80, 310);
            graficoObj.DrawLine(myPenAzul, 40, 320, 60, 320);
            graficoObj.DrawLine(myPenAzul, 40, 330, 80, 330);
            graficoObj.DrawLine(myPenAzul, 40, 340, 90, 340);
            graficoObj.DrawLine(myPenAzul, 50, 350, 80, 350);
            graficoObj.DrawLine(myPenAzul, 70, 360, 80, 360);
            graficoObj.DrawLine(myPenAzul, 80, 320, 90, 320);
            graficoObj.DrawLine(myPenAzul, 90, 330, 110, 330);
            graficoObj.DrawLine(myPenAzul, 100, 340, 110, 340);
            graficoObj.DrawLine(myPenAzul, 95, 345, 95, 375);
            graficoObj.DrawLine(myPenAzul, 105, 325, 105, 375);
            graficoObj.DrawLine(myPenAzul, 185, 325, 185, 375);
            graficoObj.DrawLine(myPenAzul, 195, 345, 195, 375);
            graficoObj.DrawLine(myPenAzul, 190, 330, 200, 330);
            graficoObj.DrawLine(myPenAzul, 200, 340, 250, 340);
            graficoObj.DrawLine(myPenAzul, 215, 325, 215, 365);
            graficoObj.DrawLine(myPenAzul, 225, 325, 225, 355);
            graficoObj.DrawLine(myPenAzul, 235, 305, 235, 355);
            graficoObj.DrawLine(myPenAzul, 245, 315, 245, 345);
            graficoObj.DrawLine(myPenAzul, 210, 310, 240, 310);
            graficoObj.DrawLine(myPenAzul, 225, 285, 225, 315);
            graficoObj.DrawLine(myPenAzul, 235, 305, 235, 355);
            graficoObj.DrawLine(myPenAzul, 200, 320, 210, 320);
            graficoObj.DrawLine(myPenAzul, 235, 305, 235, 355);
            graficoObj.DrawLine(myPenGris, 190, 300, 210, 300);
            graficoObj.DrawLine(myPenGris, 180, 310, 200, 310);
            graficoObj.DrawLine(myPenGris, 80, 300, 100, 300);
            graficoObj.DrawLine(myPenGris, 90, 310, 110, 310);

















        }
    }
}
