using FinanceManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.BuisnessLayer.Repository
{
    internal interface IFinanceRepository
    {
        bool createUser(User user);
        bool createExpense(Expense expense);
        bool deleteUser(User user);
        bool deleteExpense(int expenseId);
        List<Expense> getAllExpenses(User user);
        bool updateExpense(User user, Expense expense);
        void displayUser();
    }
}
