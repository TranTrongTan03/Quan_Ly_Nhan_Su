using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongDTO
    {
        private string _maPhong;
        private int _soNV;
        private string _truongPhong;
        private string _nvQuanLy;

        public string MaPhong { get => _maPhong; set => _maPhong = value; }
        public int SoNV { get => _soNV; set => _soNV = value; }
        public string TruongPhong { get => _truongPhong; set => _truongPhong = value; }
        public string NvQuanLy { get => _nvQuanLy; set => _nvQuanLy = value; }
    }
}
