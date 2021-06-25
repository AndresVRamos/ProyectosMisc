using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class claseUsuarios
    {
        public string usuarioSQL { get; set; }
        public string contrasenaSQL { get; set; }

        private claseUsuarios() { }
        public static readonly claseUsuarios Instance = new claseUsuarios();
    }
}
