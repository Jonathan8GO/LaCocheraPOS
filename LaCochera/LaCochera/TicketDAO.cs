using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class TicketDAO {


        public int InsertarTick(TicketModel tick)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("INSERTAR_TICKET", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NO_VENTA", OracleType.Number).Value = tick.IdVenta; ;
                comando.Parameters.Add("NO_PRODUCTO", OracleType.Number).Value = tick.IdProducto;
                comando.Parameters.Add("PRECIO", OracleType.Double).Value = tick.PrecioProducto;
                comando.Parameters.Add("CANTIDAD", OracleType.Number).Value = tick.Cantidad;
                comando.Parameters.Add("TOTAL", OracleType.Number).Value = tick.TotalTick;
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


        public OracleDataAdapter ConsultarTicket()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_TICK", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = System.Data.ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }


    }
}
