using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class EmpleadosModel
    {
        int idEmpleado;
        string nombreEmpleado;
        string apPaterno;
        string apMaterno;
        int edadEmpleado;
        string sexoEmpleado;
        int idSucursal;
        int statusEmpleado;



        public EmpleadosModel()
        {
             
        }


        public EmpleadosModel(int idEmpleado, string nombreEmpleado, string apPaterno, string apMaterno, int edadEmpleado, string sexoEmpleado, int idSucursal, int statusEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.edadEmpleado = edadEmpleado;
            this.sexoEmpleado = sexoEmpleado;
            this.idSucursal = idSucursal;
            this.statusEmpleado = statusEmpleado;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public int EdadEmpleado { get => edadEmpleado; set => edadEmpleado = value; }
        public string SexoEmpleado { get => sexoEmpleado; set => sexoEmpleado = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int StatusEmpleado { get => statusEmpleado; set => statusEmpleado = value; }
    }
}
