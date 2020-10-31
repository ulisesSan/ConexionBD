using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion2
{
    class mapa_tabla
    {
        private int id;
        private string producto;
        private int stock;
        private double precio;

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
