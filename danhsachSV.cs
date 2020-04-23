using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class danhsachSV
    {
        private int n;
        private sinhvien[] DS;
        public void Nhap()
        {
            Console.WriteLine("hay nhap so sinh vien trong danh sach:");
            n = Convert.ToInt32(Console.ReadLine());

            DS = new sinhvien[10];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("hay nhap thong tin sinh vien thu :" + i);
                DS[i] = new sinhvien();
                DS[i].Nhap();

            }

            
        }
        public void xuat()
        {
            if (DS!=null && n > 0)
            {
                for(int i = 0; i < n; i++)
                {
                    DS[i].xuat();
                }
            }
        }
        public void sapxep()
        {
            for(int i = 0; i < n; i++)
            
                for(int j = i + 1; j < n; j++)
                {
                    if (string.Compare(DS[i].masv,DS[j].masv,true)>0){
                        sinhvien tg = new sinhvien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg; 

                    }

                }
            
        }
    }
}
