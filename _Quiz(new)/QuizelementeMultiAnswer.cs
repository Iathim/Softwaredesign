using System;

namespace _Quiz_new_
{
    class QuizElementMultiAnswer : QuizElement
    {
        Answer[] _answers = new Answer[6];   

        public override void display()
        {
            Console.WriteLine(_question); 

            Console.WriteLine("There is more than one answer correct. Please type the number(s) of the answer(s) you think is correct one after another."); 
            Console.WriteLine("Please refrain from writing the same number twice."); 
            Console.WriteLine("Press Enter if your finished answering the question."); 
        }


        public override Boolean checkAnswer(string userAnswer)
        {
            

            return false; 
        }


        public static new QuizElement createQuizElement()
        {
            
            return null; 
        }
    }

}
