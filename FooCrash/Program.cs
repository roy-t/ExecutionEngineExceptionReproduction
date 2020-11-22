using System;
using System.Reflection;

namespace FooCrash
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var assembly = Assembly.LoadFrom("library.dll");
            assembly.GetTypes();

            Console.ReadLine();
        }
    }
}
