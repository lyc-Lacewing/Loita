using LoitaMod.Content.Spells;
using LoitaMod.InfusionSystem.SpellSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Content.Items.Spells
{
    public class TestSpellItem : SpellItem
    {
        public override void SetSpell()
        {
            Spell = Spell.InstanceSpell<TestSpell>();
        }
    }
}
