using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_Bai6
{
class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS;
        private SinhVien[] DSSV;
    
    public void Nhap() 
    {
        Console.WriteLine("hãy nhập số sinh viên trong danh sách:");
        n = Convert.ToInt32(Console.ReadLine());

        DS = new SinhVien[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("hãy nhập thông tin cho sinh vien thứ", +i);
            DS[i] = new SinhVien();
            DS[i].Nhap();

        }
    }
        public void Xuat()
        {
            if (DS != null && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Danh sach sinh vien: ", DS[i]);
                }
            }
        }

    public void SapXep()
        {
            for (int i=0;i<n-1;i++)
                for (int j = i; j < n; j++)
                {
                    if (string.Compare(DS[i].Masv, DS[j].Masv, true) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
        }
    public void ds()
        {
            SinhVien sv = new SinhVien();
            for (int i = 0; i <= DS.Length; i++)
            {
                if (DS[i].DiemTB > 8)
                    { DSSV[i] = DS[i];
                    Console.WriteLine("Danh sach: ", DSSV[i]);
                }
            }
        }

    }
}
