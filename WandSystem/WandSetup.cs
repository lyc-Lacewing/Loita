using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace LoitaMod.WandSystem
{
    internal class WandSetup : ModSystem
    {
        public static HashSet<int> Wands = new HashSet<int>();

        public static HashSet<int> VanillaWands = new HashSet<int>()
        {
            ItemID.WandofSparking
        }
        public override void PostSetupContent()
        {
            foreach (int type in VanillaWands)
            {
                Wands.Add(type);
            }
            //TODO allow adding modded wands, even from other mods.
        }
    }
}
