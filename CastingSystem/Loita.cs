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
        public static List<Item> Sequence = new List<Item>();
        public static List<Assemblage> Assemblages = new List<Assemblage>();

        public static Dictionary<(LoitaHook, SpellBase), Action<Loita>> SpellHooks = new Dictionary<(LoitaHook, SpellBase), Action<Loita>>();

        public void RefreshSequence(Item item)
        {
            if (!item.TryGetGlobalItem(out WandBase wand))
            {
                return;
            }
            Sequence.Clear();
            foreach (Item infusion in wand.Infusions.Embeds)
            {
                Sequence.Add(infusion.Clone());
            }
            foreach (Item infusion in wand.Infusions.Slots)
            {
                Sequence.Add(infusion.Clone());
            }
        }
        public void Assemble()
        {
            for (int i = 0; i < SpellHooks.Count; i++)
            {
                if (SpellHooks.Keys.ToArray()[i].Item1 != LoitaHook.PreAssemble)
                {
                    continue;
                }
                SpellHooks.Values.ToArray()[i](this);
            }
            
            Assemblage assemblage = new Assemblage();
            int conflux = 1, spellCount = 0;
            for (int i = 0; i < Sequence.Count; i--)
            {
                if (Sequence[i].ModItem == null || !InfusionUtil.IsInfusion(Sequence[i].ModItem))
                {
                    continue;
                }
                InfusionItem infusionItem = (InfusionItem)Sequence[i].ModItem;
                SpellItem spellItem;
                ModifierItem modifierItem;
                ConfluxerItem confluxerItem;
                switch (InfusionUtil.GetInfusionClass(Sequence[i].ModItem)) //TODO compile
                {
                    default:
                        break;
                    case InfusionClass.Spell:
                        spellItem = (SpellItem)infusionItem;
                        assemblage.Spells.Add(spellItem.Spell);
                        if (++spellCount >= conflux)
                        {

                        }
                        break;
                    case InfusionClass.Modifier:
                        break;
                    case InfusionClass.Confluxer:
                        //TODO confluxer
                        break;
                }
            }

            return;
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
