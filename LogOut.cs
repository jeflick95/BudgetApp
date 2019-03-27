using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogOut : Form
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            OpenLogInScreen();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            OpenHomeScreen();
        }

        private void OpenHomeScreen()
        {
            this.Hide();
            var HomeScreenForm = new HomeScreen();
            HomeScreenForm.Closed += (s, args) => this.Close();
            HomeScreenForm.Show();
        }

        private void OpenLogInScreen()
        {
            this.Hide();
            var LogInScreen = new LogIn();
            LogInScreen.Closed += (s, args) => this.Close();
            LogInScreen.Show();
        }
    }
}
