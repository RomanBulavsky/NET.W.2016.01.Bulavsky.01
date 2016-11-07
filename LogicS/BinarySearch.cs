using System;

namespace LogicS
{
    public static class BinarySearch
    {
        public static int find(int[] array, int x)
        {
            if (array == null) throw new ArgumentNullException("Where is Array?");

            int start = 0, end = array.Length;
            long mid = 0;
            long oldMid = -1;

            while (start < end)
            {
                if (oldMid == mid) return -1;

                oldMid = mid;

                mid = (start + end) / 2;
                if (array[mid] == x)
                {
                    return (int)mid;
                }
                else if (array[mid] > x)
                {
                    end = (int)mid;
                }
                else if (array[mid] < x)
                {
                    start = (int)mid;
                }

            }
            return (int)mid;
        }
    }
}
