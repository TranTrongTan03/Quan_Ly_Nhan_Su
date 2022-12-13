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
                String query = "SELECT * FROM PhanCong";
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
        public DataTable layMaCV()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT MaCongViec FROM CongViec";
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
        public DataTable layMaPhong()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT MaPhong FROM Phong";
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
        public DataTable layMaQL()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT MaQL FROM QuanLy";
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
        public int ThemPhanCong(PhanCongDTO phanCongDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemPhanCong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaQL", Value = phanCongDTO.MaQL },
                    new SqlParameter { ParameterName = "@MaCongViec", Value = phanCongDTO.MaCV },
                    new SqlParameter { ParameterName = "@MaPhong", Value = phanCongDTO.MaPhong });
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
        public int XoaPhanCong(String maQL)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query1 = "sp_XoaPhanCong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                     new SqlParameter { ParameterName = "@MaQL", Value = maQL });
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
        public int SuaPhanCong(PhanCongDTO phanCongDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_SuaPhanCong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaQL", Value = phanCongDTO.MaQL },
                    new SqlParameter { ParameterName = "@MaCV", Value = phanCongDTO.MaCV },
                    new SqlParameter { ParameterName = "@MaPhong", Value = phanCongDTO.MaPhong });
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
        public DataTable TimPhanCong(String maQL)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query = "sp_TimPhanCong";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query,
                        new SqlParameter { ParameterName = "@MaQL", Value = maQL });
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
