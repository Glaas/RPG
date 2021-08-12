using System.Data;
using System;
using Pastel;

namespace RPG
{
    public class Entity
    {
        public string name = "Default name";
        public int maxHealth = 30;
        public bool isAlive = true;
        public string[] possibleNames = { "Gary", "Barry", "Jerry", "Tommy" };
        Random rnd = new Random();

        private int currentHealth;
        public int CurrentHealth
        {
            get
            {
                if (currentHealth <= 0)
                {
                    isAlive = false;
                }
                if (currentHealth > maxHealth)
                {
                    currentHealth = maxHealth;
                    Console.WriteLine("current health was above maxHealth, clamped it");
                }
                return currentHealth;
            }
            set { currentHealth = value; }
        }

        public Entity()
        {
            name = "Default name of " + this.GetType();
        }

        public void Attack(Entity target, int dmgAmount)
        {
            target.CurrentHealth -= dmgAmount;
            System.Console.WriteLine($"{name} attacked enemy {target.name} and inflicted {dmgAmount} amounts of damage.");
        }
        public void Heal(int amount)
        {
            currentHealth += amount;

        }
    }
}