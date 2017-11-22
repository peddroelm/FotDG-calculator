namespace FotDG_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReCalculate = new System.Windows.Forms.Button();
            this.TempRemoveTest = new System.Windows.Forms.Button();
            this.comboBox_Profession = new System.Windows.Forms.ComboBox();
            this.comboBox_MH_WPN = new System.Windows.Forms.ComboBox();
            this.comboBox_OH_WPN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Queued_Ability1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Queued_Ability2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Queued_Ability3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Queued_Ability4 = new System.Windows.Forms.ComboBox();
            this.checkBoxDualWield = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelQ1DamageFormula = new System.Windows.Forms.Label();
            this.labelQ2DamageFormula = new System.Windows.Forms.Label();
            this.labelQ3DamageFormula = new System.Windows.Forms.Label();
            this.labelQ4DamageFormula = new System.Windows.Forms.Label();
            this.comboBox_Char_Lvl = new System.Windows.Forms.ComboBox();
            this.comboBox_MH_WPN_Lvl = new System.Windows.Forms.ComboBox();
            this.comboBox_OH_WPN_Lvl = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Haste = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_DamageBonus = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelQ1BaseCastTime = new System.Windows.Forms.Label();
            this.labelQ1Cooldown = new System.Windows.Forms.Label();
            this.labelQ2Cooldown = new System.Windows.Forms.Label();
            this.labelQ2BaseCastTime = new System.Windows.Forms.Label();
            this.labelQ3Cooldown = new System.Windows.Forms.Label();
            this.labelQ3BaseCastTime = new System.Windows.Forms.Label();
            this.labelQ4Cooldown = new System.Windows.Forms.Label();
            this.labelQ4BaseCastTime = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_BonusAP = new System.Windows.Forms.TextBox();
            this.labelInstantCooldown = new System.Windows.Forms.Label();
            this.labelInstantDamageFormula = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox_InstantAbilities = new System.Windows.Forms.ComboBox();
            this.labelQ1ThreatMul = new System.Windows.Forms.Label();
            this.labelQ2ThreatMul = new System.Windows.Forms.Label();
            this.labelQ3ThreatMul = new System.Windows.Forms.Label();
            this.labelQ4ThreatMul = new System.Windows.Forms.Label();
            this.labelInstantThreatMul = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReCalculate
            // 
            this.ReCalculate.Location = new System.Drawing.Point(32, 349);
            this.ReCalculate.Name = "ReCalculate";
            this.ReCalculate.Size = new System.Drawing.Size(83, 23);
            this.ReCalculate.TabIndex = 0;
            this.ReCalculate.Text = "Re-Calculate";
            this.ReCalculate.UseVisualStyleBackColor = true;
            this.ReCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // TempRemoveTest
            // 
            this.TempRemoveTest.Location = new System.Drawing.Point(151, 349);
            this.TempRemoveTest.Name = "TempRemoveTest";
            this.TempRemoveTest.Size = new System.Drawing.Size(198, 23);
            this.TempRemoveTest.TabIndex = 1;
            this.TempRemoveTest.Text = "Temp  RemoveDinamicButtons";
            this.TempRemoveTest.UseVisualStyleBackColor = true;
            this.TempRemoveTest.Click += new System.EventHandler(this.TempRemoveTest_Click);
            // 
            // comboBox_Profession
            // 
            this.comboBox_Profession.FormattingEnabled = true;
            this.comboBox_Profession.Location = new System.Drawing.Point(22, 37);
            this.comboBox_Profession.Name = "comboBox_Profession";
            this.comboBox_Profession.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Profession.TabIndex = 2;
            this.comboBox_Profession.SelectedIndexChanged += new System.EventHandler(this.comboBox_Profession_SelectedIndexChanged);
            // 
            // comboBox_MH_WPN
            // 
            this.comboBox_MH_WPN.FormattingEnabled = true;
            this.comboBox_MH_WPN.Location = new System.Drawing.Point(342, 37);
            this.comboBox_MH_WPN.Name = "comboBox_MH_WPN";
            this.comboBox_MH_WPN.Size = new System.Drawing.Size(170, 21);
            this.comboBox_MH_WPN.TabIndex = 3;
            this.comboBox_MH_WPN.SelectedIndexChanged += new System.EventHandler(this.comboBox_MH_WPN_SelectedIndexChanged);
            // 
            // comboBox_OH_WPN
            // 
            this.comboBox_OH_WPN.Enabled = false;
            this.comboBox_OH_WPN.FormattingEnabled = true;
            this.comboBox_OH_WPN.Location = new System.Drawing.Point(654, 41);
            this.comboBox_OH_WPN.Name = "comboBox_OH_WPN";
            this.comboBox_OH_WPN.Size = new System.Drawing.Size(170, 21);
            this.comboBox_OH_WPN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select_Profession";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select_MainHand_WPN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select_OffHand_WPN";
            // 
            // comboBox_Queued_Ability1
            // 
            this.comboBox_Queued_Ability1.FormattingEnabled = true;
            this.comboBox_Queued_Ability1.Location = new System.Drawing.Point(22, 211);
            this.comboBox_Queued_Ability1.Name = "comboBox_Queued_Ability1";
            this.comboBox_Queued_Ability1.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Queued_Ability1.TabIndex = 8;
            this.comboBox_Queued_Ability1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Queued_Ability1_SelectedIndexChanged);
            // 
            // comboBox_Queued_Ability2
            // 
            this.comboBox_Queued_Ability2.FormattingEnabled = true;
            this.comboBox_Queued_Ability2.Location = new System.Drawing.Point(342, 211);
            this.comboBox_Queued_Ability2.Name = "comboBox_Queued_Ability2";
            this.comboBox_Queued_Ability2.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Queued_Ability2.TabIndex = 9;
            this.comboBox_Queued_Ability2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Queued_Ability2_SelectedIndexChanged);
            // 
            // comboBox_Queued_Ability3
            // 
            this.comboBox_Queued_Ability3.FormattingEnabled = true;
            this.comboBox_Queued_Ability3.Location = new System.Drawing.Point(654, 217);
            this.comboBox_Queued_Ability3.Name = "comboBox_Queued_Ability3";
            this.comboBox_Queued_Ability3.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Queued_Ability3.TabIndex = 10;
            this.comboBox_Queued_Ability3.SelectedIndexChanged += new System.EventHandler(this.comboBox_Queued_Ability3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Queued_Ability1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Queued_Ability2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Queued_Ability3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(961, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Queued_Ability4";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_Queued_Ability4
            // 
            this.comboBox_Queued_Ability4.FormattingEnabled = true;
            this.comboBox_Queued_Ability4.Location = new System.Drawing.Point(922, 213);
            this.comboBox_Queued_Ability4.Name = "comboBox_Queued_Ability4";
            this.comboBox_Queued_Ability4.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Queued_Ability4.TabIndex = 14;
            this.comboBox_Queued_Ability4.SelectedIndexChanged += new System.EventHandler(this.comboBox_Queued_Ability4_SelectedIndexChanged);
            // 
            // checkBoxDualWield
            // 
            this.checkBoxDualWield.AutoSize = true;
            this.checkBoxDualWield.Location = new System.Drawing.Point(603, 45);
            this.checkBoxDualWield.Name = "checkBoxDualWield";
            this.checkBoxDualWield.Size = new System.Drawing.Size(45, 17);
            this.checkBoxDualWield.TabIndex = 16;
            this.checkBoxDualWield.Text = "DW";
            this.checkBoxDualWield.UseVisualStyleBackColor = true;
            this.checkBoxDualWield.CheckedChanged += new System.EventHandler(this.checkBoxDualWield_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "CooldownTimeline";
            // 
            // labelQ1DamageFormula
            // 
            this.labelQ1DamageFormula.AutoSize = true;
            this.labelQ1DamageFormula.Location = new System.Drawing.Point(19, 247);
            this.labelQ1DamageFormula.Name = "labelQ1DamageFormula";
            this.labelQ1DamageFormula.Size = new System.Drawing.Size(135, 13);
            this.labelQ1DamageFormula.TabIndex = 18;
            this.labelQ1DamageFormula.Text = "TotalDamageAbilityFormula";
            // 
            // labelQ2DamageFormula
            // 
            this.labelQ2DamageFormula.AutoSize = true;
            this.labelQ2DamageFormula.Location = new System.Drawing.Point(339, 247);
            this.labelQ2DamageFormula.Name = "labelQ2DamageFormula";
            this.labelQ2DamageFormula.Size = new System.Drawing.Size(135, 13);
            this.labelQ2DamageFormula.TabIndex = 19;
            this.labelQ2DamageFormula.Text = "TotalDamageAbilityFormula";
            // 
            // labelQ3DamageFormula
            // 
            this.labelQ3DamageFormula.AutoSize = true;
            this.labelQ3DamageFormula.Location = new System.Drawing.Point(651, 247);
            this.labelQ3DamageFormula.Name = "labelQ3DamageFormula";
            this.labelQ3DamageFormula.Size = new System.Drawing.Size(135, 13);
            this.labelQ3DamageFormula.TabIndex = 20;
            this.labelQ3DamageFormula.Text = "TotalDamageAbilityFormula";
            // 
            // labelQ4DamageFormula
            // 
            this.labelQ4DamageFormula.AutoSize = true;
            this.labelQ4DamageFormula.Location = new System.Drawing.Point(919, 247);
            this.labelQ4DamageFormula.Name = "labelQ4DamageFormula";
            this.labelQ4DamageFormula.Size = new System.Drawing.Size(135, 13);
            this.labelQ4DamageFormula.TabIndex = 21;
            this.labelQ4DamageFormula.Text = "TotalDamageAbilityFormula";
            // 
            // comboBox_Char_Lvl
            // 
            this.comboBox_Char_Lvl.FormattingEnabled = true;
            this.comboBox_Char_Lvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_Char_Lvl.Location = new System.Drawing.Point(149, 78);
            this.comboBox_Char_Lvl.Name = "comboBox_Char_Lvl";
            this.comboBox_Char_Lvl.Size = new System.Drawing.Size(43, 21);
            this.comboBox_Char_Lvl.TabIndex = 22;
            // 
            // comboBox_MH_WPN_Lvl
            // 
            this.comboBox_MH_WPN_Lvl.FormattingEnabled = true;
            this.comboBox_MH_WPN_Lvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_MH_WPN_Lvl.Location = new System.Drawing.Point(472, 78);
            this.comboBox_MH_WPN_Lvl.Name = "comboBox_MH_WPN_Lvl";
            this.comboBox_MH_WPN_Lvl.Size = new System.Drawing.Size(40, 21);
            this.comboBox_MH_WPN_Lvl.TabIndex = 23;
            // 
            // comboBox_OH_WPN_Lvl
            // 
            this.comboBox_OH_WPN_Lvl.FormattingEnabled = true;
            this.comboBox_OH_WPN_Lvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_OH_WPN_Lvl.Location = new System.Drawing.Point(784, 84);
            this.comboBox_OH_WPN_Lvl.Name = "comboBox_OH_WPN_Lvl";
            this.comboBox_OH_WPN_Lvl.Size = new System.Drawing.Size(40, 21);
            this.comboBox_OH_WPN_Lvl.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Select_Char_Lvl";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(354, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Select_MH_WPN_Lvl";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(666, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Select_OH_WPN_Lvl";
            // 
            // textBox_Haste
            // 
            this.textBox_Haste.Location = new System.Drawing.Point(122, 136);
            this.textBox_Haste.Name = "textBox_Haste";
            this.textBox_Haste.Size = new System.Drawing.Size(35, 20);
            this.textBox_Haste.TabIndex = 28;
            this.textBox_Haste.Text = "0";
            this.textBox_Haste.Leave += new System.EventHandler(this.textBox_Haste_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1308, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Import_Build";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1309, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Export_Build";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "?Compare Builds?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Haste%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(592, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(191, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Total Additive bonus Weapon Damage";
            // 
            // textBox_DamageBonus
            // 
            this.textBox_DamageBonus.Location = new System.Drawing.Point(789, 142);
            this.textBox_DamageBonus.Name = "textBox_DamageBonus";
            this.textBox_DamageBonus.Size = new System.Drawing.Size(35, 20);
            this.textBox_DamageBonus.TabIndex = 33;
            this.textBox_DamageBonus.Text = "0";
            this.textBox_DamageBonus.Leave += new System.EventHandler(this.textBox_DamageBonus_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(543, 430);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "RAW AA DPS";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(624, 423);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 36;
            // 
            // labelQ1BaseCastTime
            // 
            this.labelQ1BaseCastTime.AutoSize = true;
            this.labelQ1BaseCastTime.Location = new System.Drawing.Point(19, 270);
            this.labelQ1BaseCastTime.Name = "labelQ1BaseCastTime";
            this.labelQ1BaseCastTime.Size = new System.Drawing.Size(81, 13);
            this.labelQ1BaseCastTime.TabIndex = 37;
            this.labelQ1BaseCastTime.Text = "Base Cast Time";
            // 
            // labelQ1Cooldown
            // 
            this.labelQ1Cooldown.AutoSize = true;
            this.labelQ1Cooldown.Location = new System.Drawing.Point(19, 295);
            this.labelQ1Cooldown.Name = "labelQ1Cooldown";
            this.labelQ1Cooldown.Size = new System.Drawing.Size(54, 13);
            this.labelQ1Cooldown.TabIndex = 38;
            this.labelQ1Cooldown.Text = "Cooldown";
            // 
            // labelQ2Cooldown
            // 
            this.labelQ2Cooldown.AutoSize = true;
            this.labelQ2Cooldown.Location = new System.Drawing.Point(339, 295);
            this.labelQ2Cooldown.Name = "labelQ2Cooldown";
            this.labelQ2Cooldown.Size = new System.Drawing.Size(54, 13);
            this.labelQ2Cooldown.TabIndex = 40;
            this.labelQ2Cooldown.Text = "Cooldown";
            // 
            // labelQ2BaseCastTime
            // 
            this.labelQ2BaseCastTime.AutoSize = true;
            this.labelQ2BaseCastTime.Location = new System.Drawing.Point(339, 270);
            this.labelQ2BaseCastTime.Name = "labelQ2BaseCastTime";
            this.labelQ2BaseCastTime.Size = new System.Drawing.Size(81, 13);
            this.labelQ2BaseCastTime.TabIndex = 39;
            this.labelQ2BaseCastTime.Text = "Base Cast Time";
            // 
            // labelQ3Cooldown
            // 
            this.labelQ3Cooldown.AutoSize = true;
            this.labelQ3Cooldown.Location = new System.Drawing.Point(651, 295);
            this.labelQ3Cooldown.Name = "labelQ3Cooldown";
            this.labelQ3Cooldown.Size = new System.Drawing.Size(54, 13);
            this.labelQ3Cooldown.TabIndex = 42;
            this.labelQ3Cooldown.Text = "Cooldown";
            // 
            // labelQ3BaseCastTime
            // 
            this.labelQ3BaseCastTime.AutoSize = true;
            this.labelQ3BaseCastTime.Location = new System.Drawing.Point(651, 270);
            this.labelQ3BaseCastTime.Name = "labelQ3BaseCastTime";
            this.labelQ3BaseCastTime.Size = new System.Drawing.Size(81, 13);
            this.labelQ3BaseCastTime.TabIndex = 41;
            this.labelQ3BaseCastTime.Text = "Base Cast Time";
            // 
            // labelQ4Cooldown
            // 
            this.labelQ4Cooldown.AutoSize = true;
            this.labelQ4Cooldown.Location = new System.Drawing.Point(919, 295);
            this.labelQ4Cooldown.Name = "labelQ4Cooldown";
            this.labelQ4Cooldown.Size = new System.Drawing.Size(54, 13);
            this.labelQ4Cooldown.TabIndex = 44;
            this.labelQ4Cooldown.Text = "Cooldown";
            // 
            // labelQ4BaseCastTime
            // 
            this.labelQ4BaseCastTime.AutoSize = true;
            this.labelQ4BaseCastTime.Location = new System.Drawing.Point(919, 270);
            this.labelQ4BaseCastTime.Name = "labelQ4BaseCastTime";
            this.labelQ4BaseCastTime.Size = new System.Drawing.Size(81, 13);
            this.labelQ4BaseCastTime.TabIndex = 43;
            this.labelQ4BaseCastTime.Text = "Base Cast Time";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(354, 139);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 13);
            this.label27.TabIndex = 46;
            this.label27.Text = "Total_Bonus_AP";
            // 
            // textBox_BonusAP
            // 
            this.textBox_BonusAP.Location = new System.Drawing.Point(447, 136);
            this.textBox_BonusAP.Name = "textBox_BonusAP";
            this.textBox_BonusAP.Size = new System.Drawing.Size(35, 20);
            this.textBox_BonusAP.TabIndex = 45;
            this.textBox_BonusAP.Text = "0";
            this.textBox_BonusAP.Leave += new System.EventHandler(this.textBox_BonusAP_Leave);
            // 
            // labelInstantCooldown
            // 
            this.labelInstantCooldown.AutoSize = true;
            this.labelInstantCooldown.Location = new System.Drawing.Point(929, 105);
            this.labelInstantCooldown.Name = "labelInstantCooldown";
            this.labelInstantCooldown.Size = new System.Drawing.Size(54, 13);
            this.labelInstantCooldown.TabIndex = 51;
            this.labelInstantCooldown.Text = "Cooldown";
            // 
            // labelInstantDamageFormula
            // 
            this.labelInstantDamageFormula.AutoSize = true;
            this.labelInstantDamageFormula.Location = new System.Drawing.Point(919, 78);
            this.labelInstantDamageFormula.Name = "labelInstantDamageFormula";
            this.labelInstantDamageFormula.Size = new System.Drawing.Size(135, 13);
            this.labelInstantDamageFormula.TabIndex = 49;
            this.labelInstantDamageFormula.Text = "TotalDamageAbilityFormula";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(949, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(133, 13);
            this.label31.TabIndex = 48;
            this.label31.Text = "INSTANT ABILITIES (info)";
            // 
            // comboBox_InstantAbilities
            // 
            this.comboBox_InstantAbilities.FormattingEnabled = true;
            this.comboBox_InstantAbilities.Location = new System.Drawing.Point(922, 37);
            this.comboBox_InstantAbilities.Name = "comboBox_InstantAbilities";
            this.comboBox_InstantAbilities.Size = new System.Drawing.Size(170, 21);
            this.comboBox_InstantAbilities.TabIndex = 47;
            this.comboBox_InstantAbilities.SelectedIndexChanged += new System.EventHandler(this.comboBox_InstantAbilities_SelectedIndexChanged);
            // 
            // labelQ1ThreatMul
            // 
            this.labelQ1ThreatMul.AutoSize = true;
            this.labelQ1ThreatMul.Location = new System.Drawing.Point(18, 322);
            this.labelQ1ThreatMul.Name = "labelQ1ThreatMul";
            this.labelQ1ThreatMul.Size = new System.Drawing.Size(55, 13);
            this.labelQ1ThreatMul.TabIndex = 52;
            this.labelQ1ThreatMul.Text = "ThreatMul";
            // 
            // labelQ2ThreatMul
            // 
            this.labelQ2ThreatMul.AutoSize = true;
            this.labelQ2ThreatMul.Location = new System.Drawing.Point(339, 322);
            this.labelQ2ThreatMul.Name = "labelQ2ThreatMul";
            this.labelQ2ThreatMul.Size = new System.Drawing.Size(55, 13);
            this.labelQ2ThreatMul.TabIndex = 53;
            this.labelQ2ThreatMul.Text = "ThreatMul";
            // 
            // labelQ3ThreatMul
            // 
            this.labelQ3ThreatMul.AutoSize = true;
            this.labelQ3ThreatMul.Location = new System.Drawing.Point(651, 322);
            this.labelQ3ThreatMul.Name = "labelQ3ThreatMul";
            this.labelQ3ThreatMul.Size = new System.Drawing.Size(55, 13);
            this.labelQ3ThreatMul.TabIndex = 54;
            this.labelQ3ThreatMul.Text = "ThreatMul";
            // 
            // labelQ4ThreatMul
            // 
            this.labelQ4ThreatMul.AutoSize = true;
            this.labelQ4ThreatMul.Location = new System.Drawing.Point(919, 322);
            this.labelQ4ThreatMul.Name = "labelQ4ThreatMul";
            this.labelQ4ThreatMul.Size = new System.Drawing.Size(55, 13);
            this.labelQ4ThreatMul.TabIndex = 55;
            this.labelQ4ThreatMul.Text = "ThreatMul";
            // 
            // labelInstantThreatMul
            // 
            this.labelInstantThreatMul.AutoSize = true;
            this.labelInstantThreatMul.Location = new System.Drawing.Point(929, 136);
            this.labelInstantThreatMul.Name = "labelInstantThreatMul";
            this.labelInstantThreatMul.Size = new System.Drawing.Size(55, 13);
            this.labelInstantThreatMul.TabIndex = 56;
            this.labelInstantThreatMul.Text = "ThreatMul";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1230, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "TotalDamageAbilityFormula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1230, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Base Cast Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1230, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Cooldown";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1230, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "ThreatMul";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1176, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 13);
            this.label19.TabIndex = 61;
            this.label19.Text = "TotalDamageAbilityFormula";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1176, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 62;
            this.label20.Text = "Cooldown";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1176, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 63;
            this.label21.Text = "ThreatMul";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1873, 640);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelInstantThreatMul);
            this.Controls.Add(this.labelQ4ThreatMul);
            this.Controls.Add(this.labelQ3ThreatMul);
            this.Controls.Add(this.labelQ2ThreatMul);
            this.Controls.Add(this.labelQ1ThreatMul);
            this.Controls.Add(this.labelInstantCooldown);
            this.Controls.Add(this.labelInstantDamageFormula);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.comboBox_InstantAbilities);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox_BonusAP);
            this.Controls.Add(this.labelQ4Cooldown);
            this.Controls.Add(this.labelQ4BaseCastTime);
            this.Controls.Add(this.labelQ3Cooldown);
            this.Controls.Add(this.labelQ3BaseCastTime);
            this.Controls.Add(this.labelQ2Cooldown);
            this.Controls.Add(this.labelQ2BaseCastTime);
            this.Controls.Add(this.labelQ1Cooldown);
            this.Controls.Add(this.labelQ1BaseCastTime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_DamageBonus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Haste);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox_OH_WPN_Lvl);
            this.Controls.Add(this.comboBox_MH_WPN_Lvl);
            this.Controls.Add(this.comboBox_Char_Lvl);
            this.Controls.Add(this.labelQ4DamageFormula);
            this.Controls.Add(this.labelQ3DamageFormula);
            this.Controls.Add(this.labelQ2DamageFormula);
            this.Controls.Add(this.labelQ1DamageFormula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxDualWield);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Queued_Ability4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Queued_Ability3);
            this.Controls.Add(this.comboBox_Queued_Ability2);
            this.Controls.Add(this.comboBox_Queued_Ability1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_OH_WPN);
            this.Controls.Add(this.comboBox_MH_WPN);
            this.Controls.Add(this.comboBox_Profession);
            this.Controls.Add(this.TempRemoveTest);
            this.Controls.Add(this.ReCalculate);
            this.Name = "Form1";
            this.Text = "Fall of The Dungeon Guardians Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReCalculate;
        private System.Windows.Forms.Button TempRemoveTest;
        private System.Windows.Forms.ComboBox comboBox_Profession;
        private System.Windows.Forms.ComboBox comboBox_MH_WPN;
        private System.Windows.Forms.ComboBox comboBox_OH_WPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Queued_Ability1;
        private System.Windows.Forms.ComboBox comboBox_Queued_Ability2;
        private System.Windows.Forms.ComboBox comboBox_Queued_Ability3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Queued_Ability4;
        private System.Windows.Forms.CheckBox checkBoxDualWield;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelQ1DamageFormula;
        private System.Windows.Forms.Label labelQ2DamageFormula;
        private System.Windows.Forms.Label labelQ3DamageFormula;
        private System.Windows.Forms.Label labelQ4DamageFormula;
        private System.Windows.Forms.ComboBox comboBox_Char_Lvl;
        private System.Windows.Forms.ComboBox comboBox_MH_WPN_Lvl;
        private System.Windows.Forms.ComboBox comboBox_OH_WPN_Lvl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Haste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_DamageBonus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelQ1BaseCastTime;
        private System.Windows.Forms.Label labelQ1Cooldown;
        private System.Windows.Forms.Label labelQ2Cooldown;
        private System.Windows.Forms.Label labelQ2BaseCastTime;
        private System.Windows.Forms.Label labelQ3Cooldown;
        private System.Windows.Forms.Label labelQ3BaseCastTime;
        private System.Windows.Forms.Label labelQ4Cooldown;
        private System.Windows.Forms.Label labelQ4BaseCastTime;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_BonusAP;
        private System.Windows.Forms.Label labelInstantCooldown;
        private System.Windows.Forms.Label labelInstantDamageFormula;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox_InstantAbilities;
        private System.Windows.Forms.Label labelQ1ThreatMul;
        private System.Windows.Forms.Label labelQ2ThreatMul;
        private System.Windows.Forms.Label labelQ3ThreatMul;
        private System.Windows.Forms.Label labelQ4ThreatMul;
        private System.Windows.Forms.Label labelInstantThreatMul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

