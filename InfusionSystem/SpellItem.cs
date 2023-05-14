using Loita.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace Loita.InfusionSystem
{
    public abstract class SpellItem : InfusionItem
    {

        public SpellStats Stats = new SpellStats();

        public virtual void SetSpellDefaults()
        {
            
        }

        public override ModItem Clone(Item newEntity)
        {
            SpellItem clone = (SpellItem)base.Clone(Item);
            clone.Stats = Stats.Clone();
            return clone;
        }
        public override LocalizedText Tooltip => Language.GetOrRegister("Mods.Loita.Spells.Tooltip").WithFormatArgs(this.GetTooltipArgs());
        public override void SetDefaults()
        {
            base.SetDefaults();
            SetSpellDefaults();
        }
    }

    public class SpellStats
    {
        // The Spell itself
        /// <summary>
        /// Duration of the spell.
        /// </summary>
        public int Time = 60;
        /// <summary>
        /// Projectile used by the spell use, -1 for none.
        /// </summary>
        public int[] ProjIDs = new int[] { };
        /// <summary>
        /// Damage of the spell.
        /// </summary>
        public int Damage = 0;
        /// <summary>
        /// Type of damage of the spell.
        /// </summary>
        public DamageClass DamageType = DamageClass.Magic;
        /// <summary>
        /// Critical strike chance of the spell.
        /// </summary>
        public int CritChance = 4;
        /// <summary>
        /// Knock back of the spell.
        /// </summary>
        public float KnockBack = 1;
        /// <summary>
        /// Speed of the spell, if applicable.
        /// </summary>
        public float Speed = 4;
        /// <summary>
        /// Scatter of the spell, if applicable.
        /// </summary>
        public double Scatter = 0;

        // In a Sequence
        /// <summary>
        /// Delay between cast of this spell and cast of the next spell.
        /// </summary>
        public int Delay = 6;
        /// <summary>
        /// Recharge time added by the spell to the wand.
        /// </summary>
        public int Recharge = 6;
        /// <summary>
        /// Mana cost of the spell.
        /// </summary>
        public int ManaCost = 1;

        public SpellStats Clone()
        {
            SpellStats clone = (SpellStats)MemberwiseClone();
            clone.ProjIDs = (int[])ProjIDs.Clone();
            return clone;
        }
    }
}
