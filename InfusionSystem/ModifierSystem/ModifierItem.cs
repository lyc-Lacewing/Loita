using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoitaMod.InfusionSystem;
using Terraria.ID;

namespace LoitaMod.InfusionSystem.ModifierSystem
{
    public abstract class ModifierItem : InfusionItem
    {
        public ModifierStats Stats = new ModifierStats();
        public ModifierActions Actions = new ModifierActions();

        public virtual void SetModifierDefaults()
        {

        }
        public override string Texture => $"Terraria/Images/Buff_{BuffID.NebulaUpMana3}";
        public override void SetDefaults()
        {
            base.SetDefaults();
            SetModifierDefaults();
        }
        public override ModItem Clone(Item newEntity)
        {
            ModifierItem clone = (ModifierItem)MemberwiseClone();
            clone.Stats = Stats.Clone();
            clone.Actions = Actions.Clone();
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
    public class ModifierActions
    {
        public ModifierActions Clone()
        {
            return (ModifierActions)MemberwiseClone();
        }
        public virtual void ModifyProjectiles(Projectile[] projectiles)
        {

        }
    }
}
