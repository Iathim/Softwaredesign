using System;

namespace exercise_06
{
    class PseudoProgram
    {
        int geschirr; 

        Boolean wasserMitSpühlmittel = false; 

        int wasserstand = 0; 

        public static int geschirrSammeln(int geschirr)
        {
            int geschirrSammlung = geschirr; 

            return geschirrSammlung; 
        }


        public static Boolean entscheidung(Boolean motivationSpühlen)
        {
            if (motivationSpühlen == true)
            {
                return true; 
            }
            
            else 
            {
                return false; 
            }
        }


        public static int wasserEinlassen() 
        {
            int wasserstand = 0; 

            int beckenVoll = 3; 

            int wasserProMinute = 1; 

            for (int i = 0; wasserstand != beckenVoll; i++ )
            {
                wasserstand = wasserstand + wasserProMinute; 
            }

            return wasserstand; 
        }


        public static Boolean spühlmittelHinzugeben(Boolean wasserMitSpühlmittel)
        {
            wasserMitSpühlmittel = true; 

            return wasserMitSpühlmittel; 
        }


        public static Boolean geschirrInSpühle(Boolean geschirrInWasser)
        {
            geschirrInWasser = true; 

            return geschirrInWasser; 
        }


        public static Boolean geschirrSpühlen(int geschirrSammlung)
        {   
            Boolean geschirrGespühlt = false; 

            for (int i = geschirrSammlung; i > geschirrSammlung; i--)
            {
                if (geschirrSammlung != 0)
                {
                    geschirrSammlung = geschirrSammlung -1; 
                }

                if(geschirrSammlung == 0)
                {
                    geschirrGespühlt = true; 
                }

            }
            return geschirrGespühlt; 
        }

        public static Boolean entscheidungZwei(Boolean lustGeschirrAbzutrocknen)
        {
            Boolean entscheidung = false; 
            if (lustGeschirrAbzutrocknen == false)
            {
                entscheidung = false;
            }

            else 
            {
                entscheidung = true; 
            }

            return entscheidung; 
        }


        public static string geschirrEinräumen(int geschirrZumEinräumen)
        {
            for (int i = 0; i <= geschirrZumEinräumen; i++)
            {
                geschirrZumEinräumen = geschirrZumEinräumen -1; 
            }

            if(geschirrZumEinräumen == 0)
            
            return "Geschirr ist eingeräumt"; 

            else 
            {
                geschirrEinräumen(geschirrZumEinräumen); 
                return "Noch nicht fertig"; 
            }
        }
    }
}
