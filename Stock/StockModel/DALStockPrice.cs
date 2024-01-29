using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class DALStockPrice : DALStock
    {
        #region 금융위원회 주식시세정보
        private string StockPriceInfo_CallbackUrl
        {
            get { return "https://apis.data.go.kr/1160100/service/GetStockSecuritiesInfoService/getStockPriceInfo"; }
        }
        private string PreemptiveRightCertificatePriceInfo_CallbackUrl
        {
            get { return "https://apis.data.go.kr/1160100/service/GetStockSecuritiesInfoService/getPreemptiveRightCertificatePriceInfo"; }
        }
        private string SecuritiesPriceInfo_CallbackUrl
        {
            get { return "https://apis.data.go.kr/1160100/service/GetStockSecuritiesInfoService/getSecuritiesPriceInfo"; }
        }
        private string PreemptiveRightSecuritiesPriceInfo_CallbackUrl
        {
            get { return "https://apis.data.go.kr/1160100/service/GetStockSecuritiesInfoService/getPreemptiveRightSecuritiesPriceInfo"; }
        }

        /// <summary>
        /// 1. getStockPriceInfo : 주식시세
        /// 2. getPreemptiveRightCertificatePriceInfo : 신주인수권증서시세
        /// 3. getSecuritiesPriceInfo : 수익증권시세
        /// 4. getPreemptiveRightSecuritiesPriceInfo : 신주인수권증권시세
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="numOfRows"></param>
        /// <param name="itmsNm"></param>
        /// <returns></returns>
        public override DataSet GetAllData(RequestMessageInfo messageInfo)
        {
            DataSet ds = new DataSet();            
            DataTable dt1 = this.GetStockPriceInfo(messageInfo);
            DataTable dt2 = this.GetPreemptiveRightCertificatePriceInfo(messageInfo);
            DataTable dt3 = this.GetSecuritiesPriceInfo(messageInfo);
            DataTable dt4 = this.GetPreemptiveRightSecuritiesPriceInfo(messageInfo);
            if (dt1 != null) ds.Tables.Add(dt1);
            if (dt2 != null) ds.Tables.Add(dt2);
            if (dt3 != null) ds.Tables.Add(dt3);
            if (dt4 != null) ds.Tables.Add(dt4);
            ds.DataSetName = "금융위원회_주식시세정보";
            return ds;
        }

        /// <summary>
        /// getStockPriceInfo : 주식시세
        /// </summary>
        /// <param name="messageInfo"></param>
        /// <returns></returns>
        public DataTable GetStockPriceInfo(RequestMessageInfo messageInfo)
        {           
            string url = SetURL(messageInfo, StockPriceInfo_CallbackUrl);
            return GetDataTableFromAPIResult(url, "item", "주식시세");
        }

        /// <summary>
        /// getPreemptiveRightCertificatePriceInfo : 신주인수권증서시세
        /// </summary>
        /// <param name="messageInfo"></param>
        /// <returns></returns>
        public DataTable GetPreemptiveRightCertificatePriceInfo(RequestMessageInfo messageInfo)
        {           
            string url = SetURL(messageInfo, PreemptiveRightCertificatePriceInfo_CallbackUrl);
            return GetDataTableFromAPIResult(url, "item", "신주인수권증서시세");
        }

        /// <summary>
        /// getSecuritiesPriceInfo : 수익증권시세
        /// </summary>
        /// <param name="messageInfo"></param>
        /// <returns></returns>
        public DataTable GetSecuritiesPriceInfo(RequestMessageInfo messageInfo)
        {         
            string url = SetURL(messageInfo, SecuritiesPriceInfo_CallbackUrl);
            return GetDataTableFromAPIResult(url, "item", "수익증권시세");
        }

        /// <summary>
        /// getPreemptiveRightSecuritiesPriceInfo : 신주인수권증권시세
        /// </summary>
        /// <param name="messageInfo"></param>
        /// <returns></returns>
        public DataTable GetPreemptiveRightSecuritiesPriceInfo(RequestMessageInfo messageInfo)
        {
            string url = SetURL(messageInfo, PreemptiveRightSecuritiesPriceInfo_CallbackUrl);
            return GetDataTableFromAPIResult(url, "item", "신주인수권증권시세");
        }
        #endregion

        internal string SetURL(RequestMessageInfo messageInfo, string url)
        {
            string completeURL = url; // URL
            completeURL += "?ServiceKey=" + ServiceKey; // Service Key
            completeURL += $"&pageNo={messageInfo.pageNo}";
            completeURL += $"&numOfRows={messageInfo.numOfRows}";
            completeURL += "&resultType=xml";
            if (messageInfo.itmsNm != null) completeURL += $"&itmsNm={messageInfo.itmsNm}";
            if (messageInfo.likeItmsNm != null) completeURL += $"&likeItmsNm={messageInfo.likeItmsNm}";
            if (messageInfo.endBasDt != null && messageInfo.likeSrtnCd == null)
            {
                if (messageInfo.beginBasDt != null) completeURL += $"&beginBasDt={messageInfo.beginBasDt}";
                if (messageInfo.endBasDt != null) completeURL += $"&endBasDt={messageInfo.endBasDt}";
            }
            else if(messageInfo.endBasDt == null && messageInfo.likeSrtnCd != null)
            {
                if (messageInfo.likeSrtnCd != null) completeURL += $"&likeSrtnCd={messageInfo.likeSrtnCd}";
            }
            else
            {
                if (messageInfo.basDt != null) completeURL += $"&basDt={messageInfo.basDt}";
            }

            if (messageInfo.isinCd != null) completeURL += $"&isinCd={messageInfo.isinCd}";
            if (messageInfo.likeIsinCd != null) completeURL += $"&likeIsinCd={messageInfo.likeIsinCd}";
            if (messageInfo.mrktCls != null) completeURL += $"&mrktCls={messageInfo.mrktCls}";
            if (messageInfo.beginVs != null) completeURL += $"&beginVs={messageInfo.beginVs}";
            if (messageInfo.endVs != null) completeURL += $"&endVs={messageInfo.endVs}";
            if (messageInfo.beginFltRt != null) completeURL += $"&beginFltRt={messageInfo.beginFltRt}";
            if (messageInfo.endFltRt != null) completeURL += $"&endFltRt={messageInfo.endFltRt}";
            if (messageInfo.beginTrqu != null) completeURL += $"&beginTrqu={messageInfo.beginTrqu}";
            if (messageInfo.endTrqu != null) completeURL += $"&endTrqu={messageInfo.endTrqu}";
            if (messageInfo.beginTrPrc != null) completeURL += $"&beginTrPrc={messageInfo.beginTrPrc}";
            if (messageInfo.endTrPrc != null) completeURL += $"&endTrPrc={messageInfo.endTrPrc}";
            if (messageInfo.beginLstgStCnt != null) completeURL += $"&beginLstgStCnt={messageInfo.beginLstgStCnt}";
            if (messageInfo.endLstgStCnt != null) completeURL += $"&endLstgStCnt={messageInfo.endLstgStCnt}";
            if (messageInfo.beginMrktTotAmt != null) completeURL += $"&beginMrktTotAmt={messageInfo.beginMrktTotAmt}";
            if (messageInfo.endMrktTotAmt != null) completeURL += $"&endMrktTotAmt={messageInfo.endMrktTotAmt}";
            return completeURL;
        }
    }
}
