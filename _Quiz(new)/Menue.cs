using System;

namespace _Quiz_new_
{
    class Menue 
    {
        public static string displayMenue()
        {
            Console.WriteLine("1. Play Quiz."); 
            Console.WriteLine("2. Create a new Question & Answer."); 
            Console.WriteLine("3. Exit."); 

            Console.WriteLine("Please enter the number of the selection you want to chose."); 

            string userInput = Console.ReadLine(); 

            if (userInput != "1" || userInput != "2" || userInput != "3")
            {
                Console.WriteLine("Please enter a number from 1 to 3."); 
                //displayMenue(); 
                return null; 
            }

            else 
            {
                return userInput; 
            }
        }
    }
}
