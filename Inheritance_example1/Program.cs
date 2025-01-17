﻿using System;

namespace Inheritance_example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird;
            Console.WriteLine("\nPress P for pigeon, 0 for ostrich:  ");
            char key = Char.ToUpper(Console.ReadKey().KeyChar);
            if (key == 'P') bird = new Pigeon();
            else if (key == '0') bird = new Ostrich();
            else return;
            Console.Write("\nHow many eggs should it lay ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
            Egg[] eggs = bird.LayEggs(numberOfEggs);
            foreach (Egg egg in eggs)
            {
                Console.WriteLine(egg.Description);
            }
        }
    }
}
