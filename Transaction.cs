using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Transaction
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Budget_Item { get; set; }
        public string Transaction_Type { get; set; }
        public string Txn_Amount { get; set; }
    }
}
