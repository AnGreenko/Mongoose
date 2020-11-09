using System;
using MonGod.Colorama;

namespace MonGod
{
    class Program
    {
        static void Main(string[] args)
        {
            Coloro coloro = new Coloro(true);
            
            coloro.WriteLine("Hello", ConsoleColor.Red);
            string name = coloro.ReadLine("Enter Your Name: ", ConsoleColor.Yellow);
            
            coloro.WriteLine($"Hello {name}!", ConsoleColor.Green);
        }
    }
}