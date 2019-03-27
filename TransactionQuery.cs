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
    class TransactionQuery
    {
        const string ConnectionString = "Server=tcp:uwad-cloudintegration-server.database.windows.net,1433;Initial Catalog=BudgetApp;Persist Security Info=False;User ID=Jeflick;Password=Bloodiertunic1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<Transaction> GetTransaction()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                var output = connection.Query<Transaction>($"select  Budget_Item, Transaction_Type, Txn_amount from [Transaction_History] where User_Id = '" + CurrentUser.UserID + "'").ToList();
                return output;

            }
        }
    }
    
}
