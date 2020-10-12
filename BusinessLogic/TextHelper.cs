using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// class to import data from text input file
    /// </summary>
    public class TextHelper : ImportHelper
    {
        TBSRepository _tbsRepository;
        public TextHelper(TBSRepository tbsRepository)
        {
            this._tbsRepository = tbsRepository;
        }

        public override void ImportData(string filePath)
        {

        }
    }
}
