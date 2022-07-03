using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using MetroidMod;
using MetroidMod.ID;
using static MetroidMod.MetroidMod;
using MetroidMod.Common.Players;

namespace SigilOfTheHunter.Content.SuitAddons
{
	public class SigilOfTheHunter : ModSuitAddon
	{
		// See ExampleBomb.cs for these three fields.
		public override string ItemTexture => $"{Mod.Name}/Content/SuitAddons/SigilOfTheHunterItem";

		public override string TileTexture => $"{Mod.Name}/Content/SuitAddons/SigilOfTheHunterTile";

		public override bool AddOnlyAddonItem => false;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sigil of The Hunter");
			Tooltip.SetDefault("This is meant to extend the potential of the Hunter class beyond post-Moonlord..\n(A better description will be in the next coming update(s).)");
			AddonSlot = SuitAddonSlotID.Misc_Grip;
		}

		public override void SetItemDefaults(Item item)
		{
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = ItemRarityID.Orange;
			//item.accessory = true;
		}

		public override void OnUpdateArmorSet(Player Player, int stack)
		{
			Player.statDefense += SigilOfTheHunterConfig.Instance.sigilDefense;
			MPlayer mp = Player.GetModPlayer<MPlayer>();
			HunterDamagePlayer.ModPlayer(Player).HunterDamageMult += SigilOfTheHunterConfig.Instance.sigilDamage;
			HunterDamagePlayer.ModPlayer(Player).HunterCrit += SigilOfTheHunterConfig.Instance.sigilCrit;
			mp.maxOverheat += SigilOfTheHunterConfig.Instance.sigilOverheatMax;
			mp.overheatCost += SigilOfTheHunterConfig.Instance.sigilOverheatCost;
			mp.missileCost += SigilOfTheHunterConfig.Instance.sigilMissileCost;
			mp.EnergyDefenseEfficiency += SigilOfTheHunterConfig.Instance.sigilEnergyDefense;
			mp.EnergyExpenseEfficiency += SigilOfTheHunterConfig.Instance.sigilEnergyExpense;
		}

		public override void AddRecipes()
		{
			if (SigilOfTheHunterConfig.Instance.sigilRecipe)
			{
				CreateRecipe(1)
				.AddIngredient(SuitAddonLoader.GetAddon("MetroidMod/PowerGrip").ItemType, 1)
				.AddIngredient(ItemID.LunarBar, 5)
				.AddIngredient(ItemID.Sapphire, 1)
				.AddIngredient(ItemID.Ruby, 1)
				.AddIngredient(ItemID.Emerald, 1)
				.AddIngredient(ItemID.Amethyst, 1)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
			}
		}
	}
}