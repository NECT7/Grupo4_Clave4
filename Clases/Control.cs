﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_Clave4.Clases
{
    class Control
    {

        public string crtRegistro(Usuario usuarios)
        {
            Crud crud = new Crud();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuarios.NombreUsuario1) ||
                string.IsNullOrEmpty(usuarios.EmailUsuario1) ||
                string.IsNullOrEmpty(usuarios.TelefonoUsuario1) ||
                string.IsNullOrEmpty(usuarios.TipoUsuario1) ||
                string.IsNullOrEmpty(usuarios.ContraseñaUsuario1))
            {
                respuesta = "Rellene todos los campos";

            }
            else
            {
                //if (crud.existeUsuario(usuarios.NombreUsuario1))
                //{
                //    respuesta = "El nombre de usuario ya existe";
                //}
                //else

                crud.registro(usuarios);

            }

            return respuesta;
        }
        public string ctrRegistroProducto(Productos productos)
        {
            Crud crud = new Crud();
            string respuesta = "";

            if (string.IsNullOrEmpty(productos.NombreProducto1) ||
                productos.PrecioUnitarioProducto1 <= 0.0 ||
                productos.CantidadProducto1 <= 0 ||
                string.IsNullOrEmpty(productos.TipoProduto1)
                )
            {
                respuesta = "Rellene todos los campos";

            }
            else
            {
                crud.registroProducto(productos);

            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string Contraseña)
        {
            Crud crud = new Crud();
            string respuesta = "";
            Usuario datosUsuarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(Contraseña))
            {

                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuarios = crud.PorUsuario(usuario);
                if (datosUsuarios == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if ((string.IsNullOrEmpty(datosUsuarios.ContraseñaUsuario1) || datosUsuarios.ContraseñaUsuario1.Trim() != Contraseña.Trim()))
                    {
                        respuesta = "Contraseña Incorrecta";
                    }
                }
            }
            return respuesta;
            {

            }
        }
        public string ctrlRegistroLocales(Locales local)
        {
            Crud crud = new Crud();
            string respuesta = "";

            if (string.IsNullOrEmpty(local.NombreLocal1) || string.IsNullOrEmpty(local.UbicacionLocal1)
                || string.IsNullOrEmpty(local.Horario1))
            {
                respuesta = "rellene todos los campos";

            }
            else
            {
                crud.RegistroLocales(local);
            }
            return respuesta;
        }
        public int ctrlRegistroEventos(eventos evento)
        {
            Crud crud = new Crud();
            int eventoID = -1;

            if (string.IsNullOrEmpty(evento.EstadoEvento1) || evento.UsuarioID <= 0 ||
                evento.MontoMaximo1 <= 0.0 || evento.MontoMinimo1 <= 0.0 || evento.Fecha1 == DateTime.MinValue)
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                eventoID = crud.RegistoEventos(evento);
            }
            return eventoID;
        }

    }
    }




