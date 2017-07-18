using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.5 - Implemented the SuperVillain class
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.Powers.Add(new Power("Teleportation",50));
            superHero.Powers.Add(new Power("Phasing", 40));
            superHero.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine();

            SuperVillain superVillain = new SuperVillain("SuperVillain Dude", 20);
            superVillain.AddPower("Shadow Casting", 50);
            superVillain.AddPower("Mind Control", 40);
            superVillain.AddPower("Combat Senses", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);

        }
    }
}
