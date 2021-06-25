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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        public void LlenarTreeView(string direccion, TreeNode nodo)
        {
            string[] listaArchivos = Directory.GetDirectories(direccion);
            try
            {
                if (listaArchivos.Length != 0)
                {
                    foreach (var item in listaArchivos)
                    {
                        TreeNode miNodo = new TreeNode(item);
                        nodo.Nodes.Add(miNodo);

                        LlenarTreeView(item, miNodo);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {

                nodo.Nodes.Add("Acceso Denegado");
            }
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            tvwDirectorio.Nodes.Add("C:\\Users\\andre\\Documents");
            LlenarTreeView("C:\\Users\\andre\\Documents", tvwDirectorio.Nodes[0]);
        }

        private void tvwDirectorio_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
