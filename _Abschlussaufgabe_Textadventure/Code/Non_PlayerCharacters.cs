using System;
using System.Collections.Generic;

namespace Code
{
     public class NPC : Character
    {
        public string dialogue; 

        public NPC(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory, string _dialogue)
        : base (_name, _hp, _damage, _isDead, _isPlayerCharacter, _inventory)
        {
            this.name = _name; 
            this.HP = _hp; 
            this.damage = _damage; 
            this.isDead = _isDead; 
            this.isPlayerCharacter = _isPlayerCharacter; 
            this.inventory = _inventory;
            this.dialogue = _dialogue;  
        }

       public override void attack(PlayerCharacter attackingCharacter, NPC defendingCharacter, Area area)
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

       public override int damageOfAttack(PlayerCharacter defendingCharacter, NPC attackingCharacter)
       {
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
                Console.WriteLine(character.dialogue);
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
