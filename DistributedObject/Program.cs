using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CSinhVien sv = new CSinhVien();
            sv.MSSV = 1712181;
            sv.HoTen = "Le Van";
            sv["GPA"] = "8.5";

            Console.WriteLine(sv["StudentID"]);
            Console.WriteLine(sv.Ho);
            Console.WriteLine(sv.DTB.ToString());
            Console.ReadLine();
        }
    }
}
