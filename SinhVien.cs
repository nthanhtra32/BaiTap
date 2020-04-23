using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_Bai6
{
    class SinhVien
    {

        //Mã sinh viên, Họ tên, Năm sinh, Điểm lập trình, Điểm CSDL, Điểm TB(trong đó: Điểm TB = Điểm Lập trình +Điểm CSDL)/2
        private string masv;
        private string hoTen;
        private int namSinh;
        private double diemLT;
        private double diemCSDL;
        private double diemTB;

        public string Masv
        {
            get
            {
                return this.masv;
            }
            set
            {
                this.masv = value;
            }
        }

        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemLT { get => diemLT; set => diemLT = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DiemCSDL { get => diemCSDL; set => diemCSDL = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        //public string Masv { get => this.masv; set => this.masv = value; }

        //Hàm tạo không tham số
        public SinhVien()
        {
            Masv = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }


        //Hàm tạo có 5 tham số(Họ tên, năm sinh, quê quán, Điểm lập trình, Điểm CSDL)
        public SinhVien(string masv, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.masv = masv;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            //this.DiemTB = (DiemLT + DiemCSDL) / 2;

        }



        //Nhập thông tin sinh viên
        public void Nhap()
        {
            //Console.WriteLine(" Ban dang goi ham nhap tt");
            Console.WriteLine("hãy nhập mã sinh viên");
            masv = Console.ReadLine();
            Console.WriteLine(" hãy nhập tên sinh viên");
            HoTen = Console.ReadLine();
            Console.WriteLine(" hãy nhập năm sinh");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hãy nhập điểm lập trình");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hãy nhập điểm cơ sở dữ liệu");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());


        }
        public double ChamDiem()
        {
            DiemTB = (DiemLT + DiemCSDL) / 2;
            return DiemTB;
        }

        //In thông tin sinh viên ra màn hình

        public void Xuat()
        {
            Console.WriteLine(" hãy in ra thông tin sinh viên:\n masv:(0),\n HoTen: (1)," +
                "\n NamSinh: (2), \n diem lap trinh:(3),\t điểm CSDL:(4),\t điểm trung bình: (5)",
                masv, HoTen, NamSinh, DiemLT, DiemCSDL, DiemTB);
        }

    }
}
