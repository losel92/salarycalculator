using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace SalaryCalculator
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            //sets the text in the textboxes to be equal to the value the user inserted last time the settings tab was open.
            hourlyRateBox.Text = Convert.ToString(Settings.Default["hourlyRate"]);
            extraSatBox.Text = Convert.ToString(Settings.Default["extraSat"]);
            extraSunBox.Text = Convert.ToString(Settings.Default["extraSun"]);
            extraWeekBox.Text = Convert.ToString(Settings.Default["extraWeek"]);
        }

        //Makes it so the user is only allowed to insert numbers and a comma in the textbox
        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        //Everytime the user presses the button, it saves the numbers in the textboxes to the default variables
        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default["hourlyRate"] = Convert.ToDouble(hourlyRateBox.Text);
            Settings.Default["extraSat"] = Convert.ToDouble(extraSatBox.Text);
            Settings.Default["extraSun"] = Convert.ToDouble(extraSunBox.Text);
            Settings.Default["extraWeek"] = Convert.ToDouble(extraWeekBox.Text);

            MessageBox.Show("Settings succesfully saved", "Success");

        }
    }
}
