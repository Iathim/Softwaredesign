using System;
using System.Collections.Generic; 

namespace Code
{
    public abstract class Character
    {
       public string name; 
       public int HP; 
       public int damage; 
       public bool isAlive = true; 
       public bool isPlayerCharacter; 
       public List<Item> inventory; 


       public abstract void attack(Character attackingCharacter, Character defendingCharacter, Area area);

       protected abstract int damageOfAttack(Character attackingCharacter, Character defendingCharacter); 

       public abstract void dropItem(Character character, Area area); 

       public abstract void talk(NPC charakterToTalkTo);

       public abstract void dies(Character character);  
    }
}
