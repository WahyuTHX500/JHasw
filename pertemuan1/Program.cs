using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a = 10; //declarasi variabel  a, dg nilai awal 10;
            int b = 6; //declarasii variabel b dg nilai awal 6;

            Console.WriteLine("Hasil penambahan " + a + "+" + b + "=" + penambahan(a, b));
            Console.WriteLine()
        }
    }
}
