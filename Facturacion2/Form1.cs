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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CTR_btn_Click(object sender, EventArgs e)
        {
            conexion2.conexion();//class call where is the connexion
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            consProd m = new consProd();
            m.Visible = true;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
