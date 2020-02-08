using System;

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
                defendingCharacter.isAlive = false;

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
            Item selectedItem = character.inventory[0];

            Console.WriteLine(character.name + " dropped " + selectedItem + " into the are"); 

            area.items.Add(selectedItem); 
       } 

       public override void talk(NPC character)
       {
           Console.WriteLine(character.dialogue); 
       } 

       public override void dies(Character character)
       {
           character.isAlive = false; 

           Console.WriteLine(character.name + " collapses on the floor and vanishes in a cloud of smoke. Strange."); 
       }
    }
}
