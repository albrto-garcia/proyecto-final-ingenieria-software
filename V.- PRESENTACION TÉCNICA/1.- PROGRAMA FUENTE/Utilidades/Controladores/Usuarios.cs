using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades.Controladores
{
    public class Usuarios
    {
        public string Registro(Clases.Tablas.Usuarios usuario)
        {
            Modelos.Usuarios modelo = new Modelos.Usuarios();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contrasena) || string.IsNullOrEmpty(usuario.ConContrasena) || usuario.Id_tipo_usuario == 0)
            {
                respuesta = "Debe llenar todos los campos.";
            }
            else
            {
                if (usuario.Contrasena == usuario.ConContrasena)
                {
                    if (modelo.Existencia(usuario.Usuario) != null)
                    {
                        respuesta = "El usuario ya existe.";
                    }
                    else
                    {
                        usuario.Contrasena = Utilidades.EncriptacionSHA1(usuario.Contrasena);
                        respuesta = modelo.Registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden.";
                }
            }
            return respuesta;
        }
    }
}
