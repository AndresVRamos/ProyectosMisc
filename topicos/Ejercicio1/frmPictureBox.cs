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

namespace Ejercicio1
{
    public partial class frmPictureBox : Form
    {
        private int imgNum = 0;


        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void frmPictureBox_Load(object sender, EventArgs e)
        {

        }

        private void pbxFotos_Click(object sender, EventArgs e)
        {
            imgNum = imgNum + 1;
            if (imgNum > 3)
            {
                imgNum = 1;
            }
            pbxFotos.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\image" + imgNum + ".jpg");
        }
    }
}
