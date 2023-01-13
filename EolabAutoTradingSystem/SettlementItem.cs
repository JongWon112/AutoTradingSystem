using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{
    public class SettlementItem
    {
        public string accountNum; //계좌번호
        public string sellOrderNum; //매도주문번호
        public string itemCode; //종목코드
        public int orderQnt; //주문량

        public SettlementItem(string accountNum, string itemCode, int orderQnt)
        {
            this.accountNum = accountNum;
            this.itemCode = itemCode;
            this.orderQnt = orderQnt;
            

        }

    }
}
