using System;
using System.Linq;

namespace Interview_Prep.ROITI
{
    public class FirstEx
    {
        public int? Exe(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            Array.Sort(arr);

            return arr[^1];
        }
    }
}
