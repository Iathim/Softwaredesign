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









            if (arraySpielfeld[1,1] == "X")
            {
                if (arraySpielfeld[2,2] == "X")
                {
                    if (arraySpielfeld[3,3] == "X")
                    {
                        gameEnd = true; 

                        Console.WriteLine("Herzlichen Glückwunsch, X hat gewonnen!"); 
                    }
                }
            }



            return gameEnd; 
        }
    }
}
