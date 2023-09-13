using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class KySu:CanBo
    {
        private string nganhdaotao;
        public KySu(string hoten, int namsinh, string gioitinh, string diachi, string nganhdaotao) : base(hoten, namsinh, gioitinh, diachi)
        {
            this.nganhdaotao = nganhdaotao;
        }
        
        public string Nganhdaotao
        {
            get => nganhdaotao;
            set
            {
                nganhdaotao = value;
            }
        }
    }
}
