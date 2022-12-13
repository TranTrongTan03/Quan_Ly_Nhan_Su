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
    public class QuanLyPhongDAO
    {
        public DataTable layMa()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT MaQL FROM QuanLy ";
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
        public DataTable layTatCa()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM Phong ";
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
        public int ThemPhong(PhongDTO phongDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemPhong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaPhong", Value = phongDTO.MaPhong },
                    new SqlParameter { ParameterName = "@SoNV", Value = phongDTO.SoNV },
                    new SqlParameter { ParameterName = "@TruongPhong", Value = phongDTO.TruongPhong },
                    new SqlParameter { ParameterName = "@NVQuanLy", Value = phongDTO.NvQuanLy });
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
        public int XoaPhong(String maPhong)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query1 = "sp_XoaPhong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                     new SqlParameter { ParameterName = "@MaPhong", Value = maPhong});
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
        public int SuaPhong(PhongDTO phongDTO)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_SuaPhong";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaPhong", Value = phongDTO.MaPhong },
                    new SqlParameter { ParameterName = "@SoNV", Value = phongDTO.SoNV },
                    new SqlParameter { ParameterName = "@TruongPhong", Value = phongDTO.TruongPhong },
                    new SqlParameter { ParameterName = "@NVQuanLy", Value = phongDTO.NvQuanLy });
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
        public DataTable TimPhong(String maPhong)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query = "sp_TimPhong";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query,
                    new SqlParameter { ParameterName = "@MaPhong", Value = maPhong });
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
