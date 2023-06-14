using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace WinFormsQLSV.API
{
    public class SinhVien
    {
        private string? _ID;
        private string? _TEN;
        private string? _GIOITINH;
        private int? _TUOI;
        private double? _DIEMTOAN;
        private double? _DIEMVAN;
        private double? _DIEMANH;
        private double? _DIEMTRUNGBINH;
        private string? _HOCLUC;

        public string? ID { get => _ID; set => _ID = value; }
        public string? TEN { get => _TEN; set => _TEN = value; }
        public string? GIOITINH { get => _GIOITINH; set => _GIOITINH = value; }
        public int? TUOI { get => _TUOI; set => _TUOI = value; }
        public double? DIEMTOAN { get => _DIEMTOAN; set => _DIEMTOAN = value; }
        public double? DIEMVAN { get => _DIEMVAN; set => _DIEMVAN = value; }
        public double? DIEMANH { get => _DIEMANH; set => _DIEMANH = value; }
        public double? DIEMTRUNGBINH { get => _DIEMTRUNGBINH; set => _DIEMTRUNGBINH = value; }
        public string? HOCLUC { get => _HOCLUC; set => _HOCLUC = value; }
    }
}