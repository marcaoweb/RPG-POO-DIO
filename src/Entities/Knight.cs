namespace rpg_poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int CurrentHealth, int MaxHealth, int CurrentMagicPoints, int MaxMagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.CurrentHealth = CurrentHealth;
            this.MaxHealth = MaxHealth;
            this.CurrentMagicPoints = CurrentMagicPoints;
            this.MaxMagicPoints = MaxMagicPoints;
        }

        public override string Attack()
        {  
            return this.Name + " Atacou com sua espada";
        }
    }
}