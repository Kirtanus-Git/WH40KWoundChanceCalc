using System;
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


        private void Calc_button_Click(object sender, EventArgs e)
        {
            // To Hit calculation
            double ToHitRoll;
            double ToHitChance;
            double ToHitsPass;
            double NumberofHits;
            double ToHitsPassReroll;

            // Close Combat to Hit rolls
            int A_WS = Int32.Parse(A_WS_comboBox.Text);
            int T_ws = Int32.Parse(T_WS_comboBox.Text);
            if (A_WS >= 5) {
                if (T_ws < A_WS) { ToHitRoll = 3; } else { ToHitRoll = 4; }
                if (T_ws == 0) { ToHitRoll = 1; }
            }
            else {
                DataTable ToHitTableRoll = GetTable();
                ToHitRoll = ToHitTableRoll.Rows[T_ws].Field<int>(A_WS);
            }

            // Range weapons to Hit rolls

            // calculating hit chance and number of passed hits.
            NumberofHits = double.Parse(NumberofHits_textBox.Text);
            ToHitChance = (7-ToHitRoll)/6;
            ToHitsPass = ToHitChance * NumberofHits;
            ToHitsPassReroll = ToHitsPass + ((NumberofHits - ToHitsPass) * ToHitChance);
            // Special to-hit rules
            if (Hatred_checkBox.Checked)
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
            

            Result_textBox.Text = " Passed Hits:" + ToHitsPass.ToString();
            Result_textBox.AppendText(Environment.NewLine);
            Result_textBox.AppendText("asfasfa");


        }
    }
}
