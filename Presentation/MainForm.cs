using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TBS_Sales_Suit_App.BusinessLogic;
using TBS_Sales_Suit_App.DataAccess;

namespace TBS_Sales_Suit_App.Presentation
{
    public partial class MainForm : Form
    {
        TBSDbContext tbsDbContext;
        TBSRepository tbsRepository;
        List<Book> books;
        List<Book> booksPurchased = new List<Book>();
        List<SalesItemsView> saleItemsView = new List<SalesItemsView>();
        Dictionary<Book, int> bookQuantityMap;
        Customer currentCustomer = null;
        User loggedInUser = null;

        public MainForm()
        {
            InitializeComponent();
            tbsDbContext = new TBSDbContext();
            tbsRepository = new TBSRepository(tbsDbContext);


            this.cbxInputFormat.SelectedIndex = 0;
            this.txtBxSalesDiscPercent.Text = "0";
            this.txtBxSalesMemFees.Text = "0";
            LoadBooks();
            books = this.tbsRepository.GetBooks();
            bookQuantityMap = new Dictionary<Book, int>();
        }

        public MainForm(User user)
        {
            InitializeComponent();
            tbsDbContext = new TBSDbContext();
            tbsRepository = new TBSRepository(tbsDbContext);

            if (user != null)
            {
                loggedInUser = user;
            }

            this.cbxInputFormat.SelectedIndex = 0;
            this.txtBxSalesDiscPercent.Text = "0";
            this.txtBxSalesMemFees.Text = "0";
            LoadBooks();
            books = this.tbsRepository.GetBooks();
            bookQuantityMap = new Dictionary<Book, int>();
        }

