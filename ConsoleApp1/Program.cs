using System;
using System.IO;



namespace MergeSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsNumber;

            Console.WriteLine("Enter desired path to generated file:");
            string filePath = Console.ReadLine();
            

            Console.WriteLine("enter nuber of records (<1bill)");
            if (!Int32.TryParse(Console.ReadLine(), out elementsNumber)) {
                Console.WriteLine("not integer");
            }

            Console.WriteLine("Enter desired path to output file:");
            string outputFilesPath = Console.ReadLine();
            
            // creating file with randomly generated numbers written each in new row
            ManageData fileWithRandomNumbers = new ManageData();
            Array randomGeneratedArray = fileWithRandomNumbers.GenerateNumbers(elementsNumber);
            fileWithRandomNumbers.CreateFile(filePath, randomGeneratedArray);

            int[] arrayWithRandomNumbers = fileWithRandomNumbers.ReadFileToArray(filePath);
            MergeSort sort = new MergeSort();
            fileWithRandomNumbers.CreateFile(outputFilesPath, sort.MergeSortArray(arrayWithRandomNumbers));
        }
    }
}
