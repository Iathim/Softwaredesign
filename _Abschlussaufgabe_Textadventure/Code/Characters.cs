using System;
using System.Collections.Generic; 

namespace Code
{
    public abstract class Character
    {
       public string name; 
       public int HP; 
       public int damage; 
       public bool isDead; 
       public bool isPlayerCharacter; 
       public List<Item> inventory;

        public Character(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory)
        {
            this.name = _name; 
            this.HP = _hp; 
            this.damage = _damage; 
            this.isDead = _isDead; 
            this.isPlayerCharacter = _isPlayerCharacter; 
            this.inventory = _inventory; 
        }


       public abstract void attack(PlayerCharacter attackingCharacter, Area area);

       public abstract int damageOfAttack(PlayerCharacter attackingCharacter, NPC defendingCharacter); 

       //public abstract void dropItem(PlayerCharacter character, Area area); 

       public abstract void talk(NPC charakterToTalkTo);

       //public abstract void dies(Character character);  
    }
}
