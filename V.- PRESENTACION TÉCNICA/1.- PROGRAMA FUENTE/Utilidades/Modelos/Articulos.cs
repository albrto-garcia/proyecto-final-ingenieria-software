using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Modelos
{
    public class Articulos
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando, imagen, codigo_barras;
        public MemoryStream ms;
        Google.Apis.Drive.v2.Data.File respuesta;
        public int id_empleado = 20;
        public bool drive_error = false;

        public string Registro(Clases.Tablas.Articulos articulo)
        {
            try
            {
                UserCredential credential; string[] scopes = new string[] { Google.Apis.Drive.v2.DriveService.Scope.Drive,
                                 Google.Apis.Drive.v2.DriveService.Scope.DriveFile};

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                Google.Apis.Drive.v2.DriveService service = new Google.Apis.Drive.v2.DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Compraventa C Sharp",
                });
                service.HttpClient.Timeout = TimeSpan.FromMinutes(100);

                respuesta = SubirArchivo(service, articulo.Imagen, articulo.Nombre, "1bZPNRgdhuBjof9aGg_UXxSYO49QKGmoF");
                imagen = "id: " + respuesta.Id + " nombre: " + respuesta.Title;

                if (articulo.Codigo_barras != null)
                {
                    respuesta = SubirArchivo(service, articulo.Codigo_barras, articulo.Id_articulo.ToString(), "1bZPNRgdhuBjof9aGg_UXxSYO49QKGmoF");
                    codigo_barras = "id: " + respuesta.Id + " nombre: " + respuesta.Title;
                }
            }
            catch (Exception e)
            {
                drive_error = true;
                MessageBox.Show("Error en subida a drive: " + e.Message + "\nSe procederá a guardar las imagenes de forma local.");
            }

            try
            {
                drive_error = true;

                if (drive_error == true)
                {
                    drive_error = false;
                    articulo.Imagen.Save(@"" + Utilidades.ruta+@"Proyecto Integrador\Utilidades\Imagenes\img_(" + articulo.Nombre + ")_(" + sql.FechaBD().Replace(":", "-").Replace("/", "-") + ").jpg", ImageFormat.Jpeg);
                      imagen = "id: nombre: img_(" + articulo.Nombre + ")_(" + sql.FechaBD().Replace(":", " - ").Replace(" / ", " - ") + ").jpg";
                    if (articulo.Codigo_barras != null)
                    {
                        articulo.Codigo_barras.Save(@""+Utilidades.ruta+@"Proyecto Integrador\Utilidades\Imagenes\img_(" + articulo.Id_articulo + ")_(" + sql.FechaBD().Replace(":", "-").Replace("/", "-") + ").jpg", ImageFormat.Jpeg);
                        codigo_barras = "id: nombre: img_(" + articulo.Id_articulo + ")_(" + sql.FechaBD().Replace(":", "-").Replace("/", "-") + ").jpg";
                    }     
                    }
                else
                {
                    articulo.Imagen.Save(@""+Utilidades.ruta+@"Proyecto Integrador\Utilidades\Imagenes\" + imagen.Split(new[] { " " }, StringSplitOptions.None)[3] + ".jpg", ImageFormat.Jpeg);

                    if (articulo.Codigo_barras != null)
                        articulo.Codigo_barras.Save(@""+Utilidades.ruta+@"Proyecto Integrador\Utilidades\Imagenes\" + codigo_barras.Split(new[] { " " }, StringSplitOptions.None)[3] + ".jpg", ImageFormat.Jpeg);
                }

                comando = String.Format("EXEC ACTUALIZAR_ARTICULOS {0}, {1}, {2}, " +
                                        "                          {3}, {4}, '{5}', " +
                                        "                          '{6}', {7}, {8}, " +
                                        "                          {9}, {10}, '{11}', " +
                                        "                          '{12}', {13}, {14}",
                                        articulo.Id_articulo, articulo.Id_categoria, articulo.Id_descuento,
                                        articulo.Id_unidad_de_medida, articulo.Id_almacen, articulo.Nombre,
                                        articulo.Descripcion, articulo.Precio_neto, articulo.Precio_venta,
                                        articulo.Cantidad_existente, articulo.Reorden, imagen,
                                        codigo_barras, articulo.Estado, id_empleado);

                DS = sql.EjecutarBD(comando);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en guardado de forma local: " + e.Message);
            }

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public string Modificacion(Clases.Tablas.Articulos articulo)
        {
            comando = String.Format("EXEC ACTUALIZAR_ARTICULOS {0}, {1}, {2}, " +
                                        "                          {3}, {4}, '{5}', " +
                                        "                          '{6}', {7}, {8}, " +
                                        "                          {9}, {10}, '{11}', " +
                                        "                          '{12}', {13}, {14}, " +
                                        "                          {15}",
                                        articulo.Id_articulo, articulo.Id_categoria, articulo.Id_descuento,
                                        articulo.Id_unidad_de_medida, articulo.Id_almacen, articulo.Nombre,
                                        articulo.Descripcion, articulo.Precio_neto, articulo.Precio_venta,
                                        articulo.Cantidad_existente, articulo.Reorden, imagen,
                                        codigo_barras, articulo.Estado, id_empleado, 
                                        articulo.Id_precio);

            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public Google.Apis.Drive.v2.Data.File SubirArchivo(Google.Apis.Drive.v2.DriveService _service, Image imagen, string nombre, string _parent, string _descrp = "Subido con .NET a través de la aplicación SAPC!")
        {
            Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File(); ;

            if (imagen != null)
            {
                body.Title = "img_(" + nombre + ")_" + sql.FechaBD().Replace(":", "_").Replace("/", "_").Replace(" ", "~").Replace(".", "");
                body.Description = _descrp;
                body.MimeType = GetMimeType(body.Title + ".jpeg");
                body.Parents = new List<ParentReference>() { new ParentReference() { Id = _parent } };

                ms = new MemoryStream();
                imagen.Save(ms, ImageFormat.Jpeg);

                try
                {
                    Google.Apis.Drive.v2.FilesResource.InsertMediaUpload request = _service.Files.Insert(body, ms, body.MimeType);
                    request.Upload();
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }

            return body;
        }

        private static string GetMimeType(string fileName)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(fileName).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);

            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();

            return mimeType;
        }

        public DataSet Busqueda(string valor, string buscar_por)
        {
            comando = "EXEC BUSCAR_ARTICULOS '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_ARTICULOS '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        public string Eliminacion(Clases.Tablas.Articulos articulo)
        {
            comando = String.Format("EXEC ELIMINAR_ARTICULOS {0}", articulo.Id_articulo);

            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }
    }
}
