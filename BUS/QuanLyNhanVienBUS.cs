using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyNhanVienBUS
    {
        public DataTable layTatCaNhanVien()
        {
            try
            {
                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.layTatCaNhanVien();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public DataTable layMaPhong()
        {
            try
            {
                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.layMaPhong();

            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public int ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.ThemNhanVien(nv);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int XoaNhanVien(String maNV)
        {
            try
            {
                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.XoaNhanVien(maNV);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaNhanVien(NhanVienDTO nv)
        {
            try
            {

                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.SuaNhanVien(nv);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable TimNhanVien(String tenNV)
        {
            try
            {
                QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
                return quanLyNhanVien.TimNhanVien(tenNV);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
