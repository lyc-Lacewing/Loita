﻿using Loita.InfusionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader.IO;

namespace Loita.WandSystem
{
    internal class WandBase : GlobalItem
    {
        public static HashSet<int> Wands = new HashSet<int>();
        public static List<TagCompound> WandSaves = new List<TagCompound>();
        private void addVanillaWands()
        {
            Wands.Add(ItemID.WandofSparking);
        }

        public WandStats Stats = new WandStats();
        public WandInfusions Infusions = new WandInfusions();

        public override bool InstancePerEntity => true;

        public override void Load()
        {
            addVanillaWands();
            //TODO allow adding modded wands, even from other mods.
        }
        public override bool AppliesToEntity(Item entity, bool lateInstantiation)
        {
            return Wands.Contains(entity.type);
        }
        public override void SetDefaults(Item entity)
        {
            entity.shoot = ProjectileID.None;
        }
        public override void SaveData(Item item, TagCompound tag)
        {
            //TODO save data
        }
        public override void LoadData(Item item, TagCompound tag)
        {
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

        //The Wand to the Sequence.
        /// <summary>
        /// Critical strike chance of the Wand.
        /// </summary>
        public int CritChance = 4;
        /// <summary>
        /// Knockback of the Wand.
        /// </summary>
        public float KnockBack = 1;
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
        public int Mana = 20;
        /// <summary>
        /// Mana regeneration provided by the Wand, means the amount of increase of the holder's mana regen rate.
        /// </summary>
        public int ManaRegen = 2;
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
    }
}