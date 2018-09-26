using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name >> ");
            string name = Console.ReadLine();
            Console.Write($"Hello {name}");
            Console.ReadLine();
        }
    }
}
