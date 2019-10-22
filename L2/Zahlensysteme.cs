using System;

namespace L2
{
    class Zahlensysteme
    {
       public static int ConvertDecimalToHexal(int dec)
       {
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
              int next = dec / 6; 

              if (next != 0)
              ConvertDecimalToHexal(next); 
              
               return 0; 
           }
       }
    }
}
