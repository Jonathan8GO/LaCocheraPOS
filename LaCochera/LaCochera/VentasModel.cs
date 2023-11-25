using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class VentasModel
    {
        

        int idVenta;
        DateTime fecha;
      //  int totalVenta;
        int idSucursal;
        int idEmpleado;


        public VentasModel()
        {
        }

        public VentasModel(int idVenta, DateTime fecha, 
            //int totalVenta,
            int idSucursal, int idEmpleado)
        {
            this.idVenta = idVenta;
            this.fecha = fecha;
            //this.totalVenta = totalVenta;
            this.idSucursal = idSucursal;
            this.idEmpleado = idEmpleado;
        }


      


        public int IdVenta { get => idVenta; set => idVenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        //public int TotalVenta { get => totalVenta; set => totalVenta = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        

    }
}
