namespace WoundChanceCalcDesktop
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
            this.AttackerWS = new System.Windows.Forms.Label();
            this.TargetWS = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.Label();
            this.Preferedenemy_checkBox = new System.Windows.Forms.CheckBox();
            this.A_WS_comboBox = new System.Windows.Forms.ComboBox();
            this.T_WS_comboBox = new System.Windows.Forms.ComboBox();
            this.Toughness = new System.Windows.Forms.Label();
            this.Strength_comboBox = new System.Windows.Forms.ComboBox();
            this.Toughness_comboBox = new System.Windows.Forms.ComboBox();
            this.ArmourPercing = new System.Windows.Forms.Label();
            this.AP_comboBox = new System.Windows.Forms.ComboBox();
            this.ArmourSave_comboBox = new System.Windows.Forms.ComboBox();
            this.ArmourSave = new System.Windows.Forms.Label();
            this.InvSave_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FNP_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Shred_checkBox = new System.Windows.Forms.CheckBox();
            this.Calc_button = new System.Windows.Forms.Button();
            this.Result_textBox = new System.Windows.Forms.TextBox();
            this.NumberofAttacks_textBox = new System.Windows.Forms.TextBox();
            this.RerollFailedtoHit_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MasterCrafted_checkBox = new System.Windows.Forms.CheckBox();
            this.CC_radioButton = new System.Windows.Forms.RadioButton();
            this.RW_radioButton = new System.Windows.Forms.RadioButton();
            this.BS_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Flashbane_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Poisoned_comboBox = new System.Windows.Forms.ComboBox();
            this.RP_checkBox = new System.Windows.Forms.CheckBox();
            this.EnhancedRP_checkBox = new System.Windows.Forms.CheckBox();
            this.Sniper_checkBox = new System.Windows.Forms.CheckBox();
            this.Rending_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AttackerWS
            // 
            this.AttackerWS.AutoSize = true;
            this.AttackerWS.Cursor = System.Windows.Forms.Cursors.Default;
            this.AttackerWS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackerWS.Location = new System.Drawing.Point(12, 44);
            this.AttackerWS.Name = "AttackerWS";
            this.AttackerWS.Size = new System.Drawing.Size(84, 15);
            this.AttackerWS.TabIndex = 0;
            this.AttackerWS.Text = "Attacker WS";
            // 
            // TargetWS
            // 
            this.TargetWS.AutoSize = true;
            this.TargetWS.Cursor = System.Windows.Forms.Cursors.Default;
            this.TargetWS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetWS.Location = new System.Drawing.Point(187, 44);
            this.TargetWS.Name = "TargetWS";
            this.TargetWS.Size = new System.Drawing.Size(70, 15);
            this.TargetWS.TabIndex = 1;
            this.TargetWS.Text = "Target WS";
            // 
            // Strength
            // 
            this.Strength.AutoSize = true;
            this.Strength.Cursor = System.Windows.Forms.Cursors.Default;
            this.Strength.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strength.Location = new System.Drawing.Point(12, 66);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(112, 15);
            this.Strength.TabIndex = 4;
            this.Strength.Text = "Weapon Strength";
            // 
            // Preferedenemy_checkBox
            // 
            this.Preferedenemy_checkBox.AutoSize = true;
            this.Preferedenemy_checkBox.Location = new System.Drawing.Point(337, 64);
            this.Preferedenemy_checkBox.Name = "Preferedenemy_checkBox";
            this.Preferedenemy_checkBox.Size = new System.Drawing.Size(100, 17);
            this.Preferedenemy_checkBox.TabIndex = 6;
            this.Preferedenemy_checkBox.Text = "Prefered enemy";
            this.Preferedenemy_checkBox.UseVisualStyleBackColor = true;
            // 
            // A_WS_comboBox
            // 
            this.A_WS_comboBox.FormattingEnabled = true;
            this.A_WS_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.A_WS_comboBox.Location = new System.Drawing.Point(130, 42);
            this.A_WS_comboBox.MaxDropDownItems = 11;
            this.A_WS_comboBox.Name = "A_WS_comboBox";
            this.A_WS_comboBox.Size = new System.Drawing.Size(40, 21);
            this.A_WS_comboBox.TabIndex = 7;
            this.A_WS_comboBox.Text = "4";
            // 
            // T_WS_comboBox
            // 
            this.T_WS_comboBox.FormattingEnabled = true;
            this.T_WS_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.T_WS_comboBox.Location = new System.Drawing.Point(266, 42);
            this.T_WS_comboBox.MaxDropDownItems = 11;
            this.T_WS_comboBox.Name = "T_WS_comboBox";
            this.T_WS_comboBox.Size = new System.Drawing.Size(40, 21);
            this.T_WS_comboBox.TabIndex = 8;
            this.T_WS_comboBox.Text = "4";
            // 
            // Toughness
            // 
            this.Toughness.AutoSize = true;
            this.Toughness.Cursor = System.Windows.Forms.Cursors.Default;
            this.Toughness.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toughness.Location = new System.Drawing.Point(187, 66);
            this.Toughness.Name = "Toughness";
            this.Toughness.Size = new System.Drawing.Size(70, 15);
            this.Toughness.TabIndex = 9;
            this.Toughness.Text = "Toughness";
            // 
            // Strength_comboBox
            // 
            this.Strength_comboBox.FormattingEnabled = true;
            this.Strength_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Strength_comboBox.Location = new System.Drawing.Point(130, 64);
            this.Strength_comboBox.MaxDropDownItems = 11;
            this.Strength_comboBox.Name = "Strength_comboBox";
            this.Strength_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Strength_comboBox.TabIndex = 10;
            this.Strength_comboBox.Text = "4";
            // 
            // Toughness_comboBox
            // 
            this.Toughness_comboBox.FormattingEnabled = true;
            this.Toughness_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Toughness_comboBox.Location = new System.Drawing.Point(266, 64);
            this.Toughness_comboBox.MaxDropDownItems = 11;
            this.Toughness_comboBox.Name = "Toughness_comboBox";
            this.Toughness_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Toughness_comboBox.TabIndex = 11;
            this.Toughness_comboBox.Text = "4";
            // 
            // ArmourPercing
            // 
            this.ArmourPercing.AutoSize = true;
            this.ArmourPercing.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArmourPercing.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmourPercing.Location = new System.Drawing.Point(12, 93);
            this.ArmourPercing.Name = "ArmourPercing";
            this.ArmourPercing.Size = new System.Drawing.Size(21, 15);
            this.ArmourPercing.TabIndex = 12;
            this.ArmourPercing.Text = "AP";
            // 
            // AP_comboBox
            // 
            this.AP_comboBox.FormattingEnabled = true;
            this.AP_comboBox.Items.AddRange(new object[] {
            "-",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.AP_comboBox.Location = new System.Drawing.Point(130, 87);
            this.AP_comboBox.MaxDropDownItems = 11;
            this.AP_comboBox.Name = "AP_comboBox";
            this.AP_comboBox.Size = new System.Drawing.Size(40, 21);
            this.AP_comboBox.TabIndex = 13;
            this.AP_comboBox.Text = "-";
            // 
            // ArmourSave_comboBox
            // 
            this.ArmourSave_comboBox.FormattingEnabled = true;
            this.ArmourSave_comboBox.Items.AddRange(new object[] {
            "-",
            "6+",
            "5+",
            "4+",
            "3+",
            "2+"});
            this.ArmourSave_comboBox.Location = new System.Drawing.Point(266, 87);
            this.ArmourSave_comboBox.MaxDropDownItems = 11;
            this.ArmourSave_comboBox.Name = "ArmourSave_comboBox";
            this.ArmourSave_comboBox.Size = new System.Drawing.Size(40, 21);
            this.ArmourSave_comboBox.TabIndex = 15;
            this.ArmourSave_comboBox.Text = "-";
            // 
            // ArmourSave
            // 
            this.ArmourSave.AutoSize = true;
            this.ArmourSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArmourSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmourSave.Location = new System.Drawing.Point(187, 89);
            this.ArmourSave.Name = "ArmourSave";
            this.ArmourSave.Size = new System.Drawing.Size(77, 15);
            this.ArmourSave.TabIndex = 14;
            this.ArmourSave.Text = "Armour Sv.";
            // 
            // InvSave_comboBox
            // 
            this.InvSave_comboBox.FormattingEnabled = true;
            this.InvSave_comboBox.Items.AddRange(new object[] {
            "-",
            "6+",
            "5+",
            "4+",
            "3+",
            "2+"});
            this.InvSave_comboBox.Location = new System.Drawing.Point(266, 109);
            this.InvSave_comboBox.MaxDropDownItems = 11;
            this.InvSave_comboBox.Name = "InvSave_comboBox";
            this.InvSave_comboBox.Size = new System.Drawing.Size(40, 21);
            this.InvSave_comboBox.TabIndex = 17;
            this.InvSave_comboBox.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inv. Save";
            // 
            // FNP_comboBox
            // 
            this.FNP_comboBox.FormattingEnabled = true;
            this.FNP_comboBox.Items.AddRange(new object[] {
            "-",
            "6+",
            "5+",
            "4+"});
            this.FNP_comboBox.Location = new System.Drawing.Point(266, 134);
            this.FNP_comboBox.MaxDropDownItems = 11;
            this.FNP_comboBox.Name = "FNP_comboBox";
            this.FNP_comboBox.Size = new System.Drawing.Size(40, 21);
            this.FNP_comboBox.TabIndex = 19;
            this.FNP_comboBox.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "FNP";
            // 
            // Shred_checkBox
            // 
            this.Shred_checkBox.AutoSize = true;
            this.Shred_checkBox.Location = new System.Drawing.Point(337, 109);
            this.Shred_checkBox.Name = "Shred_checkBox";
            this.Shred_checkBox.Size = new System.Drawing.Size(54, 17);
            this.Shred_checkBox.TabIndex = 20;
            this.Shred_checkBox.Text = "Shred";
            this.Shred_checkBox.UseVisualStyleBackColor = true;
            // 
            // Calc_button
            // 
            this.Calc_button.Location = new System.Drawing.Point(21, 212);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(75, 23);
            this.Calc_button.TabIndex = 21;
            this.Calc_button.Text = "Calculate";
            this.Calc_button.UseVisualStyleBackColor = true;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click);
            // 
            // Result_textBox
            // 
            this.Result_textBox.BackColor = System.Drawing.Color.White;
            this.Result_textBox.Location = new System.Drawing.Point(15, 241);
            this.Result_textBox.Multiline = true;
            this.Result_textBox.Name = "Result_textBox";
            this.Result_textBox.ReadOnly = true;
            this.Result_textBox.Size = new System.Drawing.Size(257, 109);
            this.Result_textBox.TabIndex = 22;
            // 
            // NumberofAttacks_textBox
            // 
            this.NumberofAttacks_textBox.Location = new System.Drawing.Point(130, 138);
            this.NumberofAttacks_textBox.Name = "NumberofAttacks_textBox";
            this.NumberofAttacks_textBox.Size = new System.Drawing.Size(40, 20);
            this.NumberofAttacks_textBox.TabIndex = 23;
            this.NumberofAttacks_textBox.Text = "1";
            // 
            // RerollFailedtoHit_checkBox
            // 
            this.RerollFailedtoHit_checkBox.AutoSize = true;
            this.RerollFailedtoHit_checkBox.Location = new System.Drawing.Point(337, 87);
            this.RerollFailedtoHit_checkBox.Name = "RerollFailedtoHit_checkBox";
            this.RerollFailedtoHit_checkBox.Size = new System.Drawing.Size(117, 17);
            this.RerollFailedtoHit_checkBox.TabIndex = 24;
            this.RerollFailedtoHit_checkBox.Text = "Hatred/Twin-linked";
            this.RerollFailedtoHit_checkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "# of attacks";
            // 
            // MasterCrafted_checkBox
            // 
            this.MasterCrafted_checkBox.AutoSize = true;
            this.MasterCrafted_checkBox.Location = new System.Drawing.Point(337, 44);
            this.MasterCrafted_checkBox.Name = "MasterCrafted_checkBox";
            this.MasterCrafted_checkBox.Size = new System.Drawing.Size(95, 17);
            this.MasterCrafted_checkBox.TabIndex = 5;
            this.MasterCrafted_checkBox.Text = "Master-Crafted";
            this.MasterCrafted_checkBox.UseVisualStyleBackColor = true;
            // 
            // CC_radioButton
            // 
            this.CC_radioButton.AutoSize = true;
            this.CC_radioButton.Checked = true;
            this.CC_radioButton.Location = new System.Drawing.Point(190, 12);
            this.CC_radioButton.Name = "CC_radioButton";
            this.CC_radioButton.Size = new System.Drawing.Size(90, 17);
            this.CC_radioButton.TabIndex = 26;
            this.CC_radioButton.TabStop = true;
            this.CC_radioButton.Text = "Close Combat";
            this.CC_radioButton.UseVisualStyleBackColor = true;
            this.CC_radioButton.Click += new System.EventHandler(this.CC_click);
            // 
            // RW_radioButton
            // 
            this.RW_radioButton.AutoSize = true;
            this.RW_radioButton.Location = new System.Drawing.Point(286, 12);
            this.RW_radioButton.Name = "RW_radioButton";
            this.RW_radioButton.Size = new System.Drawing.Size(101, 17);
            this.RW_radioButton.TabIndex = 27;
            this.RW_radioButton.Text = "Range Weapon";
            this.RW_radioButton.UseVisualStyleBackColor = true;
            this.RW_radioButton.Click += new System.EventHandler(this.RW_Click);
            // 
            // BS_comboBox
            // 
            this.BS_comboBox.FormattingEnabled = true;
            this.BS_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.BS_comboBox.Location = new System.Drawing.Point(130, 12);
            this.BS_comboBox.MaxDropDownItems = 11;
            this.BS_comboBox.Name = "BS_comboBox";
            this.BS_comboBox.Size = new System.Drawing.Size(40, 21);
            this.BS_comboBox.TabIndex = 30;
            this.BS_comboBox.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Attacker BS";
            // 
            // Flashbane_checkBox
            // 
            this.Flashbane_checkBox.AutoSize = true;
            this.Flashbane_checkBox.Location = new System.Drawing.Point(337, 132);
            this.Flashbane_checkBox.Name = "Flashbane_checkBox";
            this.Flashbane_checkBox.Size = new System.Drawing.Size(75, 17);
            this.Flashbane_checkBox.TabIndex = 31;
            this.Flashbane_checkBox.Text = "Flashbane";
            this.Flashbane_checkBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Poisoned";
            this.label5.Visible = false;
            // 
            // Poisoned_comboBox
            // 
            this.Poisoned_comboBox.FormattingEnabled = true;
            this.Poisoned_comboBox.Items.AddRange(new object[] {
            "-",
            "6+",
            "5+",
            "4+",
            "3+",
            "2+"});
            this.Poisoned_comboBox.Location = new System.Drawing.Point(130, 113);
            this.Poisoned_comboBox.MaxDropDownItems = 11;
            this.Poisoned_comboBox.Name = "Poisoned_comboBox";
            this.Poisoned_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Poisoned_comboBox.TabIndex = 33;
            this.Poisoned_comboBox.Text = "-";
            this.Poisoned_comboBox.Visible = false;
            // 
            // RP_checkBox
            // 
            this.RP_checkBox.AutoSize = true;
            this.RP_checkBox.Location = new System.Drawing.Point(189, 166);
            this.RP_checkBox.Name = "RP_checkBox";
            this.RP_checkBox.Size = new System.Drawing.Size(68, 17);
            this.RP_checkBox.TabIndex = 34;
            this.RP_checkBox.Text = "FNP=RP";
            this.RP_checkBox.UseVisualStyleBackColor = true;
            // 
            // EnhancedRP_checkBox
            // 
            this.EnhancedRP_checkBox.AutoSize = true;
            this.EnhancedRP_checkBox.Location = new System.Drawing.Point(189, 189);
            this.EnhancedRP_checkBox.Name = "EnhancedRP_checkBox";
            this.EnhancedRP_checkBox.Size = new System.Drawing.Size(93, 17);
            this.EnhancedRP_checkBox.TabIndex = 35;
            this.EnhancedRP_checkBox.Text = "Enhacned RP";
            this.EnhancedRP_checkBox.UseVisualStyleBackColor = true;
            // 
            // Sniper_checkBox
            // 
            this.Sniper_checkBox.AutoSize = true;
            this.Sniper_checkBox.Location = new System.Drawing.Point(337, 155);
            this.Sniper_checkBox.Name = "Sniper_checkBox";
            this.Sniper_checkBox.Size = new System.Drawing.Size(56, 17);
            this.Sniper_checkBox.TabIndex = 36;
            this.Sniper_checkBox.Text = "Sniper";
            this.Sniper_checkBox.UseVisualStyleBackColor = true;
            this.Sniper_checkBox.Visible = false;
            // 
            // Rending_checkBox
            // 
            this.Rending_checkBox.AutoSize = true;
            this.Rending_checkBox.Location = new System.Drawing.Point(337, 178);
            this.Rending_checkBox.Name = "Rending_checkBox";
            this.Rending_checkBox.Size = new System.Drawing.Size(66, 17);
            this.Rending_checkBox.TabIndex = 37;
            this.Rending_checkBox.Text = "Rending";
            this.Rending_checkBox.UseVisualStyleBackColor = true;
            this.Rending_checkBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 368);
            this.Controls.Add(this.Rending_checkBox);
            this.Controls.Add(this.Sniper_checkBox);
            this.Controls.Add(this.EnhancedRP_checkBox);
            this.Controls.Add(this.RP_checkBox);
            this.Controls.Add(this.Poisoned_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Flashbane_checkBox);
            this.Controls.Add(this.BS_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RW_radioButton);
            this.Controls.Add(this.CC_radioButton);
            this.Controls.Add(this.AttackerWS);
            this.Controls.Add(this.TargetWS);
            this.Controls.Add(this.MasterCrafted_checkBox);
            this.Controls.Add(this.A_WS_comboBox);
            this.Controls.Add(this.T_WS_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RerollFailedtoHit_checkBox);
            this.Controls.Add(this.NumberofAttacks_textBox);
            this.Controls.Add(this.Result_textBox);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.Shred_checkBox);
            this.Controls.Add(this.FNP_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvSave_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArmourSave_comboBox);
            this.Controls.Add(this.ArmourSave);
            this.Controls.Add(this.AP_comboBox);
            this.Controls.Add(this.ArmourPercing);
            this.Controls.Add(this.Toughness_comboBox);
            this.Controls.Add(this.Strength_comboBox);
            this.Controls.Add(this.Toughness);
            this.Controls.Add(this.Preferedenemy_checkBox);
            this.Controls.Add(this.Strength);
            this.Name = "Form1";
            this.Text = "WH40K";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttackerWS;
        private System.Windows.Forms.Label TargetWS;
        private System.Windows.Forms.Label Strength;
        private System.Windows.Forms.CheckBox Preferedenemy_checkBox;
        private System.Windows.Forms.ComboBox A_WS_comboBox;
        private System.Windows.Forms.ComboBox T_WS_comboBox;
        private System.Windows.Forms.Label Toughness;
        private System.Windows.Forms.ComboBox Strength_comboBox;
        private System.Windows.Forms.ComboBox Toughness_comboBox;
        private System.Windows.Forms.Label ArmourPercing;
        private System.Windows.Forms.ComboBox AP_comboBox;
        private System.Windows.Forms.ComboBox ArmourSave_comboBox;
        private System.Windows.Forms.Label ArmourSave;
        private System.Windows.Forms.ComboBox InvSave_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FNP_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Shred_checkBox;
        private System.Windows.Forms.Button Calc_button;
        private System.Windows.Forms.TextBox Result_textBox;
        private System.Windows.Forms.TextBox NumberofAttacks_textBox;
        private System.Windows.Forms.CheckBox RerollFailedtoHit_checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MasterCrafted_checkBox;
        private System.Windows.Forms.RadioButton CC_radioButton;
        private System.Windows.Forms.RadioButton RW_radioButton;
        private System.Windows.Forms.ComboBox BS_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Flashbane_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Poisoned_comboBox;
        private System.Windows.Forms.CheckBox RP_checkBox;
        private System.Windows.Forms.CheckBox EnhancedRP_checkBox;
        private System.Windows.Forms.CheckBox Sniper_checkBox;
        private System.Windows.Forms.CheckBox Rending_checkBox;
    }
}

