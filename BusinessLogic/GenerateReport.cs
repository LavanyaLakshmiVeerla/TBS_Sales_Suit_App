using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    class GenerateReport
    {
        public GenerateReport()
        {

        }

        public void GeneratePDFReport()
        {
            string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            try
            {
                // Step 1: Creating System.IO.FileStream object
                using (FileStream fs = new FileStream(appRootDir + "/PDFs/" + "Report1.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                // Step 2: Creating iTextSharp.text.Document object
                using (Document doc = new Document(PageSize.A4, 10, 10, 10, 10))
                // Step 3: Creating iTextSharp.text.pdf.PdfWriter object
                // It helps to write the Document to the Specified FileStream
                using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                {
                    // Step 4: Openning the Document
                    doc.Open();

                    //doc.AddTitle("Hello World example");
                    //doc.AddSubject("This is an Example 4 of Chapter 1 of Book 'iText in Action'");
                    //doc.AddKeywords("Metadata, iTextSharp 5.4.4, Chapter 1, Tutorial");
                    //doc.AddCreator("iTextSharp 5.4.4");
                    //doc.AddAuthor("Debopam Pal");
                    //doc.AddHeader("TBSHeader", "Twinkle Book Store");

                    // Step 5: Adding a paragraph
                    // NOTE: When we want to insert text, then we've to do it through creating paragraph
                    doc.Add(new Paragraph("Criteria 1"));
                    //Chunk chunk = new Chunk("This is from chunk. ");
                    //doc.Add(chunk);

                    //Phrase phrase = new Phrase("This is from Phrase.");
                    //doc.Add(phrase);

                    string key1 = "Key1";
                    string value1 = "value1";
                    string criteriaStr = key1 + " - " + value1;
                    string text = " Criteria 1";
                    Paragraph paragraph = new Paragraph();
                    paragraph.SpacingBefore = 10;
                    paragraph.SpacingAfter = 10;
                    paragraph.Alignment = Element.ALIGN_LEFT;
                    paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 25f, BaseColor.BLUE);
                    paragraph.Add(text);
                    doc.Add(paragraph);

                    doc.Add(new Paragraph("Criteria 2"));
                    string key2 = "Key2";
                    string value2 = "value2";
                    string criteriaStr2 = key2 + " - " + value2;
                    doc.Add(new Paragraph(criteriaStr2));

                    doc.Add(new Paragraph("Criteria 3"));
                    string key3 = "Key3";
                    string value3 = "value3";
                    string criteriaStr3 = key3 + " - " + value3;
                    doc.Add(new Paragraph(criteriaStr3));
                    // Step 6: Closing the Document
                    doc.Close();
                }
            }
            // Catching iTextSharp.text.DocumentException if any
            catch (DocumentException de)
            {
                throw de;
            }
            // Catching System.IO.IOException if any
            catch (IOException ioe)
            {
                throw ioe;
            }
        }

    }
}

