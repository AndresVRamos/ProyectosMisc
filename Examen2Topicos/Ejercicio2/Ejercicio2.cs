using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUniversidad.Text == "Instituto Tecnologico de Hermosilo"||
                txtUniversidad.Text == "Instituto Tecnológico de Hermosilo"||
                txtUniversidad.Text == "ITH")
            {
                MessageBox.Show("Eres afortunado de estudiar aqui!", "Wow",MessageBoxButtons.OK , MessageBoxIcon.Asterisk);
            }

            if (txtUniversidad.Text == "Unison"||
                txtUniversidad.Text == "Unisón"||
                txtUniversidad.Text == "Universidad de Sonora")
            {
                MessageBox.Show("Que bueno que estudias", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (txtUniversidad.Text == "UTH")
            {
                MessageBox.Show("Eres bueno pero nosotros estamos en el ITH", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
