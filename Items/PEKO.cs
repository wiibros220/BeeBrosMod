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
using System.Drawing.Text;
using System.Xml.Serialization;

namespace BeeBrosMod.Items
{
    public class PEKO : ModItem
    {
        int uses = 7, useTimer = 0;
        const int maxUses = 7;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("P.E.K 0");
            Tooltip.SetDefault("HA↑ HA↓ HA↑ HA↓");
        }

        public override void SetDefaults()
        {     
            item.width = 80;
            item.height = 40;
            item.value = 10;
            item.rare = ItemRarityID.Red;
            item.autoReuse = true;
            item.noMelee = true;

            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 6;
            item.useTime = 30;
            item.useAnimation = 30;
            item.damage = 60;
            item.shoot = mod.ProjectileType("Nousagi");
            item.useAmmo = mod.ItemType("NousagiItem");
            item.shootSpeed = 10;
            item.crit = 10;
            item.ranged = true;
            item.damage = 60;
            item.UseSound = SoundID.Item95;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2 && uses > 0)
            {
                uses--;

                item.useStyle = ItemUseStyleID.HoldingOut;
                item.useTime = 7;
                item.useAnimation = 7;
                item.damage = 30;
                item.shoot = mod.ProjectileType("rabbitRee");
                item.useAmmo = mod.ItemType("NousagiItem");
                item.UseSound = SoundID.Item96;
            }
            else
            {
                item.useStyle = ItemUseStyleID.HoldingOut;
                item.knockBack = 6;
                item.useTime = 30;
                item.useAnimation = 30;
                item.damage = 60;
                item.shoot = mod.ProjectileType("Nousagi");
                item.useAmmo = mod.ItemType("NousagiItem");
                item.shootSpeed = 10;
                item.crit = 10;
                item.ranged = true;
                item.damage = 60;
                item.UseSound = SoundID.Item95;
            }
            return base.CanUseItem(player);
        }

        public override void UpdateInventory(Player player)
        {
            useTimer++;
            if (useTimer == 420)
            {
                useTimer = 0;
                uses= 7;
                Main.PlaySound(SoundID.Item37, player.position);
            }
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
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