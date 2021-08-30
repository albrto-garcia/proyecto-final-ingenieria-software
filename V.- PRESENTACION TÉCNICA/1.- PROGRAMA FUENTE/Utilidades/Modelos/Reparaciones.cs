using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Modelos
{
    public class Reparaciones
    {
        public static SQLServer sql = new SQLServer();
        public static DataSet DS = new DataSet();
        public string comando;

        public string Registro(Clases.Tablas.Reparaciones reparaciones, List<int> lista_detalles_reparaciones, int dias_prediccion)
        {
            try
            {
                comando = String.Format("EXEC ACTUALIZAR_REPARACIONES @id_reparacion, @id_articulo, @id_suplidor, @id_usuario, " +
                        "                                             @fecha, @nota");

                using (SqlConnection con = new SqlConnection(Utilidades.conexionSQLServer.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(comando))
                    {
                        cmd.Parameters.AddWithValue("@id_reparacion", reparaciones.Num_reparacion);
                        cmd.Parameters.AddWithValue("@id_articulo", reparaciones.Id_articulo);
                        cmd.Parameters.AddWithValue("@id_suplidor", reparaciones.Id_suplidor);
                        cmd.Parameters.AddWithValue("@id_usuario", reparaciones.Id_usuario);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(sql.FechaBD()));
                        cmd.Parameters.AddWithValue("@nota", reparaciones.Nota);

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                foreach (int id_fallo in lista_detalles_reparaciones)
                {
                    comando = String.Format("EXEC ACTUALIZAR_DETALLES_REPARACIONES {0}, {1}",
                                            reparaciones.Num_reparacion, id_fallo);

                    DS = sql.EjecutarBD(comando);
                }

                DateTime fecha_prediccion = DateTime.Parse(sql.FechaBD()).AddDays(dias_prediccion);

                comando = String.Format("EXEC ACTUALIZAR_PREDICCIONES @id_prediccion, @id_reparacion, @dias_prediccion, @fecha_prediccion");

                using (SqlConnection con = new SqlConnection(Utilidades.conexionSQLServer.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(comando))
                    {
                        cmd.Parameters.AddWithValue("@id_prediccion", 0);
                        cmd.Parameters.AddWithValue("@id_reparacion", reparaciones.Num_reparacion);
                        cmd.Parameters.AddWithValue("@dias_prediccion", dias_prediccion);
                        cmd.Parameters.AddWithValue("@fecha_prediccion", fecha_prediccion);

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se realizó correctamente! Error: " + e.Message);
            }

            return DS == null ? "No se realizó correctamente!" : "";
        }

        public DataSet Busqueda(string valor, string buscar_por)
        {
            comando = "EXEC BUSCAR_REPARACIONES '0', '0'";

            if (!String.IsNullOrEmpty(valor))
                comando = String.Format("EXEC BUSCAR_REPARACIONES '{0}', '{1}'", valor, buscar_por);

            DS = sql.EjecutarBD(comando);

            return DS;
        }
    }
}
