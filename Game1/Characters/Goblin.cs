using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Characters
{
    public class Goblin : Character
    {
        private const string GoblinName = "Goblin";
        private const int GoblinCharAttackDamage = 150;
        private const int GoblinCharDefensePower = 30;
        private const int GoblinCharHealth = 120;

        public Goblin() 
            : base(GoblinName, GoblinCharAttackDamage, GoblinCharDefensePower, GoblinCharHealth)
        {
        }

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
    }
}
