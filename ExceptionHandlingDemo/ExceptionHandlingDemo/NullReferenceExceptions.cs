using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class NullReferenceExceptions
    {
        public void NullRef()
        {
            try
            {
                string value = null;
                Console.WriteLine(value.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("String is null.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
