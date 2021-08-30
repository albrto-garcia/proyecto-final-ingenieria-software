using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Suplidores
    {
        int id_suplidor, id_identificacion, id_tipo_identificacion, 
            id_direccion, estado,
            id_email, id_telefono;
        string identificacion, nombre, direccion, email, telefono;
        Image imagen;
        List<int> fallos;

        public int Id_suplidor { get => id_suplidor; set => id_suplidor = value; }
        public int Id_identificacion { get => id_identificacion; set => id_identificacion = value; }
        public int Id_tipo_identificacion { get => id_tipo_identificacion; set => id_tipo_identificacion = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id_email { get => id_email; set => id_email = value; }
        public int Id_telefono { get => id_telefono; set => id_telefono = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
        public List<int> Fallos { get => fallos; set => fallos = value; }
        public int Id_direccion { get => id_direccion; set => id_direccion = value; }
    }
}
