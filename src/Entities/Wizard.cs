using System.Globalization;
namespace rpg_poo.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType, int CurrentHealth, int MaxHealth, int CurrentMagicPoints, int MaxMagicPoints)
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
            return this.Name + " Lançou mágia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou mágia super efetiva com bonus de " + Bonus;
            } else 
            {
                return this.Name + " Lançou uma mágina com força fraca com bonus de " + Bonus;
            }
        }
    }
}