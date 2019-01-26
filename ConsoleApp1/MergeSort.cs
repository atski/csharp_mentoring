using System;


namespace MergeSortApp
{
    class MergeSort
    {
        private Tuple<int[], int[]> SplitArray(int[] arrayToSplit)
        {
            int left, right;
            int[] leftArray, rightArray;
            if (arrayToSplit.Length > 2)
            {

                if (arrayToSplit.Length % 2 == 0)
                {
                    left = arrayToSplit.Length/2;
                    right = left;
                }
                else
                {
                    left = arrayToSplit.Length / 2;
                    right = left + 1;
                }
                
                leftArray = new int[left];
                rightArray = new int[right];

                for (int i = 0; i < left; i++)
                {
                    leftArray[i] = arrayToSplit[i];
                }

                for (int j = right-1; j < arrayToSplit.Length; j++)
                {
                    rightArray[j - right-1] = arrayToSplit[j];
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

        private int[] MergeArrays(int[] lArray, int[] rArray)
        {
            int resultArrayLength = lArray.Length + rArray.Length;
            int[] resultArray = new int[resultArrayLength];
            int k = 0;
            int i = 0;
            int j = 0;

            do
            {
                if (i < lArray.Length && j<rArray.Length)
                {
                    if (lArray[i] <= rArray[j])
                    {
                        resultArray[k] = lArray[i];
                        i++;
                        k++;
                    }
                    else 
                    {
                        resultArray[k] = rArray[j];
                        j++;
                        k++;
                    }
                }
                else if (i >= lArray.Length && j < rArray.Length)
                {
                    resultArray[k] = rArray[j];
                    j++;
                    k++;
                }
                else if (i < lArray.Length && j >= rArray.Length)
                {
                    resultArray[k] = lArray[i];
                    i++;
                    k++;
                }
                else break;
            } while (k < resultArrayLength);
            return resultArray;
        }

        public int[] MergeSortArray(int[] arrayToSort)
        {
            if (arrayToSort.Length >= 2)
            {
                Tuple<int[],int[]> tupleArrays = SplitArray(arrayToSort);

                int[] resultArray = MergeArrays(MergeSortArray(tupleArrays.Item1), MergeSortArray(tupleArrays.Item2));
                return resultArray;
            }
            else
            {
                return arrayToSort; 
            }
        }

    }
}
