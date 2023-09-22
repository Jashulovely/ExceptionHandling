using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    // a problem that occurs during the execution of a program is refered to as an exception
    // its allow to control of apast from one part of the program to the another exception.
    // it will prevent the crashing of the program 
    internal class Program
    {
        static void Main(string[] args)
        {
            DividedByZeroException dividedByZeroException = new DividedByZeroException();
            dividedByZeroException.Divide();
            Console.ReadLine();
        }
    }
}
