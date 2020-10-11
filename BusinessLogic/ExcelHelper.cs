using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.Entity.Core.Metadata.Edm;
using TBS_Sales_Suit_App.BusinessLogic;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    public class ExcelHelper : ImportHelper
    {
        TBSRepository _tbsRepository;
        public ExcelHelper(TBSRepository tbsRepository)
        {
            this._tbsRepository = tbsRepository;
        }

        public override void ImportData(string filePath)
        {            
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel.Sheets xlWorksheets = xlWorkbook.Sheets;
            Excel.Range xlRange = null;

            try
            {
                Customer customerXL;
                Book bookXL;
                SaleItemDetails salesItemDetailsXL;

                foreach (Excel.Worksheet workSheet in xlWorksheets)
                {
                    xlRange = workSheet.UsedRange;

                    int rowCount = xlRange.Rows.Count;
                    int colCount = xlRange.Columns.Count;

                    switch(workSheet.Name)
                    {
                        case "Customers":
                            {
                                for (int i = 2; i <= rowCount; i++)
                                {
                                    customerXL = new Customer();
                                    for (int j = 1; j <= colCount; j++)
                                    {
                                        if (((Excel.Range)xlRange.Cells[i, j]) != null && ((Excel.Range)xlRange.Cells[i, j]).Value != null)
                                        {
                                            object valuedata = ((Excel.Range)xlRange.Cells[i, j]).Value;

                                            switch (j)
                                            {
                                                case 1:
                                                    //customer.ID = Convert.ToInt32(valuedata);
                                                    break;
                                                case 2:
                                                    customerXL.Name = Convert.ToString(valuedata);
                                                    break;
                                                case 3:
                                                    customerXL.Address = Convert.ToString(valuedata);
                                                    break;
                                                case 4:
                                                    customerXL.ContactNumber = Convert.ToString(valuedata);
                                                    break;
                                                case 5:
                                                    DateTime dob;
                                                    if(DateTime.TryParse(valuedata.ToString(), out dob))
                                                    {
                                                        customerXL.DateOfBirth = dob;
                                                    }
                                                    break;
                                                case 6:
                                                    DateTime memSince;
                                                    if (DateTime.TryParse(valuedata.ToString(), out memSince))
                                                    {
                                                        customerXL.MemberSince = memSince;
                                                    }
                                                    break;                                                
                                                case 7:
                                                    DateTime validity;
                                                    if (DateTime.TryParse(valuedata.ToString(), out validity))
                                                    {
                                                        customerXL.ValidityExpiryDate = validity;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }

                                        }
                                    }
                                    this.customers.Add(customerXL);
                                }
                            }
                            break;
                        case "Books":
                            {
                                for (int i = 2; i <= rowCount; i++)
                                {
                                    bookXL = new Book();
                                    for (int j = 1; j <= colCount; j++)
                                    {
                                        if (((Excel.Range)xlRange.Cells[i, j]) != null && ((Excel.Range)xlRange.Cells[i, j]).Value != null)
                                        {
                                            object valuedata = ((Excel.Range)xlRange.Cells[i, j]).Value;

                                            switch (j)
                                            {
                                                case 1:
                                                    //book.ID = Convert.ToInt32(valuedata);
                                                    break;
                                                case 2:
                                                    bookXL.Name = Convert.ToString(valuedata);
                                                    break;
                                                case 3:
                                                    bookXL.Author = Convert.ToString(valuedata);
                                                    break;
                                                case 4:
                                                    bookXL.Genre = Convert.ToString(valuedata);
                                                    break;
                                                case 5:
                                                    bookXL.Price = Convert.ToDouble(valuedata);
                                                    break;
                                                case 6:
                                                    bookXL.AvailableCount = Convert.ToInt32(valuedata);
                                                    break;
                                                default:
                                                    break;
                                            }

                                        }
                                    }
                                    this.books.Add(bookXL);
                                }
                            }
                            break;
                        case "PurchaseHistory":
                            {
                                int saleItemsIDCounter = 1;

                                for (int i = 2; i <= rowCount; i++)
                                {
                                    salesItemDetailsXL = new SaleItemDetails();
                                    salesItemDetailsXL.ID = saleItemsIDCounter++;                                    

                                    for (int j = 2; j <= colCount; j++)
                                    {
                                        if (((Excel.Range)xlRange.Cells[i, j]) != null && ((Excel.Range)xlRange.Cells[i, j]).Value != null)
                                        {
                                            object valuedata = ((Excel.Range)xlRange.Cells[i, j]).Value;
                                            object dopData = ((Excel.Range)xlRange.Cells[i, 2]).Value;


                                            switch (j)
                                            {
                                                case 2:
                                                    break;
                                                case 3:
                                                    DateTime dateOfPurchase1;
                                                    bool dopFlag1 = DateTime.TryParse(dopData.ToString(), out dateOfPurchase1);
                                                    if (!Convert.ToString(valuedata).Equals(string.Empty) && dopFlag1)
                                                    {                              
                                                        salesItemDetailsXL.SalesRecord = this.salesRecord.FirstOrDefault(rec =>
                                                                                                                            ((rec.Customer.Name == Convert.ToString(valuedata))
                                                                                                                            && rec.DateOfPurchase == dateOfPurchase1));
                                                        if (salesItemDetailsXL.SalesRecord == null)
                                                        {
                                                            salesItemDetailsXL.SalesRecord = new SalesRecord();
                                                            salesItemDetailsXL.SalesRecord.Customer = this.customers.FirstOrDefault(cust => cust.Name == Convert.ToString(valuedata));
                                                            salesItemDetailsXL.SalesRecord.DateOfPurchase = dateOfPurchase1;
                                                            this.salesRecord.Add(salesItemDetailsXL.SalesRecord);
                                                        }                                                        
                                                    }
                                                    break;
                                                case 4:
                                                    DateTime dateOfPurchase2;
                                                    bool dopFlag2 = DateTime.TryParse(dopData.ToString(), out dateOfPurchase2);
                                                    if (!Convert.ToString(valuedata).Equals(string.Empty) && dopFlag2)
                                                    {
                                                        salesItemDetailsXL.SalesRecord = this.salesRecord.FirstOrDefault(rec =>
                                                                                                                            ((rec.Customer.ContactNumber == Convert.ToString(valuedata))
                                                                                                                            && rec.DateOfPurchase == dateOfPurchase2));
                                                        if (salesItemDetailsXL.SalesRecord == null)
                                                        {
                                                            salesItemDetailsXL.SalesRecord = new SalesRecord();
                                                            salesItemDetailsXL.SalesRecord.Customer = this.customers.FirstOrDefault(cust => cust.ContactNumber == Convert.ToString(valuedata));
                                                            salesItemDetailsXL.SalesRecord.DateOfPurchase = dateOfPurchase2;
                                                            this.salesRecord.Add(salesItemDetailsXL.SalesRecord);
                                                        }
                                                    }
                                                    break;
                                                case 5:
                                                    salesItemDetailsXL.Book = books.FirstOrDefault(bk => bk.Name == Convert.ToString(valuedata));
                                                    break;
                                                case 6:
                                                    salesItemDetailsXL.Quantity = Convert.ToInt32(valuedata);
                                                    salesItemDetailsXL.SalesRecord.NoOfItemsPurchased += salesItemDetailsXL.Quantity;
                                                    break;
                                                case 7:
                                                    salesItemDetailsXL.TotalCost = Convert.ToDouble(valuedata);
                                                    salesItemDetailsXL.SalesRecord.TotalCostBeforeDiscount += salesItemDetailsXL.TotalCost;
                                                    break;
                                                case 8:
                                                    Double feePaid;
                                                    if (Double.TryParse(valuedata.ToString(), out feePaid))
                                                    {
                                                        salesItemDetailsXL.SalesRecord.MembershipFeesPaid = feePaid;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                            
                                        }
                                        
                                    }
                                    salesItemDetailsXL.SalesRecord.TotalCostAfterDiscount = salesItemDetailsXL.SalesRecord.TotalCostBeforeDiscount - 
                                                                                                    (salesItemDetailsXL.SalesRecord.TotalCostBeforeDiscount * salesItemDetailsXL.SalesRecord.DiscountPercent??0 );
                                    this.saleItemDetails.Add(salesItemDetailsXL);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }

                this._tbsRepository.AddCustomers(this.customers);
                this._tbsRepository.AddBooks(this.books);
                this._tbsRepository.AddPurchaseHistory(this.saleItemDetails);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //rule of thumb for releasing com objects:
                //  never use two dots, all COM objects must be referenced and released individually
                //  ex: [somthing].[something].[something] is bad

                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheets);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
        }
    }
}
