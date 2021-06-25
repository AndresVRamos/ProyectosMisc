using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DANZART
{
    public class ClaseUsuarios
    {
        public string usuarioSQL { get; set; }
        public string contrasenaSQL { get; set; }

        public ClaseUsuarios() { }
        public static readonly ClaseUsuarios Instance = new ClaseUsuarios();
    }
}
