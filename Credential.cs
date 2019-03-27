using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Credentials
    {
        const string ConnectionString = "Server=tcp:uwad-cloudintegration-server.database.windows.net,1433;Initial Catalog=BudgetApp;Persist Security Info=False;User ID=Jeflick;Password=Bloodiertunic1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<User> GetCredentials(string UserNameTextBox)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                var output = connection.Query<User>($"select * from [User] where User_Name = '" + UserNameTextBox + "'").ToList();
                return output;

            }
        }
    }
}