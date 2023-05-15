using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoitaMod.InfusionSystem;
using Terraria.ID;
using static LoitaMod.InfusionSystem.ModifierSystem.ModifierBase;

namespace LoitaMod.InfusionSystem.ModifierSystem
{
    public abstract class ModifierItem : InfusionItem
    {
        public ModifierBase Modifier = new ModifierBase();
        public virtual void SetModifierDefaults()
        {

        }
        public override string Texture => $"Terraria/Images/Buff_{BuffID.NebulaUpMana3}";
        public override void SetDefaults()
        {
            base.SetDefaults();
            SetModifierDefaults();
        }
        public override ModItem Clone(Item newEntity)
        {
            ModifierItem clone = (ModifierItem)MemberwiseClone();
            clone.Modifier = Modifier.Clone();
            return clone;
        }
    }
}
