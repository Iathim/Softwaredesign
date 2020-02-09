using System;
using System.Collections.Generic;

namespace Code
{
     public class PlayerCharacter : Character
    {
        public PlayerCharacter(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory)
        : base (_name, _hp, _damage, _isDead, _isPlayerCharacter, _inventory)
        {
            this.Name = _name; 
            this.HP = _hp; 
            this.Damage = _damage; 
            this.IsDead = _isDead; 
            this.IsPlayerCharacter = _isPlayerCharacter; 
            this.Inventory = _inventory; 
        }

       public override void attack(PlayerCharacter attackingCharacter, Area area)
       {
           NPC defendingCharacter = area.NPC;  
           if (defendingCharacter.IsDead == false)
           {

           /*Console.WriteLine("Are you sure you want to attack " + defendingCharacter.name + "?");
           Console.WriteLine("Type y or yes to confirm."); 
           
           string userInput = Console.ReadLine(); 

           if (userInput != "y" || userInput != "yes")
           {
               Console.WriteLine("You decided against attacking " + defendingCharacter.name + ".");  
           }*/
           
           /*else
           {*/
               int remainingHP = damageOfAttack(attackingCharacter, defendingCharacter); 

               defendingCharacter.HP = remainingHP; 

               if (remainingHP <= 0)
               {
                   defendingCharacter.IsDead = false;

                    Console.WriteLine("Congratulations! You killed " + defendingCharacter.Name); 

                    defendingCharacter.dropItem(defendingCharacter, area);

                    defendingCharacter.dies(defendingCharacter);  
               }

               else
               {
                   Console.WriteLine(defendingCharacter.Name + ": " + defendingCharacter.IfAttacked); 
               }
           }

           else 
           {
               Console.WriteLine("There is no one here. Out of anger, you attacked a harmless wall."); 
           }
           //} 
       }


       public override int damageOfAttack(PlayerCharacter attackingCharacter, NPC defendingCharacter)
       {
           Console.WriteLine("You start to attack " + defendingCharacter.Name + " viciously!"); 
           int HP = defendingCharacter.HP; 

           int damage = attackingCharacter.Damage; 

           int newHP = HP - damage; 
           
           return newHP; 
       }


       //public override void dropItem(PlayerCharacter character, Area area)
       public void dropItem(PlayerCharacter character, Area area)
       {
           int numberOfItems = character.Inventory.Count;

           List<Item> areaItems = area.Items;  

           List<Item> inventory = character.Inventory; 

           Item tempItem = null; 

           if (numberOfItems == 0)
           {
               Console.WriteLine("There is nothing in here so you dropped a bit of dust."); 
           }

           if (numberOfItems == 1)
           {
               tempItem = inventory[0]; 
               Console.WriteLine("You dropped " + tempItem.Name + " into the area"); 
               areaItems.Add(tempItem);
               inventory.Remove(tempItem);   
           }

           if(numberOfItems >=2)
           {
                Console.Write("Which Item would you like to drop?");

                foreach (Item aItem in inventory)
                {
                    Console.WriteLine(aItem.Name);
                } 

                Console.WriteLine("Please write the name of the item you'd like to drop."); 

                string userInput = Console.ReadLine(); 

                foreach (Item aItem in inventory)
                    {
                        if (userInput == aItem.Name)
                        {
                            area.Items.Add(aItem); 
                            tempItem = aItem; 
                        }
                    } 
                if (tempItem != null)
                {
                    inventory.Remove(tempItem);
                }

                else
                {
                    Console.WriteLine("There is no Item with that name."); 
                }
            }
       } 


       public override void talk(NPC characterToTalkTo)
       {
           characterToTalkTo.talk(characterToTalkTo); 
       } 


       //public override void dies(Character character)
       public void dies (PlayerCharacter character)
       {
            character.IsDead = false; 

            Console.WriteLine("You managed to get " + character.Name + " killed. You " + character.Name + " sees the light at the end of the tunnel and walks towards it"); 
            Console.WriteLine("GAME OVER"); 
            Console.WriteLine("The Game does quit itself now."); 

            System.Threading.Thread.Sleep(7000);

            Commands.quitGame(); 
       }

        public void showInventory(PlayerCharacter character)
        {
            List<Item> inventory = character.Inventory; 

            if(inventory == null)
            {
                Console.WriteLine("There is nothing in here... except quite a lot of fluff."); 
            }

            else
            {
                foreach (Item aItem in inventory)
                {
                    Console.WriteLine(aItem.Name);
                    Console.WriteLine(aItem.Description); 
                }
            }
        }

