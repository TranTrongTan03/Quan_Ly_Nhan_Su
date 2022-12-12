using QuanLyNhanSu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyTaiKhoanBUS
    {
        public DataTable layTatCaTaiKhoan()
        {
            try
            {
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                return quanLyTaiKhoan.layTatCaTaiKhoan();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public int ThemTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                return quanLyTaiKhoan.ThemTaiKhoan(tk);
            }catch(Exception ex)
            {
                throw;
            }
        }
        public int XoaTaiKhoan(String tenDangNhap)
        {
            try
            {
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                return quanLyTaiKhoan.XoaTaiKhoan(tenDangNhap);
            }catch(Exception ex)
            {
                throw;
            }
        }
        public int SuaTaiKhoan(TaiKhoanDTO tk)
        {
            try 
            { 

            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            return quanLyTaiKhoan.SuaTaiKhoan(tk);

            }catch(Exception ex)
            {
                throw ;
            }
        }
        public DataTable TimTaiKhoan(String tenDangNhap)
        {
            try
            {
                QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
                return quanLyTaiKhoan.TimTaiKhoan(tenDangNhap);
            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
