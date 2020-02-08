using System;
using System.Collections.Generic; 

namespace Code
{
    public class DarkArea : Area
    { 
        public bool isDark = true; 
        public Item keyItem; 
        public string descriptionWhenBright; 


        public void lightenUp(Item keyItem, DarkArea area, Character character)
        {
            if(keyItem == area.keyItem)
            {
                area.isDark = false; 
                Console.WriteLine(area.descriptionWhenBright); 
            }

            else 
            {
                Console.WriteLine("You are still wrapped in darkness and you accedently stapped your toe. Ouch.");
                Console.WriteLine("Try something more useful"); 

                int damage = 5; 
                character.HP = character.HP - damage; 

                if (character.HP <= 0)
                {
                    character.dies(character); 
                }
            }
        }
    }
}
