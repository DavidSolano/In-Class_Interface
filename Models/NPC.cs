using System;

namespace Class_7.Models
{
    public class NPC : INpc
    {
        public string Name {get; set;}

        public NPC()
        {
            Name = "Bobby";
        }

        public void AskDialogue(ICombatant fighter)
        {
            Console.WriteLine($"hello {fighter.Name} could you spare some shmeckles for me? my children will starve otherwise.");
            Console.WriteLine("like gonzo beans");
            Console.WriteLine("gone forever type of thing.");
            Console.WriteLine($"would really appreciate it. {fighter.Name}");
        }

    }
}