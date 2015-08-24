using System;

namespace HW_arrays_task1
{
    public static class ArrayReverser
    {
        private static void swap(int[] array, int i, int j)
        {
            int temporary = array[i];
            array[i] = array[j];
            array[j] = temporary;
        }

        public static int[] reverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }
            return reversedArray;
        }

        public static void reverseInPlace(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                swap(array, i, array.Length - i - 1);
            }
        }
    }
}