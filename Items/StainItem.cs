using Terraria.ID;
using Terraria.ModLoader;

namespace BeeBrosMod.Items
{
    public class StainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stain Item");
            Tooltip.SetDefault("This is a modded item.");
        }

        public override void SetDefaults()
        {
            item.damage = 400;
            item.ranged = true;
            item.shoot = mod.ProjectileType("StainBoolet");
            item.shootSpeed = 10;
            item.width = 20;
            item.useStyle = 5;
            item.height = 20;
            item.noMelee = true;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 5;
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}