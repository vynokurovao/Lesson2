using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_arrays_task2
{
    public class ArrayAdder
    {
        public static void addToArray(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = value;
            array = newArray;
        }
    }
}
