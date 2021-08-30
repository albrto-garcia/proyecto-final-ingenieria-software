using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Controladores
{
  public class Tipos_Identificaciones
    {
        public string Registro(Clases.Tablas.Tipos_Identificaciones tipos_Identificaciones)
        {
            Modelos.Tipos_Identificaciones modelo = new Modelos.Tipos_Identificaciones();
            string respuesta = "";

            if (string.IsNullOrEmpty(tipos_Identificaciones.Id_tipo_identificacion.ToString()) || string.IsNullOrEmpty(tipos_Identificaciones.Nombre)
                || string.IsNullOrEmpty(tipos_Identificaciones.Descripcion))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Registro(tipos_Identificaciones);
            }

            return respuesta;
        }

        public string Modificacion(Clases.Tablas.Tipos_Identificaciones tipos_Identificaciones)
        {
            Modelos.Tipos_Identificaciones modelo = new Modelos.Tipos_Identificaciones();
            string respuesta = "";

            if (string.IsNullOrEmpty(tipos_Identificaciones.Id_tipo_identificacion.ToString()) || string.IsNullOrEmpty(tipos_Identificaciones.Nombre)
                || string.IsNullOrEmpty(tipos_Identificaciones.Descripcion))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Modificacion(tipos_Identificaciones);
            }

            return respuesta;
        }

        public string Eliminacion(Clases.Tablas.Tipos_Identificaciones tipos_Identificaciones)
        {
            Modelos.Tipos_Identificaciones modelo = new Modelos.Tipos_Identificaciones();
            string respuesta = "";

            if (string.IsNullOrEmpty(tipos_Identificaciones.Id_tipo_identificacion.ToString()) || string.IsNullOrEmpty(tipos_Identificaciones.Nombre)
                || string.IsNullOrEmpty(tipos_Identificaciones.Descripcion))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Eliminacion(tipos_Identificaciones);
            }

            return respuesta;
        }
    }
}
