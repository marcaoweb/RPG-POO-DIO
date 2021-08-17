using System;
using rpg_poo.src.Entities;

namespace rpg_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Kgnight", 469, 749, 72,72);
            Wizard wizard = new Wizard("Jennica", 99, "White Wizard",325,601,474,482);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 29,574,89,89);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 106,385, 611,641);

            Console.WriteLine(arus);
            Console.WriteLine(ninja);
            Console.WriteLine(wizard);
            Console.WriteLine(blackWizard);
        }
    }
}
