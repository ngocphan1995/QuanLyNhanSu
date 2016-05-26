using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLNS_win
{
    class DB
    {
        private const string connectionString = "Server=DINHNAMPC\\DB;Database=nhansu;UID=Client;PWD=123456";
        private static SqlConnection conn;
        public static bool Connect()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                Connect();
            return conn;
        }
    }
}
