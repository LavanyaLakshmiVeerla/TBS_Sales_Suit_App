using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class CSVHelper : ImportHelper
    {
        TBSRepository _tbsRepository;
        string _filePath = string.Empty;
        public CSVHelper(TBSRepository tbsRepository)
        {
            this._tbsRepository = tbsRepository;
        }

        public override void ImportData(string filePath)
        {
            this._filePath = filePath;
            string tableName = string.Empty;

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    var dataLine = reader.ReadLine();                    
                    
                    if (dataLine.ToUpper().Contains("CONTACT NUMBER"))
                    {
                        tableName = "Customers";
                    }
                    else if (dataLine.ToUpper().Contains("AUTHOR"))
                    {
                        tableName = "Books";    
                    }
                    else
                    {
                        tableName = "PurchaseHistory";
                    }
                    break;
                }
            }

            switch(tableName)
            {
                case "Customers":
                    ImportCustomers();
                    break;
                case "Books":
                    ImportBooks();
                    break;
                case "PurchaseHistory":
                    ImportPurchaseHistory();
                    break;
                default:
                    break;
            }

        }

        public void ImportCustomers()
        {
            Customer customerCsv;
            bool headerFlag = false;

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    customerCsv = new Customer();
                    var dataLine = reader.ReadLine();

                    if (!headerFlag)
                    {
                        headerFlag = true;
                        continue;
                    }

                    List<string> dataValue = dataLine.Split(',').ToList();

                    for (int ind = 0; ind < dataValue.Count; ind++)
                    {
                        if (!string.IsNullOrEmpty(dataValue[ind]))
                        {
                            switch (ind)
                            {
                                case 0:
                                    //customer.ID = Convert.ToInt32(dataValue[ind]);
                                    break;
                                case 1:
                                    customerCsv.Name = Convert.ToString(dataValue[ind]);
                                    break;
                                case 2:
                                    customerCsv.Address = Convert.ToString(dataValue[ind]);
                                    break;
                                case 3:
                                    customerCsv.ContactNumber = Convert.ToString(dataValue[ind]);
                                    break;
                                case 4:
                                    DateTime dob;
                                    if (DateTime.TryParse(dataValue[ind].ToString(), out dob))
                                    {
                                        customerCsv.DateOfBirth = dob;
                                    }
                                    break;
                                case 5:
                                    DateTime memSince;
                                    if (DateTime.TryParse(dataValue[ind].ToString(), out memSince))
                                    {
                                        customerCsv.MemberSince = memSince;
                                    }
                                    break;
                                case 6:
                                    DateTime validity;
                                    if (DateTime.TryParse(dataValue[ind].ToString(), out validity))
                                    {
                                        customerCsv.ValidityExpiryDate = validity;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    this.customers.Add(customerCsv);
                }
            }
            this._tbsRepository.AddCustomers(this.customers);
        }

        public void ImportBooks()
        {

            Book bookCsv;
            bool headerFlag = false;

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    bookCsv = new Book();
                    var dataLine = reader.ReadLine();

                    if (!headerFlag)
                    {
                        headerFlag = true;
                        continue;
                    }

                    List<string> dataValue = dataLine.Split(',').ToList();

                    for (int ind = 0; ind < dataValue.Count; ind++)
                    {
                        if (!string.IsNullOrEmpty(dataValue[ind]))
                        {
                            switch (ind)
                            {
                                case 0:
                                    //bookCsv.ID = Convert.ToInt32(dataValue[ind]);
                                    break;
                                case 1:
                                    bookCsv.Name = Convert.ToString(dataValue[ind]);
                                    break;
                                case 2:
                                    bookCsv.Author = Convert.ToString(dataValue[ind]);
                                    break;
                                case 3:
                                    bookCsv.Genre = Convert.ToString(dataValue[ind]);
                                    break;
                                case 4:
                                    bookCsv.Price = Convert.ToDouble(dataValue[ind]);
                                    break;
                                case 5:
                                    bookCsv.AvailableCount = Convert.ToInt32(dataValue[ind]);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    this.books.Add(bookCsv);
                }
            }
            this._tbsRepository.AddBooks(this.books);
        }

        public void ImportPurchaseHistory()
        {
            SaleItemDetails salesItemDetailsCsv;
            bool headerFlag = false;

            using (var reader = new StreamReader(_filePath))
            {
                while (!reader.EndOfStream)
                {
                    salesItemDetailsCsv = new SaleItemDetails();
                    var dataLine = reader.ReadLine();

                    if (!headerFlag)
                    {
                        headerFlag = true;
                        continue;
                    }

                    List<string> dataValue = dataLine.Split(',').ToList();

                    for (int ind = 0; ind < dataValue.Count; ind++)
                    {
                        if (!string.IsNullOrEmpty(dataValue[ind]))
                        {
                            object valuedata = dataValue[ind];
                            object dopData = dataValue[1];

                            switch (ind)
                            {
                                case 2:
                                    DateTime dateOfPurchase1;
                                    bool dopFlag1 = DateTime.TryParse(dopData.ToString(), out dateOfPurchase1);
                                    if (!Convert.ToString(valuedata).Equals(string.Empty) && dopFlag1)
                                    {
                                        salesItemDetailsCsv.SalesRecord = this.salesRecord.FirstOrDefault(rec =>
                                                                                                            ((rec.Customer.Name == Convert.ToString(valuedata))
                                                                                                            && rec.DateOfPurchase == dateOfPurchase1));
                                        if (salesItemDetailsCsv.SalesRecord == null)
                                        {
                                            salesItemDetailsCsv.SalesRecord = new SalesRecord();
                                            salesItemDetailsCsv.SalesRecord.Customer = this.customers.FirstOrDefault(cust => cust.Name == Convert.ToString(valuedata));
                                            salesItemDetailsCsv.SalesRecord.DateOfPurchase = dateOfPurchase1;
                                            this.salesRecord.Add(salesItemDetailsCsv.SalesRecord);
                                        }
                                    }
                                    break;
                                case 3:
                                    DateTime dateOfPurchase2;
                                    bool dopFlag2 = DateTime.TryParse(dopData.ToString(), out dateOfPurchase2);
                                    if (!Convert.ToString(valuedata).Equals(string.Empty) && dopFlag2)
                                    {
                                        salesItemDetailsCsv.SalesRecord = this.salesRecord.FirstOrDefault(rec =>
                                                                                                            ((rec.Customer.ContactNumber == Convert.ToString(valuedata))
                                                                                                            && rec.DateOfPurchase == dateOfPurchase2));
                                        if (salesItemDetailsCsv.SalesRecord == null)
                                        {
                                            salesItemDetailsCsv.SalesRecord = new SalesRecord();
                                            salesItemDetailsCsv.SalesRecord.Customer = this.customers.FirstOrDefault(cust => cust.ContactNumber == Convert.ToString(valuedata));
                                            salesItemDetailsCsv.SalesRecord.DateOfPurchase = dateOfPurchase2;
                                            this.salesRecord.Add(salesItemDetailsCsv.SalesRecord);
                                        }
                                    }
                                    break;
                                case 4:
                                    salesItemDetailsCsv.Book = books.FirstOrDefault(bk => bk.Name == Convert.ToString(valuedata));
                                    break;
                                case 5:
                                    salesItemDetailsCsv.Quantity = Convert.ToInt32(valuedata);
                                    salesItemDetailsCsv.SalesRecord.NoOfItemsPurchased += salesItemDetailsCsv.Quantity;
                                    break;
                                case 6:
                                    salesItemDetailsCsv.TotalCost = Convert.ToDouble(valuedata);
                                    salesItemDetailsCsv.SalesRecord.TotalCostBeforeDiscount += salesItemDetailsCsv.TotalCost;
                                    break;
                                case 7:
                                    Double feePaid;
                                    if (Double.TryParse(valuedata.ToString(), out feePaid))
                                    {
                                        salesItemDetailsCsv.SalesRecord.MembershipFeesPaid = feePaid;
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    salesItemDetailsCsv.SalesRecord.TotalCostAfterDiscount = salesItemDetailsCsv.SalesRecord.TotalCostBeforeDiscount -
                                                                                        (salesItemDetailsCsv.SalesRecord.TotalCostBeforeDiscount * salesItemDetailsCsv.SalesRecord.DiscountPercent ?? 0);
                    this.saleItemDetails.Add(salesItemDetailsCsv);
                }
            }
            this._tbsRepository.AddPurchaseHistory(this.saleItemDetails);
        }
    }
}
