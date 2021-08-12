using System;
using static System.Console;
using Pastel;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Player myPlayer = new Player();
            WriteLine("Please enter your name and press Enter".Pastel("#00E2F4"));
            myPlayer.name = Console.ReadLine();
            Enemy opponent = Init.GenerateEnemy();

            Init.StatsDisplay(myPlayer);
            Init.StatsDisplay(opponent);
            Console.ResetColor();

            WriteLine(StoryBits.intro);
            WriteLine(StoryBits.nextAction);
            while (myPlayer.isAlive && opponent.isAlive)
            {
                var choice = ReadLine();
                TurnManager.NextAction(choice);
                myPlayer.Attack(opponent, 5);
                opponent.Attack(myPlayer, 5);
            }
            WriteLine($"Finished !\n" +
            $" {myPlayer.name} is {(myPlayer.isAlive ? Consts.alive : Consts.dead)} \n" +
            $" {opponent.name} is {(opponent.isAlive ? Consts.alive : Consts.dead)} \n" +
            "Thanks for playing !");

        }
    }
    static class Init
    {
        public static Enemy GenerateEnemy()
        {
            WriteLine("Enemy generated");
            return new Enemy();
        }

        public static void StatsDisplay(Entity target)
        {
            WriteLine($" \t Entity name : {target.name} \n".Pastel("#F46400") +
            $" \t Entity max health : {target.maxHealth} \n".Pastel("#F46400") +
            $" \t Entity current health : {target.CurrentHealth} \n".Pastel("#F46400") +
            $" \t Entity is alive or dead : {(target.isAlive ? Consts.alive : Consts.dead)} \n".Pastel("#F46400"));

        }
    }
}
