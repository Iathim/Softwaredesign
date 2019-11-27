using System;

namespace _Quiz_new_
{
    class QuizElementTrueFalse : QuizElement
    {
        Boolean _isTrue; 

        public override void display()
        {
            Console.WriteLine(_question);

            Console.WriteLine("Answer 'Y' for yes/true or 'N' for no/false."); 
        }


        public override Boolean checkAnswer(string userAnswer)
        {
            Boolean answerValue = false; 

            if (userAnswer != "Y" || userAnswer != "y" || userAnswer != "N" || userAnswer != "n")
            {
                Console.WriteLine("Please give a valid input: 'Y' for yes/true or 'N' for no/false."); 

                userAnswer = Console.ReadLine(); 

                checkAnswer(userAnswer); 
            }

            else 
            {
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    answerValue = true; 
                }

                else 
                {
                    answerValue = false; 
                }
            }


            if (answerValue == _isTrue)
            {
                return true; 
            }

            else
            {
                return false; 
            }
        }


        public static new QuizElement createQuizElement()
        {
            Boolean trueFalse = false; 

            Console.WriteLine("Please type in your question."); 

            string userQuestion = Console.ReadLine(); 


            Console.WriteLine("Is your question true or false?"); 

            string userInput = Console.ReadLine(); 



            while (userInput != "true" || userInput != "True" || userInput != "false" || userInput != "False")
            {
                Console.WriteLine("Is your question true or false? Type true if the answer is true/yes and false if it's false/no."); 

                userInput = Console.ReadLine(); 

                if (userInput == "true" || userInput == "True" || userInput == "false" || userInput == "False")
                {
                    break; 
                }

            }

            if (userInput == "true" || userInput == "True")
            {
                trueFalse = true; 
            }

            else
            {
                trueFalse = false; 
            }

            QuizElementTrueFalse userTrueFalse = new QuizElementTrueFalse{_question = userQuestion, _isTrue = trueFalse}; 

            return userTrueFalse; 
        }
    }
}
