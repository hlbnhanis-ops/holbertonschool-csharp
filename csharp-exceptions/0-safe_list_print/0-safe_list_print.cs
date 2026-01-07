using System;

namespace _0_safe_list_print
{
    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int count = 0;

            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(myList[i]);
                    count++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            return count;
        }
}
}
