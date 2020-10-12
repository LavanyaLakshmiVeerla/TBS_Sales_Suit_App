using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// Class to declare properties of a every item/book in the purchase record
    /// </summary>
    public class SaleItemDetails
    {
        public int ID { get; set; }     
        public int Quantity { get; set; }
        public double TotalCost { get; set; }
        public Book Book { get; set; }
        public SalesRecord SalesRecord { get; set; }        
    }
}
