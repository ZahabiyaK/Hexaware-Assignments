using FinanceManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.BuisnessLayer.Repository
{
    public class FinanceRepository : IFinanceRepository
    {
        public bool createExpense(Expense expense)
        {
            //open connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //Query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Expenses values('" + expense.amount + "', '" + expense.date + "','" + expense.description + "', '" + expense.user_id + "', '" + expense.category_id + "')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            //DisplayStudentInfo();

            //close connection
            conn.Close();
            return true;
        }

        public bool createUser(User user)
        {
            //open connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //Query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Users values('" + user.UserName + "','"+user.Password+"','"+user.Email+"')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            //close connection
            conn.Close();

            return true;
        }

        public bool deleteExpense(int expenseId)
        {

            //open the connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete From Expenses where expense_id='" + expenseId + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            //close the connection
            conn.Close();

            return true;
        }

        public bool deleteUser(User user)
        {

            //open the connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete From Users where user_id='" + user.User_Id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            //close the connection
            conn.Close();

            return true;
        }

        public List<Expense> getAllExpenses(User user)
        {
            //open connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //guery
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Expenses where user_id = '" + user.User_Id + "'";
            cmd.Connection= conn;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader["expense_id"] + "\t" + sqlDataReader[1]+ "\t" + sqlDataReader[2] + "\t" + sqlDataReader[3] + "\t" + sqlDataReader[4] + "\t" + sqlDataReader[5]);
            }
            sqlDataReader.Close();
            //close connection
            conn.Close();

            return new List<Expense>();
        }

        public bool updateExpense(User user, Expense expense)
        {
            //open connection
            var conn = DBUtil.getDbConnection();
            conn.Open();
            //Query
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update Expenses set amount='" + expense.amount + "', date='" + expense.date + "', description='" + expense.description + "', user_id='" + user.User_Id + "', category_id = '"+expense.category_id+"' where expense_id = '" + expense.expense_id + "'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            //close connection
            conn.Close();

            return true;
        }

        public void displayUser() {
            var conn = DBUtil.getDbConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Users";
            cmd.Connection= conn;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader["user_id"] + "\t" + sqlDataReader[1] + "\t" + sqlDataReader[2] + "\t" + sqlDataReader[3]);
            }
            sqlDataReader.Close();

            conn.Close();
        }

    }
}
