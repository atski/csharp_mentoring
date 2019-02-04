using System;
using System.Collections;
using System.IO;

namespace MergeSortApp
{
    public class FileManager
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
            ArrayList lstFromFile = new ArrayList();
            int[] randNumbers;
            using (StreamReader sr = new StreamReader(pathToFile))
            {
                int countLines = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    countLines++;
                    lstFromFile.Add(Convert.ToInt32(line));
                }
            }

            randNumbers =  (int[]) lstFromFile.ToArray();
            {

            }
            return randNumbers;
        }
    }
}
