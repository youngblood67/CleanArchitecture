using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    class Human : IFighter
    {
        public Human()
        {
            Console.WriteLine("Hello I'm a human fighter.");
        }
        public void Hit(IDefend defender, int nbPoint)
        {
            Console.WriteLine("I hit like a human.");
        }

        public void Protect(int armor)
        {
            Console.WriteLine("I defend like a human.");
        }
    }
}
