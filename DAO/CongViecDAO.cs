using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class CongViecDAO
    {
        public DataTable layTatCa()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM CongViec ";
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
        public int ThemCongViec(CongViecDTO congViecDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemCongViec";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaCV", Value = congViecDTO.MaCV},
                    new SqlParameter { ParameterName = "@TenCV", Value = congViecDTO.TenCV });
                return nRow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.Disconnect();
            }
            return nRow;
        }
        public int XoaCongViec(String maCV)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query1 = "sp_XoaCongViec";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                     new SqlParameter { ParameterName = "@MaCV", Value = maCV });
                return nRow;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return nRow;
        }
        public int SuaCongViec(CongViecDTO congViecDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_SuaCongViec";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaCV", Value = congViecDTO.MaCV },
                    new SqlParameter { ParameterName = "@TenCV", Value = congViecDTO.TenCV });
                return nRow;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                provider.Disconnect();
            }
            return nRow;
        }
        public DataTable TimCongViec(String tenCV)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query = "sp_TimCongViec";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query,
                        new SqlParameter { ParameterName = "@tenCV", Value = tenCV });
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
        }
    }
}
