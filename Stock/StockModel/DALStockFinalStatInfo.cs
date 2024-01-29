using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class DALStockFinalStatInfo : DALStock
    {
        #region 재무정보조회서비스
        private string SummFinaStat_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetFinaStatInfoService/getSummFinaStat"; }
        }

        private string Bs_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetFinaStatInfoService/getBs"; }
        }

        private string IncoStat_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetFinaStatInfoService/getIncoStat"; }
        }

        public override DataSet GetAllData(RequestMessageInfo messageInfo)
        {
            DataSet ds = new DataSet();
            DataTable dt1 = this.GetSummFinaStat(messageInfo);
            DataTable dt2 = this.GetBs(messageInfo);
            DataTable dt3 = this.GetIncoStat(messageInfo);

            if (dt1 != null) ds.Tables.Add(dt1);
            if (dt2 != null) ds.Tables.Add(dt2);
            if (dt3 != null) ds.Tables.Add(dt3);            
            ds.DataSetName = "금융위원회_기업재무정보";
            return ds;
        }

        private DataTable GetSummFinaStat(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, SummFinaStat_CallbackUrl), "item", "요약재무제표조회");
        }

        private DataTable GetBs(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, Bs_CallbackUrl), "item", "재무상태표조회");            
        }

        private DataTable GetIncoStat(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, IncoStat_CallbackUrl), "item", "손익계산서조회");            
        }
        #endregion

        internal string SetURL(RequestMessageInfo messageInfo, string url)
        {
            string completeURL = url; // URL
            completeURL += "?ServiceKey=" + ServiceKey; // Service Key
            completeURL += $"&pageNo={messageInfo.pageNo}";
            completeURL += $"&numOfRows={messageInfo.numOfRows}";
            completeURL += "&resultType=xml";            
            if (messageInfo.crno != null) completeURL += $"&crno={messageInfo.crno}";
            if (messageInfo.bizYear != null) completeURL += $"&bizYear={messageInfo.bizYear}";
            return completeURL;
        }
    }
}
