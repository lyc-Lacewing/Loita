using LoitaMod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader.IO;

namespace LoitaMod.WandSystem
{
    internal class WandBase : GlobalItem
    {

        public WandStats Stats = new WandStats();
        public WandInfusions Infusions = new WandInfusions();

        public override bool InstancePerEntity => true;

        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return WandSetup.Wands.Contains(entity.type);
        }
        public override void SetDefaults(Item entity)
        {
            entity.shoot = ProjectileID.None;
        }
        public override void SaveData(Item item, TagCompound tag)
        {
            tag.Add("Stats", GeneralUtil.ToJSON(Stats));
            tag.Add("Embeds", Infusions.Embeds);
            tag.Add("Slots", Infusions.Slots);
        }
        public override void LoadData(Item item, TagCompound tag)
        {
            Stats = GeneralUtil.JSONToObj<WandStats>(tag["Stats"].ToString());
            Infusions.Embeds = (Item[])tag["Embeds"];
            Infusions.Slots = (Item[])tag["Slots"];
        }
        public override bool? UseItem(Item item, Player player)
        {
            return base.UseItem(item, player);
        }
    }

    public class WandStats
    {
        // The Wand itself.
        /// <summary>
        /// Capacity of the Wand, means the number of Slots for Infusions.
        /// </summary>
        public int Capacity = 3;
        /// <summary>
        /// Recharge time of the Wand.
        /// </summary>
        public int Recharge = 20;

        // The Wand to the Sequence.
        /// <summary>
        /// Critical strike chance of the Wand.
        /// </summary>
        public int CritChance = 0;
        /// <summary>
        /// Knockback of the Wand.
        /// </summary>
        public float KnockBack = 0;
        /// <summary>
        /// Speed added to its Spells, if applicable.
        /// </summary>
        public float Speed = 4;
        /// <summary>
        /// Scatter added to its Spells, if applicable.
        /// </summary>
        public double Scatter = 0;

        // The Wand to its holder.
        /// <summary>
        /// Mana procided by the Wand, means the amount of increase of the holder's max mana.
        /// </summary>
        public int Mana = 0;
        /// <summary>
        /// Mana regeneration provided by the Wand, means the amount of increase of the holder's mana regen rate.
        /// </summary>
        public int ManaRegen = 0;

        public WandStats Clone()
        {
            return (WandStats)MemberwiseClone();
        }
    }

    public class WandInfusions
    {
        /// <summary>
        /// Embeded Infusions of the Wand.
        /// </summary>
        public Item[] Embeds = new Item[] { };
        /// <summary>
        /// Slots of the Wand.
        /// </summary>
        public Item[] Slots = new Item[] { };

        public WandInfusions Clone()
        {
            WandInfusions clone = (WandInfusions)MemberwiseClone();
            clone.Embeds = (Item[])Embeds.Clone();
            clone.Slots = (Item[])Slots.Clone();
            return clone;
        }
    }
}
