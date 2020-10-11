using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBS_Sales_Suit_App.DataAccess;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class TBSRepository
    {
        private TBSDbContext _tbsDbContext;
        private int _currentCustomerID = 0;
        private double newMembershipDisc = 0;
        public TBSRepository(TBSDbContext tbsDbContext)
        {
            this._tbsDbContext = tbsDbContext;
        }
        

        public void AddCustomers(List<Customer> customersList)
        {            
            foreach (Customer customer in customersList)
            {
                this._tbsDbContext.Customers.Add(customer);                
            }
            //this._tbsDbContext.Entry(Customer).State = EntityState.Modified;
            this._tbsDbContext.SaveChanges();
        }

        public void AddBooks(List<Book> booksList)
        {
            foreach(Book book in booksList)
            {
                this._tbsDbContext.Books.Add(book);
                this._tbsDbContext.SaveChanges();
            }
        }

        public void AddPurchaseHistory(List<SaleItemDetails> saleItemDetails)
        {
            foreach (SaleItemDetails saleItemDetail in saleItemDetails)
            {
                this._tbsDbContext.SaleItemsDetails.Add(saleItemDetail);
                this._tbsDbContext.SaveChanges();
            }
        }

        public void AddUsers()
        {
            List<User> usersList = new List<User>();
            User user1 = new User() { ID = 1, UserName = "John", Password = "12345678", Role = StaffType.Manager };
            User user2 = new User() { ID = 2, UserName = "Mike", Password = "87654321", Role = StaffType.Salesman };
            usersList.Add(user1);
            usersList.Add(user2);
            
            foreach (User user in usersList)
            {
                this._tbsDbContext.Users.Add(user);
                this._tbsDbContext.SaveChanges();
            }
        }

        public List<Customer> GetCustomers()
        {
            return _tbsDbContext.Customers.ToList();
        }

        public List<User> GetUsers()
        {
            return this._tbsDbContext.Users.ToList();
        }

        public List<Book> GetBooks()
        {
            return this._tbsDbContext.Books.ToList();
        }

        public List<SalesRecord> GetSalesRecords()
        {
            return this._tbsDbContext.SalesRecords.ToList();
        }

        public User ValidateUser(User loggedInUser)
        {
            List<User> userList = GetUsers();
            foreach(User user in userList)
            {
                if(user.UserName.Equals(loggedInUser.UserName) &&
                    user.Password.Equals(loggedInUser.Password))
                {
                    return user;
                }
            }
            return null;
        }

        public Customer SearchCustomer(string customerName, string customerContactNumber)
        {
            Customer customer = null;
            try
            {
                if (!string.IsNullOrEmpty(customerName) && !string.IsNullOrEmpty(customerContactNumber))
                {
                    customer = this.GetCustomers().FirstOrDefault(cust => cust.Name.Equals(customerName) &&
                                                                        cust.ContactNumber.Equals(customerContactNumber));
                }
                else if ((string.IsNullOrEmpty(customerName) && !string.IsNullOrEmpty(customerContactNumber)))
                {
                    customer = this.GetCustomers().FirstOrDefault(cust => cust.ContactNumber.Equals(customerContactNumber));
                }
                else if (!string.IsNullOrEmpty(customerName) && string.IsNullOrEmpty(customerContactNumber))
                {
                    customer = this.GetCustomers().FirstOrDefault(cust => cust.Name.Equals(customerName));
                }
                else
                {
                    MessageBox.Show("Enter Customer Name and/or Contact Number to search for details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (customer != null)
                {
                    this._currentCustomerID = customer.ID;
                }
                return customer;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            var result = this._tbsDbContext.Customers.SingleOrDefault(cust => cust.ID == this._currentCustomerID);
            if (result != null)
            {
                result.Name = customer.Name;
                result.ContactNumber = customer.ContactNumber;
                result.Address = customer.Address;
                result.DateOfBirth = customer.DateOfBirth;
                result.MemberSince = customer.MemberSince;
                result.ValidityExpiryDate = customer.ValidityExpiryDate;

                this._tbsDbContext.Entry(result).State = EntityState.Modified;
                this._tbsDbContext.SaveChanges();
            }
        }

        public double UpdateCustomerMembershipInfo(Customer customer)
        {
            this.newMembershipDisc = 0;
            var result = this._tbsDbContext.Customers.SingleOrDefault(cust => cust.ID == customer.ID);
            if (result != null)
            {
                TimeSpan timeSpan = new TimeSpan(364, 0, 0, 0);
                if (result.MemberSince != null && result.ValidityExpiryDate != null)
                {
                    result.ValidityExpiryDate += timeSpan;
                }
                else
                {
                    result.MemberSince = DateTime.Now;                    
                    result.ValidityExpiryDate = DateTime.Now + timeSpan;
                    this.newMembershipDisc = 0.05;
                }                

                this._tbsDbContext.Entry(result).State = EntityState.Modified;
                this._tbsDbContext.SaveChanges();
            }
            return newMembershipDisc;
        }

        public void UpdateBookAvailabilityCount(Book book, int quantitySold)
        {
            var result = this._tbsDbContext.Books.SingleOrDefault(bk => bk.ID == book.ID);
            if (result != null)
            {
                result.AvailableCount = result.AvailableCount - quantitySold;

                this._tbsDbContext.Entry(result).State = EntityState.Modified;
                this._tbsDbContext.SaveChanges();
            }
        }
     }
}
