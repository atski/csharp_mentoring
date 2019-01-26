using System;
using System.IO;

namespace MergeSortApp
{
    class ManageData
    {
        public  Array GenerateNumbers(int numbersQuantity)
        {
            Random randGen = new Random();
            int[] numbersArray = new int[numbersQuantity];
            for (int i = 0; i < numbersQuantity; i++)
            {
                numbersArray[i] = randGen.Next(numbersQuantity);
            }
            return numbersArray;
        }

        public void CreateFile(string path, Array numbersArray)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (int i in numbersArray)
                {
                    sw.WriteLine("{0}", i);
                }
            }
        }

        public int[] ReadFileToArray(string pathToFile)
        {
            int[] arrayFromFile;
            using (StreamReader sr = new StreamReader(pathToFile))
            {
                int countLines = 0;
                while (sr.ReadLine() != null)
                {
                    countLines++;
                };

                arrayFromFile = new int[countLines];

                string line;
                int i = 0;
                sr.BaseStream.Position = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    arrayFromFile[i] = Convert.ToInt32(line);
                    i++;
                }
            };
            return arrayFromFile;
        }
    }
}
