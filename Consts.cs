using Pastel;
namespace RPG
{
    public static class Consts
    {
        public static string alive;
        public static string dead;
        public static string attack;
        public static string defend;
        public static string heal;
        static Consts()
        {
            alive = "alive".Pastel("#11E500");
            dead = "dead".Pastel("#E50000");
            attack = "attack".Pastel("c72705");
            defend = "defend".Pastel("ffff00");
            heal = "heal".Pastel("1bf325");
        }
    }
}