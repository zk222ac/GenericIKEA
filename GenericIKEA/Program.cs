using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIKEA
{
    class Program
    {
        static void Main(string[] args)
        {
            var fnood = new Fnood();
            fnood.GetInventory();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