        private void LoadBooks()
        {
            List<Book> books = this.tbsRepository.GetBooks();

            foreach(Book book in books)
            {
                this.cbxBxSalesBooks.Items.Add(book);
                this.cbxBxSalesBooks.DisplayMember = "Name";
                this.cbxBxSalesBooks.SelectedIndex = 0;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(cbxInputFormat.SelectedItem != null)
            {
                switch(cbxInputFormat.SelectedItem.ToString())
                {
                    case "EXCEL":
                        {
                            try
                            {
                                IHelper excelHelper = new ExcelHelper(tbsRepository);
                                string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, "TwinkleBookStoreExcelData.xlsx");
                                excelHelper.ImportData(filePath);
                                MessageBox.Show("Excel Data imported successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Excel Data imported failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "CSV":
                        {
                            try
                            {
                                IHelper csvHelper = new CSVHelper(tbsRepository);
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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomeScreen welcomeScreen = new WelcomeScreen();
            welcomeScreen.FormClosed += (s, args) => this.Close();
            welcomeScreen.Show();
        }

        private void GetCustomerInfo_Click(object sender, EventArgs e)
        {
            Customer customer = this.tbsRepository.SearchCustomer(txtBxCName.Text, txtBxContact.Text);
            if(customer != null)
            {
                this.txtBxCName.Text = string.Empty;
                this.txtBxContact.Text = string.Empty;
                this.lblMessage.Text = string.Empty;

                this.txtBxNameInfo.Text = customer.Name;
                this.txtBxContactInfo.Text = customer.ContactNumber;
                this.txtBxDOBInfo.Text = customer.DateOfBirth.ToShortDateString();
                this.txtBxAddrInfo.Text = customer.Address;
                if (customer.MemberSince != null)
                {
                    this.txtBxMemsinceInfo.Text = customer.MemberSince.Value.ToShortDateString();
                }
                if (customer.ValidityExpiryDate != null)
                {
                    this.txtBxValidityInfo.Text = customer.ValidityExpiryDate.Value.ToShortDateString();
                }
            }
            else
            {
                lblMessage.Text = "No records found";
                lblMessage.ForeColor = Color.Red;                
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            try
            {              
                customer.Name = txtBxNameAdd.Text;
                customer.ContactNumber = txtBxContactAdd.Text;
                customer.Address = txtBxAddrAdd.Text;

                DateTime dob;
                if (DateTime.TryParse(txtBxDOBAdd.Text, out dob))
                {
                    customer.DateOfBirth = dob;
                }

                DateTime memSince;
                if (DateTime.TryParse(txtBxMemSinceAdd.Text, out memSince))
                {
                    customer.MemberSince = memSince;
                }

                //if (!string.IsNullOrEmpty(txtBxFeePaidAdd.Text))
                //{
                //    customer.MembershipFeesPaid = Convert.ToDouble(txtBxFeePaidInfo.Text);
                //}

                DateTime validity;
                if (DateTime.TryParse(txtBxValidityAdd.Text, out validity))
                {
                    customer.ValidityExpiryDate = validity;
                }

                List<Customer> customersList = new List<Customer>();
                customersList.Add(customer);

                this.tbsRepository.AddCustomers(customersList);

                MessageBox.Show("New Customer, \"" + customer.Name + "\" added successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to add Customer, \"" + customer.Name + "\"", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtBxNameInfo.Text;
            customer.ContactNumber = txtBxContactInfo.Text;
            customer.Address = txtBxAddrInfo.Text;

            DateTime dob;
            if(DateTime.TryParse(txtBxDOBInfo.Text, out dob))
            {
                customer.DateOfBirth = dob;
            }

            DateTime memSince;
            if (DateTime.TryParse(txtBxMemsinceInfo.Text, out memSince))
            {
                customer.MemberSince = memSince;
            }

            //if (!string.IsNullOrEmpty(txtBxFeePaidInfo.Text))
            //{
            //    customer.MembershipFeesPaid = Convert.ToDouble(txtBxFeePaidInfo.Text);
            //}

            DateTime validity;
            if (DateTime.TryParse(txtBxValidityInfo.Text, out validity))
            {
                customer.ValidityExpiryDate = validity;
            }           

            this.tbsRepository.UpdateCustomerInfo(customer);
        }

        private void btnSalesAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxSalesQuantity.Text))
            {
                MessageBox.Show("Enter book quantity number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Book currentBook = (Book)(from book in books where (book == (Book)this.cbxBxSalesBooks.SelectedItem)
                                          select book).FirstOrDefault();

                if (currentBook != null)
                {
                    booksPurchased.Add(currentBook);
                    bookQuantityMap.Add(currentBook, Convert.ToInt32(txtBxSalesQuantity.Text));

                    SalesItemsView itemsView = new SalesItemsView();
                    itemsView.Name = currentBook.Name;
                    itemsView.Author = currentBook.Author;
                    itemsView.Genre = currentBook.Genre;
                    itemsView.Price = currentBook.Price;
                    itemsView.AvailableCount = currentBook.AvailableCount;
                    itemsView.QuantitySelected = Convert.ToInt32(txtBxSalesQuantity.Text);
                    itemsView.TotalCost = itemsView.Price * itemsView.QuantitySelected;
                    saleItemsView.Add(itemsView);

                    this.dgvSalesBooks.DataSource = null;
                    this.dgvSalesBooks.DataSource = saleItemsView;
                }
            }
        }

        private void btnSalesGetCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxSaleCName.Text))
            {
                Customer customer = this.tbsRepository.SearchCustomer(txtBxSaleCName.Text, null);
                if (customer == null)
                {
                    customer = this.tbsRepository.SearchCustomer(null, txtBxSaleCName.Text);
                }

                if (customer != null)
                {
                    this.txtBxSalesCNameDisplay.Text = customer.Name;
                    currentCustomer = customer;
                }
            }
            else
            {
                MessageBox.Show("Enter Customer Name or Contact to add sales", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double GetDiscountPercentValue(Customer customer, double totalUnbilledAmount)
        {
            double discountPercent = 0;
            bool isExistingCustomer = false;
            int totalNoOfPurchases = 0;
            double totalAmtSoFar = 0.0;
            DateTime memberSince;
            DateTime membershipValidUntil;

            List<SalesRecord> currentSalesRecords = this.tbsRepository.GetSalesRecords();
            foreach(SalesRecord record in currentSalesRecords)
            {
                if(record.Customer.Name.Equals(customer.Name) &&
                    record.Customer.ContactNumber.Equals(customer.ContactNumber))
                {
                    isExistingCustomer = true;
                    totalNoOfPurchases++;
                    totalAmtSoFar += record.TotalCostAfterDiscount;                    
                }
            }

            if(customer.MemberSince != null && customer.ValidityExpiryDate != null)
            {
                memberSince = customer.MemberSince.Value;
                membershipValidUntil = customer.ValidityExpiryDate.Value;
                DateTime today = DateTime.Now;

                int noOfYears = today.Year - memberSince.Year;
                if(noOfYears >= 5)
                {
                    discountPercent = 0.2;
                    return discountPercent;
                }
            }             

            if(isExistingCustomer)
            {
                DateTime today = DateTime.Now;
                int birthdayMonth = customer.DateOfBirth.Month;
                int currentMonth = today.Month;
                if(currentMonth == birthdayMonth)
                {
                    discountPercent = 0.2;
                    return discountPercent;
                }

                if(totalAmtSoFar > 6000)
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
            return discountPercent;
        }

        private void btnSalesPrepareBill_Click(object sender, EventArgs e)
        {
            try
            {
                SalesRecord newRecord = new SalesRecord();
                List<SaleItemDetails> itemDetailsList = new List<SaleItemDetails>();
                newRecord.Customer = currentCustomer;
                newRecord.DateOfPurchase = DateTime.Now;
                double newMembershipDiscount = 0;

                SaleItemDetails newItem;
                foreach(Book book in booksPurchased)
                {
                    newItem = new SaleItemDetails();
                    newItem.SalesRecord = newRecord;
                    newItem.Book = book;
                    newItem.Quantity = bookQuantityMap[book];
                    newItem.TotalCost = book.Price * newItem.Quantity;
                    this.tbsRepository.UpdateBookAvailabilityCount(book, newItem.Quantity);
                    itemDetailsList.Add(newItem);

                    newRecord.NoOfItemsPurchased += newItem.Quantity;
                    newRecord.TotalCostBeforeDiscount += newItem.TotalCost;                    
                }

                double calculatedDiscountPercent = GetDiscountPercentValue(newRecord.Customer, newRecord.TotalCostBeforeDiscount);     
                if (!string.IsNullOrEmpty(txtBxSalesMemFees.Text))
                {
                    newRecord.MembershipFeesPaid = Convert.ToDouble(txtBxSalesMemFees.Text);
                    if(newRecord.MembershipFeesPaid > 0)
                    {
                        newMembershipDiscount = this.tbsRepository.UpdateCustomerMembershipInfo(newRecord.Customer);
                    }                    
                }
                else
                {
                    newRecord.MembershipFeesPaid = 0;
                }

                double finalDiscountPercent = 0;
                double overrideDiscountPercent = 0;
                if (!string.IsNullOrEmpty(this.txtBxSalesDiscPercent.Text))
                {                    
                    bool flag = Double.TryParse(this.txtBxSalesDiscPercent.Text, out overrideDiscountPercent);
                    if(flag)
                    {
                        finalDiscountPercent = (overrideDiscountPercent / 100);
                    }
                }
                if(overrideDiscountPercent == 0)
                {
                    finalDiscountPercent = newMembershipDiscount + calculatedDiscountPercent;                    
                }
                newRecord.DiscountPercent = finalDiscountPercent;
                this.txtBxSalesDiscPercent.Text = newRecord.DiscountPercent.ToString();

                newRecord.TotalCostAfterDiscount = newRecord.TotalCostBeforeDiscount - (newRecord.TotalCostBeforeDiscount * newRecord.DiscountPercent.Value);
                newRecord.FinalBillAmount = newRecord.TotalCostAfterDiscount + newRecord.MembershipFeesPaid.Value;
                               
                this.tbsRepository.AddPurchaseHistory(itemDetailsList);
                
                this.txtBxSalesNoIP.Text = newRecord.NoOfItemsPurchased.ToString();
                this.txtBxSalesTotalCost.Text = newRecord.TotalCostBeforeDiscount.ToString();
                this.txtBxSalesDiscPercent.Text = newRecord.DiscountPercent.ToString();
                this.txtBxSalesAfterDisc.Text = newRecord.TotalCostAfterDiscount.ToString();
                this.txtBxSalesMemFees.Text = newRecord.MembershipFeesPaid.ToString();
                this.txtBxSalesFinalBill.Text = newRecord.FinalBillAmount.ToString();

                MessageBox.Show("New sale record created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add new sale record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtBxSaleCName.Text = string.Empty;
            this.txtBxSalesQuantity.Text = string.Empty;
            this.txtBxSalesCNameDisplay.Text = string.Empty;
            this.dgvSalesBooks.DataSource = null;

            this.txtBxSalesNoIP.Text = string.Empty;
            this.txtBxSalesTotalCost.Text = string.Empty;
            this.txtBxSalesDiscPercent.Text = string.Empty;
            this.txtBxSalesAfterDisc.Text = string.Empty;
            this.txtBxSalesMemFees.Text = string.Empty;
            this.txtBxSalesFinalBill.Text = string.Empty;
            this.booksPurchased.Clear();
            this.bookQuantityMap.Clear();
            this.saleItemsView.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(loggedInUser.Role.Equals(StaffType.Manager))
            {
                this.txtBxSalesDiscPercent.ReadOnly = false;
                TabPage tabModifyRecords = new TabPage("Modify Records");
                tabModifyRecords.ForeColor = Color.Black;
                this.tabMenu.TabPages.Add(tabModifyRecords);
            }
            else
            {
                this.txtBxSalesDiscPercent.ReadOnly = true;
            }
        }
    }
}
