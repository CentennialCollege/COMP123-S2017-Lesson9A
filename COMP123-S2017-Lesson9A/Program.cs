using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.3 - Used the ToString Method of the SuperHuman class
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation",50));
            superHuman.Powers.Add(new Power("Phasing", 40));
            superHuman.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHuman.ToString());

        }
    }
}
