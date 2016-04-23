using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public class OledbDAL : DataAccessLayer
    {
         // Provide class constructors
        public OledbDAL() { }

        public OledbDAL(string connectionString)
        {
            this.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Development\\Mine\\DataAccessLayer\\Northwind.mdb";
        }
 
 
        // DALBaseClass Members
        public override IDbConnection GetDataProviderConnection()
        {
            return new OleDbConnection();
        }
        public override IDbCommand GeDataProviderCommand()
        {
            return new OleDbCommand();
        }
 
        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new OleDbDataAdapter();
        }
    }
}