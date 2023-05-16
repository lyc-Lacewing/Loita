using LoitaMod.CastingSystem;
using LoitaMod.Content.Facets.SpellFacets;
using LoitaMod.InfusionSystem.SpellSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.Content.Spells
{
    public class TestSpell : Spell
    {
        public override void Setup()
        {
            InlayFacet<TestSpellFacet>();
        }
    }
}
