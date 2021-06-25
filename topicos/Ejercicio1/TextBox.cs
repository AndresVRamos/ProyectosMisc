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
    public partial class frmTextBox : Form
    {
        public frmTextBox()
        {
            InitializeComponent();
        }

        private void TextBox_Load(object sender, EventArgs e)
        {
            txtApellidoP.Enabled = false;
            txtApellidoM.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.UseSystemPasswordChar = false;
            btnAceptar.Enabled = false;
            lblVerNumero.Text = "";
            lblVerSimbolo.Text = "";
            lblVerUpper.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var texto = "Nombre: " + txtNombre.Text + "\n" + "Apellido Paterno: " + txtApellidoP.Text + "\n"
                + "Apellido Materno: " + txtApellidoM.Text + "\n" + "Email: "  + txtEmail.Text;

            var resultado = MessageBox.Show(texto, "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                Close();
            }
        }
        

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtApellidoP.Enabled = true;
            txtApellidoM.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;

            txtNombre.Focus();
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (txtNombre.Visible)
            {
                txtNombre.Visible = false;
                txtApellidoP.Visible = false;
                txtApellidoM.Visible = false;
                txtEmail.Visible = false;
                txtPassword.Visible = false;
            }
            else
            {
                txtNombre.Visible = true;
                txtApellidoP.Visible = true;
                txtApellidoM.Visible = true;
                txtEmail.Visible = true;
                txtPassword.Visible = true;

            }
        }
        
        private int numPass(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
                if (num<1)
                {
                    lblVerNumero.Text = "Se requiere al menos un número";
                }
                else
                {
                    lblVerNumero.Text = "";
                }
            }
            return num;
        }
        
        private int uppercasePass(string pass)
        {
            int numu = 0;
            foreach (char ch in pass)
            {
                if (char.IsUpper(ch))
                {
                    numu++;
                }
                if (numu < 1)
                {
                    lblVerUpper.Text = "Se requiere al menos una mayúscula";
                }
                else
                {
                    lblVerUpper.Text = "";
                }
            }
            return numu;
        }
        
        private int symbolPass(string pass)
        {
            int nums = 0;
            foreach (char ch in pass)
            {
                if (char.IsSymbol(ch) || char.IsPunctuation(ch))
                {
                    nums++;
                }
                if (nums < 1)
                {
                    lblVerSimbolo.Text = "Se requiere al menos un simbolo";
                }
                else
                {
                    lblVerSimbolo.Text = "";
                }
            }
            return nums;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            symbolPass(password);
            numPass(password);
            uppercasePass(password);
            
            if (password.Length < 6 || password.Length > 12 || symbolPass(password) < 1
                || numPass(password) < 1 || uppercasePass(password) < 1)
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                if (symbolPass(password) >= 1
                && numPass(password) >= 1 && uppercasePass(password) >= 1)
                {
                    btnAceptar.Enabled = true;
                }
            }
        }
        
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            var texto = txtPassword.Text;
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = texto;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = texto;
            }
        }
    }
}
