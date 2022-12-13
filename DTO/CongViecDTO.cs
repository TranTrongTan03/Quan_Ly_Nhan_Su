using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongViecDTO
    {
        private string _maCV;
        private string _tenCV;

        public string MaCV { get => _maCV; set => _maCV = value; }
        public string TenCV { get => _tenCV; set => _tenCV = value; }
    }
}
