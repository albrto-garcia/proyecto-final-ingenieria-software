using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Controladores
{
    public class Reparaciones
    {
        public string Registro(Clases.Tablas.Reparaciones reparaciones, List<int> lista_detalles_reparaciones, int dias_prediccion)
        {
            Modelos.Reparaciones modelo = new Modelos.Reparaciones();
            string respuesta = "";

            if (string.IsNullOrEmpty(reparaciones.Id_suplidor.ToString()) || 
                string.IsNullOrEmpty(reparaciones.Id_usuario.ToString()) ||
                DateTime.Parse(reparaciones.Fecha.ToString()) == null ||
                string.IsNullOrEmpty(reparaciones.Nota.ToString()) ||
                string.IsNullOrEmpty(reparaciones.Id_articulo.ToString()) ||
                lista_detalles_reparaciones.Count <= 0 || dias_prediccion <= 0)
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Registro(reparaciones, lista_detalles_reparaciones, dias_prediccion);
            }

            return respuesta;
        }
    }
}
