using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class sinhvien
    {
        public string masv;
        private string ten;
        private int namsinh;
        private double diemLT,diemcsdl,diemTB;

     


        //ham tao ko tham so
        public sinhvien()
        {
            masv = "";
            ten = "";
            namsinh = 1900;
            diemLT = diemcsdl = diemTB = 0;

        }
        //ham tao co 5 tham so

        public sinhvien(string masv,string ten,int namsinh,double diemLT,double diemcsdl)
        {
            this.masv = masv;
            this.ten = ten;
            this.namsinh = namsinh;
            this.diemLT = diemLT;
            this.diemcsdl = diemcsdl;
            this.diemTB = (diemLT + diemcsdl) / 2;


        }

       

        public void Nhap()
        {
            Console.WriteLine("hay nhap ma sinh vien");
            masv = Console.ReadLine();
            Console.WriteLine("hay nhap ho ten sinh vien");
            ten = Console.ReadLine();
            Console.WriteLine("hay nhap nam sinh nhan vien");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap vao diem lt cua sinh vien");
            diemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hay nhap diem csdl cua sinh vien");
            diemcsdl = Convert.ToDouble(Console.ReadLine());
        }
    

        public void xuat()
        {
            Console.WriteLine("thong tin sinh vien :\n masv{0} :  \t tên : {1} \t Năm sinh :{2}" +
                "\n diemlt : {3} \t diem csdl : {4}",masv, ten, namsinh, diemLT, diemcsdl);
        }
        

    }
}
