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
            /* if (target.HasBuff(BuffID.Poisoned))
            {
                float 
                {
                    //cannot figure out how for the life of me to get the fucking arrow on hit to spawn a new projectile on the hit target, ive been through like 5 different solutions.
                    Projectile.NewProjectileDirect(Vector2.Equals(0, 0), Vector2.Equals(0, 0), mod.ProjectileType("ToxicFlask"), damage, knockback, Main.myPlayer);
                }
            }*/
        }


    }
}
