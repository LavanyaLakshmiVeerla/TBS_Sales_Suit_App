using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
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
            
        }

    }
}

