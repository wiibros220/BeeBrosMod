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
		

		private void target()
        {

        }

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nousagi");
		}

		int[] bruh;
		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.aiStyle = 1; 
			npc.damage = 7;
			npc.defense = 2;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 25f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.friendly = true;
			npc.dontTakeDamageFromHostiles = true;

			npc.HitSound = SoundID.Item95;
			//npc.DeathSound
			npc.FaceTarget();
			npc.immortal = true;
			npc.reflectingProjectiles = true;
			//npc.soundDelay
			

			npc.catchItem = (short)mod.ItemType("NousagiItem");
		}
		
        public override void AI()
        {
			npc.TargetClosest(true);
			Vector2 targetPosition = Main.player[npc.target].position;

			if (npc.HasValidTarget && Main.player[npc.target].Distance(npc.Center) < 650f)
			{
				if (targetPosition.X < npc.position.X
					&& npc.velocity.X > -8)
				{
					npc.velocity.X -= 0.22f;
				}

				if (targetPosition.X > npc.position.X
					&& npc.velocity.X < 8)
				{
					npc.velocity.X += 0.22f;
				}

				if ((npc.velocity.X < 0.1f && npc.velocity.Y == 0) || (npc.velocity.X > -0.1f && npc.velocity.Y == 0))
				{
					if ((Math.Abs(npc.position.X - targetPosition.X) > 0) || (Math.Abs(npc.position.X - targetPosition.X) * -1 < 0))
					{
						npc.velocity.Y = -7f;
					}
				}
			}
		}

		public override bool CanHitPlayer(Player target, ref int cooldownSlot)
		{
			return false;
		}
	}
}
