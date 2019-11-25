using System;

namespace _Quiz_new_
{
    class QuizElementText : QuizElement
    {
        Answer _answer = new Answer(); 

        public new void display()
        {
            Console.WriteLine(_question); 
            
            Console.WriteLine("Please type in the correct answer by using your keyboard."); 
        }


        public new Boolean checkAnswer(string userAnswer)
        {
            if (userAnswer == _answer._text)
            {
                return true; 
            }

            else
            {
                Console.WriteLine(_answer._text + " would be the correct answer"); 
                return false; 
            }
        }


        public static new QuizElement createQuizElement()
        {
            Console.WriteLine("Please type in your question."); 

            string userQuestion = Console.ReadLine(); 


            Console.WriteLine("Please write the correct answer to your question and pay attention to the correct spelling of your answer."); 

            string userText = Console.ReadLine(); 


            Answer userAnswer = new Answer {_text = userText}; 

            QuizElementText userTextQuestion = new QuizElementText{_question = userQuestion, _answer = userAnswer}; 
            
            return userTextQuestion; 
        }
    }
}
