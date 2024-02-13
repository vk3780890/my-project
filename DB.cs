using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Gmail
{
    public class DB
    {
        public const string MySqlConnection = "Mysql";

        //This returns the connection string  
        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings[MySqlConnection].ConnectionString;
                }
                return _connectionString;
            }
        }


        /// <summary>
        /// Brings a SqlCommand object to be able to add some parameters in it. After you send this to Execute method.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public MySqlCommand GetCommand(string Mysql)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            MySqlCommand MysqlCmd = new MySqlCommand(Mysql, conn);
            return MysqlCmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql, List<MySqlParameter> paramslist)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = GetCommand(sql);
            if (paramslist != null)
            {
                for (int i = 0; i < paramslist.Count; i++)
                {
                    cmd.Parameters.Add(paramslist[i]);
                }
            }
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteWithParams(string sql, List<MySqlParameter> paramslist)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = GetCommand(sql);
            cmd.Parameters.Clear();
            for (int i = 0; i < paramslist.Count; i++)
            {
                cmd.Parameters.Add(paramslist[i]);
            }
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        /// <summary>
        /// Datatable Döndür
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(MySqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            //command.ExecuteNonQuery();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, List<MySqlParameter> paramslist)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = GetCommand(sql);
            for (int i = 0; i < paramslist.Count; i++)
            {
                cmd.Parameters.Add(paramslist[i]);
            }
            cmd.Connection.Open();
            var result = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Mysql, List<MySqlParameter> paramslist)
        {
            MySqlCommand cmd = GetCommand(Mysql);
            cmd.Connection.Open();
            for (int i = 0; i < paramslist.Count; i++)
            {
                cmd.Parameters.Add(paramslist[i]);
            }
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(MySqlCommand command)
        {
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="spName"></param>
        /// <returns></returns>
        public int ExecuteStoredProcedure(string spName)
        {
            MySqlCommand cmd = GetCommand(spName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteStoredProcedure(MySqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }
    }
}