using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion2
{
    public partial class consProd : Form
    {
        public consProd()
        {
            InitializeComponent();
            cargar_tabla(null);
        }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargar_tabla(dato);
        }

        private void cargar_tabla(string dato)
        {
            List<ctrl_prod> lista = new List<ctrl_prod>();
            ctrl_prod _ctrlprod = new ctrl_prod();
            tablaProd.DataSource = _ctrlprod.consulta(dato);
        }
    }
}
