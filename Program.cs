using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
           atas:
            IPrinterWindows printer;
            Console.WriteLine("Pilihan Printer :");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");
            Console.Write("Nomor printer [1,2,3] : ");
            int pilihanPrinter = Convert.ToInt32(Console.ReadLine());

            if(pilihanPrinter == 1)
            {
                printer = new Epson();
            }
            else if (pilihanPrinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.show();
            printer.print();

            Console.ReadKey();

            goto atas;
        }
    }
}
