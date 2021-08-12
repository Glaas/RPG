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
            Player myPlayer = Init.GeneratePlayer();
            Enemy opponent = Init.GenerateEnemy();

            do
            {
                NextAction();

            } while (myPlayer.isAlive && opponent.isAlive);

            WriteLine($"Finished !\n" +
            $" {myPlayer.name} is {(myPlayer.isAlive ? Consts.alive : Consts.dead)} \n" +
            $" {opponent.name} is {(opponent.isAlive ? Consts.alive : Consts.dead)} \n" +
            "Thanks for playing !");

            void NextAction()
            {
                WriteLine(StoryBits.nextAction);
                var choice = ReadLine();
                choice = choice.ToLower();
                switch (choice)
                {
                    case "a":
                        WriteLine("Pressed A");
                        myPlayer.Attack(opponent, rnd.Next(6, 10));
                        break;
                    case "b":
                        WriteLine("Pressed B");
                        break;
                    case "c":
                        WriteLine("Pressed C");
                        myPlayer.Heal(rnd.Next(5, 10));
                        break;
                    case "init":
                        Init.StatsDisplay(myPlayer);
                        Init.StatsDisplay(opponent);
                        break;
                    default:
                        WriteLine("Not valid");
                        break;
                }
            }
        }
    }
    static class Init
    {
        public static Player GeneratePlayer()
        {
            Player player = new Player();
            WriteLine("Please enter your name and press Enter".Pastel(System.Drawing.Color.DarkOrange));
            player.name = Console.ReadLine();
            WriteLine($"Welcome {player.name.Pastel(Consts.GetNameColor(player))}! You're an adventurer, ready to fight with all your might ! \n\n");

            return player;
        }
        public static Enemy GenerateEnemy()
        {
            Enemy enemy = new Enemy();
            WriteLine($"An enemy has entered the battlefield ! Its name is {enemy.name.ToString().Pastel(Consts.GetNameColor(enemy))}");
            return enemy;
        }

        public static void StatsDisplay(Entity target)
        {
            WriteLine($" \t Entity name : {target.name.Pastel(Consts.GetNameColor(target))} \n" +
            $" \t {target.name.Pastel(Consts.GetNameColor(target))} max health : {target.maxHealth} \n".Pastel("#F46400") +
            $" \t {target.name.Pastel(Consts.GetNameColor(target))} current health : {target.CurrentHealth} \n".Pastel("#F46400") +
            $" \t {target.name.Pastel(Consts.GetNameColor(target))} is alive or dead : {(target.isAlive ? Consts.alive : Consts.dead)} \n".Pastel("#F46400"));


        }
    }
}

