using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_example1
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {

            Egg[] eggs = new Egg[numberOfEggs];

            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, "Speckled");
                
            }

            return eggs;
        }
    }
}
