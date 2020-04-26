﻿// https://pastebin.com/ZH0L3XXi
using KHSave.Attributes;

namespace KHSave.Lib1.Types
{
    public enum AbilityType : byte
    {
        [Info] Empty,

        //equipped
        [Ability("High Jump")] HighJump = 0x01,
        [Ability("Mermaid Kick")] MermaidKick = 0x02,
        [Ability("Glide")] Glide = 0x03,
        [Ability("Superglide")] Superglide = 0x04,
        [Ability("Treasure Magnet")] TreasureMagnet = 0x05,
        [Ability("Combo Plus")] ComboPlus = 0x06,
        [Ability("Air Combo Plus")] AirComboPlus = 0x07,
        [Ability("Critical Plus")] CriticalPlus = 0x08,
        [Ability("Second Wind")] SecondWind = 0x09,
        [Ability("Scan")] Scan = 0x0A,
        [Ability("Sonic Blade")] SonicBlade = 0x0B,
        [Ability("Ars Arcanum")] ArsArcanum = 0x0C,
        [Ability("Strike Raid")] StrikeRaid = 0x0D,
        [Ability("Ragnarok")] Ragnarok = 0x0E,
        [Ability("Trinity Limit")] TrinityLimit = 0x0F,
        [Ability("Cheer")] Cheer = 0x10,
        [Ability("Vortex")] Vortex = 0x11,
        [Ability("Aerial Sweep")] AerialSweep = 0x12,
        [Ability("Counterattack")] Counterattack = 0x13,
        [Ability("Blitz")] Blitz = 0x14,
        [Ability("Guard")] Guard = 0x15,
        [Ability("Dodge Roll")] DodgeRoll = 0x16,
        [Ability("MP Haste")] MPHaste = 0x17,
        [Ability("MP Rage")] MPRage = 0x18,
        [Ability("Second Chance")] SecondChance = 0x19,
        [Ability("Berserk")] Berserk = 0x1A,
        [Ability("Jackpot")] Jackpot = 0x1B,
        [Ability("Lucky Strike")] LuckyStrike = 0x1C,
        [Ability("Charge")] Charge = 0x1D,
        [Ability("Rocket")] Rocket = 0x1E,
        [Ability("Tornado")] Tornado = 0x1F,
        [Ability("MP Gift")] MPGift = 0x20,
        [Ability("Raging Boar")] RagingBoar = 0x21,
        [Ability("Asp's Bite")] AspsBite = 0x22,
        [Ability("Healing Herb")] HealingHerb = 0x23,
        [Ability("Wind Armor")] WindArmor = 0x24,
        [Ability("Crescent")] Crescent = 0x25,
        [Ability("Sandstorm")] Sandstorm = 0x26,
        [Ability("Applause!")] Applause = 0x27,
        [Ability("Blazing Fury")] BlazingFury = 0x28,
        [Ability("Icy Terror")] IcyTerror = 0x29,
        [Ability("Bolts Of Sorrow")] BoltsOfSorrow = 0x2A,
        [Ability("Ghostly Scream")] GhostlyScream = 0x2B,
        [Ability("Hummingbird")] Hummingbird = 0x2C,
        [Ability("Time-Out")] TimeOut = 0x2D,
        [Ability("Storm's Eye")] StormsEye = 0x2E,
        [Ability("Ferocious Lunge")] FerociousLunge = 0x2F,
        [Ability("Furious Bellow")] FuriousBellow = 0x30,
        [Ability("Spiral Wave")] SpiralWave = 0x31,
        [Ability("Thunder Potion")] ThunderPotion = 0x32,
        [Ability("Cure Potion")] CurePotion = 0x33,
        [Ability("Aero Potion")] AeroPotion = 0x34,
        [Ability("Slapshot")] Slapshot = 0x35,
        [Ability("Sliding Dash")] SlidingDash = 0x36,
        [Ability("Hurricane Blast")] HurricaneBlast = 0x37,
        [Ability("Ripple Drive")] RippleDrive = 0x38,
        [Ability("Stun Impact")] StunImpact = 0x39,
        [Ability("Gravity Break")] GravityBreak = 0x3A,
        [Ability("Zantetsuken")] Zantetsuken = 0x3B,
        [Ability("Tech Boost")] TechBoost = 0x3C,
        [Ability("Encounter Plus")] EncounterPlus = 0x3D,
        [Ability("Leaf Bracer")] LeafBracer = 0x3E,
        [Ability("Evolution")] Evolution = 0x3F,
        [Ability("EXP Zero")] EXPZero = 0x40,

