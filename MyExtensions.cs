using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_net
{
    public static class MyExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}

        
    

        









