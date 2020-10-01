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
            item.rare = ItemRarityID.Pink;
            item.damage = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bunny, 1);
            recipe.AddIngredient(ItemID.Grenade, 10);


            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
