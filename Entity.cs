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
        public string[] possibleNames = { "Gary", "Barry", "Jerry", "Tommy", "Henry", "Helvecy", "Lucy", "Aubrey", "Ivy" };
        Random rnd = new Random();

        private int currentHealth;
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (value > maxHealth) currentHealth = maxHealth;
                else currentHealth = value;
                
                if (currentHealth <= 0) isAlive = false;

            }
        }

        public Entity()
        {
            name = "Default name of " + this.GetType();
        }

        public void Attack(Entity target, int dmgAmount)
        {
            target.CurrentHealth -= dmgAmount;
            System.Console.WriteLine($"{name}".Pastel(Consts.GetNameColor(this)) + " attacked".Pastel(System.Drawing.Color.Red) + $" enemy {target.name.Pastel(Consts.GetNameColor(target))} and inflicted {dmgAmount.ToString().Pastel(System.Drawing.Color.Red)} amounts of damage.");
        }
        public void Heal(int amount)
        {
            if (CurrentHealth + amount > maxHealth)
            {
                Console.WriteLine("Health was already at it's maximum !");
                return;
            }
            CurrentHealth += amount;
            System.Console.WriteLine($"You healed yourself and recovered {amount.ToString().Pastel(System.Drawing.Color.Chartreuse)} points of health !");
        }
    }
}