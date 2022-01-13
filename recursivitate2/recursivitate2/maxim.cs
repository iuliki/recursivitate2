using System;
using System.Collections.Generic;
using System.Text;

namespace recursivitate2
{
    class maxim
    {
        public static int Maximul(int[] array, int n, int maxi)
        {
            if(n==0 )
            {
                if (maxi >= array[n])
                    return maxi;
                else
                    return array[n];
            }
            else
            {
                if (maxi >= array[n])
                    return Maximul(array,n-1,maxi);
                else
                    return Maximul(array, n - 1, array[n]);
            }
        }
    }
}
