using FinanceManagementSystem.BuisnessLayer.Repository;
using FinanceManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.BuisnessLayer.Service
{
    public class FinanceService : IFinanceService
    {
        IFinanceRepository _financeRepository;
        public FinanceService(FinanceRepository financeRepository)
        {
            _financeRepository = financeRepository;
        }
        public bool createExpense(Expense expense)
        {
           _financeRepository.createExpense(expense);
            return true;
        }

        public bool createUser(User user)
        {
            _financeRepository.createUser(user);
            return true;
        }

        public bool deleteExpense(int expenseId)
        {
            _financeRepository.deleteExpense(expenseId);
            return true;
        }

        public bool deleteUser(User user)
        {
            _financeRepository.deleteUser(user);
            return true;
        }

        public List<Expense> getAllExpenses(int userId)
        {
            _financeRepository.getAllExpenses(userId);
            return new List<Expense>();
        }

        public bool updateExpense(int userId, Expense expense)
        {
            _financeRepository.updateExpense(userId, expense);
            return true;
        }

        public void displayUser()
        {
            _financeRepository.displayUser();
        }
    }
}
