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
           Console.Write("Which Item would you like to drop?"); 

           List<Item> inventory = character.Inventory; 

            foreach (Item aItem in inventory)
            {
                Console.WriteLine(aItem);
            } 

           Console.WriteLine("Please write the name of the item you'd like to drop."); 

           string userInput = Console.ReadLine(); 

           foreach (Item aItem in inventory)
            {
                if (userInput == aItem.Name)
                {
                area.Items.Add(aItem); 
                inventory.Remove(aItem);
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

            Commands.quitGame(); 
       }

        public void showInventory(Character character)
        {
            List<Item> inventory = character.Inventory; 

            if(inventory == null)
            {
                Console.WriteLine("There is nothing in here"); 
            }

            else
            {
                foreach (Item aItem in inventory)
                {
                    Console.WriteLine(aItem);
                }
            }
        }

       public void useItem(Area area)
       {
           
       }

       public void move (Area[] areas)
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
               Console.WriteLine(middleArea.Description); 
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

       protected void putItemnInInventory(Item item, PlayerCharacter character)
       {
           character.Inventory.Add(item);  
       }

       public void takeItem(Area area, PlayerCharacter character)
       {
            List <Item> items = area.Items; 

            int numberOfItems = area.Items.Count; 

            if (numberOfItems == 0)
            {
                Console.WriteLine("There is no Item here. Maybe someone picked it already up?");   
            }

            if (numberOfItems == 1)
            {
                foreach (Item aItem in items)
                {
                    Console.WriteLine(aItem); 
                    character.Inventory.Add(aItem); 
                    //character.putItemnInInventory(aItem, character); 
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
                    if (aItem.Name == userInput)
                    {
                        character.putItemnInInventory(aItem, character); 
                    }
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
