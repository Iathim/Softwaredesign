using System;
using System.Collections.Generic; 

namespace Code
{
    public class DarkArea : Area
    { 
        public bool IsDark; 
        public Item KeyItem; 
        public string DescriptionWhenBright; 

        public DarkArea (string _description, List<Item> _items, NPC _NPC, string _type, string _position, bool _isCurrentArea, bool _isBright, Item _keyItem, string _descriptionWhenBright)
        : base (_description, _items, _NPC, _type, _position, _isCurrentArea)
        {
            this.Description = _description; 
            this.Items = _items; 
            this.NPC = _NPC; 
            this.Type = _type;
            this.Position = _position;
            this.IsCurrentArea = _isCurrentArea;  
            this.IsDark = _isBright; 
            this.KeyItem = _keyItem; 
            this.DescriptionWhenBright = _descriptionWhenBright; 
        }


        public void lightenUp(Item keyItem, DarkArea area, PlayerCharacter character)
        {
            if(keyItem == area.KeyItem)
            {
                area.IsDark = true; 
                Console.WriteLine(area.DescriptionWhenBright); 
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
