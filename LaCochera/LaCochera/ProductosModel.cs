using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class ProductosModel
    {
        int idProducto;
        string nombreProducto;
        double precioProducto;
        int statusProducto;

        public ProductosModel()
        {
          
        }
        public ProductosModel(int idProducto, string nombreProducto, double precioProducto, int statusProducto)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.statusProducto = statusProducto;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int StatusProducto { get => statusProducto; set => statusProducto = value; }
    }
}
