using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        const string ConnectionString = "Server=tcp:uwad-cloudintegration-server.database.windows.net,1433;Initial Catalog=BudgetApp;Persist Security Info=False;User ID=Jeflick;Password=Bloodiertunic1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        List<User> credentials = new List<User>();

        private void DBSubmit_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            string pass = PasswordTextBox.Text;

            Query();

            bool UNameCheck = credentials.Any(x => x.User_Name == UserName);
            bool PassCheck = credentials.Any(x => x.Password == pass);
            if (true == UNameCheck)
            {
                if(true == PassCheck)
                {
                    
                    CurrentUser.ActiveUser = UserNameTextBox.Text;
                    CurrentUser.UserID = credentials[0].ID;
                    OpenHomeScreen();
                }
                else
                {
                    LabelError2.Text = "Password is Incorrect.";
                }
            }
            else 
            {
                LabelError2.Text = "Username " + UserName +  " does not exist.";
 
            }
        }

        private void DBQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            Credentials db = new Credentials();
            credentials = db.GetCredentials(UserNameTextBox.Text);
        }


        private void OpenCreateCredentialsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var CreateCredForm = new CreateCredentials();
            CreateCredForm.Closed += (s, args) => this.Close();
            CreateCredForm.Show();
        }

        private void OpenHomeScreen()
        {
            this.Hide();
            var HomeScreenForm = new HomeScreen();
            HomeScreenForm.Closed += (s, args) => this.Close();
            HomeScreenForm.Show();
        }

        private void HomeScreenButton_Click(object sender, EventArgs e)
        {
            OpenHomeScreen();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            //string TempUser = UserNameTextBox.Text;
            //System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            //connection.Open();
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "Select Id from [User] where User_Name = '" + TempUser + "'";
            //cmd.Connection = connection;

            //cmd.ExecuteNonQuery();
            //SqlDataReader rdr = cmd.ExecuteReader();
            //connection.Close();

            //string TempID = rdr.ToString();
            //LabelError2.Text = TempID;
            Query();

            //User id = new User();
            //{
            //    //int TempID = DisplayMember.credentials[0];
            //    string TempID = credentials[0].ToString();
            //    LabelError2.Text = TempID;
            //}
            //listBoxTest.DataSource = credentials;
            //listBoxTest.DisplayMember = "ID";

            int TempId = credentials[0].ID;

        }
    }
}
