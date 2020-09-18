using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

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
            //float projectileSpeed = 10;
            
            projectile.width = 25;
            projectile.height = 25;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.velocity = new Microsoft.Xna.Framework.Vector2(1000000);
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
    }
}
