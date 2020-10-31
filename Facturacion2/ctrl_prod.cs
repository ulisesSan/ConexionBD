using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Facturacion2
{
    class ctrl_prod : conexion2
    {
        public List<object> consulta(string dato)
        {
            MySqlDataReader reader;

            List<object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM producto ORDER BY Producto ASC";
            }
            else
            {
                sql = "SELECT * FROM producto WHERE Id_Producto LIKE '%" + dato + "%' OR Producto LIKE'%" + dato + "%' OR Cantidad_Stock LIKE '%" + dato + "%' " +
                    "OR precio LIKE '%" + dato + "%' ORDER BY Producto ASC";
            }

            try
            {
                MySqlConnection conexionBD = base.conectProd();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    mapa_tabla _prod = new mapa_tabla();
                    _prod.Id = int.Parse(reader.GetString(0));
                    _prod.Producto = reader.GetString(1);
                    _prod.Stock = int.Parse(reader.GetString(2));
                    _prod.Precio = double.Parse(reader.GetString(3));
                    lista.Add(_prod);
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            return lista;
        }
    }
}
