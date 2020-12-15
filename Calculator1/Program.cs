using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String na, nb;
            double c, d, e, f, n_a, n_b;

            Console.Write("\n Masukkan Nilai a  : ");
            na = Console.ReadLine();
            Console.Write("\n Masukkan Nilai b  : ");
            nb = Console.ReadLine();

            n_a = Convert.ToDouble(na);
            n_b = Convert.ToDouble(nb);

            c = n_a + n_b;
            d = n_a - n_b;
            e = n_a * n_b;
            f = n_a / n_b;

            Console.WriteLine("\n c = Pertambahan a + b adalah {0}", c);
            Console.WriteLine("\n d = Pengurangan a - b adalah {0}", d);
            Console.WriteLine("\n e = Perkalian   a * b adalah {0}", e);
            Console.WriteLine("\n f = Pembagian   a / b adalah {0}", f);
            Console.WriteLine("\n Hasil total jumlah keseluruhan = {0}", c + d + e + f);

    
            Console.ReadLine();
        }
    }

}