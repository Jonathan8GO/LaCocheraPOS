using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class VentasDAO
    {

        public int InsertarVent (VentasModel venta) {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("INSERTAR_VENTAS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
               // comando.Parameters.Add("TOTAL", OracleType.Number).Value = venta.TotalVenta;
                comando.Parameters.Add("NO_SUCURSAL", OracleType.Number).Value = venta.IdSucursal;
                comando.Parameters.Add("NO_EMPLEADO", OracleType.Number).Value = venta.IdEmpleado;
                comando.ExecuteNonQuery();
                ok = 1;
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
            objConn.Desconectar();
            return ok;



        }

        public OracleDataAdapter ConsultarVenta()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_VENTAS", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = System.Data.ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }




    }
}
