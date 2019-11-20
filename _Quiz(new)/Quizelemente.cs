using System;

namespace _Quiz_new_
{
    class Answer
    {
        public string _text; 
        public Boolean _isTrue; 
    }


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


    class QuizElementTrueFalse : QuizElement
    {
        Boolean isTrue; 

        public new void display()
        {
            Console.WriteLine(_question);

            Console.WriteLine("Answer 'Y' for yes/true or 'N' for no/false."); 
        }


        public new Boolean checkAnswer(string userAnswer)
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


            if (answerValue == isTrue)
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

            if (userInput == "true")
            {
                trueFalse = true; 
            }

            else
            {
                trueFalse = false; 
            }

            QuizElementTrueFalse userTrueFalse = new QuizElementTrueFalse{_question = userQuestion, isTrue = trueFalse}; 

            return userTrueFalse; 
        }
    }


    class QuizElementText : QuizElement
    {
        Answer answer = new Answer(); 

        public new void display()
        {
            Console.WriteLine(_question); 
            
            Console.WriteLine("Please write the correct answer by using your keyboard."); 
        }


        public new Boolean checkAnswer(string userAnswer)
        {
            if (userAnswer == answer._text)
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
            Console.WriteLine("Please type in your question."); 

            string userQuestion = Console.ReadLine(); 


            Console.WriteLine("Please type in the correct answer to your question and pay attention to the correct spelling of your answer."); 

            string userText = Console.ReadLine(); 


            Answer userAnswer = new Answer {_text = userText}; 

            QuizElementText userTextQuestion = new QuizElementText{_question = userQuestion, answer = userAnswer}; 
            
            return userTextQuestion; 
        }
    }


    class QuizElementGuess : QuizElement
    {
        float tolerance; 

        float correctAnswer;  

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


            

            float toleranceMin = correctAnswer - tolerance; 

            float toleranceMax = correctAnswer + tolerance; 

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


            QuizElementGuess userGuess = new QuizElementGuess{_question = userQuestion, tolerance = userToleranceFloat, correctAnswer = userAnswerFloat}; 

            
            return userGuess; 
        }
    }



    class QuizElementMultiAnswer : QuizElement
    {
        Answer[] answers = new Answer[6];   

        public new void display()
        {
            Console.WriteLine(_question); 

            Console.WriteLine("There is more than one answer correct. Please type the number(s) of the answer(s) you think is correct one after another."); 
            Console.WriteLine("Please refrain from writing the same number twice."); 
            Console.WriteLine("Press Enter if your finished answering the question."); 
        }


        public new Boolean checkAnswer(string userAnswer)
        {
            

            return false; 
        }


        public new QuizElement createQuizElement()
        {
            
            return new QuizElement(); 
        }
    }


    class QuizElementSingleAnswer : QuizElement
    {
        Answer[] answers = new Answer[5];  

        public new void display()
        {
            Console.WriteLine(_question);

            Console.WriteLine("Only one answer is correct. Please enter the number of the answer you think is correct."); 
        }


        public new Boolean checkAnswer(string userAnswer)
        {
            if (userAnswer != "1" || userAnswer != "2" || userAnswer != "3" || userAnswer != "4" || userAnswer != "5" || userAnswer != "6")
            {
                Console.WriteLine("Please only use a number from 1 to 6."); 

                userAnswer = Console.ReadLine(); 

                checkAnswer(userAnswer); 
            }
            int userAnswerNumber = int.Parse(userAnswer); 
            //Excaption for using letters and symbols 

            if (answers[userAnswerNumber]._isTrue == true)
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


            if (userInput == "exit")
            {
                Answer[] userAnswers = {correctAnswer, firstFalseAnswer}; 
                QuizElementSingleAnswer userSingleAnswer = new QuizElementSingleAnswer{_question = userQuestion}; 

                return userSingleAnswer; 
            }
            
            return new QuizElement(); 
        }
    }
}
