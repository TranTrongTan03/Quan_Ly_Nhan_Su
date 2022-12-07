using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
                tbMatKhau.PasswordChar = (char)0;
            else
                tbMatKhau.PasswordChar= '*';
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
                Application.Exit(); 
        }

        private int kiemTraDangNhap(String dangNhap, String matKhau)
        {
            try
            {
                string query1 = "SELECT * FROM TaiKhoan " +
                    "WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                Provider provider = new Provider();
                provider.Connect();
                DataTable dt = provider.Select(CommandType.Text, query1,
                    new SqlParameter { ParameterName = "@TenDangNhap", Value = dangNhap},
                    new SqlParameter { ParameterName = "@MatKhau", Value = matKhau});
                if (dt != null && dt.Rows.Count == 0)
                    return -1;
                DataRow row = dt.Rows[0];
                return (int)row["Loai"];

            }
            catch(Exception ex)
            {
                MessageBox.Show("Form1: " + ex.ToString());
            }
            return -1;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string dangNhap = tbTaiKhoan.Text;
            string matKhau = tbMatKhau.Text;
            int kq = kiemTraDangNhap(dangNhap, matKhau);
            if (dangNhap.Trim() == "")
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            else if(matKhau.Trim() == "")
                MessageBox.Show("Vui lòng nhập mật khẩu!");

            else
            {
                if (kq == 0)
                {
                    this.Hide();
                    QuanLyForm quanLyForm = new QuanLyForm();
                    quanLyForm.ShowDialog();
                    this.Show();
                }
                else if(kq == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chích xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhauForm quenMatKhauForm = new QuenMatKhauForm();
            quenMatKhauForm.ShowDialog();
        }
    }
}