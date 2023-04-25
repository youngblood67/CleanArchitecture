using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    /// <summary>
    /// Pattern Abstract Factory
    /// </summary>
    abstract class FighterFactory
    {
        abstract public IFighter CreateFighter();
    }
}
