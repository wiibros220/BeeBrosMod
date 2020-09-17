using BeeBrosMod.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

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
            item.damage = 25;
            item.shoot = mod.ProjectileType("LeArrow");
            item.shootSpeed = 15;
            item.width = 40;
            item.height = 40;
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
    }
}
