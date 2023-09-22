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

            bool interested = true;
            while (interested)
            {
                Console.WriteLine("Enter your choice.\n   1   -->   DivideByZeroException.\n   2   -->   FileNotFoundExceptions.\n" +
                    "   0   -->   QUIT.");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DividedByZeroException dividedByZeroException = new DividedByZeroException();
                        dividedByZeroException.Divide();
                        Console.ReadLine();
                        break;
                    case 2:
                        FileNotFoundExceptions fileNotFoundExceptions = new FileNotFoundExceptions();
                        fileNotFoundExceptions.FileExists();
                        Console.ReadLine();
                        break;
                    case 0:
                        interested = false;
                        Console.WriteLine("Thanks for your interest.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
