using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSortApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortApp.Tests
{
    [TestClass()]
    public class MergeSortTests
    {
        [TestMethod()]
        public void ZeroesSortTest()
        {
            //defining data
            int[] standard = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int[] toSort = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            MergeSort sort = new MergeSort();
            int[] sorted = sort.Sort(toSort);
            //asserting
            for (int i = 0; i < standard.Length; i++)
            {
                Assert.AreEqual(standard[i], sorted[i]);
            }
            
        }

        [TestMethod()]
        public void SortedSortTest()
        {
            //defining data
            int[] standard = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] toSort = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            MergeSort sort = new MergeSort();
            int[] sorted = sort.Sort(toSort);
            //asserting
            for (int i = 0; i < standard.Length; i++)
            {
                Assert.AreEqual(standard[i], sorted[i]);
            }
        }

        [TestMethod()]
        public void NotSortedSortTest()
        {
            //defining data
            int[] standard = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] toSort = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            MergeSort sort = new MergeSort();
            int[] sorted = sort.Sort(toSort);
            //asserting
            for (int i = 0; i < standard.Length; i++)
            {
                Assert.AreEqual(standard[i], sorted[i]);
            }
        }
    }
}