using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Controladores
{
    public class Suplidores
    {
        public string Registro(Clases.Tablas.Suplidores suplidor)
        {
            Modelos.Suplidores modelo = new Modelos.Suplidores();
            string respuesta;

            if (string.IsNullOrEmpty(suplidor.Id_suplidor.ToString()) || string.IsNullOrEmpty(suplidor.Id_identificacion.ToString()) || 
                string.IsNullOrEmpty(suplidor.Id_tipo_identificacion.ToString()) || string.IsNullOrEmpty(suplidor.Id_direccion.ToString()) || 
                string.IsNullOrEmpty(suplidor.Estado.ToString()) || string.IsNullOrEmpty(suplidor.Id_telefono.ToString()) || 
                string.IsNullOrEmpty(suplidor.Identificacion) || string.IsNullOrEmpty(suplidor.Nombre) || 
                string.IsNullOrEmpty(suplidor.Direccion) || string.IsNullOrEmpty(suplidor.Telefono) || 
                suplidor.Imagen == null || suplidor.Fallos.Count <= 0)
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Registro(suplidor);
            }

            return respuesta;
        }
    }
}
