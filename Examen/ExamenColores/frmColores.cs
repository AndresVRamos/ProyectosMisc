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

namespace ExamenColores
{
    public partial class frmColores : Form
    {
        private Random rnd = new Random();

        public frmColores()
        {
            InitializeComponent();
            
        }
        
        private void pbxCuadro1_MouseEnter(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            pbxCuadro1.BackColor = randomColor;
        }

        private void pbxCuadro2_MouseEnter(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            pbxCuadro2.BackColor = randomColor;
        }

        private void pbxCuadro3_MouseEnter(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            pbxCuadro3.BackColor = randomColor;
        }
    }
}
