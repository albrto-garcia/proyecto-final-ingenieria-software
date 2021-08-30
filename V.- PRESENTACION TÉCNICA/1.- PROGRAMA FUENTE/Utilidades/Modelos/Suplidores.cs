using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data;
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
   public class Suplidores
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando, imagen, codigo_barras;
        public MemoryStream ms;
        Google.Apis.Drive.v2.Data.File respuesta;
        public bool drive_error = false;

        public string Registro(Clases.Tablas.Suplidores suplidor)
        {
            try
            {
                UserCredential credential; string[] scopes = new string[] { Google.Apis.Drive.v2.DriveService.Scope.Drive,
                             Google.Apis.Drive.v2.DriveService.Scope.DriveFile};

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
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

                respuesta = SubirArchivo(service, suplidor.Id_suplidor, suplidor.Imagen, suplidor.Nombre, "1bZPNRgdhuBjof9aGg_UXxSYO49QKGmoF");
                imagen = "id: " + respuesta.Id + " nombre: " + respuesta.Title + ".jpg";
            }
            catch (Exception e)
            {
                drive_error = true;
                MessageBox.Show("Error en subida a drive: " + e.Message + "\nSe procederá a guardar las imagenes de forma local.");
            }

            try
            {
                if (drive_error == true)
                {
                    drive_error = false;
                    suplidor.Imagen.Save(@"" + Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\img_("+ suplidor.Id_suplidor + ")_(" + suplidor.Nombre + ")_(" + sql.FechaBD().Replace(":", "-").Replace("/", "-") + ").jpg", ImageFormat.Jpeg);
                    imagen = "id: " + suplidor.Id_suplidor + " nombre: img_(" + suplidor.Id_suplidor + ")_(" + suplidor.Nombre + ")_(" + sql.FechaBD().Replace(":", "-").Replace("/", "-") + ").jpg";
                }
                else
                {
                    suplidor.Imagen.Save(@"" + Utilidades.ruta + @"Proyecto SAPC\Utilidades\Imagenes\" + imagen.Split(new[] { " " }, StringSplitOptions.None)[3], ImageFormat.Jpeg);
                }

                comando = String.Format("EXEC ACTUALIZAR_SUPLIDORES {0}, {1}, {2}, " +
                                        "                          '{3}', '{4}', {5}, " +
                                        "                          '{6}', {7}, {8}, " +
                                        "                          '{9}', {10}, '{11}', " +
                                        "                          '{12}'",
                                        suplidor.Id_suplidor, suplidor.Id_identificacion, suplidor.Id_tipo_identificacion,
                                        suplidor.Identificacion, suplidor.Nombre, suplidor.Id_direccion, suplidor.Direccion, 
                                        suplidor.Estado, suplidor.Id_email, suplidor.Email, suplidor.Id_telefono, suplidor.Telefono, 
                                        imagen);

                DS = sql.EjecutarBD(comando);
                int id_suplidor;

                try
                {
                    id_suplidor = int.Parse(DS.Tables[4].Rows[0]["id_suplidor"].ToString());
                }
                catch(Exception)
                {
                    id_suplidor = int.Parse(DS.Tables[5].Rows[0]["id_suplidor"].ToString());
                }

                foreach(int id_fallo in suplidor.Fallos)
                {
                    comando = String.Format("EXEC ACTUALIZAR_SUPLIDORES_VS_FALLOS {0}, {1}",
                                             id_suplidor, id_fallo);

                    DS = sql.EjecutarBD(comando);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en guardado de forma local: " + e.Message);
                return "No se realizó correctamente!";
            }

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public Google.Apis.Drive.v2.Data.File SubirArchivo(Google.Apis.Drive.v2.DriveService _service, int id_suplidor, Image imagen, string nombre, string _parent, string _descrp = "Subido con .NET a través de la aplicación SAPC!")
        {
            Google.Apis.Drive.v2.Data.File body = new Google.Apis.Drive.v2.Data.File(); ;

            if (imagen != null)
            {
                body.Title = "img_(" + id_suplidor + ")_(" + nombre + ")_" + sql.FechaBD().Replace(":", "_").Replace("/", "_").Replace(" ", "~").Replace(".", "");
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
            comando = "EXEC BUSCAR_SUPLIDORES '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_SUPLIDORES '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }
    }
}
