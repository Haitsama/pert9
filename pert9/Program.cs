using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymerphism;

namespace pert9
{
     class Program
    {
        static void Main(string[] args)
        {
            Printer printer;
            Console.WriteLine("Pilih printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.WriteLine("Nomor printer [1...3] :");

            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
                printer = new Epson();
            else if (nomorprinter == 2)
                printer = new Canon();
            else if (nomorprinter == 3)
                printer = new LasetJet();
            else
            {
                Console.WriteLine("Nomor printer tidak tersedia");
                return;
            }

            printer.show();
            printer.print();

            Console.ReadKey();
        }
    }
}