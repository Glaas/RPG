using System.Net;
using static System.Console;
namespace RPG
{
    public static class TurnManager
    {
        public static void NextAction(string choice)
        {
            choice = choice.ToUpper();
            switch (choice)
            {
                case "A":
                    WriteLine("Pressed A");
                    break;
                case "B":
                    WriteLine("Pressed B");
                    break;
                case "C":
                    WriteLine("Pressed C");
                    break;
                default:
                    WriteLine("Not valid");
                    break;
            }
        }
    }
}