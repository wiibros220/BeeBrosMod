using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace BeeBrosMod.Items
{
    public class PEKO : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("P.E.K 0");
            Tooltip.SetDefault("HA↑ HA↓ HA↑ HA↓");
        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 60;
            item.crit = 10;
            item.useAmmo = mod.ItemType("NousagiItem");
            item.shoot = mod.ProjectileType("Nousagi");
            item.shootSpeed = 10;
            item.width = 40;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 5;
            item.UseSound = SoundID.Item95;
            item.autoReuse = true;
            item.noMelee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofFright, 15);
            recipe.AddIngredient(ItemID.Bunny, 20);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.Grenade, 50);


            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}