namespace Class_7.Models
{
    public interface INpc
    {
        public string Name { get; set; }

        void AskDialogue(ICombatant fighter);
    }
}