using LoitaMod.InfusionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.CastingSystem
{
    public class CastedProjectile : GlobalProjectile
    {
        public override bool InstancePerEntity => true;

        public bool DoAI = true;
        public override bool PreAI(Projectile projectile)
        {
            
            return DoAI;
        }
    }
    public enum Hook
    {
        SetDefaults,
        PreAI,
        PostAI
    }
}
