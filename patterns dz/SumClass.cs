using System;

namespace patterns_dz
{
    class SumClass
    {
        public static int Sum(int num)
        {
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
