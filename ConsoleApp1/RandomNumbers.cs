using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RandomNumbers
    {
        public Array GenerateNumbers(int numbersQuantity)
        {
            Random randGen = new Random();
            int[] numbersArray = new int[numbersQuantity];
            for (int i = 0; i < numbersQuantity; i++)
            {
                numbersArray[i] = randGen.Next(numbersQuantity);
            }
            return numbersArray;
        }
    }
}
