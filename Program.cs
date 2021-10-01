using System;
using Class_7.Models;

namespace Class_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Fighter (instantiate object)
            // equip armor (assign value)
            // equip weapon (assign values)
            ICombatant fighter = new Fighter();
            fighter.Armor.Defense = 10;
            fighter.Weapon.Power = 10;
            
            //create enemy (instantiate object)
            // equip armor (assign value)
            // equip weapon (assign values)
            ICombatant enemy = new Enemy();
            enemy.Armor.Defense = 8;
            enemy.Weapon.Power = 10;

            // attack enemy (execute method)
            fighter.Attack(enemy);

            // IRepository repos = null;
            // var movie = repos.Get(5);

            INpc merchant = new NPC();
            merchant.AskDialogue(fighter);


        }
    }
}
