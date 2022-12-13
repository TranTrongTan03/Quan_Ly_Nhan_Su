using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CongViecBUS
    {
        public DataTable layTatCa()
        {
            try
            {
                CongViecDAO congViecDAO = new CongViecDAO();
                return congViecDAO.layTatCa();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int ThemCongViec(CongViecDTO congViecDTO)
        {
            try
            {
                CongViecDAO congViecDAO = new CongViecDAO();
                return congViecDAO.ThemCongViec(congViecDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int XoaCongViec(String maCV)
        {
            try
            {
                CongViecDAO congViecDAO = new CongViecDAO();
                return congViecDAO.XoaCongViec(maCV);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int SuaCongViec(CongViecDTO congViecDTO)
        {
            try
            {
                CongViecDAO congViecDAO = new CongViecDAO();
                return congViecDAO.SuaCongViec(congViecDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable TimCongViec(String tenCV)
        {
            try
            {
                CongViecDAO congViecDAO = new CongViecDAO();
                return congViecDAO.TimCongViec(tenCV);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
