using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManagementSystem.Entity;
using FinanceManagementSystem.BuisnessLayer.Repository;
using FinanceManagementSystem.BuisnessLayer.Service;
using FinanceManagementSystem.BuisnessLayer.Exception;
using FinanceManagementSystem.DatabaseLayer;

namespace FinanceManagementSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinanceRepository financeRepository = new FinanceRepository();
            FinanceService financeService = new FinanceService(financeRepository);

            User user = new User();

            Console.WriteLine("Enter your choice you want to perform:\n Choose option from here:\n1.Add User\n2.Delete User\n3.Add Expense\n4.Delete Expense\n5.Update Expense\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter user details: username, password, email\n");

                    //user.user_id = Convert.ToInt32(Console.ReadLine());
                    string username = Console.ReadLine();
                    string password = Console.ReadLine();
                    string email = Console.ReadLine();

                    financeService.createUser(new User()
                    {
                        UserName = username,
                        Password = password,
                        Email = email
                    });

                    Console.WriteLine("\nDisplay User details:");
                    financeService.displayUser();
                    
                    break;

                case 2:
                    int id = Convert.ToInt32(Console.ReadLine());
                    financeService.deleteUser(new User() { User_Id = id });
                    break;

                case 3:
                    Console.WriteLine("Add Expense");
                    break;

                case 4:
                    Console.WriteLine("Delete Expense");
                    break;

                case 5:
                    Console.WriteLine("Update Expense");
                    break;
            }

            Console.ReadKey();
        }
    }
}
