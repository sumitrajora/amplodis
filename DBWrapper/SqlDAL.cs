using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public class SqlDAL : DataAccessLayer
    {        

        public SqlDAL(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
                
        public override IDbConnection GetDataProviderConnection()
        {
            return new SqlConnection();
        }

        public override IDbCommand GeDataProviderCommand()
        {
            return new SqlCommand();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}