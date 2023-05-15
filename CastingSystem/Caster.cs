using LoitaMod.InfusionSystem.ModifierSystem;
using LoitaMod.InfusionSystem.SpellSystem;
using LoitaMod.WandSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.CastingSystem
{
    public static class Caster
    {
        public static void RefreshSequence(Player player, Item item)
        {
            if (!item.TryGetGlobalItem(out WandBase wand) || !player.TryGetModPlayer(out Loita loita))
            {
                return;
            }
            loita.Sequence.Clear();
            foreach (Item infusion in wand.Infusions.Embeds)
            {
                loita.Sequence.Add(infusion.Clone());
            }
            foreach (Item infusion in wand.Infusions.Slots)
            {
                loita.Sequence.Add(infusion.Clone());
            }
        }
        public static List<Assemblage> Assemble(List<Item> sequence)
        {
            List<Assemblage> assemblages = new List<Assemblage>();
            for (int i = 0; i < sequence.Count; i++)
            {

            }
            return assemblages;
        }
    }
    public class Assemblage
    {
        public List<SpellBase> Spells = new List<SpellBase>();
        public List<ModifierBase> Modifiers = new List<ModifierBase>();
    }
}
