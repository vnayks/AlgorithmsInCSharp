using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algorithms.Test
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Sort_BasicTest_ShouldReturnSortedArray()
        {
            //Arrange
            var nums=new int[]{5,1,4,3};

            //Act
            var result = InsertionSort.Sort(nums);
            var isSorted = Utils.IsSorted(result);
            Console.WriteLine(result.PrintArrayElements());
            //Assert
            Assert.IsTrue(isSorted);
        }
    }
}
