using System;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casion. Let's start by telling me your name");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money would you like to begin with?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to join a game of 21 right now?," + playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to enjoy the rest of the Casino! Bye!");
            Console.ReadLine();


        }
    }  

}


