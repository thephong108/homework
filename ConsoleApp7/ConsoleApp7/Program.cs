using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            danhsachSV htttak21 = new danhsachSV();
            htttak21.Nhap();
            htttak21.xuat();
            htttak21.sapxep();
            htttak21.xuat();
            Console.ReadLine();
        }
    }
}
