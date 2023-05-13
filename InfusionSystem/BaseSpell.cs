using Loita.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace Loita.InfusionSystem
{
    internal abstract class BaseSpell : BaseInfusion
    {
        public LocalizedText Description => this.GetLocalization(nameof(Description));

        public SpellStats Stats = new SpellStats();

        public virtual void SetSpellDefaults()
        {
            
        }

        public override LocalizedText Tooltip => Language.GetOrRegister("Mods.Loita.Spells.Tooltip").WithFormatArgs(this.GetTooltipArgs()); //TODO proper tooltip
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
        public int ProjID = -1;
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
        public float Speed = 8;
        /// <summary>
        /// Scatter of the spell, if applicable.
        /// </summary>
        public float Scatter = 0;

        // In a Sequence
        /// <summary>
        /// Delay between cast of this spell and cast of the next spell.
        /// </summary>
        public int Delay = 12;
        /// <summary>
        /// Recharge time added by the spell to the wand.
        /// </summary>
        public int Recharge = 12;
        /// <summary>
        /// Mana cost of the spell.
        /// </summary>
        public int ManaCost = 1;

        public SpellStats Clone()
        {
            SpellStats clone = new SpellStats();
            clone.Time = Time;
            clone.ProjID = ProjID;
            clone.Damage = Damage;
            clone.DamageType = DamageType;
            clone.CritChance = CritChance;
            clone.KnockBack = KnockBack;
            clone.Speed = Speed;
            clone.Scatter = Scatter;
            clone.Delay = Delay;
            clone.Recharge = Recharge;
            clone.ManaCost = ManaCost;
            return clone;
        }
    }
}
