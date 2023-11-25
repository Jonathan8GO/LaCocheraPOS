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
    public partial class CONSULTA_PRODUCTO : Form
    {
        public CONSULTA_PRODUCTO()
        {
            InitializeComponent();
        }

        private void GBXProducTotal_Enter(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNProducTotal_Click(object sender, EventArgs e)
        {
            ProductosDAO objProductos = new ProductosDAO();
            DataTable tabla = new DataTable();
            objProductos.ConsultarTotalProd().Fill(tabla);
            DGVProducTotal.DataSource = tabla;
        }

        private void BTNProducActivos_Click(object sender, EventArgs e)
        {
            ProductosDAO objProductos = new ProductosDAO();
            DataTable tabla = new DataTable();
            objProductos.ConsultarExistProd().Fill(tabla);
            DGVProducActivos.DataSource = tabla;
        }

        private void BTNProducInactivos_Click(object sender, EventArgs e)
        {
            ProductosDAO objProductos = new ProductosDAO();
            DataTable tabla = new DataTable();
            objProductos.ConsultarInexistProd().Fill(tabla);
            DGVProducInactivos.DataSource = tabla;            
        }

        private void CONSULTA_PRODUCTO_Load(object sender, EventArgs e)
        {

        }
    }
}
