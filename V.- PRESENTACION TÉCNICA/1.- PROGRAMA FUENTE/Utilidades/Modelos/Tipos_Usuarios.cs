using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Modelos
{
    public class Tipos_Usuarios
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando;

        public string Registro(Clases.Tablas.Tipos_Usuarios tipo_usuario)
        {
            comando = String.Format("EXEC ACTUALIZAR_TIPOS_USUARIOS 0, '{0}', '{1}'", tipo_usuario.Tipo_usuario, tipo_usuario.Descripcion);
            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public string Modificacion(Clases.Tablas.Tipos_Usuarios tipo_usuario)
        {
            comando = String.Format("EXEC ACTUALIZAR_TIPOS_USUARIOS {0}, '{1}', '{2}'", tipo_usuario.Id_tipo_usuario, tipo_usuario.Tipo_usuario, tipo_usuario.Descripcion);
            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public DataSet Busqueda(string valor, string buscar_por)
        {
            comando = "EXEC BUSCAR_TIPOS_USUARIOS '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_TIPOS_USUARIOS '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }

        public string Eliminacion(Clases.Tablas.Tipos_Usuarios tipo_usuario)
        {
            comando = String.Format("EXEC ELIMINAR_TIPOS_USUARIOS {0}", tipo_usuario.Id_tipo_usuario);

            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }
    }
}
