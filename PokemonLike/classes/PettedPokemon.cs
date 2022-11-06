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
    public class PettedPokemon : Pokemon//PettedPokemon class, child of Pokemon
    {
        public int Level { get; set; }//Level attribute for the scaling of the player's pokemon
        public PettedPokemon (string initName)//Constructor
        {
            Random random = new();
            Level = 1;
            Name = initName;
            MaxHealthPoints = random.Next(100, 150);
            CurrentHealthPoints = MaxHealthPoints;
            Attack = random.Next(25, 50);
            Defense = random.Next(8, 18);
            Speed = random.Next(15, 25);
            
        } 
        public override void ShowStatistics()//Override the Pokemon class method to show more stats like Level
        {
            Console.WriteLine(Name + " statistics'" +
                "\n\n\tHealth points : " + CurrentHealthPoints +" HP / "+ MaxHealthPoints +" HP"+
                "\n\tAttack : " + Attack +
                "\n\tDefense : " + Defense +
                "\n\tSpeed : " + Speed +
                "\n\tLevel : " + Level +
                "\n\tExperience : " + CurrentExperience+" xp / "+MaxExperience+" xp\n");
        }
        public void LevelUp(int experienceEarned)//Method to allow scaling : the player's pokemon earn experience and level up
        {
            CurrentExperience += experienceEarned;
            if (CurrentExperience >= MaxExperience)
            {
                CurrentExperience -= MaxExperience;
                MaxExperience *=2 ;
                Level += 1;
                MaxHealthPoints += 3;
                CurrentHealthPoints = MaxHealthPoints;
                Attack += 1;
                Defense += 1;
                Speed += 1;
                Console.WriteLine(Name + " has earned "+experienceEarned+" xp and has leveled up. He is now at the level "+Level+" and needs "+(MaxExperience - CurrentExperience)+" xp to reach level "+(Level+1) + "\n");
            }
            else
            {
                Console.WriteLine(Name + " has earned " + experienceEarned + " xp. He needs "+(MaxExperience-CurrentExperience)+" xp to reach level "+(Level+1)+"\n");
            }
        }
    }
}
