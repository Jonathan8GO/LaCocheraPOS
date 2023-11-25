using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class ProductosDAO
    {
        public int InsertarProd(ProductosModel producto){

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("INSERTAR_PRODUCTOS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = producto.NombreProducto;
                comando.Parameters.Add("PRECIO", OracleType.Double).Value = producto.PrecioProducto;
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

        public int BajaProd(ProductosModel producto)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("BAJA_PRODUCTOS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ID", OracleType.Number).Value = producto.IdProducto;
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


        public int ReactivarProd(ProductosModel producto)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("REACTIVAR_PRODUCTO", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ID", OracleType.Number).Value = producto.IdProducto;
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

        public int PrecioProd(ProductosModel producto)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("PRECIO_PRODUCTOS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ID", OracleType.Number).Value = producto.IdProducto;
                comando.Parameters.Add("PRECIO", OracleType.Number).Value = producto.PrecioProducto;
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


        public OracleDataAdapter ConsultarExistProd()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_PRODUC_EXIST_VW", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;            
        }

        public OracleDataAdapter ConsultarInexistProd()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_PRODUC_NO_EXIST_VW", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }

        public OracleDataAdapter ConsultarTotalProd()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_PRODUCTOS", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }


    }
}
