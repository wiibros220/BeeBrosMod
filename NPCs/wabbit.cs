using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BeeBrosMod.NPCs
{
    class wabbit : ModNPC
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nousagi");
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 1; 
			npc.lifeMax = 1;
			npc.value = 25f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.friendly = true;
			npc.dontTakeDamageFromHostiles = true;

			npc.HitSound = SoundID.Item95;
			npc.FaceTarget();
			npc.immortal = true;
			npc.reflectingProjectiles = true;
			//npc.soundDelay

			npc.catchItem = (short)mod.ItemType("NousagiItem");

			//animationType = NPCID.Bunny;
		}

		private void target(Vector2 targetPosition)
        {
			if (targetPosition.X < npc.position.X
					&& npc.velocity.X > -7)
			{
				npc.velocity.X -= 0.11f;
				npc.spriteDirection = npc.direction;
			}

			if (targetPosition.X > npc.position.X
				&& npc.velocity.X < 7)
			{
				npc.velocity.X += 0.11f;
				//npc.spriteDirection = 1;
				npc.spriteDirection = npc.direction;
			}

			if ((npc.velocity.X < 0.1f && npc.velocity.Y == 0) || (npc.velocity.X > -0.1f && npc.velocity.Y == 0))
			{
				if ((Math.Abs(npc.position.X - targetPosition.X) > 0) || (Math.Abs(npc.position.X - targetPosition.X) * -1 < 0))
				{
					npc.velocity.Y = -6f;
				}
			}
		}
		
        public override void AI()
        {
			npc.TargetClosest(true);
			Vector2 targetPosition = Main.player[0].Center;
			bool targetFound = false;
			int targetIndex = 0;
			
			for (int i = 0; i < 200; i++)
            {
				if (Main.npc[i].active && !Main.npc[i].dontTakeDamage && !Main.npc[i].friendly && Main.npc[i].lifeMax > 5 && Main.npc[i].Distance(npc.Center) < 400f)
                {
					targetFound = true;
					targetIndex = i;
                }
			}

			if (targetFound) 
			{
				Projectile.NewProjectile(npc.Center.X, npc.Center.Y, npc.velocity.X, npc.velocity.Y, mod.ProjectileType("rabbitRee"), 1, 1, Main.myPlayer, 0f, 0f);
				npc.velocity.Y = -1000000000f;    //i seriously hate whoever made tmodloader LET ME JUST KILL AN NPC
				
				//npc.Teleport(new Vector2(0, 0));
			}
			else
			{
				targetPosition = Main.player[0].Center;
				target(targetPosition);
			}

			//old 
			/*
			if (npc.HasValidTarget && Main.player[npc.target].Distance(npc.Center) < 650f)
			{
				target(targetPosition);
			}*/
		}

		public override bool CanHitPlayer(Player target, ref int cooldownSlot)
		{
			return false;
		}
	}
}
