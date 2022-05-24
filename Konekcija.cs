using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Olimpijada
{
    class Konekcija
    {
        static public SqlConnection vezuj()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }
    }
}
