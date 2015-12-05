using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Characters
{
    public class Boss : Character
    {
        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void ConsumeItem()
        {
            throw new NotImplementedException();
        }

        public override void UseMagic()
        {
            throw new NotImplementedException();
        }

        public Boss(string charName, int attackDamage, int defensePower, int health) : base(charName, attackDamage, defensePower, health)
        {
        }
    }
}
