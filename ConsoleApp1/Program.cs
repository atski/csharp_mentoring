using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCreate.cs;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNumber = 0;

            Console.WriteLine("Enter desired path to generated files:");
            string filesPath = Console.ReadLine();
            Console.WriteLine("enter nuber of records (<1bill)");
            if (!Int32.TryParse(Console.ReadLine(), out elementsNumber)) {
                Console.WriteLine("not integer");
            }
        

        }
    }
}
