using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VideoClub
{
    class ConexionBD
    {
        string cadena = "Data Source = ANDRESV-PC\\SQLEXPRESS;Initial Catalog=VIDEOCLUB; Integrated Security=true";

        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD() {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir() {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexión Abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Abrir la Base de Datos " + ex.Message);
            }
        }

        public void cerrar() {
            conectarbd.Close();
        }
    }
}
