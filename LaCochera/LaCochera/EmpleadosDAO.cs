using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class EmpleadosDAO
    {
        public int InsertarEmp(EmpleadosModel empleado)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("INSERTAR_EMPLEADOS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = empleado.NombreEmpleado;
                comando.Parameters.Add("PATERNO", OracleType.VarChar).Value = empleado.ApPaterno;
                comando.Parameters.Add("MATERNO", OracleType.VarChar).Value = empleado.ApMaterno;
                comando.Parameters.Add("EDAD", OracleType.Number).Value = empleado.EdadEmpleado;
                comando.Parameters.Add("SEXO", OracleType.VarChar).Value = empleado.SexoEmpleado;
                comando.Parameters.Add("ID_SUC", OracleType.Number ).Value = empleado.IdSucursal;
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

        public int BajaEmp(EmpleadosModel empleado)
        {

            int ok = 0;

            CONN objConn = new CONN();

            objConn.Conectar();

            try
            {
                OracleCommand comando = new OracleCommand("BAJA_EMPLEADOS", objConn.ConnOracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ID", OracleType.Number).Value = empleado.IdEmpleado;               
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



        public OracleDataAdapter ConsultarActivosEmp()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_EMP_ACTIVOS_VW", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }

        public OracleDataAdapter ConsultarInactivosEmp()
        {

            CONN objConn = new CONN();
            objConn.Conectar();
            OracleCommand comando = new OracleCommand("CONSULTAR_EMP_INACTIVOS_VW", objConn.ConnOracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("REGISTROS", OracleType.Cursor).Direction = ParameterDirection.Output; /* using system.data */
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            objConn.Desconectar();
            return adaptador;
        }       


    }
}
