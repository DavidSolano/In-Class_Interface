namespace Class_7.Models
{
    public class Enemy : ICombatant
    {
        public string Name { get; set;}

        public Armor Armor { get; set; }
        
        public Weapon Weapon { get; set; }

        public Enemy()
        {
            Name = "Bob";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }
    }
}