
namespace EolabAutoTradingSystem
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tradingStrategyDataGridView = new System.Windows.Forms.DataGridView();
            this.매매전략_계좌번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_매수조건식 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_매수가격 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_총투자금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_매수종목수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_종목당투자금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_익절 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_익절률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_손절 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_손절률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매전략_취소 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stopLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.stopLossCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.takeProfitNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.takeProfitCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyInterestCheckBox = new System.Windows.Forms.CheckBox();
            this.itemInvestmentLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.investmentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buyingOrderOptionComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.marketPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.buyingConditionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createStrategyButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.balanceStopLossNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.balanceStopLossCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.balanceTakeProfitNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.balanceTakeProfitCheckBox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.balanceItemCodeTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.balanceAvgPriceLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.balanceQntNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.balanceItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.balanceSellButton = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.AddInterestButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.interestItemListBox = new System.Windows.Forms.ListBox();
            this.label23 = new System.Windows.Forms.Label();
            this.interestConditionListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.주문_주문번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_계좌번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_주문량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_주문가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_매매구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문_가격구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.conclusionDataGridView = new System.Windows.Forms.DataGridView();
            this.체결_주문번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_체결시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_주문량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_단위체결량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_누적체결량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_체결가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.체결_매매구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.outstandingDataGridView = new System.Windows.Forms.DataGridView();
            this.미체결_주문번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_주문수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_미체결량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.미체결_매매구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.잔고_계좌번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_보유수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_주문가능수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_매입단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_총매입가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.잔고_손익률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autoTradingDataGridView = new System.Windows.Forms.DataGridView();
            this.매매진행_진행상황 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매수조건식 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_주문량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매수가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매수금 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매도가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_현재가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_손익률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_평가손익 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매수시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_매도시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매매진행_청산 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.d2AssetLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.assetLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.investmentLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.profitRateLabel = new System.Windows.Forms.Label();
            this.accountBalanceDataGridView = new System.Windows.Forms.DataGridView();
            this.계좌잔고_종목코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_종목명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_보유수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_평균단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_손익률 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_평가금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_매입금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_손익금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.계좌잔고_청산 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SetaccountbalanceBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tradingStrategyDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopLossNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takeProfitNumbericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentNumericUpDown)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopLossNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTakeProfitNumbericUpDown)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceQntNumericUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conclusionDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoTradingDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBalanceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(0, 778);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 26);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1808, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.loginToolStripMenuItem.Text = "로그인";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tradingStrategyDataGridView);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(37, 762);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1109, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // tradingStrategyDataGridView
            // 
            this.tradingStrategyDataGridView.AllowUserToAddRows = false;
            this.tradingStrategyDataGridView.AllowUserToDeleteRows = false;
            this.tradingStrategyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tradingStrategyDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tradingStrategyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tradingStrategyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.매매전략_계좌번호,
            this.매매전략_매수조건식,
            this.매매전략_매수가격,
            this.매매전략_총투자금,
            this.매매전략_매수종목수,
            this.매매전략_종목당투자금,
            this.매매전략_익절,
            this.매매전략_익절률,
            this.매매전략_손절,
            this.매매전략_손절률,
            this.매매전략_취소});
            this.tradingStrategyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tradingStrategyDataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tradingStrategyDataGridView.Location = new System.Drawing.Point(3, 21);
            this.tradingStrategyDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tradingStrategyDataGridView.MultiSelect = false;
            this.tradingStrategyDataGridView.Name = "tradingStrategyDataGridView";
            this.tradingStrategyDataGridView.RowHeadersVisible = false;
            this.tradingStrategyDataGridView.RowTemplate.Height = 23;
            this.tradingStrategyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tradingStrategyDataGridView.Size = new System.Drawing.Size(1103, 184);
            this.tradingStrategyDataGridView.TabIndex = 0;
            this.tradingStrategyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tradingStrategyDataGridView_CellContentClick);
            // 
            // 매매전략_계좌번호
            // 
            this.매매전략_계좌번호.HeaderText = "계좌번호";
            this.매매전략_계좌번호.Name = "매매전략_계좌번호";
            this.매매전략_계좌번호.ReadOnly = true;
            // 
            // 매매전략_매수조건식
            // 
            this.매매전략_매수조건식.HeaderText = "매수조건식";
            this.매매전략_매수조건식.Name = "매매전략_매수조건식";
            this.매매전략_매수조건식.ReadOnly = true;
            // 
            // 매매전략_매수가격
            // 
            this.매매전략_매수가격.HeaderText = "매수가격";
            this.매매전략_매수가격.Name = "매매전략_매수가격";
            this.매매전략_매수가격.ReadOnly = true;
            // 
            // 매매전략_총투자금
            // 
            this.매매전략_총투자금.HeaderText = "총투자금";
            this.매매전략_총투자금.Name = "매매전략_총투자금";
            this.매매전략_총투자금.ReadOnly = true;
            // 
            // 매매전략_매수종목수
            // 
            this.매매전략_매수종목수.HeaderText = "매수종목수";
            this.매매전략_매수종목수.Name = "매매전략_매수종목수";
            this.매매전략_매수종목수.ReadOnly = true;
            // 
            // 매매전략_종목당투자금
            // 
            this.매매전략_종목당투자금.HeaderText = "종목당투자금";
            this.매매전략_종목당투자금.Name = "매매전략_종목당투자금";
            this.매매전략_종목당투자금.ReadOnly = true;
            // 
            // 매매전략_익절
            // 
            this.매매전략_익절.HeaderText = "익절";
            this.매매전략_익절.Name = "매매전략_익절";
            this.매매전략_익절.ReadOnly = true;
            // 
            // 매매전략_익절률
            // 
            this.매매전략_익절률.HeaderText = "익절률";
            this.매매전략_익절률.Name = "매매전략_익절률";
            this.매매전략_익절률.ReadOnly = true;
            // 
            // 매매전략_손절
            // 
            this.매매전략_손절.HeaderText = "손절";
            this.매매전략_손절.Name = "매매전략_손절";
            this.매매전략_손절.ReadOnly = true;
            // 
            // 매매전략_손절률
            // 
            this.매매전략_손절률.HeaderText = "손절률";
            this.매매전략_손절률.Name = "매매전략_손절률";
            this.매매전략_손절률.ReadOnly = true;
            // 
            // 매매전략_취소
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.NullValue = "취소";
            this.매매전략_취소.DefaultCellStyle = dataGridViewCellStyle37;
            this.매매전략_취소.HeaderText = "취소";
            this.매매전략_취소.Name = "매매전략_취소";
            this.매매전략_취소.ReadOnly = true;
            this.매매전략_취소.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.매매전략_취소.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(115, 69);
            this.accountComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(180, 23);
            this.accountComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.82518F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.17482F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 336);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.stopLossNumericUpDown);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.stopLossCheckBox);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.takeProfitNumbericUpDown);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.takeProfitCheckBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(299, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 326);
            this.panel2.TabIndex = 1;
            // 
            // stopLossNumericUpDown
            // 
            this.stopLossNumericUpDown.DecimalPlaces = 2;
            this.stopLossNumericUpDown.Location = new System.Drawing.Point(94, 245);
            this.stopLossNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopLossNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.stopLossNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.stopLossNumericUpDown.Name = "stopLossNumericUpDown";
            this.stopLossNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.stopLossNumericUpDown.TabIndex = 9;
            this.stopLossNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "매수단가 대비";
            // 
            // stopLossCheckBox
            // 
            this.stopLossCheckBox.AutoSize = true;
            this.stopLossCheckBox.Checked = true;
            this.stopLossCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stopLossCheckBox.ForeColor = System.Drawing.Color.Black;
            this.stopLossCheckBox.Location = new System.Drawing.Point(9, 204);
            this.stopLossCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopLossCheckBox.Name = "stopLossCheckBox";
            this.stopLossCheckBox.Size = new System.Drawing.Size(50, 19);
            this.stopLossCheckBox.TabIndex = 7;
            this.stopLossCheckBox.Text = "손절";
            this.stopLossCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "00:현재가",
            "05:조건부지정가",
            "06:최유리지정가",
            "07:최우선지정가",
            "10:지정가IOC",
            "13:시장가IOC",
            "16:최유리IOC",
            "20:지정가FOK",
            "23:시장가FOK",
            "26:최유리FOK",
            "61:장전시간외종가",
            "62:시간외단일가매매",
            "81:장후시간외종가"});
            this.comboBox1.Location = new System.Drawing.Point(9, 156);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(122, 116);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "지정가";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(9, 119);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "시장가";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // takeProfitNumbericUpDown
            // 
            this.takeProfitNumbericUpDown.DecimalPlaces = 2;
            this.takeProfitNumbericUpDown.Location = new System.Drawing.Point(94, 80);
            this.takeProfitNumbericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.takeProfitNumbericUpDown.Name = "takeProfitNumbericUpDown";
            this.takeProfitNumbericUpDown.Size = new System.Drawing.Size(120, 24);
            this.takeProfitNumbericUpDown.TabIndex = 3;
            this.takeProfitNumbericUpDown.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.takeProfitNumbericUpDown.ValueChanged += new System.EventHandler(this.takeProfitNumbericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "매수단가 대비";
            // 
            // takeProfitCheckBox
            // 
            this.takeProfitCheckBox.AutoSize = true;
            this.takeProfitCheckBox.Checked = true;
            this.takeProfitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.takeProfitCheckBox.ForeColor = System.Drawing.Color.Black;
            this.takeProfitCheckBox.Location = new System.Drawing.Point(9, 51);
            this.takeProfitCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.takeProfitCheckBox.Name = "takeProfitCheckBox";
            this.takeProfitCheckBox.Size = new System.Drawing.Size(50, 19);
            this.takeProfitCheckBox.TabIndex = 1;
            this.takeProfitCheckBox.Text = "익절";
            this.takeProfitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "매도전략";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.onlyInterestCheckBox);
            this.panel1.Controls.Add(this.itemInvestmentLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.itemCountNumericUpDown);
            this.panel1.Controls.Add(this.investmentNumericUpDown);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buyingOrderOptionComboBox);
            this.panel1.Controls.Add(this.SelectedPriceRadioButton);
            this.panel1.Controls.Add(this.marketPriceRadioButton);
            this.panel1.Controls.Add(this.buyingConditionComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 326);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // onlyInterestCheckBox
            // 
            this.onlyInterestCheckBox.AutoSize = true;
            this.onlyInterestCheckBox.ForeColor = System.Drawing.Color.Black;
            this.onlyInterestCheckBox.Location = new System.Drawing.Point(8, 291);
            this.onlyInterestCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.onlyInterestCheckBox.Name = "onlyInterestCheckBox";
            this.onlyInterestCheckBox.Size = new System.Drawing.Size(113, 19);
            this.onlyInterestCheckBox.TabIndex = 9;
            this.onlyInterestCheckBox.Text = "관심종목만 매수";
            this.onlyInterestCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemInvestmentLabel
            // 
            this.itemInvestmentLabel.ForeColor = System.Drawing.Color.Black;
            this.itemInvestmentLabel.Location = new System.Drawing.Point(111, 242);
            this.itemInvestmentLabel.Name = "itemInvestmentLabel";
            this.itemInvestmentLabel.Size = new System.Drawing.Size(94, 29);
            this.itemInvestmentLabel.TabIndex = 11;
            this.itemInvestmentLabel.Text = "0";
            this.itemInvestmentLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "종목 당 투자금 :";
            // 
            // itemCountNumericUpDown
            // 
            this.itemCountNumericUpDown.Location = new System.Drawing.Point(89, 192);
            this.itemCountNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemCountNumericUpDown.Name = "itemCountNumericUpDown";
            this.itemCountNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.itemCountNumericUpDown.TabIndex = 9;
            this.itemCountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // investmentNumericUpDown
            // 
            this.investmentNumericUpDown.Location = new System.Drawing.Point(89, 155);
            this.investmentNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.investmentNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.investmentNumericUpDown.Name = "investmentNumericUpDown";
            this.investmentNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.investmentNumericUpDown.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "매수종목 수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "총투자금";
            // 
            // buyingOrderOptionComboBox
            // 
            this.buyingOrderOptionComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buyingOrderOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyingOrderOptionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyingOrderOptionComboBox.FormattingEnabled = true;
            this.buyingOrderOptionComboBox.Items.AddRange(new object[] {
            "00:현재가",
            "05:조건부지정가",
            "06:최유리지정가",
            "07:최우선지정가",
            "10:지정가IOC",
            "13:시장가IOC",
            "16:최유리IOC",
            "20:지정가FOK",
            "23:시장가FOK",
            "26:최유리FOK",
            "61:장전시간외종가",
            "62:시간외단일가매매",
            "81:장후시간외종가"});
            this.buyingOrderOptionComboBox.Location = new System.Drawing.Point(17, 115);
            this.buyingOrderOptionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buyingOrderOptionComboBox.Name = "buyingOrderOptionComboBox";
            this.buyingOrderOptionComboBox.Size = new System.Drawing.Size(192, 23);
            this.buyingOrderOptionComboBox.TabIndex = 5;
            this.buyingOrderOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.buyingOrderOptionComboBox_SelectedIndexChanged);
            // 
            // SelectedPriceRadioButton
            // 
            this.SelectedPriceRadioButton.AutoSize = true;
            this.SelectedPriceRadioButton.Checked = true;
            this.SelectedPriceRadioButton.ForeColor = System.Drawing.Color.Black;
            this.SelectedPriceRadioButton.Location = new System.Drawing.Point(85, 86);
            this.SelectedPriceRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedPriceRadioButton.Name = "SelectedPriceRadioButton";
            this.SelectedPriceRadioButton.Size = new System.Drawing.Size(61, 19);
            this.SelectedPriceRadioButton.TabIndex = 4;
            this.SelectedPriceRadioButton.TabStop = true;
            this.SelectedPriceRadioButton.Text = "지정가";
            this.SelectedPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // marketPriceRadioButton
            // 
            this.marketPriceRadioButton.AutoSize = true;
            this.marketPriceRadioButton.ForeColor = System.Drawing.Color.Black;
            this.marketPriceRadioButton.Location = new System.Drawing.Point(17, 86);
            this.marketPriceRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marketPriceRadioButton.Name = "marketPriceRadioButton";
            this.marketPriceRadioButton.Size = new System.Drawing.Size(61, 19);
            this.marketPriceRadioButton.TabIndex = 3;
            this.marketPriceRadioButton.Text = "시장가";
            this.marketPriceRadioButton.UseVisualStyleBackColor = true;
            this.marketPriceRadioButton.CheckedChanged += new System.EventHandler(this.marketPriceRadioButton_CheckedChanged);
            // 
            // buyingConditionComboBox
            // 
            this.buyingConditionComboBox.FormattingEnabled = true;
            this.buyingConditionComboBox.Location = new System.Drawing.Point(85, 41);
            this.buyingConditionComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buyingConditionComboBox.Name = "buyingConditionComboBox";
            this.buyingConditionComboBox.Size = new System.Drawing.Size(121, 23);
            this.buyingConditionComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "매수조건식";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "매수전략";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "계좌번호";
            // 
            // createStrategyButton
            // 
            this.createStrategyButton.BackColor = System.Drawing.Color.Red;
            this.createStrategyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createStrategyButton.FlatAppearance.BorderSize = 0;
            this.createStrategyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.createStrategyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(39)))), ((int)(((byte)(26)))));
            this.createStrategyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createStrategyButton.ForeColor = System.Drawing.Color.White;
            this.createStrategyButton.Location = new System.Drawing.Point(248, 348);
            this.createStrategyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createStrategyButton.Name = "createStrategyButton";
            this.createStrategyButton.Size = new System.Drawing.Size(97, 46);
            this.createStrategyButton.TabIndex = 3;
            this.createStrategyButton.Text = "전략생성";
            this.createStrategyButton.UseVisualStyleBackColor = false;
            this.createStrategyButton.Click += new System.EventHandler(this.createStrategyButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(4, 25);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(605, 436);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.tableLayoutPanel1);
            this.tabPage5.Controls.Add(this.createStrategyButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(597, 408);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "자동매매";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.tableLayoutPanel4);
            this.tabPage6.Controls.Add(this.tableLayoutPanel3);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Size = new System.Drawing.Size(597, 408);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "잔고매도";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.80484F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.19516F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(588, 330);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.balanceStopLossNumericUpDown);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.balanceStopLossCheckBox);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.balanceTakeProfitNumbericUpDown);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.balanceTakeProfitCheckBox);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(278, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 322);
            this.panel3.TabIndex = 2;
            // 
            // balanceStopLossNumericUpDown
            // 
            this.balanceStopLossNumericUpDown.DecimalPlaces = 2;
            this.balanceStopLossNumericUpDown.Location = new System.Drawing.Point(94, 245);
            this.balanceStopLossNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceStopLossNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.balanceStopLossNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.balanceStopLossNumericUpDown.Name = "balanceStopLossNumericUpDown";
            this.balanceStopLossNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.balanceStopLossNumericUpDown.TabIndex = 9;
            this.balanceStopLossNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "매수단가 대비";
            // 
            // balanceStopLossCheckBox
            // 
            this.balanceStopLossCheckBox.AutoSize = true;
            this.balanceStopLossCheckBox.Checked = true;
            this.balanceStopLossCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.balanceStopLossCheckBox.ForeColor = System.Drawing.Color.Black;
            this.balanceStopLossCheckBox.Location = new System.Drawing.Point(9, 204);
            this.balanceStopLossCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceStopLossCheckBox.Name = "balanceStopLossCheckBox";
            this.balanceStopLossCheckBox.Size = new System.Drawing.Size(50, 19);
            this.balanceStopLossCheckBox.TabIndex = 7;
            this.balanceStopLossCheckBox.Text = "손절";
            this.balanceStopLossCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00:현재가",
            "05:조건부지정가",
            "06:최유리지정가",
            "07:최우선지정가",
            "10:지정가IOC",
            "13:시장가IOC",
            "16:최유리IOC",
            "20:지정가FOK",
            "23:시장가FOK",
            "26:최유리FOK",
            "61:장전시간외종가",
            "62:시간외단일가매매",
            "81:장후시간외종가"});
            this.comboBox2.Location = new System.Drawing.Point(9, 156);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(122, 116);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "지정가";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(9, 119);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 19);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "시장가";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // balanceTakeProfitNumbericUpDown
            // 
            this.balanceTakeProfitNumbericUpDown.DecimalPlaces = 2;
            this.balanceTakeProfitNumbericUpDown.Location = new System.Drawing.Point(94, 80);
            this.balanceTakeProfitNumbericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceTakeProfitNumbericUpDown.Name = "balanceTakeProfitNumbericUpDown";
            this.balanceTakeProfitNumbericUpDown.Size = new System.Drawing.Size(120, 24);
            this.balanceTakeProfitNumbericUpDown.TabIndex = 3;
            this.balanceTakeProfitNumbericUpDown.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(7, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "매수단가 대비";
            // 
            // balanceTakeProfitCheckBox
            // 
            this.balanceTakeProfitCheckBox.AutoSize = true;
            this.balanceTakeProfitCheckBox.Checked = true;
            this.balanceTakeProfitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.balanceTakeProfitCheckBox.ForeColor = System.Drawing.Color.Black;
            this.balanceTakeProfitCheckBox.Location = new System.Drawing.Point(9, 51);
            this.balanceTakeProfitCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceTakeProfitCheckBox.Name = "balanceTakeProfitCheckBox";
            this.balanceTakeProfitCheckBox.Size = new System.Drawing.Size(50, 19);
            this.balanceTakeProfitCheckBox.TabIndex = 1;
            this.balanceTakeProfitCheckBox.Text = "익절";
            this.balanceTakeProfitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(7, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "매도전략";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.balanceItemCodeTextBox);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.balanceAvgPriceLabel);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.balanceQntNumericUpDown);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.balanceItemNameTextBox);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.infolabel);
            this.panel6.Location = new System.Drawing.Point(3, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 322);
            this.panel6.TabIndex = 1;
            // 
            // balanceItemCodeTextBox
            // 
            this.balanceItemCodeTextBox.Enabled = false;
            this.balanceItemCodeTextBox.Location = new System.Drawing.Point(119, 36);
            this.balanceItemCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceItemCodeTextBox.Name = "balanceItemCodeTextBox";
            this.balanceItemCodeTextBox.Size = new System.Drawing.Size(100, 24);
            this.balanceItemCodeTextBox.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(13, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 15);
            this.label22.TabIndex = 7;
            this.label22.Text = "종목코드";
            // 
            // balanceAvgPriceLabel
            // 
            this.balanceAvgPriceLabel.AutoSize = true;
            this.balanceAvgPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.balanceAvgPriceLabel.Location = new System.Drawing.Point(117, 181);
            this.balanceAvgPriceLabel.Name = "balanceAvgPriceLabel";
            this.balanceAvgPriceLabel.Size = new System.Drawing.Size(13, 15);
            this.balanceAvgPriceLabel.TabIndex = 6;
            this.balanceAvgPriceLabel.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(13, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "평균단가";
            // 
            // balanceQntNumericUpDown
            // 
            this.balanceQntNumericUpDown.Location = new System.Drawing.Point(119, 124);
            this.balanceQntNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceQntNumericUpDown.Name = "balanceQntNumericUpDown";
            this.balanceQntNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.balanceQntNumericUpDown.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(13, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "수량";
            // 
            // balanceItemNameTextBox
            // 
            this.balanceItemNameTextBox.Enabled = false;
            this.balanceItemNameTextBox.Location = new System.Drawing.Point(119, 84);
            this.balanceItemNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceItemNameTextBox.Name = "balanceItemNameTextBox";
            this.balanceItemNameTextBox.Size = new System.Drawing.Size(100, 24);
            this.balanceItemNameTextBox.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(13, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "종목명";
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.ForeColor = System.Drawing.Color.Black;
            this.infolabel.Location = new System.Drawing.Point(13, 11);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(85, 15);
            this.infolabel.TabIndex = 0;
            this.infolabel.Text = "매도 종목 정보";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.balanceSellButton, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(591, 392);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // balanceSellButton
            // 
            this.balanceSellButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.balanceSellButton.BackColor = System.Drawing.Color.Red;
            this.balanceSellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceSellButton.ForeColor = System.Drawing.Color.White;
            this.balanceSellButton.Location = new System.Drawing.Point(248, 338);
            this.balanceSellButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceSellButton.Name = "balanceSellButton";
            this.balanceSellButton.Size = new System.Drawing.Size(95, 46);
            this.balanceSellButton.TabIndex = 0;
            this.balanceSellButton.Text = "매도등록";
            this.balanceSellButton.UseVisualStyleBackColor = false;
            this.balanceSellButton.Click += new System.EventHandler(this.balanceSellButton_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.AddInterestButton);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.interestTextBox);
            this.tabPage7.Controls.Add(this.interestItemListBox);
            this.tabPage7.Controls.Add(this.label23);
            this.tabPage7.Controls.Add(this.interestConditionListBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(597, 408);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "관심종목";
            // 
            // AddInterestButton
            // 
            this.AddInterestButton.BackColor = System.Drawing.Color.Red;
            this.AddInterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInterestButton.ForeColor = System.Drawing.Color.White;
            this.AddInterestButton.Location = new System.Drawing.Point(359, 329);
            this.AddInterestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddInterestButton.Name = "AddInterestButton";
            this.AddInterestButton.Size = new System.Drawing.Size(75, 29);
            this.AddInterestButton.TabIndex = 5;
            this.AddInterestButton.Text = "관심등록";
            this.AddInterestButton.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(239, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 15);
            this.label24.TabIndex = 4;
            this.label24.Text = "관심종목 리스트";
            // 
            // interestTextBox
            // 
            this.interestTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.interestTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.interestTextBox.Location = new System.Drawing.Point(241, 330);
            this.interestTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(112, 24);
            this.interestTextBox.TabIndex = 3;
            // 
            // interestItemListBox
            // 
            this.interestItemListBox.FormattingEnabled = true;
            this.interestItemListBox.ItemHeight = 15;
            this.interestItemListBox.Location = new System.Drawing.Point(241, 48);
            this.interestItemListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interestItemListBox.Name = "interestItemListBox";
            this.interestItemListBox.Size = new System.Drawing.Size(193, 274);
            this.interestItemListBox.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(3, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "조건식리스트";
            // 
            // interestConditionListBox
            // 
            this.interestConditionListBox.FormattingEnabled = true;
            this.interestConditionListBox.ItemHeight = 15;
            this.interestConditionListBox.Location = new System.Drawing.Point(3, 48);
            this.interestConditionListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interestConditionListBox.Name = "interestConditionListBox";
            this.interestConditionListBox.Size = new System.Drawing.Size(192, 304);
            this.interestConditionListBox.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1160, 556);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 201);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.orderDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(605, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주문";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.주문_주문번호,
            this.주문_계좌번호,
            this.주문_시간,
            this.주문_종목코드,
            this.주문_종목명,
            this.주문_주문량,
            this.주문_주문가,
            this.주문_매매구분,
            this.주문_가격구분});
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 4);
            this.orderDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersVisible = false;
            this.orderDataGridView.RowTemplate.Height = 23;
            this.orderDataGridView.Size = new System.Drawing.Size(599, 165);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // 주문_주문번호
            // 
            this.주문_주문번호.HeaderText = "주문번호";
            this.주문_주문번호.Name = "주문_주문번호";
            this.주문_주문번호.ReadOnly = true;
            // 
            // 주문_계좌번호
            // 
            this.주문_계좌번호.HeaderText = "계좌번호";
            this.주문_계좌번호.Name = "주문_계좌번호";
            this.주문_계좌번호.ReadOnly = true;
            // 
            // 주문_시간
            // 
            this.주문_시간.HeaderText = "시간";
            this.주문_시간.Name = "주문_시간";
            this.주문_시간.ReadOnly = true;
            // 
            // 주문_종목코드
            // 
            this.주문_종목코드.HeaderText = "종목코드";
            this.주문_종목코드.Name = "주문_종목코드";
            this.주문_종목코드.ReadOnly = true;
            // 
            // 주문_종목명
            // 
            this.주문_종목명.HeaderText = "종목명";
            this.주문_종목명.Name = "주문_종목명";
            this.주문_종목명.ReadOnly = true;
            // 
            // 주문_주문량
            // 
            this.주문_주문량.HeaderText = "주문량";
            this.주문_주문량.Name = "주문_주문량";
            this.주문_주문량.ReadOnly = true;
            // 
            // 주문_주문가
            // 
            this.주문_주문가.HeaderText = "주문가";
            this.주문_주문가.Name = "주문_주문가";
            this.주문_주문가.ReadOnly = true;
            // 
            // 주문_매매구분
            // 
            this.주문_매매구분.HeaderText = "매매구분";
            this.주문_매매구분.Name = "주문_매매구분";
            this.주문_매매구분.ReadOnly = true;
            // 
            // 주문_가격구분
            // 
            this.주문_가격구분.HeaderText = "가격구분";
            this.주문_가격구분.Name = "주문_가격구분";
            this.주문_가격구분.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.conclusionDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(605, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "체결";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // conclusionDataGridView
            // 
            this.conclusionDataGridView.AllowUserToAddRows = false;
            this.conclusionDataGridView.AllowUserToDeleteRows = false;
            this.conclusionDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.conclusionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conclusionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.체결_주문번호,
            this.체결_체결시간,
            this.체결_종목코드,
            this.체결_종목명,
            this.체결_주문량,
            this.체결_단위체결량,
            this.체결_누적체결량,
            this.체결_체결가,
            this.체결_매매구분});
            this.conclusionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conclusionDataGridView.Location = new System.Drawing.Point(3, 4);
            this.conclusionDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conclusionDataGridView.Name = "conclusionDataGridView";
            this.conclusionDataGridView.RowHeadersVisible = false;
            this.conclusionDataGridView.RowTemplate.Height = 23;
            this.conclusionDataGridView.Size = new System.Drawing.Size(599, 165);
            this.conclusionDataGridView.TabIndex = 0;
            // 
            // 체결_주문번호
            // 
            this.체결_주문번호.HeaderText = "주문번호";
            this.체결_주문번호.Name = "체결_주문번호";
            this.체결_주문번호.ReadOnly = true;
            // 
            // 체결_체결시간
            // 
            this.체결_체결시간.HeaderText = "체결시간";
            this.체결_체결시간.Name = "체결_체결시간";
            this.체결_체결시간.ReadOnly = true;
            // 
            // 체결_종목코드
            // 
            this.체결_종목코드.HeaderText = "종목코드";
            this.체결_종목코드.Name = "체결_종목코드";
            this.체결_종목코드.ReadOnly = true;
            // 
            // 체결_종목명
            // 
            this.체결_종목명.HeaderText = "종목명";
            this.체결_종목명.Name = "체결_종목명";
            this.체결_종목명.ReadOnly = true;
            // 
            // 체결_주문량
            // 
            this.체결_주문량.HeaderText = "주문량";
            this.체결_주문량.Name = "체결_주문량";
            this.체결_주문량.ReadOnly = true;
            // 
            // 체결_단위체결량
            // 
            this.체결_단위체결량.HeaderText = "단위체결량";
            this.체결_단위체결량.Name = "체결_단위체결량";
            this.체결_단위체결량.ReadOnly = true;
            // 
            // 체결_누적체결량
            // 
            this.체결_누적체결량.HeaderText = "누적체결량";
            this.체결_누적체결량.Name = "체결_누적체결량";
            this.체결_누적체결량.ReadOnly = true;
            // 
            // 체결_체결가
            // 
            this.체결_체결가.HeaderText = "체결가";
            this.체결_체결가.Name = "체결_체결가";
            this.체결_체결가.ReadOnly = true;
            // 
            // 체결_매매구분
            // 
            this.체결_매매구분.HeaderText = "매매구분";
            this.체결_매매구분.Name = "체결_매매구분";
            this.체결_매매구분.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.outstandingDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(605, 173);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "미체결";
            // 
            // outstandingDataGridView
            // 
            this.outstandingDataGridView.AllowUserToAddRows = false;
            this.outstandingDataGridView.AllowUserToDeleteRows = false;
            this.outstandingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outstandingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.outstandingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outstandingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.미체결_주문번호,
            this.미체결_종목코드,
            this.미체결_종목명,
            this.미체결_주문수량,
            this.미체결_미체결량,
            this.미체결_매매구분});
            this.outstandingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outstandingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.outstandingDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outstandingDataGridView.Name = "outstandingDataGridView";
            this.outstandingDataGridView.RowHeadersVisible = false;
            this.outstandingDataGridView.RowTemplate.Height = 23;
            this.outstandingDataGridView.Size = new System.Drawing.Size(605, 173);
            this.outstandingDataGridView.TabIndex = 0;
            // 
            // 미체결_주문번호
            // 
            this.미체결_주문번호.HeaderText = "주문번호";
            this.미체결_주문번호.Name = "미체결_주문번호";
            this.미체결_주문번호.ReadOnly = true;
            // 
            // 미체결_종목코드
            // 
            this.미체결_종목코드.HeaderText = "종목코드";
            this.미체결_종목코드.Name = "미체결_종목코드";
            this.미체결_종목코드.ReadOnly = true;
            // 
            // 미체결_종목명
            // 
            this.미체결_종목명.HeaderText = "종목명";
            this.미체결_종목명.Name = "미체결_종목명";
            this.미체결_종목명.ReadOnly = true;
            // 
            // 미체결_주문수량
            // 
            this.미체결_주문수량.HeaderText = "주문수량";
            this.미체결_주문수량.Name = "미체결_주문수량";
            this.미체결_주문수량.ReadOnly = true;
            // 
            // 미체결_미체결량
            // 
            this.미체결_미체결량.HeaderText = "미체결량";
            this.미체결_미체결량.Name = "미체결_미체결량";
            this.미체결_미체결량.ReadOnly = true;
            // 
            // 미체결_매매구분
            // 
            this.미체결_매매구분.HeaderText = "매매구분";
            this.미체결_매매구분.Name = "미체결_매매구분";
            this.미체결_매매구분.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.balanceDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(605, 173);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "잔고";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.AllowUserToAddRows = false;
            this.balanceDataGridView.AllowUserToDeleteRows = false;
            this.balanceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.잔고_계좌번호,
            this.잔고_종목코드,
            this.잔고_종목명,
            this.잔고_보유수량,
            this.잔고_주문가능수량,
            this.잔고_매입단가,
            this.잔고_총매입가,
            this.잔고_현재가,
            this.잔고_손익률});
            this.balanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balanceDataGridView.Location = new System.Drawing.Point(0, 0);
            this.balanceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowHeadersVisible = false;
            this.balanceDataGridView.RowTemplate.Height = 23;
            this.balanceDataGridView.Size = new System.Drawing.Size(605, 173);
            this.balanceDataGridView.TabIndex = 0;
            // 
            // 잔고_계좌번호
            // 
            this.잔고_계좌번호.HeaderText = "계좌번호";
            this.잔고_계좌번호.Name = "잔고_계좌번호";
            this.잔고_계좌번호.ReadOnly = true;
            // 
            // 잔고_종목코드
            // 
            this.잔고_종목코드.HeaderText = "종목코드";
            this.잔고_종목코드.Name = "잔고_종목코드";
            this.잔고_종목코드.ReadOnly = true;
            // 
            // 잔고_종목명
            // 
            this.잔고_종목명.HeaderText = "종목명";
            this.잔고_종목명.Name = "잔고_종목명";
            this.잔고_종목명.ReadOnly = true;
            // 
            // 잔고_보유수량
            // 
            this.잔고_보유수량.HeaderText = "보유수량";
            this.잔고_보유수량.Name = "잔고_보유수량";
            this.잔고_보유수량.ReadOnly = true;
            // 
            // 잔고_주문가능수량
            // 
            this.잔고_주문가능수량.HeaderText = "주문가능수량";
            this.잔고_주문가능수량.Name = "잔고_주문가능수량";
            this.잔고_주문가능수량.ReadOnly = true;
            // 
            // 잔고_매입단가
            // 
            this.잔고_매입단가.HeaderText = "매입단가";
            this.잔고_매입단가.Name = "잔고_매입단가";
            this.잔고_매입단가.ReadOnly = true;
            // 
            // 잔고_총매입가
            // 
            this.잔고_총매입가.HeaderText = "총매입가";
            this.잔고_총매입가.Name = "잔고_총매입가";
            this.잔고_총매입가.ReadOnly = true;
            // 
            // 잔고_현재가
            // 
            dataGridViewCellStyle38.Format = "N0";
            dataGridViewCellStyle38.NullValue = null;
            this.잔고_현재가.DefaultCellStyle = dataGridViewCellStyle38;
            this.잔고_현재가.HeaderText = "현재가";
            this.잔고_현재가.Name = "잔고_현재가";
            this.잔고_현재가.ReadOnly = true;
            // 
            // 잔고_손익률
            // 
            dataGridViewCellStyle39.Format = "N2";
            dataGridViewCellStyle39.NullValue = null;
            this.잔고_손익률.DefaultCellStyle = dataGridViewCellStyle39;
            this.잔고_손익률.HeaderText = "손익률";
            this.잔고_손익률.Name = "잔고_손익률";
            this.잔고_손익률.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.autoTradingDataGridView);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(35, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1108, 548);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // autoTradingDataGridView
            // 
            this.autoTradingDataGridView.AllowUserToAddRows = false;
            this.autoTradingDataGridView.AllowUserToDeleteRows = false;
            this.autoTradingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoTradingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.autoTradingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.autoTradingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoTradingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.매매진행_진행상황,
            this.매매진행_종목코드,
            this.매매진행_종목명,
            this.매매진행_매수조건식,
            this.매매진행_주문량,
            this.매매진행_매수량,
            this.매매진행_매수가,
            this.매매진행_매수금,
            this.매매진행_매도가,
            this.매매진행_현재가,
            this.매매진행_손익률,
            this.매매진행_평가손익,
            this.매매진행_매수시간,
            this.매매진행_매도시간,
            this.매매진행_청산});
            this.autoTradingDataGridView.Location = new System.Drawing.Point(1, 15);
            this.autoTradingDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoTradingDataGridView.Name = "autoTradingDataGridView";
            this.autoTradingDataGridView.RowHeadersVisible = false;
            this.autoTradingDataGridView.RowTemplate.Height = 23;
            this.autoTradingDataGridView.Size = new System.Drawing.Size(1104, 525);
            this.autoTradingDataGridView.TabIndex = 0;
            this.autoTradingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoTradingDataGridView_CellContentClick);
            // 
            // 매매진행_진행상황
            // 
            this.매매진행_진행상황.HeaderText = "진행상황";
            this.매매진행_진행상황.Name = "매매진행_진행상황";
            this.매매진행_진행상황.ReadOnly = true;
            // 
            // 매매진행_종목코드
            // 
            this.매매진행_종목코드.HeaderText = "종목코드";
            this.매매진행_종목코드.Name = "매매진행_종목코드";
            this.매매진행_종목코드.ReadOnly = true;
            // 
            // 매매진행_종목명
            // 
            this.매매진행_종목명.HeaderText = "종목명";
            this.매매진행_종목명.Name = "매매진행_종목명";
            this.매매진행_종목명.ReadOnly = true;
            // 
            // 매매진행_매수조건식
            // 
            this.매매진행_매수조건식.HeaderText = "매수조건식";
            this.매매진행_매수조건식.Name = "매매진행_매수조건식";
            this.매매진행_매수조건식.ReadOnly = true;
            // 
            // 매매진행_주문량
            // 
            this.매매진행_주문량.HeaderText = "주문량";
            this.매매진행_주문량.Name = "매매진행_주문량";
            // 
            // 매매진행_매수량
            // 
            this.매매진행_매수량.HeaderText = "매수량";
            this.매매진행_매수량.Name = "매매진행_매수량";
            this.매매진행_매수량.ReadOnly = true;
            // 
            // 매매진행_매수가
            // 
            this.매매진행_매수가.HeaderText = "매수가";
            this.매매진행_매수가.Name = "매매진행_매수가";
            this.매매진행_매수가.ReadOnly = true;
            // 
            // 매매진행_매수금
            // 
            this.매매진행_매수금.HeaderText = "매수금";
            this.매매진행_매수금.Name = "매매진행_매수금";
            this.매매진행_매수금.ReadOnly = true;
            // 
            // 매매진행_매도가
            // 
            this.매매진행_매도가.HeaderText = "매도가";
            this.매매진행_매도가.Name = "매매진행_매도가";
            this.매매진행_매도가.ReadOnly = true;
            // 
            // 매매진행_현재가
            // 
            this.매매진행_현재가.HeaderText = "현재가";
            this.매매진행_현재가.Name = "매매진행_현재가";
            // 
            // 매매진행_손익률
            // 
            this.매매진행_손익률.HeaderText = "손익률";
            this.매매진행_손익률.Name = "매매진행_손익률";
            this.매매진행_손익률.ReadOnly = true;
            // 
            // 매매진행_평가손익
            // 
            this.매매진행_평가손익.HeaderText = "평가손익";
            this.매매진행_평가손익.Name = "매매진행_평가손익";
            this.매매진행_평가손익.ReadOnly = true;
            // 
            // 매매진행_매수시간
            // 
            this.매매진행_매수시간.HeaderText = "매수시간";
            this.매매진행_매수시간.Name = "매매진행_매수시간";
            this.매매진행_매수시간.ReadOnly = true;
            // 
            // 매매진행_매도시간
            // 
            this.매매진행_매도시간.HeaderText = "매도시간";
            this.매매진행_매도시간.Name = "매매진행_매도시간";
            this.매매진행_매도시간.ReadOnly = true;
            // 
            // 매매진행_청산
            // 
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.NullValue = "주문취소";
            this.매매진행_청산.DefaultCellStyle = dataGridViewCellStyle41;
            this.매매진행_청산.HeaderText = "청산";
            this.매매진행_청산.Name = "매매진행_청산";
            this.매매진행_청산.ReadOnly = true;
            this.매매진행_청산.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.매매진행_청산.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0012F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0012F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.d2AssetLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.assetLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.investmentLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.profitLabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.profitRateLabel, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(359, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 71);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // d2AssetLabel
            // 
            this.d2AssetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d2AssetLabel.ForeColor = System.Drawing.Color.Black;
            this.d2AssetLabel.Location = new System.Drawing.Point(158, 36);
            this.d2AssetLabel.Margin = new System.Windows.Forms.Padding(1);
            this.d2AssetLabel.Name = "d2AssetLabel";
            this.d2AssetLabel.Size = new System.Drawing.Size(155, 34);
            this.d2AssetLabel.TabIndex = 7;
            this.d2AssetLabel.Text = "0";
            this.d2AssetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(158, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "D+2추정예수금(예탁자산평가액)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetLabel
            // 
            this.assetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetLabel.ForeColor = System.Drawing.Color.Black;
            this.assetLabel.Location = new System.Drawing.Point(1, 36);
            this.assetLabel.Margin = new System.Windows.Forms.Padding(1);
            this.assetLabel.Name = "assetLabel";
            this.assetLabel.Size = new System.Drawing.Size(155, 34);
            this.assetLabel.TabIndex = 6;
            this.assetLabel.Text = "0";
            this.assetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(315, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 33);
            this.label13.TabIndex = 3;
            this.label13.Text = "당일투자원금";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(472, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 33);
            this.label14.TabIndex = 4;
            this.label14.Text = "당일투자손익";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(629, 1);
            this.label15.Margin = new System.Windows.Forms.Padding(1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 33);
            this.label15.TabIndex = 5;
            this.label15.Text = "당일손익률";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // investmentLabel
            // 
            this.investmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.investmentLabel.ForeColor = System.Drawing.Color.Black;
            this.investmentLabel.Location = new System.Drawing.Point(315, 36);
            this.investmentLabel.Margin = new System.Windows.Forms.Padding(1);
            this.investmentLabel.Name = "investmentLabel";
            this.investmentLabel.Size = new System.Drawing.Size(155, 34);
            this.investmentLabel.TabIndex = 9;
            this.investmentLabel.Text = "0";
            this.investmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profitLabel
            // 
            this.profitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitLabel.ForeColor = System.Drawing.Color.Black;
            this.profitLabel.Location = new System.Drawing.Point(472, 36);
            this.profitLabel.Margin = new System.Windows.Forms.Padding(1);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(155, 34);
            this.profitLabel.TabIndex = 10;
            this.profitLabel.Text = "0";
            this.profitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "예수금";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profitRateLabel
            // 
            this.profitRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profitRateLabel.ForeColor = System.Drawing.Color.Black;
            this.profitRateLabel.Location = new System.Drawing.Point(629, 36);
            this.profitRateLabel.Margin = new System.Windows.Forms.Padding(1);
            this.profitRateLabel.Name = "profitRateLabel";
            this.profitRateLabel.Size = new System.Drawing.Size(157, 34);
            this.profitRateLabel.TabIndex = 11;
            this.profitRateLabel.Text = "0";
            this.profitRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountBalanceDataGridView
            // 
            this.accountBalanceDataGridView.AllowUserToAddRows = false;
            this.accountBalanceDataGridView.AllowUserToDeleteRows = false;
            this.accountBalanceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.accountBalanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountBalanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.계좌잔고_종목코드,
            this.계좌잔고_종목명,
            this.계좌잔고_보유수량,
            this.계좌잔고_평균단가,
            this.계좌잔고_손익률,
            this.계좌잔고_평가금액,
            this.계좌잔고_매입금액,
            this.계좌잔고_손익금액,
            this.계좌잔고_청산});
            this.accountBalanceDataGridView.Location = new System.Drawing.Point(1160, 806);
            this.accountBalanceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountBalanceDataGridView.MultiSelect = false;
            this.accountBalanceDataGridView.Name = "accountBalanceDataGridView";
            this.accountBalanceDataGridView.RowHeadersVisible = false;
            this.accountBalanceDataGridView.RowTemplate.Height = 23;
            this.accountBalanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountBalanceDataGridView.Size = new System.Drawing.Size(616, 135);
            this.accountBalanceDataGridView.TabIndex = 8;
            this.accountBalanceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountBalanceDataGridView_CellContentClick);
            // 
            // 계좌잔고_종목코드
            // 
            this.계좌잔고_종목코드.HeaderText = "종목코드";
            this.계좌잔고_종목코드.Name = "계좌잔고_종목코드";
            this.계좌잔고_종목코드.ReadOnly = true;
            // 
            // 계좌잔고_종목명
            // 
            this.계좌잔고_종목명.HeaderText = "종목명";
            this.계좌잔고_종목명.Name = "계좌잔고_종목명";
            this.계좌잔고_종목명.ReadOnly = true;
            // 
            // 계좌잔고_보유수량
            // 
            dataGridViewCellStyle42.Format = "N0";
            dataGridViewCellStyle42.NullValue = null;
            this.계좌잔고_보유수량.DefaultCellStyle = dataGridViewCellStyle42;
            this.계좌잔고_보유수량.HeaderText = "보유수량";
            this.계좌잔고_보유수량.Name = "계좌잔고_보유수량";
            this.계좌잔고_보유수량.ReadOnly = true;
            // 
            // 계좌잔고_평균단가
            // 
            dataGridViewCellStyle43.Format = "N2";
            dataGridViewCellStyle43.NullValue = null;
            this.계좌잔고_평균단가.DefaultCellStyle = dataGridViewCellStyle43;
            this.계좌잔고_평균단가.HeaderText = "평균단가";
            this.계좌잔고_평균단가.Name = "계좌잔고_평균단가";
            this.계좌잔고_평균단가.ReadOnly = true;
            // 
            // 계좌잔고_손익률
            // 
            dataGridViewCellStyle44.Format = "N2";
            dataGridViewCellStyle44.NullValue = null;
            this.계좌잔고_손익률.DefaultCellStyle = dataGridViewCellStyle44;
            this.계좌잔고_손익률.HeaderText = "손익률";
            this.계좌잔고_손익률.Name = "계좌잔고_손익률";
            this.계좌잔고_손익률.ReadOnly = true;
            // 
            // 계좌잔고_평가금액
            // 
            dataGridViewCellStyle45.Format = "N0";
            dataGridViewCellStyle45.NullValue = null;
            this.계좌잔고_평가금액.DefaultCellStyle = dataGridViewCellStyle45;
            this.계좌잔고_평가금액.HeaderText = "평가금액";
            this.계좌잔고_평가금액.Name = "계좌잔고_평가금액";
            this.계좌잔고_평가금액.ReadOnly = true;
            // 
            // 계좌잔고_매입금액
            // 
            dataGridViewCellStyle46.Format = "N0";
            dataGridViewCellStyle46.NullValue = null;
            this.계좌잔고_매입금액.DefaultCellStyle = dataGridViewCellStyle46;
            this.계좌잔고_매입금액.HeaderText = "매입금액";
            this.계좌잔고_매입금액.Name = "계좌잔고_매입금액";
            this.계좌잔고_매입금액.ReadOnly = true;
            // 
            // 계좌잔고_손익금액
            // 
            dataGridViewCellStyle47.Format = "N0";
            dataGridViewCellStyle47.NullValue = null;
            this.계좌잔고_손익금액.DefaultCellStyle = dataGridViewCellStyle47;
            this.계좌잔고_손익금액.HeaderText = "손익금액";
            this.계좌잔고_손익금액.Name = "계좌잔고_손익금액";
            this.계좌잔고_손익금액.ReadOnly = true;
            // 
            // 계좌잔고_청산
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.NullValue = "청산";
            this.계좌잔고_청산.DefaultCellStyle = dataGridViewCellStyle48;
            this.계좌잔고_청산.HeaderText = "청산";
            this.계좌잔고_청산.Name = "계좌잔고_청산";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "123123123.png");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.Window;
            this.label25.Location = new System.Drawing.Point(50, 742);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 15);
            this.label25.TabIndex = 9;
            this.label25.Text = "매매전략";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.Window;
            this.label26.Location = new System.Drawing.Point(50, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 15);
            this.label26.TabIndex = 10;
            this.label26.Text = "매매진행상황";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(38, 740);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(6, 19);
            this.label27.TabIndex = 11;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Aquamarine;
            this.label28.Location = new System.Drawing.Point(38, 135);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(6, 19);
            this.label28.TabIndex = 12;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Aquamarine;
            this.label29.Location = new System.Drawing.Point(38, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(6, 19);
            this.label29.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Aquamarine;
            this.label30.Location = new System.Drawing.Point(1166, 776);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(6, 19);
            this.label30.TabIndex = 15;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.Window;
            this.label31.Location = new System.Drawing.Point(1178, 780);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 15);
            this.label31.TabIndex = 14;
            this.label31.Text = "보유종목";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Aquamarine;
            this.label32.Location = new System.Drawing.Point(1154, 527);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(6, 19);
            this.label32.TabIndex = 17;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.Window;
            this.label33.Location = new System.Drawing.Point(1166, 531);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 15);
            this.label33.TabIndex = 16;
            this.label33.Text = "주문";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1161, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 479);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.TimerFunction);
            // 
            // SetaccountbalanceBtn
            // 
            this.SetaccountbalanceBtn.Location = new System.Drawing.Point(1028, 122);
            this.SetaccountbalanceBtn.Name = "SetaccountbalanceBtn";
            this.SetaccountbalanceBtn.Size = new System.Drawing.Size(118, 23);
            this.SetaccountbalanceBtn.TabIndex = 18;
            this.SetaccountbalanceBtn.Text = " 업데이트";
            this.SetaccountbalanceBtn.UseVisualStyleBackColor = true;
            this.SetaccountbalanceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Tag = "test";
            this.notifyIcon1.Text = "Ornda";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.trayItem_clicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Tag = "OPEN";
            this.toolStripMenuItem1.Text = "창 활성화";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Tag = "EXIT";
            this.toolStripMenuItem2.Text = "프로그램 종료";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Tag = "ACCOUNT";
            this.toolStripMenuItem3.Text = "로그인";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1808, 1061);
            this.Controls.Add(this.SetaccountbalanceBtn);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.accountBalanceDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tradingStrategyDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopLossNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takeProfitNumbericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentNumericUpDown)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceStopLossNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTakeProfitNumbericUpDown)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceQntNumericUpDown)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conclusionDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outstandingDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoTradingDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBalanceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tradingStrategyDataGridView;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label itemInvestmentLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown itemCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown investmentNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox buyingOrderOptionComboBox;
        private System.Windows.Forms.RadioButton SelectedPriceRadioButton;
        private System.Windows.Forms.RadioButton marketPriceRadioButton;
        private System.Windows.Forms.ComboBox buyingConditionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createStrategyButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView conclusionDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView outstandingDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_주문번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_계좌번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_주문량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_주문가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_매매구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문_가격구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_주문번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_체결시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_주문량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_단위체결량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_누적체결량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_체결가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 체결_매매구분;
        private System.Windows.Forms.NumericUpDown takeProfitNumbericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox takeProfitCheckBox;
        private System.Windows.Forms.NumericUpDown stopLossNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox stopLossCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView autoTradingDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label profitRateLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.Label investmentLabel;
        private System.Windows.Forms.Label d2AssetLabel;
        private System.Windows.Forms.Label assetLabel;
        private System.Windows.Forms.DataGridView accountBalanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_보유수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_평균단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_손익률;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_평가금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_매입금액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 계좌잔고_손익금액;
        private System.Windows.Forms.DataGridViewButtonColumn 계좌잔고_청산;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown balanceStopLossNumericUpDown;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox balanceStopLossCheckBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.NumericUpDown balanceTakeProfitNumbericUpDown;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox balanceTakeProfitCheckBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label balanceAvgPriceLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown balanceQntNumericUpDown;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox balanceItemNameTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox balanceItemCodeTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_계좌번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_매수조건식;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_매수가격;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_총투자금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_매수종목수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_종목당투자금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_익절;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_익절률;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_손절;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매전략_손절률;
        private System.Windows.Forms.DataGridViewButtonColumn 매매전략_취소;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button AddInterestButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.ListBox interestItemListBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox interestConditionListBox;
        private System.Windows.Forms.CheckBox onlyInterestCheckBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button balanceSellButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_주문수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_미체결량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 미체결_매매구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_계좌번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_보유수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_주문가능수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_매입단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_총매입가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 잔고_손익률;
        private System.Windows.Forms.Button SetaccountbalanceBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_진행상황;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_종목코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_종목명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매수조건식;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_주문량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매수가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매수금;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매도가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_현재가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_손익률;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_평가손익;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매수시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매매진행_매도시간;
        private System.Windows.Forms.DataGridViewButtonColumn 매매진행_청산;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

