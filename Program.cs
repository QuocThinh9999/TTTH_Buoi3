using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTTH_Buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoNguyen();
            Console.ReadKey();
        }
        public static int SoNguyen()
        {
            Console.Write("Hay nhap vao so nguyen n: ");
            int n =int.Parse(Console.ReadLine());
            //
            return n;   
        }
    }
}
