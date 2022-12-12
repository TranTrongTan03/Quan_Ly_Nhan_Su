using BUS;

using System.Data;

namespace QuanLyNhanSu
{
    public partial class QuanLyTaiKhoanForm : Form
    {
        private TaiKhoanDTO rowSelected;
        public QuanLyTaiKhoanForm()
        {
            InitializeComponent();

        }
        public void LoadData()
        {
            try
            {
                QuanLyTaiKhoanBUS qltk = new QuanLyTaiKhoanBUS();
                DataTable dt = qltk.layTatCaTaiKhoan();
                dgvDanhSachTaiKhoan.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void ClearForm()
        {
            tbTenDangNhap.Text = "";
            tbMatKhau.Text = "";
            cbLoai.SelectedIndex = 0;
        }
        public TaiKhoanDTO getInForForm()
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            string tenDangNhap = tbTenDangNhap.Text;
            string matKhau = tbMatKhau.Text;
            int loai = Convert.ToInt32(cbLoai.SelectedItem.ToString());
            tk.TenDangNhap = tenDangNhap;
            tk.MatKhau = matKhau;
            tk.Loai = loai;
            return tk;
        }

        private void QuanLyTaiKhoanForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = tbTenDangNhap.Text;
                string matKhau = tbMatKhau.Text;
                int loai = Convert.ToInt32(cbLoai.SelectedItem.ToString());
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenDangNhap = tenDangNhap;
                tk.MatKhau = matKhau;
                tk.Loai = loai;
                QuanLyTaiKhoanBUS qltk = new QuanLyTaiKhoanBUS();
                int kq = qltk.ThemTaiKhoan(tk);
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
                    QuanLyTaiKhoanBUS qltk = new QuanLyTaiKhoanBUS();
                    int kq = qltk.XoaTaiKhoan(rowSelected.TenDangNhap);
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

        private void dgvDanhSachTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachTaiKhoan.RowCount)
            {
                rowSelected = new TaiKhoanDTO();
                rowSelected.TenDangNhap = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.MatKhau = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.Loai = Convert.ToInt32(dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString());

                tbTenDangNhap.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbMatKhau.Text = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbLoai.SelectedItem = dgvDanhSachTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO tk = getInForForm();
                QuanLyTaiKhoanBUS qltk = new QuanLyTaiKhoanBUS();
                int kq = qltk.SuaTaiKhoan(tk);
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
            string tenDangNhap = tbTim.Text;
            QuanLyTaiKhoanBUS qltk = new QuanLyTaiKhoanBUS();
            DataTable dt = qltk.TimTaiKhoan(tenDangNhap);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvDanhSachTaiKhoan.DataSource = source;

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm= new QuanLyForm();
            quanLyForm.ShowDialog();
            this.Close();
        }
    }
}
