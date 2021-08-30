using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clases.Tablas
{
    public class Articulos
    {
        int id_articulo, id_categoria, id_descuento, id_unidad_de_medida, id_almacen, id_precio, cantidad_existente, reorden, estado;
        string nombre, descripcion;
        float precio_neto, precio_venta;
        Image imagen, codigo_barras;

        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public int Id_descuento { get => id_descuento; set => id_descuento = value; }
        public int Id_unidad_de_medida { get => id_unidad_de_medida; set => id_unidad_de_medida = value; }
        public int Id_almacen { get => id_almacen; set => id_almacen = value; }
        public int Id_precio { get => id_precio; set => id_precio = value; }
        public int Cantidad_existente { get => cantidad_existente; set => cantidad_existente = value; }
        public int Reorden { get => reorden; set => reorden = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio_neto { get => precio_neto; set => precio_neto = value; }
        public float Precio_venta { get => precio_venta; set => precio_venta = value; }
        public Image Imagen { get => imagen; set => imagen = value; }
        public Image Codigo_barras { get => codigo_barras; set => codigo_barras = value; }
    }
}
