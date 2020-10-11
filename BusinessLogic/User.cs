using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class User
    { 
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public StaffType Role { get; set; }
    }
    public enum StaffType
    {
        Manager,
        Salesman
    }
}
