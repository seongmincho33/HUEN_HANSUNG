using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class DALStockDividend : DALStock
    {
        #region 주식배당정보조회서비스
        private string DiviInfo_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetStocDiviInfoService/getDiviInfo"; }
        }

        /// <summary>
        /// 1. getDiviInfo : 배당정보 조회
        /// </summary>
        /// <param name="pageNo">페이지 번호 (필수)</param>
        /// <param name="numOfRows">한 페이지 결과 수(필수)</param>
        /// <param name="basDt">작업 또는 거래의 기준이 되는 일자(년월일)</param>
        /// <param name="crno">법인등록번호</param>
        /// <param name="stckIssuCmpyNm">주식발행사의 명칭</param>
        /// <returns></returns>
        public override DataSet GetAllData(RequestMessageInfo messageInfo)
        {
            DataSet ds = new DataSet();
            DataTable dt1 = this.GetDiviInfo(messageInfo);
            if (dt1 != null) ds.Tables.Add(dt1);
            ds.DataSetName = "금융위원회_주식배당정보";
            return ds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNo">페이지 번호 (필수)</param>
        /// <param name="numOfRows">한 페이지 결과 수(필수)</param>
        /// <param name="basDt">작업 또는 거래의 기준이 되는 일자(년월일)</param>
        /// <param name="crno">법인등록번호</param>
        /// <param name="stckIssuCmpyNm">주식발행사의 명칭</param>
        /// <returns></returns>
        public DataTable GetDiviInfo(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, DiviInfo_CallbackUrl), "item", "배당정보 조회");
        }
        #endregion

        internal string SetURL(RequestMessageInfo messageInfo, string url)
        {
            string completeURL = url; // URL
            completeURL += "?ServiceKey=" + ServiceKey; // Service Key
            completeURL += $"&pageNo={messageInfo.pageNo}";
            completeURL += $"&numOfRows={messageInfo.numOfRows}";
            completeURL += "&resultType=xml";
            if (messageInfo.basDt != null) completeURL += $"&basDt={messageInfo.basDt}";
            if (messageInfo.crno != null) completeURL += $"&crno={messageInfo.crno}";
            if (messageInfo.stckIssuCmpyNm != null) completeURL += $"&stckIssuCmpyNm={messageInfo.stckIssuCmpyNm}";
            return completeURL;
        }
    }
}
