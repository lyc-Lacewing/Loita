using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.WandSystem
{
    internal class Caster
    {
        public static void InitializeInfusions(Player player, Item item)
        {
            if (!item.TryGetGlobalItem(out WandBase wand) || !player.TryGetModPlayer(out Loita loita))
            {
                return;
            }
            loita.Sequence.Clear();
            foreach (Item infusion in wand.Infusions.Embeds)
            {
                loita.Sequence.Add(infusion.Clone());
            }
            foreach (Item infusion in wand.Infusions.Slots)
            {
                loita.Sequence.Add(infusion.Clone());
            }
        }
    }
}
