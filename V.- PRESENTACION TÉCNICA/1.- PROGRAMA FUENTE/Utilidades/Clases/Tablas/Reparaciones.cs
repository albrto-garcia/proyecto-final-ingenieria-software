using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Reparaciones
    {
        int num_reparacion, id_suplidor, id_usuario, id_articulo;
        DateTime fecha;
        string nota;

        public int Num_reparacion { get => num_reparacion; set => num_reparacion = value; }
        public int Id_suplidor { get => id_suplidor; set => id_suplidor = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
       
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Nota { get => nota; set => nota = value; }
        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
    }
}
