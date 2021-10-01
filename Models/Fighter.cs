using System;

namespace Battle.Models
{
    public class Fighter : ICombatant
    {
        public Fighter()
        {
            Name = "Fighter";
            Armor = new Armor();
            Weapon = new Weapon();
            Spell = new Spell();
        }

        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public Spell Spell {get; set;}

        public void Attack(ICombatant enemy)
        {
            if (Weapon.Power > enemy.Armor.Defense)
                Console.WriteLine($"{Name} attacks {enemy.Name} with his {Weapon.Name}");
            else
                Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Armor.Name}");
        }

        public void Cast(ICombatant enemy)
        {
            if(Spell.Power > enemy.Armor.Defense)
                Console.WriteLine($"{Name} attacks {enemy.Name} with {Spell.Name}");
            else
                Console.WriteLine($"{enemy.Name} deflects {Spell.Name}");
        }

        public void Defend(ICombatant enemy)
        {
        }
    }
}