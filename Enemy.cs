using System;

namespace RPG
{
    public class Enemy : Entity
    {
        public Enemy()
        {
            Random rnd = new Random();
            maxHealth = rnd.Next(15,25);
            CurrentHealth = maxHealth;
            isAlive = true;
            name = possibleNames[rnd.Next(0, possibleNames.Length)];
        }




    }
}