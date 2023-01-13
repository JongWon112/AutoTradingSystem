using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolabAutoTradingSystem
{
    public class Condition
    {

        public int index; //조건식 인덱스
        public string name; //조건식 이름
        public string screenNum; // 화면번호

        public List<StockItem> interestItemList = new List<StockItem>();

        public  Condition(int _index, string _name)
        {

            index = _index;
            name = _name;
        }
    }
}
