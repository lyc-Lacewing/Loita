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

        ModifierActions[] actions = new ModifierActions[] { };
        public override bool PreAI(Projectile projectile)
        {

            return base.PreAI(projectile);
        }
    }
}
