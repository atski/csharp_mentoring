using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class RandomNumbersFileCreate
    {
        private Array GenerateNumbers(int numbersQuantity)
        {
            Random randGen = new Random();
            int[] numbersArray = new int[numbersQuantity];
            for (int i = 0; i < numbersQuantity; i++)
            {
                numbersArray[i] = randGen.Next(numbersQuantity);
            }
            return numbersArray;
        }

        public void CreateFile(string path, int numbers)
        {
            var randomNumbers = GenerateNumbers(numbers);

            if (File.Exists(path)){
                File.Delete(path);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach(int i in randomNumbers)
                    {
                        sw.WriteLine("{0}", i);
                    }
                }
            }

        }

       
    }
}
