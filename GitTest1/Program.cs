using System;
using System.Net.Security;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var name = Console.ReadLine();
            Console.WriteLine("Hello,"+name);
            Console.WriteLine("Hello," + name);
            Console.WriteLine("Hello," + name);
            Console.WriteLine("This is branch1");
        }
    }
}
