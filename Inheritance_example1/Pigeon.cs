﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_example1
{
    class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)

        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "White");
            }
            return eggs;

        }
    }
}
