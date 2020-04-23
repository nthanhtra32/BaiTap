using System;

namespace Chuong3_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien htttak21 = new DanhSachSinhVien();
            SinhVien sv = new SinhVien();
            htttak21.Nhap();
            sv.ChamDiem();
            htttak21.Xuat();
            htttak21.SapXep();
            htttak21.Xuat();
            Console.ReadLine();
        }
    }
}
