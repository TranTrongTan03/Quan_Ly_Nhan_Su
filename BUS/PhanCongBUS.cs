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
    }
}
