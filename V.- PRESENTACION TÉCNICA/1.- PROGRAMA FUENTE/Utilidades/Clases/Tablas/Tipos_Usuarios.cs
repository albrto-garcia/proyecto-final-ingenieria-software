using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Tipos_Usuarios
    {
        int id_tipo_usuario;
        string tipo_usuario, descripcion;

        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
