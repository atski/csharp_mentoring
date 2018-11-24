using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MergeSort
    {
        public int[] MergeSortArray(int[] arrayToSort)
        {
            int[] leftArray, rightArray, leftSorted, rightSorted;
            if (arrayToSort.Length >= 2)
            {
                //split given array into 2 arrays
                int leftElementsNumber, rightElementsNumber;

                leftElementsNumber = arrayToSort.Length / 2;
                rightElementsNumber = leftElementsNumber + 1;

                leftArray = new int[leftElementsNumber];
                rightArray = new int[rightElementsNumber];

                for (int i = 0; i < leftElementsNumber; i++)
                {
                    leftArray[i] = arrayToSort[i];
                }

                for (int j = rightElementsNumber; j < arrayToSort.Length; j++)
                {
                    rightArray[j-leftElementsNumber] = arrayToSort[j];
                }

                //reccursion till array of length 1
                leftSorted = MergeSortArray(leftArray);
                rightSorted = MergeSortArray(rightArray);

                for (int )


                return resultArray;
            }
            else
            {
                return arrayToSort;
            }
        }

    }
}
