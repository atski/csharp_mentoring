using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNumber = 0;

            Console.WriteLine("Enter desired path to generated file:");
            string filePath = Console.ReadLine();

            Console.WriteLine("enter nuber of records (<1bill)");
            if (!Int32.TryParse(Console.ReadLine(), out elementsNumber)) {
                Console.WriteLine("not integer");
            }

            Console.WriteLine("Enter desired path to output file:");
            string outputFilesPath = Console.ReadLine();

            DataCreate fileWithRandomNumbers = new DataCreate();
            Array randomGeneratedArray = fileWithRandomNumbers.GenerateNumbers(elementsNumber);
            fileWithRandomNumbers.CreateFile(filePath, randomGeneratedArray);
        }
    }
}
