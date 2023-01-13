using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{
    class CheckItem
    {
        public string itemCode;
        public string itemName;
        public string score;
        public string conditionName;
        public int conditionIndex;

     
        public CheckItem(string itemCode, string itemName, string score, string conditionName, int conditionIndex)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.score = score;
            this.conditionName = conditionName;
            this.conditionIndex = conditionIndex;
        }
    }
}
