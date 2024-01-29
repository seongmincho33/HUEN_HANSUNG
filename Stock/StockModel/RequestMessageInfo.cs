using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    public class RequestMessageInfo
    {
        /// <summary>
        /// [시세정보]
        /// [발행정보]
        /// [배당정보]
        /// [재무정보]
        /// 공공데이터포털에서 받은 인증키
        /// </summary>
        public string serviceKey { get; set; }

        /// <summary>
        /// [시세정보]
        /// [발행정보]
        /// [배당정보]
        /// [재무정보]
        /// 페이지 번호
        /// </summary>
        public Int64 pageNo { get; set; }

        /// <summary>
        /// [시세정보]
        /// [발행정보]
        /// [배당정보]
        /// [재무정보]
        /// 한 페이지 결과 수
        /// </summary>       
        public Int64 numOfRows { get; set; }

        /// <summary>
        /// [시세정보]
        /// [발행정보]
        /// [배당정보]
        /// [재무정보]
        /// 결과형식(xml/json) Default: xml
        /// </summary>
        public string resultType { get; set; }

        /// <summary>
        /// [발행정보]
        /// [배당정보]
        /// [재무정보]
        /// 법인등록번호
        /// ex)1746110000741
        /// </summary>
        public Int64? crno
        {
            get
            {
                if(_crno != 0 && _crno != null)
                {
                    return _crno;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _crno = value;
            }
        }

        private Int64? _crno { get; set; }       

        /// <summary>
        /// [발행정보]
        /// [배당정보]
        /// 종목명
        /// ex)동남합성
        /// 주식발행사의 명칭
        /// </summary>
        public string stckIssuCmpyNm
        {
            get
            {
                if (_stckIssuCmpyNm != "" && _stckIssuCmpyNm != null)
                {
                    return _stckIssuCmpyNm;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _stckIssuCmpyNm = value;
            }
        }

        private string _stckIssuCmpyNm { get; set; }

        /// <summary>
        /// [시세정보]
        /// 종목명
        /// ex)이스트아시아홀딩스
        /// 검색값과 종목명이 일치하는 데이터를 검색
        /// </summary>
        public string itmsNm
        {
            get
            {
                if (_itmsNm != "" && _itmsNm != null)
                {
                    return _itmsNm;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _itmsNm = value;
            }
        }

        private string _itmsNm { get; set; }

        /// <summary>
        /// [시세정보]
        /// 종목명
        /// ex)이스트아시아홀딩스
        /// 종목명이 검색값을 포함하는 데이터를 검색
        /// </summary>
        public string likeItmsNm
        {
            get
            {
                if (_likeItmsNm != "" && _likeItmsNm != null)
                {
                    return _likeItmsNm;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _likeItmsNm = value;
            }
        }

        private string _likeItmsNm { get; set; }

        /// <summary>
        /// [시세정보]
        /// [발행정보]
        /// [배당정보]
        /// 기준일자
        ///  ex)20220919
        /// 검색값과 기준일자가 일치하는 데이터를 검색
        /// </summary>
        public Int64? basDt
        {
            get
            {
                if (_basDt != 0 && _basDt != null)
                {
                    return _basDt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _basDt = value;
            }
        }

        private Int64? _basDt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 기준일자 
        /// ex)20220919
        /// 기준일자가 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public Int64? beginBasDt
        {
            get
            {
                if (_beginBasDt != 0 && _beginBasDt != null)
                {
                    return _beginBasDt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginBasDt = value;
            }
        }

        private Int64? _beginBasDt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 기준일자
        /// ex)20220919
        /// 기준일자가 검색값보다 작은 데이터를 검색
        /// </summary>
        public Int64? endBasDt
        {
            get
            {
                if (_endBasDt != 0 && _endBasDt != null)
                {
                    return _endBasDt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endBasDt = value;
            }
        }

        private Int64? _endBasDt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 기준일자
        /// ex)20220919
        /// 기준일자값이 검색값을 포함하는 데이터를 검색
        /// </summary>
        public Int64? likeBasDt
        {
            get
            {
                if (_likeBasDt != 0 && _likeBasDt != null)
                {
                    return _likeBasDt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _likeBasDt = value;
            }
        }

        private Int64? _likeBasDt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 단축코드
        /// ex)900110
        /// 단축코드가 검색값을 포함하는 데이터를 검색
        /// </summary>
        public Int64? likeSrtnCd
        {
            get
            {
                if (_likeSrtnCd != 0 && _likeSrtnCd != null)
                {
                    return _likeSrtnCd;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _likeSrtnCd = value;
            }
        }

        private Int64? _likeSrtnCd { get; set; }

        /// <summary>
        /// [시세정보]
        /// ISIN코드
        /// ex)HK0000057197
        /// 검색값과 ISIN코드이 일치하는 데이터를 검색
        /// </summary>
        public string isinCd
        {
            get
            {
                if (_isinCd != "" && _isinCd != null)
                {
                    return _isinCd;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _isinCd = value;
            }
        }

        private string _isinCd { get; set; }

        /// <summary>
        /// [시세정보]
        /// ISIN코드
        /// ex)HK0000057197
        /// ISIN코드가 검색값을 포함하는 데이터를 검색
        /// </summary>
        public string likeIsinCd
        {
            get
            {
                if (_likeIsinCd != "" && _likeIsinCd != null)
                {
                    return _likeIsinCd;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _likeIsinCd = value;
            }
        }

        private string _likeIsinCd { get; set; }

        /// <summary>
        /// [시세정보]
        /// 시장구분
        /// ex)KOSDAQ
        /// 검색값과 시장구분이 일치하는 데이터를 검색
        /// </summary>
        public string mrktCls
        {
            get
            {
                if (_mrktCls != "" && _mrktCls != null)
                {
                    return _mrktCls;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _mrktCls = value;
            }
        }

        private string _mrktCls { get; set; }

        /// <summary>
        /// [시세정보]
        /// 대비
        /// ex)-8
        /// 대비가 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public decimal? beginVs
        {
            get
            {
                if (_beginVs != 0 && _beginVs != null)
                {
                    return _beginVs;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginVs = value;
            }
        }

        private decimal? _beginVs { get; set; }

        /// <summary>
        /// [시세정보]
        /// 대비
        /// ex)-8
        /// 대비가 검색값보다 작은 데이터를 검색
        /// </summary>
        public decimal? endVs
        {
            get
            {
                if (_endVs != 0 && _endVs != null)
                {
                    return _endVs;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endVs = value;
            }
        }

        private decimal? _endVs { get; set; }

        /// <summary>
        /// [시세정보]
        /// 등락률
        /// ex)-4.57
        /// 등락률이 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public decimal? beginFltRt
        {
            get
            {
                if (_beginFltRt != 0 && _beginFltRt != null)
                {
                    return _beginFltRt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginFltRt = value;
            }
        }

        private decimal? _beginFltRt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 등락률
        /// ex)-4.57
        /// 등락률이 검색값보다 작은 데이터를 검색
        /// </summary>
        public decimal? endFltRt
        {
            get
            {
                if (_endFltRt != 0 && _endFltRt != null)
                {
                    return _endFltRt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endFltRt = value;
            }
        }

        private decimal? _endFltRt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 거래량
        /// ex)2788311
        /// 거래량이 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public Int64? beginTrqu
        {
            get
            {
                if (_beginTrqu != 0 && _beginTrqu != null)
                {
                    return _beginTrqu;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginTrqu = value;
            }
        }

        private Int64? _beginTrqu { get; set; }

        /// <summary>
        /// [시세정보]
        /// 거래량
        /// ex)2788311
        /// 거래량이 검색값보다 작은 데이터를 검색
        /// </summary>
        public Int64? endTrqu
        {
            get
            {
                if (_endTrqu != 0 && _endTrqu != null)
                {
                    return _endTrqu;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endTrqu = value;
            }
        }

        private Int64? _endTrqu { get; set; }

        /// <summary>
        /// [시세정보]
        /// 거래대금
        /// ex)475708047
        /// 거래대금이 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public Int64? beginTrPrc
        {
            get
            {
                if (_beginTrPrc != 0 && _beginTrPrc != null)
                {
                    return _beginTrPrc;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginTrPrc = value;
            }
        }

        private Int64? _beginTrPrc { get; set; }

        /// <summary>
        /// [시세정보]
        /// 거래대금
        /// ex)475708047
        /// 거래대금이 검색값보다 작은 데이터를 검색
        /// </summary>
        public Int64? endTrPrc
        {
            get
            {
                if (_endTrPrc != 0 && _endTrPrc != null)
                {
                    return _endTrPrc;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endTrPrc = value;
            }
        }

        private Int64? _endTrPrc { get; set; }

        /// <summary>
        /// [시세정보]
        /// 상장주식수
        /// ex)219932050
        /// 상장주식수가 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public Int64? beginLstgStCnt
        {
            get
            {
                if (_beginLstgStCnt != 0 && _beginLstgStCnt != null)
                {
                    return _beginLstgStCnt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginLstgStCnt = value;
            }
        }

        private Int64? _beginLstgStCnt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 상장주식수
        /// ex)219932050
        /// 상장주식수가 검색값보다 작은 데이터를 검색
        /// </summary>
        public Int64? endLstgStCnt
        {
            get
            {
                if (_endLstgStCnt != 0 && _endLstgStCnt != null)
                {
                    return _endLstgStCnt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endLstgStCnt = value;
            }
        }

        private Int64? _endLstgStCnt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 시가총액
        /// ex)36728652350
        /// 시가총액이 검색값보다 크거나 같은 데이터를 검색
        /// </summary>
        public Int64? beginMrktTotAmt
        {
            get
            {
                if (_beginMrktTotAmt != 0 && _beginMrktTotAmt != null)
                {
                    return _beginMrktTotAmt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _beginMrktTotAmt = value;
            }
        }

        private Int64? _beginMrktTotAmt { get; set; }

        /// <summary>
        /// [시세정보]
        /// 시가총액
        /// ex)36728652350
        /// 시가총액이 검색값보다 작은 데이터를 검색
        /// </summary>
        public Int64? endMrktTotAmt
        {
            get
            {
                if (_endMrktTotAmt != 0 && _endMrktTotAmt != null)
                {
                    return _endMrktTotAmt;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _endMrktTotAmt = value;
            }
        }

        private Int64? _endMrktTotAmt { get; set; }

        /// <summary>
        /// [재무정보]
        /// 사업연도
        /// ex)2019
        /// 법인에 대해 법령이 규정한 1회계기간으로서 법인세의 과세기간
        /// </summary>
        public Int64? bizYear
        {
            get
            {
                if (_bizYear != 0 && _bizYear != null)
                {
                    return _bizYear;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                _bizYear = value;
            }
        }

        private Int64? _bizYear { get; set; }

       
    }
}
