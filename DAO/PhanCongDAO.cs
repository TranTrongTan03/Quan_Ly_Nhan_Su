using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanCongDAO
    {
        public DataTable layTatCa()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM Phong";
                provider.Connect();
                dt = provider.Select(CommandType.Text, query);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return null;
        }
    }
}
