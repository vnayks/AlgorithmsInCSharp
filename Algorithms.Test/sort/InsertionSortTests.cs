using System;
using System.Collections.Generic;
using System.Diagnostics;
using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test {
    [TestClass]
    public class InsertionSortTests {
        [TestMethod]
        public void Sort_BasicTest_ShouldReturnSortedArray () {
            //Arrange
            var nums = new int[] { 5, 1, 4, 3 };

            //Act
            var result = InsertionSort.Sort (nums);
            var isSorted = Utils.IsSorted (result);

            //Assert
            Assert.IsTrue (isSorted);
        }

        [TestMethod]
        public void Sort_LongArray_ShouldReturnSortedArray () {
            //Arrange
            var arraySize = 1000;
            var nums = new int[arraySize];
            Random random = new Random ();
            Stopwatch watch = new Stopwatch ();
            for (var i = 0; i < arraySize; i++) {
                nums[i] = random.Next (1, arraySize);
            }

            //Act
            watch.Start ();
            var result = InsertionSort.Sort (nums);
            watch.Stop ();

            var isSorted = Utils.IsSorted (result);
            Console.WriteLine (result.PrintArrayElements ());
            Console.WriteLine ("Time Taken for Long Array : " + watch.Elapsed);
            //Assert
            Assert.IsTrue (isSorted);
        }

        [TestMethod]
        public void Sort_XLongArray_ShouldReturnSortedArray () {
            //Arrange
            var arraySize = 10000;
            var nums = new int[arraySize];
            Random random = new Random ();
            Stopwatch watch = new Stopwatch ();
            for (var i = 0; i < arraySize; i++) {
                nums[i] = random.Next (1, arraySize);
            }

            //Act
            watch.Start ();
            var result = InsertionSort.Sort (nums);
            watch.Stop ();

            var isSorted = Utils.IsSorted (result);
            Console.WriteLine (result.PrintArrayElements ());
            Console.WriteLine ("Time Taken x-Long Array : " + watch.Elapsed);

            //Assert
            Assert.IsTrue (isSorted);
        }

        [TestMethod]
        public void Sort_XXLongArray_ShouldReturnSortedArray () {
            //Arrange
            var arraySize = 100000;
            var nums = new int[arraySize];
            Random random = new Random ();
            Stopwatch watch = new Stopwatch ();
            for (var i = 0; i < arraySize; i++) {
                nums[i] = random.Next (1, arraySize);
            }

            //Act
            watch.Start ();
            var result = InsertionSort.Sort (nums);
            watch.Stop ();

            var isSorted = Utils.IsSorted (result);
            Console.WriteLine (result.PrintArrayElements ());
            Console.WriteLine ("Time Taken xx-Long Array : " + watch.Elapsed);

            //Assert
            Assert.IsTrue (isSorted);
        }

        [TestMethod]
        public void Sort_NegativeNumber_ShouldReturnSortedArray () {
           //Arrange
            var nums = new int[] { -5, -1, -4, -3 };

            //Act
            var result = InsertionSort.Sort (nums);
            var isSorted = Utils.IsSorted (result);

            //Assert
            Assert.IsTrue (isSorted);
        }

        [TestMethod]
        public void Sort_NegativeLongArray_ShouldReturnSortedArray () {
            //Arrange
            var arraySize = 1000;
            var nums = new int[arraySize];
            Random random = new Random ();
            Stopwatch watch = new Stopwatch ();
            for (var i = 0; i < arraySize; i++) {
                nums[i] = random.Next (arraySize*(-1),0);
            }

            //Act
            watch.Start ();
            var result = InsertionSort.Sort (nums);
            watch.Stop ();

            var isSorted = Utils.IsSorted (result);
            Console.WriteLine (result.PrintArrayElements ());
            Console.WriteLine ("Time Taken for Long Array : " + watch.Elapsed);
            //Assert
            Assert.IsTrue (isSorted);
        }

         [TestMethod]
        public void Sort_EqualIntegers_ShouldReturnSortedArray () {
           //Arrange
            var nums = new int[] { 1,1,1,1,1,1,1,1};

            //Act
            var result = InsertionSort.Sort (nums);
            var isSorted = Utils.IsSorted (result);

            //Assert
            Assert.IsTrue (isSorted);
        }

         [TestMethod]
        public void Sort_EmptyArray_ShouldReturnSortedArray () {
           //Arrange
            var nums = new int[] {};

            //Act
            var result = InsertionSort.Sort (nums);
            var isSorted = Utils.IsSorted (result);

            //Assert
            Assert.IsTrue (isSorted);
        }
    }
}
