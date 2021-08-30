using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Modelos
{
    public class Fallos
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando;

        public DataSet Busqueda(string valor)
        {
            comando = "EXEC BUSCAR_FALLOS '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_FALLOS '{0}'", valor);

            DS = sql.EjecutarBD(comando);

            return DS;
        }
    }
}
