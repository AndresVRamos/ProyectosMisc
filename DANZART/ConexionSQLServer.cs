using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DANZART
{
    public class ConexionSQLServer : ClaseUsuarios
    {
        //Cadena de Conexion
        //static string Cadena = "Data Source = DESKTOP-H64H067; Initial Catalog = ACADEMIA; Integrated Security = True";
        static string Cadena = "Data Source=26.209.163.41, 1433;Initial Catalog = ACADEMIA;Persist Security Info=True;User ID=" + ClaseUsuarios.Instance.usuarioSQL + ";Password=" + ClaseUsuarios.Instance.contrasenaSQL;
        //Data Source = 26.209.163.41, 1433; Initial Catalog = ACADEMIA; Persist Security Info=True;User ID = Admin; Password=1234

        public SqlConnection Conectarbd = new SqlConnection();

        //Constructor
        public ConexionSQLServer()
        {
            Conectarbd.ConnectionString = Cadena;
        }

        //Metodo para abrir la conexion
        public void Abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD "+ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void Cerrar()
        {
            Conectarbd.Close();
        }
    }
}
