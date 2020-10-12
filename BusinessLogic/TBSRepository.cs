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
    /// <summary>
    /// Class that contains logical methods to fetch data from data access layer classes
    /// </summary>
    public class TBSRepository
    {
        private TBSDbContext _tbsDbContext;
        private int _currentCustomerID = 0;
        private double newMembershipDisc = 0;

        /// <summary>
        /// Constructor with IContext interface object injected
        /// </summary>
        /// <param name="tbsDbContext"></param>
        public TBSRepository(IContext tbsDbContext)
        {
            this._tbsDbContext = (TBSDbContext)tbsDbContext;
        }
        
        /// <summary>
        /// MEthod to add Customers into the database
        /// </summary>
        /// <param name="customersList"></param>
        public void AddCustomers(List<Customer> customersList)
        {
            try
            {
                foreach (Customer customer in customersList)
                {
                    this._tbsDbContext.Customers.Add(customer);
                }
                this._tbsDbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to Add Customers into the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  MEthod to add Books into the database
        /// </summary>
        /// <param name="booksList"></param>
        public void AddBooks(List<Book> booksList)
        {
            try
            {
                foreach (Book book in booksList)
                {
                    this._tbsDbContext.Books.Add(book);
                    this._tbsDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add Books into the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  MEthod to add Purchase record into the database
        /// </summary>
        /// <param name="saleItemDetails"></param>
        public void AddPurchaseHistory(List<SaleItemDetails> saleItemDetails)
        {
            try
            {
                foreach (SaleItemDetails saleItemDetail in saleItemDetails)
                {
                    this._tbsDbContext.SaleItemsDetails.Add(saleItemDetail);
                    this._tbsDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add purchase history into the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  MEthod to add Users into the database
        /// </summary>
        public void AddUsers()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add users into the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  MEthod to get Customers from the database
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            return _tbsDbContext.Customers.ToList();
        }

        /// <summary>
        ///  MEthod to get Users into the database
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return this._tbsDbContext.Users.ToList();
        }

        /// <summary>
        ///  MEthod to get Books from the database
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            return this._tbsDbContext.Books.ToList();
        }

        /// <summary>
        ///  MEthod to get purchase history from the database
        /// </summary>
        /// <returns></returns>
        public List<SalesRecord> GetSalesRecords()
        {
            return this._tbsDbContext.SalesRecords.ToList();
        }

        /// <summary>
        ///  MEthod to calculate discount percent for a given customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="totalUnbilledAmount"></param>
        /// <returns></returns>
        public double GetDiscountPercentValue(Customer customer, double totalUnbilledAmount)
        {
            double discountPercent = 0;
            bool isExistingCustomer = false;
            int totalNoOfPurchases = 0;
            double totalAmtSoFar = 0.0;
            DateTime memberSince;
            DateTime membershipValidUntil;

            try
            {
                List<SalesRecord> currentSalesRecords = GetSalesRecords();
                foreach (SalesRecord record in currentSalesRecords)
                {
                    if (record.Customer.Name.Equals(customer.Name) &&
                        record.Customer.ContactNumber.Equals(customer.ContactNumber))
                    {
                        isExistingCustomer = true;
                        totalNoOfPurchases++;
                        totalAmtSoFar += record.TotalCostAfterDiscount;
                    }
                }

                if (customer.MemberSince != null && customer.ValidityExpiryDate != null)
                {
                    memberSince = customer.MemberSince.Value;
                    membershipValidUntil = customer.ValidityExpiryDate.Value;
                    DateTime today = DateTime.Now;

                    int noOfYears = today.Year - memberSince.Year;
                    if (noOfYears >= 5)
                    {
                        discountPercent = 0.2;
                        return discountPercent;
                    }
                }

                if (isExistingCustomer)
                {
                    DateTime today = DateTime.Now;
                    int birthdayMonth = customer.DateOfBirth.Month;
                    int currentMonth = today.Month;
                    if (currentMonth == birthdayMonth)
                    {
                        discountPercent = 0.2;
                        return discountPercent;
                    }

                    if (totalAmtSoFar > 6000)
                    {
                        discountPercent = 0.05;
                        return discountPercent;
                    }

                    if (totalNoOfPurchases > 5)
                    {
                        discountPercent = 0.03;
                        return discountPercent;
                    }
                }
                else
                {
                    if (totalUnbilledAmount > 5000)
                    {
                        discountPercent = 0.03;
                        return discountPercent;
                    }
                    else
                    {
                        discountPercent = 0.02;
                        return discountPercent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to calculate discount percent using the database records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return discountPercent;
        }

        /// <summary>
        ///  MEthod to import data from different Input file types
        /// </summary>
        /// <param name="inputFileType"></param>
        public void ImportData(string inputFileType)
        {
            switch (inputFileType)
            {
                case "EXCEL":
                    {
                        try
                        {
                            IHelper excelHelper = new ExcelHelper(this);
                            string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, "TwinkleBookStoreExcelData.xlsx");
                            excelHelper.ImportData(filePath);
                            MessageBox.Show("Excel Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Excel Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "CSV":
                    {
                        try
                        {
                            IHelper csvHelper = new CSVHelper(this);
                            string customersFile = System.IO.Path.Combine(Environment.CurrentDirectory, "TwinkleBookStore_CustomersCsv.csv");
                            string booksFile = System.IO.Path.Combine(Environment.CurrentDirectory, "TwinkleBookStore_BooksCsv.csv");
                            string purHistoryFile = System.IO.Path.Combine(Environment.CurrentDirectory, "TwinkleBookStore_PurchasehistoryCsv.csv");
                            csvHelper.ImportData(customersFile);
                            csvHelper.ImportData(booksFile);
                            csvHelper.ImportData(purHistoryFile);
                            MessageBox.Show("CSV Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("CSV Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "XML":
                    {
                        try
                        {
                            MessageBox.Show("To be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //IHelper xmlHelper = new XMLHelper(tbsRepository);
                            //xmlHelper.ImportData(@"C:\1_Lavanya\Workspace\ABBAsignment\Files\TwinkleBookStoreRecord1.xml");
                            //MessageBox.Show("XML Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("XML Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "JSON":
                    {
                        try
                        {
                            MessageBox.Show("To be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //IHelper jsonHelper = new JSONHelper(tbsRepository);
                            //jsonHelper.ImportData(@"C:\1_Lavanya\Workspace\ABBAsignment\Files\TwinkleBookStoreRecord1.json");

                            //MessageBox.Show("JSON Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("JSON Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "TEXT":
                    {
                        try
                        {
                            MessageBox.Show("To be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //IHelper textHelper = new TextHelper(tbsRepository);
                            //textHelper.ImportData(@"C:\1_Lavanya\Workspace\ABBAsignment\Files\TwinkleBookStoreRecord.txt");
                            //MessageBox.Show("Text Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Text Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        ///  MEthod to validate user login
        /// </summary>
        /// <param name="loggedInUser"></param>
        /// <returns></returns>
        public User ValidateUser(User loggedInUser)
        {
            List<User> userList = GetUsers();
            try
            {
                foreach (User user in userList)
                {
                    if (user.UserName.Equals(loggedInUser.UserName) &&
                        user.Password.Equals(loggedInUser.Password))
                    {
                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to validate user login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        ///  MEthod to search Customers in the database
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="customerContactNumber"></param>
        /// <returns></returns>
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
            }
            catch(Exception ex)
            {                
                MessageBox.Show("Failed to search customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            return customer;
        }

        /// <summary>
        ///  MEthod to update Customers into the database
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomerInfo(Customer customer)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update customer info into the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  MEthod to update Customers membership into the database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public double UpdateCustomerMembershipInfo(Customer customer)
        {
            this.newMembershipDisc = 0;
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to customer membership info into the database records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return newMembershipDisc;
        }

        /// <summary>
        ///  MEthod to update a book's available count into the database
        /// </summary>
        /// <param name="book"></param>
        /// <param name="quantitySold"></param>
        public void UpdateBookAvailabilityCount(Book book, int quantitySold)
        {
            try
            {
                var result = this._tbsDbContext.Books.SingleOrDefault(bk => bk.ID == book.ID);
                if (result != null)
                {
                    result.AvailableCount = result.AvailableCount - quantitySold;

                    this._tbsDbContext.Entry(result).State = EntityState.Modified;
                    this._tbsDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to books availability count into the database records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     }
}
