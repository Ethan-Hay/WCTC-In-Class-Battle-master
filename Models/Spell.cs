namespace Battle.Models
{
    public class Spell
    {
        public Spell()
        {
            Name = "Spell";
        }

        public string Name { get; set; }
        public int Power { get; set; }
    }
}