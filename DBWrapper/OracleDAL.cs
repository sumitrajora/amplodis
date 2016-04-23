using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public class OracleDAL : DataAccessLayer
    {
        // Provide class constructors
        public OracleDAL() {
            this.ConnectionString = "Data Source=Oracle8i;Integrated Security=yes";
        }

        public OracleDAL(string connectionString)
        {
            
        }


        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return null;// new OracleConnection();
        }
        public override IDbCommand GeDataProviderCommand()
        {
            return null;// new OracleCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return null;// new OracleDataAdapter();
        }
    }
}