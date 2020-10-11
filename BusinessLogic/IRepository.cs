using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public interface IRepository
    {
        List<User> GetUsers();
        List<Customer> GetCustomers();
        List<Book> GetBooks();
    }
}
