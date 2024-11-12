using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Grupo4_Clave4.Clases
{
    class Crud
    {
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
