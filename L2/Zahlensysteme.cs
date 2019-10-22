using System;

namespace L2
{
    class Zahlensysteme
    {
       public static int ConvertDecimalToHexal(int dec)
       {
           int hexal = 0; 
           if (dec > 1023 || dec < 0)
           {
               Console.WriteLine("Die Zahl darf nicht größer als 1023 und kleiner als 0 sein"); 
               return 0; 
           }

           if(dec >= 6)
                return dec; 

           else 
           {
              int mod = dec % 6; 
              /*int next = dec / 6; 

              if (next != 0)
              ConvertDecimalToHexal(next); */
              
               return hexal; 
           }
       }


       public static int ConvertHexalToDecimal(int hexal)
       {
           int dec = 0; 


            return dec; 
       }


       public static int ConvertToBaseFromDecimal(int toBase, int dec)
       {
           int output = 0; 


           return output; 
       }


       public static int ConvertToDecimalFromBase(int fromBase, int number)
       {
           int dec = 0; 


           return dec; 
       }


       public static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase)
       {
           int output = 0; 


           return output; 
       }
    }
}
