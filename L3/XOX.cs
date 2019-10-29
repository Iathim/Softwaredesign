using System;

namespace L3
{
    class XOX
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static Boolean startGame()
        {
            Boolean gameEnd = false; 

            Console.WriteLine("Bitte X oder O eingeben"); 

            var symbol = Console.ReadLine();

            string[,] arraySpielfeld = new string[3, 3] { { " ", " ", " " }, { " ", " ", " "}, { " ", " ", " "} };

            if (symbol != "X" || symbol != "O" || symbol != "x" || symbol != "o" )
            { 
                Console.WriteLine("Bitte gültiges Symbol eingeben. Nur X oder O"); 
            }









            



            return gameEnd; 
        }
    }
}
