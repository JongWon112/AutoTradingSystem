using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{

    //매매진행 종목
    public class TradingItem
    {
        public string buyOrderNum; //매수주문번호
        public string sellOrderNum; //매도주문번호
        public string cancleOrderNum; //주문취소시 취소주문번호 이때 매수주문버호가 원주문번호
        public string medoCondition;

        public string itemCode; //종목코드
        //public string itemName; //종목명
        public long buyingPrice; //매수단가
        public int buyingQnt; //매수량
        public bool isSold; //매도주문여부

        public bool isCompletedBuying; //매수완료 여부
        
        public TradingItem(string itemCode, long buyingPrice, int buyingQnt)
        {
            this.itemCode = itemCode;
            this.buyingPrice = buyingPrice;
            this.buyingQnt = buyingQnt;
            this.isSold = false;
            this.isCompletedBuying = false;

            this.buyOrderNum = String.Empty;
            this.sellOrderNum = string.Empty;
            this.cancleOrderNum = string.Empty;
            this.medoCondition = string.Empty;


        }

    }
}
