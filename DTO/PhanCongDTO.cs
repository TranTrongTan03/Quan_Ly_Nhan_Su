using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanCongDTO
    {
        private string _maQL;
        private string _maCV;
        private string _maPhong;

        public string MaQL { get => _maQL; set => _maQL = value; }
        public string MaCV { get => _maCV; set => _maCV = value; }
        public string MaPhong { get => _maPhong; set => _maPhong = value; }
    }
}
