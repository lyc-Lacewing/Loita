using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.InfusionSystem.ConfluxerSystem
{
    public class ConfluxerBase
    {
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
