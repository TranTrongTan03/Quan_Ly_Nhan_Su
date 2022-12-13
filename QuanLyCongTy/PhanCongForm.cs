using BUS;
using System.Data;

namespace GUI
{
    public partial class PhanCongForm : Form
    {
        public PhanCongForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                PhanCongBUS phanCongBUS = new PhanCongBUS();
                DataTable dt = phanCongBUS.layTatCa();
                dgvDanhSachPhanCong.DataSource = dt;

            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
