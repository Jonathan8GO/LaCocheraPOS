using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCochera
{
    class CONN
    {
        OracleConnection connOracle = new OracleConnection("DATA SOURCE = orcl ; USER = PROGRA2 ; PASSWORD = 123");

        public OracleConnection ConnOracle { get => connOracle; set => connOracle = value; }

        public void Conectar() {
            connOracle.Open();
        }

        public void Desconectar() {
            ConnOracle.Close();
        }

    }
}
