using System;

namespace _Quiz_new_
{
    class MainQuiz
    {
        public static void Main(string[] args)
        {
            
            
            
            
            
            
            
            string userInput = Menue.displayMenue(); 

            if (userInput == null)
            {
                userInput = Menue.displayMenue(); 
            }

            else
            {
                if (userInput == "1")
                {
                    //Play Quiz 
                }

                if (userInput == "2")
                {
                    //Create new Quizelement 
                    //Returns Quizelement which has to be saved to the QuizelementList/Question
                }

                if (userInput == "3")
                {
                    //exit game 
                }
            }


        }
    }
}
