using System;

namespace _Quiz_new_
{
    class QuizElementSingleAnswer : QuizElement
    {
        Answer[] _answers = new Answer[5];  

        public override void display()
        {
            Console.WriteLine(_question);

            Console.WriteLine("Only one answer is correct. Please enter the number of the answer you think is correct."); 
        }


        public override Boolean checkAnswer(string userAnswer)
        {
            if (userAnswer != "1" || userAnswer != "2" || userAnswer != "3" || userAnswer != "4" || userAnswer != "5" || userAnswer != "6")
            {
                Console.WriteLine("Please only use a number from 1 to 6."); 

                userAnswer = Console.ReadLine(); 

                checkAnswer(userAnswer); 
            }
            int userAnswerNumber = int.Parse(userAnswer); 
            //Excaption for using letters and symbols 

            if (_answers[userAnswerNumber]._isTrue == true)
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
            Console.WriteLine("Please type in your question."); 

            string userQuestion = Console.ReadLine(); 


            Console.WriteLine("Please write the correct answer"); 

            string userAnswerCorrect = Console.ReadLine(); 


            Answer correctAnswer = new Answer{_text = userAnswerCorrect, _isTrue = true}; 


            Console.WriteLine("Please write a wrong answer to your question."); 

            string userAnswerFalse_1 = Console.ReadLine(); 


            Answer firstFalseAnswer = new Answer{_text = userAnswerFalse_1, _isTrue = false}; 


            Console.WriteLine("Please write another wrong answer or type 'exit' to finish creating your question"); 

            string userInput = Console.ReadLine(); 

            //Switch/Case?

            if (userInput == "exit" || userInput == "Exit")
            {
                Answer[] userAnswers = {correctAnswer, firstFalseAnswer}; 
                QuizElementSingleAnswer userSingleAnswer = new QuizElementSingleAnswer{_question = userQuestion}; 

                return userSingleAnswer; 
            }

            else 
            {
                string userAnswerFalse_2 = userInput; 

                Answer secondFalseAnswer = new Answer{_text = userQuestion, _isTrue = false}; 

                
            }
            
            return null; 
        }
    }
}
