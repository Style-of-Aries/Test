using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Sach
    {
        #region Thuoc tinh
        string maSach, tenSach, tenTacGia;
        int soTrang, gia;
        #endregion
        #region Phuong thuc
        public string getMaSach()
        {
            return maSach;
        }
        public void input()
        {
            Console.Write("Ma sach: ");
            maSach = Console.ReadLine();
            Console.Write("Ten sach: ");
            tenSach = Console.ReadLine();
            Console.Write("Ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.Write("So trang: ");
            soTrang = Int32.Parse(Console.ReadLine());
            Console.Write("Gia: ");
            gia = Int32.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Ma sach: {0}; Ten sach: {1}; Ten tac gia: {2}; So trang: {3}; Gia sach(VND): {4}", maSach, tenSach, tenTacGia, soTrang, gia);
        }
        #endregion
    }
}
