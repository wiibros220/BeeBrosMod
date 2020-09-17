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
            base.OnHitNPC(target, damage, knockback, crit);
            target.AddBuff(BuffID.Poisoned, 400);
            if (target.poisoned)
            {
                float projectilespeedX = 0;
                float projectilespeedY = 0;
                float projectileKnockBack = 0;
                int projectiledamage = 15;
                {
                    Projectile.NewProjectile(target.position.X, target.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("ToxicFlask"), projectiledamage, projectileKnockBack, projectile.owner, 0, 0);
                }
            }
        }


    }
}
