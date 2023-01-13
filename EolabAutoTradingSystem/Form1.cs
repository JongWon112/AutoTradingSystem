using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace EolabAutoTradingSystem
{
    public partial class Form1 : Form
    {


        List<Condition> conditionList = new List<Condition>(); //조건식리스트

        List<BalanceSellStrategy> balanceSellStrategyList = new List<BalanceSellStrategy>(); // 보유 종목 매도 전략 리스트
        List<TradingStrategy> tradingStrategyList = new List<TradingStrategy>(); //매매전략 리스트
        List<SettlementItem> settleItemList = new List<SettlementItem>(); //진행중인 청산 종목 리스트

        List<TradingItem> tryingOrderList = new List<TradingItem>(); //주문 접수 시도 종목 리스트
        List<SettlementItem> tryingSettleList = new List<SettlementItem>(); //청산 접수 시도 종목 리스트
        List<BalanceSellStrategy> tryingSellList = new List<BalanceSellStrategy>(); //잔고 매도 접수 시도 종목 리스트

        List<StockItem> stockItemList = new List<StockItem>(); //상장종목리스트 

        bool marketClose = false; //true가 되면 모든 종목 청산
        

        //List<CheckItem> checkitemList = new List<CheckItem>();
        //DBCon dbcon = new DBCon();
        


        double TAX = 0.0023;   

        double FEE = 0.00015; //모투의경우 0.0035
       

        int screenNum = 1000;
        string currentAccount = String.Empty;
        long DEPOSIT = 0;

        public Form1()
        {
            InitializeComponent();

            loginToolStripMenuItem.Click += ToolStripMenuItem_Click; //로그인 메뉴 Event
           

            createStrategyButton.Click += Button_Click;
            balanceSellButton.Click += Button_Click;
            AddInterestButton.Click += Button_Click;
            SetaccountbalanceBtn.Click += Button_Click;

            accountComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            accountBalanceDataGridView.CellClick += DataGridView_CellClick;
            autoTradingDataGridView.CellClick += DataGridView_CellClick;
            tradingStrategyDataGridView.CellClick += DataGridView_CellClick;
            
            accountBalanceDataGridView.SelectionChanged += DataGridView_SelectionChanged;

            interestConditionListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

            axKHOpenAPI1.OnEventConnect += API_OnEventConnect; //로그인 결과 Event
            axKHOpenAPI1.OnReceiveConditionVer += API_OnReceiveConditionVer; // 조건식 리스트 요청 결과 Event
            axKHOpenAPI1.OnReceiveRealCondition += API_OnReceiveRealCondition; //실시간 조건식 편입/이탈 정보 Event
            axKHOpenAPI1.OnReceiveTrData += API_OnReceiveTrData; //Tr요청 결과 Event
            axKHOpenAPI1.OnReceiveChejanData += API_OnReceiveChejanData; // 실시간 체결/잔고 정보 Event
            axKHOpenAPI1.OnReceiveRealData += API_OnReceiveRealData; //실시간 데이터
            axKHOpenAPI1.OnReceiveTrCondition += API_OnReceiveTrCondition; //전략생성시 데이터



            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl2.DrawItem += new DrawItemEventHandler(this.tabControl2_DrawItem);

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);

            //form 종료 이벤트
            this.FormClosing += Form_Closing;
            

        }

        //종료이벤트
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
       
            e.Cancel = true;
            this.Visible = false;

            



        }




        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#cc0000");







        private void Form1_Load(object sender, EventArgs e)

        {
            //DBCon dbConn = new DBCon();
            //List<tradingItems> sscc = dbConn.selectDb("1"); // scoree가 1점이상인 데이터를 리스트형으로 반환하므로

            //if (sscc != null)
            //{
            //    foreach (tradingItems tItem in sscc)
            //    {
            //        string code = tItem.code;
            //        string name = tItem.name;
            //        string scoree = tItem.scoree;

            //        Console.WriteLine("code : " + code);
            //        Console.WriteLine("name : " + name);
            //        Console.WriteLine("scoree : " + scoree);
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("select is null!!");
            //}

        }





        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)

        {

            Font fntTab;

            Brush bshBack;

            Brush bshFore;



            if (e.Index == this.tabControl2.SelectedIndex)

            {

                fntTab = new Font(e.Font, FontStyle.Bold);

                //bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);//원래 컨트롤색

                //bshFore = Brushes.Black;

                bshBack = new SolidBrush(col);

                bshFore = new SolidBrush(Color.White);

            }

            else

            {

                fntTab = e.Font;

                //bshBack = new SolidBrush(SystemColors.Control); //원래 컨트롤색

                //bshFore = new SolidBrush(Color.Black);



                bshBack = new SolidBrush(col);

                bshFore = new SolidBrush(Color.White);

            }



            string tabName = this.tabControl2.TabPages[e.Index].Text;

            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);

            sftTab.Alignment = StringAlignment.Center;

            sftTab.LineAlignment = StringAlignment.Center;



            e.Graphics.FillRectangle(bshBack, e.Bounds);

            Rectangle recTab = e.Bounds;





#if true    // <--- 여기를 true 로 변경하면 텍스트의 좌우를 뒤집지 않음

            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);

            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

#else

                        recTab = new Rectangle(0, 0, recTab.Width, recTab.Height);

 

                        Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

                        Graphics g = Graphics.FromImage(bitmap);

                        g.Clear(BackColor);        // <--- 여기에 원하는 배경색상을 지정

                        g.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);

 

                        e.Graphics.DrawImage(bitmap, e.Bounds.X + 1, e.Bounds.Y);   // +1 안해주면 왼쪽에서 짤림

 

                        g.Dispose();

                        bitmap.Dispose();

#endif







        }

        



        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {

            Font fntTab;

            Brush bshBack;

            Brush bshFore;



            if (e.Index == this.tabControl1.SelectedIndex)

            {

                fntTab = new Font(e.Font, FontStyle.Bold);

                //bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);//원래 컨트롤색

                //bshFore = Brushes.Black;

                bshBack = new SolidBrush(col);

                bshFore = new SolidBrush(Color.White);

            }

            else

            {

                fntTab = e.Font;

                //bshBack = new SolidBrush(SystemColors.Control); //원래 컨트롤색

                //bshFore = new SolidBrush(Color.Black);



                bshBack = new SolidBrush(col);

                bshFore = new SolidBrush(Color.White);

            }



            string tabName = this.tabControl1.TabPages[e.Index].Text;

            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);

            sftTab.Alignment = StringAlignment.Center;

            sftTab.LineAlignment = StringAlignment.Center;



            e.Graphics.FillRectangle(bshBack, e.Bounds);

            Rectangle recTab = e.Bounds;



#if true    // <--- 여기를 true 로 변경하면 텍스트의 좌우를 뒤집지 않음

            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);

            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

#else

                        recTab = new Rectangle(0, 0, recTab.Width, recTab.Height);

 

                        Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

                        Graphics g = Graphics.FromImage(bitmap);

                        g.Clear(BackColor);        // <--- 여기에 원하는 배경색상을 지정

                        g.DrawString(tabName, fntTab, bshFore, recTab, sftTab);

                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);

 

                        e.Graphics.DrawImage(bitmap, e.Bounds.X + 1, e.Bounds.Y);   // +1 안해주면 왼쪽에서 짤림

 

                        g.Dispose();

                        bitmap.Dispose();

