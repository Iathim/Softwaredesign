﻿using System;

namespace exercise_08
{
    class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Welcome to the Calculator. Start entering calculations!");
           for (;;) // ever
           {
               Console.Write("> ");
               string command = Console.ReadLine();
               if (command.ToLower() == "exit")
                   break;             
               int left = 0;
               int right = 0;
               int opInx = FindFirstNonDigit(command);
               if (opInx < 0)
                   Console.WriteLine("No operator specified");
               char opSymbol = command[opInx];
               try
               {
                   left = int.Parse(command.Substring(0, opInx));
                   right = int.Parse(command.Substring(opInx + 1));
               }
               catch (Exception)
               {
                   Console.WriteLine("Error parsing commmand");
               }

               Console.WriteLine($"Calculating {left} {opSymbol} {right}...");

                float result = 0;

                switch(opSymbol)
                {
                    case '+':
                    result = left + right;
                    break;
                    

                    case '-': 
                    result = left - right; 
                    break; 

                    case '/': 
                    result = left / right; 
                    break; 

                    /*case ':': 
                    result = left / right; 
                    break;*/

                    case '*': 
                    result = left * right; 
                    break; 
                }
                
                Console.WriteLine($"... = {result}");
           }
       }

       private static int FindFirstNonDigit(string s)
       {
           for (int i = 0; i < s.Length; i++)
           {
               if (!Char.IsDigit(s[i]))
                   return i;
           }
           return -1;
       }        
   }
}
