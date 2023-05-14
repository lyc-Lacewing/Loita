using LoitaMod.InfusionSystem;
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
        public static bool IsInfusion(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(InfusionItem));
        }
        public static bool IsSpell(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(SpellItem));
        }
        public static bool IsModifier(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(ModifierItem));
        }
        public static bool IsConfluxer(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(ConfluxerItem));
        }

        public static object[] GetTooltipArgs(this SpellItem spell)
        {
            SpellStats stats = spell.Stats;
            return new object[] {
                Language.GetText($"Mods.Loita.Items.{spell.GetType().Name}.Tooltip").Value,
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
}
