using LoitaMod.InfusionSystem;
using LoitaMod.InfusionSystem.ConfluxerSystem;
using LoitaMod.InfusionSystem.ModifierSystem;
using LoitaMod.InfusionSystem.SpellSystem;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualBasic;
using Microsoft.Xna.Framework.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace LoitaMod.Utils
{
    public static class InfusionUtil
    {
        public static bool IsInfusion(this ModItem modItem)
        {
            return modItem.GetType().IsSubclassOf(typeof(InfusionItem));
        }
        public static bool IsSpell(this ModItem modItem)
        {
            return modItem.GetType().IsSubclassOf(typeof(SpellItem));
        }
        public static bool IsModifier(this ModItem modItem)
        {
            return modItem.GetType().IsSubclassOf(typeof(ModifierItem));
        }
        public static bool IsConfluxer(this ModItem modItem)
        {
            return modItem.GetType().IsSubclassOf(typeof(ConfluxerItem));
        }
        public static InfusionClass GetInfusionClass(ModItem modItem)
        {
            if (modItem.GetType().IsSubclassOf(typeof(SpellBase)))
            {
                return InfusionClass.Spell;
            }
            if (modItem.GetType().IsSubclassOf(typeof(ModifierBase)))
            {
                return InfusionClass.Modifier;
            }
            if (modItem.GetType().IsSubclassOf(typeof(ConfluxerBase)))
            {
                return InfusionClass.Confluxer;
            }
            return InfusionClass.None;
        }

        public static object[] GetTooltipArgs(this SpellItem item)
        {
            SpellStats stats = item.Spell.Stats;
            return new object[] {
                Language.GetText($"Mods.Loita.Items.{item.GetType().Name}.Tooltip").Value,
                stats.Damage,
                stats.DamageType.DisplayName,
                stats.CritChance,
                stats.KnockBack,
                stats.Scatter.RadToDeg(),
                stats.ManaCost,
                stats.Delay.TickToSecond().ToSigned(),
                stats.Recharge.TickToSecond().ToSigned() };
        }
    }
    public enum InfusionClass
    {
        None,
        Spell,
        Modifier,
        Confluxer
    }
}
