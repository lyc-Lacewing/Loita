using Loita.InfusionSystem;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace Loita.Utils
{
    internal static class InfusionUtil
    {
        public static bool IsInfusion(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(BaseInfusion));
        }
        public static bool IsSpell(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(BaseSpell));
        }
        public static bool IsModifier(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(BaseModifier));
        }
        public static bool IsConfluxer(this ModItem item)
        {
            return item.GetType().IsSubclassOf(typeof(BaseConfluxer));
        }

        public static object[] GetTooltipArgs(this BaseSpell spell)
        {
            SpellStats stats = spell.Stats;
            return new object[] { spell.GetType().ToString(), stats.Damage, stats.DamageType, stats.CritChance, stats.KnockBack, stats.Scatter, stats.ManaCost, stats.Delay, stats.Recharge };
        }
    }
}
