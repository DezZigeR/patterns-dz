using System;

namespace patterns_dz
{
    class FactorialClass
    {
        public static int Factorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                if (int.MaxValue / result < i)
                {
                    result = -1;
                    break;
                }
                else
                {
                    result *= i;
                }
            }

            return result;
        }
    }
}
