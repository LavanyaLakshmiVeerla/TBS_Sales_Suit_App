using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBS_Sales_Suit_App.BusinessLogic;

namespace TBS_Sales_Suit_App.DataAccess
{
    public class TBSDbContext : DbContext //, IContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<SaleItemDetails> SaleItemsDetails { get; set; }

    }
}
