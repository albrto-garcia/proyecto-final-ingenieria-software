using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Usuarios
    {
        int id_usuario, id_empleado, id_tipo_usuario, estado;
        string usuario, contrasena, concontrasena;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string ConContrasena { get => concontrasena; set => concontrasena = value; }
    }
}
