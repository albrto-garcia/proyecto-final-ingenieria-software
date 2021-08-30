using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Fallos
    {
        int id_fallo;
        string descripcion;
        int nivel;

        public int Id_fallo { get => id_fallo; set => id_fallo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Nivel { get => nivel; set => nivel = value; }
    }
}
