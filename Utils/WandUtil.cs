using Loita.WandSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loita.Utils
{
    internal static class WandUtil
    {
        public static object[] GetTooltipArgs(this WandBase wand)
        {
            WandStats stats = wand.Stats;
            return new object[] { };
        }
    }
}
