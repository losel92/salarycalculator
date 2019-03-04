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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        //Opens calculator window
        private void calculatorButton_Click(object sender, EventArgs e)
        {
            calculator calc = new calculator();
            calc.Show();
        }

        //Opens settings window
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
        }

        //Exits the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
