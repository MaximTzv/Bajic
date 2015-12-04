using System;
using Game1.Interfaces;

namespace Game1
{
    public abstract class Character : IAttack, IDefend, IConsume, IUseMagic, IWalkable
    {
        private string charName;
        private int attackDamage;
        private int defensePower;
        private int health;

        public Character(string charName, int attackDamage, int defensePower, int health)
        {

        }

        public abstract void ConsumeItem();

        public abstract void Attack();

        public abstract void UseMagic();
    }
}
