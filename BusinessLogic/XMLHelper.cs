﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// Class to implement Import feature from XML input data
    /// </summary>
    public class XMLHelper : ImportHelper
    {
        TBSRepository _tbsRepository;
        public XMLHelper(TBSRepository tbsRepository)
        {
            this._tbsRepository = tbsRepository;
        }

        public override void ImportData(string filePath)
        {

        }
    }
}
