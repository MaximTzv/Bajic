using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1.Characters
{
    public class MainHero : Character
    {
        private const string MainCharName = "MainHero";
        private const int MainCharAttackDamage = 200;
        private const int MainCharDefensePower = 50;
        private const int MainCharHealth = 300;

        public MainHero() 
            : base(MainCharName, MainCharAttackDamage, MainCharDefensePower, MainCharHealth)
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
