using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Microsoft.Xna.Framework;

namespace BeeBrosMod.Items
{
    public class aa12 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AA-12");
            Tooltip.SetDefault("Not one for Formalities");
        }

        public override void SetDefaults()
        {
            item.damage = 400;
            item.ranged = true;
            item.shoot = mod.ProjectileType("StainBoolet");
            item.shootSpeed = 10;
            item.width = 20;
            item.scale = 1f;
            item.useStyle = 5;
            item.autoReuse = true;
            item.useTime = 18;
            item.useAnimation = 18;
            item.height = 20;
            item.noMelee = true;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 5;
            item.useAmmo = AmmoID.Bullet;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 0);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        // What if I wanted it to shoot like a shotgun?
        // Shotgun style: Multiple Projectiles, Random spread
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

            if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("StainBoolet"); // or ProjectileID.FireArrow;
            }

            int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
				// If you want to randomize the speed to stagger the projectiles
				// float scale = 1f - (Main.rand.NextFloat() * .3f);
				// perturbedSpeed = perturbedSpeed * scale; 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}

            
            return false; // return false because we don't want tmodloader to shoot projectile
		}
        
    }
}