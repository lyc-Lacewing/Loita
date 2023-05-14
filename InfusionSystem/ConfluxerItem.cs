using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Loita.InfusionSystem
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
        public double[] Orientation = new double[] { 0 };
        public double Scatter = 0;

        public ConfluxStats Clone()
        {
            ConfluxStats clone = (ConfluxStats)MemberwiseClone();
            clone.Orientation = (double[])Orientation.Clone();
            return clone;
        }
    }
}
