using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem.BuisnessLayer.Exception
{
    public class ExpenseNotFoundException
    {
        //declare private field of type string
        string message;

        //define parameterized constructor
        public ExpenseNotFoundException(string msg)
        {
            message = msg;
        }

        //define read only property to read message
        public string Message1 { get => message; }
    }
}
