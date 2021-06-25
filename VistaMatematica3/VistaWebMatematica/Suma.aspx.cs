using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VistaWebMatematica
{
    public partial class Suma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            var resultado = Aritmetica.OperacionesAritmeticas.Sumar(double.Parse(txtbxValorA.Text), double.Parse(txtbxValorB.Text));
            
        }
    }
}