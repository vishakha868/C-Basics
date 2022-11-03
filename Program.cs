using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            bool? Ismajor = null;
            if (Ismajor == true)
            {
                Console.WriteLine("user is major");
            }
            else if (Ismajor == false)
            {
                Console.WriteLine("user is not major");
            }
            else 
            {
                Console.WriteLine("user does not wish to say");
            }
        }
    }
}
