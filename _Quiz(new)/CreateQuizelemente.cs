using System;

namespace _Quiz_new_
{
    class createQuizElemente
    {
        public QuizElement createNewQuizelement()
        {
            Console.WriteLine("What kind of Quizelement do you want to create? Type in /one/ of the following numbers."); 
            Console.WriteLine("1. True/False Question"); 
            Console.WriteLine("2. Textual Question."); 
            Console.WriteLine("3. Guessing Question."); 
            Console.WriteLine("4. Multiple Choice Question."); 
            Console.WriteLine("5. Singe Answer Question."); 

            string userSelection = Console.ReadLine(); 


            if (userSelection != "1" || userSelection != "2" || userSelection != "3" || userSelection != "4" || userSelection != "5")
            {
                Console.WriteLine("Please type in a valid input: Any number from 1 to 5"); 
                createNewQuizelement(); 
            }

            
                if (userSelection == "1")
                { 
                    return QuizElementTrueFalse.createQuizElement(); 
                }

                if (userSelection == "2")
                {
                    return QuizElementText.createQuizElement(); 
                }

                if (userSelection == "3")
                {
                    return QuizElementGuess.createQuizElement(); 
                }

                if (userSelection == "4")
                {
                    return QuizElementMultiAnswer.createQuizElement(); 
                }

                else
                {
                    return QuizElementSingleAnswer.createQuizElement(); 
                }
        }
    }
}
