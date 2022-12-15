using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QuanLyNhanVien
    {
        public DataTable layTatCaNhanVien()
        {
            DataTable dt = new DataTable();
            Provider provider = new Provider();
            try
            {
                String query = "SELECT * FROM NhanVien";
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

        public int ThemNhanVien(NhanVienDTO nv)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                String query1 = "sp_ThemNhanVien";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query1,
                    new SqlParameter { ParameterName = "@MaNV", Value = nv.MaNV },
                    new SqlParameter { ParameterName = "@TenNV", Value = nv.TenNV },               
                    new SqlParameter { ParameterName = "@NgaySinh", Value = nv.NgaySinh },
                    new SqlParameter { ParameterName = "@Email", Value = nv.Email },
                    new SqlParameter { ParameterName = "@DienThoai", Value = nv.DienThoai },
                    new SqlParameter { ParameterName = "@DiaChi", Value = nv.DiaChi },
                    new SqlParameter { ParameterName = "@MaPhong", Value = nv.MaPhong });
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


        public int XoaNhanVien(String maNV)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {
                string query2 = "sp_XoaNhanVien";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query2,
                     new SqlParameter { ParameterName = "@maNV", Value = maNV });
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

        public int SuaNhanVien(NhanVienDTO nv)
        {
            Provider provider = new Provider();
            int nRow = 0;
            try
            {

                String query3 = "sp_SuaNhanVien";
                provider.Connect();
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, query3,
                        new SqlParameter { ParameterName = "@maNV", Value = nv.MaNV },
                        new SqlParameter { ParameterName = "@tenNV", Value = nv.TenNV },
                        new SqlParameter { ParameterName = "@ngaySinh", Value = nv.NgaySinh },
                        new SqlParameter { ParameterName = "@email", Value = nv.Email },
                        new SqlParameter { ParameterName = "@dienThoai", Value = nv.DienThoai },
                        new SqlParameter { ParameterName = "@diaChi", Value = nv.DiaChi },
                        new SqlParameter { ParameterName = "@maPhong", Value = nv.MaPhong });
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
        public DataTable TimNhanVien(String tenNV)
        {
            DataTable dt;
            Provider provider = new Provider();
            try
            {
                string query4 = "sp_TimNhanVien";
                provider.Connect();
                dt = provider.Select(CommandType.StoredProcedure, query4,
                    new SqlParameter { ParameterName = "@TenNV", Value = tenNV });
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
