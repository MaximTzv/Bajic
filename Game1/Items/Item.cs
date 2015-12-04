using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    public abstract class Item
    {
        private string itemName;
        private int healingEffect; // potion gives a flat and instant increase, ex + 200 hp
        private int permenentDmgBoost; // items that give a small amount of damage, permenently , ex + 5dmg
        private int permenentDefBoost; // items that give a small amount of defense, permenently, ex + 10 def
        private int permenentHealthBoost; // items that give a small amount of healrth, permenently, ex + 10hp
    }
}
