using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using System.Runtime.CompilerServices;
//using static Terraria.ModLoader.ModContent;

namespace BeeBrosMod.Projectiles
{
    class rabbitRee : ModProjectile
    {
        Color bruh = new Color();
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 5;
            projectile.height = 5;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.ranged = true;

            projectile.friendly = true;
            projectile.ranged = true;
            projectile.damage = 1;      
        }

        private void AdjustMagnitude(ref Vector2 vector)
        {
            float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (magnitude > 17f)
            {
                vector *= 17f / magnitude;
            }
        }

        
        public override void AI()
        {
            projectile.spriteDirection = projectile.direction = (projectile.velocity.X > 0).ToDirectionInt();
            projectile.rotation = projectile.velocity.ToRotation() + (projectile.spriteDirection == 1 ? 0f : MathHelper.Pi);

            if (projectile.velocity.X == 0)
            {
                projectile.rotation += 180;
            }

            if (projectile.localAI[0] == 0f)
            {
                AdjustMagnitude(ref projectile.velocity);
                projectile.localAI[0] = 1f;
            }

            Vector2 move = Vector2.Zero;
            float distance = 400f;
            bool target = false;

            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 25f)
            {
                for (int k = 0; k < 200; k++)
                {
                    if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
                    {
                        Vector2 newMove = Main.npc[k].Center - projectile.Center;
                        float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
                        
                        if (distanceTo < distance)
                        {
                            move = newMove;
                            distance = distanceTo;
                            target = true;
                        }
                    }
                }
                if (target)
                {
                    AdjustMagnitude(ref move);
                    projectile.velocity = (10 * projectile.velocity + move) / 11f;

                    if (projectile.velocity.X < 1 && projectile.velocity.X > 0)
                    {
                        projectile.velocity.X = 1;
                    }

                    AdjustMagnitude(ref projectile.velocity);
                }
            }
            Dust.NewDust(projectile.Center + new Vector2(10, 10), projectile.width, projectile.height, 51, projectile.velocity.X * -0.5f, projectile.velocity.Y * -0.5f, 100, bruh, 2f);
         }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, ProjectileID.Grenade, 60, 10, Main.myPlayer, 0f, 0f);
        }
    }
}