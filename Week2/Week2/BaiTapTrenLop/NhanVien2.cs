using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BaiTapTrenLop
{
    internal class NhanVien2 : CanBo
    {
        private string congviec;
        public NhanVien2(string hoten, int namsinh, string gioitinh, string diachi, string congviec) : base(hoten, namsinh, gioitinh, diachi)
        {
            this.congviec = congviec;
        }
        public string Congviec
        {
            get => congviec;
            set
            {
                congviec = value;
            }
        }
    }
}
