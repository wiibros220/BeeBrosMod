using Terraria.ID;
using Terraria.ModLoader;

namespace BeeBrosMod.Items
{
	public class TheBladeOfITried : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Blade of I tried");
			// DisplayName.SetDefault("ExampleSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("I can't believe im actually doing this");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.shoot = 502;
			item.shootSpeed = 10;
			item.melee = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
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