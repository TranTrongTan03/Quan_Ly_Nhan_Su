using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace GUI
{
    public partial class NhanVienQLForm : Form
    {
        private NhanVienQuanLyDTO rowSelected ;
        public NhanVienQLForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                NhanVienQuanLyBUS nvql = new NhanVienQuanLyBUS();
                DataTable dt = nvql.layTatCaNhanVienQL();
                dgvNhanVienQL.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }

        public void ClearForm()
        {
            tbMaQL.Text = "";
            tbTenQL.Text = "";
            tbNgaySinh.Text = "";
            tbGioiTinh.SelectedItem = "";
            tbSoDt.Text = "";
            tbEmail.Text = "";
            tbDiaChi.Text = "";
        }

        public NhanVienQuanLyDTO getInForForm()
        {
            string maQL = tbMaQL.Text;
            string tenQL = tbTenQL.Text;
            string ngaySinh = tbNgaySinh.Text;
            string gioiTinh = tbGioiTinh.Text;
            string dienThoai = tbSoDt.Text;
            string email = tbEmail.Text;
            string diaChi = tbDiaChi.Text;
            NhanVienQuanLyDTO Nvql = new NhanVienQuanLyDTO(maQL,tenQL,ngaySinh,gioiTinh,dienThoai,email,diaChi);
            return Nvql;
        }

        private void NhanVienQLForm_Load(object sender, EventArgs e)
        {
            LoadData();
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
                    NhanVienQuanLyDTO Nvql = getInForForm();
                    NhanVienQuanLy nvql = new NhanVienQuanLy();
                    int kq = nvql.ThemNhanVienQL(Nvql);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {


                try
                {
                    NhanVienQuanLyBUS nvql = new NhanVienQuanLyBUS();
                    int kq = nvql.XoaNhanVienQL(rowSelected.TenQL);
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

        private void dgvNhanVienQL_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVienQL.RowCount)
            {
                rowSelected = new NhanVienQuanLyDTO();
                rowSelected.MaQL = dgvNhanVienQL.Rows[e.RowIndex].Cells[0].Value.ToString();
                rowSelected.TenQL = dgvNhanVienQL.Rows[e.RowIndex].Cells[1].Value.ToString();
                rowSelected.NgaySinh = dgvNhanVienQL.Rows[e.RowIndex].Cells[2].Value.ToString();
                rowSelected.GioiTinh = dgvNhanVienQL.Rows[e.RowIndex].Cells[3].Value.ToString();
                rowSelected.DienThoai = dgvNhanVienQL.Rows[e.RowIndex].Cells[4].Value.ToString();
                rowSelected.Email = dgvNhanVienQL.Rows[e.RowIndex].Cells[5].Value.ToString();
                rowSelected.DiaChi = dgvNhanVienQL.Rows[e.RowIndex].Cells[6].Value.ToString();

                tbMaQL.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenQL.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbNgaySinh.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGioiTinh.Text= dgvNhanVienQL.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbSoDt.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbEmail.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbDiaChi.Text = dgvNhanVienQL.Rows[e.RowIndex].Cells[6].Value.ToString();
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
                    NhanVienQuanLyDTO Nvql = getInForForm();
                    NhanVienQuanLyBUS nvql = new NhanVienQuanLyBUS();
                    int kq = nvql.SuaNhanVienQL(Nvql);
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
            string tenQL = tbTimKiem.Text;
            NhanVienQuanLyBUS nvql = new NhanVienQuanLyBUS();
            DataTable dt = nvql.TimNhanVienQL(tenQL);
            var source = new BindingSource();
            source.DataSource = dt;
            dgvNhanVienQL.DataSource = source;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

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

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailaddress = email_validation();
    }
}
