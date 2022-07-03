using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace SigilOfTheHunter
{
    [Label("A Metroid Mod Addon")]
    public class SigilOfTheHunterConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static SigilOfTheHunterConfig Instance;
		
	[Header("General")]
		
        [Label("[i:Toolbelt] Enable Recipe")]
        [Tooltip("If false, Players cannot craft the Sigil of The Hunter.\n[Default: On]\n(REQUIRES MOD RELOAD)")]
        [DefaultValue(true)]
        public bool sigilRecipe {get; set;}
		
        [Label("[i:ObsidianShield] Sigil Defense")]
        [Tooltip("Critical Chance bonus gained from the Sigil.\n[Default: 25]")]
        [Slider]
        [DefaultValue(25)]
        [Range(0, 100)]
        [Increment(1)]
        public int sigilDefense {get; set;}
		
        [Label("[i:MetroidMod/PowerBeam] Sigil Damage")]
        [Tooltip("Damage bonus gained from the Sigil.\n[Default: 1.5f]")]
        [Slider]
        [DefaultValue(1.50f)]
        [Range(0f, 3f)]
        [Increment(0.05f)]
        public float sigilDamage {get; set;}
		
        [Label("[i:EyeoftheGolem] Sigil Critical Chance")]
        [Tooltip("Critical Chance bonus gained from the Sigil.\n[Default: 15]")]
        [Slider]
        [DefaultValue(15)]
        [Range(0, 100)]
        [Increment(1)]
        public int sigilCrit {get; set;}
		
        [Label("[i:MetroidMod/EnergyShard] Sigil Overheat Max")]
        [Tooltip("Maximum Overheat bonus gained from the Sigil.\n[Default: 150]")]
        [Slider]
        [DefaultValue(150)]
        [Range(0, 200)]
        [Increment(5)]
        public int sigilOverheatMax {get; set;}
		
        [Label("[i:MetroidMod/PowerBeam] Sigil Overheat Cost")]
        [Tooltip("Overheat Cost gained from the Sigil.\n[Default: 0.5f]")]
        [Slider]
        [DefaultValue(0.50f)]
        [Range(0f, 2f)]
        [Increment(0.05f)]
        public float sigilOverheatCost {get; set;}
		
        [Label("[i:MetroidMod/MissileLauncher] Sigil Missile Cost")]
        [Tooltip("Missile Damage bonus gained from the Sigil.\n[Default: 0.5f]")]
        [Slider]
        [DefaultValue(0.50f)]
        [Range(0f, 2f)]
        [Increment(0.05f)]
        public float sigilMissileCost {get; set;}
		
        [Label("[i:MetroidMod/EnergyTank] Sigil Energy Defense")]
        [Tooltip("Energy Defense bonus gained from the Sigil.\n[Default: 0.5f]")]
        [Slider]
        [DefaultValue(0.50f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float sigilEnergyDefense {get; set;}
		
        [Label("[i:MetroidMod/ReserveTank] Sigil Energy Expense")]
        [Tooltip("Energy Expense bonus gained from the Sigil.\n[Default: 0.5f]")]
        [Slider]
        [DefaultValue(0.50f)]
        [Range(0f, 1f)]
        [Increment(0.05f)]
        public float sigilEnergyExpense {get; set;}
		
    }
}