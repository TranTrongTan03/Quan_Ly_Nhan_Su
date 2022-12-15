using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienQuanLyDTO
    {
        private string _maQL;
        private string _tenQL;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _dienThoai;
        private string _email;
        private string _diaChi;

        public NhanVienQuanLyDTO()
        {
        }

        public NhanVienQuanLyDTO(string maQL, string tenQL, string ngaySinh, string gioiTinh, string dienThoai, string email, string diaChi)
        {
            MaQL = maQL;
            TenQL = tenQL;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DienThoai = dienThoai;
            Email = email;
            DiaChi = diaChi;
        }

        public string MaQL { get => _maQL; set => _maQL = value; }
        public string TenQL { get => _tenQL; set => _tenQL = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string Email { get => _email; set => _email = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
       
    }
}
