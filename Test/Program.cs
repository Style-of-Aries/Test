﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{
    enum gioiTinh
    {
        Nam,
        Nu
    }
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
    internal class Program
    {
        static List<Sach> list_s = new List<Sach>();
        static void nhapSach()
        {
            Console.Write("Nhap so luong sach: ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0;i<n;i++)
            {
                Sach s = new Sach();
                Console.WriteLine($"Nhap thong tin cua sach {i}");
                s.input();
                list_s.Add(s);
            }
        }
        static void xuatSach()
        {
            Console.WriteLine("Danh sach thong tin cua sach:");
            foreach (Sach sach in list_s)
            {
                sach.output();
            }
        }
        static void themSach()
        {
            Console.WriteLine("Nhap thong tin sach moi:");
            Sach sach = new Sach();
            sach.input();
            list_s.Add(sach);
        }
        static void timKiemSach()
        {
            int dem = 0;
            Console.Write("Nhap ma sach can tim: ");
            string tk = Console.ReadLine();
            foreach(Sach sach in list_s)
            {
                if (sach.getMaSach().SequenceEqual(tk))
                {
                    Console.WriteLine("Da tim thay:");
                    sach.output();
                    dem++;
                }
            }
            if(dem==0) Console.WriteLine("Ma sach khong hop le!");
        }
        static void suaSach()
        {
            int dem = 0;
            Console.Write("Nhap ma sach can tim: ");
            string sua = Console.ReadLine();
            foreach (Sach sach in list_s)
            {
                if (sach.getMaSach().SequenceEqual(sua))
                {
                    Console.WriteLine("Nhap lai thong tin cua sach:");
                    sach.input();
                    dem++;
                }
            }
            if (dem == 0) Console.WriteLine("Ma sach khong hop le!");
        }
        static void xoaSach()
        {
            int dem = 0;
            Console.Write("Nhap ma sach can xoa: ");
            string xoa = Console.ReadLine();
            for(int i=0;i<list_s.Count;i++)
            {
                if (list_s.g.getMaSach().SequenceEqual(xoa))
                {
                    
                    list_s.Remove(sach);
                    dem++;
                    Console.WriteLine("Da xoa!");
                }
            }
            if (dem == 0) Console.WriteLine("Ma sach khong hop le!");
        }
        static void Main(string[] args)
        {
            nhapSach();
            xuatSach();
            xoaSach();
            xuatSach();
            Console.ReadKey();

        }
    }
}