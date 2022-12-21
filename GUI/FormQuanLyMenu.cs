using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLyMenu : Form
    {
        public FormQuanLyMenu()
        {
            InitializeComponent();
        }
        private int _loai;
        public int Loai { get => _loai; set => _loai = value; }

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

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            this.Hide();
            CongViecForm congViecForm = new CongViecForm();
            congViecForm.ShowDialog();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVienForm quanLyNhanVienForm = new QuanLyNhanVienForm();
            quanLyNhanVienForm.ShowDialog();
            this.Close();
        }
    }
}

