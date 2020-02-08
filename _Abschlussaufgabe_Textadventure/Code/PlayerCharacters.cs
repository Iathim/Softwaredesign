using System;
using System.Collections.Generic;

namespace Code
{
     public class PlayerCharacter : Character
    {
       public override void attack(Character attackingCharacter, Character defendingCharacter, Area area)
       {
           Console.WriteLine("Are you sure you want to attack " + defendingCharacter.name + "?");
           Console.WriteLine("Type y or yes to confirm."); 
           
           string userInput = Console.ReadLine(); 

           if (userInput != "y" || userInput != "yes")
           {
               Console.WriteLine("You decided against attacking " + defendingCharacter.name + ".");  
           }
           
           else
           {
               int remainingHP = damageOfAttack(attackingCharacter, defendingCharacter); 

               if (remainingHP <= 0)
               {
                   defendingCharacter.isAlive = false;

                   if (defendingCharacter.isPlayerCharacter == false)
                   {
                       Console.WriteLine("Congratulations! You killed " + defendingCharacter.name); 

                       dropItem(defendingCharacter, area);

                       dies(defendingCharacter);  
                   }

                   else 
                   {
                       Console.WriteLine("Oh no. " + defendingCharacter.name + ". You got killed by" + attackingCharacter.name); 

                       Commands.quitGame(); 
                   } 
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
           Console.Write("Which Item would you like to drop?"); 

           //character.inventory.ForEach(Console.WriteLine); 

           Console.WriteLine(inventory); 

           Console.WriteLine("Please write the position of the item as number."); 

           string userInput = Console.ReadLine(); 

           int itemNumber = int.Parse(userInput);

           Item selectedItem = inventory[itemNumber];

           area.items.Add(selectedItem); 
       } 


       public override void talk(NPC characterToTalkTo)
       {
           talk(characterToTalkTo); 
       } 


       public override void dies(Character character)
       {
            character.isAlive = false; 
            Console.WriteLine("You managed to get " + character.name + " killed. You " + character.name + " sees the light at the end of the tunnel and walks towards it"); 
            Console.WriteLine("GAME OVER"); 
            Console.WriteLine("The Game does quit itself now."); 

            Commands.quitGame(); 
       }

       public void useItem(Area area)
       {
           
       }

       public void move(Area[] areas)
       {
           
       }

       /*public void look(Area area)
       {
           Console.WriteLine(area.destription); 
       }*/

       protected void putItemnInInventory(Item item, Character character)
       {
           character.inventory.Add(item);  
       }

       public void takeItem(Area area, PlayerCharacter character)
       {
            List <Item> items = area.items; 

            string stringItems = items.ToString(); 

            int numberOfItems = area.items.Count; 

            if (numberOfItems == 0)
            {
                Console.WriteLine("There is no Item here. Maybe someone picked it already up?");   
            }

            if (numberOfItems == 1)
            {
                foreach (Item aPart in items)
                {
                    Console.WriteLine(items);
                    //character.putItemnInInventory(items, character); 
                }
            }

            else
            {
                foreach (Item aPart in items)
                {
                    Console.WriteLine(items);
                }
            }
       }
    }
}
