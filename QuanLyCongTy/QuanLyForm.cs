using GUI;


namespace GUI
{
    public partial class QuanLyForm : Form
    {
        private int _loai;
        public int Loai { get => _loai; set => _loai = value; }
        public QuanLyForm()
        {
            InitializeComponent();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyTaiKhoanForm quanLyTaiKhoanForm = new QuanLyTaiKhoanForm();
            quanLyTaiKhoanForm.ShowDialog();
            this.Close();
        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {
            if(Loai == 1)
            {

                btnQuanLyTaiKhoan.Hide();
                btnPhanCong.Hide(); 
            }
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhanCongForm phanCongForm = new PhanCongForm();
            phanCongForm.ShowDialog();
            this.Close();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyPhongForm quanLyPhongForm = new QuanLyPhongForm();
            quanLyPhongForm.ShowDialog();
            this.Close();
        }
    }
}
