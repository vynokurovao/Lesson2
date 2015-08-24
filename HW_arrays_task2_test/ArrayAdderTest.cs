using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_arrays_task2;

namespace HW_arrays_task2_test
{
    [TestClass]
    public class ArrayAdderTest
    {
        [TestMethod]
        public void AddToArray_AddToEmptyArray()
        {
            int[] inputArray = new int[0];
            int inputValue = 8;
            ArrayAdder.addToArray(ref inputArray, inputValue);
            int[] expectedArray = new int[] { 8 };

            CollectionAssert.AreEqual(expectedArray, inputArray);   
        }

        [TestMethod]
        public void AddToArray_Add()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5};
            int inputValue = 8;
            ArrayAdder.addToArray(ref inputArray, inputValue);
            int[] expectedArray = new int[] { 1, 2, 3, 4, 5, 8};

            CollectionAssert.AreEqual(expectedArray, inputArray);
        }
    }
}
