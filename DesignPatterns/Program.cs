using DesignPatterns.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton S1 = Singleton.Instance;
            Singleton S2 = Singleton.Instance;

            if(S1 == S2)
            {
                Console.WriteLine("Same Instance");
            }

            Console.ReadKey();
        }
    }
}
