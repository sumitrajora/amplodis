using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBWrapper
{   
    public class ConcreteFactory : DALFactory
    {
        public override DataAccessLayer GetDataAccessLayer(DataProviderType dataProviderType, string conString)
        {
            switch (dataProviderType)
            {
                case DataProviderType.Access:
                case DataProviderType.OleDb:
                    return new OledbDAL();

                case DataProviderType.Odbc:
                    return new OdbcDAL();
                case DataProviderType.Oracle:
                    return new OracleDAL();
                case DataProviderType.Sql:
                    return new SqlDAL(conString);

                default:
                    throw new ArgumentException("Invalid DAL provider type.");
            }
        }
    }
}