using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class QuenMatKhauForm : Form
    {
        public QuenMatKhauForm()
        {
            InitializeComponent();
            lbKetQua.Text = "";
        }
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string dangNhap = tbTaiKhoan.Text;
            string matKhau = lbKetQua.Text;
            int kq = kiemTraDangNhap(dangNhap, matKhau);
            if (dangNhap.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
            }
            else
            {
                if(kq == 0)
                {
                    lbKetQua.ForeColor = Color.Blue;
                    lbKetQua.Text = "Mật Khẩu: " + dangNhap;
                }
                else if(kq == 1)
                {
                    MessageBox.Show("User");
                }
                else
                {
                    lbKetQua.ForeColor = Color.Red;
                    lbKetQua.Text = "Tài khoản này chưa đăng ký";
                }
            }
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
                    new SqlParameter { ParameterName = "@TenDangNhap", Value = dangNhap },
                    new SqlParameter { ParameterName = "@MatKhau", Value = matKhau });
                if (dt != null && dt.Rows.Count == 0)
                    return -1;
                DataRow row = dt.Rows[0];
                return (int)row["Loai"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Form1: " + ex.ToString());
            }
            return -1;
        }
    }
}
