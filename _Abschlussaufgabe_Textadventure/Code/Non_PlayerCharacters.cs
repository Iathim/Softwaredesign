using System;
using System.Collections.Generic;

namespace Code
{
     public class NPC : Character
    {
        public string Dialogue; 

        public string IfAttacked; 

        public NPC(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory, string _dialogue, string _ifAtacked)
        : base (_name, _hp, _damage, _isDead, _isPlayerCharacter, _inventory)
        {
            this.Name = _name; 
            this.HP = _hp; 
            this.Damage = _damage; 
            this.IsDead = _isDead; 
            this.IsPlayerCharacter = _isPlayerCharacter; 
            this.Inventory = _inventory;
            this.Dialogue = _dialogue;
            this.IfAttacked = _ifAtacked;   
        }

       public override void attack(PlayerCharacter defendingCharacter, Area area)
       {
           NPC attackingCharacter = area.NPC; 

            int playerHP = defendingCharacter.HP; 

           int remainingHP = damageOfAttack(defendingCharacter, attackingCharacter); 

           playerHP = remainingHP; 

            if (remainingHP <= 0)
            {
                defendingCharacter.IsDead = true;

                Console.WriteLine("Oh no. " + defendingCharacter.Name + ". You got killed by" + attackingCharacter.Name); 
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
           Console.WriteLine(attackingCharacter.Name + " goes in for an attack."); 

           int HP = defendingCharacter.HP; 

           int damage = attackingCharacter.Damage; 

           int newHP = HP - damage; 
           
           return newHP;
       }

       //public override void dropItem(Character character, Area area)
       public void dropItem(NPC character, Area area)
       {
           List<Item> inventory = character.Inventory; 

            foreach (Item aItem in inventory)
            {
                Console.WriteLine(character.Name + " dropped " + aItem + " into the area."); 

                area.Items.Add(aItem); 
            } 
       } 

       public override void talk(NPC character)
       {
           if ( character.IsDead == true)
           {
               Console.WriteLine("There is no one to talk to here. Maybe you could talk a bit to yourself and hear it echo of the walls?"); 
           }

           else
           {
                Console.WriteLine(character.Name + ": " + character.Dialogue);
           } 
       } 

       //public override void dies(Character character)
       public void dies(NPC character)
       {
           character.IsDead = true; 

           Console.WriteLine(character.Name + " collapses on the floor and vanishes in a cloud of smoke. Strange."); 
       }
    }
}
