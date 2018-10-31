using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calcul
    {
        [LoggingAspect]
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
