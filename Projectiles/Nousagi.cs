﻿using System;
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

        private Player player; 

        private int bounceCount = 0;
        private bool hitNPC = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nousagi");
        }

        public override void SetDefaults()
        {
            
            projectile.width = 15;
            projectile.height = 15;
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
            hitNPC = true;
      
            if (hitNPC)
            {
                bounceCount++;
                Main.PlaySound(SoundID.Item21, projectile.position);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, (projectile.velocity.X *= -1) / 2, (projectile.velocity.Y *= -1) / 2, mod.ProjectileType("Nousagi"), 60 + (20 * bounceCount), 10 + (10 * bounceCount), Terraria.Main.myPlayer, 0f, 0f);
            }
            

        }

        public override void Kill(int timeLeft)
        {  
            if (!hitNPC)
            {
                bounceCount = 0;
                Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
                Main.PlaySound(SoundID.Item35, projectile.position);
                NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y, mod.NPCType("wabbit"), 0, 0, 0, 0, 0, 0);
                
            }
        }
    }
}
