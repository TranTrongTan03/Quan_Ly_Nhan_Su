using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class QuanLyTaiKhoan
    {
        public DataTable layTatCaTaiKhoan()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM TaiKhoan";
                provider.Connect();
                dt = provider.Select(CommandType.Text, query);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return null;
        }
        public int ThemTaiKhoan(TaiKhoanDTO tk)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@TenDangNhap", Value = tk.TenDangNhap },
                    new SqlParameter { ParameterName = "@MatKhau", Value = tk.MatKhau },
                    new SqlParameter { ParameterName = "@Loai", Value = tk.Loai});
                return nRow;
            }catch(Exception ex)
            {
                throw;
            }
            finally
            {
                provider.Disconnect();
            }
            return nRow;
        }
        public int XoaTaiKhoan(String tenDangNhap)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query1 = "sp_XoaTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                     new SqlParameter { ParameterName = "@ten", Value = tenDangNhap });
                return nRow;
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                provider.Disconnect();
            }
            return nRow;
        }
        public int SuaTaiKhoan(TaiKhoanDTO tk)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_SuaTaiKhoan";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                      new SqlParameter { ParameterName = "@ten", Value = tk.TenDangNhap },
                      new SqlParameter { ParameterName = "@matkhau", Value = tk.MatKhau },
                      new SqlParameter { ParameterName = "@loai", Value = tk.Loai });
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
        public DataTable TimTaiKhoan(String tenDangNhap)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query = "sp_TimTaiKhoan";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query,
                    new SqlParameter { ParameterName = "@Ten", Value = tenDangNhap });
                return dt;
            }catch(Exception ex)
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
