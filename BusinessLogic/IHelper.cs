using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBS_Sales_Suit_App.BusinessLogic
{
    /// <summary>
    /// Interface to import data from any input file format
    /// </summary>
    public interface IHelper
    {
        void ImportData(string filePath);
    }

}
