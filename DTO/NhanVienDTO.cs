using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string _maNV;
        private string _tenNV;
        private string _ngaySinh;     
        private string _email;
        private string _dienThoai;
        private string _diaChi;
        private string _maPhong;

        public NhanVienDTO()
        {

        }

        public NhanVienDTO(string maNV, string tenNV, string ngaySinh, string email, string dienThoai, string diaChi, string maPhong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;           
            Email = email;
            DienThoai = dienThoai;
            DiaChi = diaChi;
            MaPhong = maPhong;
        }


        public string MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string Email { get => _email; set => _email = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }     
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
