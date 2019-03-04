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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            //sets the text in the textboxes to be equal to the value the user inserted last time the calculator tab was open.
            hoursWeekBefore18.Text = Convert.ToString(Settings.Default["hBefore18"]);
            hoursWeekAfter18.Text = Convert.ToString(Settings.Default["hAfter18"]);
            hoursSat.Text = Convert.ToString(Settings.Default["hSat"]);
            hoursSun.Text = Convert.ToString(Settings.Default["hSun"]);
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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Assigns what the user inserted into the textboxes to the respective global variables
            Settings.Default["hBefore18"] = Convert.ToDouble(hoursWeekBefore18.Text);
            Settings.Default["hAfter18"] = Convert.ToDouble(hoursWeekAfter18.Text);
            Settings.Default["hSat"] = Convert.ToDouble(hoursSat.Text);
            Settings.Default["hSun"] = Convert.ToDouble(hoursSun.Text);

            //Converts all the global variables (objects) into local doubles
            double hB18 = Convert.ToDouble(Settings.Default["hBefore18"]);
            double hA18 = Convert.ToDouble(Settings.Default["hAfter18"]);
            double hSat = Convert.ToDouble(Settings.Default["hSat"]);
            double hSun = Convert.ToDouble(Settings.Default["hSun"]);

            double hourlyRate = Convert.ToDouble(Settings.Default["hourlyRate"]);
            double extraWeek = Convert.ToDouble(Settings.Default["extraWeek"]);
            double extraSat = Convert.ToDouble(Settings.Default["extraSat"]);
            double extraSun = Convert.ToDouble(Settings.Default["extraSun"]);

            double totalHours = hB18 + hA18 + hSat + hSun;

            double finalSalary = totalHours * hourlyRate + hA18 * extraWeek + hSat * extraSat + hSun * extraSun;

            MessageBox.Show(Convert.ToString(finalSalary), "Your final salary");
        }
    }
}
