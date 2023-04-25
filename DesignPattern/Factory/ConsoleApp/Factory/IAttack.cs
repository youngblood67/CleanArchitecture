using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    interface IAttack
    {
        void Hit(IDefend defender, int nbPoint);
    }
}
