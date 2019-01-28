using System;
using System.IO;

namespace MergeSortApp
{
    class FileManager
    {
        public void CreateFile(string path, int[] numbersArray)
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
