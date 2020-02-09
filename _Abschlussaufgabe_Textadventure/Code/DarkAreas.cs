using System;
using System.Collections.Generic; 

namespace Code
{
    public class DarkArea : Area
    { 
        public bool isBright; 
        public Item keyItem; 
        public string descriptionWhenBright; 

        public DarkArea (string _description, List<Item> _items, NPC _NPC, string _type, string _position, bool _isActualArea, bool _isBright, Item _keyItem, string _descriptionWhenBright)
        : base (_description, _items, _NPC, _type, _position, _isActualArea)
        {
            this.description = _description; 
            this.items = _items; 
            this.NPC = _NPC; 
            this.type = _type;
            this.position = _position;
            this.isActualArea = _isActualArea;  
            this.isBright = _isBright; 
            this.keyItem = _keyItem; 
            this.descriptionWhenBright = _descriptionWhenBright; 
        }


        public void lightenUp(Item keyItem, DarkArea area, PlayerCharacter character)
        {
            if(keyItem == area.keyItem)
            {
                area.isBright = false; 
                Console.WriteLine(area.descriptionWhenBright); 
            }

            else 
            {
                Console.WriteLine("You are still wrapped in darkness and you accedently stapped your toe. Ouch.");
                Console.WriteLine("Try something more useful"); 

                int damage = 5; 
                character.HP = character.HP - damage; 

                if (character.HP <= 0)
                {
                    character.dies(character); 
                }
            }
        }
    }
}
