namespace rpg_poo.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int CurrentHealth, int MaxHealth, int CurrentMagicPoints, int MaxMagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.CurrentHealth = CurrentHealth;
            this.MaxHealth = MaxHealth;
            this.CurrentMagicPoints = CurrentMagicPoints;
            this.MaxMagicPoints = MaxMagicPoints;
        }

        public Hero() {}

        public string Name;
        public int Level;
        public string HeroType;
        public int MaxHealth;
        public int CurrentHealth;
        public int MaxMagicPoints;
        public int CurrentMagicPoints;

        public override string ToString()
        {
            return this.Name + 
                   " Level " + this.Level +
                   " " + this.HeroType + 
                   " HP " + this.CurrentHealth + "/" + this.MaxHealth +
                   " MP " + this.CurrentMagicPoints + "/" + this.MaxMagicPoints;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou";
        }

    }
}