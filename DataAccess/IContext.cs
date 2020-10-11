using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TBS_Sales_Suit_App.BusinessLogic;

namespace TBS_Sales_Suit_App.DataAccess
{
    public interface IContext
    {
         DbSet<Customer> Customers { get; set; }
         DbSet<User> Users { get; set; }
         DbSet<Book> Books { get; set; }
         DbSet<SalesRecord> SalesRecords { get; set; }
         DbSet<SaleItemDetails> SaleItemsDetails { get; set; }
    }
}
