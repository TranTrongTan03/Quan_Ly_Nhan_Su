using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class QuanLyPhongBUS
    {
        public DataTable layTatCa()
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.layTatCa();
            }catch(Exception ex)
            {
                throw;
            }
        }
        public DataTable layMa()
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.layMa();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int ThemPhong(PhongDTO phongDTO)
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.ThemPhong(phongDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int XoaPhong(String maPhong)
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.XoaPhong(maPhong);
            }catch(Exception ex)
            {
                throw;
            }
        }
        public int SuaPhong(PhongDTO phongDTO)
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.SuaPhong(phongDTO);
            }catch(Exception ex)
            {
                throw;
            }
        }
        public DataTable TimPhong(String maPhong)
        {
            try
            {
                QuanLyPhongDAO quanLyPhongDAO = new QuanLyPhongDAO();
                return quanLyPhongDAO.TimPhong(maPhong);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
