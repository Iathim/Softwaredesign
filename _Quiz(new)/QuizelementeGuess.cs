using System;

namespace _Quiz_new_
{
    class QuizElementGuess : QuizElement
    {
        float _tolerance; 

        float _correctAnswer;  

        public new void display()
        {
            Console.WriteLine(_question); 

            Console.WriteLine("Please write your guess. Use '.' if you want to write a decimal number."); 
        }


        public new Boolean checkAnswer(string userAnswer)
        {
            //Invalid input = ',' and letters -> error in userAnswerNumber 
            
            /*string invalidInput = ","; 

            Boolean invalidInputFound = userAnswer.Contains(invalidInput); 

            if (invalidInputFound == true)
            {
                Console.WriteLine("Please user '.' to describe a decimal number."); 

                userAnswer = Console.ReadLine(); 

                checkAnswers(userAnswer); 
            }*/


            float toleranceMin = _correctAnswer - _tolerance; 

            float toleranceMax = _correctAnswer + _tolerance; 

            float userAnswerNumber = float.Parse(userAnswer); //excaption: userAnswer has ',', letters oder more than one '.' in it 

           
            if (userAnswerNumber <= toleranceMax && userAnswerNumber >= toleranceMin)
            {
                return true; 
            }

            else
            {
                return false; 
            } 
        }


        public new QuizElement createQuizElement()
        {
            Console.WriteLine("Please type in your question"); 

            string userQuestion = Console.ReadLine(); 


            Console.WriteLine("Please type in the correct answer to your question. It has to be a number."); 

            string userAnswer = Console.ReadLine(); 


            Console.WriteLine("Please write a tolerance to the correct answer. E.g. '0.5'. 1 equals 100% and 0 equals 0%."); 

            string userTolerance = Console.ReadLine(); 


            float userAnswerFloat = float.Parse(userAnswer); //ecapion handling for : everything except numbers 

            float userToleranceFloat = float.Parse(userTolerance); 


            QuizElementGuess userGuess = new QuizElementGuess{_question = userQuestion, _tolerance = userToleranceFloat, _correctAnswer = userAnswerFloat}; 

            
            return userGuess; 
        }
    }
}
