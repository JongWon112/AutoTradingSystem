using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{
    class BalanceSellStrategy
    {
        public string orderNum;

        public string account; //매매 계좌
        public string itemCode; //종목코드
        public string itemName;
        public int buyingPrice; //매수 평균 단가


        public long sellQnt; //매도수량
        public string sellOrderOption; //매도 현재가 or 시장가 등등 호가 옵션
        public bool usingTakeProfit; //익절 사용여부
        public double takeProfitRate; //익절률
        public bool usingStopLoss; //손절 사용 여부
        public double stopLossRate; //손절률
        

        public bool isSold = false;

        public BalanceSellStrategy(string account, string itemCode, string itemName, int buyingPrice, long sellQnt, string sellOrderOption, bool usingTakeProfit, double takeProfitRate, bool usingStopLoss, double stopLossRate)
        {
            this.account = account;
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.buyingPrice = buyingPrice;
            this.sellQnt = sellQnt;
            this.usingTakeProfit = usingTakeProfit;
            this.takeProfitRate = takeProfitRate;
            this.usingStopLoss = usingStopLoss;
            this.stopLossRate = stopLossRate;
            this.sellOrderOption = sellOrderOption;
            this.orderNum = string.Empty;
        }

    }
}
