using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapTop_1.Models
{
    public class TaiKhoan
    {
        string tendangnhap;
        string matkhau;

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }

        public TaiKhoan()
        {
        }

        public TaiKhoan(string tendangnhap, string matkhau)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }
    }
}
