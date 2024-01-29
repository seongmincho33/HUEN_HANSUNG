using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace StockController
{
    public interface IkoreanStockView
    {        
        void SetController(KoreanStockController controller);

        void ClearView();

        void SetDataSetsToTreeList(List<DataSet> dsList);

        bool IsStockPrice { get; set; }

        bool IsStockIssueInfo { get; set; }

        bool IsStockDividend { get; set; }

        bool IsStockFinalStat { get; set; }
    }
}
