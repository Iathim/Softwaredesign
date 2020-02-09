using System;
using System.Collections.Generic;

namespace Code
{
     public class NPC : Character
    {
        public string dialogue; 

        public string ifAttacked; 

        public NPC(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory, string _dialogue, string _ifAtacked)
        : base (_name, _hp, _damage, _isDead, _isPlayerCharacter, _inventory)
        {
            this.name = _name; 
            this.HP = _hp; 
            this.damage = _damage; 
            this.isDead = _isDead; 
            this.isPlayerCharacter = _isPlayerCharacter; 
            this.inventory = _inventory;
            this.dialogue = _dialogue;
            this.ifAttacked = _ifAtacked;   
        }

       public override void attack(PlayerCharacter defendingCharacter, Area area)
       {
           NPC attackingCharacter = area.NPC; 

            int playerHP = defendingCharacter.HP; 

           int remainingHP = damageOfAttack(defendingCharacter, attackingCharacter); 

           playerHP = remainingHP; 

            if (remainingHP <= 0)
            {
                defendingCharacter.isDead = true;

                Console.WriteLine("Oh no. " + defendingCharacter.name + ". You got killed by" + attackingCharacter.name); 
                Console.WriteLine("GAME OVER"); 
                Console.WriteLine("The Game does quit now."); 

                Commands.quitGame();
            }

            else 
            {
                Console.WriteLine("Your remaining HP are " + remainingHP); 
            }
       }

       public override int damageOfAttack(PlayerCharacter defendingCharacter, NPC attackingCharacter)
       {
           Console.WriteLine(attackingCharacter.name + " goes in for an attack."); 

           int HP = defendingCharacter.HP; 

           int damage = attackingCharacter.damage; 

           int newHP = HP - damage; 
           
           return newHP;
       }

       //public override void dropItem(Character character, Area area)
       public void dropItem(NPC character, Area area)
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
                Console.WriteLine(character.name + ": " + character.dialogue);
           } 
       } 

       //public override void dies(Character character)
       public void dies(NPC character)
       {
           character.isDead = true; 

           Console.WriteLine(character.name + " collapses on the floor and vanishes in a cloud of smoke. Strange."); 
       }
    }
}
