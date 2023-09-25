using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class ArrayTypeMissMatch
    {
        public void ArrayType()
        {
            string[] arrayOne = {"Jashu","Manoj","Uday"};
            int[] arrayTwo = {1,2,3};
            try
            {
                Array.Copy(arrayOne, arrayTwo, 3);
            }catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);   
            }
        }
    }
}
