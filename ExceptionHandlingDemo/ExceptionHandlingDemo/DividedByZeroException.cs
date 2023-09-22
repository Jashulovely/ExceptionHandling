using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class DividedByZeroException
    {
        public void Divide()
        {
            int a = 0;
            int b = 10;
            //if (a != 0)
            //{
            //    int b = 10 / a;
            //}
            try
            {
                int c = b/a;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hi");
        }
    }
}
