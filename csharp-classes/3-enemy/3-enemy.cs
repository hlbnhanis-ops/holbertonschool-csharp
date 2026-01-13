using System;

namespace Enemies
{
    public class Zombie
    {
        public int health;

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int anHealth)
        {
            if (anHealth < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = anHealth;
        }

        public int GetHealth()
        {
            return health;
        }
    }
}

