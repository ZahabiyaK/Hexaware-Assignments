using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.Entity
{
    public class Expense
    {
        public int expense_id;
        public decimal amount;
        public DateTime date;
        public string description;
        public int user_id;
        public int category_id;
    }
}
