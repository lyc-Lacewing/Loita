using Loita.InfusionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loita.WandSystem
{
    internal class Caster
    {
        public static void ActivateInfusions(Player player, Item item)
        {
            if (!item.TryGetGlobalItem(out WandBase wand) || !player.TryGetModPlayer(out LoitaPlayer loita))
            {
                return;
            }
            loita.Sequence.Clear();
            foreach (Item infusion in wand.Infusions.Embeds)
            {
                loita.Sequence.Add(infusion);
            }
            foreach (Item infusion in wand.Infusions.Slots)
            {
                loita.Sequence.Add(infusion);
            }
        }
    }
}
