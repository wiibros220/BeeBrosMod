using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;

namespace BeeBrosMod.Projectiles
{
    public class Nousagi : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nousagi");
        }

        public override void SetDefaults()
        {
            
            projectile.width = 25;
            projectile.height = 25;
            projectile.friendly = true;
            projectile.ranged = true;
          
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 15f)
            {
                projectile.ai[0] = 15f;
                projectile.velocity.Y = projectile.velocity.Y + 0.27f;
            }
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }

            projectile.rotation += 0.4f * (float)projectile.direction;
        }

        public override void OnHitNPC(Terraria.NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, ProjectileID.Bunny, 40, 10, Terraria.Main.myPlayer, 0f, 0f);
        }
    }
}
