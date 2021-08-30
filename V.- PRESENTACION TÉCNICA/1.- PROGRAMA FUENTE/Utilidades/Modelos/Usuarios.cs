using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Utilidades.Clases.Tablas;
using System.Windows.Forms;

namespace Utilidades.Modelos
{
    class Usuarios
    {
        public static SQLServer sql = new SQLServer();
        public static SqlConnection conexionSQLServer = new SqlConnection("Data Source=DESKTOP-SVAHGNA;Initial Catalog=ProyectoIntegrador;Integrated Security=True");
        public static DataSet DS = new DataSet();
        //public FilterInfoCollection dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //public VideoCaptureDevice frame = null;
        //public MemoryStream ms;
        //public byte[] imagenes;
        //private Boolean down;

        public string Registro(Clases.Tablas.Usuarios usuario)
        {
            string comando = String.Format("EXEC ACTUALIZAR_USUARIOS 0, {0}, {1}, '{2}', '{3}', {4}", usuario.Id_empleado, usuario.Id_tipo_usuario, usuario.Usuario, usuario.Contrasena, usuario.Estado);
            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public static DataSet Busqueda(string valor, string buscar_por)
        {
            string comando = "EXEC BUSCAR_USUARIOS '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_USUARIOS '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            //if (DS.Tables.Count > 0)
            //{
            //    if (DS.Tables[0].Rows.Count > 0)
            //    {
            //        //DGV.DataSource = DS.Tables[0];
            //        //ms = new MemoryStream((byte[])DS.Tables[0].Rows[0]["Imagen"]);
            //        //picUser.Image = Image.FromStream(ms);
            //    }
            //}

            return DS;
        }

        public Clases.Tablas.Usuarios Existencia(string usuario)
        {
            string comando = String.Format("Select * from USUARIOS where usuario = '{0}'", usuario);

            DS = sql.EjecutarBD(comando);

            if (DS == null)
                return null;

            if (DS.Tables.Count > 0)
            {
                Clases.Tablas.Usuarios usr = null;

                if (DS.Tables[0].Rows.Count > 0)
                {
                    usr = new Clases.Tablas.Usuarios();
                    usr.Id_usuario = int.Parse(DS.Tables[0].Rows[0]["id_usuario"].ToString());
                    usr.Id_empleado = int.Parse(DS.Tables[0].Rows[0]["id_empleado"].ToString());
                    usr.Id_tipo_usuario = int.Parse(DS.Tables[0].Rows[0]["id_tipo_usuario"].ToString());
                    usr.Usuario = DS.Tables[0].Rows[0]["usuario"].ToString();
                    usr.Contrasena = DS.Tables[0].Rows[0]["contrasena"].ToString();
                    usr.Estado = DS.Tables[0].Rows[0]["estado"].ToString().ToLower() == "false" ? 0 : 1; //False = Activo = 0 | True = Inactivo = 1
                }

                return usr;
            }
            else
            {
                return null;
            }
        }
    }
}
