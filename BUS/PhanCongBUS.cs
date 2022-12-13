using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanCongBUS
    {
        public DataTable layTatCa()
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.layTatCa();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public DataTable layMaCV()
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.layMaCV();
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
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.layMaPhong();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable layMaQL()
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.layMaQL();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ThemPhanCong(PhanCongDTO phanCongDTO)
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.ThemPhanCong(phanCongDTO);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public int XoaPhanCong(String maQL)
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.XoaPhanCong(maQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int SuaPhanCong(PhanCongDTO phanCongDTO)
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.SuaPhanCong(phanCongDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable TimPhanCong(String maQL)
        {
            try
            {
                PhanCongDAO phanCongDAO = new PhanCongDAO();
                return phanCongDAO.TimPhanCong(maQL);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
