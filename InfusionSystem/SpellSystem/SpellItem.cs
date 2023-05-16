using LoitaMod.CastingSystem;
using LoitaMod.InfusionSystem;
using LoitaMod.InfusionSystem.ModifierSystem;
using LoitaMod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace LoitaMod.InfusionSystem.SpellSystem
{
    public abstract class SpellItem : InfusionItem
    {
        public Spell Spell;
        public abstract void SetSpell();

        public virtual void SetSpellDefaults() { }

        public override LocalizedText Tooltip => Language.GetOrRegister("Mods.Loita.Spells.Tooltip").WithFormatArgs(this.GetTooltipArgs());
        public override void SetDefaults()
        {
            base.SetDefaults();
            SetSpell();
            SetSpellDefaults();
        }
        public override ModItem Clone(Item newEntity)
        {
            SpellItem clone = (SpellItem)base.Clone(Item);
            clone.Spell = Spell.Clone();
            return clone;
        }
    }
}
