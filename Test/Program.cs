using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{

    internal class Program
    {
        static List<Sach> list_s = new List<Sach>();
        static List<SInhVien> list_sv = new List<SInhVien>();
        static void nhapSach()
        {
            Console.Write("Nhap so luong sach: ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0;i<n;i++)
            {
                Sach s = new Sach();
                Console.WriteLine($"Nhap thong tin cua sach {i+1}");
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
                if (list_s[i].getMaSach().Equals(xoa)) 
                {
                    
                    list_s.RemoveAt(i);
                    dem++;
                    Console.WriteLine("Da xoa!");
                }
            }
            if (dem == 0) Console.WriteLine("Ma sach khong hop le!");
        }
        static void nhapSV()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i+1}");
                SInhVien sv = new SInhVien();
                sv.input();
                list_sv.Add(sv);
            }
        }
        static void xuatSV()
        {
            foreach(SInhVien sv in list_sv)
            {
                Console.WriteLine("Danh sach Sinh Vien: ");
                sv.output();
            }
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
