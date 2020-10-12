using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TBS_Sales_Suit_App.BusinessLogic;
using TBS_Sales_Suit_App.DataAccess;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    class GenerateReport
    {
        TBSRepository _tBSRepository;

        public GenerateReport(IContext tbsDbContext)
        {
            _tBSRepository = new TBSRepository(tbsDbContext);
        }

        public void GeneratePDFReport()
        {
            try
            {
                string validityCustStr = "List of customers qualified for discount >= 20% as on date today";
                string upcomingBDCustStr = "Customers having upcoming birthdays.";
                string annualBillingCustStr = "Customer with annual billing above 10K";
                string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
                string filePath = appRootDir + @"\Twinkle_Book_Store_Report.pdf";

                List<Customer> customersList = this._tBSRepository.GetCustomers();
                List<Customer> validityCustList = Customers20PerDiscountValidity(customersList);
                List<Customer> birthdayCustList = CustomerWithUpcomingBirthdays(customersList);
                List<Customer> annualBillCustList = CustomerWithAnnualBillingCriteria(customersList);            
                
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                
                using (Document doc = new Document(PageSize.A4, 10, 10, 10, 10))
                
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    doc.Open();

                    Paragraph paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 22f, BaseColor.BLUE);
                    paragraph.Add("Twinkle Book Store Report");
                    doc.Add(paragraph);


                    paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 15f, BaseColor.BLUE);
                    paragraph.Add(validityCustStr);
                    doc.Add(paragraph);

                    if (validityCustList.Count == 0)
                    {
                        doc.Add(new Paragraph("No Records found"));
                    }
                    else
                    {
                        foreach (Customer customer in validityCustList)
                        {
                            doc.Add(new Paragraph(customer.Name));
                        }
                    }

                    paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 15f, BaseColor.BLUE);
                    paragraph.Add(upcomingBDCustStr);
                    doc.Add(paragraph);

                    if (birthdayCustList.Count == 0)
                    {
                        doc.Add(new Paragraph("No Records found"));
                    }
                    else
                    {
                        foreach (Customer customer in birthdayCustList)
                        {
                            doc.Add(new Paragraph(customer.Name));
                        }
                    }
                    

                    paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 15f, BaseColor.BLUE);
                    paragraph.Add(annualBillingCustStr);
                    doc.Add(paragraph);

                    if (annualBillCustList.Count == 0)
                    {
                        doc.Add(new Paragraph("No Records found"));
                    }
                    else
                    {
                        foreach (Customer customer in annualBillCustList)
                        {
                            doc.Add(new Paragraph(customer.Name));
                        }
                    }                    
                    doc.Close();
                    MessageBox.Show("PDF Report generated successfully. Report available at path:" + filePath);
                }
            }
            catch (DocumentException de)
            {
                MessageBox.Show("Failed to generate Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Failed to generate Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        public List<Customer> Customers20PerDiscountValidity(List<Customer> getCustomersList)
        { 
            bool isExistingCustomer = false;
            DateTime memberSince;
            DateTime membershipValidUntil;
            List<Customer> custoumerList = new List<Customer>();

            foreach (Customer customer in getCustomersList)
            {
                List<SalesRecord> currentSalesRecords = this._tBSRepository.GetSalesRecords();
                foreach (SalesRecord record in currentSalesRecords)
                {
                    if (record.Customer.Name.Equals(customer.Name) &&
                        record.Customer.ContactNumber.Equals(customer.ContactNumber))
                    {
                        isExistingCustomer = true;
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
                        custoumerList.Add(customer);
                    }
                }

                if (isExistingCustomer)
                {
                    DateTime today = DateTime.Now;
                    int birthdayMonth = customer.DateOfBirth.Month;
                    int currentMonth = today.Month;
                    if (currentMonth == birthdayMonth)
                    {
                        custoumerList.Add(customer);
                    }
                }
            }
            return custoumerList;
        }

        public List<Customer> CustomerWithUpcomingBirthdays(List<Customer> getCustomersList)
        {
            bool isExistingCustomer = false;
            List<Customer> custoumerList = new List<Customer>();

            foreach (Customer customer in getCustomersList)
            {
                List<SalesRecord> currentSalesRecords = this._tBSRepository.GetSalesRecords();
                foreach (SalesRecord record in currentSalesRecords)
                {
                    if (record.Customer.Name.Equals(customer.Name) &&
                        record.Customer.ContactNumber.Equals(customer.ContactNumber))
                    {
                        isExistingCustomer = true;
                    }
                }                

                if (isExistingCustomer)
                {
                    DateTime today = DateTime.Now;
                    int birthdayMonth = customer.DateOfBirth.Month;
                    int currentMonth = today.Month;
                    if (currentMonth == birthdayMonth && customer.DateOfBirth > today)
                    {
                        custoumerList.Add(customer);
                    }
                }
            }
            return custoumerList;
        }

        public List<Customer> CustomerWithAnnualBillingCriteria(List<Customer> getCustomersList)
        {
            List<Customer> custoumerList = new List<Customer>();     
            double totalAmtSoFar = 0.0;
            DateTime today = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(365, 0, 0, 0);
            DateTime yearBackDay = today.Subtract(timeSpan);

            foreach (Customer customer in getCustomersList)
            {
                List<SalesRecord> currentSalesRecords = this._tBSRepository.GetSalesRecords();
                foreach (SalesRecord record in currentSalesRecords)
                {
                    if (record.Customer.Name.Equals(customer.Name) &&
                        record.Customer.ContactNumber.Equals(customer.ContactNumber))
                    {
                        if (record.DateOfPurchase > yearBackDay && record.DateOfPurchase < today)
                        {
                            totalAmtSoFar += record.TotalCostAfterDiscount;
                        }
                    }
                }

                if(totalAmtSoFar > 10000)
                {
                    custoumerList.Add(customer);
                }
            }
            return custoumerList;
        }
    }
}

