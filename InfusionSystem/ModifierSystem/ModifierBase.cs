using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.InfusionSystem.ModifierSystem
{
    public class ModifierBase
    {
        public ModifierStats Stats = new ModifierStats();

        public ModifierBase Clone()
        {
            ModifierBase clone = (ModifierBase)MemberwiseClone();
            clone.Stats = Stats.Clone();
            return clone;
        }
    }
    public class ModifierStats
    {
        public StatModifier Damage = new StatModifier();
        public StatModifier CritChance = new StatModifier();
        public StatModifier CritDamage = new StatModifier();
        public StatModifier KnockBack = new StatModifier();
        public StatModifier Speed = new StatModifier();
        public StatModifier Scatter = new StatModifier();
        public StatModifier Delay = new StatModifier();
        public StatModifier Recharge = new StatModifier();
        public StatModifier ManaCost = new StatModifier();

        public ModifierStats Clone()
        {
            return (ModifierStats)MemberwiseClone();
        }
    }
}
