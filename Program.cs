using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info;
            Console.Write("Ad - Kulup: ");
            info = Console.ReadLine();


            Ogrenci ogr = new Ogrenci(info);

            Console.Read();
        }
    }
}
