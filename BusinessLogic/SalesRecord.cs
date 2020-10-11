using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int NoOfItemsPurchased { get; set; }
        public double TotalCostBeforeDiscount { get; set; }
        public double? DiscountPercent { get; set; }
        public double TotalCostAfterDiscount { get; set; }        
        public double? MembershipFeesPaid { get; set; }
        public double FinalBillAmount { get; set; }
        public Customer Customer { get; set; }

    }
}
