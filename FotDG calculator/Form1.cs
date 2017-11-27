using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotDG_calculator
{
    struct Professions
    {
        public Professions(int IDI, int ClassI, string NameI, bool DWI, string MHI, string OHI, float AP_MulI, float RAP_MUlI)
        {
            ID = IDI;
            Class = ClassI;
            Name = NameI;
            DW = DWI;
            MH = MHI;
            OH = OHI;
            AP_Mul = AP_MulI;
            RAP_Mul = RAP_MUlI;
        }

        public int ID { get; }
        public int Class { get; } // 1 warrior, 2 rogue, 3 healer, 4 mage
        public string Name { get; }
        public bool DW { get; }
        public string MH { get; }  // weapons allowed in main hand
        public string OH { get; }  // weapons allowed in off hand
        public float AP_Mul { get; }
        public float RAP_Mul { get; }
            }

    struct WeaponClass
    {
        public WeaponClass(int IDI, string NameI, bool TwoHandedI, float SpeedI, float DamageMultiplierI, bool MeleeRangedI)
            {
            ID = IDI; 
            Name = NameI;
            TwoHanded = TwoHandedI;
            Speed = SpeedI;
            DamageMultiplier = DamageMultiplierI;
            MeleeRanged = MeleeRangedI;
            }

     public int ID { get; }
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow
     public string Name { get; }
     public bool TwoHanded { get; }
     public float Speed { get; }
     public float DamageMultiplier { get; }
     public bool MeleeRanged { get; }
    }

    struct Ability
    {
        public Ability(string NameI, bool InstantI, int ProfessionIDI, int ClassI, string AbilityFormulaI, bool CastTypeI, float CastDurationWeaponSPDMulI, float FixedCastDurationI, bool CooldownTypeI, float CooldownDurationWeaponSPDMulI, float FixedCooldownDurationI, float ThreatMulI)
        {
            Name = NameI;
            Instant = InstantI;
            ProfessionID = ProfessionIDI;
            Class = ClassI;
            AbilityFormula = AbilityFormulaI;
            CastType = CastTypeI;
            CastDurationWeaponSPDMul = CastDurationWeaponSPDMulI;
            FixedCastDuration = FixedCastDurationI;
            CooldownType = CooldownTypeI;
            CooldownDurationWeaponSPDMul = CooldownDurationWeaponSPDMulI;
            FixedCooldownDuration = FixedCooldownDurationI;
            ThreatMul = ThreatMulI;
        }

        public string Name { get; }
        public bool Instant { get; }
        public int ProfessionID { get; }
        public int Class { get; }
        public string AbilityFormula { get; }
        public bool CastType { get; }
        public float CastDurationWeaponSPDMul { get; }
        public float FixedCastDuration { get; }
        public bool CooldownType { get; }
        public float CooldownDurationWeaponSPDMul { get; }
        public float FixedCooldownDuration { get; }
        public float ThreatMul { get; }
    }


    public partial class Form1 : Form
    {

        const int constNrProfessions = 12;
        private Professions[] myProfessionsArray = new Professions[constNrProfessions]
      {
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow 19 PGladius
                  new Professions(1, 1, "Protector", true, "1110111110011111101", "0100000000000000001", 1.2f, 0f),
                  new Professions(2, 1, "Man at Arms", true, "1110111110011111101", "0100111110011111101", 1.2f, 0f),
                  new Professions(3, 1, "Paladin", true, "1010111110011111101" , "0000000000000000001", 1.2f, 0f),
                  new Professions(4, 2, "Assassin", true, "1110110100000000001", "0100000000000000001", 1.2f, 0f),
                  new Professions(5, 2, "Duelist", true, "1110110100000000001" , "0100000000000000001", 1.2f, 0f),
                  new Professions(6, 2, "Ranger", false, "1010000000100000010" , "", 0f, 1.05f),
                  new Professions(7, 3, "Druid", false, "1111100001000000000", "", 1f, 0.85f),
                  new Professions(8, 3, "Priestess", false, "1111100001000000000", "", 1f, 0.85f ),
                  new Professions(9, 3, "Necromancer", false, "1111100001000000000", "", 1f, 0.85f),
                  new Professions(10, 4, "Elementalist", false, "1111010001000000001", "", 1f, 0.85f),
                  new Professions(11, 4, "Warlock", false, "1111010001000000001", "", 1f, 0.85f),
                  new Professions(12, 4, "Arcanist", false, "1111010001000000001", "", 1f, 0.85f)
      };

        const int constNrWeaponClasses = 19;
        private WeaponClass[] myWeaponClassArray = new WeaponClass[constNrWeaponClasses]
      {
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow
                  new WeaponClass(1, "Fist", false, 1.1f, 0.4f, false),    // 0.5 * 0.8
                  new WeaponClass(2, "Dagger", false, 1.2f, 0.45f, false),  // 0.5 * 0.9     
                  new WeaponClass(3, "Fist_2H", true, 1.1f, 0.675f, false),  // 0.5 * 0.9  * 1.5  
                  new WeaponClass(4, "Wand", true, 3f, 0.7f, true),  // 1 * 0.7  
                  new WeaponClass(5, "Mace", false, 1.5f, 1f, false),  // 1 * 1 
                  new WeaponClass(6, "Sword", false, 1.6f, 1f, false),  // 1 * 1 
                  new WeaponClass(7, "BSword", false, 1.8f, 1f, false),  // 1 * 1 
                  new WeaponClass(8, "Axe", false, 1.8f, 1f, false),  // 1 * 1 
                  new WeaponClass(9, "BAxe", false, 2f, 1f, false),  // 1 * 1 
                  new WeaponClass(10, "Staff", true, 2.7f, 1.04f, false),  // 1.3 * 0.8
                  new WeaponClass(11, "Bow", true, 2.3f, 1.17f, true),  // 1.3 * 0.9
                  new WeaponClass(12, "BSword2H", true, 1.8f, 1.2f, false),  // 1 * 1 * 1.2 
                  new WeaponClass(13, "BAxe2H", true, 2f, 1.2f, false),  // 1 * 1 * 1.2 
                  new WeaponClass(14, "2HMace", true, 2f, 1.3f, false),  // 1 * 1.3
                  new WeaponClass(15, "2HSword", true, 2.2f, 1.3f, false),  // 1 * 1.3
                  new WeaponClass(15, "2HAxe", true, 2.4f, 1.3f, false),  // 1 * 1.3
                  new WeaponClass(16, "Polearm", true, 2.5f, 1.3f, false),  // 1 * 1.3
                  new WeaponClass(17, "Crossbow", true, 3.3f, 1.3f, true),  // 1 * 1.3
                  new WeaponClass(18, "L1 QGarbage Practice Gladius", false, 1.6f, 0.5f, false)  // 
      };


        const int constNrAbilities = 135;
        private Ability[] myAbilityArray = new Ability[constNrAbilities]
      {
//1 Protector 
                  new Ability("Kick", true, 1, 0, "Interrupt; Aggro += Lvl + 5 ; AUTOHIT", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Thunder Clap", false, 1, 1, "AP * 0.75 ; AOE AUTOHIT !!", false, 0f, 2f, false, 0f, 12f, 10f) ,
                  new Ability("Rend", false, 1, 1, "WpAp * 0.5 and (WpAp * 1.5 + AP * 0.5) as DOT", true, 1f, 0f, true, 3f, 0f, 4f),
                  new Ability("Rend Bleed", true, 1, 1, "(WpAp * 1.5 + AP * 0.5) / NbTick", false, 0f, 0f, false, 0f, 0f, 4f),
                  new Ability("Taunt", true, 1, 1, "single target TAUNT AUTOHIT; Aggro += Lvl + 5", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Last Stand", true, 1, 1, "TotalHP *= 1.3 ; CurHP += 0.3 * TotalHP", false, 0f, 0f, false, 0f, 150f, 0f),
                  new Ability("Rage Yell", true, 1, 1, "AOE TAUNT AUTOHIT; Self *0,95 DR; +25% Damage for 20s", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Devastate", false, 1, 1, "WpAp * 1; Target Armor * (1 - 0.1 * NrStacks)", true, 1f, 0f, true, 3f, 0f, 1.5f),
                  new Ability("Retaliate", true, 1, 1, "AP * 0.5 * LvL", false, 0f, 0f, false, 0f, 0f, 1.5f),
                  new Ability("Spell Deflect", true, 1, 1, "spell deflect", false, 0f, 0f, false, 0f, 25f, 0f),
                  new Ability("Pulse Wave", false, 1, 1, "AP * 0.8 + WpAp * 0.6; AOE AUTOHIT; 3s stun", false, 0f, 3f, false, 0f, 35f, 7f),
                  new Ability("Shield Wall", true, 1, 1, "Self *0.6 DR 12s", false, 0f, 0f, false, 0f, 180f, 0f),

//2 Man at Arms
                  new Ability("Swipe", false, 2, 0, "WpAp * 0.75 AOE", true, 2f, 0f, false, 0f, 12f , 1f),
                  new Ability("Hard Strike", false, 2, 1, "WpAp * 1.3", true, 1f, 0f, true, 3f, 0f , 1f),
                  new Ability("Deadly Assault", false, 2, 1, "AP * 1.35 + WpAp * 0.7", true, 1f, 0f, true, 6f, 0f , 1f),
                  new Ability("Deep Wounds Bleed", true, 2, 1, "ParentDmg * TalentX * Stack", false, 0f, 0f, false, 0f, 0f, 1f),
                  new Ability("War Cry", true, 2, 1, "AP Bonus += AP * 0.3 * Stacks", false, 0f, 0f, false, 0f, 180f, 0f),
                  new Ability("Overwhelming Blow", false, 2, 1, "WpAp * 1.25; Target Dodge *= 0.5, Parry *= 0.5", true, 1.5f, 0f, false, 0f, 12f , 1f),
                  new Ability("Lucky Strike", true, 2, 1, "Self Crit% + = 25 for 15s", false, 0f, 0f, false, 0f, 180f, 0f),
                  new Ability("Live by The Sword", true, 2, 1, "Self Parry% += 50 for 12s", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Berserk", true, 2, 1, "Self Damage +25% for 20s", false, 0f, 0f, false, 0f, 150f, 0f),

//3 Paladin
                  new Ability("Divine Punishment", true, 3, 0, "SP * 1.5", false, 0f, 0f, false, 0f, 12f , 8f),
                  new Ability("Hammer of Justice", false, 3, 1, "(SP * AbSpeed + WpAp) *0.54", true, 1f, 0f, false, 0f, 6f, 1f),
                  new Ability("Crusader Assault", false, 3, 1, "WpAp * 1 vs primary; WpAp * 0.75 vs rest", true, 1.5f, 0f, false, 0f, 6f , 1f),
                  new Ability("Seal of Contrition", false, 3, 1, "(SP * 3.375) / NbTick; Opt +2/4/6 Crit vs target", false, 0f, 2.5f, false, 0f, 20f , 1f),
                  new Ability("Celestial Blindness", true, 3, 1, "Self AGGRO *= 0.25", false, 0f, 0f, false, 0f, 45f , 0f),
                  new Ability("Holly Barrier", true, 3, 1, "Self Rez += 25% for 5s", false, 0f, 0f, false, 0f, 30f , 0f),
                  new Ability("Holier Barrier", true, 3, 1, "Self Rez += 50% for 6s", false, 0f, 0f, false, 0f, 30f , 0f),
                  new Ability("Saintly Sacrifice", true, 3, 1, "Ally 0.25 damage to paladin for 15s", false, 0f, 0f, false, 0f, 90f , 0f),
                  new Ability("Angel's Protection", true, 3, 1, "Ally Damage Immunity for 8s", false, 0f, 0f, false, 0f, 90f , 0f),
                  new Ability("Seraphic Intervention", true, 3, 1, "Ally Resurrect Downed", false, 0f, 0f, false, 0f, 300f , 0f),

//4 Assassin
                  new Ability("Dreadful Jab", false, 4, 0, "MH WpAp * 1.35; OH WpAp * 0.5 * Side Attack; Streak+=1", true, 1f, 0f, true, 3f, 0f, 1f),
                  new Ability("Swift Knife", true, 4, 2, "AP * 1.08 * (1 + NbCombo * 0.2)", false, 0f, 0f, false, 0f, 18f, 1f),
                  new Ability("Execute", false, 4, 2, "WpAp * 1.8 * (1 + NbCombo * 0.2)", true, 1.5f, 0f, false, 0f, 12f, 1f),
                  new Ability("Deadly Poison", true, 4, 2, "(AP * 0.885 * NbStack) / NbTick; Nature", false, 0f, 0f, false, 0f, 0f, 1f),
                  new Ability("Mug", false, 4, 2, "MH WpAp * 1.035; OH WpAp * 1; Streak+=2", true, 1.25f, 0f, false, 0f, 12f, 1f),
                  new Ability("Killing Spree", true, 4, 2, "Self Haste% += 30 for 6 * (NrStreak +1)s", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Fade in the Shadows", true, 4, 2, "Self Dodge% += 30 for 15s", false, 0f, 0f, false, 0f, 180f, 0f),
                  new Ability("Thousand Knives", false, 4, 2, "WpAp * 0.75 * (1 + NbCombo * 0.2) AOE", true, 2f, 0f, false, 0f, 12f, 1f),
                  new Ability("Now or Never", true, 4, 2, "Self Streak = 5", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Hired Hitman", true, 4, 2, "Self AGGRO += *0.35; Hitman Aggro += *0.65 for 12s", false, 0f, 0f, false, 0f, 90f, 0f),
                  
                  
//5 Duelist
                  new Ability("Pommel", true, 5, 0, "no damage; Interrupt; Aggro += Lvl + 5; Streak+=1", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Sweeping Blow", false, 5, 2, "WpAp * 0.4 + AP * 0.45; *1 | *0.5; AOE AUTOHIT; Streak+=1", true, 1.5f, 0f, false, 0f, 6f, 6f),
                  new Ability("Deep Cut Bleed", true, 5, 2, "Sweep Blow: CallerDmg / 3 + 0.5", false, 0f, 0f, false, 0f, 0f, 7f),
                  new Ability("Lunge", false, 5, 2, "(WpAp + AP) * 0.5 * (1 + NbCombo * 0.40)", true, 1.5f, 0f, false, 0f, 12f, 2.5f),
                  new Ability("Invitation", true, 5, 2, "single target TAUNT AUTOHIT; Aggro += Lvl + 5; Streak+=1", false, 0f, 0f, false, 0f, 25f, 0f),
                  new Ability("Dual Strike", false, 5, 2, "MH WpAp * 1; (OH WpAp * 1 and *5 threat); Streak+=2", true, 1.25f, 0f, false, 0f, 12f, 2.5f),
                  new Ability("Recovery in Blood", true, 5, 2, "DOT = TH * 0.03 | streak extends duration ..", false, 0f, 0f, false, 0f, 75f, 0f),
                  new Ability("Piercing Strike", false, 5, 2, "MH (WpAp + AP) * 0.45;OH (WpAp + AP * 0.5) * 0.4;* (1 + NbCombo * 0.3); Nature", true, 1.5f, 0f, false, 0f, 12f, 2.5f),
                  new Ability("Blade Dancer", true, 5, 2, "Self Dodge% += 45; DR *0.85 for 12s", false, 0f, 0f, false, 0f, 120f, 0f),
                 
//6 Ranger
                  new Ability("Sniper Shot", false, 6, 0, "WpAp * 1.2 * (1 + NbCombo * 0.15)", true, 1.5f, 0f, false, 0f, 12f, 1f),
                  new Ability("Instinct Shot", false, 6, 2, "WpAp * 1.15; Streak+=1", true, 1.25f, 0f, true, 2.5f, 0f, 1f),
                  new Ability("Double Shot", false, 6, 2, "WpAp * 0.9; WpAP * 0.75 secondary'; Streak+=2", true, 1.25f, 0f, true, 2.5f, 0f, 1f),
                  new Ability("Hunter Tracking", true, 6, 2, "Self Passive Threat *0.95; Visual Smoke for 30s", false, 0f, 0f, false, 0f, 90f, 0f),
                  new Ability("Volley of Arrows", false, 6, 2, "WpAp * 0.6 * (1 + NbCombo * 0.2) / NbTick", false, 0f, 8f, false, 0f, 12f, 1f),
                  new Ability("Hemmorage Bleed", true, 6, 2, "ParentDmg * TalentX", false, 0f, 0f, false, 0f, 0f, 1f),
                  new Ability("Warning Shot", true, 6, 2, "single target TAUNT AUTOHIT; Aggro += Lvl + 5; Streak+=1", false, 0f, 0f, false, 0f, 30f, 0f),
                  new Ability("Playing Possum", true, 6, 2, "Self AGGRO *= 0; Self Stun for 2s", false, 0f, 0f, false, 0f, 60f , 0f),
                  new Ability("Sidetrack", true, 6, 2, "Self AGGRO += *0.6; Hitman Aggro += *0.4 for 9s", false, 0f, 0f, false, 0f, 60f, 0f),
                  new Ability("Rumble", true, 6, 2, "Self *0.4 DR 8s; Self Stun 8s", false, 0f, 0f, false, 0f, 180f, 0f),
                  new Ability("Night of The Hunter", true, 6, 2, "Self Haste% += 40; *0.5 DR for 15s", false, 0f, 0f, false, 0f, 120f, 0f),
//7 Druid
                  new Ability("Regrowth", false, 7, 0, "(SP * 6) / NbTick", false, 0f, 3f, false, 0f, 6f , 0.4f),
                  new Ability("Heal", false, 7, 3, "SP * 3.6", false, 0f, 1.5f, false, 0f, 6f , 0.4f),
                  new Ability("Lifebloom", false, 7, 3, "(SP * 3 * NbStack) / NbTick and SP * 2.4 * NbStack", false, 0f, 2f, false, 0f, 6f, 0.4f),
                  new Ability("Savior", true, 7, 3, "BaseHP * 0.6; (BH without *0.8 prof_mul)", false, 0f, 0f, false, 0f, 180f, 0.4f),
                  new Ability("Dance of Gaia", false, 7, 3, "(SP * 5.1) / NbTick", false, 0f, 8f, false, 0f, 6f, 0.4f),
                  new Ability("Rain of Life", true, 7, 3, "SP * 7.8 * Lerp(1.5, 0.5, Time) / NbTick ALL over 10s", false, 0f, 0f, false, 0f, 240f, 0.4f),
                  new Ability("Dispel", true, 7, 3, "Dispel 1 effect from ally", false, 0f, 0f, false, 0f, 60f, 0f),
                  new Ability("Tree Form", true, 7, 3, "Self Healing +0.15% and *0.9 DR for 20s", false, 0f, 0f, false, 0f, 120f, 0f),
//8 Priest
                  new Ability("Righteous Shield1", false, 8, 0, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 12f, 0.4f),
                  new Ability("Righteous Shield2", false, 8, 0, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 9f, 0.4f),
                  new Ability("Righteous Shield3", false, 8, 0, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 6f, 0.4f),
                  new Ability("Flash Heal", false, 8, 3, "SP * 3", false, 0f, 0.5f, false, 0f, 6f , 0.4f),
                  new Ability("Renew", false, 8, 3, "(SP * 3.6) / 3", false, 0f, 2f, false, 0f, 6f , 0.4f),
                  new Ability("Twin Heal", false, 8, 3, "Ally SP * 4.2; Self SP * 2.52", false, 0f, 3f, false, 0f, 6f , 0.4f),
                  new Ability("Sacred Nova", true, 8, 3, "SP * 2.04 ALL", false, 0f, 0f, false, 0f, 0.5f, 0.4f),
                  new Ability("Spiritual Effervescence", true, 8, 3, "?? amount extra shield like layer of HP", false, 0f, 0f, false, 0f, 0f, 0.4f),
                  new Ability("Prayer of Redemption 1", false, 8, 3, "SP * 3.18 ALL", false, 0f, 6f, false, 0f, 6f , 0.4f),
                  new Ability("Prayer of Redemption 2", false, 8, 3, "SP * 3.18 ALL", false, 0f, 5f, false, 0f, 6f , 0.4f),
                  new Ability("Prayer of Redemption 3", false, 8, 3, "SP * 3.18 ALL", false, 0f, 4f, false, 0f, 6f , 0.4f),
                  new Ability("Arhangel Wrath 2/2", true, 8, 3, "Self *0.7 DR for 8s after hit", false, 0f, 0f, false, 0f, 0f, 0f),
                  new Ability("Mortification", true, 8, 3, "Ally *0.6 DR for 12s", false, 0f, 0f, false, 0f, 120f, 0.4f),
                  new Ability("Sacrament", false, 8, 3, "(SP * 8.4) / NbTick", false, 0f, 6f, false, 0f, 15f, 0.4f),
                  new Ability("Blessed Spirit", false, 8, 3, "SP * 2.52; jumps after heal 5 times last 30s per jump", false, 0f, 3f, false, 0f, 20f, 0.4f),
//9 Necromancer
                  new Ability("Seal of Necromancy", true, 9, 0, "SP * 1.8 * TCO after 20s", false, 0f, 0f, false, 0f, 10f, 0.4f),
                  new Ability("Soul Sucking", false, 9, 3, "SP * 1.2 and [SP * 3.42 + SP * 2.052] heals", false, 0f, 4f, false, 0f, 6f, 1.4f),
                  new Ability("Eat My Flesh", false, 9, 3, "SP * 1.26 self harm and SP * 2.52 * 1.5 OpenB heal", false, 0f, 2f, false, 0f, 6f, 0.4f),
                  new Ability("Soul Eater", false, 9, 3, "(SP * 3.9) / NbTick ; *3 heal", false, 0f, 3f, false, 0f, 10f, 1.4f),
                  new Ability("Last Incantation", false, 9, 3, "(SP * 6.3) * Lerp(0.35, 1.65, Time) / NbTick 21s + SP * 2.1 at end", false, 0f, 3.5f, false, 0f, 6f , 0.4f),
                  new Ability("Army of Darkness", false, 9, 3, "SP * 3.9; DR * 0.7 DR ALL", false, 0f, 5f, false, 0f, 6f , 0.4f),
                  new Ability("Over My Dead Body", true, 9, 3, "Sustained TAUNT; * 0.4 DR ;12s; AGGRO*=0.5 vs all at end", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Raise From the Dead", true, 9, 3, "25s mark. Raise and heal SP * 6 * (0.2 + CallerTime * 1.4)", false, 0f, 3f, false, 0f, 120f, 0f),
                  new Ability("Touch of Death", true, 9, 3, "Haste -30 for 12s", false, 0f, 0f, false, 0f, 120f, 0f),
//10 Elementalist
                  new Ability("Scorch", false, 10, 0, "SP * 1.86 and (SP * 1.89) / NbTick DOT", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt1", false, 10, 4, "SP * 3.125", false, 0f, 2.5f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt2", false, 10, 4, "SP * 3.125", false, 0f, 1.5f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt3", false, 10, 4, "SP * 3.125", false, 0f, 0.5f, false, 0f, 6f, 1f),
                  new Ability("Fireball", false, 10, 4, "SP * 3.6 primary; * 0.7 rest;?damage loss range?; upto 0.6 as DOT", false, 0f, 4f, false, 0f, 6f, 1f),
                  new Ability("Rain of Fire 1", false, 10, 4, "SP * 0.95 4 ticks", false, 0f, 8f, false, 0f, 20f, 1f),
                  new Ability("Rain of Fire 2", false, 10, 4, "SP * 0.95 4 ticks", false, 0f, 8f, false, 0f, 17f, 1f),
                  new Ability("Rain of Fire 3", false, 10, 4, "SP * 0.95 4 ticks", false, 0f, 8f, false, 0f, 14f, 1f),
                  new Ability("Water Shield", true, 10, 4, "Self *0.85 DR for 15s", false, 0f, 0f, false, 0f, 90f, 0f),
                  new Ability("Ice Shield", true, 10, 4, "Self *0.7 DR; Rest *0.85 DR for 15s", false, 0f, 0f, false, 0f, 90f, 0f),
                  new Ability("Ice Blast", true, 10, 4, "SP * 4.4", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Focus", true, 10, 4, "Self CurMana += TM * 0.25", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Cauterize", true, 10, 4, "CurHP =  TH * 0.4 heal on death then bleed 0.3 * TH for 6s", false, 0f, 0f, false, 0f, 60f, 0f),
//11 Warlock
                  new Ability("Torment", false, 11, 0, "(SP * 4.08) / NbTick", false, 0f, 2.5f, false, 0f, 6f, 1f),
                  new Ability("Shadowball1", false, 11, 4, "SP * 3.78", false, 0f, 4f, false, 0f, 6f, 1f),
                  new Ability("Shadowball2", false, 11, 4, "SP * 3.78", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Shadowball3", false, 11, 4, "SP * 3.78", false, 0f, 2f, false, 0f, 6f, 1f),
                  new Ability("DirePlague", false, 11, 4, "(SP * 4.5) * Lerp(0.5, 1.5, Time) / NbTick", false, 0f, 5f, false, 0f, 6f, 1f),
                  new Ability("Hellfire 1", false, 11, 4, "(SP * 3.6 * 1) / NbTick; 4 ticks", false, 0f, 8f, false, 0f, 20f, 1f),
                  new Ability("Hellfire 2", false, 11, 4, "(SP * 3.6 * 1.25) / NbTick; 5 ticks", false, 0f, 10f, false, 0f, 20f, 1f),
                  new Ability("Hellfire 3", false, 11, 4, "(SP * 3.6 * 1.5) / NbTick; 6 ticks", false, 0f, 12f, false, 0f, 20f, 1f),
                  new Ability("Drain Life", false, 11, 4, "(SP * 2.4) / NbTick; 3 ticks", false, 0f, 5f, false, 0f, 6f, 1f),
                  new Ability("Lethal Empowerment", true, 11, 4, "Self TH * 0.15 damage, CurMana+= CallerDmg * MWTP", false, 0f, 0f, false, 0f, 3f, 0f),
                  new Ability("Dominate1", false, 11, 4, "SP * 1.92; 20% DOT buff for 12s", false, 0f, 3.5f, false, 0f, 6f, 1f),
                  new Ability("Dominate2", false, 11, 4, "SP * 1.92; 20% DOT buff for 12s", false, 0f, 2.5f, false, 0f, 6f, 1f),
                  new Ability("Dominate3", false, 11, 4, "SP * 1.92; 20% DOT buff for 12s", false, 0f, 1.5f, false, 0f, 6f, 1f),
                  new Ability("Demonic Form", true, 11, 4, "50% WD, 20% ShadowD, *0.5 DR for 15s", false, 0f, 0f, false, 0f, 150f, 0f),
//12 Arcanist
                  new Ability("Arcane Rupture1", false, 12, 0, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 12f, 1f),
                  new Ability("Arcane Rupture2", false, 12, 0, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 11f, 1f),
                  new Ability("Arcane Rupture3", false, 12, 0, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 10f, 1f),
                  new Ability("Arcane Rupture4", false, 12, 0, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 9f, 1f),
                  new Ability("Arcane Burst1", false, 12, 4, "(SP * 4.2) / NbTick", false, 0f, 4f, false, 0f, 6f, 1f),
                  new Ability("Arcane Burst2", false, 12, 4, "(SP * 4.2) / NbTick", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Arcane Burst3", false, 12, 4, "(SP * 4.2) / NbTick", false, 0f, 2f, false, 0f, 6f, 1f),
                  new Ability("Arcane Lock", true, 12, 4, "Lock target 18s", false, 0f, 0f, false, 0f, 30f, 0f),
                  new Ability("Arcane Armor", true, 12, 4, "Ally +15% Armor for 10 + 15s", false, 0f, 0f, false, 0f, 120f, 0f),
                  new Ability("Arcane Fusion", true, 12, 4, "(SP * 0.39 * NbStack) / NbTick up to 3 stacks over 15s", false, 0f, 0f, false, 0f, 0f, 1f),
                  new Ability("Mind Focus", true, 12, 4, "Ally Crit+=15% for 45s; Self Crit+=12%", false, 0f, 0f, false, 0f, 180f, 0f),
                  new Ability("Total Rupture", true, 12, 4, "Resets Arcane Rupture cooldown", false, 0f, 0f, false, 0f, 40f, 0f),
                  new Ability("Esoteric Connection", true, 12, 4, "Damage All Squad +=0.06% for ", false, 0f, 0f, false, 0f, 90f, 0f),
                  new Ability("Arcane Implosion", true, 12, 4, "SP * 1.62 * (1 + NrArcaneRuptureStacks)", false, 0f, 0f, false, 0f, 30f, 0f),
                  new Ability("Overcharge", true, 12, 4, "+20% Arcane Damage for 20s", false, 0f, 0f, false, 0f, 90f, 0f)
    };

        int GlobalTempButtonTotal = 0; // global var
        int Global_top = 530;
        int Global_left = 0;
        float constScalingCoef = 200;
        Color Ability_Cooldown_Color= Color.Chartreuse;
        Color GCD_Cooldown_Color = Color.Aqua;
        Color Ability_Cast_Color = Color.Red;
        Color MH_Cast_Color_A = Color.LightPink;
        Color MH_Cast_Color_B = Color.DeepPink;
        Color OH_Cast_Color = Color.Yellow;
        Color MH_Cooldown_Color = Color.DarkSlateBlue;
        Color Time_Scale_Color = Color.Coral;


        public Form1()
        {
            InitializeComponent();
        }

        private void PlaceButton(float X, int Y, float width, string TimeText, Color BotonColor)
        {

            
            Button button = new Button();
            button.Left = Global_left + (int)(X* constScalingCoef);
            button.Top = Global_top + Y;
            button.Text = TimeText;
            button.Enabled = false;
            button.BackColor = BotonColor;
            button.Width = (int)(width * constScalingCoef);
           // button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 6);
            button.Name = "temp" + GlobalTempButtonTotal.ToString(); // ALL BUTTONS WILL HAVE this type of name for easy removal
            this.Controls.Add(button); GlobalTempButtonTotal++;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // REMEMBER TO DELETE THE PREVIOUS BUTTONZ
            // OTHERWISE YOU KEEP ADDING MILLIONZ OF BUTTONS
            RemoveTempButtons(GlobalTempButtonTotal); GlobalTempButtonTotal = 0;

            // need to define X axis scaling  Accumulated time to Screen Pixels
            // hop many pixels do I have to work with ? 1920 in 1920x1080 resolution
            // how much total time DO I NEED ? 20 * 4 = 80 seconds should cover it; 1600/80 = 20 pixels per second .. Not great resolution
            // So can I do Width = duration * 20 ? 
  
// find index of selected MH weapon
            int MHWPNID = 0;
            do
            {
                if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                MHWPNID++;
            } while (MHWPNID < constNrWeaponClasses);

            // If  DW is checked get OHWPN index
    
            int OHWPNID = 0; float DW_SPD_MUL = 1f;
            if (checkBoxDualWield.Checked)
            {

                DW_SPD_MUL = 0.5f;
                do
                {
                    if (myWeaponClassArray[OHWPNID].Name.Equals(comboBox_OH_WPN.SelectedItem)) break;
                    OHWPNID++;
                } while (OHWPNID < constNrWeaponClasses);


                //temp test
               // textBox3.Text = myWeaponClassArray[OHWPNID].Name;
            }

            // NEED TO GET HASTE multiplier once and have it . 
            float hastepercent, haste_MUL;
            hastepercent = float.Parse(textBox_Haste.Text);
            if (hastepercent < 0) haste_MUL = 1 - hastepercent / 100; else haste_MUL = 1 / (1 + hastepercent / 100);

/*
            // find index of Abilities selection
                      float[] QueuedAbilityIndex = new float[4];
            int AbilityID = 0;
                 do
                 {
                if (myAbilityArray[AbilityID].Name.Equals(comboBox_Queued_Ability1.SelectedItem)) break;
                AbilityID++;
                 } while (AbilityID < constNrAbilities);
            QueuedAbilityIndex[0] = AbilityID;

            AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(comboBox_Queued_Ability2.SelectedItem)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);
            QueuedAbilityIndex[1] = AbilityID;

            AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(comboBox_Queued_Ability3.SelectedItem)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);
            QueuedAbilityIndex[2] = AbilityID;

            AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(comboBox_Queued_Ability4.SelectedItem)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);
            QueuedAbilityIndex[3] = AbilityID;
            */

        
            //////////////////// WILL NEED 6 paralel time lines to display all relevant timers . Game UI doesn't show all of them .. Bad job at distinguishing between the one that are shown.
            //////////////////// GlobalCD
            //////////////////// AbilityCD
            //////////////////// Ability cast time
            //////////////////// AA Cast (MH_A, MH_B, OH)
            //////////////////// MHCD (relevant for explaining limbo - when upgrading to faster ability) 
            //////////////////// WGCD (there are gaps here during 1st half of MH attack - to enable mutation) 

            // load up queued ability indexes in array for easy handling. 

            int CurrentAbility = 0; float CurentTime = 0; float IntermediateCurentTime ;  float TimeToBeat;
           string[] QueuedAbilityNames = new string[4];
            QueuedAbilityNames[0] = comboBox_Queued_Ability1.SelectedItem.ToString();
            QueuedAbilityNames[1] = comboBox_Queued_Ability2.SelectedItem.ToString();
            QueuedAbilityNames[2] = comboBox_Queued_Ability3.SelectedItem.ToString();
            QueuedAbilityNames[3] = comboBox_Queued_Ability4.SelectedItem.ToString();
            // there are still Labels to read values from . Either manually load up their values in extra arrays or find control by name ..  
            float[] QueuedAbilityCastTimes = new float[4]; float[] QueuedAbilityCooldownTimes = new float[4];
            QueuedAbilityCastTimes[0] = float.Parse(labelQ1BaseCastTime.Text); QueuedAbilityCooldownTimes[0] = float.Parse(labelQ1Cooldown.Text);
            QueuedAbilityCastTimes[1] = float.Parse(labelQ2BaseCastTime.Text); QueuedAbilityCooldownTimes[1] = float.Parse(labelQ2Cooldown.Text);
            QueuedAbilityCastTimes[2] = float.Parse(labelQ3BaseCastTime.Text); QueuedAbilityCooldownTimes[2] = float.Parse(labelQ3Cooldown.Text);
            QueuedAbilityCastTimes[3] = float.Parse(labelQ4BaseCastTime.Text); QueuedAbilityCooldownTimes[3] = float.Parse(labelQ4Cooldown.Text);
            int[] AB_CD_Offset =new int[4]; AB_CD_Offset[0] = 90; AB_CD_Offset[1] = 60; AB_CD_Offset[2] = 30; AB_CD_Offset[3] = 0;
            float LimboTime = 0; int tempI;
            float[] AbilityCooldownEndTime = new float[4]; AbilityCooldownEndTime[0] = AbilityCooldownEndTime[1] = AbilityCooldownEndTime[2] = AbilityCooldownEndTime[3] = 0;


            while (CurrentAbility < 4) 
            {
                PlaceButton(CurentTime, AB_CD_Offset[CurrentAbility], QueuedAbilityCooldownTimes[CurrentAbility], QueuedAbilityCooldownTimes[CurrentAbility].ToString("0.00"), Ability_Cooldown_Color ); // AB_CD
                PlaceButton(CurentTime, 120, 6 * haste_MUL, (6 * haste_MUL).ToString("0.00"), GCD_Cooldown_Color);  // GCD
                PlaceButton(CurentTime, 150, QueuedAbilityCastTimes[CurrentAbility] * haste_MUL, (QueuedAbilityCastTimes[CurrentAbility] * haste_MUL).ToString("0.00"), Ability_Cast_Color); // AB_CAST TIME      

               AbilityCooldownEndTime[CurrentAbility] = CurentTime + QueuedAbilityCooldownTimes[CurrentAbility];

                //   if ( CurrentAbility == 3) TimeToBeat =  6 * haste_MUL;
                //   else if (QueuedAbilityNames[CurrentAbility].Equals( QueuedAbilityNames[CurrentAbility+1])) TimeToBeat = Math.Max(QueuedAbilityCooldownTimes[CurrentAbility], 6 * haste_MUL);
                //         else TimeToBeat =  6 * haste_MUL;

               
                tempI = CurrentAbility;

                TimeToBeat = 6 * haste_MUL;
                if (CurrentAbility < 3)  while  (tempI >= 0)
                    {
                     if (QueuedAbilityNames[CurrentAbility+1].Equals(QueuedAbilityNames[tempI])) if (AbilityCooldownEndTime[tempI] > CurentTime + TimeToBeat) TimeToBeat = AbilityCooldownEndTime[tempI] - CurentTime;
                        tempI--;
                    }

                CurrentAbility++; IntermediateCurentTime = 0;
                if ((QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL) >= TimeToBeat) { CurentTime += QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL; continue; }
                else
                {

                    IntermediateCurentTime += QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL;
                    
                    do { 
                    // fill in with AAs 
                    if (checkBoxDualWield.Checked)
                    {
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL, (myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL).ToString("0.00"), OH_Cast_Color); // OH Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 240, myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL, (myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL).ToString("0.00"), GCD_Cooldown_Color); // OH WGCD
                            IntermediateCurentTime += myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL;
                       if (IntermediateCurentTime >= TimeToBeat) { CurentTime += IntermediateCurentTime; break; }; 
                    }

                        //AND LIMBO
                        if (LimboTime > CurentTime + IntermediateCurentTime) IntermediateCurentTime = LimboTime - CurentTime;


                            // MH_A
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), MH_Cast_Color_A ); // MH_A Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 210, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL).ToString("0.00"), MH_Cooldown_Color); // MH Cooldown
                        IntermediateCurentTime += myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL;
                        if (IntermediateCurentTime >= TimeToBeat) {
                            CurentTime += IntermediateCurentTime - myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL;
                            LimboTime = CurentTime + myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL; 
                            break; };

                     

                        // ADD MH_B
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), MH_Cast_Color_B ); // MH_B Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 240, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), GCD_Cooldown_Color); // MH WGCD
                        IntermediateCurentTime += myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL;
                        if (IntermediateCurentTime >= TimeToBeat)
                        {
                            CurentTime += IntermediateCurentTime;
                            break;
                        };


                    } while (true) ;

                }

               
            } 

        }

        private void TempRemoveTest_Click(object sender, EventArgs e)
        {
            RemoveTempButtons(GlobalTempButtonTotal);

        }

        private void RemoveTempButtons(int NrButtons)
        {
            for (int i = 0; i < NrButtons; i++)
            {
                Control ctn = this.Controls["temp" + i.ToString()];
                this.Controls.Remove(ctn);
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RePopulateCombos(); Button button;

            // X time axis
            for (int i = 0; i < 100; i++)
            {
                 button = new Button();
                button.Left = (int)(Global_left + 0.5 * i * constScalingCoef);
                button.Top = Global_top + 270;
                button.Enabled = false;
                button.BackColor = Time_Scale_Color;
                button.Width = (int)(0.5 * constScalingCoef);
                button.Text = ((float)(0.5 * i)).ToString();
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font(button.Font.FontFamily, 6);
                this.Controls.Add(button);
            }

            //     Color Ability_Cooldown_Color = Color.Chartreuse;
            //     Color GCD_Cooldown_Color = Color.Aqua;
            //     Color Ability_Cast_Color = Color.Red;
            //     Color MH_Cast_Color_A = Color.LightPink;
            //     Color MH_Cast_Color_B = Color.DeepPink;
            //     Color OH_Cast_Color = Color.Yellow;
            //     Color MH_Cooldown_Color = Color.DarkSlateBlue;
            //     Color Time_Scale_Color = Color.Coral;


            // can't use place button - since it will die at refresh
            //      PlaceButton(Global_left, 600, 50, "Ability_Cooldown_Color", Ability_Cooldown_Color);

            button = new Button();
            button.Left = 0;
            button.Top = Global_top + 360;
            button.Enabled = false;
            button.BackColor = Ability_Cooldown_Color;
            button.Width = 250;
            button.Text = "Ability_Cooldown_Color";
        //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 300;
            button.Top = Global_top + 360;
            button.Enabled = false;
            button.BackColor = GCD_Cooldown_Color;
            button.Width = 250;
            button.Text = "GCD_Cooldown_Color";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 600;
            button.Top = Global_top + 360;
            button.Enabled = false;
            button.BackColor = Ability_Cast_Color;
            button.Width = 250;
            button.Text = "Ability_Cast_Color";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 900;
            button.Top = Global_top + 360;
            button.Enabled = false;
            button.BackColor = Time_Scale_Color;
            button.Width = 250;
            button.Text = "Time_Scale_Color";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);


            button = new Button();
            button.Left = 0;
            button.Top = Global_top + 360 + 30;
            button.Enabled = false;
            button.BackColor = OH_Cast_Color;
            button.Width = 250;
            button.Text = "OH_Cast_Color";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 300;
            button.Top = Global_top + 360 + 30;
            button.Enabled = false;
            button.BackColor = MH_Cast_Color_A;
            button.Width = 250;
            button.Text = "MH_Cast_Color_A";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 600;
            button.Top = Global_top + 360 + 30;
            button.Enabled = false;
            button.BackColor = MH_Cast_Color_B;
            button.Width = 250;
            button.Text = "MH_Cast_Color_B";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);

            button = new Button();
            button.Left = 900;
            button.Top = Global_top + 360 + 30;
            button.Enabled = false;
            button.BackColor = MH_Cooldown_Color;
            button.Width = 250;
            button.Text = "MH_Cooldown_Color";
            //    button.TextAlign = ContentAlignment.MiddleLeft;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font(button.Font.FontFamily, 8);
            this.Controls.Add(button);
        }

        private void RePopulateCombos()
        {
           
            // weapons and abilities comboboxes need to be reset by selection event on comboBox_Profession

            //bellow char level // weapon levels
            comboBox_Char_Lvl.SelectedIndex = 0;


            comboBox_MH_W_QLTY.SelectedIndex = 3;
            comboBox_OH_W_QLTY.SelectedIndex = 3;

            comboBox_MH_WPN_Lvl.SelectedIndex = 0;
            comboBox_OH_WPN_Lvl.SelectedIndex = 0;


            comboBox_Profession.Items.Clear();
            for (int i = 0; i < constNrProfessions; i++)
            {
                comboBox_Profession.Items.Add(myProfessionsArray[i].Name);
            }
            comboBox_Profession.SelectedIndex = 0;


        }

        private void comboBox_Profession_SelectedIndexChanged(object sender, EventArgs e)
        {

            // get the Name of selected profession
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            int ProfessionID = 0;

            do
            {
                if (myProfessionsArray[ProfessionID].Name.Equals(selected)) break;
                ProfessionID++;
            } while (ProfessionID < constNrProfessions);


            // populate MH list

            int MHID = 0; comboBox_MH_WPN.Items.Clear();
            do
            {
                if (myProfessionsArray[ProfessionID].MH[MHID] == '1')
                {
                    comboBox_MH_WPN.Items.Add(myWeaponClassArray[MHID].Name);
                }
                MHID++;
            } while (MHID < constNrWeaponClasses);
            comboBox_MH_WPN.SelectedIndex = 0;

            comboBox_OH_WPN.Items.Clear(); comboBox_OH_WPN.Text = "";
            // if DW = true  enable OH and check box else disable them
            if (myProfessionsArray[ProfessionID].DW)
            {
                checkBoxDualWield.Enabled = true;
                //populate it
                int OHID = 0;
                do
                {
                    if (myProfessionsArray[ProfessionID].OH[OHID] == '1')
                    {
                        comboBox_OH_WPN.Items.Add(myWeaponClassArray[OHID].Name);
                    }
                    OHID++;
                } while (OHID < constNrWeaponClasses);
                comboBox_OH_WPN.SelectedIndex = 0;
            }
            else
            {
                checkBoxDualWield.Enabled = false;
                checkBoxDualWield.Checked = false;
                comboBox_OH_WPN.Enabled = false;
            }

            update_RAP();

            // clear checkboxes AND labels
            comboBox_Queued_Ability1.Items.Clear(); comboBox_Queued_Ability2.Items.Clear(); comboBox_Queued_Ability3.Items.Clear(); comboBox_Queued_Ability4.Items.Clear();
            comboBox_InstantAbilities.Items.Clear();
            comboBox_Queued_Ability1.Text = ""; comboBox_Queued_Ability2.Text = ""; comboBox_Queued_Ability3.Text = ""; comboBox_Queued_Ability4.Text = ""; comboBox_InstantAbilities.Text = "";

            labelQ1DamageFormula.Text = labelQ2DamageFormula.Text = labelQ3DamageFormula.Text = labelQ4DamageFormula.Text = labelInstantDamageFormula.Text = "";
            labelQ1BaseCastTime.Text = labelQ2BaseCastTime.Text = labelQ3BaseCastTime.Text = labelQ4BaseCastTime.Text = "";
            labelQ1Cooldown.Text = labelQ2Cooldown.Text = labelQ3Cooldown.Text = labelQ4Cooldown.Text = labelInstantCooldown.Text = "";
            labelQ1ThreatMul.Text = labelQ2ThreatMul.Text = labelQ3ThreatMul.Text = labelQ4ThreatMul.Text = labelInstantThreatMul.Text = "";

            // populate Queable ablity list [queue times 4]  // populate the instant abilities
            // first pass add profession abilties

            for (int i = 0; i < constNrAbilities; i++)
            {

                if (myAbilityArray[i].ProfessionID == (ProfessionID + 1))
                {
                    if (myAbilityArray[i].Instant)
                    {
                        comboBox_InstantAbilities.Items.Add(myAbilityArray[i].Name);
                        comboBox_InstantAbilities.SelectedIndex = 0;


                    }
                    else
                    {
                        comboBox_Queued_Ability1.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability1.SelectedIndex = 0;
                        comboBox_Queued_Ability2.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability2.SelectedIndex = 0;
                        comboBox_Queued_Ability3.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability3.SelectedIndex = 0;
                        comboBox_Queued_Ability4.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability4.SelectedIndex = 0;


                    }
                }
            }
            // second pass ADD rest of the class abilities ?
            // class matches and profession differs
            for (int i = 0; i < constNrAbilities; i++)
            {

                if ((myAbilityArray[i].ProfessionID != (ProfessionID + 1)) && (myAbilityArray[i].Class == (myProfessionsArray[ProfessionID].Class )))
                {
                    if (myAbilityArray[i].Instant)
                    {
                        comboBox_InstantAbilities.Items.Add(myAbilityArray[i].Name);
                        comboBox_InstantAbilities.SelectedIndex = 0;


                    }
                    else
                    {
                        comboBox_Queued_Ability1.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability1.SelectedIndex = 0;
                        comboBox_Queued_Ability2.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability2.SelectedIndex = 0;
                        comboBox_Queued_Ability3.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability3.SelectedIndex = 0;
                        comboBox_Queued_Ability4.Items.Add(myAbilityArray[i].Name); comboBox_Queued_Ability4.SelectedIndex = 0;


                    }
                }
            }

        }

        private void checkBoxDualWield_CheckedChanged(object sender, EventArgs e)
        {
             CheckBox  checkBox = (CheckBox)sender;
            if (checkBox.Checked) update_OH_W_WpAp();
            update_AA_DPS(); ;
        }

        private void comboBox_MH_WPN_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;


            int ProfessionID = 0;

            do
            {
                if (myProfessionsArray[ProfessionID].Name.Equals(comboBox_Profession.SelectedItem)) break;
                ProfessionID++;
            } while (ProfessionID < constNrProfessions);

            // find out index on weapon
            int MHID = 0;
            do
            {
                if (myWeaponClassArray[MHID].Name.Equals(selected)) break;

                MHID++;
            } while (MHID < constNrWeaponClasses);

            textBox_MH_SPD.Text = myWeaponClassArray[MHID].Speed.ToString();

            if (myProfessionsArray[ProfessionID].DW)
            {
                // when 2H weapon in MH clear off hand UNLESS profession = Man At Arms
                if ((myWeaponClassArray[MHID].TwoHanded) && (!comboBox_Profession.SelectedItem.Equals("Man at Arms")))
                {
                    checkBoxDualWield.Checked = false; checkBoxDualWield.Enabled = false; comboBox_OH_WPN.Enabled = false;
                }
                // when 1H weapon in MH enable dual wield check box and off hand selection
                if (!myWeaponClassArray[MHID].TwoHanded)
                {
                    checkBoxDualWield.Enabled = true; comboBox_OH_WPN.Enabled = true;
                }

            }
            // NEED TO TRIGGER ABILITY COMBO EVENTS BECAUSE THEIR COOLDOWNS MIGHT DEPEND On WEAPON SPEED

            update_MH_W_DPS(); update_RAP();


            comboBox_Queued_Ability1_SelectedIndexChanged(comboBox_Queued_Ability1, new EventArgs());
            comboBox_Queued_Ability2_SelectedIndexChanged(comboBox_Queued_Ability2, new EventArgs());
            comboBox_Queued_Ability3_SelectedIndexChanged(comboBox_Queued_Ability3, new EventArgs());
            comboBox_Queued_Ability4_SelectedIndexChanged(comboBox_Queued_Ability4, new EventArgs());
            comboBox_InstantAbilities_SelectedIndexChanged(comboBox_InstantAbilities, new EventArgs());

        }

        private void update_MH_W_DPS()
        {

            // calculate MH_W_DPS
            //W_DPS = (5 + 0.5 * W_LVL) * W_QLTY * W_DamageMul * (0.85 + (W_SPD-1) * 0.02)

        
            if (!(comboBox_MH_W_QLTY.SelectedItem == null) && !(comboBox_MH_WPN_Lvl.SelectedItem == null))
            {
                if (!(comboBox_MH_WPN.SelectedItem == null))
                    {
                    //  textBox3.Text = float.Parse(comboBox_MH_W_QLTY.SelectedItem.ToString().Substring(0, 4)).ToString();

                    //get selected weapon index 

                    int MHID = 0;
                    do
                    {
                        if (myWeaponClassArray[MHID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;

                        MHID++;
                    } while (MHID < constNrWeaponClasses);


                    textBox_MH_W_DPS.Text = ((5f + 0.5f * (float.Parse(comboBox_MH_WPN_Lvl.SelectedItem.ToString()))) * float.Parse(comboBox_MH_W_QLTY.SelectedItem.ToString().Substring(0, 4)) * myWeaponClassArray[MHID].DamageMultiplier * (0.85 + (myWeaponClassArray[MHID].Speed  - 1) * 0.02)).ToString("0.00");
                }
            }

        }

        private void update_OH_W_DPS()
        {

            // calculate OH_W_DPS
            //W_DPS = (5 + 0.5 * W_LVL) * W_QLTY * W_DamageMul * (0.85 + (W_SPD-1) * 0.02)
            if (!(comboBox_OH_W_QLTY.SelectedItem == null) && !(comboBox_OH_WPN_Lvl.SelectedItem == null))
            {
                if (!(comboBox_OH_WPN.SelectedItem == null))
                {
                    //  textBox3.Text = float.Parse(comboBox_OH_W_QLTY.SelectedItem.ToString().Substring(0, 4)).ToString();

                    //get selected weapon index 

                    int OHID = 0;
                    do
                    {
                        if (myWeaponClassArray[OHID].Name.Equals(comboBox_OH_WPN.SelectedItem)) break;

                        OHID++;
                    } while (OHID < constNrWeaponClasses);


                    textBox_OH_W_DPS.Text = ((5f + 0.5f * (float.Parse(comboBox_OH_WPN_Lvl.SelectedItem.ToString()))) * float.Parse(comboBox_OH_W_QLTY.SelectedItem.ToString().Substring(0, 4)) * myWeaponClassArray[OHID].DamageMultiplier * (0.85 + (myWeaponClassArray[OHID].Speed - 1) * 0.02)).ToString("0.00");
                }
            }
        }

        private void comboBox_Queued_Ability1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
          ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            // find selected ability index

            int AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(selected)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);

            if (AbilityID < constNrAbilities)  // even might fire from weapon change before we have data in this combobox 
            { 

            labelQ1DamageFormula.Text = myAbilityArray[AbilityID].AbilityFormula;

            // find selected MH index [in case we need weapon speed]

            int MHWPNID = 0;
            do
            {
                if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                MHWPNID++;
            } while (MHWPNID < constNrWeaponClasses );

            if (myAbilityArray[AbilityID].CastType) labelQ1BaseCastTime.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CastDurationWeaponSPDMul).ToString();
                else labelQ1BaseCastTime.Text = myAbilityArray[AbilityID].FixedCastDuration.ToString();

           if (myAbilityArray[AbilityID].CooldownType) labelQ1Cooldown.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CooldownDurationWeaponSPDMul).ToString();
                else labelQ1Cooldown.Text = myAbilityArray[AbilityID].FixedCooldownDuration.ToString();

                labelQ1ThreatMul.Text = myAbilityArray[AbilityID].ThreatMul.ToString() ;

            }
    }

        private void comboBox_Queued_Ability2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            // find selected ability index

            int AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(selected)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);

            if (AbilityID < constNrAbilities)  // even might fire from weapon change before we have data in this combobox 
            {

                labelQ2DamageFormula.Text = myAbilityArray[AbilityID].AbilityFormula;

                // find selected MH index [in case we need weapon speed]

                int MHWPNID = 0;
                do
                {
                    if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                    MHWPNID++;
                } while (MHWPNID < constNrWeaponClasses);

                if (myAbilityArray[AbilityID].CastType) labelQ2BaseCastTime.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CastDurationWeaponSPDMul).ToString();
                else labelQ2BaseCastTime.Text = myAbilityArray[AbilityID].FixedCastDuration.ToString();

                if (myAbilityArray[AbilityID].CooldownType) labelQ2Cooldown.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CooldownDurationWeaponSPDMul).ToString();
                else labelQ2Cooldown.Text = myAbilityArray[AbilityID].FixedCooldownDuration.ToString();

                labelQ2ThreatMul.Text = myAbilityArray[AbilityID].ThreatMul.ToString();

            }
        }

        private void comboBox_Queued_Ability3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            // find selected ability index

            int AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(selected)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);

            if (AbilityID < constNrAbilities)  // even might fire from weapon change before we have data in this combobox 
            {

                labelQ3DamageFormula.Text = myAbilityArray[AbilityID].AbilityFormula;

                // find selected MH index [in case we need weapon speed]

                int MHWPNID = 0;
                do
                {
                    if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                    MHWPNID++;
                } while (MHWPNID < constNrWeaponClasses);

                if (myAbilityArray[AbilityID].CastType) labelQ3BaseCastTime.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CastDurationWeaponSPDMul).ToString();
                else labelQ3BaseCastTime.Text = myAbilityArray[AbilityID].FixedCastDuration.ToString();

                if (myAbilityArray[AbilityID].CooldownType) labelQ3Cooldown.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CooldownDurationWeaponSPDMul).ToString();
                else labelQ3Cooldown.Text = myAbilityArray[AbilityID].FixedCooldownDuration.ToString();

                labelQ3ThreatMul.Text = myAbilityArray[AbilityID].ThreatMul.ToString();

            }
        }

        private void comboBox_Queued_Ability4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            // find selected ability index

            int AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(selected)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);

            if (AbilityID < constNrAbilities)  // even might fire from weapon change before we have data in this combobox 
            {

                labelQ4DamageFormula.Text = myAbilityArray[AbilityID].AbilityFormula;

                // find selected MH index [in case we need weapon speed]

                int MHWPNID = 0;
                do
                {
                    if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                    MHWPNID++;
                } while (MHWPNID < constNrWeaponClasses);

                if (myAbilityArray[AbilityID].CastType) labelQ4BaseCastTime.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CastDurationWeaponSPDMul).ToString();
                else labelQ4BaseCastTime.Text = myAbilityArray[AbilityID].FixedCastDuration.ToString();

                if (myAbilityArray[AbilityID].CooldownType) labelQ4Cooldown.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CooldownDurationWeaponSPDMul).ToString();
                else labelQ4Cooldown.Text = myAbilityArray[AbilityID].FixedCooldownDuration.ToString();

                labelQ4ThreatMul.Text = myAbilityArray[AbilityID].ThreatMul.ToString();

            }
        }

        private void comboBox_InstantAbilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            // find selected ability index

            int AbilityID = 0;
            do
            {
                if (myAbilityArray[AbilityID].Name.Equals(selected)) break;
                AbilityID++;
            } while (AbilityID < constNrAbilities);

            if (AbilityID < constNrAbilities)  // even might fire from weapon change before we have data in this combobox 
            {

                labelInstantDamageFormula.Text = myAbilityArray[AbilityID].AbilityFormula;

                // find selected MH index [in case we need weapon speed]

                int MHWPNID = 0;
                do
                {
                    if (myWeaponClassArray[MHWPNID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;
                    MHWPNID++;
                } while (MHWPNID < constNrWeaponClasses);

             
                if (myAbilityArray[AbilityID].CooldownType) labelInstantCooldown.Text = (myWeaponClassArray[MHWPNID].Speed * myAbilityArray[AbilityID].CooldownDurationWeaponSPDMul).ToString();
                else labelInstantCooldown.Text = myAbilityArray[AbilityID].FixedCooldownDuration.ToString();

                labelInstantThreatMul.Text = myAbilityArray[AbilityID].ThreatMul.ToString();

            }
        }

        private void textBox_Haste_Leave(object sender, EventArgs e)
        {
           
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            float tempcheck;
           
           if (!float.TryParse(selected, out tempcheck)) textBox_Haste.Text = "0";
            else {
                if (tempcheck > 100) tempcheck = 100;
                if (tempcheck < -100) tempcheck = -100;
                textBox_Haste.Text = tempcheck.ToString();
                  }

            update_AA_DPS(); 
        }

        private void textBox_BonusAP_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            float tempcheck;

            if (!float.TryParse(selected, out tempcheck)) textBox_BonusAP.Text = "0";
            else
            {
                if (tempcheck > 100) tempcheck = 100;
                if (tempcheck < -20) tempcheck = -20;
                textBox_BonusAP.Text = tempcheck.ToString();
            }
            update_MH_W_WpAp(); update_RAP();
            if (checkBoxDualWield.Checked) update_OH_W_WpAp();
        }

    
        private void textBox_DamageBonus_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            float tempcheck;

            if (!float.TryParse(selected, out tempcheck)) textBox_DamageBonus.Text = "0";
            else
            {
                if (tempcheck > 400) tempcheck = 400;
                if (tempcheck < -200) tempcheck = -200;
                textBox_DamageBonus.Text = tempcheck.ToString();
            }

            update_AA_DPS();
        }

        private void comboBox_OH_WPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender; string selected = (string)comboBox.SelectedItem;

            update_OH_W_DPS();

            int OHWPNID = 0; 
              
                do
                {
                    if (myWeaponClassArray[OHWPNID].Name.Equals(comboBox_OH_WPN.SelectedItem)) break;
                    OHWPNID++;
                } while (OHWPNID < constNrWeaponClasses);


                textBox_OH_SPD.Text = myWeaponClassArray[OHWPNID].Speed.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_OH_W_DPS();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_MH_WPN_Lvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_MH_W_DPS();
        }

        private void comboBox_MH_W_QLTY_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_MH_W_DPS();
        }

        private void comboBox_OH_WPN_Lvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_OH_W_DPS();
        }

        private void textBox_MH_W_DPS_TextChanged(object sender, EventArgs e)
        {
         
            update_MH_W_WpAp();

        }

        private void update_MH_W_WpAp()
        {

            int MHID = 0;
            do
            {
                if (myWeaponClassArray[MHID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;

                MHID++;
            } while (MHID < constNrWeaponClasses);


            // find the professsion index
            int ProfessionID = 0;

            do
            {
                if (myProfessionsArray[ProfessionID].Name.Equals(comboBox_Profession.SelectedItem)) break;
                ProfessionID++;
            } while (ProfessionID < constNrProfessions);


            if (!(textBox_MH_W_DPS.Text == null) && !(comboBox_Char_Lvl.SelectedItem == null))
            {
                if (!(textBox_BonusAP.Text == null) && !(comboBox_Profession.SelectedItem == null))
                {
                    // WpAp = W_SPD * (W_DPS * 0.9 + BaseAP * 0.1) + BonusAP * 0.5

                    if (myWeaponClassArray[MHID].MeleeRanged)
                    {
                        textBox_MH_WpAp.Text = (myWeaponClassArray[MHID].Speed * (float.Parse(textBox_MH_W_DPS.Text) * 0.9 + (5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) * myProfessionsArray[ProfessionID].RAP_Mul * 0.1) + float.Parse(textBox_BonusAP.Text) * 0.5f).ToString("0.00");
                    }
                    else
                    {
                        textBox_MH_WpAp.Text = (myWeaponClassArray[MHID].Speed * (float.Parse(textBox_MH_W_DPS.Text) * 0.9 + (5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) * myProfessionsArray[ProfessionID].AP_Mul * 0.1) + float.Parse(textBox_BonusAP.Text) * 0.5f).ToString("0.00");
                    }
                }
            }

        }

        private void update_OH_W_WpAp()
        {

            int OHID = 0;
            do
            {
                if (myWeaponClassArray[OHID].Name.Equals(comboBox_OH_WPN.SelectedItem)) break;

                OHID++;
            } while (OHID < constNrWeaponClasses);


            // find the professsion index
            int ProfessionID = 0;

            do
            {
                if (myProfessionsArray[ProfessionID].Name.Equals(comboBox_Profession.SelectedItem)) break;
                ProfessionID++;
            } while (ProfessionID < constNrProfessions);


            if (!(textBox_OH_W_DPS.Text == null) && !(comboBox_Char_Lvl.SelectedItem == null))
            {
                if (!(textBox_BonusAP.Text == null) && !(comboBox_Profession.SelectedItem == null))
                {
                    // WpAp = W_SPD * (W_DPS * 0.9 + BaseAP * 0.1) + BonusAP * 0.5

                  textBox_OH_WpAp.Text = (myWeaponClassArray[OHID].Speed * (float.Parse(textBox_OH_W_DPS.Text) * 0.9 + (5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) * myProfessionsArray[ProfessionID].AP_Mul * 0.1) + float.Parse(textBox_BonusAP.Text) * 0.5f).ToString("0.00");
                   
                }
            }

        }

        private void comboBox_Char_Lvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_MH_W_WpAp(); update_RAP();
            if (checkBoxDualWield.Checked) update_OH_W_WpAp();
        }

        private void textBox_BonusAP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_OH_WpAp_TextChanged(object sender, EventArgs e)
        {
            update_AA_DPS();
        }

        private void textBox_OH_W_DPS_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxDualWield.Checked) update_OH_W_WpAp();
        }

        private void textBox_MH_WpAp_TextChanged(object sender, EventArgs e)
        {
            update_AA_DPS();
        }

        private void textBox_DamageBonus_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox_Haste_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void update_RAP()
        {
            // (5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) + float.Parse(textBox_BonusAP.Text)

            int MHID = 0;
            do
            {
                if (myWeaponClassArray[MHID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;

                MHID++;
            } while (MHID < constNrWeaponClasses);


            // find the professsion index
            int ProfessionID = 0;

            do
            {
                if (myProfessionsArray[ProfessionID].Name.Equals(comboBox_Profession.SelectedItem)) break;
                ProfessionID++;
            } while (ProfessionID < constNrProfessions);

            if (!(comboBox_Char_Lvl.SelectedItem == null) && !(comboBox_Profession.SelectedItem == null))
            {
                if (!(textBox_BonusAP.Text == null) && (!(comboBox_MH_WPN.SelectedItem == null)))
                { 

                if (myWeaponClassArray[MHID].MeleeRanged)
                {
                    textBox_R_AP.Text = ((5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) * myProfessionsArray[ProfessionID].RAP_Mul + float.Parse(textBox_BonusAP.Text)).ToString("0.00");
                }
                else
                {
                    textBox_R_AP.Text = ((5 + 0.5 * float.Parse(comboBox_Char_Lvl.SelectedItem.ToString())) * myProfessionsArray[ProfessionID].AP_Mul + float.Parse(textBox_BonusAP.Text)).ToString("0.00");
                }
            }
        }

        }

        private void update_AA_DPS()
        {
          
                   if (!(textBox_MH_WpAp == null) && (!(textBox_DamageBonus.Text == null)))
                 {
                if (!(textBox_Haste.Text == null))
                    {

                    // NEED TO GET HASTE multiplier once and have it . 
                    float hastepercent, haste_MUL;
                    hastepercent = float.Parse(textBox_Haste.Text);
                    if (hastepercent < 0) haste_MUL = 1 - hastepercent / 100; else haste_MUL = 1 / (1 + hastepercent / 100);


                    int MHID = 0;
                    do
                    {
                        if (myWeaponClassArray[MHID].Name.Equals(comboBox_MH_WPN.SelectedItem)) break;

                        MHID++;
                    } while (MHID < constNrWeaponClasses);



                    if (checkBoxDualWield.Checked) if (!(textBox_OH_WpAp == null))
                        {

                            // update DW DPS
                            //  Raw AA DPS = ((MH_WpAp + OH_WpAp * 0.5) * (1 + SumDamBonus)) / (( MH_W_SPD + OH_W_SPD ) *  0.5 * Haste_Mul )


                            int OHID = 0;
                            do
                            {
                                if (myWeaponClassArray[OHID].Name.Equals(comboBox_OH_WPN.SelectedItem)) break;

                                OHID++;
                            } while (OHID < constNrWeaponClasses);



                    textBox_AA_DPS.Text = ((float.Parse(textBox_MH_WpAp.Text) + float.Parse(textBox_OH_WpAp.Text) * 0.5f ) * (1 + float.Parse(textBox_DamageBonus.Text) / 100) / ((myWeaponClassArray[MHID].Speed + myWeaponClassArray[OHID].Speed) * 0.5f * haste_MUL)).ToString("0.00");
                        }
                        else { }
                    else {
                        // update 1 H DPS
                        // Raw AA DPS = (MH_WpAp * (1 + SumDamBonus)) / (MH_W_SPD * Haste_Mul) 


                        textBox_AA_DPS.Text = (float.Parse(textBox_MH_WpAp.Text) * (1 + float.Parse(textBox_DamageBonus.Text)/100)/(myWeaponClassArray[MHID].Speed * haste_MUL)).ToString("0.00");
                           }        

                        }
                 }

        }

        private void textBox_AA_DPS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
