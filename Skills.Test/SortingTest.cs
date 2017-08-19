using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Skills;

namespace Skills.Test
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void TestQuickSort()
        {
            IList<int> testList = null;
            testList = sortList(ESortType.QuickSort, 10, 10);
            Assert.IsTrue(isSorted(testList));

            testList = sortList(ESortType.QuickSort, 100, 100);
            Assert.IsTrue(isSorted(testList));

            testList = sortList(ESortType.QuickSort, 1000, 1000);
            Assert.IsTrue(isSorted(testList));
        }

        [TestMethod]
        public void TestTreeSort()
        {
            IList<int> testList = null;
            testList = sortList(ESortType.TreeSort, 10, 10);
            Assert.IsTrue(isSorted(testList));

            testList = sortList(ESortType.TreeSort, 100, 100);
            Assert.IsTrue(isSorted(testList));

            testList = sortList(ESortType.TreeSort, 1000, 1000);
            Assert.IsTrue(isSorted(testList));
        }

        private IList<int> sortList(ESortType sortType, int listSize, int maxValue)
        {
            var generatedList = Helper.generateRandomArray(listSize, maxValue);
            IList<int> sortedList = null;
            switch (sortType)
            {
                case ESortType.QuickSort:
                    sortedList = Sorting.quickSort(generatedList);
                    break;
                case ESortType.TreeSort:
                    sortedList = Sorting.treeSort(generatedList);
                    break;
            }

            return sortedList;
        }

        private bool isSorted(IList<int> list)
        {
            if (list != null)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i] < list[i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
