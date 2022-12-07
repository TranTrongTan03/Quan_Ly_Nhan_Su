using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public class Provider
    {
        static string ConnectionString = "Data Source=LAPTOP-CSRVLLOM\\SQLEXPRESS;Initial Catalog=QuanLyCongTyDB;Integrated Security=True";

        SqlConnection? Connection { get; set; }
        public void Connect()
        {
            try
            {
                if (Connection == null)

                    Connection = new SqlConnection(ConnectionString);

                if (Connection.State != ConnectionState.Closed)

                    Connection.Close();

                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            int nRow = 0;
            try
            {
                Connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                nRow = command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return nRow;
        }

        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            try
            {
                Connect();
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

    }

}
