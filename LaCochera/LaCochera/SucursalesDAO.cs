using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class SucursalesDAO
    {

        public int InsertarSuc(SucursalesModel sucursal)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("INSERTAR_SUCURSALES  ", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = sucursal.NombreSucursal;
                comando.Parameters.Add("NO_MUNICIPIO", OracleType.Number).Value = sucursal.IdMunicipio;
                comando.Parameters.Add("CALLE", OracleType.VarChar).Value = sucursal.CalleSucursal;

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



        public OracleDataAdapter ConsultarSucursales()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_SUCURSALES", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }


        public OracleDataAdapter ConsultarMunicipios()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_MUNICIPIOS", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }











    }
}
