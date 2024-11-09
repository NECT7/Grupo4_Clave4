using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Grupo4_Clave4.Clases
{
    class CConexion

        // <sumary>
        // Creacion de la clase para conexion a base de datos
        // </sumary>
    {
        MySqlConnection conex = new MySqlConnection();

        //Variables estaticas que almacenan las credenciales para la conexion a la base de datos
        static string servidor = "localhost"; //servidor donde se encuentra la base
        static string db = "Clave4_Grupo4DB"; //Nombre de la base de datos
        static string usuario = "root"; //Nombre de usuario
        static string port = "3306"; //puerto
        static string password = ""; //contreña de la conexion


        //Cadena de caracteres para ejecutar la conexion
        String cadenaConexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + usuario
            + ";" + "password=" + password + ";" + "database=" + db + ";";


        //bloque para abrir conexion
        public MySqlConnection EstablecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("erro: " + e);
            }
            return conex;
        }

    }
}
