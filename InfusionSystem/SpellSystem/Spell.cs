using LoitaMod.CastingSystem;
using rail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.UI.BigProgressBar;

namespace LoitaMod.InfusionSystem.SpellSystem
{
    public abstract class Spell : Infusion
    {
        public SpellStats Stats = new SpellStats();
        public List<SpellFacet> Facets = new List<SpellFacet>();
        public Dictionary<(LoitaHook, SpellFacet), Action<Loita, Spell>> LoitaHooks = new Dictionary<(LoitaHook, SpellFacet), Action<Loita, Spell>>();

        public bool InlayFacet<T>() where T : SpellFacet
        {
            SpellFacet facet = (SpellFacet)Activator.CreateInstance(typeof(T));
            return facet.Inlay(this);
        }
        public bool RegisterLoitaHook(LoitaHook type, SpellFacet facet, Action<Loita, Spell> action)
        {
            if (LoitaHooks.TryAdd((type, facet), action))
            {
                return true;
            }
            if (LoitaHooks.TryGetValue((type, facet), out Action<Loita, Spell> act))
            {
                act = action;
                return true;
            }
            return false;
        }
        public Spell Clone()
        {
            Spell clone = (Spell)MemberwiseClone();
            clone.Stats = Stats.Clone();
            clone.Facets = new List<SpellFacet>();
            Facets.ForEach(f => clone.Facets.Add(f.Clone()));
            clone.LoitaHooks = new Dictionary<(LoitaHook, SpellFacet), Action<Loita, Spell>>();
            foreach (var lh in LoitaHooks)
            {
                clone.LoitaHooks.Add(lh.Key, lh.Value);
            }
            return clone;
        }

        public static Spell InstanceSpell<T>() where T : Spell
        {
            return (Spell)Activator.CreateInstance(typeof(T));
        }
    }
}
