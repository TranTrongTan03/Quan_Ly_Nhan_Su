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
    public class NhanVienQuanLyBUS
    {
        public DataTable layTatCaNhanVienQL()
        {
            try
            {
                NhanVienQuanLy nhanVienQuanLy = new NhanVienQuanLy();
                return nhanVienQuanLy.layTatCaNhanVienQL();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int ThemNhanVienQL(NhanVienQuanLyDTO ql)
        {
            try
            {
                NhanVienQuanLy nhanVienQuanLy = new NhanVienQuanLy();
                return nhanVienQuanLy.ThemNhanVienQL(ql);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int XoaNhanVienQL(String tenQL)
        {
            try
            {
                NhanVienQuanLy nhanVienQuanLy = new NhanVienQuanLy();
                return nhanVienQuanLy.XoaNhanVienQL(tenQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int SuaNhanVienQL(NhanVienQuanLyDTO Nvql)
        {
            try
            {

                NhanVienQuanLy nhanVienQuanLy = new NhanVienQuanLy();
                return nhanVienQuanLy.SuaNhanVienQL(Nvql);

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable TimNhanVienQL(String tenQL)
        {
            try
            {
                NhanVienQuanLy nhanVienQuanLy = new NhanVienQuanLy();
                return nhanVienQuanLy.TimNhanVienQL(tenQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
