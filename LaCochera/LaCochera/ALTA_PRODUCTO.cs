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
    public partial class ALTA_PRODUCTO : Form
    {
        public ALTA_PRODUCTO()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNAgregarProd_Click(object sender, EventArgs e)
        {
            ProductosModel modelProd = new ProductosModel();
            modelProd.NombreProducto = (TXTNombreProd.Text).ToUpper();
            modelProd.PrecioProducto = Convert.ToDouble(TXTPrecioProd.Text);
            ProductosDAO objProducto = new ProductosDAO();
            int Res = objProducto.InsertarProd(modelProd);
            if (Res == 1)
            {
                MessageBox.Show("Producto Agregado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void ALTA_PRODUCTO_Load(object sender, EventArgs e)
        {

        }
    }
}