       public void useItem(Area area)
       {
           
       }

       public void move (List<Area> areas)
       {
           Area actualArea = null;  
            foreach (Area aArea in areas)
                {
                    if(aArea.IsActualArea == true) 
                    {
                        actualArea = aArea;
                        //Console.WriteLine(actualArea.description); 
                    }
                }

           string positon = actualArea.Position;

           Area middleArea = null;  

           foreach (Area aArea in areas)
                {
                    if (aArea.Position == "m" || aArea.Position == "middle")
                    {
                        middleArea = aArea;  
                    }
                }

           if (positon == "n" || positon == "north" || positon == "e" || positon == "east" || positon == "s" || positon == "south" || positon == "w" || positon == "west")
           {
               foreach (Area aArea in areas)
                {
                    aArea.IsActualArea = false; 
                }

               actualArea = middleArea; 
               middleArea.IsActualArea = true; 
               Console.WriteLine("You're gpoing back to the main room."); 
               Console.WriteLine(middleArea.Description); 
           }

           else
           {
               Console.WriteLine("In which direction do you want to go next?"); 
               Console.WriteLine("n = north, e = east, s = south, w = west"); 
               Console.WriteLine("Please type in the direction you want to go."); 

               string userInput = Console.ReadLine(); 

                   switch (userInput)
                   {
                       case "n":
                       case "north":  

                       foreach (Area aArea in areas)
                        {
                            if (aArea.Position == "n" || aArea.Position == "north")
                            {
                                actualArea.IsActualArea = false; 
                                aArea.IsActualArea = true; 
                                actualArea = aArea; 
                                Console.WriteLine(aArea.Description); 
                            }
                        }
                        break; 

                        case "e": 
                        case "east": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.Position == "e" || aArea.Position == "east")
                            {
                                actualArea.IsActualArea = false; 
                                aArea.IsActualArea = true; 
                                actualArea = aArea; 
                                Console.WriteLine(aArea.Description); 
                            }
                        }
                        break;

                        case "s": 
                        case "south": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.Position == "s" || aArea.Position == "south")
                            {
                                actualArea.IsActualArea = false; 
                                aArea.IsActualArea = true; 
                                actualArea = aArea; 
                                Console.WriteLine(aArea.Description); 
                            }
                        }
                        break;

                        case "w": 
                        case "west": 

                       foreach (Area aArea in areas)
                        {
                            if (aArea.Position == "w" || aArea.Position == "west")
                            {
                                actualArea.IsActualArea = false; 
                                aArea.IsActualArea = true; 
                                actualArea = aArea; 
                                Console.WriteLine(aArea.Description);  
                            }
                        }
                        break;

                        default: 
                        Console.WriteLine("This was not a valid input."); 
                        break; 
                   }
           }
       }

       /*public void look(Area area)
       {
           Console.WriteLine(area.destription); 
       }*/

       protected void putItemnInInventory(Item item, PlayerCharacter character)
       {
           character.Inventory.Add(item);  
       }

       public void takeItem(Area area, PlayerCharacter character)
       {
            List <Item> items = area.Items; 

            int numberOfItems = area.Items.Count;

            List <Item> characterInventory = character.Inventory;  

            if (numberOfItems == 0)
            {
                Console.WriteLine("There is no Item here. Maybe someone picked it already up?");   
            }

            if (numberOfItems == 1)
            {
                Item item = items[0]; 
                Console.WriteLine(item.Description); 
                characterInventory.Add(item);  
                items.Remove(item); 
            }

            else
            {
                foreach (Item aItem in items)
                {
                    Console.WriteLine(aItem.Name);
                }

                Console.WriteLine("Which Item would you like to take? Please write the name of it."); 

                string userInput = Console.ReadLine(); 

                List<Item> tempItems = area.Items; 
                Item tempItem = null; 

                foreach (Item aItem in tempItems)
                {
                    if (aItem.Name == userInput)
                    {
                        character.putItemnInInventory(aItem, character); 
                        tempItem = aItem; 
                    }
                }
                if (tempItem != null)
                {
                    Console.WriteLine("You put " + tempItem.Name + " in your inventory."); 
                    items.Remove(tempItem); 
                }

                else
                {
                    Console.WriteLine("No Item matches this name."); 
                }
            }
       }

       
        public void fight(PlayerCharacter player,  Area area)
        {
            NPC character = area.NPC; 

            player.attack(player, area); 

            if (character.IsDead != true)
            {
                character.attack(player, area); 
            }
        }
    }
}
