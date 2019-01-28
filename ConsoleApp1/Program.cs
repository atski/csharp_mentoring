using System;
using System.IO;
using ConsoleApp1;


namespace MergeSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersQuantity;

            Console.WriteLine("Enter desired path to generated file:");
            string inputFile = Console.ReadLine();

            Console.WriteLine("enter nuber of records (<1bill)");
            if (!Int32.TryParse(Console.ReadLine(), out numbersQuantity)) {
                Console.WriteLine("not integer");
            }

            Console.WriteLine("Enter desired path to output file:");
            string outFile = Console.ReadLine();
            
            // creating file with randomly generated numbers written each in new row
            FileManage fileManager = new FileManage();
            RandomNumbers randData = new RandomNumbers();
            int[] generatedNumbers = randData.GenerateNumbers(numbersQuantity);
            fileManager.CreateFile(inputFile, generatedNumbers);

            int[] arrayWithRandomNumbers = fileManager.ReadFileToArray(inputFile);
            MergeSort sort = new MergeSort();
            fileManager.CreateFile(outFile, sort.Sort(arrayWithRandomNumbers));
        }
    }
}
