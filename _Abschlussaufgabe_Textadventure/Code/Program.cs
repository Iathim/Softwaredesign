using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Area[] areas = null; 

            Area startingArea = null; 

            Area actualArea = startingArea;  

            PlayerCharacter player = null;

            Commands commands = null; 

            Commands.useCommands(player, actualArea, areas, commands); 

            Console.WriteLine("Hello World!");
        }
    }
}
