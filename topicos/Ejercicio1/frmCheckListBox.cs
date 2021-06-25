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
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void clbHabilidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void clbHabilidades_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = clbHabilidades.SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
            {
                lbxSeleccion.Items.Add(item);
            }
            else
            {
                lbxSeleccion.Items.Remove(item);
            }
        }
    }
}
