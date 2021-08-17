using System;
namespace rpg_poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int CurrentHealth, int MaxHealth, int CurrentMagicPoints, int MaxMagicPoints)
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
            return base.Attack();
        }


    }
}