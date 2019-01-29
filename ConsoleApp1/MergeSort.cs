using System;


namespace MergeSortApp
{
    public class MergeSort
    {
        private Tuple<int[], int[]> Split(int[] arrayToSplit)
        {
            int left, right;
            int[] leftArray, rightArray;
            if (arrayToSplit.Length > 2)
            {

                left = arrayToSplit.Length/2;
                right = arrayToSplit.Length - left;                
                leftArray = new int[left];
                rightArray = new int[right];
                
                for (int k = 0; k < arrayToSplit.Length; k++)
                {
                    if (k < left) leftArray[k] = arrayToSplit[k];
                    else rightArray[k - left] = arrayToSplit[k];
                }

                return new Tuple<int[], int[]>(leftArray, rightArray);

            }
            else if (arrayToSplit.Length == 2)
            {
                leftArray = new int[1] {arrayToSplit[0]};
                rightArray = new int[1] {arrayToSplit[1]};
                return new Tuple<int[], int[]>(leftArray, rightArray);
            }
            else return null;
        }

        private int[] MergeSorted(int[] lArray, int[] rArray)
        {
            int resultArrayLength = lArray.Length + rArray.Length;
            int[] resultArray = new int[resultArrayLength];
            int k = 0;
            int i = 0;
            int j = 0;

            while (k < resultArrayLength) 
            {
                if (i < lArray.Length && j<rArray.Length)
                {
                    if (lArray[i] <= rArray[j])
                    {
                        resultArray[k] = lArray[i];
                        i++;
                    }
                    else 
                    {
                        resultArray[k] = rArray[j];
                        j++;
                    }
                }
                else if (i >= lArray.Length && j < rArray.Length)
                {
                    resultArray[k] = rArray[j];
                    j++;
                }
                else if (i < lArray.Length && j >= rArray.Length)
                {
                    resultArray[k] = lArray[i];
                    i++;
                }
                k++;
            } 
            return resultArray;
        }

        public int[] Sort(int[] arrayToSort)
        {
            if (arrayToSort.Length >= 2)
            {
                Tuple<int[],int[]> tupleArrays = Split(arrayToSort);

                int[] resultArray = MergeSorted(Sort(tupleArrays.Item1), Sort(tupleArrays.Item2));
                return resultArray;
            }
            else
            {
                return arrayToSort; 
            }
        }

    }
}
