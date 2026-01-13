using System;

namespace Enemies
{
    /// <summary>
    /// Classe du Zombie
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Points de vie du Zombie
        /// </summary>
        public int health;

        /// <summary>
        /// Constructeur un Zombie vide
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Construire un Zombie avec une vie
        /// </summary>
        /// <param name="anHealth"></param>
        /// <exception cref="ArgumentException"></exception>
        public Zombie(int anHealth)
        {
            if (anHealth < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = anHealth;
        }

        /// <summary>
        /// Récuperer la vie du Zombie
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return health;
        }
    }
}

