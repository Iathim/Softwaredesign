using System;
using System.Collections.Generic;

namespace Code
{
     public class NPC : Character
    {
        public string dialogue; 
       public override void attack(Character attackingCharacter, Character defendingCharacter, Area area)
       {
           int remainingHP = damageOfAttack(attackingCharacter, defendingCharacter); 

            if (remainingHP == 0)
            {
                defendingCharacter.isDead = true;

                if (defendingCharacter.isPlayerCharacter == false)
                {
                    Console.WriteLine("Congratulations! You killed " + defendingCharacter.name); 

                    defendingCharacter.dropItem(defendingCharacter, area); 
                }

                else 
                {
                    Console.WriteLine("Oh no. " + defendingCharacter.name + ". You got killed by" + attackingCharacter.name); 
                    Console.WriteLine("GAME OVER"); 
                    Console.WriteLine("The Game does quit now."); 

                    Commands.quitGame(); 
                } 
            }
       }

       protected override int damageOfAttack(Character attackingCharacter, Character defendingCharacter)
       {
           int HP = defendingCharacter.HP; 

           int damage = attackingCharacter.damage; 

           int newHP = HP - damage; 
           
           return newHP;
       }

       public override void dropItem(Character character, Area area)
       {
           List<Item> inventory = character.inventory; 

            foreach (Item aItem in inventory)
            {
                Console.WriteLine(character.name + " dropped " + aItem + " into the area."); 

                area.items.Add(aItem); 
            } 
       } 

       public override void talk(NPC character)
       {
           if ( character.isDead == true)
           {
               Console.WriteLine("There is no one to talk to here. Maybe you could talk a bit to yourself and hear it echo of the walls?"); 
           }

           else
           {
                Console.WriteLine(character.dialogue);
           } 
       } 

       public override void dies(Character character)
       {
           character.isDead = true; 

           Console.WriteLine(character.name + " collapses on the floor and vanishes in a cloud of smoke. Strange."); 
       }
    }
}
