using Factory.Factory;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var h = new HumanFighter();
            var human = h.CreateFighter();

            Console.Read();
        }
    }
}
