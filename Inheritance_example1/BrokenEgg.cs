using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_example1
{
    class BrokenEgg:Egg
    {
        public BrokenEgg(string color) : base(0,$"Broken {color}")
        {
            Console.WriteLine("A bird laid a broken egg ");
        }
    }
}
