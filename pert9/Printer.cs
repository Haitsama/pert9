using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymerphism
{
    public class Printer
    {
        public string NamaPrinter { get; set; }
        public virtual void show()
        {
            Console.WriteLine("\ndisplay dimensian");
        }
        public virtual void print()
        {
            Console.WriteLine("\ndisplay dimensian");
        }
    }
    public class Epson : Printer
    {
        public override void show()
        { 
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
    public class Canon : Printer
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
    public class LasetJet : Printer
    {
        public override void show()
        {
            Console.WriteLine("LasetJet display dimension : 11*12");
        }
        public override void print()
        {
            Console.WriteLine("LasetJet printer printing....");
        }
    }
}
