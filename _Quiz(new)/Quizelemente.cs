using System;

namespace _Quiz_new_
{
    class QuizElement
    {
        public string _question; 


        public void display()
        {
            Console.WriteLine(_question); 
        }


        public Boolean checkAnswer(string userAnswer)
        {


            return false; 
        }


        public QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }
}
