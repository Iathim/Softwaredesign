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

           List<Item>inventory = character.inventory; 

            foreach (Item aItem in inventory)
            {
                Console.WriteLine(inventory);
            } 

           Console.WriteLine("Please write the name of the item you'd like to drop."); 

           string userInput = Console.ReadLine(); 

           foreach (Item aItem in inventory)
            {
                if (userInput == aItem.name)
                {
                area.items.Add(aItem); 
                inventory.Remove(aItem);
                }
            }     
       } 


       public override void talk(NPC characterToTalkTo)
       {
           characterToTalkTo.talk(characterToTalkTo); 
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

       public void move(Area actualArea, Area[] areas)
       {
           string positon = actualArea.position;

           Area middleArea = null;  

           foreach (Area aArea in areas)
                {
                    if (aArea.position == "m" || aArea.position == "middle")
                    {
                        middleArea = aArea;  
                    }
                }

           if (positon == "n" || positon == "north")
           {
               foreach (Area aArea in areas)
                {
                    if (aArea.position == "m" || aArea.position == "middle")
                    {
                        actualArea = aArea; 
                        Console.WriteLine(aArea.destription); 
                    }
                }
           }

           if (positon == "e" || positon == "east")
           {
               foreach (Area aArea in areas)
                {
                    if (aArea.position == "m" || aArea.position == "middle")
                    {
                        actualArea = aArea; 
                        Console.WriteLine(aArea.destription); 
                    }
                }
           }

           if (positon == "s" || positon == "south")
           {
               foreach (Area aArea in areas)
                {
                    if (aArea.position == "m" || aArea.position == "middle")
                    {
                        actualArea = aArea; 
                        Console.WriteLine(aArea.destription); 
                    }
                }
           }

           if (positon == "w" || positon == "west")
           {
               foreach (Area aArea in areas)
                {
                    if (aArea.position == "m" || aArea.position == "middle")
                    {
                        actualArea = aArea; 
                        Console.WriteLine(aArea.destription); 
                    }
                }
           }

           else
           {
               Console.WriteLine("In which direction do you want to go next?"); 
               Console.WriteLine("n = north, e = east, s = south, w = west"); 
               Console.WriteLine("Please type in the direction you want to go."); 

               string userInput = Console.ReadLine(); 

               if (userInput == "n" || userInput == "e" || userInput == "s" || userInput == "w")
               {
                   switch (userInput)
                   {
                       case "n": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.position == "n" || aArea.position == "north")
                            {
                                actualArea = aArea; 
                                Console.WriteLine(aArea.destription); 
                            }
                        }
                        break; 

                        case "e": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.position == "e" || aArea.position == "east")
                            {
                                actualArea = aArea; 
                                Console.WriteLine(aArea.destription); 
                            }
                        }
                        break;

                        case "s": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.position == "s" || aArea.position == "south")
                            {
                                actualArea = aArea; 
                                Console.WriteLine(aArea.destription); 
                            }
                        }
                        break;

                        case "w": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.position == "w" || aArea.position == "west")
                            {
                                actualArea = aArea; 
                                Console.WriteLine(aArea.destription); 
                            }
                        }
                        break;
                   }
               }

               else
               {
                   Console.WriteLine("This was not a valid input"); 
               }
           }
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

            int numberOfItems = area.items.Count; 

            if (numberOfItems == 0)
            {
                Console.WriteLine("There is no Item here. Maybe someone picked it already up?");   
            }

            if (numberOfItems == 1)
            {
                foreach (Item aItem in items)
                {
                    character.putItemnInInventory(aItem, character); 
                }
            }

            else
            {
                foreach (Item aItem in items)
                {
                    Console.WriteLine(aItem);
                }

                Console.WriteLine("Which Item would you like to take? Please write the name of it."); 

                string userInput = Console.ReadLine();

                foreach (Item aItem in items)
                {
                    if(aItem.name == userInput)
                    {
                        character.putItemnInInventory(aItem, character); 
                    }
                }
            }
       }
    }
}
