using BUS;
using DTO;
using System.Data;

namespace GUI
{
    public partial class CongViecForm : Form
    {
        private CongViecDTO rowSelected;
        public CongViecForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                CongViecBUS congViecBUS = new CongViecBUS();
                DataTable dt = congViecBUS.layTatCa();
                dgvDanhSachCongViec.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ClearForm()
        {
            tbMaCongViec.Text = "";
            tbTenCongViec.Text = "";
        }

        private void CongViecForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public CongViecDTO getInForForm()
        {
            CongViecDTO congViecDTO = new CongViecDTO();
            string maCV = tbMaCongViec.Text;
            string tenCV = tbTenCongViec.Text;
            congViecDTO.MaCV = maCV;
            congViecDTO.TenCV = tenCV;
            return congViecDTO;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CongViecDTO congViecDTO = getInForForm();
                CongViecBUS congViecBUS = new CongViecBUS();
                int kq = congViecBUS.ThemCongViec(congViecDTO);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    CongViecBUS congViecBUS = new CongViecBUS();
                    int kq =congViecBUS.XoaCongViec(rowSelected.MaCV);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadData();
                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CongViecDTO congViecDTO = getInForForm();
                CongViecBUS congViecBUS = new CongViecBUS();
                int kq = congViecBUS.SuaCongViec(congViecDTO);
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dgvDanhSachCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachCongViec.RowCount)
            {
                rowSelected = new CongViecDTO();
                rowSelected.MaCV = dgvDanhSachCongViec.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.TenCV = dgvDanhSachCongViec.Rows[e.RowIndex].Cells[1].Value.ToString();

                tbMaCongViec.Text = dgvDanhSachCongViec.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenCongViec.Text = dgvDanhSachCongViec.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            string tenCV = tbTim.Text;
            string maCV = tbTim.Text;
            CongViecBUS congViecBUS = new CongViecBUS();
            DataTable dt = congViecBUS.TimCongViec(tenCV);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvDanhSachCongViec.DataSource = source;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm();
            quanLyForm.ShowDialog();
            this.Close();
        }
    }
}
