using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            CallChart();
            WelcomeLabel.Text = "Welcome to the applicaiton " + LoggedInUser + ".";

            TQuery();
            InitialFundLoad();
        }

        List<Transaction> Credit = new List<Transaction>();

        const string ConnectionString = "Server=tcp:uwad-cloudintegration-server.database.windows.net,1433;Initial Catalog=BudgetApp;Persist Security Info=False;User ID=Jeflick;Password=Bloodiertunic1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public string LoggedInUser = CurrentUser.ActiveUser;
        public int LoggedInUserId = CurrentUser.UserID;

        private void TQuery()
        {
            TransactionQuery db = new TransactionQuery();
            Credit = db.GetTransaction();


        }
        private void InsertQuery(string TempBudgetItem, string TempTransactionType, string TempCreditDebit)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            connection.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT into [Transaction_History] (User_Id, Budget_Item, Transaction_Type, Txn_Amount ) VALUES ('" + LoggedInUserId + "', '" + TempBudgetItem + "', '" + TempTransactionType + "',  '" + TempCreditDebit + "')";
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void CallChart()
        {
            Series Budget = BudgetChart.Series.Add("Pie");
            Budget.ChartType = SeriesChartType.Pie;
            Budget.IsValueShownAsLabel = true;

            Budget.Points.AddXY("0", "33");
            Budget.Points.AddXY("1", "33");
            Budget.Points.AddXY("2", "33");
            Budget.Points.AddXY("3", "33");
            Budget.Points.AddXY("4", "33");
            Budget.Points.AddXY("5", "33");

            Budget.Points[0].LegendText = "Income";
            Budget.Points[1].LegendText = "Housing";
            Budget.Points[2].LegendText = "Transportation";
            Budget.Points[3].LegendText = "Food";
            Budget.Points[4].LegendText = "LifeStyle";
            Budget.Points[5].LegendText = "Savings";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            OpenLogOutScreen();
        }

        private void OpenLogOutScreen()
        {
            this.Hide();
            var LogOutScreen = new LogOut();
            LogOutScreen.Closed += (s, args) => this.Close();
            LogOutScreen.Show();
        }

        private void MonthlyIncomeButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "Monthly Income";
            string TempTransactionType = "Credit";
            string TempCreditDebit = MonthlyIncomeTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                MonthlyIncomeListBox.Items.Clear();
                MonthlyIncomeListBox.Items.Add("A value must be entered.");
            }
            else
            {
                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                MonthlyIncomeListBox.Items.Clear();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "Monthly Income")
                    {
                        MonthlyIncomeListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void SavingsButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "Savings";
            string TempTransactionType = "Credit";
            string TempCreditDebit = SavingsTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                SavingsListBox.Items.Clear();
                SavingsListBox.Items.Add("A value must be entered.");
            }
            else
            {
                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                SavingsListBox.Items.Clear();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "Savings")
                    {
                        SavingsListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void LifeStyleButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "LifeStyle";
            string TempTransactionType = "Debit";
            string TempCreditDebit = LifeStyleTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                LifeStyleListBox.Items.Clear();
                LifeStyleListBox.Items.Add("A value must be entered.");
            }
            else
            {
                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                LifeStyleListBox.Items.Clear();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "LifeStyle")
                    {
                        LifeStyleListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void HousingButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "Housing";
            string TempTransactionType = "Debit";
            string TempCreditDebit = HousingTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                HousingListBox.Items.Clear();
                HousingListBox.Items.Add("A value must be entered.");
            }
            else
            {
                HousingListBox.Items.Clear();

                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "Housing")
                    {
                        HousingListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void TransportationButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "Transportation";
            string TempTransactionType = "Debit";
            string TempCreditDebit = TransportationTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                TransportationListBox.Items.Clear();
                TransportationListBox.Items.Add("A value must be entered.");
            }
            else
            {
                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "Transportation")
                    {
                        TransportationListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            string TempBudgetItem = "Food";
            string TempTransactionType = "Debit";
            string TempCreditDebit = FoodTextBox.Text;

            if (string.IsNullOrWhiteSpace(TempCreditDebit))
            {
                FoodListBox.Items.Clear();
                FoodListBox.Items.Add("A value must be entered.");
            }
            else
            {
                InsertQuery(TempBudgetItem, TempTransactionType, TempCreditDebit);
                TQuery();

                for (int i = 0; i < Credit.Count; i++)
                {
                    if (Credit[i].Budget_Item == "Food")
                    {
                        FoodListBox.Items.Add(Credit[i].Txn_Amount);
                    }
                }
                FundsRemainingCalc();
            }
        }

        private void FundsRemainingCalc()
        {

            int TempCreditTotal = 0;
            int TempDebitTotal = 0;
            int RemainingBalance = 0;

            for (int i = 0; i < Credit.Count; i++)
            {
                if (Credit[i].Transaction_Type == "Credit")
                {
                    int credit = Convert.ToInt32(Credit[i].Txn_Amount);
                    TempCreditTotal += credit;
                }
                else
                {
                    int debit = Convert.ToInt32(Credit[i].Txn_Amount);
                    TempDebitTotal += debit;
                }
            }
            RemainingBalance = TempCreditTotal - TempDebitTotal;
            label1.Text = "$" + RemainingBalance.ToString();
        }

        private void InitialFundLoad()
        {
            for (int i = 0; i < Credit.Count; i++)
            {
                if (Credit[i].Budget_Item == "Monthly Income")
                {
                    MonthlyIncomeListBox.Items.Add(Credit[i].Txn_Amount);
                }
                else if (Credit[i].Budget_Item == "Savings")
                {
                    SavingsListBox.Items.Add(Credit[i].Txn_Amount);
                }
                else if (Credit[i].Budget_Item == "LifeStyle")
                {
                    LifeStyleListBox.Items.Add(Credit[i].Txn_Amount);
                }
                else if (Credit[i].Budget_Item == "Housing")
                {
                    HousingListBox.Items.Add(Credit[i].Txn_Amount);
                }
                else if (Credit[i].Budget_Item == "Transportation")
                {
                    TransportationListBox.Items.Add(Credit[i].Txn_Amount);
                }
                else if (Credit[i].Budget_Item == "Food")
                {
                    FoodListBox.Items.Add(Credit[i].Txn_Amount);
                }
            }
            FundsRemainingCalc();
        }
    }
}
