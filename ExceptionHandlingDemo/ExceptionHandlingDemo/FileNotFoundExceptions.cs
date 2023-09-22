using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class FileNotFoundExceptions
    {
        public void FileExists()
        {
            var fileName = "jashu.txt";
            try
            {
                var text = File.ReadAllText(fileName);
                Console.WriteLine(text);
            }catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
