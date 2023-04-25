using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    class Monster : IFighter
    {
        public Monster()
        {
            Console.WriteLine("Hello I'm a monster fighter.");
        }
        public void Hit(IDefend defender, int nbPoint)
        {
            Console.WriteLine("I hit like a monster.");
        }

        public void Protect(int armor)
        {
            Console.WriteLine("I defend like a monster.");
        }
    }
}
