using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter Contatore = new Counter(100);

            while (!Contatore.isError())
            {
                Contatore.inc();
                Console.Write(Contatore.getValue());
                Console.Write("---");
                Console.WriteLine("" + Contatore.isError());
            }
        }
    }
}
