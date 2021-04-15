using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns_dz
{
    class MaxClass
    {
        public static int Max(int num)
        {
            int result = num - 1;

            if (result % 2 != 0)
                result--;

            return result;
        }
    }
}
