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
        public Professions(int IDI, int ClassI,string NameI, bool DWI, string MHI, string OHI)
        {
            ID = IDI;
            Class = ClassI;
            Name = NameI;
            DW = DWI;
            MH = MHI;
            OH = OHI;
        }

        public int ID { get; }
        public int Class { get; } // 1 warrior, 2 rogue, 3 healer, 4 mage
        public string Name { get; }
        public bool DW { get; }
        public string MH { get; }  // weapons allowed in main hand
        public string OH { get; }  // weapons allowed in off hand
    }
    

    struct WeaponClass
    {
        public WeaponClass(int IDI, string NameI, bool TwoHandedI, float SpeedI, float DamageMultiplierI)
            {
            ID = IDI; 
            Name = NameI;
            TwoHanded = TwoHandedI;
            Speed = SpeedI;
            DamageMultiplier = DamageMultiplierI;
            }

     public int ID { get; }
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow
     public string Name { get; }
     public bool TwoHanded { get; }
     public float Speed { get; }
     public float DamageMultiplier { get; }

    }

    struct Ability
    {
        public Ability(string NameI, bool InstantI, int ProfessionIDI, string AbilityFormulaI, bool CastTypeI, float CastDurationWeaponSPDMulI, float FixedCastDurationI, bool CooldownTypeI, float CooldownDurationWeaponSPDMulI, float FixedCooldownDurationI, float ThreatMulI)
        {
            Name = NameI;
            Instant = InstantI;
            ProfessionID = ProfessionIDI;
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
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow
                  new Professions(1, 1, "Protector", true, "111011111001111110", "010000000000000000"),
                  new Professions(2, 1, "Man at Arms", true, "111011111001111110", "010011111001111110"),
                  new Professions(3, 1, "Paladin", false, "101011111001111110" , ""),
                  new Professions(4, 2, "Assassin", true, "111011010000000000", "010000000000000000"),
                  new Professions(5, 2, "Duelist", true, "111011010000000000" , "010000000000000000"),
                  new Professions(6, 2, "Ranger", false, "101000000010000001" , ""),
                  new Professions(7, 3, "Druid", false, "111110000100000000", ""),
                  new Professions(8, 3, "Priestess", false, "111110000100000000", ""),
                  new Professions(9, 3, "Necromancer", false, "111110000100000000", ""),
                  new Professions(10, 4, "Elementalist", false, "111101000100000000", ""),
                  new Professions(11, 4, "Warlock", false, "111101000100000000", ""),
                  new Professions(12, 4, "Arcanist", false, "111101000100000000", "")
      };

        const int constNrWeaponClasses = 18;
        private WeaponClass[] myWeaponClassArray = new WeaponClass[constNrWeaponClasses]
      {
  // 1 fist, 2 dagger, 3 fist_2H, 4 Wand, 5 Mace, 6 Sword, 7 BSword, 8 Axe, 9 BAxe, 10 Staff, 11 Bow, 12 BSword2H, 13 BAxe2H, 14 2HMace, 15 2HSword, 16 2HAxe, 17 Polearm, 18 Crossbow
                  new WeaponClass(1, "Fist", false, 1.1f, 0.4f),    // 0.5 * 0.8
                  new WeaponClass(2, "Dagger", false, 1.2f, 0.45f),  // 0.5 * 0.9     
                  new WeaponClass(3, "Fist_2H", true, 1.1f, 0.675f),  // 0.5 * 0.9  * 1.5  
                  new WeaponClass(4, "Wand", true, 3f, 0.7f),  // 1 * 0.7  
                  new WeaponClass(5, "Mace", false, 1.5f, 1f),  // 1 * 1 
                  new WeaponClass(6, "Sword", false, 1.6f, 1f),  // 1 * 1 
                  new WeaponClass(7, "BSword", false, 1.8f, 1f),  // 1 * 1 
                  new WeaponClass(8, "Axe", false, 1.8f, 1f),  // 1 * 1 
                  new WeaponClass(9, "BAxe", false, 2f, 1f),  // 1 * 1 
                  new WeaponClass(10, "Staff", true, 2.7f, 1.04f),  // 1.3 * 0.8
                  new WeaponClass(11, "Bow", true, 2.3f, 1.17f),  // 1.3 * 0.9
                  new WeaponClass(12, "BSword2H", true, 1.8f, 1.2f),  // 1 * 1 * 1.2 
                  new WeaponClass(13, "BAxe2H", true, 2f, 1.2f),  // 1 * 1 * 1.2 
                  new WeaponClass(14, "2HMace", true, 2f, 1.3f),  // 1 * 1.3
                  new WeaponClass(15, "2HSword", true, 2.2f, 1.3f),  // 1 * 1.3
                  new WeaponClass(15, "2HAxe", true, 2.4f, 1.3f),  // 1 * 1.3
                  new WeaponClass(16, "Polearm", true, 2.5f, 1.3f),  // 1 * 1.3
                  new WeaponClass(17, "Crossbow", true, 3.3f, 1.3f)  // 1 * 1.3
      };


        const int constNrAbilities = 44;
        private Ability[] myAbilityArray = new Ability[constNrAbilities]
      {
//1 Protector 
                  new Ability("Thunder Clap", false, 1, "AP * 0.75", false, 0f, 2f, false, 0f, 12f, 10f) ,
                  new Ability("Kick", true, 1, "no damage; Interrupt; Aggro += Lvl + 5", false, 0f, 0f, false, 0f, 20f, 0f),
                  new Ability("Rend", false, 1, "WpAp * 0.5 and (WpAp * 1.5 + AP * 0.5) as DOT", true, 1f, 0f, true, 3f, 0f, 4f),
//2 Man at Arms
                  new Ability("Hard Strike", false, 2, "WpAp * 1.3", true, 1f, 0f, true, 3f, 0f , 1f),
                  new Ability("Deadly Assault", false, 2, "AP * 1.35 + WpAp * 0.7", true, 1f, 0f, true, 6f, 0f , 1f),
//3 Paladin
                  new Ability("Hammer of Justice", false, 3, "(SP * AbSpeed + WpAp) *0.54", true, 1f, 0f, false, 0f, 6f, 1f),
                  new Ability("Divine Punishment", true, 3, "SP * 1.5", false, 1f, 0f, false, 0f, 12f , 8f),
                  new Ability("Crusader Assault", false, 3, "WpAp", true, 1.5f, 0f, false, 0f, 6f , 1f),
//4 Assassin
                  new Ability("Dreadful Jab", false, 4, "WpAp * 1.35", true, 1f, 0f, true, 3f, 0f , 1f),
                  new Ability("Swift Knife", true, 4, "AP * 1.08 * (1 + NbCombo * 0.2)", false, 0f, 0f, false, 0f, 18f, 1f),
                  new Ability("Execute", false, 4, "WpAp * 1.8 * (1 + NbCombo * 0.2)", true, 1.5f, 0f, false, 0f, 12f, 1f),
                  new Ability("Sweeping Blow", false, 5, "WpAp * 0.4 + AP * 0.45", true, 1.5f, 0f, false, 0f, 6f, 6f),
//5 Duelist
                  new Ability("Lunge", false, 5, "(WpAp + AP) * 0.5 * (1 + NbCombo * 0.40)", true, 1.5f, 0f, false, 0f, 12f, 2.5f),
                  new Ability("Pommel", true, 5, "no damage; Interrupt; Aggro += Lvl + 5", false, 0f, 0f, false, 0f, 20f, 0f),
//6 Ranger
                  new Ability("Instinct Shot", false, 6, "WpAp * 1.15", true, 1.25f, 0f, true, 2.5f, 0f, 1f),
                  new Ability("Double Shot", false, 6, "WpAp * 0.9", true, 1.25f, 0f, true, 2.5f, 0f, 1f),
                  new Ability("Sniper Shot", false, 6, "WpAp * 1.2 * (1 + NbCombo * 0.15)", true, 1.5f, 0f, false, 0f, 12f, 1f),
//7 Druid
                  new Ability("Heal", false, 7, "SP * 3.6", false, 0f, 1.5f, false, 0f, 6f , 0.4f),
                  new Ability("Regrowth", false, 7, "(SP * 6) / NbTick", false, 0f, 3f, false, 0f, 6f , 0.4f),
                  new Ability("Lifebloom", false, 7, "(SP * 3 * NbStack) / NbTick and SP * 2.4 * NbStack", false, 0f, 2f, false, 0f, 6f, 0.4f),
                  new Ability("Dance of Gaia", false, 7, "(SP * 5.1) / NbTick", false, 0f, 8f, false, 0f, 6f, 0.4f),
//8 Priest
                  new Ability("Righteous Shield1", false, 8, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 12f, 0.4f),
                  new Ability("Righteous Shield2", false, 8, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 9f, 0.4f),
                  new Ability("Righteous Shield3", false, 8, "(SP * 7.2) * (1 + TV_StrongerShield)", false, 0f, 1.5f, false, 0f, 6f, 0.4f),
                  new Ability("Flash Heal", false, 8, "SP * 3", false, 0f, 0.5f, false, 0f, 6f , 0.4f),
                  new Ability("Renew", false, 8, "(SP * 3.6) / 3", false, 0f, 2f, false, 0f, 6f , 0.4f),
//9 Necromancer
                  new Ability("Soul Sucking", false, 9, "SP * 1.2 and SP * 3.42 heal", false, 0f, 4f, false, 0f, 6f, 1.4f),
                  new Ability("Eat My Flesh", false, 9, "SP * 2.52 and SP * 1.26 harm", false, 0f, 2f, false, 0f, 6f, 0.4f),
//10 Elementalist
                  new Ability("Scorch", false, 10, "SP * 1.86 and (SP * 1.89) / NbTick DOT", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt1", false, 10, "SP * 3.125", false, 0f, 2.5f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt2", false, 10, "SP * 3.125", false, 0f, 1.5f, false, 0f, 6f, 1f),
                  new Ability("Frostbolt3", false, 10, "SP * 3.125", false, 0f, 0.5f, false, 0f, 6f, 1f),
//11 Warlock
                  new Ability("Shadowball1", false, 11, "SP * 3.78", false, 0f, 4f, false, 0f, 6f, 1f),
                  new Ability("Shadowball2", false, 11, "SP * 3.78", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Shadowball3", false, 11, "SP * 3.78", false, 0f, 2f, false, 0f, 6f, 1f),
                  new Ability("Torment", false, 11, "(SP * 4.08) / NbTick", false, 0f, 2.5f, false, 0f, 6f, 1f),
                  new Ability("DirePlague", false, 11, "(SP * 4.5) * Lerp(0.5, 1.5, Time) / NbTick", false, 0f, 5f, false, 0f, 6f, 1f),
//12 Arcanist
                  new Ability("Arcane Burst1", false, 12, "(SP * 4.2) / NbTick", false, 0f, 4f, false, 0f, 6f, 1f),
                  new Ability("Arcane Burst2", false, 12, "(SP * 4.2) / NbTick", false, 0f, 3f, false, 0f, 6f, 1f),
                  new Ability("Arcane Burst3", false, 12, "(SP * 4.2) / NbTick", false, 0f, 2f, false, 0f, 6f, 1f),
                  new Ability("Arcane Rupture1", false, 12, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 12f, 1f),
                  new Ability("Arcane Rupture2", false, 12, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 11f, 1f),
                  new Ability("Arcane Rupture3", false, 12, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 10f, 1f),
                  new Ability("Arcane Rupture4", false, 12, "(SP * 2.58 * NbStack) / NbTick", false, 0f, 2.5f, false, 0f, 9f, 1f)

    };

        int GlobalTempButtonTotal = 0; // global var
        int Global_top = 500;
        int Global_left = 0;
        float constScalingCoef = 200;

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
                PlaceButton(CurentTime, AB_CD_Offset[CurrentAbility], QueuedAbilityCooldownTimes[CurrentAbility], QueuedAbilityCooldownTimes[CurrentAbility].ToString("0.00"), Color.Chartreuse); // AB_CD
                PlaceButton(CurentTime, 120, 6 * haste_MUL, (6 * haste_MUL).ToString("0.00"), Color.Aqua);  // GCD
                PlaceButton(CurentTime, 150, QueuedAbilityCastTimes[CurrentAbility] * haste_MUL, (QueuedAbilityCastTimes[CurrentAbility] * haste_MUL).ToString("0.00"), Color.Red); // AB_CAST TIME      

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


                //NEED TO DO THAT CHECK FOR ABILITY COOLDOWN EVEN ACROSS MORE THAN 1 GAP
                // HOW TO SOLVE THIS ?? 12 seconds thunder clap or even more for Deadly Assault
                // update per ability total time it finishes last in array ?? how do I check this ?

                CurrentAbility++; IntermediateCurentTime = 0;
                if ((QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL) >= TimeToBeat) { CurentTime += QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL; continue; }
                else
                {

                    IntermediateCurentTime += QueuedAbilityCastTimes[CurrentAbility - 1] * haste_MUL;
                    
                    do { 
                    // fill in with AAs 
                    if (checkBoxDualWield.Checked)
                    {
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL, (myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL).ToString("0.00"), Color.Yellow); // OH Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 240, myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL, (myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL).ToString("0.00"), Color.Aqua); // OH WGCD
                            IntermediateCurentTime += myWeaponClassArray[OHWPNID].Speed * 0.5f * haste_MUL;
                       if (IntermediateCurentTime >= TimeToBeat) { CurentTime += IntermediateCurentTime; break; }; 
                    }

                        //AND LIMBO
                        if (LimboTime > CurentTime + IntermediateCurentTime) IntermediateCurentTime = LimboTime - CurentTime;


                            // MH_A
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), Color.DeepPink ); // MH_A Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 210, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL).ToString("0.00"), Color.DarkSlateBlue); // MH Cooldown
                        IntermediateCurentTime += myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL;
                        if (IntermediateCurentTime >= TimeToBeat) {
                            CurentTime += IntermediateCurentTime - myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL;
                            LimboTime = CurentTime + myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * haste_MUL; 
                            break; };

                     

                        // ADD MH_B
                        PlaceButton(CurentTime + IntermediateCurentTime, 180, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), Color.Pink ); // MH_B Attack 
                        PlaceButton(CurentTime + IntermediateCurentTime, 240, myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL, (myWeaponClassArray[MHWPNID].Speed * DW_SPD_MUL * 0.5f * haste_MUL).ToString("0.00"), Color.Aqua); // MH WGCD
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
            RePopulateCombos();

            // X time axis
            for (int i = 0; i < 100; i++)
            {
                Button button = new Button();
                button.Left = (int)(Global_left + 0.5 * i * constScalingCoef);
                button.Top = Global_top + 270;
                button.Enabled = false;
                button.BackColor = Color.Coral;
                button.Width = (int)(0.5 * constScalingCoef);
                button.Text = ((float)(0.5 * i)).ToString();
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font(button.Font.FontFamily, 6);
                this.Controls.Add(button);
            }
        }

        private void RePopulateCombos()
        {
            comboBox_Profession.Items.Clear();
            for (int i = 0; i < constNrProfessions; i++)
            {
                comboBox_Profession.Items.Add(myProfessionsArray[i].Name);
            }
            comboBox_Profession.SelectedIndex = 0;

            // weapons and abilities comboboxes need to be reset by selection event on comboBox_Profession

            //bellow char level // weapon levels
            comboBox_Char_Lvl.SelectedIndex = 0;
            comboBox_MH_WPN_Lvl.SelectedIndex = 0;
            comboBox_OH_WPN_Lvl.SelectedIndex = 0;

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


            // clear checkboxes AND labels
            comboBox_Queued_Ability1.Items.Clear(); comboBox_Queued_Ability2.Items.Clear(); comboBox_Queued_Ability3.Items.Clear(); comboBox_Queued_Ability4.Items.Clear();
            comboBox_InstantAbilities.Items.Clear();
            comboBox_Queued_Ability1.Text = ""; comboBox_Queued_Ability2.Text = ""; comboBox_Queued_Ability3.Text = ""; comboBox_Queued_Ability4.Text = ""; comboBox_InstantAbilities.Text = "";

            labelQ1DamageFormula.Text = labelQ2DamageFormula.Text = labelQ3DamageFormula.Text = labelQ4DamageFormula.Text = labelInstantDamageFormula.Text = "";
            labelQ1BaseCastTime.Text = labelQ2BaseCastTime.Text = labelQ3BaseCastTime.Text = labelQ4BaseCastTime.Text = "";
            labelQ1Cooldown.Text = labelQ2Cooldown.Text = labelQ3Cooldown.Text = labelQ4Cooldown.Text = labelInstantCooldown.Text = "";
            labelQ1ThreatMul.Text = labelQ2ThreatMul.Text = labelQ3ThreatMul.Text = labelQ4ThreatMul.Text = labelInstantThreatMul.Text = "";

            // populate Queable ablity list [queue times 4]  // populate the instant abilities

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

        }

        private void checkBoxDualWield_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox  checkBox = (CheckBox)sender;
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

            comboBox_Queued_Ability1_SelectedIndexChanged(comboBox_Queued_Ability1, new EventArgs());
            comboBox_Queued_Ability2_SelectedIndexChanged(comboBox_Queued_Ability2, new EventArgs());
            comboBox_Queued_Ability3_SelectedIndexChanged(comboBox_Queued_Ability3, new EventArgs());
            comboBox_Queued_Ability4_SelectedIndexChanged(comboBox_Queued_Ability4, new EventArgs());
            comboBox_InstantAbilities_SelectedIndexChanged(comboBox_InstantAbilities, new EventArgs());

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

        }

    
        private void textBox_DamageBonus_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; string selected = (string)textBox.Text;
            float tempcheck;

            if (!float.TryParse(selected, out tempcheck)) textBox_DamageBonus.Text = "0";
            else
            {
                if (tempcheck > 5) tempcheck = 5;
                if (tempcheck < -2) tempcheck = -2;
                textBox_DamageBonus.Text = tempcheck.ToString();
            }
        }
    }
}
