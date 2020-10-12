using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// class to implement import feature using JSON input file
    /// </summary>
    public class JSONHelper : ImportHelper
    {
        TBSRepository _tbsRepository;
        public JSONHelper(TBSRepository tbsRepository)
        {
            this._tbsRepository = tbsRepository;
        }

        public override void ImportData(string filePath)
        {

        }
    }
}