        //unequipped
        [Ability("High Jump (unequipped)")] HighJumpUnequipped = 0x81,
        [Ability("Mermaid Kick (unequipped)")] MermaidKickUnequipped = 0x82,
        [Ability("Glide (unequipped)")] GlideUnequipped = 0x83,
        [Ability("Superglide (unequipped)")] SuperglideUnequipped = 0x84,
        [Ability("Treasure Magnet (unequipped)")] TreasureMagnetUnequipped = 0x85,
        [Ability("Combo Plus (unequipped)")] ComboPlusUnequipped = 0x86,
        [Ability("Air Combo Plus (unequipped)")] AirComboPlusUnequipped = 0x87,
        [Ability("Critical Plus (unequipped)")] CriticalPlusUnequipped = 0x88,
        [Ability("Second Wind (unequipped)")] SecondWindUnequipped = 0x89,
        [Ability("Scan (unequipped)")] ScanUnequipped = 0x8A,
        [Ability("Sonic Blade (unequipped)")] SonicBladeUnequipped = 0x8B,
        [Ability("Ars Arcanum (unequipped)")] ArsArcanumUnequipped = 0x8C,
        [Ability("Strike Raid (unequipped)")] StrikeRaidUnequipped = 0x8D,
        [Ability("Ragnarok (unequipped)")] RagnarokUnequipped = 0x8E,
        [Ability("Trinity Limit (unequipped)")] TrinityLimitUnequipped = 0x8F,
        [Ability("Cheer (unequipped)")] CheerUnequipped = 0x90,
        [Ability("Vortex (unequipped)")] VortexUnequipped = 0x91,
        [Ability("Aerial Sweep (unequipped)")] AerialSweepUnequipped = 0x92,
        [Ability("Counterattack (unequipped)")] CounterattackUnequipped = 0x93,
        [Ability("Blitz (unequipped)")] BlitzUnequipped = 0x94,
        [Ability("Guard (unequipped)")] GuardUnequipped = 0x95,
        [Ability("Dodge Roll (unequipped)")] DodgeRollUnequipped = 0x96,
        [Ability("MP Haste (unequipped)")] MPHasteUnequipped = 0x97,
        [Ability("MP Rage (unequipped)")] MPRageUnequipped = 0x98,
        [Ability("Second Chance (unequipped)")] SecondChanceUnequipped = 0x99,
        [Ability("Berserk (unequipped)")] BerserkUnequipped = 0x9A,
        [Ability("Jackpot (unequipped)")] JackpotUnequipped = 0x9B,
        [Ability("Lucky Strike (unequipped)")] LuckyStrikeUnequipped = 0x9C,
        [Ability("Charge (unequipped)")] ChargeUnequipped = 0x9D,
        [Ability("Rocket (unequipped)")] RocketUnequipped = 0x9E,
        [Ability("Tornado (unequipped)")] TornadoUnequipped = 0x9F,
        [Ability("MP Gift (unequipped)")] MPGiftUnequipped = 0xA0,
        [Ability("Raging Boar (unequipped)")] RagingBoarUnequipped = 0xA1,
        [Ability("Asp's Bite (unequipped)")] AspsBiteUnequipped = 0xA2,
        [Ability("Healing Herb (unequipped)")] HealingHerbUnequipped = 0xA3,
        [Ability("Wind Armor (unequipped)")] WindArmorUnequipped = 0xA4,
        [Ability("Crescent (unequipped)")] CrescentUnequipped = 0xA5,
        [Ability("Sandstorm (unequipped)")] SandstormUnequipped = 0xA6,
        [Ability("Applause! (unequipped)")] ApplauseUnequipped = 0xA7,
        [Ability("Blazing Fury (unequipped)")] BlazingFuryUnequipped = 0xA8,
        [Ability("Icy Terror (unequipped)")] IcyTerrorUnequipped = 0xA9,
        [Ability("Bolts Of Sorrow (unequipped)")] BoltsOfSorrowUnequipped = 0xAA,
        [Ability("Ghostly Scream (unequipped)")] GhostlyScreamUnequipped = 0xAB,
        [Ability("Hummingbird (unequipped)")] HummingbirdUnequipped = 0xAC,
        [Ability("Time-Out (unequipped)")] TimeOutUnequipped = 0xAD,
        [Ability("Storm's Eye (unequipped)")] StormsEyeUnequipped = 0xAE,
        [Ability("Ferocious Lunge (unequipped)")] FerociousLungeUnequipped = 0xAF,
        [Ability("Furious Bellow (unequipped)")] FuriousBellowUnequipped = 0xB0,
        [Ability("Spiral Wave (unequipped)")] SpiralWaveUnequipped = 0xB1,
        [Ability("Thunder Potion (unequipped)")] ThunderPotionUnequipped = 0xB2,
        [Ability("Cure Potion (unequipped)")] CurePotionUnequipped = 0xB3,
        [Ability("Aero Potion (unequipped)")] AeroPotionUnequipped = 0xB4,
        [Ability("Slapshot (unequipped)")] SlapshotUnequipped = 0xB5,
        [Ability("Sliding Dash (unequipped)")] SlidingDashUnequipped = 0xB6,
        [Ability("Hurricane Blast (unequipped)")] HurricaneBlastUnequipped = 0xB7,
        [Ability("Ripple Drive (unequipped)")] RippleDriveUnequipped = 0xB8,
        [Ability("Stun Impact (unequipped)")] StunImpactUnequipped = 0xB9,
        [Ability("Gravity Break (unequipped)")] GravityBreakUnequipped = 0xBA,
        [Ability("Zantetsuken (unequipped)")] ZantetsukenUnequipped = 0xBB,
        [Ability("Tech Boost (unequipped)")] TechBoostUnequipped = 0xBC,
        [Ability("Encounter Plus (unequipped)")] EncounterPlusUnequipped = 0xBD,
        [Ability("Leaf Bracer (unequipped)")] LeafBracerUnequipped = 0xBE,
        [Ability("Evolution (unequipped)")] EvolutionUnequipped = 0xBF,
        [Ability("EXP Zero (unequipped)")] EXPZeroUnequipped = 0xC0,
    }
}