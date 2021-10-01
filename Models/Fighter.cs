using System;

namespace Class_7.Models
{
    public class Fighter : ICombatant
    {
        public string Name {get; set;}

        public Armor Armor { get; set; }
        
        public Weapon Weapon { get; set; }

        public Fighter()
        {
            Name = "Roger";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack(ICombatant enemy)
        {
            if (this.Weapon.Power > enemy.Armor.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with his {this.Weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} blocks {this.Name} with his {enemy.Armor.Name}");
            }
        }

        public void Defend(ICombatant enemy)
        {
            
        }
    }
}