using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Facturacion2
{
    class conexion2
    {
        public static void conexion()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "mysql"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "a"; //Contraseña de usuario de acceso a MySQL
            string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {
                string consulta = "SHOW DATABASES"; //Consulta a MySQL (Introduce datos a la bd)
                MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0) + "\n"; //Almacena cada registro con un salto de linea
                }

                MessageBox.Show(datos+"\n Conexion exisosa"); //Imprime en cuadro de dialogo el resultado
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        public MySqlConnection conectProd()
        {
            string servidor = "localhost"; //Nombre o ip del servidor de MySQL
            string bd = "facturacion"; //Nombre de la base de datos
            string usuario = "ulises"; //Usuario de acceso a MySQL
            string password = "a"; //Contraseña de usuario de acceso a MySQL
            //string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; " +
                "User Id=" + usuario + "; Password=" + password + "";

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.

            try
            {

                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si existe un error aquí muestra el mensaje
                return null;
            }
        }
    }
}
