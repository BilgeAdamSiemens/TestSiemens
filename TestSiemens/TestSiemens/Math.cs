using System;
using System.Collections.Generic;
using System.Text;

namespace TestSiemens
{
    public class Math
    {
        public int Add(int x, int y)
        {
            /*
                int z;
                z = x + y;
                return z;
            */
            return x + y;
        }

        public int Max(int a, int b)
        {
            /*
                if (a > b)
                    return a;
                else
                    return b;
            */
            //Ternary
            return (a > b) ? a : b;
        }

        //IEnumerable & IQuearyble
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 0; i <= limit; i++)
            { 
                if(i % 2 != 0)
                    yield return i;
            }
        }
    }
}
