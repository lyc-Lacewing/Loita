using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Loita.InfusionSystem
{
    internal abstract class BaseConfluxer : BaseInfusion
    {
        public override string Texture => $"Terraria/Images/Buff_{BuffID.NebulaUpLife3}";
    }
}
