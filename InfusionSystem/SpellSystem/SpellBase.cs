using LoitaMod.CastingSystem;
using LoitaMod.InfusionSystem.ModifierSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LoitaMod.InfusionSystem.ModifierSystem.ModifierBase;

namespace LoitaMod.InfusionSystem.SpellSystem
{
    public class SpellBase
    {
        public SpellStats Stats = new SpellStats();

        public SpellBase Clone()
        {
            SpellBase clone = (SpellBase)MemberwiseClone();
            clone.Stats = Stats.Clone();
            return clone;
        }

        public bool RegisterLoitaHook(LoitaHook type, Action<Loita> hook)
        {
            return Loita.SpellHooks.TryAdd((type, this), hook);
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
            return (SpellStats)MemberwiseClone();
        }
    }
}
