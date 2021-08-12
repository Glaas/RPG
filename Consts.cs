using Pastel;
namespace RPG
{
    public static class Consts
    {
        public static string alive;
        public static string dead;
        public static string attack;
        public static string defend;
        public static string inspect;

        public static string heal;
        static Consts()
        {
            alive = "alive".Pastel(System.Drawing.Color.Lime);
            dead = "dead".Pastel(System.Drawing.Color.Red);
            attack = "attack".Pastel(System.Drawing.Color.Red);
            defend = "defend".Pastel(System.Drawing.Color.Yellow);
            inspect = "inspect".Pastel(System.Drawing.Color.Yellow);
            heal = "heal".Pastel(System.Drawing.Color.Chartreuse);
        }
        public static System.Drawing.Color GetNameColor<T>(T target)
        {
            if (target is Player)
            {
                return System.Drawing.Color.Coral;
            }
            else if (target is Enemy)
            {
                return System.Drawing.Color.SlateBlue;
            }
            else return System.Drawing.Color.Magenta;
        }
    }
}