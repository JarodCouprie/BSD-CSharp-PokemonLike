/// Inital class allowing us to create the wild pokemon and the petted pokemon classes

namespace PokemonLike.classes
{ 
    public class Pokemon
    {
        public string Name { get; set; }
        public int MaxHealthPoints { get; set; }//Setting the maximum health
        public int CurrentHealthPoints { get; set; }//Setting the current health to make the game easier and allow scaling
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public bool Alive { get; set; } = true;
        public int MaxExperience { get; set; }//Setting the maximum experience
        public int CurrentExperience { get; set; }//Setting the current experience to make the game easier and allow scaling

        public Pokemon()//Default constructor to allow initialisation for the childs
        {
            Name = "Pokemon";
            MaxHealthPoints = 100;
            CurrentHealthPoints = MaxHealthPoints;
            Attack = 10;
            Defense = 10;
            Speed = 10;
            MaxExperience = 100;
            CurrentExperience = 0;
        }

        public void TakingDamages(int pokemonAttack)//Method to take damages
        {
            CurrentHealthPoints -= pokemonAttack - Defense;//The pokemon's defense blocks damages
            if (CurrentHealthPoints <= 0)//If a pokemon has no health points the pokemon is beaten
            {
                CurrentHealthPoints = 0;
                Console.WriteLine(Name + " has been beaten.");
                Alive = false;
            }
            else if(CurrentHealthPoints >= MaxHealthPoints)//A pokemon can resist to an attack but can't get more health than the maximum health
            {
                CurrentHealthPoints = MaxHealthPoints;
                Console.WriteLine(Name + " is resisting to the attack. He didn't lose any HP");
            }
            else
            {   
                Console.WriteLine(Name + " took " + (pokemonAttack-Defense) + " damages. He has "+CurrentHealthPoints + " HP / "+MaxHealthPoints+" HP.\n");
            }

        }

        public void Potion()//Healing a pokemon but can't heal more than the maximum health
        {
            int heal = 50;
            CurrentHealthPoints += heal;
            if (CurrentHealthPoints > MaxHealthPoints)
            {
                heal -= (CurrentHealthPoints - MaxHealthPoints);
                CurrentHealthPoints = MaxHealthPoints;
                Console.WriteLine(Name + " has been fully healed for " + heal + " HP. He now has " + CurrentHealthPoints + " HP.");
            }
            else
            {
                Console.WriteLine(Name + " has been healed for " + heal + " HP. He now has " + CurrentHealthPoints + " HP.");
            }
        }
        public void MaxPotion()//Healing a pokemon to his maximum health
        {
            CurrentHealthPoints = MaxHealthPoints;
            Console.WriteLine(Name + " has been fully healed. He now has " + CurrentHealthPoints + " HP.");
        }

        public virtual void ShowStatistics()//Showing the statistics of a pokemon
        {
            Console.WriteLine(Name + " statistics'"+
                "\n\tHealth points : "+ CurrentHealthPoints+
                " / "+MaxHealthPoints+" HP"+
                "\n\tAttack : " + Attack+
                "\n\tDefense : " + Defense+
                "\n\tSpeed : " + Speed+"\n");
        }

    }
}