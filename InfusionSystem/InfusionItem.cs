using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent;
using Terraria.ID;

namespace Loita.InfusionSystem
{
    public abstract class InfusionItem : ModItem
    {
        public override string Texture => $"Terraria/Images/Buff_{BuffID.NebulaUpDmg3}";
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 32;
            Item.useAnimation = 32;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.UseSound = SoundID.MaxMana;
            Item.maxStack = 1;
        }
    }
}
