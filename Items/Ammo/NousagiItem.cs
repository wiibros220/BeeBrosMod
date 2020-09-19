using BeeBrosMod.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace BeeBrosMod.Items.Ammo
{
    public class NousagiItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nousagi");
            Tooltip.SetDefault("Yabai...");
        }

        public override void SetDefaults()
        {
            item.ammo = item.type;
            item.shoot = mod.ItemType("Nousagi");
            item.maxStack = 999;
            item.consumable = true;
        }
        
    }
}
