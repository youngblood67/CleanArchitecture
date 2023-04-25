using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    class HumanFighter : FighterFactory
    {
        public override IFighter CreateFighter()
        {
            return new Human();
        }
    }
}
