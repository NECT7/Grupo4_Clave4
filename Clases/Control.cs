using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Clave4.Clases
{
    class Control
    {
        public string ctrlLogin(string usuario, string Contraseña)
        {
            Crud crud = new Crud();
            string respuesta = "";
            Usuario datosUsuarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(Contraseña)){

                respuesta = "Debe llenar todos los campos";
            }             
            else
            {
                datosUsuarios = crud.PorUsuario(usuario);
                if(datosUsuarios == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if((string.IsNullOrEmpty(datosUsuarios.ContraseñaUsuario1) || datosUsuarios.ContraseñaUsuario1.Trim() != Contraseña.Trim()))
                    {
                        respuesta = "Contraseña Incorrecta";
                    }
                }
            }
            return respuesta;
           {

            }
        }
    }
}
