using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public enum DataProviderType
    {
        Access,
        Odbc,
        OleDb,
        Oracle,
        Sql
    }

    public abstract class DALFactory
    {
        public abstract DataAccessLayer GetDataAccessLayer(DataProviderType dataProviderType, string conString);
    }
}