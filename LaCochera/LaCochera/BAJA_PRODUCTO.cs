using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCochera
{
    public partial class BAJA_PRODUCTO : Form
    {
        public BAJA_PRODUCTO()
        {
            InitializeComponent();
        }

        private void BAJA_PRODUCTO_Load(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNBajaProd_Click(object sender, EventArgs e)
        {
            ProductosModel modelProd = new ProductosModel();
            modelProd.IdProducto = Convert.ToInt32(TXTIDProdBaja.Text);         
            ProductosDAO objProducto = new ProductosDAO();
            int Res = objProducto.BajaProd(modelProd);
            if (Res == 1)
            {
                MessageBox.Show("Producto Eliminado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BTNReactivarProduc_Click(object sender, EventArgs e)
        {
            ProductosModel modelProd = new ProductosModel();
            modelProd.IdProducto = Convert.ToInt32(TXTIDProdBaja.Text);
            ProductosDAO objProducto = new ProductosDAO();
            int Res = objProducto.ReactivarProd(modelProd);
            if (Res == 1)
            {
                MessageBox.Show("Producto Reactivado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BTNModPrecio_Click(object sender, EventArgs e)
        {
            ProductosModel modelProd = new ProductosModel();
            modelProd.IdProducto = Convert.ToInt32(TXTProdMod.Text);
            modelProd.PrecioProducto = Convert.ToDouble(TXTModPrecioProd.Text);
            ProductosDAO objProducto = new ProductosDAO();
            int Res = objProducto.PrecioProd(modelProd);
            if (Res == 1)
            {
                MessageBox.Show("Producto Modificado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
