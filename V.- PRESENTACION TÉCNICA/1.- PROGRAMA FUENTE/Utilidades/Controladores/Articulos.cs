using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Controladores
{
    public class Articulos
    {
        public string Registro(Clases.Tablas.Articulos articulo)
        {
            Modelos.Articulos modelo = new Modelos.Articulos();
            string respuesta = "";

            if (string.IsNullOrEmpty(articulo.Id_articulo.ToString()) || string.IsNullOrEmpty(articulo.Id_categoria.ToString()) || string.IsNullOrEmpty(articulo.Id_descuento.ToString()) || 
                string.IsNullOrEmpty(articulo.Id_unidad_de_medida.ToString()) || string.IsNullOrEmpty(articulo.Id_almacen.ToString()) || string.IsNullOrEmpty(articulo.Nombre) || 
                string.IsNullOrEmpty(articulo.Descripcion) || string.IsNullOrEmpty(articulo.Precio_neto.ToString()) || string.IsNullOrEmpty(articulo.Precio_venta.ToString()) || 
                string.IsNullOrEmpty(articulo.Cantidad_existente.ToString()) || string.IsNullOrEmpty(articulo.Reorden.ToString()) || articulo.Imagen == null || 
                articulo.Codigo_barras == null || string.IsNullOrEmpty(articulo.Estado.ToString()))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Registro(articulo);
            }

            return respuesta;
        }

        public string Modificacion(Clases.Tablas.Articulos articulo)
        {
            Modelos.Articulos modelo = new Modelos.Articulos();
            string respuesta = "";

            if (string.IsNullOrEmpty(articulo.Id_articulo.ToString()) || string.IsNullOrEmpty(articulo.Id_categoria.ToString()) || string.IsNullOrEmpty(articulo.Id_descuento.ToString()) ||
                string.IsNullOrEmpty(articulo.Id_unidad_de_medida.ToString()) || string.IsNullOrEmpty(articulo.Id_almacen.ToString()) || string.IsNullOrEmpty(articulo.Nombre) ||
                string.IsNullOrEmpty(articulo.Descripcion) || string.IsNullOrEmpty(articulo.Precio_neto.ToString()) || string.IsNullOrEmpty(articulo.Precio_venta.ToString()) ||
                string.IsNullOrEmpty(articulo.Cantidad_existente.ToString()) || string.IsNullOrEmpty(articulo.Reorden.ToString()) || articulo.Imagen == null ||
                articulo.Codigo_barras == null || string.IsNullOrEmpty(articulo.Estado.ToString()) || string.IsNullOrEmpty(articulo.Id_precio.ToString()))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Modificacion(articulo);
            }
            return respuesta;
        }

        public string Eliminacion(Clases.Tablas.Articulos articulo)
        {
            Modelos.Articulos modelo = new Modelos.Articulos();
            string respuesta = "";

            if (string.IsNullOrEmpty(articulo.Id_articulo.ToString()) || string.IsNullOrEmpty(articulo.Id_categoria.ToString()) || string.IsNullOrEmpty(articulo.Id_descuento.ToString()) ||
                string.IsNullOrEmpty(articulo.Id_unidad_de_medida.ToString()) || string.IsNullOrEmpty(articulo.Id_almacen.ToString()) || string.IsNullOrEmpty(articulo.Nombre) ||
                string.IsNullOrEmpty(articulo.Descripcion) || string.IsNullOrEmpty(articulo.Precio_neto.ToString()) || string.IsNullOrEmpty(articulo.Precio_venta.ToString()) ||
                string.IsNullOrEmpty(articulo.Cantidad_existente.ToString()) || string.IsNullOrEmpty(articulo.Reorden.ToString()) || articulo.Imagen == null ||
                articulo.Codigo_barras == null || string.IsNullOrEmpty(articulo.Estado.ToString()) || string.IsNullOrEmpty(articulo.Id_precio.ToString()))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                respuesta = modelo.Eliminacion(articulo);
            }
            return respuesta;
        }
    }
}
