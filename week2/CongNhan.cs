using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class CongNhan:CanBo
    {
        private string bac;
        public CongNhan(string hoten, int namsinh, string gioitinh,string diachi,string bac) : base(hoten, namsinh, gioitinh, diachi)
        {
            this.bac = bac;
        }
        public string Bac
        {
            get=>bac; 
            set => bac = value;
        }
    }
}
