using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_arrays_task1;

namespace HW_arrays_task1_test
{
    [TestClass]
    public class ArrayReverserTest
    {
        [TestMethod]
        public void reverse_WithEmptyArray()
        {
            int[] inputArray = new int[0];
            int[] actualArray = ArrayReverser.reverse(inputArray);
            int[] expectedArray = new int[0];

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void reverse_WithOneElementArray()
        {
            int[] inputArray = new int[1] { 3 };
            int[] actualArray = ArrayReverser.reverse(inputArray);
            int[] expectedArray = new int[1] { 3 };

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void reverse_WithEvenNumberElementArray()
        {
            int[] inputArray = new int[6] { 3, 5, 34, 89, 123, 90 };
            int[] actualArray = ArrayReverser.reverse(inputArray);
            int[] expectedArray = new int[6] { 90, 123, 89, 34, 5, 3 };

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void reverse_WithOddNumberElementArray()
        {
            int[] inputArray = new int[7] { 3, 5, 34, 89, 123, 90, 67 };
            int[] actualArray = ArrayReverser.reverse(inputArray);
            int[] expectedArray = new int[7] { 67, 90, 123, 89, 34, 5, 3 };

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void reverse_WithBigArray()
        {
            int[] inputArray = new int[10000];
            int[] expectedArray = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                inputArray[i] = i;
                expectedArray[i] = 10000 - 1 - i;
            }       
     
            int[] actualArray = ArrayReverser.reverse(inputArray);
            
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestMethod]
        public void reverseInPlace_WithEmptyArray()
        {
            int[] inputArray = new int[0];
            ArrayReverser.reverseInPlace(inputArray);
            int[] expectedArray = new int[0];

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }

        [TestMethod]
        public void reverseInPlace_WithOneElementArray()
        {
            int[] inputArray = new int[1] { 3 };
            ArrayReverser.reverseInPlace(inputArray);
            int[] expectedArray = new int[1] { 3 };

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }

        [TestMethod]
        public void reverseInPlace_WithEvenNumberElementArray()
        {
            int[] inputArray = new int[6] { 3, 5, 34, 89, 123, 90 };
            ArrayReverser.reverseInPlace(inputArray);
            int[] expectedArray = new int[6] { 90, 123, 89, 34, 5, 3 };

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }

        [TestMethod]
        public void reverseInPlace_WithOddNumberElementArray()
        {
            int[] inputArray = new int[7] { 3, 5, 34, 89, 123, 90, 67 };
            ArrayReverser.reverseInPlace(inputArray);
            int[] expectedArray = new int[7] { 67, 90, 123, 89, 34, 5, 3 };

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }

        [TestMethod]
        public void reverseInPlace_WithBigArray()
        {
            int[] inputArray = new int[10000];
            int[] expectedArray = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                inputArray[i] = i;
                expectedArray[i] = 10000 - 1 - i;
            }

            ArrayReverser.reverseInPlace(inputArray);

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }
    }
}
