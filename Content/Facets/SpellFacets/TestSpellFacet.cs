using LoitaMod.CastingSystem;
using LoitaMod.InfusionSystem.SpellSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Content.Facets.SpellFacets
{
    public class TestSpellFacet : SpellFacet
    {
        public override bool Inlay(Spell spell)
        {
            return spell.RegisterLoitaHook(LoitaHook.OnCast, this, OnCast);
        }
        public Action<Loita, Spell> OnCast = (loita, spell) =>
        {
            spell.Stats.Damage += 10;
        };
    }
}
