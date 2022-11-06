using PokemonLike.classes;
using System.Security.Cryptography.X509Certificates;

namespace PokemonLike
{
    internal class Program
    {
        /*----------------------------------------------Fonctions----------------------------------------------*/
        //fonctions that will allow us to run the game properly

        /*-----------------------Pokemon starter selection-----------------------*/
        public static string StarterChoosing()//Return the name of the starter chosen by the player
        {
            Console.WriteLine("                                 ,'\\\r\n    _.----.        ____         ,'  _\\   ___    ___     ____\r\n_,-'       `.     |    |  /`.   \\,-'    |   \\  /   |   |    \\  |`.\r\n\\      __    \\    '-.  | /   `.  ___    |    \\/    |   '-.   \\ |  |\r\n \\.    \\ \\   |  __  |  |/    ,','_  `.  |          | __  |    \\|  |\r\n   \\    \\/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |\r\n    \\     ,-'/  /   \\    ,'   | \\/ / ,`.|         /  /   \\  |     |\r\n     \\    \\ |   \\_/  |   `-.  \\    `'  /|  |    ||   \\_/  | |\\    |\r\n      \\    \\ \\      /       `-.`.___,-' |  |\\  /| \\      /  | |   |\r\n       \\    \\ `.__,'|  |`-._    `|      |__| \\/ |  `.__,'|  | |   |\r\n        \\_.-'       |__|    `-._ |              '-.|     '-.| |   |\r\n                                `'                            '-._|");
            Console.WriteLine("Hello I'm the Professor Oak and I am going to help you through your journey in Kanto.\nHere, take one of these rare Pokémon !");
            Console.WriteLine("\nYou can select your Pokemon by pressing the following keys\n\n[1] - Bulbasaur\n[2] - Squirtle\n[3] - Charmander");//Pokemon starter selection line
            switch (Console.ReadLine())//Asking a key from the keyboard - each case will return the correct name for the player's strater
            {
                case "1" or "[1]"://Double check to make sure the player will enter the right gate
                    Console.Clear();//Clear the console for readability
                    Console.WriteLine("                                           /\r\n                        _,.------....___,.' ',.-.\r\n                     ,-'          _,.--\"        |\r\n                   ,'         _.-'              .\r\n                  /   ,     ,'                   `\r\n                 .   /     /                     ``.\r\n                 |  |     .                       \\.\\\r\n       ____      |___._.  |       __               \\ `.\r\n     .'    `---\"\"       ``\"-.--\"'`  \\               .  \\\r\n    .  ,            __               `              |   .\r\n    `,'         ,-\"'  .               \\             |    L\r\n   ,'          '    _.'                -._          /    |\r\n  ,`-.    ,\".   `--'                      >.      ,'     |\r\n . .'\\'   `-'       __    ,  ,-.         /  `.__.-      ,'\r\n ||:, .           ,'  ;  /  / \\ `        `.    .      .'/\r\n j|:D  \\          `--'  ' ,'_  . .         `.__, \\   , /\r\n/ L:_  |                 .  \"' :_;                `.'.'\r\n.    \"\"'                  \"\"\"\"\"'                    V\r\n `.                                 .    `.   _,..  `\r\n   `,_   .    .                _,-'/    .. `,'   __  `\r\n    ) \\`._        ___....----\"'  ,'   .'  \\ |   '  \\  .\r\n   /   `. \"`-.--\"'         _,' ,'     `---' |    `./  |\r\n  .   _  `\"\"'--.._____..--\"   ,             '         |\r\n  | .\" `. `-.                /-.           /          ,\r\n  | `._.'    `,_            ;  /         ,'          .\r\n .'          /| `-.        . ,'         ,           ,\r\n '-.__ __ _,','    '`-..___;-...__   ,.'\\ ____.___.'\r\n `\"^--'..'   '-`-^-'\"--    `-^-'`.''\"\"\"\"\"`.,^.`.--'");
                    ChoseIsRight("Bulbasaur","plant");
                    return "Bulbasaur";

                case "2" or "[2]":
                    Console.Clear();
                    Console.WriteLine("               _,........__\r\n            ,-'            \"`-.\r\n          ,'                   `-.\r\n        ,'                        \\\r\n      ,'                           .\r\n      .'\\               ,\"\".       `\r\n     ._.'|             / |  `       \\\r\n     |   |            `-.'  ||       `.\r\n     |   |            '-._,'||       | \\\r\n     .`.,'             `..,'.'       , |`-.\r\n     l                       .'`.  _/  |   `.\r\n     `-.._'-   ,          _ _'   -\" \\  .     `\r\n`.\"\"\"\"\"'-.`-...,---------','         `. `....__.\r\n.'        `\"-..___      __,'\\          \\  \\     \\\r\n\\_ .          |   `\"\"\"\"'    `.           . \\     \\\r\n  `.          |              `.          |  .     L\r\n    `.        |`--...________.'.        j   |     |\r\n      `._    .'      |          `.     .|   ,     |\r\n         `--,\\       .            `7\"\"' |  ,      |\r\n            ` `      `            /     |  |      |    _,-'\"\"\"`-.\r\n             \\ `.     .          /      |  '      |  ,'          `.\r\n              \\  v.__  .        '       .   \\    /| /              \\\r\n               \\/    `\"\"\\\"\"\"\"\"\"\"`.       \\   \\  /.''                |\r\n                `        .        `._ ___,j.  `/ .-       ,---.     |\r\n                ,`-.      \\         .\"     `.  |/        j     `    |\r\n               /    `.     \\       /         \\ /         |     /    j\r\n              |       `-.   7-.._ .          |\"          '         /\r\n              |          `./_    `|          |            .     _,'\r\n              `.           / `----|          |-............`---'\r\n                \\          \\      |          |\r\n               ,'           )     `.         |\r\n                7____,,..--'      /          |\r\n                                  `---.__,--.'");
                    ChoseIsRight("Squirtle","water");
                    return "Squirtle";

                case "3" or "[3]":
                    Console.Clear();
                    Console.WriteLine("              _.--\"\"`-..\r\n            ,'          `.\r\n          ,'          __  `.\r\n         /|          \" __   \\\r\n        , |           / |.   .\r\n        |,'          !_.'|   |\r\n      ,'             '   |   |\r\n     /              |`--'|   |\r\n    |                `---'   |\r\n     .   ,                   |                       ,\".\r\n      ._     '           _'  |                    , ' \\ `\r\n  `.. `.`-...___,...---\"\"    |       __,.        ,`\"   L,|\r\n  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \\\r\n-:..     `. `-..--_.,.<       `\"      / `.        `-/ |   .\r\n  `,         \"\"\"\"'     `.              ,'         |   |  ',,\r\n    `.      '            '            /          '    |'. |/\r\n      `.   |              \\       _,-'           |       ''\r\n        `._'               \\   '\"\\                .      |\r\n           |                '     \\                `._  ,'\r\n           |                 '     \\                 .'|\r\n           |                 .      \\                | |\r\n           |                 |       L              ,' |\r\n           `                 |       |             /   '\r\n            \\                |       |           ,'   /\r\n          ,' \\               |  _.._ ,-..___,..-'    ,'\r\n         /     .             .      `!             ,j'\r\n        /       `.          /        .           .'/\r\n       .          `.       /         |        _.'.'\r\n        `.          7`'---'          |------\"'_.'\r\n       _,.`,_     _'                ,''-----\"'\r\n   _,-_    '       `.     .'      ,\\\r\n   -\" /`.         _,'     | _  _  _.|\r\n    \"\"--'---\"\"\"\"\"'        `' '! |! /\r\n                            `\" \" -' ");
                    ChoseIsRight("Charmander","fire");
                    return "Charmander";

                case "42" or "[42]":
                    Console.Clear();
                    
                    Console.WriteLine("quu..__\r\n $$$b  `---.__\r\n  \"$$b        `--.                          ___.---uuudP\r\n   `$$b           `.__.------.__     __.---'      $$$$\"              .\r\n     \"$b          -'            `-.-'            $$$\"              .'|\r\n       \".                                       d$\"             _.'  |\r\n         `.   /                              ...\"             .'     |\r\n           `./                           ..::-'            _.'       |\r\n            /                         .:::-'            .-'         .'\r\n           :                          ::''\\          _.'            |\r\n          .' .-.             .-.           `.      .'               |\r\n          : /'$$|           .@\"$\\           `.   .'              _.-'\r\n         .'|$u$$|          |$$,$$|           |  <            _.-'\r\n         | `:$$:'          :$$$$$:           `.  `.       .-'\r\n         :                  `\"--'             |    `-.     \\\r\n        :##.       ==             .###.       `.      `.    `\\\r\n        |##:                      :###:        |        >     >\r\n        |#'     `..'`..'          `###'        x:      /     /\r\n         \\                                   xXX|     /    ./\r\n          \\                                xXXX'|    /   ./\r\n          /`-.                                  `.  /   /\r\n         :    `-  ...........,                   | /  .'\r\n         |         ``:::::::'       .            |<    `.\r\n         |             ```          |           x| \\ `.:``.\r\n         |                         .'    /'   xXX|  `:`M`M':.\r\n         |    |                    ;    /:' xXXX'|  -'MMMMM:'\r\n         `.  .'                   :    /:'       |-'MMMM.-'\r\n          |  |                   .'   /'        .'MMM.-'\r\n          `'`'                   :  ,'          |MMM<\r\n            |                     `'            |tbap\\\r\n             \\                                  :MM.-'\r\n              \\                 |              .''\r\n               \\.               `.            /\r\n                /     .:::::::.. :           /\r\n               |     .:::::::::::`.         /\r\n               |   .:::------------\\       /\r\n              /   .''               >::'  /\r\n              `',:                 :    .'\r\n                                   `:.:'");
                    Console.WriteLine("GREAT! You know the ultimate answer but wait... what is the question ?");
                    ChoseIsRight("Pikachu","electric");
                    return "Pikachu";
                default:
                    Console.Clear();
                    StarterChoosing();//If the player make a mistake the function is called 
                    return "";//Mandatory in a public static string function
            }
        }

