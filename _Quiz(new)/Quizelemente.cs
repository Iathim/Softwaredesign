using System;

namespace _Quiz_new_
{
    public abstract class QuizElement
    {
        public string _question; 


        public virtual void display()
        {
            Console.WriteLine(_question); 
        }


        public abstract Boolean checkAnswer(string userAnswer); 


        public QuizElement createQuizElement()
        {
            
            return null; 
        }
    }
}
