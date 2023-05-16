using LoitaMod.CastingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.InfusionSystem.SpellSystem
{
    public abstract class SpellFacet : IFacet
    {
        public abstract bool Inlay(Spell spell);
        public virtual bool Outlay(Spell spell) { return true; }
        public SpellFacet Clone()
        {
            return (SpellFacet)MemberwiseClone();
        }
    }
}
