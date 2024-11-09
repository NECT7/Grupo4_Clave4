using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Clave4.Clases
{
    public class Usuario
    {

       
            public int UsuarioID { get; set; }
            public string NombreUsuario { get; set; }
            public string TipoUsuario { get; set; }
            public string EmailUsuario { get; set; }
            public string ContraseñaUsuario { get; set; }
            public string TelefonoUsuario { get; set; }

            public Usuario() { }

            public Usuario(int usuarioID, string nombreUsuario, string tipoUsuario, 
                string emailUsuario, string contraseñaUsuario, string telefonoUsuario)
            {
                UsuarioID = usuarioID;
                NombreUsuario = nombreUsuario;
                TipoUsuario = tipoUsuario;
                EmailUsuario = emailUsuario;
                ContraseñaUsuario = contraseñaUsuario;
                TelefonoUsuario = telefonoUsuario;
            }
        }

 }

