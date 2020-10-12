using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// This class has properties and methods for importing sub classes
    /// </summary>
    public abstract class ImportHelper : IHelper
    {
        protected List<Customer> customers = new List<Customer>();
        protected List<Book> books = new List<Book>();
        protected List<SalesRecord> salesRecord = new List<SalesRecord>();
        protected List<SaleItemDetails> saleItemDetails = new List<SaleItemDetails>();
        protected List<User> users = new List<User>();

        public abstract void ImportData(string filePath);

    }

}
