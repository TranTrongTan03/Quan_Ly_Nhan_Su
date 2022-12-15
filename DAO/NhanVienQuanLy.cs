using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienQuanLy
    {
        public DataTable layTatCaNhanVienQL()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM QuanLy";
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

        public int ThemNhanVienQL(NhanVienQuanLyDTO Nvql)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemNhanVienQL";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@TenQL", Value = Nvql.TenQL },
                    new SqlParameter { ParameterName = "@MaQL", Value = Nvql.MaQL },
                    new SqlParameter { ParameterName = "@NgaySinh", Value = Nvql.NgaySinh },
                    new SqlParameter { ParameterName = "@GioiTinh", Value = Nvql.GioiTinh },
                    new SqlParameter { ParameterName = "@DienThoai", Value = Nvql.DienThoai },
                    new SqlParameter { ParameterName = "@Email", Value = Nvql.Email },
                    new SqlParameter { ParameterName = "@DiaChi", Value = Nvql.DiaChi });
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

        public int XoaNhanVienQL(String tenQL)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query2 = "sp_XoaNhanVienQL";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query2,
                     new SqlParameter { ParameterName = "@tenQL", Value = tenQL });
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

        public int SuaNhanVienQL(NhanVienQuanLyDTO Nvql)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                
                    String query3 = "sp_SuaNhanVienQL";
                    provider.Connect();
                    nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query3,
                            new SqlParameter { ParameterName = "@maQL", Value = Nvql.MaQL },
                            new SqlParameter { ParameterName = "@tenQL", Value = Nvql.TenQL },
                            new SqlParameter { ParameterName = "@ngaySinh", Value = Nvql.NgaySinh },
                            new SqlParameter { ParameterName = "@gioiTinh", Value = Nvql.GioiTinh },
                            new SqlParameter { ParameterName = "@dienThoai", Value = Nvql.DienThoai },
                            new SqlParameter { ParameterName = "@email", Value = Nvql.Email },
                            new SqlParameter { ParameterName = "@diaChi", Value = Nvql.DiaChi });
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

        public DataTable TimNhanVienQL(String tenQL)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query4 = "sp_TimNhanVienQL";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query4,
                    new SqlParameter { ParameterName = "@TenQL", Value = tenQL });
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
