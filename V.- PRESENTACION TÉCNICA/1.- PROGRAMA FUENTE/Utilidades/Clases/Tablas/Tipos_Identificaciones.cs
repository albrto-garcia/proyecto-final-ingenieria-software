using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Tipos_Identificaciones
    {
        int id_tipo_identificacion;
        string nombre, descripcion;

        public int Id_tipo_identificacion { get => id_tipo_identificacion; set => id_tipo_identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}