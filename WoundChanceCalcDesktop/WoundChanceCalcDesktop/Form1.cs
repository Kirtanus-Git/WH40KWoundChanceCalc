﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoundChanceCalcDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static DataTable GetTable()
        {
            //
            DataTable ToHittable = new DataTable();
            ToHittable.Columns.Add("TWS", typeof(int));
            ToHittable.Columns.Add("AWS1", typeof(int));
            ToHittable.Columns.Add("AWS2", typeof(int));
            ToHittable.Columns.Add("AWS3", typeof(int));
            ToHittable.Columns.Add("AWS4", typeof(int));

            //
            ToHittable.Rows.Add(0, 1, 1, 1, 1);
            ToHittable.Rows.Add(1, 4, 3, 3, 3);
            ToHittable.Rows.Add(2, 4, 4, 3, 3);
            ToHittable.Rows.Add(3, 5, 4, 4, 3);
            ToHittable.Rows.Add(4, 5, 4, 4, 4);
            ToHittable.Rows.Add(5, 5, 5, 4, 4);
            ToHittable.Rows.Add(6, 5, 5, 4, 4);
            ToHittable.Rows.Add(7, 5, 5, 5, 4);
            ToHittable.Rows.Add(8, 5, 5, 5, 4);
            ToHittable.Rows.Add(9, 5, 5, 5, 5);
            ToHittable.Rows.Add(10, 5, 5, 5, 5);
            return ToHittable;
        }

        public bool ValidateInput() 
        {
            int x;
            bool Valid = true;
            if (!(int.TryParse(A_WS_comboBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(T_WS_comboBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(Strength_comboBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(Toughness_comboBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(BS_comboBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(NumberofAttacks_textBox.Text, out x))) { Valid = false; }
            if (!(int.TryParse(AP_comboBox.Text, out x))) 
            {
                if (AP_comboBox.Text != "-") { Valid = false; } ;
            }
            if (!(int.TryParse((ArmourSave_comboBox.Text.Substring(0,1)), out x))) 
            {
                if (ArmourSave_comboBox.Text != "-") { Valid = false; } ;
            }
            if (!(int.TryParse(InvSave_comboBox.Text.Substring(0, 1), out x))) 
            {
                if (InvSave_comboBox.Text != "-") { Valid = false; } ;
            }
            if (!(int.TryParse(FNP_comboBox.Text.Substring(0, 1), out x))) 
            {
                if (FNP_comboBox.Text != "-") { Valid = false; };
            }
            if (!(int.TryParse(Poisoned_comboBox.Text.Substring(0, 1), out x)))
            {
                if (Poisoned_comboBox.Text != "-") { Valid = false; };
            }
            return Valid;
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // To Hit calculation
                double ToHitRoll = 7;
                double ToHitChance;
                double ToHitsPass;
                double NumberofHits;
                double ToHitsPassReroll;

                // Close Combat to Hit rolls
                if (CC_radioButton.Checked)
                {
                    int A_WS = Int32.Parse(A_WS_comboBox.Text);
                    int T_ws = Int32.Parse(T_WS_comboBox.Text);
                    if (A_WS >= 5)
                    {
                        if (T_ws < A_WS) { ToHitRoll = 3; } else { ToHitRoll = 4; }
                        if (T_ws == 0) { ToHitRoll = 1; }
                    }
                    else
                    {
                        DataTable ToHitTableRoll = GetTable();
                        ToHitRoll = ToHitTableRoll.Rows[T_ws].Field<int>(A_WS);
                    }
                }

                // Range weapons to Hit rolls
                if (RW_radioButton.Checked)
                {

                }


                // calculating hit chance and number of passed hits.
                NumberofHits = double.Parse(NumberofAttacks_textBox.Text);
                ToHitChance = (7 - ToHitRoll) / 6;
                ToHitsPass = ToHitChance * NumberofHits;
                ToHitsPassReroll = ToHitsPass + ((NumberofHits - ToHitsPass) * ToHitChance);
                // Special to-hit rules
                if (RerollFailedtoHit_checkBox.Checked)
                {
                    ToHitsPass = ToHitsPassReroll;
                }
                else
                {
                    if (MasterCrafted_checkBox.Checked)
                    {
                        ToHitsPass = ToHitsPass + ToHitChance;
                    }
                    if (Preferedenemy_checkBox.Checked)
                    {
                        ToHitsPass = ToHitsPass + ((NumberofHits / 6) * ToHitChance);
                    }
                    if (ToHitsPass > ToHitsPassReroll) { ToHitsPass = ToHitsPassReroll; }
                }


                // Calculate Passed Wounds
                double WoundsPassed;
                double WoundsPassedReroll;
                double ToWoundRoll = 7;
                double ToWoundChance;
                int Svalue = Int32.Parse(Strength_comboBox.Text);
                int Tvalue = Int32.Parse(Toughness_comboBox.Text);

                int STDiff = Svalue - Tvalue;

                // To Wound Roll
                if (STDiff == 0) { ToWoundRoll = 4; }
                if (STDiff == -1) {ToWoundRoll = 5; }
                if (STDiff == -2) { ToWoundRoll = 6; }
                if (STDiff == -3) { ToWoundRoll = 6; }
                if (STDiff < -3) { ToWoundRoll = 7; }
                if (STDiff == 1) { ToWoundRoll = 3; }
                if (STDiff >= 2) { ToWoundRoll = 2; }

                if (Poisoned_comboBox.Text != "-") { }

                if (Flashbane_checkBox.Checked) { ToWoundRoll = 2; }


                // To wound chance
                ToWoundChance = (7 - ToWoundRoll) / 6;
                WoundsPassed = ToHitsPass * ToWoundChance;
                WoundsPassedReroll = WoundsPassed + ((ToHitsPass - WoundsPassed) * ToWoundChance);

                // Wound Special Rules
                if (Shred_checkBox.Checked)
                { WoundsPassed = WoundsPassedReroll; }
                else
                {
                    if (Preferedenemy_checkBox.Checked)
                    {
                        WoundsPassed = WoundsPassed + ((ToHitsPass / 6) * ToWoundChance);
                    }
                }
              
                // Saves
                double APValue;
                if (!(double.TryParse(AP_comboBox.Text.Substring(0, 1), out APValue))) { APValue = 7; }
                double ASValue;
                if (!(double.TryParse(ArmourSave_comboBox.Text.Substring(0, 1), out ASValue))) { ASValue = 7; }
                double InvValue;
                if (!(double.TryParse(InvSave_comboBox.Text.Substring(0, 1), out InvValue))) { InvValue = 7; }

                double UnsavedWounds = 0;
                if (APValue <= ASValue) 
                {
                    UnsavedWounds = WoundsPassed - (((7 - InvValue) / 6) * WoundsPassed);
                }
                else
                {
                    UnsavedWounds = WoundsPassed - (((7 - ASValue) / 6) * WoundsPassed);
                }

                // FNP rolls
                double FinalWounds = UnsavedWounds;
                double FNPvalue;
                if (!(double.TryParse(FNP_comboBox.Text.Substring(0, 1), out FNPvalue))) { FNPvalue = 7; }
                if ((Tvalue * 2) > Svalue) { FinalWounds = UnsavedWounds - (((7 - FNPvalue) / 6) * UnsavedWounds);  }


                Result_textBox.Text = "Passed Hits: " + ToHitsPass.ToString();
                Result_textBox.AppendText(Environment.NewLine);
                Result_textBox.AppendText("Passed Wounds: " + WoundsPassed.ToString());
                Result_textBox.AppendText(Environment.NewLine);
                Result_textBox.AppendText("Unsaved Wounds: " + UnsavedWounds.ToString());
                Result_textBox.AppendText(Environment.NewLine);
                Result_textBox.AppendText("Final Wounds Count: " + FinalWounds.ToString());


            }
            else { MessageBox.Show("Incorrect Input"); }

        }

        private void RW_Click(object sender, EventArgs e)
        {

        }

        private void CC_click(object sender, EventArgs e)
        {

        }
    }
}
