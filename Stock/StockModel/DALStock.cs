using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StockModel
{
    public abstract class DALStock
    {
        /// <summary>
        /// 공공데이터 포털에서 받아온 인증키
        /// </summary>
        public string ServiceKey
        {
            get { return "io8Si%2BJVpbHh5oGquslEZhqXNa0v0d5KaRRwlSuMQ0UK1VQoSNn9oc8dgatjYgXd0akMCTla7JiHbk9csD8H5Q%3D%3D"; }
        }

        abstract public DataSet GetAllData(RequestMessageInfo messageInfo);

        /// <summary>
        /// API로 부터 데이터 받음.
        /// </summary>
        /// <param name="url">url 주소</param>
        /// <param name="tagName">XML 구조 보고 원하는데이터의 부모 태그 이름</param>
        /// <param name="tableName">반환 테이블 이름 정해주기</param>
        /// <returns>DataTable형식으로 반환</returns>
        internal DataTable GetDataTableFromAPIResult(string url, string tagName, string tableName)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                XmlNodeReader xmlReader = new XmlNodeReader(xmlDoc);
                DataSet ds = new DataSet();
                ds.ReadXml(xmlReader);
                if (tagName == "item" || tagName == "body")
                {
                    if(ds.Tables[tagName] != null)
                    {
                        DataTable dt = ds.Tables[tagName].Copy();
                        dt.TableName = tableName;
                        ChangeDataTableColumnName(dt);
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    //XML 구조 보고 원하는데이터의 부모 테그가 곧 테이블 이름임.
                    return null;
                }
            }
        }

        /// <summary>
        /// 데이터 테이블 컬럼이름을 한국어로 바꿉니다.
        /// </summary>
        /// <param name="dt"></param>
        private void ChangeDataTableColumnName(DataTable dt)
        {
            foreach(DataColumn col in dt.Columns)
            {
                switch (col.ColumnName)
                {
                    //1. 주식시세API
                    //[1] 주식시세
                    case "resultCode":
                        col.ColumnName = "결과코드";
                        break;
                    case "resultMsg":
                        col.ColumnName = "결과메시지";
                        break;
                    case "numOfRows":
                        col.ColumnName = "한 페이지 결과 수";
                        break;
                    case "pageNo":
                        col.ColumnName = "페이지 번호";
                        break;
                    case "totalCount":
                        col.ColumnName = "전체 결과 수";
                        break;
                    case "basDt":
                        col.ColumnName = "기준일자";
                        break;
                    case "srtnCd":
                        col.ColumnName = "단축코드";
                        break;
                    case "isinCd":
                        col.ColumnName = "ISIN코드";
                        break;
                    case "itmsNm":
                        col.ColumnName = "종목명";
                        break;
                    case "mrktCtg":
                        col.ColumnName = "시장구분";
                        break;
                    case "clpr":
                        col.ColumnName = "종가";
                        break;
                    case "vs":
                        col.ColumnName = "대비";
                        break;
                    case "fltRt":
                        col.ColumnName = "등락률";
                        break;
                    case "mkp":
                        col.ColumnName = "시가";
                        break;
                    case "hipr":
                        col.ColumnName = "고가";
                        break;
                    case "lopr":
                        col.ColumnName = "저가";
                        break;
                    case "trqu":
                        col.ColumnName = "거래량";
                        break;
                    case "trPrc":
                        col.ColumnName = "거래대금";
                        break;
                    case "lstgStCnt":
                        col.ColumnName = "상장주식수";
                        break;
                    case "mrktTotAmt":
                        col.ColumnName = "시가총액";
                        break;
                    //[2] 신주인수권증서시세
                    case "crno":
                        col.ColumnName = "법인등록번호";
                        break;
                    case "lstgCtfCnt":
                        col.ColumnName = "상장증서수";
                        break;
                    case "nstIssPrc":
                        col.ColumnName = "신주발행가";
                        break;
                    case "dltDt":
                        col.ColumnName = "상장폐지일";
                        break;
                    case "purRgtScrtItmsCd":
                        col.ColumnName = "목적주권_종목코드";
                        break;
                    case "purRgtScrtItmsNm":
                        col.ColumnName = "목적주권_종목명";
                        break;
                    case "purRgtScrtItmsClpr":
                        col.ColumnName = "목적주권_종가";
                        break;
                    //[3] 수익증권시세
                    case "stLstgCnt":
                        col.ColumnName = "상장좌수";
                        break;
                    //[4] 신주인수권증권시세
                    case "exertPric":
                        col.ColumnName = "행사가격";
                        break;
                    case "subtPdSttgDt":
                        col.ColumnName = "존속기간_시작일";
                        break;
                    case "subtPdEdDt":
                        col.ColumnName = "존속기간_종료일";                    
                        break;
                    //2. 주식발행정보조회서비스
                    //[1] 종목기본정보조회
                    case "stckIssuCmpyNm":
                        col.ColumnName = "주식발행회사명";
                        break;
                    case "isinCdNm":
                        col.ColumnName = "ISIN코드명";
                        break;
                    case "scrsItmsKcd":
                        col.ColumnName = "유가증권종목종류코드";
                        break;
                    case "scrsItmsKcdNm":
                        col.ColumnName = "유가증권종목종류코드명";
                        break;
                    case "stckParPrc":
                        col.ColumnName = "주식액면가";
                        break;
                    case "issuStckCnt":
                        col.ColumnName = "발행주식수";
                        break;
                    case "lstgDt":
                        col.ColumnName = "상장일자";
                        break;
                    case "lstgAbolDt":
                        col.ColumnName = "상장폐지일자";
                        break;
                    case "dpsgRegDt":
                        col.ColumnName = "예탁등록일자";
                        break;
                    case "dpsgCanDt":
                        col.ColumnName = "예탁취소일자";
                        break;
                    case "issuFrmtClsfNm":
                        col.ColumnName = "발행형태구분명";
                        break;
                    //[2] 주식발행내역조회
                    case "scrsDcd":
                        col.ColumnName = "유가증권구분코드";
                        break;
                    case "stckIssuSqno":
                        col.ColumnName = "주식발행일련번호";
                        break;
                    case "stckIssuDt":
                        col.ColumnName = "주식발행일자";
                        break;
                    case "stckIssuDcnt":
                        col.ColumnName = "주식발행차수";
                        break;
                    case "stckIssuRcd":
                        col.ColumnName = "주식발행사유코드";
                        break;
                    case "stckIssuRcdNm":
                        col.ColumnName = "주식발행사유코드명";
                        break;
                    //[3] 의무보호예수반환정보조회
                    case "itmsShrtnCd":
                        col.ColumnName = "종목단축코드";
                        break;
                    case "lstgDcd":
                        col.ColumnName = "상장구분코드";
                        break;
                    case "lstgDcdNm":
                        col.ColumnName = "상장구분코드명";
                        break;
                    case "lkupRegDt":
                        col.ColumnName = "의무보호예수등록일자";
                        break;
                    case "lkupRegStckCnt":
                        col.ColumnName = "의무보호예수등록주식수";
                        break;
                    case "rsrnDt":
                        col.ColumnName = "반환일자";
                        break;
                    case "rsrnStckCnt":
                        col.ColumnName = "반환주식수";
                        break;
                    case "afrsRsqtCnt":
                        col.ColumnName = "반환후잔량수";
                        break;
                    case "stckLblHoldRcd":
                        col.ColumnName = "주식의무보유사유코드";
                        break;
                    case "stckLblHoldRcdNm":
                        col.ColumnName = "주식의무보유사유코드명";
                        break;
                    case "lblProtTsumIssuStckCnt":
                        col.ColumnName = "의무보호총합계발행주식수";
                        break;
                    //[4] 주식발행현황조회
                    case "onskTisuCnt":
                        col.ColumnName = "보통주총발행수";
                        break;
                    case "pfstTisuCnt":
                        col.ColumnName = "우선주총발행수";
                        break;
                    //3. 주식배당정보조회서비스
                    //[1] 배당정보조회
                    case "dvdnBasDt":
                        col.ColumnName = "배당기준일자";
                        break;
                    case "cashDvdnPayDt":
                        col.ColumnName = "현금배당지급일자";
                        break;
                    case "stckHndvDt":
                        col.ColumnName = "주식교부일자";
                        break;
                    case "stckDvdnRcd":
                        col.ColumnName = "주식배당사유코드";
                        break;
                    case "stckDvdnRcdNm":
                        col.ColumnName = "주식배당사유코드명";
                        break;
                    case "trsnmDptyDcd":
                        col.ColumnName = "명의개서대리인구분코드";
                        break;
                    case "trsnmDptyDcdNm":
                        col.ColumnName = "명의개서대리인구분코드명";
                        break;
                    case "stckGenrDvdnAmt":
                        col.ColumnName = "주식일반배당금액";
                        break;
                    case "stckGrdnDvdnAmt":
                        col.ColumnName = "주식차등배당금액";
                        break;
                    case "stckGenrCashDvdnRt":
                        col.ColumnName = "주식일반현금배당률";
                        break;
                    case "stckGenrDvdnRt":
                        col.ColumnName = "주식일반배당률";
                        break;
                    case "cashGrdnDvdnRt":
                        col.ColumnName = "현금차등배당률";
                        break;
                    case "stckGrdnDvdnRt":
                        col.ColumnName = "주식차등배당률";
                        break;
                    case "stckStacMd":
                        col.ColumnName = "주식결산월일";
                        break;
                    //4. 재무정보조회서비스
                    //[1] 요약재무제표조회
                    case "bizYear":
                        col.ColumnName = "사업연도";
                        break;
                    case "fnclDcd":
                        col.ColumnName = "재무제표구분코드";
                        break;
                    case "fnclDcdNm":
                        col.ColumnName = "재무제표구분코드명";
                        break;
                    case "enpSaleAmt":
                        col.ColumnName = "기업매출금액";
                        break;
                    case "enpBzopPft":
                        col.ColumnName = "기업영업이익";
                        break;
                    case "iclsPalClcAmt":
                        col.ColumnName = "포괄손익계산금액";
                        break;
                    case "enpCrtmNpf":
                        col.ColumnName = "기업당기순이익";
                        break;
                    case "enpTastAmt":
                        col.ColumnName = "기업총자산금액";
                        break;
                    case "enpTdbtAmt":
                        col.ColumnName = "기업총부채금액";
                        break;
                    case "enpTcptAmt":
                        col.ColumnName = "기업총자본금액";
                        break;
                    case "enpCptlAmt":
                        col.ColumnName = "기업자본금액";
                        break;
                    case "fnclDebtRto":
                        col.ColumnName = "재무제표부채비율";
                        break;
                    //[2] 재무상태표조회 [3] 손익계산서조회
                    case "acitId":
                        col.ColumnName = "계정과목ID";
                        break;
                    case "acitNm":
                        col.ColumnName = "계정과목명";
                        break;
                    case "thqrAcitAmt":
                        col.ColumnName = "당분기계정과목금액";
                        break;
                    case "crtmAcitAmt":
                        col.ColumnName = "당기계정과목금액";
                        break;
                    case "lsqtAcitAmt":
                        col.ColumnName = "전분기계정과목금액";
                        break;
                    case "pvtrAcitAmt":
                        col.ColumnName = "전기계정과목금액";
                        break;
                    case "bpvtrAcitAmt":
                        col.ColumnName = "전전기계정과목금액";
                        break;
                    default:
                        col.ColumnName = col.ColumnName + "한글명(X)";
                        break;
                }
            }
        }
    }
}
