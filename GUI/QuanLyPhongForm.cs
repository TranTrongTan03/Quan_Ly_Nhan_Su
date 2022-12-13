using BUS;
using DAO;
using DTO;
using System.Data;

namespace GUI
{
    public partial class QuanLyPhongForm : Form
    {
        private PhongDTO rowSelected;
        public QuanLyPhongForm()
        {
            InitializeComponent();
        }
        public void LoadMaQuanLy()
        {
            QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
            DataTable dt = quanLyPhongBUS.layMa();
            cbbMaQuanLy.DataSource = dt;
            cbbMaQuanLy.DisplayMember = "MaQL";
        } 
        public void LoadData()
        {
            try
            {
                QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
                DataTable dt = quanLyPhongBUS.layTatCa();
                dgvDanhSachPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ClearForm()
        {
            tbMaPhong.Text = "";
            tbSoNhanVien.Text = "";
            tbTruongPhong.Text = "";
            cbbMaQuanLy.SelectedIndex = 0;
        }

        private void QuanLyPhongForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMaQuanLy();
            ClearForm();
        }
        public PhongDTO getInForForm()
        {
            PhongDTO phongDTO = new PhongDTO();
            string maPhong = tbMaPhong.Text;
            int soNhanVien = Convert.ToInt32(tbSoNhanVien.Text.ToString());
            string truongPhong = tbTruongPhong.Text;
            string maQuanLy = cbbMaQuanLy.Text;

            phongDTO.MaPhong = maPhong;
            phongDTO.SoNV = soNhanVien;
            phongDTO.TruongPhong = truongPhong;
            phongDTO.NvQuanLy = maQuanLy;
            return phongDTO;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhongDTO phongDTO=getInForForm();
                QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
                int kq = quanLyPhongBUS.ThemPhong(phongDTO);
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
                    QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
                    int kq = quanLyPhongBUS.XoaPhong(rowSelected.MaPhong);
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

        private void dgvDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachPhong.RowCount)
            {
                rowSelected = new PhongDTO();
                rowSelected.MaPhong = dgvDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.SoNV = Convert.ToInt32(dgvDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString());
                rowSelected.TruongPhong = dgvDanhSachPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.NvQuanLy = dgvDanhSachPhong.Rows[e.RowIndex].Cells[3].Value.ToString();

                tbMaPhong.Text = dgvDanhSachPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbSoNhanVien.Text = dgvDanhSachPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbTruongPhong.Text = dgvDanhSachPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbMaQuanLy.SelectedItem = dgvDanhSachPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PhongDTO phongDTO = getInForForm();
                QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
                int kq = quanLyPhongBUS.SuaPhong(phongDTO);
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

        private void tbTim_TextChanged(object sender, EventArgs e)
        {
            string maPhong= tbTim.Text;
            QuanLyPhongBUS quanLyPhongBUS = new QuanLyPhongBUS();
            DataTable dt = quanLyPhongBUS.TimPhong(maPhong);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvDanhSachPhong.DataSource = source;
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
