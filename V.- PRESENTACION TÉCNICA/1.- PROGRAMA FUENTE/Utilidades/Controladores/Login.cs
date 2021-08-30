using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Clases.Tablas;

namespace Utilidades.Controladores
{
    public class Login
    {
        public static Sesiones sesion;

        public static string Ingreso(string usuario, string contrasena)
        {
            Modelos.Usuarios modelo = new Modelos.Usuarios();
            string respuesta = "";
            Clases.Tablas.Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                datosUsuario = modelo.Existencia(usuario);

                if (usuario.Equals("admin", StringComparison.CurrentCultureIgnoreCase)
                   && !contrasena.Equals("12345"))
                    respuesta = "El usuario y/o contraseña no coinciden.";
                else
                if (usuario.Equals("admin", StringComparison.CurrentCultureIgnoreCase)
                   && contrasena.Equals("12345")) { respuesta = "."; }
                else
                    if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe.";
                }
                else
                {
                    if (datosUsuario.Contrasena != Utilidades.EncriptacionSHA1(contrasena))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden.";
                    }
                    else
                    {
                        Sesiones.id_usuario = datosUsuario.Id_usuario;
                        Sesiones.id_empleado = datosUsuario.Id_empleado;
                        Sesiones.id_tipo_usuario = datosUsuario.Id_tipo_usuario;
                        Sesiones.usuario = datosUsuario.Usuario;
                        Sesiones.estado = datosUsuario.Estado;

                        respuesta = @"id_usuario: " + datosUsuario.Id_usuario.ToString() +
                                     "| id_empleado: " + datosUsuario.Id_empleado.ToString() +
                                     "| id_tipo_usuario: " + datosUsuario.Id_tipo_usuario.ToString() +
                                     "| usuario: " + datosUsuario.Usuario.ToString();
                    }
                }
            }

            return respuesta;
        }
    }
}
