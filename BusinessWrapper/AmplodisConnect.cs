using DBWrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessWrapper
{
    public static class AmplodisConnect
    {
        public static string DbType { get; set; }
        public static string ConnectionString { get; set; }

        public static DataTable ExecuteText(string CommandString)
        {
            DataSet ds = new DataSet();
            ConcreteFactory factory = new ConcreteFactory();
            var DAL = factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), DbType), ConnectionString);
            IDbCommand cmd = DAL.GeDataProviderCommand();
            IDbDataAdapter adapter = DAL.GetDataProviderDataAdapter();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = CommandString;
                cmd.Connection = DAL.OpenConnection();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                factory = null;
                DAL = null;
                cmd.Dispose();
                adapter = null;
                ds.Dispose();
            }
            return ds.Tables[0];
        }

        public static DataTable ExecuteStoredProcedure(string CommandString, DbParameter[] parameters)
        {
            DataSet ds = new DataSet();
            ConcreteFactory factory = new ConcreteFactory();
            var DAL = factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), DbType), ConnectionString);
            IDbCommand cmd = DAL.GeDataProviderCommand();
            IDbDataAdapter adapter = DAL.GetDataProviderDataAdapter();
            try
            {
                if (parameters != null)
                {
                    foreach (DbParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = CommandString;
                cmd.Connection = DAL.OpenConnection();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                factory = null;
                DAL = null;
                cmd.Dispose();
                adapter = null;
                ds.Dispose();
            }
            return ds.Tables[0];
        }

        public static void ExecuteNoneQueryText(string CommandString)
        {
            ConcreteFactory factory = new ConcreteFactory();
            var DAL = factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), DbType), ConnectionString);
            IDbCommand cmd = DAL.GeDataProviderCommand();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = CommandString;
                cmd.Connection = DAL.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                factory = null;
                DAL = null;
                cmd.Dispose();
            }
        }

        public static void ExecuteNonQueryStoredProcedure(string CommandString, DbParameter[] parameters)
        {
            ConcreteFactory factory = new ConcreteFactory();
            var DAL = factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), DbType), ConnectionString);
            IDbCommand cmd = DAL.GeDataProviderCommand();
            try
            {
                if (parameters != null)
                {
                    foreach (DbParameter param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = CommandString;
                cmd.Connection = DAL.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                factory = null;
                DAL = null;
                cmd.Dispose();
            }
        }
    }
}
