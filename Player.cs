using System;
namespace RPG
{
    public class Player : Entity
    {
        public Player()
        {
            Random rnd = new Random();
            maxHealth = rnd.Next(25,35);
            isAlive = true;
            CurrentHealth = maxHealth;
        }

        
    }
}