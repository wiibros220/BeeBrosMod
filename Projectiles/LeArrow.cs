using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeeBrosMod.Projectiles
{
    public class LeArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Le Arrow");
        }

        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.ranged = true;
            aiType = ProjectileID.JestersArrow;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 400);
             if (crit == true)
            {
                float projectilespeedX = 0;
                float projectilespeedY = 0;
                float projectileknockback = 0;
                int projectiledamage = 10;
                //cannot figure out how for the life of me to get the fucking arrow on hit to spawn a new projectile on the hit target, ive been through like 5 different solutions.
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectilespeedX, projectilespeedY, ProjectileID.ToxicFlask, projectiledamage, projectileknockback, Main.myPlayer, 0f, 0f);
                
            }
        }


    }
}
