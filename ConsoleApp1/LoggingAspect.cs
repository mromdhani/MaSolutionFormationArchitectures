
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   [Serializable]
    class LoggingAspect 
    {
        public  void OnEntry()
        {
            Console.WriteLine("Al entrée de la méthode");
        }

        public void OnExit()
        {
            Console.WriteLine("Al entrée de la méthode");
        }
    }
}
