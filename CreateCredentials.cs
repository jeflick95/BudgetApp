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
    public partial class CreateCredentials : Form
    {
        public CreateCredentials()
        {
            InitializeComponent();
        }

        const string ConnectionString = "Server=tcp:uwad-cloudintegration-server.database.windows.net,1433;Initial Catalog=BudgetApp;Persist Security Info=False;User ID=Jeflick;Password=Bloodiertunic1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        List<User> credentials = new List<User>();

        private void CreateCredentialButton_Click(object sender, EventArgs e)
        {
            string UserName = CreateUserNameTextBox.Text;
            string pass = CreatePasswordTextBox.Text;
            string confPass = CreateConfirmPasswordTextBox.Text;

            if(pass != confPass)
            {
                LabelError2.Text = "Entered passwords do not match.";

            }
            else if(confPass == pass)
            {
                Query();
                bool UNameCheck = credentials.Any(x => x.User_Name == UserName);
                bool PassCheck = credentials.Any(x => x.Password == pass);

                if (true == UNameCheck)
                {
                    LabelError2.Text = "Username " + UserName + " alerady exists. Please create a different Username";
                }
                else if (false == UNameCheck)
                {
                    if(string.IsNullOrEmpty(pass))
                    {
                        LabelError2.Text = "Password cannot be blank.";
                    }
                    else 
                    {
                        SetCredentials();
                        this.Hide();
                        var LogInForm = new LogIn();
                        LogInForm.Closed += (s, args) => this.Close();
                        LogInForm.Show();
                    }
                }
            }
        }

        private void Query()
        {
            Credentials db = new Credentials();
            credentials = db.GetCredentials(CreateUserNameTextBox.Text);
        }

        private void SetCredentials()
        {
            string TBUser_Name = CreateUserNameTextBox.Text;
            string TBPassword = CreatePasswordTextBox.Text;
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            connection.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT into [User] (User_Name, Password) VALUES ('" + TBUser_Name + "', '" + TBPassword + "')";
            cmd.Connection = connection;

            cmd.ExecuteNonQuery();
            connection.Close();
        }


    }
}