        public static void ChoseIsRight(string pokemonName, string pokemonType)//Function for checking the player's decision
        {
            Console.WriteLine("\n"+pokemonName+"'s type is "+pokemonType+".\nDo you want "+pokemonName+ " as your starter pokemon ?\n[1] - Yes\n[2] - No");
            switch (Console.ReadLine())
            {
                case "yes" or "Yes" or "YES" or "1" or "[1]"://Making sure the player will enter the gate
                    Console.Clear();
                    Console.WriteLine("Your rare starter pokemon is now "+pokemonName+" !\n");
                    break;
                default:
                    Console.Clear();
                    StarterChoosing();
                    break;
            }
        }
        /*----------------------------------------------Main----------------------------------------------*/
        public static void Main(string[] args)
        {
            /*-----------------------Initialisation-----------------------*/
            bool game = true;//game must be on "true" to run the game
            Random random = new();//random variable initialisation for future usage
            string pokemonName = StarterChoosing();//Using the previous function to give a name to our pokemon
            PettedPokemon pokemonChosen = new(pokemonName);//Create the pokemon class with the name selected
            WildPokemon wildPokemon = new();//Create the wild pokemon for the fight in coming

            /*-----------------------Main loop-----------------------*/

            while (game && pokemonChosen.Alive)//game running and player's pokemon must be alive to run the game
            {
                bool fight = true;//fight must be on "true" to run the fighting sequence
                wildPokemon.Alive = true;//The pokemon Alive state must be restart to create a new random pokemon
                Console.WriteLine("You can choose between those 4 actions :\n[1] - Fight a wild pokemon\n[2] - Heal completely " + pokemonName + "\n[3] - See " + pokemonName + "'s statistics\n[4] - Leaving the game");
                switch (Console.ReadLine())
                {
                    case "1" or "[1]"://Fighting sequence
                        Console.Clear();
                        while (fight && wildPokemon.Alive)//Fighting sequence loop
                        {
                            if (wildPokemon.CurrentHealthPoints <= 0)
                            {
                                wildPokemon = new WildPokemon();//Create a new wild pokemon to fight when the previous one is beaten
                            }
                            Console.WriteLine("Fight against a wild " + wildPokemon.Name +"\n\nYou can choose between 3 actions :\n[1] - FIGHT " + wildPokemon.Name + "\n[2] - Use a potion and heal " + pokemonChosen.Name + "\n[3] - RUN");
                            switch (Console.ReadLine())//Allow the player to chose options in the fightingh sequence
                            {
                                case "1" or "[1]"://Fight phase - the pokemon's speed grants the first strike on the other one
                                    Console.Clear();
                                    if (wildPokemon.Speed > pokemonChosen.Speed)//The wildPokemon is faster than the player's pokemon and fights first
                                    {
                                        pokemonChosen.TakingDamages(wildPokemon.Attack);//Method on the object PettedPokemon to simulate an attack from the object WildPokemon
                                        if (pokemonChosen.Alive)//Making sure the player's pokemon is still alive to fight back the wild pokemon
                                        {
                                            wildPokemon.TakingDamages(pokemonChosen.Attack);
                                            if (!wildPokemon.Alive)
                                            {
                                                Console.WriteLine("Congratulations ! You won against " + wildPokemon.Name);
                                                pokemonChosen.LevelUp(random.Next(50, 100));//The player's pokemon can level up each time he beats a wild pokemon
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(wildPokemon.Name + " has beaten " + pokemonChosen.Name);
                                        }
                                    }
                                    else//The player's pokemon is faster than the wild pokemon and fights first
                                    {
                                        wildPokemon.TakingDamages(pokemonChosen.Attack);
                                        if (wildPokemon.Alive)//Making sure the wild pokemon is still alive to fight back the player's pokemon
                                        {
                                            pokemonChosen.TakingDamages(wildPokemon.Attack);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Congratulations ! You won against " + wildPokemon.Name);
                                            pokemonChosen.LevelUp(random.Next(50, 100));
                                        }
                                    }
                                    break;
                                case "2" or "[2]"://Healing sequence : using the method PettedPokemon.Potion()
                                    Console.Clear();
                                    pokemonChosen.Potion();//The player's pokemon can be healed in combat but can't fight 
                                    pokemonChosen.TakingDamages(wildPokemon.Attack);//The wild pokemon fight while the player's pokemon is healed
                                    break;
                                default://If the player don't want to fight, use a potion or just wants to run
                                    Console.Clear();
                                    if (random.Next(0, 100) > 8)//Run can fail
                                    {
                                        Console.WriteLine("You successfully ran!");
                                        wildPokemon.CurrentHealthPoints = 0;
                                        fight = false;//Ending the fight sequence
                                    }
                                    else
                                    {
                                        Console.WriteLine("You failed to run");
                                        pokemonChosen.TakingDamages(wildPokemon.Attack);
                                    }
                                    break;
                            }
                        }
                        break;
                    case "2" or "[2]"://Healing the player's pokemon to his maximum health
                        Console.Clear();
                        pokemonChosen.MaxPotion();//Method to heal the player's pokemon to his maximum health
                        break;
                    case "3" or "[3]"://Showing the statistics of the player's pokemon
                        Console.Clear();
                        pokemonChosen.ShowStatistics();//Method to show the statistic of the player's pokemon
                        break;
                    default://If the player wants to leave the game or press a wrong key he is warned
                        Console.Clear();
                        Console.WriteLine("Do you want to leave the game ?\n[1] - Yes\n[2] - No");
                        switch (Console.ReadLine())
                        {
                            case "yes" or "Yes" or "YES" or "1" or "[1]"://Making sure the player will enter the gate
                                Console.Clear();
                                Console.WriteLine("I'm sad to see you leaving Kanto ! See you soon");
                                game = false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("You still have a lot to discover here in Kanto\n");
                                game = true;
                                break;
                        }
                        break;
                }
            }
        }
    }
}