using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{
    public class TradingStrategy
    {
        public string account; //매매 계좌
        public Condition buyingCondition; //매수 조건식
        public string buyingOrderOption; //매수 현재가 or 시장가 등등 호가 옵션
        public long totalInvestment; //총 투자금
        public int buyingItemCount; //매수 종목수
        public int remainingItemCount; // 남은 매수할 종목 수 

        public long itemInvestment; //종목별 투자금
        public bool onlyIntrest;


        public bool usingTakeProfit; //익절 사용여부
        public double takeProfitRate; //익절률
        public string sellOrderOption; //매도 현재가 or 시장가 등등 호가 옵션
        public bool usingStopLoss; //손절 사용 여부
        public double stopLossRate; //손절률

        public bool usingCondition; //조건식 사용여부

       


        //매매 진행 종목 리스트
        public List<TradingItem> tradingItemList = new List<TradingItem>(); 



        public TradingStrategy(string account, Condition condition, string buyingOrderOption, long totalInvestment, int buyingItemCount, bool usingTakeProfit, double takeProfitRate, string sellOrderOption, bool usingStopLoss, double stopLossRate, bool onlyInterest)
        {
            this.account = account;
            this.buyingCondition = condition;
            this.buyingOrderOption = buyingOrderOption;
            this.totalInvestment = totalInvestment;
            this.buyingItemCount = buyingItemCount;
            this.remainingItemCount = buyingItemCount;


            if (buyingItemCount != 0)
                this.itemInvestment = totalInvestment / buyingItemCount;


            this.usingTakeProfit = usingTakeProfit;
            this.takeProfitRate = takeProfitRate;
            this.sellOrderOption = sellOrderOption;
            this.usingStopLoss = usingStopLoss;
            this.stopLossRate = stopLossRate;

            this.onlyIntrest = onlyInterest;

        }
    }
}
