using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class SucursalesModel
    {

        int idSucursal;
        string nombreSucursal;
        int idMunicipio;
        string calleSucursal;


        public SucursalesModel()
        {            
        }


        public SucursalesModel(int idSucursal, string nombreSucursal, int idMunicipio, string calleSucursal)
        {
            this.idSucursal = idSucursal;
            this.nombreSucursal = nombreSucursal;
            this.idMunicipio = idMunicipio;
            this.calleSucursal = calleSucursal;
        }

        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public string NombreSucursal { get => nombreSucursal; set => nombreSucursal = value; }
        public int IdMunicipio { get => idMunicipio; set => idMunicipio = value; }
        public string CalleSucursal { get => calleSucursal; set => calleSucursal = value; }
    }
}
