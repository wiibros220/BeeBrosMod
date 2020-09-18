using BeeBrosMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace BeeBrosMod.Items
{
    public class LeMonarque : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Le Monarque");
            Tooltip.SetDefault("\"Wings flutter. \n Beauty distracts.Poison injects. \n The butterfly's curse extends to your enemies. \n A short life, shortened further by your hand.\" \n —Ada-1");
        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.damage = 15;
            item.crit = 21;
            item.useAmmo = AmmoID.Arrow;
            item.shoot = mod.ProjectileType("LeArrow");
            item.shootSpeed = 15;
            item.width = 16;
            item.height = 32;
            item.useTime = 25;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 10;
            item.rare = 5;
            item.UseSound = SoundID.Item39;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("LeArrow"); // or ProjectileID.FireArrow;
            }

            return true;
        }

    }
}
