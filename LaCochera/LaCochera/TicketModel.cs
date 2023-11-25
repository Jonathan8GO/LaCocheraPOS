using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class TicketModel
    {

        int idTicket;
        int idProducto;
        double precioProducto;
        int cantidad;
        int idVenta;
        int totalTick;

        public TicketModel() { 

          
        }

        public TicketModel(int idTicket, int idProducto, double precioProducto, int cantidad, int idVenta, int totalTick)
        {
            this.idTicket = idTicket;
            this.idProducto = idProducto;
            this.precioProducto = precioProducto;
            this.cantidad = cantidad;
            this.idVenta = idVenta;
            this.totalTick = totalTick;
        }

        public int IdTicket { get => idTicket; set => idTicket = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int TotalTick { get => totalTick; set => totalTick = value; }
    }
}
