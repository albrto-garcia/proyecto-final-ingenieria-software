using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Modelos
{
    public class Tipos_Identificaciones
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando;

        public string Registro(Clases.Tablas.Tipos_Identificaciones tipos_identificaciones)
        {
            comando = String.Format("EXEC ACTUALIZAR_TIPOS_IDENTIFICACIONES 0, '{0}', '{1}'", tipos_identificaciones.Nombre, tipos_identificaciones.Descripcion);
            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public string Modificacion(Clases.Tablas.Tipos_Identificaciones tipos_identificaciones)
        {
            comando = String.Format("EXEC ACTUALIZAR_TIPOS_IDENTIFICACIONES {0}, '{1}', '{2}'", tipos_identificaciones.Id_tipo_identificacion, tipos_identificaciones.Nombre, tipos_identificaciones.Descripcion);
            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }
        public DataSet Busqueda(string valor, string buscar_por)
        {
            comando = "EXEC BUSCAR_TIPOS_IDENTIFICACIONES '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_TIPOS_IDENTIFICACIONES '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }
        public string Eliminacion(Clases.Tablas.Tipos_Identificaciones tipos_identificaciones)
        {
            comando = String.Format("EXEC ELIMINAR_TIPOS_IDENTIFICACIONES {0}", tipos_identificaciones.Id_tipo_identificacion);

            DS = sql.EjecutarBD(comando);

            return DS == null ? "No se realizó correctamente!" : "";
        }
    }
}
