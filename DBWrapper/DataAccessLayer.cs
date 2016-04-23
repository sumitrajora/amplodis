using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DBWrapper
{
    public abstract class DataAccessLayer
    {
        private string strConnectionString;
        private IDbConnection connection;
        private IDbCommand command;
        private IDbTransaction transaction;

        public string ConnectionString
        {
            get
            {
                if (strConnectionString == string.Empty || strConnectionString.Length == 0)
                    throw new ArgumentException("Invalid database connection string.");

                return strConnectionString;
            }
            set
            { strConnectionString = value; }
        }

        public abstract IDbConnection GetDataProviderConnection();

        public abstract IDbCommand GeDataProviderCommand();

        public abstract IDbDataAdapter GetDataProviderDataAdapter();

        #region Database Transaction

        public IDbConnection OpenConnection()
        {
            try
            {
                connection = GetDataProviderConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
            }
            catch
            {
                connection.Close();
            }
            return connection;
        }
        #endregion
    }
}