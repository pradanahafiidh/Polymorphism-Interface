using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismInterface
{
    class Epson : IPrinterWindows
    {
        public void print()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public void show()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}
