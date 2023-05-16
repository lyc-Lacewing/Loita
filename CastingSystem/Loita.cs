using LoitaMod.InfusionSystem;
using LoitaMod.InfusionSystem.ConfluxerSystem;
using LoitaMod.InfusionSystem.ModifierSystem;
using LoitaMod.InfusionSystem.SpellSystem;
using LoitaMod.Utils;
using LoitaMod.WandSystem;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.CastingSystem
{
    public class Loita : ModPlayer
    {
        public List<Item> InfusionItems = new List<Item>();
        public List<Assemblage> Sequence = new List<Assemblage>();

        public void RefreshSequence(Item item)
        {
            if (!item.TryGetGlobalItem(out WandBase wand))
            {
                return;
            }
            InfusionItems.Clear();
            foreach (Item infusion in wand.Infusions.Embeds)
            {
                InfusionItems.Add(infusion.Clone());
            }
            foreach (Item infusion in wand.Infusions.Slots)
            {
                InfusionItems.Add(infusion.Clone());
            }
        }
        public void Cast()
        {
            //TODO cast
        }
    }
    public class Assemblage
    {
        public List<ModifierBase> Modifiers = new List<ModifierBase>();
        public List<SpellBase> Spells = new List<SpellBase>();
        public List<Assemblage> Assemblages = new List<Assemblage>();
        public List<Vector2> Orientation = new List<Vector2>();
    }
    public enum LoitaHook
    {
        PreAssemble,
        OnAssemble,
        PreCast,
        OnCast,
    }
}
