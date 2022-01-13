using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate2
{
    class recursiv
    {
        public static int Maxim(int[] vector, int n, int maxx)
        {
            if (n == 0)
            {
                if (maxx >= vector[n])
                    return maxx;
                else
                    return vector[n];
            }
            else
            {
                if (maxx >= vector[n])
                    return Maxim(vector, n - 1, maxx);
                else
                    return Maxim(vector, n - 1, vector[n]);
            }
        }
    }
}
