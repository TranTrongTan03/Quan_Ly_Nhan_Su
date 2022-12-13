using BUS;
using DAO;
using DTO;
using System.Data;

namespace GUI
{
    public partial class PhanCongForm : Form
    {
        private PhanCongDTO rowSelected;
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
        public void LoadMaCV()
        {
            try
            {
                PhanCongBUS phanCongBUS = new PhanCongBUS();
                DataTable dt = phanCongBUS.layMaCV();
                cbbMaCV.DataSource = dt;
                cbbMaCV.DisplayMember = "MaCongViec";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void LoadMaPhong()
        {
            try
            {
                PhanCongBUS phanCongBUS = new PhanCongBUS();
                DataTable dt = phanCongBUS.layMaPhong();
                cbbMaPhong.DataSource = dt;
                cbbMaPhong.DisplayMember = "MaPhong";
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void LoadMaQL()
        {
            try
            {
                PhanCongBUS phanCongBUS = new PhanCongBUS();
                DataTable dt = phanCongBUS.layMaQL();
                cbbMaQL.DataSource = dt;
                cbbMaQL.DisplayMember = "MaQL";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ClearForm()
        {
            cbbMaCV.SelectedIndex = 0;
            cbbMaPhong.SelectedIndex = 0;
            cbbMaQL.SelectedIndex = 0;
        }

        public PhanCongDTO getInForForm()
        {
            PhanCongDTO phanCongDTO = new PhanCongDTO();
            string maQL = cbbMaQL.Text;
            string maCV = cbbMaCV.Text;
            string maPhong = cbbMaPhong.Text;

            phanCongDTO.MaQL = maQL;
            phanCongDTO.MaCV = maCV;
            phanCongDTO.MaPhong = maPhong;
            return phanCongDTO;
        }

        private void PhanCongForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMaCV();
            LoadMaPhong();
            LoadMaQL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            { 
            PhanCongDTO phanCongDTO = getInForForm();
            PhanCongBUS phanCongBUS = new PhanCongBUS();
            int kq = phanCongBUS.ThemPhanCong(phanCongDTO);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PhanCongDTO phanCongDTO = getInForForm();
                PhanCongBUS phanCongBUS = new PhanCongBUS();
                int kq = phanCongBUS.SuaPhanCong(phanCongDTO);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                try
                {
                    PhanCongBUS phanCongBUS = new PhanCongBUS();
                    int kq = phanCongBUS.XoaPhanCong(rowSelected.MaQL);
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

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            string maQL = tbTim.Text;
            PhanCongBUS phanCongBUS = new PhanCongBUS();
            DataTable dt = phanCongBUS.TimPhanCong(maQL);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvDanhSachPhanCong.DataSource = source;
        }

        private void dgvDanhSachPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhanCong.RowCount)
            {
                rowSelected = new PhanCongDTO();
                rowSelected.MaQL = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.MaCV = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.MaPhong = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[2].Value.ToString();

                cbbMaQL.Text = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbMaCV.Text = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbMaPhong.Text = dgvDanhSachPhanCong.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
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
