using System;
using System.Collections.Generic; 

namespace Code
{
    public abstract class Character
    {
       public string Name; 
       public int HP; 
       public int Damage; 
       public bool IsDead; 
       public bool IsPlayerCharacter; 
       public List<Item> Inventory;

        public Character(string _name, int _hp, int _damage, bool _isDead, bool _isPlayerCharacter, List<Item> _inventory)
        {
            this.Name = _name; 
            this.HP = _hp; 
            this.Damage = _damage; 
            this.IsDead = _isDead; 
            this.IsPlayerCharacter = _isPlayerCharacter; 
            this.Inventory = _inventory; 
        }


       public abstract void attack(PlayerCharacter attackingCharacter, Area area);

       public abstract int damageOfAttack(PlayerCharacter attackingCharacter, NPC defendingCharacter); 

       //public abstract void dropItem(PlayerCharacter character, Area area); 

       public abstract void talk(NPC charakterToTalkTo);

       //public abstract void dies(Character character);  
    }
}
