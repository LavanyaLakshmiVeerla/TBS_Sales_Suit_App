using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class SalesItemsView
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public int AvailableCount { get; set; }
        public int QuantitySelected { get; set; }
        public double TotalCost { get; set; }
    }
}
