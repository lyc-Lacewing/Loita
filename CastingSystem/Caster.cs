using LoitaMod.InfusionSystem;
using LoitaMod.WandSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoitaMod.CastingSystem
{
    public class Caster
    {
        public static void InitializeInfusions(Player player, Item item)
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
    }
    public class Assemblage
    {
        public List<SpellStats> SpellStats = new List<SpellStats>();
        public List<SpellActions> SpellActions = new List<SpellActions>();
        public List<ModifierStats> ModifierStats = new List<ModifierStats>();
        public List<ModifierActions> ModifierActions = new List<ModifierActions>();
    }
}
