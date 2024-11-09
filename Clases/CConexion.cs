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



        //bloque para abrir conexion
        public static MySqlConnection EstablecerConexion()
        {
            string servidor = "localhost"; //servidor donde se encuentra la base
            string db = "Clave4_Grupo4DB"; //Nombre de la base de datos
            string usuario = "root"; //Nombre de usuario
            string port = "3306"; //puerto
            string password = ""; //contreña de la conexion

            //Cadena de caracteres para ejecutar la conexion
            String cadenaConexion = "server=" + servidor + ";" + "port=" + port + ";" + "user id=" + usuario
                + ";" + "password=" + password + ";" + "database=" + db + ";";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;


        }

    }
}
