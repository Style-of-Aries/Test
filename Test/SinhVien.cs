using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SInhVien
    {
        public String maSV { get; set; }
        public String hoTen { get; set; }
        public void input()
        {
            Console.Write("Ma Sinh Vien: ");
            maSV = Console.ReadLine();
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();
        }
        public void output()
        {
            Console.WriteLine("Ma Sinh Vien: {0} \t Ho va ten: {1}", maSV, hoTen);
        }
    }
}
