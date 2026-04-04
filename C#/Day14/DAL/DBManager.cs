using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;

namespace DAL
{
    public class DBManager
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        public static DataTable table;


        public DBManager()
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
                cmd = new SqlCommand(string.Empty, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                table = new DataTable();
            }
            catch (Exception ex)
            {

            }
        }

        public int ExecuteNonQuery(string SPName, Dictionary<string, object> Parameters)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = SPName;

                foreach (var param in Parameters)
                    cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                return cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return -1;
        }
        public int ExecuteNonQuery(string SPName)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = SPName;

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return -1;
        }

        public object ExecuteScalar(string SPName)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = SPName;

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                return cmd.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return new();
        }
        public object ExecuteScalar(string SPName, Dictionary<string, object> Parameters)
        {
            throw new NotImplementedException();
        }

        public DataTable ExecuteDataTable(string SPName)
        {
            try
            {
                table.Clear();
                cmd.Parameters.Clear();

                cmd.CommandText = SPName;

                adapter.Fill(table);
            }
            catch
            {

            }
            return table;
        }
        public DataTable ExecuteDataTable(string SPName, Dictionary<string, object> Parameters)
        {
            try
            {
                table.Clear();
                cmd.Parameters.Clear();
                cmd.CommandText = SPName;
                foreach (var param in Parameters)
                    cmd.Parameters.Add(new SqlParameter(param.Key, param.Value));
                adapter.Fill(table);
            }
            catch
            {
            }
            return table;
        }
    }
}
