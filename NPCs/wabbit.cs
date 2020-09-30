using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 25f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.friendly = true;
			npc.dontTakeDamageFromHostiles = true;

			npc.catchItem = (short)mod.ItemType("NousagiItem");
		}
		
        public override void AI()
        {
            
        }

		public override bool CanHitPlayer(Player target, ref int cooldownSlot)
		{
			return false;
		}
	}
}
