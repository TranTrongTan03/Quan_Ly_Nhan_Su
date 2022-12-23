using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BUS;
using DAO;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{

    public partial class QuanLyNhanVienForm : Form
    {
        private NhanVienDTO rowSelected;
        private TaiKhoanDTO TaiKhoanDTO;

        public void LoadData()
        {
            try
            {
                QuanLyNhanVienBUS nv = new QuanLyNhanVienBUS();
                DataTable dt = nv.layTatCaNhanVien();
                dgvNhanVien.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }

        public void ClearForm()
        {
            tbMaNV.Text = "";
            tbTenNV.Text = "";
            tbNgaySinh.Text = "";
            tbEmail.Text = "";
            tbDienThoai.Text = "";
            tbDiaChi.Text = "";
            cbbMaPhong.SelectedIndex = 0;
        }

        public NhanVienDTO getInForForm()
        {
            string maNV = tbMaNV.Text;
            string tenNV = tbTenNV.Text;
            string ngaySinh = tbNgaySinh.Text;
            string email = tbEmail.Text;
            string dienThoai = tbDienThoai.Text;
            string diaChi = tbDiaChi.Text;
            string maPhong = cbbMaPhong.Text;
            NhanVienDTO nv = new NhanVienDTO(maNV, tenNV, ngaySinh, email,dienThoai,diaChi,maPhong);
            return nv;
        }
        public QuanLyNhanVienForm()
        {
            InitializeComponent();
        }

        public void LoadMaPhong()
        {
            QuanLyNhanVienBUS quanLyNhanVienBUS = new QuanLyNhanVienBUS();
            DataTable dt = quanLyNhanVienBUS.layMaPhong();
            cbbMaPhong.DataSource = dt;
            cbbMaPhong.DisplayMember = "MaPhong";
        } 

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (validate_emailaddress.IsMatch(tbEmail.Text) != true)
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbEmail.Focus();
                return;
            }
            else
            {
                try
                {
                    NhanVienDTO nv = getInForForm();
                    QuanLyNhanVien qlnv = new QuanLyNhanVien();
                    int kq = qlnv.ThemNhanVien(nv);
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
            
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.RowCount)
            {
                rowSelected = new NhanVienDTO();
                rowSelected.MaNV = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.TenNV = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.NgaySinh = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.Email = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                rowSelected.DienThoai = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                rowSelected.DiaChi = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                rowSelected.MaPhong = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();

                tbMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbEmail.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDienThoai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbMaPhong.SelectedItem = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void QuanLyNhanVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadMaPhong();    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {


                try
                {
                    QuanLyNhanVienBUS nv = new QuanLyNhanVienBUS();
                    int kq = nv.XoaNhanVien(rowSelected.MaNV);
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
            if (validate_emailaddress.IsMatch(tbEmail.Text) != true)
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbEmail.Focus();
                return;
            }
            else
            {
                try
                {
                    NhanVienDTO nv = getInForForm();
                    QuanLyNhanVienBUS qlnv = new QuanLyNhanVienBUS();
                    int kq = qlnv.SuaNhanVien(nv);
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
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenNV = tbTimKiem.Text;
            QuanLyNhanVienBUS qlnv = new QuanLyNhanVienBUS();
            DataTable dt = qlnv.TimNhanVien(tenNV);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvNhanVien.DataSource = source;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

                this.Hide();
                QuanLyForm quanLyForm = new QuanLyForm();
                quanLyForm.ShowDialog();
                this.Close();
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
