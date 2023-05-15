using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace LoitaMod.InfusionSystem
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
    public class ConfluxStats
    {
        public Vector2[] Orientation = new Vector2[] { Vector2.Zero };
        public double Scatter = 0;

        public ConfluxStats Clone()
        {
            ConfluxStats clone = (ConfluxStats)MemberwiseClone();
            clone.Orientation = (Vector2[])Orientation.Clone();
            return clone;
        }
    }
}
