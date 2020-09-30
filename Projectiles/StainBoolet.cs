using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeeBrosMod.Projectiles
{
	public class StainBoolet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			
			aiType = ProjectileID.WoodenArrowFriendly;
		}

		// Additional hooks/methods here.
	}
}