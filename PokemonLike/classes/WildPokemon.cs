using PokemonLike.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonLike.classes
{
    public class WildPokemon : Pokemon//WildPokemon class, child of Pokemon
    {
        private readonly string[] RandomNames = { "Caterpie", "Weedle", "Pidgey", "Rattata", "Spearow", "Ekans", "Sandshrew", "Nidoran", "Vulpix", "Zubat","Mew","Mewtwo","MewThree","Dratini" };

        public WildPokemon()//Constructor
        {
            Random random = new();//Allowing random stats for the wild pokemon iteration
            Name = RandomNames[random.Next(0, 14)];//Choosing a name from the array for the wild pokemon
            MaxHealthPoints = random.Next(70, 100);
            CurrentHealthPoints = MaxHealthPoints;
            Attack = random.Next(20, 40);
            Defense = random.Next(8, 18);
            Speed = random.Next(8, 26);
        }
    }
}
