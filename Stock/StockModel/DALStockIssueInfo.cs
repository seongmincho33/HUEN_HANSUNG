using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StockModel
{
    public class DALStockIssueInfo : DALStock
    {
        #region 주식발행정보조회서비스
        private string ItemBasiInfo_CallbackUrl
        { 
            get { return "http://apis.data.go.kr/1160100/service/GetStocIssuInfoService/getItemBasiInfo"; } 
        }

        private string IssuInfo_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetStocIssuInfoService/getStocIssuInfo"; }
        }

        private string LockUpRetuInfo_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetStocIssuInfoService/getLockUpRetuInfo"; }
        }

        private string StocIssuStat_CallbackUrl
        {
            get { return "http://apis.data.go.kr/1160100/service/GetStocIssuInfoService/getStocIssuStat";  }
        }

        /// <summary>
        ///  1	주식발행정보조회서비스	getItemBasiInfo	    종목기본정보조회
        ///  2	주식발행정보조회서비스    getStocIssuInfo     주식발행내역조회
        ///  3	주식발행정보조회서비스    getLockUpRetuInfo   의무보호예수반환정보조회
        ///  4	주식발행정보조회서비스    getStocIssuStat     주식발행현황조회
        /// </summary>        
        /// <param name="pageNo">페이지 번호 (필수)</param>
        /// <param name="numOfRows">한 페이지 결과 수(필수)</param>
        /// <param name="basDt">작업 또는 거래의 기준이 되는 일자(년월일)</param>
        /// <param name="crno">법인등록번호</param>
        /// <param name="stckIssuCmpyNm">주식발행사의 명칭</param>
        /// int pageNo, int numOfRows, int? basDt = null, int? crno = null, string stckIssuCmpyNm = null
        public override DataSet GetAllData(RequestMessageInfo messageInfo)
        {
            DataSet ds = new DataSet();
            DataTable dt1 = this.GetItemBasiInfo(messageInfo);
            DataTable dt2 = this.GetStocIssuInfo(messageInfo);
            DataTable dt3 = this.GetLockUpRetuInfo(messageInfo);
            DataTable dt4 = this.GetStocIssuStat(messageInfo);
            if(dt1 != null) ds.Tables.Add(dt1);
            if(dt2 != null) ds.Tables.Add(dt2);
            if(dt3 != null) ds.Tables.Add(dt3);
            if(dt4 != null) ds.Tables.Add(dt4);
            ds.DataSetName = "금융위원회_주식발행정보";
            return ds;
        }

        /// <summary>
        ///  [요청]
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  resultType : 결과형식
        ///  serviceKey : 서비스키
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  
        ///  [응답]
        ///  resultCode : 결과코드
        ///  resultMsg : 결과메시지
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  totalCount : 전체 결과 수
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  isinCd : ISIN코드
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  isinCdNm : ISIN코드명
        ///  scrsItmsKcd : 유가증권종목종류코드
        ///  scrsItmsKcdNm : 유가증권종목종류코드명
        ///  stckParPrc : 주식액면가
        ///  issuStckCnt : 발행주식수
        ///  lstgDt : 상장일자
        ///  lstgAbolDt : 상장폐지일자
        ///  dpsgRegDt : 예탁등록일자
        ///  dpsgCanDt : 예탁취소일자
        ///  issuFrmtClsfNm : 발행형태구분명
        /// </summary>
        public DataTable GetItemBasiInfo(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, ItemBasiInfo_CallbackUrl), "item", "종목기본정보조회");
        }

        /// <summary>
        /// [요청]
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  resultType : 결과형식
        ///  serviceKey : 서비스키
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  
        /// [응답]
        ///  resultCode : 결과코드
        ///  resultMsg : 결과메시지
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  totalCount : 전체 결과 수
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  isinCd : ISIN코드
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  isinCdNm : ISIN코드명
        ///  scrsDcd : 유가증권구분코드
        ///  stckIssuSqno : 주식발행일련번호
        ///  stckIssuDt : 주식발행일자
        ///  stckIssuDcnt : 주식발행차수
        ///  scrsItmsKcd : 유가증권종목종류코드
        ///  scrsItmsKcdNm : 유가증권종목종류코드명
        ///  stckIssuRcd : 주식발행사유코드
        ///  stckIssuRcdNm : 주식발행사유코드명
        ///  issuStckCnt : 발행주식수
        ///  lstgDt : 상장일자
        /// </summary>
        public DataTable GetStocIssuInfo(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, IssuInfo_CallbackUrl), "item", "주식발행내역조회");
        }

        /// <summary>
        /// [요청]
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  resultType : 결과형식
        ///  serviceKey : 서비스키
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  
        /// [응답]
        ///  resultCode : 결과코드
        ///  resultMsg : 결과메시지
        ///  numOfRows : 한 페이지 결과 수
        ///  pageNo : 페이지 번호
        ///  totalCount : 전체 결과 수
        ///  basDt : 기준일자
        ///  crno : 법인등록번호
        ///  isinCd : ISIN코드
        ///  isinCdNm : ISIN코드명
        ///  itmsShrtnCd : 종목단축코드
        ///  stckIssuCmpyNm : 주식발행회사명
        ///  scrsItmsKcd : 유가증권종목종류코드
        ///  scrsItmsKcdNm : 유가증권종목종류코드명
        ///  lstgDcd : 상장구분코드
        ///  lstgDcdNm : 상장구분코드명
        ///  lkupRegDt : 의무보호예수등록일자
        ///  lkupRegStckCnt : 의무보호예수등록주식수
        ///  rsrnDt : 반환일자
        ///  rsrnStckCnt : 반환주식수
        ///  afrsRsqtCnt : 반환후잔량수
        ///  stckLblHoldRcd : 주식의무보유사유코드
        ///  stckLblHoldRcdNm : 주식의무보유사유코드명
        ///  lblProtTsumIssuStckCnt : 의무보호총합계발행주식수
        ///  
        /// </summary>
        public DataTable GetLockUpRetuInfo(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, LockUpRetuInfo_CallbackUrl), "item", "의무보호예수반환정보조회");
        }

        /// <summary>
        /// [요청]
        /// numOfRows : 한 페이지 결과 수
        /// pageNo : 페이지 번호
        /// resultType : 결과형식
        /// serviceKey : 서비스키
        /// basDt : 기준일자
        /// crno : 법인등록번호
        /// stckIssuCmpyNm : 주식발행회사명
        ///  
        /// [응답]
        /// resultCode : 결과코드
        /// resultMsg : 결과메시지
        /// numOfRows : 한 페이지 결과 수
        /// pageNo : 페이지 번호
        /// totalCount : 전체 결과 수
        /// basDt : 기준일자
        /// crno : 법인등록번호
        /// stckIssuCmpyNm : 주식발행회사명
        /// onskTisuCnt : 보통주총발행수
        /// pfstTisuCnt : 우선주총발행수
        /// </summary>
        public DataTable GetStocIssuStat(RequestMessageInfo messageInfo)
        {
            return GetDataTableFromAPIResult(SetURL(messageInfo, StocIssuStat_CallbackUrl), "item", "주식발행현황조회");
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
