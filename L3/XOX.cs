using System;

namespace L3
{
    class XOX
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static string startGame()
        {
            Boolean gameEnd = false; 
            int turn = 0; 

            int spieler = 2; 
            



            Console.WriteLine("Spieler 1: Bitte X oder O eingeben"); 

            string[,] arrayGameBoard = new string[3, 3] { { "0", "1", "2" }, { "3", "4", "5"}, { "6", "7", "8"} };

            Console.WriteLine(arrayGameBoard); 


            for (int i = 0; turn <= 9; i++)
            {
                var symbol = Console.ReadLine();

                if (symbol != "X" || symbol != "O")
                { 
                    Console.WriteLine("Bitte gültiges Symbol eingeben. Nur X oder O in upper case"); 
                }

            
                Console.WriteLine("Bitte geben Sie die Zahl des Feldes an, in welches Sie ihr Symbol setzen wollen."); 
                
                string position = Console.ReadLine(); 

                /*if (spieler == 2)
                    spieler = 1;
                else if (spieler == 1)
                    spieler = 2;*/

                switch(position)
                {
                    case "0": arrayGameBoard[0,0] = symbol; 
                    break; 

                    case "1": arrayGameBoard[0,1] = symbol; 
                    break;

                    case "2": arrayGameBoard[0,2] = symbol; 
                    break; 


                }



                turn = turn + 1; 

            }







            


           



            return "Es gibt einen Gewinner!"; 
        }


        public static Boolean winningCondition(string symbol)
        {
            Boolean win = false; 

            /*if (arrayGameBoard[0,0] == symbol)
            {
                if (arrayGameBoard[1,1] == symbol)
                {
                    if (arrayGameBoard[2,2] == symbol)
                    {
                        win = true;

                        return win; 
                    }
                }
            }*/







            return win; 
        }
    }
}
