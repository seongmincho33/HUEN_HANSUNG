using StockModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace StockController
{
    public class KoreanStockController
    {
        private IkoreanStockView View { get; set; }
        
        private DALStock StockPrice { get; set; }

        private DALStock StockIssueInfo { get; set; }

        private DALStock StockDividend { get; set; }

        private DALStock StockFinalStat { get; set; }

        public KoreanStockController(IkoreanStockView view)
        {
            this.View = view;
            view.SetController(this);
            this.StockPrice = new DALStockPrice();
            this.StockIssueInfo = new DALStockIssueInfo();
            this.StockDividend = new DALStockDividend();
            this.StockFinalStat = new DALStockFinalStatInfo();
        }

        public void LoadView()
        {
            this.View.ClearView();            
        }

        /// <summary>
        /// View에 존재하는 TreeList에 모든 데이터셋을 노드로 붙여준다.
        /// </summary>
        /// <param name="pageNo">페이지 번호 (필수)</param>
        /// <param name="numOfRows">한 페이지 결과 수(필수)</param>
        /// <param name="basDt">작업 또는 거래의 기준이 되는 일자(년월일)</param>
        /// <param name="crno">법인등록번호</param>
        /// <param name="stckIssuCmpyNm">주식발행사의 명칭</param>
        public void Search(RequestMessageInfo messageInfo)
        {            
            List<DataSet> dsList = new List<DataSet>();
            if (this.View.IsStockPrice) dsList.Add(this.StockPrice.GetAllData(messageInfo));
            if (this.View.IsStockIssueInfo) dsList.Add(this.StockIssueInfo.GetAllData(messageInfo));
            if (this.View.IsStockDividend) dsList.Add(this.StockDividend.GetAllData(messageInfo));
            if (this.View.IsStockFinalStat) dsList.Add(this.StockFinalStat.GetAllData(messageInfo));
            this.View.SetDataSetsToTreeList(dsList);
        }       

        public void ShowStockColumnNameHelp()
        {

        }
    }
}
