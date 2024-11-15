﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Grupo4_Clave4.Clases
{
    class Crud
    {//Obtener los datos de la tabla prouctos

        public DataTable ObtenerProductos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = Clases.CConexion.EstablecerConexion())
            {
                string query = "SELECT * FROM Productos";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public DataTable ObtenerProductosDisponibles()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = Clases.CConexion.EstablecerConexion())
            {
                string query = "SELECT Producto_ID,Nombre_Producto, Cantidad_Producto, PrecioUnitario, Tipo_Producto, Horario_Disponible FROM Productos WHERE Cantidad_producto > 0";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public int registro(Usuario usuarios)
        {
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (Nombre_Usuario, Tipo_Usuario, Email_Usuario, Contraseña_Usuario, Telefono_Usuario) " +
                "VALUES (@usuario, @tipoUsuario, @emailUsuario, @Contraseña, @telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuarios.NombreUsuario1);
            comando.Parameters.AddWithValue("@tipoUsuario", usuarios.TipoUsuario1);
            comando.Parameters.AddWithValue("@emailUsuario", usuarios.EmailUsuario1);
            comando.Parameters.AddWithValue("@Contraseña", usuarios.ContraseñaUsuario1);
            comando.Parameters.AddWithValue("@telefono", usuarios.TelefonoUsuario1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int registroProducto(Productos producto)
        {
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            conexion.Open();

            string sql = "INSERT INTO productos (Nombre_Producto, Cantidad_producto, PrecioUnitario, Tipo_Producto, Horario_Disponible) " +
                "VALUES (@nombre, @cantidad, @precio, @tipo, @horario)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", producto.NombreProducto1);
            comando.Parameters.AddWithValue("@cantidad", producto.CantidadProducto1);
            comando.Parameters.AddWithValue("@precio", producto.PrecioUnitarioProducto1);
            comando.Parameters.AddWithValue("@tipo", producto.TipoProduto1);
            comando.Parameters.AddWithValue("@horario", producto.HorarioDisponible1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public int GuardarPedido(Pedido pedido)
        {
            MySqlConnection conn = Clases.CConexion.EstablecerConexion();
            try
            {
                conn.Open();
                string query = "INSERT INTO pedidos (Usuario_ID, Local_ID, Evento_ID, FechaHora_Pedido, Hora_Reserva, Estado_Pedido, Tipo_Pedido, TotalPago, TipoPago) " +
                               "VALUES (@Usuario_ID, @Local_ID, @Evento_ID, @FechaHora_Pedido, @Hora_Reserva, @Estado_Pedido, @Tipo_Pedido, @TotalPago, @TipoPago)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Usuario_ID", pedido.UsuarioID);
                cmd.Parameters.AddWithValue("@Local_ID", pedido.LocalID);
                cmd.Parameters.AddWithValue("@Evento_ID", pedido.EventoID ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaHora_Pedido", pedido.FechaHoraPedido);
                cmd.Parameters.AddWithValue("@Hora_Reserva", pedido.HoraReserva);
                cmd.Parameters.AddWithValue("@Estado_Pedido", pedido.EstadoPedido);
                cmd.Parameters.AddWithValue("@Tipo_Pedido", pedido.TipoPedido);
                cmd.Parameters.AddWithValue("@TotalPago", pedido.TotalPago);
                cmd.Parameters.AddWithValue("@TipoPago", pedido.TipoPago);

                int resultado = cmd.ExecuteNonQuery();

                // Obtener el PedidoID del último pedido insertado
                pedido.PedidoID = (int)cmd.LastInsertedId;  // Asignar el PedidoID al objeto pedido

                MessageBox.Show("Pedido guardado con ID: " + pedido.PedidoID);

                return resultado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar el pedido: " + ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }


        public int RegistrarDetallePedido(DetallePedido detallePedido)
        {
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            try
            {
                conexion.Open();

                string sql = "INSERT INTO detalle_pedido (Pedido_ID, Producto_ID, CantidadProducto_Detalle, PrecioUnitario_Detalle, SubTotal) " +
                             "VALUES (@PedidoID, @ProductoID, @CantidadProducto, @PrecioUnitario, @SubTotal)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@PedidoID", detallePedido.PedidoID);
                comando.Parameters.AddWithValue("@ProductoID", detallePedido.ProductoID);
                comando.Parameters.AddWithValue("@CantidadProducto", detallePedido.CantidadProducto);
                comando.Parameters.AddWithValue("@PrecioUnitario", detallePedido.PrecioUnitario);
                comando.Parameters.AddWithValue("@SubTotal", detallePedido.SubTotal);

                int resultado = comando.ExecuteNonQuery();
                return resultado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar el detalle del pedido: " + ex.Message);
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }

    


    public int RegistroLocales(Locales local)
        {
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            try
            {
                conexion.Open();
                string sql = "INSERT INTO `clave4_grupo4db`.`locales` (`Nombre_Local`, `Ubicacion_Local`, `Horario_Local`) " +
                             "VALUES (@Nombre, @Ubicacion, @Horario)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Nombre", local.NombreLocal1);
                comando.Parameters.AddWithValue("@Ubicacion", local.UbicacionLocal1);
                comando.Parameters.AddWithValue("@Horario", local.Horario1);

                int resultado = comando.ExecuteNonQuery();
                return resultado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }
        public int RegistoEventos(eventos evento)
        {
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            try
            {
                conexion.Open();
                string sql = "INSERT INTO eventos (Usuario_ID, Fecha_Evento, MontoMinimo_Evento, MontoMaximo_Evento" +
                    ", Estado_Evento ) " +
                             "VALUES (@Usuario, @Fecha, @Maximo, @Minimo, @Estado)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@Usuario", evento.UsuarioID);
                comando.Parameters.AddWithValue("@Fecha", evento.Fecha1);
                comando.Parameters.AddWithValue("@Maximo", evento.MontoMaximo1);
                comando.Parameters.AddWithValue("@Minimo", evento.MontoMinimo1);
                comando.Parameters.AddWithValue("@Estado", evento.EstadoEvento1);

                int resultado = comando.ExecuteNonQuery();
                int eventoID = (int)comando.LastInsertedId;
                return resultado;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable ObtenerLocales()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conexion = Clases.CConexion.EstablecerConexion())
            {
                string query = "SELECT * FROM locales";
                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }



        //NO FUNCIONA POR EL MOMENTO xd
        //public bool existeUsuario(string usuario)
        //{
        //    MySqlDataReader reader;
        //    MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
        //    conexion.Open();

        //    string sql = "SELECT Usuario_ID FROM usuarios WHERE Nombre_Usuario LIKE @usuarios";
        //    MySqlCommand comando = new MySqlCommand(sql, conexion);
        //    comando.Parameters.AddWithValue("@usuario", usuario);

        //    reader = comando.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        public Usuario PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Clases.CConexion.EstablecerConexion();
            conexion.Open();
            string sql = "SELECT Usuario_ID, Contraseña_Usuario, Nombre_Usuario, Tipo_Usuario FROM usuarios WHERE Nombre_Usuario = @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuario usr = null;
            

            while (reader.Read())
            {
                usr = new Usuario();
                usr.UsuarioID1 = int.Parse(reader["Usuario_ID"].ToString());
                usr.NombreUsuario1 = reader["Nombre_Usuario"].ToString();
                usr.ContraseñaUsuario1 = reader["Contraseña_Usuario"].ToString();
                usr.TipoUsuario1 = reader["Tipo_Usuario"].ToString();
            }
            return usr;
        }
        
    }
}
