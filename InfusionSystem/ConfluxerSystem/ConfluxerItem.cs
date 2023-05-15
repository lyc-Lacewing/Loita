using LoitaMod.InfusionSystem;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using static LoitaMod.InfusionSystem.ConfluxerSystem.ConfluxerBase;

namespace LoitaMod.InfusionSystem.ConfluxerSystem
{
    public abstract class ConfluxerItem : InfusionItem
    {
        public ConfluxStats Stats = new ConfluxStats();
        public virtual void SetConfluxerDefaults()
        {

        }
        public override string Texture => $"Terraria/Images/Buff_{BuffID.NebulaUpLife3}";
        public override void SetDefaults()
        {
            base.SetDefaults();
            SetConfluxerDefaults();
        }
        public override ModItem Clone(Item newEntity)
        {
            ConfluxerItem clone = (ConfluxerItem)MemberwiseClone();
            clone.Stats = Stats.Clone();
            return base.Clone(newEntity);
        }
    }
}
