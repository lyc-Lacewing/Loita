using LoitaMod.InfusionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Items.Spells
{
    internal class TestSpell : SpellItem
    {
        public override void SetSpellDefaults()
        {
            Stats.Damage = 10;
            Stats.Scatter = Math.PI / 16;
            Stats.ManaCost = 4;
        }
    }
}
