/*
 * Haunted Home
 * by Zack Frey, October 2021
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */


using System;

namespace HauntedHome
{

    public static class Game
    {
        // initializes a basic empty variable
        static string CharacterName = "";

        public static void StartGame()
        {
            // sets a title for the game, check this on a Windows system
            Console.Title = "Haunted Home Alpha";
            Console.WriteLine("Are you prepared to embark upon the most terrifying adventure of your life?");
            NameCharacter();
        }

        static void NameCharacter()
        {
            //reads input for player name
            Console.WriteLine("But first, we have not been introduced. What is your name, my unfortunate friend?");
            CharacterName = Console.ReadLine();

            //confirms input
            Console.WriteLine("It is nice to meet you, " + CharacterName + ". A shame our acquaintance will be cut so short..");
            Console.ReadKey();
        }

    }

    class Item
    {

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Game.StartGame();
            Console.ReadKey();
            

        }
    }

}