#endif



        }



        private void DataGridView_SelectionChange(object sneder, EventArgs e)
        {


        }


        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Console.WriteLine("SelectionChanged" + sender.ToString());
            if (sender.Equals(accountBalanceDataGridView))
            {
                if (accountBalanceDataGridView.SelectedRows.Count > 0)
                {
                    int rowIndex = accountBalanceDataGridView.SelectedRows[0].Index;

                    if (accountBalanceDataGridView["계좌잔고_종목코드", rowIndex].Value != null)
                    {

                        string itemCode = accountBalanceDataGridView["계좌잔고_종목코드", rowIndex].Value.ToString();
                        string itemName = accountBalanceDataGridView["계좌잔고_종목명", rowIndex].Value.ToString();
                        long balanceQnt = long.Parse(accountBalanceDataGridView["계좌잔고_보유수량", rowIndex].Value.ToString());
                        double buyingPrice = double.Parse(accountBalanceDataGridView["계좌잔고_평균단가", rowIndex].Value.ToString());


                        balanceItemCodeTextBox.Text = itemCode.Replace("A", "").Trim();
                        balanceItemNameTextBox.Text = itemName;

                        balanceQntNumericUpDown.Maximum = balanceQnt;
                        balanceQntNumericUpDown.Value = balanceQnt;
                        balanceAvgPriceLabel.Text = buyingPrice.ToString();

                    }
                    else
                    {
                        accountBalanceDataGridView.ClearSelection();

                    }


                }

            }

        }

       

        private void ListBox_SelectedIndexChanged(Object sender, EventArgs e)
        {

            if (sender.Equals(interestConditionListBox))
            {
                if (interestConditionListBox.SelectedItem != null)
                {
                    string conditionName = interestConditionListBox.SelectedItem.ToString();
                    Condition condition = conditionList.Find(o => o.name.Equals(conditionName));

                    if (condition != null)
                    {
                        interestItemListBox.Items.Clear();
                        foreach (StockItem stockItem in condition.interestItemList)
                        {
                            interestItemListBox.Items.Add(stockItem.Name);


                        }


                    }

                }
            }
        }


        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            if (sender.Equals(accountBalanceDataGridView))
            {

                if (accountBalanceDataGridView.Columns["계좌잔고_청산"].Index == e.ColumnIndex && e.RowIndex >=0) //잔고아이템 청산 눌렀을때
                {
                    if (accountBalanceDataGridView["계좌잔고_청산", e.RowIndex].Value == null)
                    {
                        if (accountBalanceDataGridView["계좌잔고_종목코드", e.RowIndex].Value != null)
                        {

                            string itemCode = accountBalanceDataGridView["계좌잔고_종목코드", e.RowIndex].Value.ToString().Replace("A", "").Trim();
                            int balanceCnt = int.Parse(accountBalanceDataGridView["계좌잔고_보유수량", e.RowIndex].Value.ToString());
                            
                          /*  if(autoTradingDataGridView.Rows.Count > 0)
                            {
                                int balanceCntChk = 0;
                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {
                                   
                                    if (row.Cells[1].Value.Equals(itemCode))
                                    {
                                        balanceCntChk += int.Parse(row.Cells[5].Value.ToString());
                                    }
                                }

                                if(balanceCntChk != 0)
                                {
                                    balanceCnt = balanceCntChk;
                                }
                               
                            }*/
                          
                            Console.WriteLine("매도수량 : " + balanceCnt);
                            //청산클릭 종목이 매수중인지 아닌지 확인 -> 매수중이면 주문취소->청산
                            //청산클릭 종목이 이미 청산중인지 아닌지 확인 -> 청산중 아닐때 청산
                            string mesuingList = ""; // 매수중인 종목리스트
                            foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                            {
                                if (row.Cells[0].Value.Equals("매수중"))
                                {
                                    mesuingList += row.Cells[1].Value + "_";
                                }
                            }
                            Console.WriteLine("매수진행중 리스트 : " + mesuingList);
                            SettlementItem si = settleItemList.Find(p => p.itemCode.Equals(itemCode));
                            if (!mesuingList.Contains(itemCode) && si == null) //자동매매진행중 종목이 아니거나 매수주문이 완료된 것들만 청산
                            {
                               
                                Console.WriteLine("청산 종목코드: " + itemCode);

                                int orderResult = axKHOpenAPI1.SendOrder("청산매도주문",
                                                        GetScreenNum(),
                                                        currentAccount,
                                                        2,
                                                        itemCode,
                                                        balanceCnt,
                                                        0,
                                                        "03",
                                                        "");
                                Console.WriteLine(orderResult.ToString());
                                if (orderResult == 0)
                                {
                                    Console.WriteLine("청산 접수 성공");
                                    Console.WriteLine("아이템코드 : " + itemCode.ToString());
                                    SettlementItem settlementItem = new SettlementItem(currentAccount, itemCode, balanceCnt);
                                    settleItemList.Add(settlementItem);
                                    tryingSettleList.Add(settlementItem);


                                    accountBalanceDataGridView["계좌잔고_청산", e.RowIndex].Value = "청산중...";


                                }

                               /* //매매진행상황 그리드뷰 업데이트
                                int rows = autoTradingDataGridView.Rows.Count;
                                if (rows > 0)
                                {
                                    for (int i = 0; i < rows; i++)
                                    {
                                        string codename = autoTradingDataGridView.Rows[i].Cells[1].Value.ToString();
                                        Console.WriteLine("매매진황상황코드 : " + codename);
                                        Console.WriteLine("보유잔고코드 : " + itemCode);
                                        if (itemCode.Equals(codename))
                                        {
                                            string conditionName = autoTradingDataGridView["매매진행_매수조건식", i].Value.ToString();
                                            TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));
                                            if (ts != null)
                                            {

                                                TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Equals(itemCode));
                                                tryingOrderList.Add(ti);
                                                ti.isSold = true;
                                                if (autoTradingDataGridView["매매진행_진행상황", i].Value.ToString() != "주문취소")
                                                {
                                                    autoTradingDataGridView["매매진행_진행상황", i].Value = "청산중";

                                                    autoTradingDataGridView["매매진행_청산", i].Value = "청산중...";
                                                }

                                            }

                                        }

                                    }
                                }*/
                            }
                            else if(mesuingList.Contains(itemCode))
                            {
                                
                                MessageBox.Show("자동매매 매수중인 종목입니다.");
                            }
                            else if(si != null)
                            {
                                MessageBox.Show("청산 진행중입니다.");
                            }
                           

                        }
                    }
                }
                
            }
            else if (sender.Equals(autoTradingDataGridView))
            {

                //Console.WriteLine(accountBalanceDataGridView["계좌잔고_손익금액", 0].Value);
                /*Console.WriteLine(accountBalanceDataGridView["계좌잔고_손익금액",0 ].Selected.ToString());
                Console.WriteLine(accountBalanceDataGridView["계좌잔고_청산", 0].Value == null);*/

                if (0 <= e.ColumnIndex && e.ColumnIndex <= autoTradingDataGridView.Columns.Count)
                {
                    if (autoTradingDataGridView.Columns["매매진행_청산"].Index == e.ColumnIndex &&e.RowIndex >= 0)
                    {
                        Console.WriteLine(autoTradingDataGridView["매매진행_청산", e.RowIndex].Value);
                        if (autoTradingDataGridView["매매진행_청산", e.RowIndex].Value.Equals("주문취소"))
                        {
                            if (MessageBox.Show("주문취소시 체결수량은 시장가로 청산됩니다.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string itemCode = autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value.ToString().Replace("A", "");
                                int balanceCnt = int.Parse(autoTradingDataGridView["매매진행_매수량", e.RowIndex].Value.ToString());
                                string conditionName = autoTradingDataGridView["매매진행_매수조건식", e.RowIndex].Value.ToString();

                                TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));


                                if (ts != null)
                                {
                                    TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Equals(itemCode));


                                    int orderResult = axKHOpenAPI1.SendOrder("주문취소;" + ts.buyingCondition.name + ";" + itemCode,
                                                    GetScreenNum(),
                                                    ts.account,
                                                    3,
                                                    itemCode,
                                                    0,
                                                    0,
                                                    "",
                                                    ti.buyOrderNum);
                                    Console.WriteLine("주문취소 결과 : " + orderResult.ToString());
                                    if (orderResult == 0)
                                    {

                                        /* autoTradingDataGridView["매매진행_진행상황", e.RowIndex].Value = "주문취소";

                                         autoTradingDataGridView["매매진행_청산", e.RowIndex].Value = "주문취소완료";*/

                                        //ts.remainingItemCount++;

                                    }


                                }
                            }

                           
                        }
                        else if (autoTradingDataGridView["매매진행_청산", e.RowIndex].Value.Equals("청산"))
                        {

                            if (autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value != null)
                            {

                                string itemCode = autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value.ToString().Replace("A", "");
                                int balanceCnt = int.Parse(autoTradingDataGridView["매매진행_매수량", e.RowIndex].Value.ToString());
                                string conditionName = autoTradingDataGridView["매매진행_매수조건식", e.RowIndex].Value.ToString();

                                TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));

                                if (ts != null)
                                {
                                    TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Equals(itemCode));

                                    if (ti.isCompletedBuying && !ti.isSold)
                                    {
                                        int orderResult = axKHOpenAPI1.SendOrder("청산매도주문",
                                                      GetScreenNum(),
                                                      ts.account,
                                                      2,
                                                      itemCode,
                                                      balanceCnt,
                                                      0,
                                                      "03",
                                                      "");

                                        if (orderResult == 0)
                                        {
                                            tryingOrderList.Add(ti);
                                            ti.isSold = true;
                                            autoTradingDataGridView["매매진행_진행상황", e.RowIndex].Value = "청산중";

                                            autoTradingDataGridView["매매진행_청산", e.RowIndex].Value = "청산중...";


                                          /*  //보유종목DataGridView 업데이트
                                            int count = accountBalanceDataGridView.Rows.Count;
                                            Console.WriteLine(count.ToString());
                                            for (int i = 0; i < count; i++)
                                            {
                                                Console.WriteLine("매매진행종목코드 " + autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value.ToString());
                                                Console.WriteLine("보유잔고종목코드 " + accountBalanceDataGridView["계좌잔고_종목코드", i].Value.ToString().Substring(1));
                                                if (autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value.ToString().Equals(accountBalanceDataGridView["계좌잔고_종목코드", i].Value.ToString().Substring(1)))
                                                {
                                                    accountBalanceDataGridView["계좌잔고_청산", i].Value = "청산중...";
                                                }
                                            }*/

                                        }

                                    }
                                }
                            }
                        }
                        else if (autoTradingDataGridView["매매진행_청산", e.RowIndex].Value.Equals("잔고매도취소"))
                        {
                            //MessageBox.Show("잔고매도취소!!!");

                            //balanceSellStrategyList에서 삭제
                            string itemCode = autoTradingDataGridView["매매진행_종목코드", e.RowIndex].Value.ToString();
                            BalanceSellStrategy bss = balanceSellStrategyList.Find(o => o.itemCode.Equals(itemCode));

                            if(bss != null)
                            {
                                balanceSellStrategyList.Remove(bss);
                            }

                            //매매진행상황에서 삭제
                            autoTradingDataGridView.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

            }



            else if (sender.Equals(tradingStrategyDataGridView))
            {

                if (e.ColumnIndex == tradingStrategyDataGridView.Columns["매매전략_취소"].Index &&e.RowIndex >= 0)
                {

                    string conditionName = tradingStrategyDataGridView["매매전략_매수조건식", e.RowIndex].Value.ToString();
                    TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition != null && o.buyingCondition.name.Equals(conditionName));

                    if (ts != null)
                    {
                        DialogResult result = MessageBox.Show(conditionName + "매매조건을 삭제하시겠습니까?", "매매전략 삭제", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //tradingStrategyList.Remove(ts);
                            //ts.buyingCondition.name = ts.buyingCondition.name + ": Complete";
                            ts.usingCondition = false;
                            tradingStrategyDataGridView.Rows.RemoveAt(e.RowIndex);

                            Console.WriteLine("전략삭제screenNum-" + ts.buyingCondition.screenNum);
                            axKHOpenAPI1.SendConditionStop(ts.buyingCondition.screenNum, ts.buyingCondition.name, ts.buyingCondition.index);
                          
                            
                        }

                    }

                }
            }
        }




        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (sender.Equals(accountComboBox)) //계좌번호 선택 시
            {
                if (accountComboBox.SelectedItem != null)
                {
                   

                    string account = accountComboBox.SelectedItem.ToString();

                  /*  if (!account.Equals(currentAccount))
                    {*/

                        currentAccount = account;

                        axKHOpenAPI1.SetInputValue("계좌번호", account);
                        axKHOpenAPI1.SetInputValue("비밀번호", "");
                        axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
                        axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                        axKHOpenAPI1.CommRqData("계좌평가현황요청1;" + account, "OPW00004", 0, GetScreenNum());
                        

                        string date = DateTime.Now.ToString("yyyyMMdd");

                        axKHOpenAPI1.SetInputValue("계좌번호", account);
                        axKHOpenAPI1.SetInputValue("비밀번호", "");
                        axKHOpenAPI1.SetInputValue("기준일자", date);
                        axKHOpenAPI1.SetInputValue("단주구분", "2"); //당일매수에대한 당일매도 : 1, 당일매도전체 : 2
                        axKHOpenAPI1.SetInputValue("현금신용구분", "0");
                        axKHOpenAPI1.CommRqData("당일매매일지요청", "opt10170", 0, GetScreenNum());

                      








                    //}

                }
            }

        }

        
        
        



        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.Equals(loginToolStripMenuItem))
            {
                if (loginToolStripMenuItem.Text.Equals("로그인"))
                {
                    axKHOpenAPI1.CommConnect();
                }
                
                
               
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(createStrategyButton))
            {
               

                foreach (TradingStrategy tradingStrategy in tradingStrategyList)
                {
                    if (tradingStrategy.buyingCondition.name.Equals(buyingConditionComboBox.Text) && tradingStrategy.usingCondition)
                    {
                        MessageBox.Show("같은조건의 매매가 실행중입니다.");
                        return;
                    }

                }

                //매매 계좌
                string account = accountComboBox.Text;
/*
                axKHOpenAPI1.SetInputValue("계좌번호", account);
                axKHOpenAPI1.SetInputValue("비밀번호", "");
                axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
                axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                axKHOpenAPI1.CommRqData("계좌평가현황요청", "OPW00004", 0, GetScreenNum());
*/
                if (account.Length == 0)
                {
                    MessageBox.Show("투자 계좌를 선택해주세요.");
                    return;

                }

                //매수 전략
                string conditionName = buyingConditionComboBox.Text;
                Condition buyingCondition = null; // <- 매수조건식


              
                if (conditionName.Length > 0)
                {
                    buyingCondition = conditionList.Find(o => o.name.Equals(conditionName));
                }
                else //매수 조건이 선택되지 않은 경우
                {

                    MessageBox.Show("매수조건식을 선택해주세요.");
                    return;


                }



                if (buyingCondition == null)
                    return;

                string buyingOrderOption; // <- 호가 옵션

                if (marketPriceRadioButton.Checked)
                    buyingOrderOption = "03";
                else
                {
                    if (buyingOrderOptionComboBox.Text.Equals(""))
                    {
                        MessageBox.Show("지정가 옵션을 선택하세요");
                        return;
                    }else
                        buyingOrderOption = buyingOrderOptionComboBox.Text.Split(':')[0];



                }
                    

                if (investmentNumericUpDown.Value == 0)
                {
                    MessageBox.Show("총 투자금을 설정해주세요.");
                    return;
                }
                else if (investmentNumericUpDown.Value > DEPOSIT)
                {
                    MessageBox.Show("총 투자금액이 예수금액을 초과합니다.");
                    return;
                }

                long totalInvestment = (long)investmentNumericUpDown.Value; // <-총투자금액
                int itemCount = (int)itemCountNumericUpDown.Value; // <--매수 종목 수

                


                //매도 전략
                bool usingTakeProfit = takeProfitCheckBox.Checked; //익절 사용여부 true or false 저장
                double takeProfitRate = 0;

                if (usingTakeProfit)

                {

                    takeProfitRate = (double)takeProfitNumbericUpDown.Value;

                }

                string sellOrderOption;
                if (radioButton1.Checked)
                {
                    sellOrderOption = "03";
                }
                else
                {
                    if (comboBox1.Text.Equals(""))
                    {
                        MessageBox.Show("지정가 옵션을 선택하세요");
                        return;
                    }else
                        sellOrderOption = comboBox1.Text.Split(':')[0];

                }

                bool usingStopLoss = stopLossCheckBox.Checked; //손절 사용 여부 true or false
                double stopLossRate = 0;

                if (usingStopLoss)
                {

                    stopLossRate = (double)stopLossNumericUpDown.Value;


                }

                bool onlyIntest = onlyInterestCheckBox.Checked;

                TradingStrategy ts = new TradingStrategy(account, buyingCondition, buyingOrderOption, totalInvestment, itemCount, usingTakeProfit, takeProfitRate, sellOrderOption, usingStopLoss, stopLossRate, onlyIntest);
                ts.usingCondition = true;
                tradingStrategyList.Add(ts);


                WriteLog("전략 생성 성공 - 매수조건식 :" + ts.buyingCondition.name + "I총투자금 : " + ts.totalInvestment + "I종목수 : " + ts.buyingItemCount);
               

                //매수조건식 감시시작

                StartMonitoring(ts);



            }

            else if (sender.Equals(balanceSellButton))
            {

                string itemCode = balanceItemCodeTextBox.Text;
                string itemName = balanceItemNameTextBox.Text;
                long sellQnt = (long)balanceQntNumericUpDown.Value;
                string accountNum = accountComboBox.Text;
                int buyingPrice = (int)double.Parse(balanceAvgPriceLabel.Text);

                BalanceSellStrategy bs = balanceSellStrategyList.Find(o => o.itemCode.Equals(itemCode));

                string checkList = "";
                
                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                {
                    if (row.Cells["매매진행_진행상황"].Value.Equals("매도완료") && row.Cells["매매진행_매수조건식"].Value.Equals("잔고자동매도"))
                    {
                        checkList += row.Cells["매매진행_종목코드"].Value;
                    }
                }

                if (bs == null || checkList.Contains(bs.itemCode))
                {

                    if (accountNum.Length > 0)
                    {
                        if (itemCode.Length > 0) //종목이 선택된 경우
                        {
                            if (sellQnt > 0)
                            {
                                //매도 전략
                                bool usingTakeProfit = balanceTakeProfitCheckBox.Checked; //익절 사용여부 true or false 저장
                                double takeProfitRate = 0;

                                if (usingTakeProfit)

                                {

                                    takeProfitRate = (double)balanceTakeProfitNumbericUpDown.Value;

                                }

                                string sellOrderOption;

                                if (radioButton4.Checked) 
                                    sellOrderOption = "03";
                                else
                                {
                                    if (comboBox2.Text.Equals(""))
                                        return;
                                    else
                                        sellOrderOption = comboBox2.Text.Split(':')[0];
                                }

                                bool usingStopLoss = balanceStopLossCheckBox.Checked; //손절 사용 여부 true or false
                                double stopLossRate = 0;

                                if (usingStopLoss)
                                {

                                    stopLossRate = (double)balanceStopLossNumericUpDown.Value;


                                }

                                BalanceSellStrategy bss = new BalanceSellStrategy(accountNum, itemCode, itemName, buyingPrice, sellQnt, sellOrderOption, usingTakeProfit, takeProfitRate, usingStopLoss, stopLossRate);

                                balanceSellStrategyList.Add(bss);

                                //MessageBox.Show("전략이 생성되었습니다.");


                                int rowIndex = autoTradingDataGridView.Rows.Add();

                                autoTradingDataGridView["매매진행_진행상황", rowIndex].Value = "매도감시";
                                autoTradingDataGridView["매매진행_종목코드", rowIndex].Value = itemCode;
                                autoTradingDataGridView["매매진행_종목명", rowIndex].Value = itemName;
                                autoTradingDataGridView["매매진행_매수가", rowIndex].Value = buyingPrice;
                                autoTradingDataGridView["매매진행_주문량", rowIndex].Value = balanceQntNumericUpDown.Text;
                                autoTradingDataGridView["매매진행_매수량", rowIndex].Value = 0;
                                autoTradingDataGridView["매매진행_매수조건식", rowIndex].Value = "잔고자동매도";
                                autoTradingDataGridView["매매진행_청산", rowIndex].Value = "잔고매도취소";
                                balanceQntNumericUpDown.Value = 0;



                                //보유종목창 청산 금지
                                foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                                {
                                    if (row.Cells["계좌잔고_종목코드"].Value.ToString().Contains(itemCode))
                                    {
                                        row.Cells["계좌잔고_청산"].Value = "매도등록중";

                                        


                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("매도수량은 0보다 커야됩니다.");

                            }
                        }
                        else
                            MessageBox.Show("매도 종목을 선택해주세요.");
                    }
                    else
                        MessageBox.Show("계좌번호를 선택해주세요.");
                }
                else
                    MessageBox.Show("매도감시중인 종목입니다.");

                
            }
            else if (sender.Equals(AddInterestButton))
            {
                if (interestConditionListBox.SelectedItem != null)
                {
                    string conditionName = interestConditionListBox.SelectedItem.ToString();

                    Condition condition = conditionList.Find(o => o.name.Equals(conditionName));
                    if (condition != null)
                    {
                        string itemName = interestTextBox.Text;
                        StockItem stockItem = stockItemList.Find(o => o.Name.Equals(itemName));

                        if (stockItem != null)
                        {
                            if (!condition.interestItemList.Contains(stockItem))
                            {
                                condition.interestItemList.Add(stockItem);
                                interestItemListBox.Items.Add(stockItem.Name);
                            }

                        }
                    }
                }

                else
                    MessageBox.Show("조건식을 선택해주세요.");
            }
            else if (sender.Equals(SetaccountbalanceBtn))
            {
                if(accountComboBox.SelectedItem != null /*&& outstandingDataGridView.Rows.Count <= 0*/)
                {
                    string account = accountComboBox.SelectedItem.ToString();
                    axKHOpenAPI1.SetInputValue("계좌번호", account);
                    axKHOpenAPI1.SetInputValue("비밀번호", "");
                    axKHOpenAPI1.SetInputValue("상장폐지조회구분", "0");
                    axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
                    axKHOpenAPI1.CommRqData("계좌평가현황요청2", "OPW00004", 0, GetScreenNum());

                    string date = DateTime.Now.ToString("yyyyMMdd");

                    axKHOpenAPI1.SetInputValue("계좌번호", account);
                    axKHOpenAPI1.SetInputValue("비밀번호", "");
                    axKHOpenAPI1.SetInputValue("기준일자", date);
                    axKHOpenAPI1.SetInputValue("단주구분", "2"); //당일매수에대한 당일매도 : 1, 당일매도전체 : 2
                    axKHOpenAPI1.SetInputValue("현금신용구분", "0");
                    axKHOpenAPI1.CommRqData("당일매매일지요청", "opt10170", 0, GetScreenNum());
                }

             
            }
        }

        private void StartMonitoring(TradingStrategy ts)
        {

            //SendCondition - 서버에 조건검색 요청하는 함수
            //응답으로 OnReceiveTrCondition으로 들어오고 실시간 요청시 실시간값은 OnReceiveRealCondition으로 들어온다.

            ts.buyingCondition.screenNum = GetScreenNum();

            int result = axKHOpenAPI1.SendCondition(ts.buyingCondition.screenNum, ts.buyingCondition.name, ts.buyingCondition.index, 1);
            Console.WriteLine("전략생성screenNum-" + ts.buyingCondition.screenNum.ToString());





           /* int result = axKHOpenAPI1.SendCondition(realScreenNum, condition.name, condition.index, 1);*/

            if (result == 1)
            {
                Console.WriteLine(ts.buyingCondition.name + " 감시 요청 성공");
                //매매전략 데이터그리그뷰에 추가
                AddStrategyToDataGridView(ts);

                
            }
            else
            {

                Console.WriteLine(ts.buyingCondition.name + "감시 요청 실패");
                tradingStrategyList.Remove(ts);
                MessageBox.Show("조건식감시요청에 실패했습니다. 잠시후 시도해주세요");
            }
        }

        private void AddStrategyToDataGridView(TradingStrategy ts)
        {

            if (ts != null)
            {

                int rowIndex = tradingStrategyDataGridView.Rows.Add();

                tradingStrategyDataGridView["매매전략_계좌번호", rowIndex].Value = ts.account;
                tradingStrategyDataGridView["매매전략_매수조건식", rowIndex].Value = ts.buyingCondition.name;
                tradingStrategyDataGridView["매매전략_매수가격", rowIndex].Value = ts.buyingOrderOption;
                tradingStrategyDataGridView["매매전략_총투자금", rowIndex].Value = ts.totalInvestment;
                tradingStrategyDataGridView["매매전략_매수종목수", rowIndex].Value = ts.buyingItemCount;
                tradingStrategyDataGridView["매매전략_종목당투자금", rowIndex].Value = ts.itemInvestment;



                tradingStrategyDataGridView["매매전략_익절", rowIndex].Value = ts.usingTakeProfit;
                tradingStrategyDataGridView["매매전략_익절률", rowIndex].Value = ts.takeProfitRate;
                tradingStrategyDataGridView["매매전략_손절", rowIndex].Value = ts.usingStopLoss;
                tradingStrategyDataGridView["매매전략_손절률", rowIndex].Value = ts.stopLossRate;

            }

        }

       

        private void API_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0) //로그인 성공
            {
                WriteLog("로그인 접속 성공");

                //접속 서버 구분
                string server = axKHOpenAPI1.GetLoginInfo("GetServerGubun");
                if (server.Equals("1"))
                {
                    this.FEE = 0.0035;
                    toolStripMenuItem3.Text = "모의투자접속중";
                }
                else toolStripMenuItem3.Text = "실서버접속중";
                    

                //계좌번호 불러오기
                string accList = axKHOpenAPI1.GetLoginInfo("ACCLIST"); //로그인 사용자 계좌번호 리스트 요청
                string[] accountArray = accList.Split(';');

                foreach (string account in accountArray)
                {
                    if (account.Length > 0)
                        accountComboBox.Items.Add(account);

                }


                string codeList = axKHOpenAPI1.GetCodeListByMarket(null);
                string[] codeArray = codeList.Split(';');

                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                foreach (string code in codeArray)
                {

                    string name = axKHOpenAPI1.GetMasterCodeName(code);

                    StockItem stockItem = new StockItem()
                    {
                        Code = code,
                        Name = name

                    };

                    stockItemList.Add(stockItem);
                    collection.Add(name);


                }

                interestTextBox.AutoCompleteCustomSource = collection;
                
                //사용자 조건식 불러오기
                axKHOpenAPI1.GetConditionLoad();


                //timer start
                
                timer.Interval = 1000;
                timer.Start();

                //로그인 -> 로그아웃
                loginToolStripMenuItem.Text = "로그인중입니다.";


                //python server start
                pythonServer_start();


               


            }
            else//로그인 실패
            {
                WriteLog("로그인 접속 실패");
                //MessageBox.Show("로그인 실패");

            }
        }

        void pythonServer_start()
        {
            var path = " D:/EolabAutoTradingSystem_2022-06-22/EolabAutoTradingSystem/EolabAutoTradingSystem/python";
            Console.WriteLine("path : " + path);
            // D:\EolabAutoTradingSystem_2022-06-22\EolabAutoTradingSystem\EolabAutoTradingSystem\bin\Debug
            var pythonFimeName = "server.py";
            run_cmd(path, pythonFimeName);
        }

        void run_cmd(string path, string pythonFile)
        {
            var psi = new ProcessStartInfo
            {
                FileName = @"C:/Users/my/AppData/Local/Programs/Python/Python38-32", // 파이썬 설치 경로
                Arguments = $"\"{path}\\{pythonFile}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var erros = string.Empty;
            var results = string.Empty;

            using (Process process = Process.Start(psi))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    while (!process.HasExited)
                    {
                        Console.WriteLine(reader.ReadLine());
                    }

                    erros = process.StandardError.ReadToEnd();
                    results = process.StandardOutput.ReadToEnd();
                }
            }

            Console.WriteLine(erros);
            Console.WriteLine(results);
        }


        private void API_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {




        }




        private void API_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {

            string conditions = axKHOpenAPI1.GetConditionNameList();

            //000^엘리트 비기 ◆;001^엘리트 단기급등 ◆;003^엘리트 필살기 ◆;002^엘리트 초필살기 ◆;

            string[] conditionArray = conditions.Split(';');

            //000 ^ 엘리트 비기 ◆
            //001 ^ 엘리트 단기급등 ◆
            //003 ^ 엘리트 필살기 ◆


            //conditionList에 조건식 정보 객체 저장
            foreach (string condition in conditionArray)
            {
                if (condition.Length > 0)
                {
                    string[] conditionInfo = condition.Split('^');

                    string index = conditionInfo[0];
                    string name = conditionInfo[1];

                    Condition cd = new Condition(int.Parse(index), name);
                    conditionList.Add(cd);
                }




            }

            //조건식 목록 매수전략 콤보박스 추가




            foreach (Condition condition in conditionList)
            {

                buyingConditionComboBox.Items.Add(condition.name);
                interestConditionListBox.Items.Add(condition.name);
            }

        }

        private void API_OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {


            string itemCode = e.sTrCode;
            string conditionName = e.strConditionName;
            int conditionIndex = int.Parse(e.strConditionIndex);
           

            //Console.WriteLine("e.sTrType = " + e.strType);
            //Console.WriteLine("conditionName = " + conditionName);
            //Console.WriteLine("itemCode = " + itemCode);
            
            string itemName = axKHOpenAPI1.GetMasterCodeName(itemCode);





            if (e.strType.Equals("I")) //종목 편입
            {
                //BCon dbConn = new DBCon();

                //dbcon.InsertDb(itemCode, itemName, "0", conditionName, conditionIndex);
                //List<tradingItems> sscc = dbcon.selectDb("1", itemCode);

                //bool result = sendData(itemCode);

                if (true) //편입종목에 대한 감정분석 리턴값이 true일때
                {
                    TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));

                    if (ts != null)
                    {



                        //Console.WriteLine("남은 매수 가능 종목 수 : " + ts.remainingItemCount);
                        if (ts.remainingItemCount > 0) // 매수 가능 종목 수 > 0
                        {
                            StockItem stockItem = stockItemList.Find(o => o.Code.Equals(itemCode));

                            if (!ts.onlyIntrest || (ts.onlyIntrest && ts.buyingCondition.interestItemList.Contains(stockItem)))
                            {

                                TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Contains(itemCode));


                                //매매 조건식 매매종목리스트에 편입 종목이 존재하지 않을 경우
                                if (ti == null)
                                {
                                    //Console.WriteLine("종목매수 : " + axKHOpenAPI1.GetMasterCodeName(itemCode));
                                    Console.WriteLine("매수가능종목수 : " + ts.remainingItemCount.ToString());
                                    ts.remainingItemCount--; //남은 매수가능 종목수 -1
                                    
                                    //여기서 매수할 종목 가격 요청
                                    axKHOpenAPI1.SetInputValue("종목코드", itemCode);
                                    axKHOpenAPI1.CommRqData("매수종목정보요청;" + ts.buyingCondition.index, "opt10001", 0, GetScreenNum());



                                }
                            }
                        }
                    }

                }
            }

            else if (e.strType.Equals("D")) //종목 이탈
            {
                //dbcon.DeleteDb(itemCode, conditionIndex);



            }

        }

      /*  //감정분석 결과를 보낸후 결과르 돌려받는 socket통신
        private bool sendData(string itemCode)
        {
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                // Connect 함수로 로컬(127.0.0.1)의 포트 번호 9999로 대기 중인 socket에 접속한다.
                client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                // 보낼 메시지를 UTF8타입의 byte 배열로 변환한다.
                //var data = Encoding.UTF8.GetBytes("this message is sent from C# client.");
                var data = Encoding.UTF8.GetBytes(itemCode); //편입종목 매수여부 평가를 위해 server로 전달

                // big엔디언으로 데이터 길이를 변환하고 서버로 보낼 데이터의 길이를 보낸다. (4byte)
                client.Send(BitConverter.GetBytes(data.Length));
                // 데이터를 전송한다.
                client.Send(data);

                // 데이터의 길이를 수신하기 위한 배열을 생성한다. (4byte)
                data = new byte[4];
                // 데이터의 길이를 수신한다.
                client.Receive(data, data.Length, SocketFlags.None);
                // server에서 big엔디언으로 전송을 했는데도 little 엔디언으로 온다. big엔디언과 little엔디언은 배열의 순서가 반대이므로 reverse한다.
                Array.Reverse(data);
                // 데이터의 길이만큼 byte 배열을 생성한다.
                data = new byte[BitConverter.ToInt32(data, 0)];
                // 데이터를 수신한다.
                client.Receive(data, data.Length, SocketFlags.None);
                // 수신된 데이터를 UTF8인코딩으로 string 타입으로 변환 후에 콘솔에 출력한다.
                Console.WriteLine(Encoding.UTF8.GetString(data));

                string result = Encoding.UTF8.GetString(data);
               
                if (result.Equals("0"))
                {
                    return true;
                }
                else return false;
            }


            
        }*/

        private void API_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            Console.WriteLine("sRQName,TR이름 : " + e.sRQName + e.sTrCode);
           


           

            if (e.sRQName.Contains("매수종목정보요청"))
            {
                string[] rqName = e.sRQName.Split(';');
                int conditionIndex = int.Parse(rqName[1]);

              /*  string itemCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                string existItemList = "";*/

             /*   //편입종목이 이미 매수한 종목인지 체크
                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                {
                    if (row.Cells[1].Value.Equals(itemCode))
                    {
                        existItemList += itemCode + "_";
                    }
                }*/

                TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.index == conditionIndex);

                if (ts != null /*&& !existItemList.Contains(itemCode)*/)
                {

                    string itemCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                    string price = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가").Trim();
                    //Console.WriteLine("매수종목정보요청 가격 - " + price);



                    try
                    {

                        int cPrice = Math.Abs(int.Parse(price));
                        int qnt = (int)(ts.itemInvestment / cPrice);
                        if (cPrice > 0)
                        {


                            int orderResult = axKHOpenAPI1.SendOrder(
                                      "편입종목매수;" + ts.buyingCondition.name + ";" + itemCode,
                                      GetScreenNum(),
                                      ts.account, //계좌번호
                                      1, //신규매수
                                      itemCode,
                                      qnt,
                                      cPrice,
                                      ts.buyingOrderOption,
                                      ""
                                      );

                            if (orderResult == 0) //매수주문 요청 성공  시
                            {
                                //주문성공
                                Console.WriteLine("매수 주문 성공!");
                               //ts.remainingItemCount--;
                                Console.WriteLine(ts.remainingItemCount);
                                //매매전략에 매매 진행 종목 등록

                                TradingItem tradingItem = new TradingItem(itemCode, cPrice, qnt);
                                ts.tradingItemList.Add(tradingItem);
                                tryingOrderList.Add(tradingItem);

                                //매수 종목 실시간 가격 등록

                                string fidList = "9001;302;10;11;25;12;13";
                                axKHOpenAPI1.SetRealReg("9001", itemCode, fidList, "1");

                               /* //매매진행 데이터 그리드뷰 표시
                                int rowIndex = autoTradingDataGridView.Rows.Add();
                                autoTradingDataGridView["매매진행_진행상황", rowIndex].Value = "매수중";
                                autoTradingDataGridView["매매진행_종목코드", rowIndex].Value = itemCode;
                                autoTradingDataGridView["매매진행_종목명", rowIndex].Value = axKHOpenAPI1.GetMasterCodeName(itemCode);
                                autoTradingDataGridView["매매진행_매수조건식", rowIndex].Value = ts.buyingCondition.name;
                                autoTradingDataGridView["매매진행_매수금", rowIndex].Value = *//*qnt * cPrice*//*0;
                                autoTradingDataGridView["매매진행_매수량", rowIndex].Value = *//*qnt*//*0;
                                autoTradingDataGridView["매매진행_매수가", rowIndex].Value = cPrice;
                                autoTradingDataGridView["매매진행_매수시간", rowIndex].Value = Dater
                                
                                e.Now.ToString("yyyy-MM-dd HH:mm:ss"); // ex) 2021-09-09 13:05:00
                                autoTradingDataGridView["매매진행_청산", rowIndex].Value = "주문취소";
                                autoTradingDataGridView["매매진행_청산", rowIndex].Style.BackColor = Color.Red;*/




                                WriteLog("자동매수요청 - 종목코드 : " + itemCode + " l 주문가 : " + cPrice + " I 주문수량 : " + qnt + " I 매수조건식: " + ts.buyingCondition.name);

                            }

                        }
                    }


                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.ToString());
                    }
                }
            }

            
            else if (e.sRQName.Contains("계좌평가현황요청1"))
            {

                string account = e.sRQName.Split(';')[1];
                long asset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금"));
                long d2Asset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "D+2추정예수금"));
                //long estimatedAsset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예탁자산평가액"));
                /* long totalinvestment = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자원금"));
                 long totalprofit = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자손익"));
                 long totalprofitRate = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일손익율"));*/
                DEPOSIT = asset;

                assetLabel.Text = String.Format("{0:n0}", asset) + "원";
                d2AssetLabel.Text = String.Format("{0:n0}", d2Asset) + "원";
                //estimatedAssetLabel.Text = String.Format("{0:n0}", estimatedAsset) + "원";
                /*investmentLabel.Text = String.Format("{0:n0}", totalinvestment) + "원";
                profitLabel.Text = String.Format("{0:n0}", totalprofit) + "원";
                profitRateLabel.Text = totalprofitRate.ToString() + "%";*/


        
                string codeList = "";

                string codeList_exist = "";

                int existCount = accountBalanceDataGridView.Rows.Count;

                for (int i = 0; i < existCount; i++)
                {
                    codeList_exist += accountBalanceDataGridView.Rows[i].Cells[0].Value.ToString().Trim() + ";";

                }

                int cnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRecordName);
                //accountBalanceDataGridView.Rows.Clear();

                Console.WriteLine("루프전: " + codeList_exist);
                for (int i = 0; i < cnt; i++)
                {
                    
                    
                    string itemCode = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();
                    string itemName = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();
                    long balanceCount = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "보유수량"));
                    double buyingPrice = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평균단가"));
                    int price = Math.Abs(int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가")));
                    long estimatedAmount = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "평가금액"));
                    long profitAmount = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "손익금액"));
                    long buyingAmount = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "매입금액"));

                    int rowIndex = balanceDataGridView.Rows.Add();
                    balanceDataGridView["잔고_계좌번호", rowIndex].Value = account;
                    balanceDataGridView["잔고_종목코드", rowIndex].Value = itemCode;
                    balanceDataGridView["잔고_종목명", rowIndex].Value = itemName;
                    balanceDataGridView["잔고_보유수량", rowIndex].Value = balanceCount;
                    balanceDataGridView["잔고_주문가능수량", rowIndex].Value = balanceCount;
                    balanceDataGridView["잔고_매입단가", rowIndex].Value = buyingPrice;
                    balanceDataGridView["잔고_총매입가", rowIndex].Value = buyingAmount;
                    balanceDataGridView["잔고_손익률", rowIndex].Value = profitAmount;

                    //보유종목창에 없으면 추가
                    if (!codeList_exist.Contains(itemCode))
                    {
                       
                        codeList += itemCode;
                        if (i != cnt - 1)
                            codeList += ";";

                        double profitRate = ((((price * balanceCount) * (1.00 - TAX) - (balanceCount * FEE) * (price + buyingPrice)) / (buyingPrice * balanceCount)) - 1) * 100;

                        //double profitRate = 100 * (price - buyingPrice) / buyingPrice - TAX;
                        rowIndex = accountBalanceDataGridView.Rows.Add();
                        accountBalanceDataGridView["계좌잔고_종목코드", rowIndex].Value = itemCode;
                        accountBalanceDataGridView["계좌잔고_종목명", rowIndex].Value = itemName;
                        accountBalanceDataGridView["계좌잔고_보유수량", rowIndex].Value = balanceCount;
                        accountBalanceDataGridView["계좌잔고_평균단가", rowIndex].Value = buyingPrice;
                        accountBalanceDataGridView["계좌잔고_손익금액", rowIndex].Value = profitAmount;
                        accountBalanceDataGridView["계좌잔고_평가금액", rowIndex].Value = estimatedAmount;
                        accountBalanceDataGridView["계좌잔고_매입금액", rowIndex].Value = buyingAmount;

                        accountBalanceDataGridView["계좌잔고_손익률", rowIndex].Value = profitRate;
                    }
                    //보유종목창에 있으면 정보 수정
                    else if (codeList_exist.Contains(itemCode))
                    {
                        Console.WriteLine("리스트 제거");
                        codeList_exist = codeList_exist.Replace(itemCode + ";", "").Trim();

                        foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                        {
                            if (itemCode.Equals(row.Cells["계좌잔고_종목코드"].Value.ToString().Trim()))
                            {
                                row.Cells["계좌잔고_보유수량"].Value = balanceCount;
                                row.Cells["계좌잔고_평균단가"].Value = buyingPrice;
                                row.Cells["계좌잔고_손익금액"].Value = profitAmount;
                                row.Cells["계좌잔고_평가금액"].Value = estimatedAmount;
                                row.Cells["계좌잔고_매입금액"].Value = buyingAmount;
                            }
                        }

                    }
                    
                }
                
                //루프 다 돌고 난후 codeList_exist에 종목코드정보가 있으면 삭제
                if(codeList_exist.Length >= 6)
                {
                    Console.WriteLine("코드 존재시: " + codeList_exist);
                    foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                    {
                        if (codeList_exist.Contains(row.Cells["계좌잔고_종목코드"].Value.ToString().Trim()))
                        {
                            accountBalanceDataGridView.Rows.Remove(row);
                        } 
                    }
                }

                //보유 종목들 실시간 가격 요청
                string fidList = "9001;302;10;11;25;12;13";
                axKHOpenAPI1.SetRealReg("9002", codeList, fidList, "1");


               

                


            }

            else if (e.sRQName.Equals("계좌평가현황요청2"))
            {
                long asset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금"));
                long d2Asset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "D+2추정예수금"));
                //long estimatedAsset = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예탁자산평가액"));
                /* long totalinvestment = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자원금"));
                 long totalprofit = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일투자손익"));
                 long totalprofitRate = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "당일손익율"));*/
                DEPOSIT = asset;

                assetLabel.Text = String.Format("{0:n0}", asset) + "원";
                d2AssetLabel.Text = String.Format("{0:n0}", d2Asset) + "원";
                //estimatedAssetLabel.Text = String.Format("{0:n0}", estimatedAsset) + "원";
                /*investmentLabel.Text = String.Format("{0:n0}", totalinvestment) + "원";
                profitLabel.Text = String.Format("{0:n0}", totalprofit) + "원";
                profitRateLabel.Text = totalprofitRate.ToString() + "%";*/
            }

            else if (e.sRQName.Equals("당일매매일지요청"))
            {
                long totalSellPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매도금액"));
                long totalBuyPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매수금액"));
                long totalFee = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총수수료_세금"));
                long totalCalPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총정산금액"));
                long totalProfitPrice = long.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총손익금액"));
                double totalProfitRate = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총수익률"));


                investmentLabel.Text = String.Format("{0:n0}", totalSellPrice) + "원";
                profitLabel.Text = String.Format("{0:n0}", totalProfitPrice) + "원";
                profitRateLabel.Text = totalProfitRate.ToString() + "%";
            }

            else if (e.sRQName.Contains("편입종목매수"))
            {
                string buyOrderNum = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문번호");
                if(buyOrderNum != "")
                {
                    string itemCode = e.sRQName.Split(';')[2];
                    string mesuQnt = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문량").Trim();

                    string conditionName = e.sRQName.Split(';')[1];
                    Console.WriteLine(conditionName);

                    TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));
                    
                    if(ts != null)
                    {
                        TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Equals(itemCode));
                        ti.buyOrderNum = buyOrderNum;
                    }

                    foreach(TradingItem t in ts.tradingItemList)
                    {
                        Console.WriteLine("종목코드: " + t.itemCode);
                        Console.WriteLine("주문가: " + t.buyingPrice);
                        Console.WriteLine("주문량: " + t.buyingQnt);
                        Console.WriteLine("매수주문번호: " + t.buyOrderNum);
                        Console.WriteLine("매도주문번호: " + t.sellOrderNum);
                    }

                    //매매진행 데이터 그리드뷰 표시
                    int rowIndex = autoTradingDataGridView.Rows.Add();
                    autoTradingDataGridView["매매진행_진행상황", rowIndex].Value = "매수주문요청";
                    autoTradingDataGridView["매매진행_종목코드", rowIndex].Value = itemCode;
                    autoTradingDataGridView["매매진행_종목명", rowIndex].Value = axKHOpenAPI1.GetMasterCodeName(itemCode);
                    autoTradingDataGridView["매매진행_매수조건식", rowIndex].Value = conditionName;
                    autoTradingDataGridView["매매진행_주문량", rowIndex].Value = 0;
                    autoTradingDataGridView["매매진행_매수금", rowIndex].Value = 0;
                    autoTradingDataGridView["매매진행_매수량", rowIndex].Value = 0;
                    autoTradingDataGridView["매매진행_매수가", rowIndex].Value = 0;
                    autoTradingDataGridView["매매진행_매수시간", rowIndex].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // ex) 2021-09-09 13:05:00
                    autoTradingDataGridView["매매진행_청산", rowIndex].Value = "주문취소";
                    autoTradingDataGridView["매매진행_청산", rowIndex].Style.BackColor = Color.Red;
                }
                /*else
                {
                    foreach(DataGridViewRow row in autoTradingDataGridView.Rows)
                    {
                        if (e.sRQName.Contains(row.Cells["매매진행_매수조건식"].Value.ToString()) && e.sRQName.Contains(row.Cells["매매진행_종목코드"].Value.ToString()))
                        {
                            autoTradingDataGridView.Rows.Remove(row);
                        }
                    }
                }*/
              
            }

            else if (e.sRQName.Contains("주문취소"))
            {
                //손절,익절 확인 후 실행
                string orderNum = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문번호");
                
                //주문번호가 있으면 취소주문 성공
                if(orderNum != "")
                {
                    string itemCode = e.sRQName.Split(';')[2];
                    string conditionName = e.sRQName.Split(';')[1];
                    string meduCondition = e.sRQName.Split(';')[0].Substring(4);

                    TradingStrategy ts = tradingStrategyList.Find(o => o.buyingCondition.name.Equals(conditionName));
                    TradingItem ti = ts.tradingItemList.Find(o => o.itemCode.Equals(itemCode));
                    ti.cancleOrderNum = orderNum;
                    ti.medoCondition = meduCondition; //손절 or 익절
                }
               
            }

            else if (e.sRQName.Contains("잔고"))
            {
                string orderNum = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문번호");

                string itemCode = e.sRQName.Split(';')[1];

                if(orderNum != "")
                {
                    BalanceSellStrategy bss = balanceSellStrategyList.Find(o => o.itemCode.Equals(itemCode));
                    bss.orderNum = orderNum;
                }
            }

            else if (e.sRecordName.Contains("장마감청산"))
            {
                string orderNum = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "주문번호");
                if(orderNum != "")
                {
                    
                }
            }
        }

        private void API_OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {
            //전달 정보: 특정 주문에 대한 접수/체결/잔고
            //전달되지 않는 정보 : 어떤 매매전략으로 한 주문인가?
          

            if (e.sGubun.Equals("0")) //접숙 혹은 체결
            {
                
                //Console.WriteLine("접수 or 체결");
                string account = axKHOpenAPI1.GetChejanData(9201); //계좌번호
                string orderNumber = axKHOpenAPI1.GetChejanData(9203); //주문번호
                string itemCode = axKHOpenAPI1.GetChejanData(9001); //종목코드
                string orderState = axKHOpenAPI1.GetChejanData(913); //주문상태
                string itemName = axKHOpenAPI1.GetChejanData(302).Trim(); //종목명
                string orderQuantity = axKHOpenAPI1.GetChejanData(900); //주문수량
                string orderPrice = axKHOpenAPI1.GetChejanData(901); //주문가격
                string outstanding = axKHOpenAPI1.GetChejanData(902); //미체결수량
                string orderType = axKHOpenAPI1.GetChejanData(905); //주문구분
                string tradingType = axKHOpenAPI1.GetChejanData(906); //매매구분
                string time = axKHOpenAPI1.GetChejanData(908); //주문 혹은 체결시간
                string conclusionPrice = axKHOpenAPI1.GetChejanData(910); //누적평균체결가
                string conclusionPrice_unit = axKHOpenAPI1.GetChejanData(914); // 단위 체결가
                string conclusionQuantity = axKHOpenAPI1.GetChejanData(911); //체결량
                string unitConclusionQnt = axKHOpenAPI1.GetChejanData(915); //단위체결량
                string price = axKHOpenAPI1.GetChejanData(10); //현재가
                string orderNumber_pre = axKHOpenAPI1.GetChejanData(904); // 원주문번호 주문취소, 정정시 사용

                Console.WriteLine("주문량 : " + orderQuantity + " 체결가 : " + conclusionPrice + " 체결량: " + conclusionQuantity + " 미체결량: " + outstanding);

                Console.WriteLine("주문상태:" + orderState + " 주문구분: " + orderType + " 매매구분 : " + tradingType);
                Console.WriteLine("주문번호: " + orderNumber + " 원주문번호: " + orderNumber_pre);

                if (orderState.Equals("접수"))
                {
                   /* Console.WriteLine("종목코드 : " + itemCode);
                    Console.WriteLine("종목명 : " + itemName);
                    Console.WriteLine("미체결수량 : " + outstanding);
                    Console.WriteLine("주문번호 : " + orderNumber);
                    Console.WriteLine("원주문번호 : " + orederNumber_pre);*/
                    //주문번호, 계좌, 시간, 종목코드, 종목명, 주문수량, 주문가격, 매도/매수 구분, 주문 구분
                    //acount, orderNumber, itemCode, itemName, orderQuantity, orderPrice, orderType, tradingType, time,
                    
                  

                    TradingItem ti = tryingOrderList.Find(o => itemCode.Contains(o.itemCode));
                    Console.WriteLine("ti == null??" + (ti == null).ToString());

                    

                    if (ti != null)
                    {
                        if (orderType.Contains("매수")) 
                        {
                            if(int.Parse(outstanding) != 0)
                            {
                                ti.buyOrderNum = orderNumber;
                                tryingOrderList.Remove(ti);

                                WriteLog("자동매수접수 - 종목코드 : " + itemCode + "l 주문번호 : " + orderNumber);
                            }
                            else if(int.Parse(outstanding) == 0) //미체결량 0이면 매수주문취소 미체결클리어신호
                            {
                                //여기로 주문취소 클리어신호 들어올시 체결수량이 x 이므로 손절, 익절 필요x
                                //주문가능수량만 +, 매매진행상화 업데이트
                                Console.WriteLine("testtest1");
                                foreach (TradingStrategy ts in tradingStrategyList)
                                {
                                    Console.WriteLine("testtest2");
                                    TradingItem tii = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(axKHOpenAPI1.GetChejanData(904).ToString()));
                                    if (tii != null)
                                    {
                                        Console.WriteLine("testtest3");
                                        

                                        //매매진생상황 데이터그리드뷰 진행상황 갱신
                                        foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                        {
                                            Console.WriteLine("testtest4");
                                            if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                            {
                                                Console.WriteLine("testtest5");
                                                row.Cells["매매진행_진행상황"].Value = "주문취소";
                                                row.Cells["매매진행_청산"].Value = "주문취소완료";
                                                row.Cells["매매진행_청산"].Style.BackColor = Color.White;
                                                ts.remainingItemCount++;
                                                ti.isCompletedBuying = true;
                                                break;

                                            }
                                        }
                                        break;

                                    }
                                }

                            }
                           

                        }
                        else if (orderType.Contains("매도") && ti.sellOrderNum != null)
                        {

                            ti.sellOrderNum = orderNumber;
                            
                            tryingOrderList.Remove(ti);

                            WriteLog("자동매도접수 - 종목코드 : " + itemCode + "l 주문번호 : " + orderNumber);
                            /*SettlementItem settlementItem = new SettlementItem(currentAccount, itemCode, int.Parse(orderQuantity));
                            settlementItem.sellOrderNum = orderNumber;
                            settleItemList.Add(settlementItem);*/

                            SettlementItem si = settleItemList.Find(o => itemCode.Contains(o.itemCode));
                            //si.sellOrderNum = orderNumber;
                            
                                
                        }
                    }
                    else
                    {

                        BalanceSellStrategy bss = tryingSellList.Find(o => o.itemCode.Contains(o.itemCode));

                        if (bss != null && int.Parse(outstanding) != 0)
                        {
                            bss.orderNum = orderNumber;
                            tryingSellList.Remove(bss);

                        }
                        else if(bss == null && int.Parse(outstanding) != 0)
                        {
                            SettlementItem item = tryingSettleList.Find(o => itemCode.Contains(o.itemCode));
                            if (item != null)
                            {
                                item.sellOrderNum = orderNumber;
                                tryingSettleList.Remove(item);

                            }
                        }
                        else if(int.Parse(outstanding) == 0)
                        {
                            //여기로 주문취소 클리어신호 들어올시 체결수량이 x 이므로 손절, 익절 필요x
                            //주문가능수량만 +, 매매진행상화 업데이트
                         
                            foreach (TradingStrategy ts in tradingStrategyList)
                            {
                             
                                TradingItem tii = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(orderNumber));
                                if (tii != null)
                                {
                                    

                                    //매매진생상황 데이터그리드뷰 진행상황 갱신
                                    foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                    {
                                     
                                        if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(tii.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                        {
                                            ;
                                            row.Cells["매매진행_진행상황"].Value = "주문취소";
                                            row.Cells["매매진행_청산"].Value = "주문취소완료";
                                            row.Cells["매매진행_청산"].Style.BackColor = Color.White;
                                            ts.remainingItemCount++;
                                            break;

                                        }
                                    }
                                    break;

                                }
                            }
                        }
                    }

                    int rowIndex = orderDataGridView.Rows.Add();
                    orderDataGridView["주문_주문번호", rowIndex].Value = orderNumber;
                    orderDataGridView["주문_계좌번호", rowIndex].Value = account;
                    orderDataGridView["주문_시간", rowIndex].Value = time;
                    orderDataGridView["주문_종목코드", rowIndex].Value = itemCode;
                    orderDataGridView["주문_종목명", rowIndex].Value = itemName;
                    orderDataGridView["주문_주문량", rowIndex].Value = orderQuantity;
                    orderDataGridView["주문_주문가", rowIndex].Value = orderPrice;
                    orderDataGridView["주문_매매구분", rowIndex].Value = orderType;
                    orderDataGridView["주문_가격구분", rowIndex].Value = tradingType;

                    //미체결 데이터그리드뷰에 추가
                    if (!orderType.Contains("매수취소") && int.Parse(outstanding) != 0)
                    {
                        int index = outstandingDataGridView.Rows.Add();
                        outstandingDataGridView["미체결_주문번호", index].Value = orderNumber;
                        outstandingDataGridView["미체결_종목코드", index].Value = itemCode;
                        outstandingDataGridView["미체결_종목명", index].Value = itemName;
                        outstandingDataGridView["미체결_주문수량", index].Value = orderQuantity;
                        outstandingDataGridView["미체결_미체결량", index].Value = outstanding;
                        outstandingDataGridView["미체결_매매구분", index].Value = orderType;
                    }
                    else if(int.Parse(outstanding) == 0)
                    {
                        foreach (DataGridViewRow row in outstandingDataGridView.Rows)
                        {
                            if (row.Cells["미체결_주문번호"].Value != null)
                            {
                                if (row.Cells["미체결_주문번호"].Value.ToString().Equals(orderNumber))
                                {
                                    //기존 매수주문 미체결정보 삭제
                                    outstandingDataGridView.Rows.Remove(row);
                                    break;
                                }

                            }



                        }
                    }
                   
                    
                    


                }

                else if (orderState.Equals("체결"))
                {
                   
                  

                    //매수주문 체결이 일어날때마다 매매진행상황 업데이트 list 업데이트
                    if (orderType.Equals("+매수") && conclusionQuantity != "")
                    {
                        foreach(TradingStrategy ts in tradingStrategyList)
                        {
                            TradingItem ti = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(orderNumber));
                            
                            if(ti != null)
                            {
                                ti.buyingPrice = int.Parse(conclusionPrice); //누적평균체결가
                                ti.buyingQnt = int.Parse(conclusionQuantity);//체결량



                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {
                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                    {
                                        row.Cells["매매진행_주문량"].Value = orderQuantity;
                                        row.Cells["매매진행_매수금"].Value = ti.buyingPrice * ti.buyingQnt;
                                        row.Cells["매매진행_매수량"].Value = ti.buyingQnt;
                                        row.Cells["매매진행_매수가"].Value = ti.buyingPrice;

                                        if (int.Parse(outstanding) == 0)
                                        {
                                            row.Cells["매매진행_진행상황"].Value = "매수완료";
                                            row.Cells["매매진행_청산"].Value = "청산";
                                            row.Cells["매매진행_청산"].Style.BackColor = Color.White;
                                            ti.isCompletedBuying = true;
                                            break;
                                        }
                                        else
                                        {
                                            row.Cells["매매진행_진행상황"].Value = "매수중";
                                          
                                            break;
                                        }
                                       

                                    }
                                }
                                break;
                            }
                        }

                      
                    }

                    if(orderType.Equals("+매수") && int.Parse(outstanding) == 0 && conclusionQuantity.Equals("")) //체결량이 존재할때 주문취소 미체결클리어신호
                    {
                        //매매진행 업데이트
                        foreach (TradingStrategy ts in tradingStrategyList)
                        {
                            TradingItem ti = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(orderNumber));
                            if (ti != null)
                            {

                                //매매진생상황 데이터그리드뷰 진행상황 갱신
                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {
                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                    {
                                        row.Cells["매매진행_진행상황"].Value = "매도대기";
                                        row.Cells["매매진행_청산"].Value = "주문취소완료";
                                        row.Cells["매매진행_청산"].Style.BackColor = Color.White;
                                        break;

                                    }
                                }
                                break;

                            }
                        }


                        //미체결 dataGridView 정보 update


                        foreach (DataGridViewRow row in outstandingDataGridView.Rows)
                        {
                            if (row.Cells["미체결_주문번호"].Value != null)
                            {
                                if (row.Cells["미체결_주문번호"].Value.ToString().Equals(axKHOpenAPI1.GetChejanData(904).ToString()))
                                {
                                    //기존 매수주문 미체결정보 삭제
                                    outstandingDataGridView.Rows.Remove(row);
                                    break;
                                }

                                row.Cells["미체결_미체결량"].Value = outstanding;

                                if (int.Parse(outstanding) == 0)
                                {
                                    outstandingDataGridView.Rows.Remove(row);
                                }
                                break;

                            }



                        }


                        
                        foreach (TradingStrategy ts in tradingStrategyList)
                        {
                            TradingItem ti = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(orderNumber));

                            if (ti != null)
                            {
                                //잔량에 대한 익절/손절주문
                                //매도주문
                                if (DialogResult == 0)
                                {
                                    Console.WriteLine("testtesttt");
                                    Console.WriteLine("계좌번호: " + account);
                                    Console.WriteLine("매도수량: " + ti.buyingQnt);
                                    Console.WriteLine("종목코드: " + ti.itemCode);
                                    Console.WriteLine("가격: " + Math.Abs(int.Parse(price)));
                                   
                                    int orderResult = axKHOpenAPI1.SendOrder(
                                   "종목" + ti.medoCondition + "매도",
                                   GetScreenNum(),
                                   account, //계좌번호
                                   2, //신규매도
                                   ti.itemCode,
                                   ti.buyingQnt,
                                   Math.Abs(int.Parse(price)),
                                   ts.sellOrderOption,
                                   ""
                                   );
                                    Console.WriteLine("손/익절 주문결과: " + orderResult);

                                    if (orderResult == 0) //매도 주문 요청 성공시
                                    {
                                        Console.WriteLine(ti.medoCondition +  " 주문 요청 성공");

                                        tryingOrderList.Add(ti);
                                        ti.isSold = true;
                                        ti.isCompletedBuying = true;

                                        //매매진행상황 데이터그리드뷰 진행상황 갱신
                                        
                                        foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                        {
                                            Console.WriteLine("진행상황 종목코드 : " + row.Cells["매매진행_종목코드"].Value.ToString());
                                            Console.WriteLine("매도주문종목코드 : " + itemCode);
                                            Console.WriteLine("매매진행 조건식 : " + row.Cells["매매진행_매수조건식"].Value.ToString());
                                            Console.WriteLine("매도주문해당조건식 :" + ts.buyingCondition.name);
                                            if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(itemCode.Replace("A", "").Trim()) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                            {
                                                row.Cells["매매진행_진행상황"].Value = ti.medoCondition +  " 매도중";
                                                break;
                                            }
                                        }

                                        WriteLog("자동익절매도요청 - 종목코드 : " + itemCode + " I 주문가: " + price + " I 주문수량: " + ti.buyingQnt);
                                    }
                                }



                               
                            }
                        }

                      
                    }

                    if (int.Parse(outstanding) == 0 && conclusionQuantity != "")
                    {

                      

                        
                        if (orderType.Contains("매도"))
                        {
                            //자동매매 진행중인 종목 매도
                            foreach (TradingStrategy ts in tradingStrategyList)
                            {
                                Console.WriteLine("자동매매 진행중 매도");
                                TradingItem ti = ts.tradingItemList.Find(o => o.sellOrderNum.Equals(orderNumber));
                                if (ti != null)
                                {
                                    
                                    //매매진생상황 데이터그리드뷰 진행상황 갱신
                                    foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                    {
                                        if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                        {
                                           
                                            if (row.Cells["매매진행_진행상황"].Value.ToString() != "주문취소")
                                            {
                                                
                                                ts.remainingItemCount++;
                                            }
                                            row.Cells["매매진행_진행상황"].Value = "매도완료";
                                            Console.WriteLine("매수가능종목수 : " + ts.remainingItemCount.ToString());
                                            row.Cells["매매진행_매도가"].Value = conclusionPrice;
                                            //row.Cells["매매진행_손익률"].Value = ;
                                            row.Cells["매매진행_매도시간"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                            row.Cells["매매진행_청산"].Value = "매도완료";

                                            break;
                                            //보유종목 row 삭제
                                            
                                            

                                            //break;

                                        }
                                    }

                                   

                                    break;

                                }
                                //
                            }

                            //보유 잔고 매도 
                            BalanceSellStrategy bss = balanceSellStrategyList.Find(o => o.orderNum.Equals(orderNumber));
                            
                            if (bss != null)
                            {
                                Console.WriteLine("보유잔고매도!!!");

                                foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                                {
                                    if (row.Cells["계좌잔고_종목코드"].Value != null && row.Cells["계좌잔고_종목코드"].Value.ToString().Contains(bss.itemCode))
                                    {
                                        int qnt = int.Parse(row.Cells["계좌잔고_보유수량"].Value.ToString());
                                        qnt = qnt - (int)bss.sellQnt;

                                        if (qnt > 0)
                                        {
                                            row.Cells["계좌잔고_보유수량"].Value = qnt;
                                            row.Cells["계좌잔고_청산"].Value = null;
                                           

                                        }
                                        else
                                            accountBalanceDataGridView.Rows.Remove(row);

                                        break;

                                    }

                                }



                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {

                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(bss.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals("잔고자동매도"))
                                    {
                                        row.Cells["매매진행_진행상황"].Value = "잔고매도완료";
                                        row.Cells["매매진행_매도가"].Value = conclusionPrice;
                                        row.Cells["매매진행_매도시간"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                        row.Cells["매매진행_청산"].Value = "잔고매도완료";

                                        

                                    }
                                }

                                //보유잔고매도 완료햇으므로 리스트에서 삭제
                                balanceSellStrategyList.Remove(bss);

                            }


                            //청산 진행중인 종목 매도
                            Console.WriteLine("아이템코드2 : " + itemCode.ToString().Substring(1));
                            SettlementItem settlementItem = settleItemList.Find(o => o.itemCode.Equals(itemCode));
                            if(settlementItem == null)
                            {
                                settlementItem = settleItemList.Find(o => o.itemCode.Equals(itemCode.Replace("A", "").Trim()));
                            }
                            //Console.WriteLine(settlementItem.itemCode.ToString());
                            if (settlementItem != null)
                            {
                                Console.WriteLine("청산 진행중 매도");
                                foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                                {
                                    if (row.Cells["계좌잔고_종목코드"].Value != null)
                                    {
                                        if (row.Cells["계좌잔고_종목코드"].Value.ToString().Contains(settlementItem.itemCode))
                                        {
                                            accountBalanceDataGridView.Rows.Remove(row);
                                            //청산중인 리스트에서 삭제
                                            for (int i = 0; i < settleItemList.Count; i++)
                                            {
                                                
                                                if (itemCode.Replace("A", "").Trim().Equals(settleItemList[i].itemCode))
                                                {

                                                    settleItemList.RemoveAt(i);


                                                }
                                            }
                                            break;

                                        }

                                    }
                                }
                            }
                           

                        }

                       
                    }
                    
                    //주문취소
                   /* else if((int.Parse(outstanding) == 0 && conclusionQuantity == "")){
                        if (orderType.Contains("매수"))
                        {

                            foreach (TradingStrategy ts in tradingStrategyList)
                            {
                                TradingItem ti = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(orderNumber));
                                if (ti != null)
                                {
  
                                    //매매진생상황 데이터그리드뷰 진행상황 갱신
                                    foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                    {
                                        if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                        {
                                            row.Cells["매매진행_진행상황"].Value = "주문취소";
                                            row.Cells["매매진행_청산"].Value = "주문취소완료";
                                            ts.remainingItemCount++;
                                            break;

                                        }
                                    }
                                    break;

                                }
                            }
                            //

                        }
                    }*/

                    //주문번호, 시간, 종목코드, 종목명, 주문량, 체결량, 단위체결량, 체결가, 매수매도구분

                    int rowIndex = conclusionDataGridView.Rows.Add();

                    conclusionDataGridView["체결_주문번호", rowIndex].Value = orderNumber;
                    conclusionDataGridView["체결_체결시간", rowIndex].Value = time;
                    conclusionDataGridView["체결_종목코드", rowIndex].Value = itemCode;
                    conclusionDataGridView["체결_종목명", rowIndex].Value = itemName;
                    conclusionDataGridView["체결_주문량", rowIndex].Value = orderQuantity;
                    conclusionDataGridView["체결_단위체결량", rowIndex].Value = unitConclusionQnt;
                    conclusionDataGridView["체결_누적체결량", rowIndex].Value = conclusionQuantity;
                    conclusionDataGridView["체결_체결가", rowIndex].Value = conclusionPrice;
                    conclusionDataGridView["체결_매매구분", rowIndex].Value = orderType;
                   
                  

                    //미체결 dataGridView 정보 update


                    foreach (DataGridViewRow row in outstandingDataGridView.Rows)
                    {
                        if (row.Cells["미체결_주문번호"].Value != null && row.Cells["미체결_주문번호"].Value.ToString().Equals(orderNumber))
                        {
                            row.Cells["미체결_미체결량"].Value = outstanding;

                            if (int.Parse(outstanding) == 0)
                            {


                                outstandingDataGridView.Rows.Remove(row);
                            }
                            break;

                        }

                    }

                }
                else if (orderState.Equals("확인") && axKHOpenAPI1.GetChejanData(904).ToString() != "")
                {
                   /* foreach (TradingStrategy ts in tradingStrategyList)
                    {
                        TradingItem ti = ts.tradingItemList.Find(o => o.buyOrderNum.Equals(axKHOpenAPI1.GetChejanData(904).ToString()));
                        if (ti != null)
                        {

                            //매매진생상황 데이터그리드뷰 진행상황 갱신
                            foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                            {
                                if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(ti.itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                {
                                    row.Cells["매매진행_진행상황"].Value = "주문취소";
                                    row.Cells["매매진행_청산"].Value = "주문취소완료";
                                    row.Cells["매매진행_청산"].Style.BackColor = Color.White;
                                    ts.remainingItemCount++;
                                    break;

                                }
                            }
                            break;

                        }
                    }


                    //미체결 dataGridView 정보 update


                    foreach (DataGridViewRow row in outstandingDataGridView.Rows)
                    {
                        if (row.Cells["미체결_주문번호"].Value != null)
                        {
                            if (row.Cells["미체결_주문번호"].Value.ToString().Equals(axKHOpenAPI1.GetChejanData(904).ToString()))
                            {
                                //기존 매수주문 미체결정보 삭제
                                outstandingDataGridView.Rows.Remove(row);
                                break;
                            }

                            row.Cells["미체결_미체결량"].Value = outstanding;

                            if (int.Parse(outstanding) == 0)
                            {
                                outstandingDataGridView.Rows.Remove(row);
                            }
                            break;

                        }



                    }*/
                }

            } //접수와 체결

                
            


            else if (e.sGubun.Equals("1")) //잔고 전달(잔고변경)
            {   

                Console.WriteLine("잔고전달");
                string account = axKHOpenAPI1.GetChejanData(9201); //계좌번호
                string itemCode = axKHOpenAPI1.GetChejanData(9001); //종목코드
                string itemName = axKHOpenAPI1.GetChejanData(302); //종목명
                string balanceQnt = axKHOpenAPI1.GetChejanData(930); // 보유수량
                string buyingPrice = axKHOpenAPI1.GetChejanData(931); //매입단가
                string totalBuyingPrice = axKHOpenAPI1.GetChejanData(932); //총매입가
                string orderAvailableQnt = axKHOpenAPI1.GetChejanData(933); //주문가능수량
                //string tradingType = axKHOpenAPI1.GetChejanData(946); //매매구분
                string profitRate = axKHOpenAPI1.GetChejanData(8019); // 손익률


                bool hasItem = false;
                foreach (DataGridViewRow row in balanceDataGridView.Rows)
                {
                    if (row.Cells["잔고_종목코드"].Value != null && row.Cells["잔고_종목코드"].Value.ToString().Equals(itemCode))
                    {

                        hasItem = true;

                        if (int.Parse(balanceQnt) > 0)
                        {
                            row.Cells["잔고_보유수량"].Value = balanceQnt;
                            row.Cells["잔고_주문가능수량"].Value = orderAvailableQnt;
                            row.Cells["잔고_매입단가"].Value = buyingPrice;
                            row.Cells["잔고_총매입가"].Value = totalBuyingPrice;
                            row.Cells["잔고_손익률"].Value = profitRate;
                        }
                        else
                        {

                            balanceDataGridView.Rows.Remove(row);


                        }
                        break;
                    }


                }

                if (!hasItem)
                {

                    int rowIndex = balanceDataGridView.Rows.Add();
                    balanceDataGridView["잔고_계좌번호", rowIndex].Value = account;
                    balanceDataGridView["잔고_종목코드", rowIndex].Value = itemCode;
                    balanceDataGridView["잔고_종목명", rowIndex].Value = itemName;
                    balanceDataGridView["잔고_보유수량", rowIndex].Value = balanceQnt;
                    balanceDataGridView["잔고_주문가능수량", rowIndex].Value = orderAvailableQnt;
                    balanceDataGridView["잔고_매입단가", rowIndex].Value = buyingPrice;
                    balanceDataGridView["잔고_총매입가", rowIndex].Value = totalBuyingPrice;
                    balanceDataGridView["잔고_손익률", rowIndex].Value = profitRate;
                    //balanceDataGridView["잔고_매매구분", rowIndex].Value = tradingType;
                }

            }


        }
        

        

        
       


        private void API_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {


            string itemCode = e.sRealKey.Trim();
            //Console.WriteLine("실시간데이터 : " + itemCode);
            if (e.sRealType.Equals("주식체결"))
            {
                string cPrice = axKHOpenAPI1.GetCommRealData(itemCode, 10);
                string lowPrice = axKHOpenAPI1.GetCommRealData(itemCode, 18);
                string openPrice = axKHOpenAPI1.GetCommRealData(itemCode, 16);
                string mesurate = axKHOpenAPI1.GetCommRealData(itemCode, 129);

               
               
                
          
                


                long cPrice_long = Math.Abs(long.Parse(cPrice)); //현재가

                //종목 -> 매매 전략 검색 
                foreach (TradingStrategy ts in tradingStrategyList)
                {




                    List<TradingItem> tiList = ts.tradingItemList.FindAll(o => o.itemCode.Equals(itemCode));
                    if (tiList != null && tiList.Count > 0) //매매진행 종목을 찾았을 경우
                    {
                        foreach (TradingItem ti in tiList)
                        {
                            //Console.WriteLine("매매종목 검사" + ti.itemCode);
                            if (/*ti.isCompletedBuying &&*/ !ti.isSold) // ti.isSold == false
                            {

                                //realProfitRate : 실시간 손익률
                                // 손익률 : ((현재가 - 매입단가)/매입단가) * 100
                                int orderResult = -1;

                                if (ti.buyingPrice != 0)
                                {

                                    //double realProfitRate = ((cPrice_long - ti.buyingPrice) / (double)ti.buyingPrice) * 100;
                                    double realProfitRate = ((((cPrice_long * 1) * (1.00 - TAX) - (1 * FEE) * (cPrice_long + ti.buyingPrice)) / (ti.buyingPrice * 1)) - 1) * 100;

                                    //Console.WriteLine("실시간 손익률: " + realProfitRate);
                                    if (ts.usingTakeProfit)  //익절 사용 시 
                                    {
                                        if (realProfitRate >= ts.takeProfitRate)  //익절률 돌파  //ts : 매매전략 //takeProfitRate : 익절률
                                        {
                                            if (!ti.isCompletedBuying)
                                            {
                                                //주문취소

                                                int result = axKHOpenAPI1.SendOrder("주문취소익절;" + ts.buyingCondition.name + ";" + itemCode,
                                                                GetScreenNum(),
                                                                ts.account,
                                                                3,
                                                                itemCode,
                                                                0,
                                                                0,
                                                                "",
                                                                ti.buyOrderNum);
                                                Console.WriteLine("주문취소 결과 : " + result.ToString() + "종목코드 :" + itemCode);
                                             
                                            }
                                            else if (ti.isCompletedBuying)
                                            {
                                                //매도주문
                                                if (DialogResult == 0)
                                                {
                                                    orderResult = axKHOpenAPI1.SendOrder(
                                                   "종목익절매도",
                                                   GetScreenNum(),
                                                   ts.account, //계좌번호
                                                   2, //신규매도
                                                   itemCode,
                                                   ti.buyingQnt,
                                                   (int)cPrice_long,
                                                   ts.sellOrderOption,
                                                   ""
                                                   );
                                                }
                                          


                                                if (orderResult == 0) //매도 주문 요청 성공시
                                                {
                                                    Console.WriteLine("익절 주문 요청 성공");

                                                    tryingOrderList.Add(ti);
                                                    ti.isSold = true;

                                                    //매매진행상황 데이터그리드뷰 진행상황 갱신

                                                    foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                                    {
                                                        if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                                        {
                                                            row.Cells["매매진행_진행상황"].Value = "익절 매도중";
                                                            break;
                                                        }
                                                    }

                                                    WriteLog("자동익절매도요청 - 종목코드 : " + itemCode + " I 주문가: " + cPrice + " I 주문수량: " + ti.buyingQnt);
                                                }
                                            }
                                          
                                        }
                                    }
                                    if (ts.usingStopLoss) //손절 사용 시 
                                    {

                                        if (realProfitRate <= ts.stopLossRate) //손절률 돌파
                                        {

                                            if (!ti.isCompletedBuying)
                                            {
                                                int result = axKHOpenAPI1.SendOrder("주문취소손절;" + ts.buyingCondition.name + ";" + itemCode,
                                                                GetScreenNum(),
                                                                ts.account,
                                                                3,
                                                                itemCode,
                                                                0,
                                                                0,
                                                                "",
                                                                ti.buyOrderNum);
                                                Console.WriteLine("주문취소 결과 : " + result.ToString() + "종목코드 :" + itemCode);
                                                
                                            }
                                            else if (ti.isCompletedBuying)
                                            {
                                                //매도주문
                                                orderResult = axKHOpenAPI1.SendOrder(
                                                  "종목손절매도",
                                                  GetScreenNum(),
                                                  ts.account, //계좌번호
                                                  2, //신규매수
                                                  itemCode,
                                                  ti.buyingQnt,
                                                  0,
                                                  ts.sellOrderOption, //시장가
                                                  ""
                                                  );
                                            }

                                           


                                            if (orderResult == 0) //매도 주문 요청 성공시
                                            {
                                                Console.WriteLine("손절 주문 요청 성공");
                                                tryingOrderList.Add(ti);
                                                ti.isSold = true;

                                                //매매진행상황 데이터그리드뷰 진행상황 갱신

                                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                                {
                                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(itemCode) && row.Cells["매매진행_매수조건식"].Value.ToString().Equals(ts.buyingCondition.name))
                                                    {
                                                        row.Cells["매매진행_진행상황"].Value = "손절 매도중";
                                                        break;
                                                    }
                                                }


                                                WriteLog("자동손절매도요청 - 종목코드 : " + itemCode + " I 주문가: " + cPrice + " I 주문수량: " + ti.buyingQnt);
                                            }
                                        }
                                    }

                                }

                            }

                          
                           
                        }

                    }

                }

                //실시간 종목에 대한 매매 전략

                BalanceSellStrategy bss = balanceSellStrategyList.Find(o => o.itemCode.Equals(itemCode));
                if (bss != null)
                {
                    if (!bss.isSold && bss.buyingPrice != 0)
                    {
                        //double profitRate = 100 * (cPrice_long - bss.buyingPrice) / bss.buyingPrice;

                        double profitRate = ((((cPrice_long * bss.sellQnt) * (1.00 - TAX) - (bss.sellQnt * FEE) * (cPrice_long + bss.buyingPrice)) / (bss.buyingPrice * bss.sellQnt)) - 1) * 100;

                        Console.WriteLine("손익률 : " + Math.Round(profitRate, 2));


                        if (bss.takeProfitRate <= Math.Round(profitRate, 2)) //익절 만족
                        {
                            //매도주문
                            int orderResult = axKHOpenAPI1.SendOrder(
                              "잔고익절매도;" + bss.itemCode,
                              GetScreenNum(),
                              bss.account, //계좌번호
                              2, //신규매수
                              itemCode,
                              (int)bss.sellQnt,
                              (int)cPrice_long,
                             "00",
                              ""
                              );

                            if (orderResult == 0)
                            {
                                bss.isSold = true;

                                //주문 접수 시도 리스트에 추가
                                tryingSellList.Add(bss);

                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {

                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(itemCode) && row.Cells["매매진행_진행상황"].Value.ToString().Equals("매도감시"))
                                    {
                                        row.Cells["매매진행_진행상황"].Value = "잔고익절매도중";
                                        break;

                                    }
                                }
                            }

                        }
                        else if (bss.stopLossRate >= Math.Round(profitRate, 2)) //손절 만족
                        {

                            //매도주문
                            int orderResult = axKHOpenAPI1.SendOrder(
                              "잔고손절매도;" + bss.itemCode,
                              GetScreenNum(),
                              bss.account, //계좌번호
                              2, //신규매수
                              itemCode,
                              (int)bss.sellQnt,
                              0,
                              "03",
                              ""
                              );

                            if (orderResult == 0) //매도 주문 용청 성공 시
                            {
                                bss.isSold = true;


                                tryingSellList.Add(bss);

                                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                                {

                                    if (row.Cells["매매진행_종목코드"].Value.ToString().Equals(itemCode) && row.Cells["매매진행_진행상황"].Value.ToString().Equals("매도감시"))
                                    {
                                        row.Cells["매매진행_진행상황"].Value = "잔고손절매도중";
                                        row.Cells["매매진행_청산"].Value = "잔고손절매도중";
                                        break;

                                    }

                                }
                            }
                        }

                    }

                }

                //현재가 갱신


                //계좌잔고 데이터그리드뷰 갱신
                foreach (DataGridViewRow row in accountBalanceDataGridView.Rows)
                {

                    if (row.Cells["계좌잔고_종목코드"].Value != null)
                    {
                        /*Console.WriteLine("계좌잔고_종목코드 != null " + itemCode);*/
                        if (row.Cells["계좌잔고_종목코드"].Value.ToString().Contains(itemCode))
                        {
                            /*Console.WriteLine("계좌잔고_종목코드 : " + itemCode);*/
                            double buyingPrice = double.Parse(row.Cells["계좌잔고_평균단가"].Value.ToString());
                            double amount = double.Parse(row.Cells["계좌잔고_보유수량"].Value.ToString());
                            //double profitRate = 100 * (cPrice_long - buyingPrice) / buyingPrice - TAX;
                            double profitRate = ((((cPrice_long * amount) * (1.00 - TAX) - (amount * FEE) * (cPrice_long + buyingPrice)) / (buyingPrice * amount)) - 1) * 100;

                            row.Cells["계좌잔고_손익률"].Value = profitRate;
                            //row.Cells["계좌잔고_손익금액"].Value = profitPrice;
                            //break;


                        }

                    }

                }



               




                //잔고 데이터그리드뷰 갱신
                foreach (DataGridViewRow row in balanceDataGridView.Rows)
                {
                    if (row.Cells["잔고_종목코드"].Value != null)
                    {
                        if (row.Cells["잔고_종목코드"].Value.ToString().Contains(itemCode))
                        {
                            double buyingPrice = double.Parse(row.Cells["잔고_매입단가"].Value.ToString());
                            row.Cells["잔고_현재가"].Value = cPrice_long;

                            if (buyingPrice != 0)
                            {

                                //double profitRate = 100 * (cPrice_long - buyingPrice) / buyingPrice;
                                double amount = double.Parse(row.Cells["잔고_보유수량"].Value.ToString());
                                double profitRate = ((((cPrice_long * amount) * (1.00 - TAX) - (amount * FEE) * (cPrice_long + buyingPrice)) / (buyingPrice * amount)) - 1) * 100;

                                row.Cells["잔고_손익률"].Value = profitRate;

                            }
                        }


                    }

                }






                //매매진행상황 데이터그리드뷰 현재가 갱신
                foreach (DataGridViewRow row in autoTradingDataGridView.Rows)
                {
                    if (row.Cells["매매진행_종목코드"].Value != null)
                    {

                        if (row.Cells["매매진행_종목코드"].Value.ToString().Contains(itemCode))
                        {
                           
                            row.Cells["매매진행_현재가"].Value = cPrice_long; //현재가
                            

                            if (row.Cells["매매진행_진행상황"].Value != null && !row.Cells["매매진행_진행상황"].Value.ToString().Contains("매도완료"))
                            {
                               
                                double buyingPrice = double.Parse(row.Cells["매매진행_매수가"].Value.ToString()); // 매수가
                                
                                //자동매매 매수시 amount = 매수량
                                //잔고매도 매도시 amount = 주문량
                                double amount = double.Parse(row.Cells["매매진행_매수량"].Value.ToString()); // 수량
                                if (row.Cells["매매진행_매수조건식"].Value.Equals("잔고자동매도"))
                                {
                                    amount = double.Parse(row.Cells["매매진행_주문량"].Value.ToString());
                                }
                                double nowPrice = (double)cPrice_long;

                                if (buyingPrice != 0)
                                {
                                    //double profitRate = 100 * (cPrice_long - buyingPrice) / buyingPrice;
                                    long mesuFee = Convert.ToInt64(buyingPrice * amount * FEE); //매수가 계산 수수료
                                    long medoFee = Convert.ToInt64(nowPrice * amount * FEE); //매도가 계산 수수료
                                    long tax = Convert.ToInt64(nowPrice * amount * TAX); // 매도시 제세금     

                                    mesuFee = (mesuFee / 10) * 10;
                                    medoFee = (medoFee / 10) * 10;

                                    long EquitiesValue = Convert.ToInt64(nowPrice * amount);
                                    long profitPrice = Convert.ToInt64(EquitiesValue - (buyingPrice * amount) - mesuFee - medoFee - tax); 
                                    double profitRate = Math.Round(profitPrice / (buyingPrice * amount) * 100, 2);
                                  
/*
                                    double profitRate = ((((nowPrice * amount)*(1.00 - TAXm) - (amount * FEE)*(nowPrice + buyingPrice)) / (buyingPrice * amount)) - 1) * 100;
                                    double profitPrice = (nowPrice * amount) * (1 - TAXm - FEE) - ((buyingPrice * amount) * (1 + FEE));*/
                                        
                                    row.Cells["매매진행_손익률"].Value = profitRate.ToString();
                                    row.Cells["매매진행_평가손익"].Value = profitPrice.ToString();
                                   

                                }
                            }
                        }
                    }
                }
            }
        }



        
        
        



        private string GetScreenNum()
        {

            if (screenNum > 5000)
                screenNum = 1000;

            screenNum++;

            return screenNum.ToString();

        }


        private void WriteLog(string log)
        {
            string filePath = DateTime.Now.ToString("yyyMMdd") + "_log.txt";
            FileInfo fi = new FileInfo(filePath);

            try
            {
                if (!fi.Exists)
                {

                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine("[{0}] - {1}", DateTime.Now.ToString("HH:mm:ss"), log);

                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {

                        sw.WriteLine("[{0}] - {1}", DateTime.Now.ToString("HH:mm:ss"), log);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }


       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tradingStrategyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void balanceSellButton_Click(object sender, EventArgs e)
        {

        }
















        /*class DBCon
        {
            //접속 정보
            static string connectString = string.Format("Server={0};Database={1};Uid ={2};Pwd={3};",
              "localhost", "sentiment_analysis", "root", "1234");


            public bool InsertDb(List<CheckItem> checkItemList, int nIndex)
            {


                //조건식에 해당하는 리스트 초기화

                string sql = string.Format("delete from tradingdb2 where conditionIndex = {0}", nIndex);




                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectString))//using문 범위 내에서만 자원 할당 
                    {

                        conn.Open(); //db 연결그
                        Console.WriteLine(conn.State);
                        if (conn.State.ToString().Equals("Open"))
                        {
                            //조건식 해당 리스트 초기화
                            Console.WriteLine(sql);
                            MySqlCommand cmd = new MySqlCommand(sql, conn);//MySqlCommand 오브젝트를 생성

                            cmd.ExecuteNonQuery();



                            foreach (CheckItem cItem in checkItemList)
                            {

                                sql = string.Format("insert into tradingdb2 values('{0}','{1}',now(), '{2}', '{3}', '{4}');", cItem.itemCode, cItem.itemName, cItem.score, cItem.conditionName, cItem.conditionIndex);
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                            //쿼리 준비



                            //MySqlDataReader dr = cmd.ExecuteReader(); //ExcuteReader는 데이터를 받아옴 MySqlDataReader객체로 리턴
                            //ExecuteNonQuery -데이터 삽입/삭제시 사용
                            //ExecuteScalar - 하나의 값이리턴되는 쿼리문에 사용
                            conn.Close();
                            return true;
                        }



                        else
                        {
                            Console.WriteLine("db연결 실패..");
                            return false;
                        }

                    }

                }




                catch (Exception)
                {
                    return false;
                }
            }

            //db에 하나씩 넣을때
            public bool InsertDb(string itemCode, string itemName, string score, string conditionName, int conditionIndex)
            {
                string sql = string.Format("insert into tradingdb2 values('{0}','{1}',now(), '{2}', '{3}', '{4}');", itemCode, itemName, score, conditionName, conditionIndex);


                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectString))//using문 범위 내에서만 자원 할당 
                    {

                        conn.Open(); //db 연결그
                        Console.WriteLine(conn.State);
                        if (conn.State.ToString().Equals("Open"))
                        {
                            //조건식 해당 리스트 초기화
                            Console.WriteLine(sql);
                            MySqlCommand cmd = new MySqlCommand(sql, conn);//MySqlCommand 오브젝트를 생성

                            cmd.ExecuteNonQuery();


                            //MySqlDataReader dr = cmd.ExecuteReader(); //ExcuteReader는 데이터를 받아옴 MySqlDataReader객체로 리턴
                            //ExecuteNonQuery -데이터 삽입/삭제시 사용
                            //ExecuteScalar - 하나의 값이리턴되는 쿼리문에 사용
                            conn.Close();
                            return true;
                        }



                        else
                        {
                            Console.WriteLine("db연결 실패..");
                            return false;
                        }

                    }

                }




                catch (Exception)
                {
                    return false;
                }

            }

            public List<tradingItems> selectDb(string scoree, String code)
            {
                List<tradingItems> result = null;

                string sql = string.Format("select ItemCode,ItemName,score from tradingdb2 where score > {0} and ItemCode = '{1}';", scoree, code);


                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectString))
                    {
                        conn.Open();
                        Console.WriteLine(conn.State);
                        if (conn.State.ToString().Equals("Open"))
                        {
                            result = new List<tradingItems>();

                            Console.WriteLine(sql);
                            MySqlCommand cmd = new MySqlCommand(sql, conn);


                            //여기서부터 차이가 납니다.

                            MySqlDataReader msdr = cmd.ExecuteReader(); //쿼리실행, <-- 이부분이 select할때 차이점



                            //데이터 반환값, 결과 리스트에 셋팅
                            while (msdr.Read())
                            {
                                String _code = msdr["ItemCode"].ToString();
                                String _name = msdr["ItemName"].ToString();
                                String _scoree = msdr["score"].ToString();

                                tradingItems resultItem = new tradingItems();
                                resultItem.code = _code;
                                resultItem.name = _name;
                                resultItem.scoree = _scoree;

                                result.Add(resultItem);
                            }

                            msdr.Close();

                            //db연결종료
                            if (conn != null)
                                try
                                {
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("[conn Err] : " + ex);
                                }
                        }
                        else
                        {
                            Console.WriteLine("db연결실패..");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("[Err] : " + ex);
                }

                return result;
            }

            public bool DeleteDb(string itemCode, int conditionIndex)
            {
                string sql = string.Format("delete from tradingdb2 where ItemCode = '{0}' and conditionIndex = {1};", itemCode, conditionIndex);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectString))//using문 범위 내에서만 자원 할당 
                    {

                        conn.Open(); //db 연결그
                        Console.WriteLine(conn.State);
                        if (conn.State.ToString().Equals("Open"))
                        {

                            Console.WriteLine(sql);
                            MySqlCommand cmd = new MySqlCommand(sql, conn);//MySqlCommand 오브젝트를 생성

                            cmd.ExecuteNonQuery();


                            //MySqlDataReader dr = cmd.ExecuteReader(); //ExcuteReader는 데이터를 받아옴 MySqlDataReader객체로 리턴
                            //ExecuteNonQuery -데이터 삽입/삭제시 사용
                            //ExecuteScalar - 하나의 값이리턴되는 쿼리문에 사용
                            conn.Close();
                            return true;
                        }



                        else
                        {
                            Console.WriteLine("db연결 실패..");
                            return false;
                        }

                    }

                }




                catch (Exception)
                {
                    return false;
                }
            }

        }*/

        private void API_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {

            




        }

        
        

        private void API_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {

         /*   //checkitemList초기화
            checkitemList.RemoveAll(x => true);

            //db에서 구분하기 위한 조건식이름,조건식고유번호쌍
            string conditionName = e.strConditionName;
            int index = e.nIndex;

            string[] itemCodeList = e.strCodeList.Split(';');
            int scoree = 0; //초기 점수
            for (int i = 0; i < itemCodeList.Length - 1; i++)
            {
                string itemCode = itemCodeList[i].ToString();
                string itemName = axKHOpenAPI1.GetMasterCodeName(itemCode);
                string score = "0";

                CheckItem cItem = new CheckItem(itemCode, itemName, score, conditionName, index);
                checkitemList.Add(cItem);
            }
           
            //dbcon.InsertDb(checkitemList, index);
            */


        }

        private void createStrategyButton_Click(object sender, EventArgs e)
        {

        }

        private void buyingOrderOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TimerFunction(object sender, EventArgs e)
        {

            string now = DateTime.Now.ToString("HH:mm:ss");

          

            //3시되면 1.전략삭제, 2.미체결 취소, 3. 잔고 매도
            if (now.Contains("15:00:00")) //3시되면
            {
                Console.WriteLine("start!!!");
                //1. 전략 삭제
                tradingStrategyList.Clear();
                tradingStrategyDataGridView.Rows.Clear();

                //2. 모든 미체결 주문 취소
                foreach (DataGridViewRow rows in outstandingDataGridView.Rows)
                {
                    int orderResult = axKHOpenAPI1.SendOrder("장마감청산",
                                                     GetScreenNum(),
                                                     currentAccount,
                                                     3,
                                                     rows.Cells["미체결_종목코드"].Value.ToString().Replace("A", "").Trim(),
                                                     0,
                                                     0,
                                                     "",
                                                     rows.Cells["미체결_주문번호"].Value.ToString());
                    Console.WriteLine("장마감주문취소결과 : " + orderResult);
                    Console.WriteLine("장마감청산 종목코드 : " + rows.Cells["미체결_종목코드"].Value.ToString());
                }

                marketClose = true;
            }

            if(marketClose == true)
            {
                //잔고 모두 청산
                foreach(DataGridViewRow row in balanceDataGridView.Rows)
                {
                    int orderResult = axKHOpenAPI1.SendOrder("청산매도주문",
                                                       GetScreenNum(),
                                                       currentAccount,
                                                       2,
                                                       row.Cells["잔고_종목코드"].Value.ToString().Replace("A", "").Trim(),
                                                       int.Parse(row.Cells["잔고_주문가능수량"].Value.ToString()),
                                                       0,
                                                       "03",
                                                       "");
                }
            }


        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void accountBalanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autoTradingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void marketPriceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (marketPriceRadioButton.Checked)
                buyingOrderOptionComboBox.Enabled = false;
            else
                buyingOrderOptionComboBox.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                comboBox1.Enabled = false;
            else
                comboBox1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                comboBox2.Enabled = false;
            else
                comboBox2.Enabled = true;
        }

        private void takeProfitNumbericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trayItem_clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Tag != null)
            {
                if (e.ClickedItem.Tag.ToString().Equals("EXIT"))
                {
                    this.Close();
                    this.Dispose();
                    Properties.Settings.Default.Save();
                    Application.Exit();
              
                }
                else if (e.ClickedItem.Tag.ToString().Equals("OPEN"))
                {
                    this.Visible = true;
                }

                else if (e.ClickedItem.Tag.ToString().Equals("ACCOUNT"))
                {
                    if (e.ClickedItem.Text.Equals("로그인"))
                    {
                        axKHOpenAPI1.CommConnect();
                    }
                }
            }
        }
    }
}




//두 정수 A와 B를 입력받은 다음, A×B를 출력하는 프로그램을 작성하시오.

//입력
//첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

//출력
//첫째 줄에 A×B를 출력한다.