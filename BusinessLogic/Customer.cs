using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// This class declares all the properties of a Customer type
    /// </summary>
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? MemberSince { get; set; }        
        public DateTime? ValidityExpiryDate { get; set; }
    }

    
}
