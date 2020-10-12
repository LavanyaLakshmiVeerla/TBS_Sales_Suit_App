using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// Interface to get data from database
    /// </summary>
    public interface IRepository
    {
        List<User> GetUsers();

        List<Customer> GetCustomers();

        List<Book> GetBooks();

        void AddCustomers(List<Customer> customersList);

        void AddBooks(List<Book> booksList);

        void AddPurchaseHistory(List<SaleItemDetails> saleItemDetails);

        void AddUsers();

        List<SalesRecord> GetSalesRecords();

        double GetDiscountPercentValue(Customer customer, double totalUnbilledAmount);

        void ImportData(string inputFileType);

        User ValidateUser(User loggedInUser);

        Customer SearchCustomer(string customerName, string customerContactNumber);

        void UpdateCustomerInfo(Customer customer);

        double UpdateCustomerMembershipInfo(Customer customer);

        void UpdateBookAvailabilityCount(Book book, int quantitySold);
    }
}
