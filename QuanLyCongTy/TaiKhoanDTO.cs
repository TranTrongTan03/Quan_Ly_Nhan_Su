using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    public class TaiKhoanDTO
    {
        private string _tenDangNhap;
        private string _matKhau;
        private int _loai;

        public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public int Loai { get => _loai; set => _loai = value; }
    }
}
