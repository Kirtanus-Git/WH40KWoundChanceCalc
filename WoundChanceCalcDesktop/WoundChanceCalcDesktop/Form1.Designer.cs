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
            this.NumberofHits_textBox = new System.Windows.Forms.TextBox();
            this.Hatred_checkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MasterCrafted_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttackerWS
            // 
            this.AttackerWS.AutoSize = true;
            this.AttackerWS.Cursor = System.Windows.Forms.Cursors.Default;
            this.AttackerWS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttackerWS.Location = new System.Drawing.Point(3, 9);
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
            this.TargetWS.Location = new System.Drawing.Point(182, 9);
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
            this.Strength.Location = new System.Drawing.Point(18, 45);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(112, 15);
            this.Strength.TabIndex = 4;
            this.Strength.Text = "Weapon Strength";
            // 
            // Preferedenemy_checkBox
            // 
            this.Preferedenemy_checkBox.AutoSize = true;
            this.Preferedenemy_checkBox.Location = new System.Drawing.Point(343, 43);
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
            this.A_WS_comboBox.Location = new System.Drawing.Point(122, 7);
            this.A_WS_comboBox.MaxDropDownItems = 11;
            this.A_WS_comboBox.Name = "A_WS_comboBox";
            this.A_WS_comboBox.Size = new System.Drawing.Size(40, 21);
            this.A_WS_comboBox.TabIndex = 7;
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
            this.T_WS_comboBox.Location = new System.Drawing.Point(258, 9);
            this.T_WS_comboBox.MaxDropDownItems = 11;
            this.T_WS_comboBox.Name = "T_WS_comboBox";
            this.T_WS_comboBox.Size = new System.Drawing.Size(40, 21);
            this.T_WS_comboBox.TabIndex = 8;
            // 
            // Toughness
            // 
            this.Toughness.AutoSize = true;
            this.Toughness.Cursor = System.Windows.Forms.Cursors.Default;
            this.Toughness.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toughness.Location = new System.Drawing.Point(196, 45);
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
            this.Strength_comboBox.Location = new System.Drawing.Point(136, 43);
            this.Strength_comboBox.MaxDropDownItems = 11;
            this.Strength_comboBox.Name = "Strength_comboBox";
            this.Strength_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Strength_comboBox.TabIndex = 10;
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
            this.Toughness_comboBox.Location = new System.Drawing.Point(272, 43);
            this.Toughness_comboBox.MaxDropDownItems = 11;
            this.Toughness_comboBox.Name = "Toughness_comboBox";
            this.Toughness_comboBox.Size = new System.Drawing.Size(40, 21);
            this.Toughness_comboBox.TabIndex = 11;
            // 
            // ArmourPercing
            // 
            this.ArmourPercing.AutoSize = true;
            this.ArmourPercing.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArmourPercing.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmourPercing.Location = new System.Drawing.Point(18, 72);
            this.ArmourPercing.Name = "ArmourPercing";
            this.ArmourPercing.Size = new System.Drawing.Size(21, 15);
            this.ArmourPercing.TabIndex = 12;
            this.ArmourPercing.Text = "AP";
            // 
            // AP_comboBox
            // 
            this.AP_comboBox.FormattingEnabled = true;
            this.AP_comboBox.Items.AddRange(new object[] {
            "",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.AP_comboBox.Location = new System.Drawing.Point(136, 66);
            this.AP_comboBox.MaxDropDownItems = 11;
            this.AP_comboBox.Name = "AP_comboBox";
            this.AP_comboBox.Size = new System.Drawing.Size(40, 21);
            this.AP_comboBox.TabIndex = 13;
            // 
            // ArmourSave_comboBox
            // 
            this.ArmourSave_comboBox.FormattingEnabled = true;
            this.ArmourSave_comboBox.Items.AddRange(new object[] {
            "",
            "6+",
            "5+",
            "4+",
            "3+",
            "2+"});
            this.ArmourSave_comboBox.Location = new System.Drawing.Point(272, 66);
            this.ArmourSave_comboBox.MaxDropDownItems = 11;
            this.ArmourSave_comboBox.Name = "ArmourSave_comboBox";
            this.ArmourSave_comboBox.Size = new System.Drawing.Size(40, 21);
            this.ArmourSave_comboBox.TabIndex = 15;
            // 
            // ArmourSave
            // 
            this.ArmourSave.AutoSize = true;
            this.ArmourSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.ArmourSave.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmourSave.Location = new System.Drawing.Point(196, 68);
            this.ArmourSave.Name = "ArmourSave";
            this.ArmourSave.Size = new System.Drawing.Size(77, 15);
            this.ArmourSave.TabIndex = 14;
            this.ArmourSave.Text = "Armour Sv.";
            // 
            // InvSave_comboBox
            // 
            this.InvSave_comboBox.FormattingEnabled = true;
            this.InvSave_comboBox.Items.AddRange(new object[] {
            "",
            "6+",
            "5+",
            "4+",
            "3+",
            "2+"});
            this.InvSave_comboBox.Location = new System.Drawing.Point(272, 88);
            this.InvSave_comboBox.MaxDropDownItems = 11;
            this.InvSave_comboBox.Name = "InvSave_comboBox";
            this.InvSave_comboBox.Size = new System.Drawing.Size(40, 21);
            this.InvSave_comboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inv. Save";
            // 
            // FNP_comboBox
            // 
            this.FNP_comboBox.FormattingEnabled = true;
            this.FNP_comboBox.Items.AddRange(new object[] {
            "",
            "6+",
            "5+",
            "4+"});
            this.FNP_comboBox.Location = new System.Drawing.Point(272, 113);
            this.FNP_comboBox.MaxDropDownItems = 11;
            this.FNP_comboBox.Name = "FNP_comboBox";
            this.FNP_comboBox.Size = new System.Drawing.Size(40, 21);
            this.FNP_comboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "FNP";
            // 
            // Shred_checkBox
            // 
            this.Shred_checkBox.AutoSize = true;
            this.Shred_checkBox.Location = new System.Drawing.Point(343, 88);
            this.Shred_checkBox.Name = "Shred_checkBox";
            this.Shred_checkBox.Size = new System.Drawing.Size(54, 17);
            this.Shred_checkBox.TabIndex = 20;
            this.Shred_checkBox.Text = "Shred";
            this.Shred_checkBox.UseVisualStyleBackColor = true;
            // 
            // Calc_button
            // 
            this.Calc_button.Location = new System.Drawing.Point(119, 180);
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
            this.Result_textBox.Location = new System.Drawing.Point(44, 224);
            this.Result_textBox.Multiline = true;
            this.Result_textBox.Name = "Result_textBox";
            this.Result_textBox.ReadOnly = true;
            this.Result_textBox.Size = new System.Drawing.Size(257, 109);
            this.Result_textBox.TabIndex = 22;
            // 
            // NumberofHits_textBox
            // 
            this.NumberofHits_textBox.Location = new System.Drawing.Point(136, 92);
            this.NumberofHits_textBox.Name = "NumberofHits_textBox";
            this.NumberofHits_textBox.Size = new System.Drawing.Size(40, 20);
            this.NumberofHits_textBox.TabIndex = 23;
            this.NumberofHits_textBox.Text = "1";
            // 
            // Hatred_checkBox
            // 
            this.Hatred_checkBox.AutoSize = true;
            this.Hatred_checkBox.Location = new System.Drawing.Point(343, 66);
            this.Hatred_checkBox.Name = "Hatred_checkBox";
            this.Hatred_checkBox.Size = new System.Drawing.Size(58, 17);
            this.Hatred_checkBox.TabIndex = 24;
            this.Hatred_checkBox.Text = "Hatred";
            this.Hatred_checkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "# of attacks";
            // 
            // MasterCrafted_checkBox
            // 
            this.MasterCrafted_checkBox.AutoSize = true;
            this.MasterCrafted_checkBox.Location = new System.Drawing.Point(343, 23);
            this.MasterCrafted_checkBox.Name = "MasterCrafted_checkBox";
            this.MasterCrafted_checkBox.Size = new System.Drawing.Size(95, 17);
            this.MasterCrafted_checkBox.TabIndex = 5;
            this.MasterCrafted_checkBox.Text = "Master-Crafted";
            this.MasterCrafted_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AttackerWS);
            this.panel1.Controls.Add(this.TargetWS);
            this.panel1.Controls.Add(this.A_WS_comboBox);
            this.panel1.Controls.Add(this.T_WS_comboBox);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 34);
            this.panel1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.MasterCrafted_checkBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hatred_checkBox);
            this.Controls.Add(this.NumberofHits_textBox);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox NumberofHits_textBox;
        private System.Windows.Forms.CheckBox Hatred_checkBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MasterCrafted_checkBox;
        private System.Windows.Forms.Panel panel1;
    }
}

