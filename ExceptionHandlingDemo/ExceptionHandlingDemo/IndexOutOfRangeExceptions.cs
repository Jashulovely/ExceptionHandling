using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class IndexOutOfRangeExceptions
    {
        public void IndexOut()
        {
            int[] array = new int[5]
            {
                1, 2, 3, 4,5
            };
            try
            {
                Console.WriteLine(array[6]);
            } catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
