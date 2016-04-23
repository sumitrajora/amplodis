using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public class OdbcDAL : DataAccessLayer
    {

        // Provide class constructors
        public OdbcDAL() { }

        public OdbcDAL(string connectionString)
        {
            this.ConnectionString = "DSN=dsnname";
        }


        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new OdbcConnection();
        }

        public override IDbCommand GeDataProviderCommand()
        {
            return new OdbcCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new OdbcDataAdapter();
        }
    }
}