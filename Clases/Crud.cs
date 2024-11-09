using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Grupo4_Clave4.Clases
{
    class Crud
    {
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
