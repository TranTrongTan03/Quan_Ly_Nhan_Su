using System;
using System.Collections.Generic;
using System.Data;
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
                String query = "SELECT * FORM TaiKhoan";
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
                String query = "sp_ThemTaiKhoan";
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
    }
}
