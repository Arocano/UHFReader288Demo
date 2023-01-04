namespace UHFReader288Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Maintab = new System.Windows.Forms.TabControl();
            this.Main_Page1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Basic = new System.Windows.Forms.TabPage();
            this.gbReturnLoss = new System.Windows.Forms.GroupBox();
            this.cbbAnt = new System.Windows.Forms.ComboBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.cmbReturnLossFreq = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.textReturnLoss = new System.Windows.Forms.TextBox();
            this.btReturnLoss = new System.Windows.Forms.Button();
            this.gbCmdTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetReaderTemperature = new System.Windows.Forms.Button();
            this.txtReaderTemperature = new System.Windows.Forms.TextBox();
            this.gbp_DRM = new System.Windows.Forms.GroupBox();
            this.DRM_CLOSE = new System.Windows.Forms.RadioButton();
            this.DRM_OPEN = new System.Windows.Forms.RadioButton();
            this.bt_GetDRM = new System.Windows.Forms.Button();
            this.bt_setDRM = new System.Windows.Forms.Button();
            this.gbp_Retry = new System.Windows.Forms.GroupBox();
            this.com_retrytimes = new System.Windows.Forms.ComboBox();
            this.bt_Getretry = new System.Windows.Forms.Button();
            this.bt_Setretry = new System.Windows.Forms.Button();
            this.gbp_wpower = new System.Windows.Forms.GroupBox();
            this.label112 = new System.Windows.Forms.Label();
            this.com_wpower = new System.Windows.Forms.ComboBox();
            this.rb_wp2 = new System.Windows.Forms.RadioButton();
            this.rb_wp1 = new System.Windows.Forms.RadioButton();
            this.bt_GetWpower = new System.Windows.Forms.Button();
            this.bt_SetWpower = new System.Windows.Forms.Button();
            this.group_maxtime = new System.Windows.Forms.GroupBox();
            this.comboBox_maxtime = new System.Windows.Forms.ComboBox();
            this.btSetMaxtime = new System.Windows.Forms.Button();
            this.gbp_buff = new System.Windows.Forms.GroupBox();
            this.rb496 = new System.Windows.Forms.RadioButton();
            this.rb128 = new System.Windows.Forms.RadioButton();
            this.btGetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btSetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btGetInformation = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.btFlashROM = new System.Windows.Forms.Button();
            this.gpb_clock = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Text_sec = new System.Windows.Forms.TextBox();
            this.Text_min = new System.Windows.Forms.TextBox();
            this.Text_hour = new System.Windows.Forms.TextBox();
            this.Text_day = new System.Windows.Forms.TextBox();
            this.Text_month = new System.Windows.Forms.TextBox();
            this.Text_year = new System.Windows.Forms.TextBox();
            this.ClockCMD = new System.Windows.Forms.Button();
            this.GetClock = new System.Windows.Forms.RadioButton();
            this.SetClock = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.gpb_antconfig = new System.Windows.Forms.GroupBox();
            this.Button_Ant = new System.Windows.Forms.Button();
            this.checkant4 = new System.Windows.Forms.CheckBox();
            this.checkant3 = new System.Windows.Forms.CheckBox();
            this.checkant2 = new System.Windows.Forms.CheckBox();
            this.checkant1 = new System.Windows.Forms.CheckBox();
            this.gpb_checkant = new System.Windows.Forms.GroupBox();
            this.btSetcheckant = new System.Windows.Forms.Button();
            this.rb_Closecheckant = new System.Windows.Forms.RadioButton();
            this.rb_Opencheckant = new System.Windows.Forms.RadioButton();
            this.gpb_GPIO = new System.Windows.Forms.GroupBox();
            this.Button_GetGPIO = new System.Windows.Forms.Button();
            this.Button_SetGPIO = new System.Windows.Forms.Button();
            this.check_int4 = new System.Windows.Forms.CheckBox();
            this.check_int3 = new System.Windows.Forms.CheckBox();
            this.check_int2 = new System.Windows.Forms.CheckBox();
            this.check_int1 = new System.Windows.Forms.CheckBox();
            this.check_out4 = new System.Windows.Forms.CheckBox();
            this.check_out3 = new System.Windows.Forms.CheckBox();
            this.check_out2 = new System.Windows.Forms.CheckBox();
            this.check_out1 = new System.Windows.Forms.CheckBox();
            this.gpb_OutputRep = new System.Windows.Forms.GroupBox();
            this.btOutputRep = new System.Windows.Forms.Button();
            this.check_OutputRep4 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep3 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep2 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep1 = new System.Windows.Forms.CheckBox();
            this.gpb_Relay = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.ComboBox_RelayTime = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btRelay = new System.Windows.Forms.Button();
            this.gpb_baud = new System.Windows.Forms.GroupBox();
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.btBaudRate = new System.Windows.Forms.Button();
            this.gpb_DBM = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_PowerDbm = new System.Windows.Forms.ComboBox();
            this.BT_DBM = new System.Windows.Forms.Button();
            this.gpb_Freq = new System.Windows.Forms.GroupBox();
            this.radioButton_band12 = new System.Windows.Forms.RadioButton();
            this.radioButton_band8 = new System.Windows.Forms.RadioButton();
            this.CheckBox_SameFre = new System.Windows.Forms.CheckBox();
            this.radioButton_band4 = new System.Windows.Forms.RadioButton();
            this.radioButton_band3 = new System.Windows.Forms.RadioButton();
            this.radioButton_band2 = new System.Windows.Forms.RadioButton();
            this.radioButton_band1 = new System.Windows.Forms.RadioButton();
            this.btFreq = new System.Windows.Forms.Button();
            this.ComboBox_dmaxfre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboBox_dminfre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpb_beep = new System.Windows.Forms.GroupBox();
            this.Radio_beepDis = new System.Windows.Forms.RadioButton();
            this.Radio_beepEn = new System.Windows.Forms.RadioButton();
            this.Button_Beep = new System.Windows.Forms.Button();
            this.gpb_RDVersion = new System.Windows.Forms.GroupBox();
            this.text_RDVersion = new System.Windows.Forms.TextBox();
            this.gpb_MDVersion = new System.Windows.Forms.GroupBox();
            this.text_MDVersion = new System.Windows.Forms.TextBox();
            this.btMDVersion = new System.Windows.Forms.Button();
            this.gpb_Serial = new System.Windows.Forms.GroupBox();
            this.text_Serial = new System.Windows.Forms.TextBox();
            this.btSerial = new System.Windows.Forms.Button();
            this.gpb_address = new System.Windows.Forms.GroupBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.btaddress = new System.Windows.Forms.Button();
            this.gpb_tcp = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.ipServerIP = new CustomControl.IpAddressTextBox();
            this.btDisConnectTcp = new System.Windows.Forms.Button();
            this.btConnectTcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_rs232 = new System.Windows.Forms.GroupBox();
            this.btDisConnect232 = new System.Windows.Forms.Button();
            this.btConnect232 = new System.Windows.Forms.Button();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tcp = new System.Windows.Forms.RadioButton();
            this.rb_rs232 = new System.Windows.Forms.RadioButton();
            this.tabPage_Mx = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbp_trigger = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.bttrigger = new System.Windows.Forms.Button();
            this.comboBox_trigger = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.btGetQS = new System.Windows.Forms.Button();
            this.btSetQS = new System.Windows.Forms.Button();
            this.com_acS = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.com_acQ = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.text_tidlen = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.text_tidaddr = new System.Windows.Forms.TextBox();
            this.btTIDpara = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.btGetWorkmodepara = new System.Windows.Forms.Button();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.btworkmode = new System.Windows.Forms.Button();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.btInterval = new System.Windows.Forms.Button();
            this.comboBox_intervalT = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.gbp_tagType = new System.Windows.Forms.GroupBox();
            this.rb_G2TID = new System.Windows.Forms.RadioButton();
            this.bt_typeTag = new System.Windows.Forms.Button();
            this.rb_EAS = new System.Windows.Forms.RadioButton();
            this.rb_G2 = new System.Windows.Forms.RadioButton();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.rb_180006B = new System.Windows.Forms.RadioButton();
            this.rb_180006c = new System.Windows.Forms.RadioButton();
            this.gbp_Response = new System.Windows.Forms.GroupBox();
            this.btResponse = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.comboBox_RespTime = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox_Resp = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.gbp_mask = new System.Windows.Forms.GroupBox();
            this.btMaskSet = new System.Windows.Forms.Button();
            this.text_mdata = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.text_mlen = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.text_madds = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.rb_MaskUser = new System.Windows.Forms.RadioButton();
            this.rb_MaskTID = new System.Windows.Forms.RadioButton();
            this.rb_MaskEPC = new System.Windows.Forms.RadioButton();
            this.gbp_EASAcc = new System.Windows.Forms.GroupBox();
            this.btAccuracy = new System.Windows.Forms.Button();
            this.ComboBox_Accuracy = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbEASAcc = new System.Windows.Forms.RadioButton();
            this.tabPage_Module = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMSetParameter = new System.Windows.Forms.Button();
            this.btMGetParameter = new System.Windows.Forms.Button();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.btSetMmode = new System.Windows.Forms.Button();
            this.com_Mmode = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.checkBox_tid = new System.Windows.Forms.CheckBox();
            this.txt_Mtidlen = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_mtidaddr = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.txt_Mdata = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txt_Mlen = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_Maddr = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.RBM_USER = new System.Windows.Forms.RadioButton();
            this.RBM_TID = new System.Windows.Forms.RadioButton();
            this.RBM_EPC = new System.Windows.Forms.RadioButton();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.com_MS = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.com_MQ = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.com_MFliterTime = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.COM_MRPTime = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MRB_6B = new System.Windows.Forms.RadioButton();
            this.MRB_G2 = new System.Windows.Forms.RadioButton();
            this.Main_Page2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_answer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbp_MixRead = new System.Windows.Forms.GroupBox();
            this.text_readpsd = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.text_readLen = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.text_readadr = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.com_MixMem = new System.Windows.Forms.ComboBox();
            this.label114 = new System.Windows.Forms.Label();
            this.lxLedControl5 = new LxControl.LxLedControl();
            this.label9 = new System.Windows.Forms.Label();
            this.lxLedControl1 = new LxControl.LxLedControl();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_rate = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.text_target = new System.Windows.Forms.TextBox();
            this.check_num = new System.Windows.Forms.CheckBox();
            this.com_Target = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.com_scantime = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.com_S = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.com_Q = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.group_ant1 = new System.Windows.Forms.GroupBox();
            this.check_ant4 = new System.Windows.Forms.CheckBox();
            this.check_ant3 = new System.Windows.Forms.CheckBox();
            this.check_ant2 = new System.Windows.Forms.CheckBox();
            this.check_ant1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_fastid = new System.Windows.Forms.RadioButton();
            this.rb_mix = new System.Windows.Forms.RadioButton();
            this.rb_tid = new System.Windows.Forms.RadioButton();
            this.rb_epc = new System.Windows.Forms.RadioButton();
            this.btIventoryG2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Main_Page3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.text_Statu6B = new System.Windows.Forms.TextBox();
            this.btCheckLock6B = new System.Windows.Forms.Button();
            this.btLock6B = new System.Windows.Forms.Button();
            this.text_checkaddr = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.text_lock6b = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.text_W6B = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btWrite6B = new System.Windows.Forms.Button();
            this.text_W6BLen = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.text_W6BAddr = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.text_R6B = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btRead6B = new System.Windows.Forms.Button();
            this.text_R6BLen = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.text_R6BAddr = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.text_6BUID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ListView_ID_6B = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rb_mutiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.btInventory6B = new System.Windows.Forms.Button();
            this.btFlashCl = new System.Windows.Forms.Button();
            this.timer_answer = new System.Windows.Forms.Timer(this.components);
            this.timer_runmode = new System.Windows.Forms.Timer(this.components);
            this.timer_EAS = new System.Windows.Forms.Timer(this.components);
            this.Timer_Test_6B = new System.Windows.Forms.Timer(this.components);
            this.timer_Buff = new System.Windows.Forms.Timer(this.components);
            this.timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.ckClearOperationRec = new System.Windows.Forms.CheckBox();
            this.Maintab.SuspendLayout();
            this.Main_Page1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Basic.SuspendLayout();
            this.gbReturnLoss.SuspendLayout();
            this.gbCmdTemperature.SuspendLayout();
            this.gbp_DRM.SuspendLayout();
            this.gbp_Retry.SuspendLayout();
            this.gbp_wpower.SuspendLayout();
            this.group_maxtime.SuspendLayout();
            this.gbp_buff.SuspendLayout();
            this.gpb_clock.SuspendLayout();
            this.gpb_antconfig.SuspendLayout();
            this.gpb_checkant.SuspendLayout();
            this.gpb_GPIO.SuspendLayout();
            this.gpb_OutputRep.SuspendLayout();
            this.gpb_Relay.SuspendLayout();
            this.gpb_baud.SuspendLayout();
            this.gpb_DBM.SuspendLayout();
            this.gpb_Freq.SuspendLayout();
            this.gpb_beep.SuspendLayout();
            this.gpb_RDVersion.SuspendLayout();
            this.gpb_MDVersion.SuspendLayout();
            this.gpb_Serial.SuspendLayout();
            this.gpb_address.SuspendLayout();
            this.gpb_tcp.SuspendLayout();
            this.gpb_rs232.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Mx.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbp_trigger.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.gbp_tagType.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.gbp_Response.SuspendLayout();
            this.gbp_mask.SuspendLayout();
            this.gbp_EASAcc.SuspendLayout();
            this.tabPage_Module.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Main_Page2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_answer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbp_MixRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.group_ant1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Main_Page3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lrtxtLog.EnableAutoDragDrop = true;
            this.lrtxtLog.Location = new System.Drawing.Point(-1, 685);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1080, 96);
            this.lrtxtLog.TabIndex = 0;
            this.lrtxtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation records:";
            // 
            // Maintab
            // 
            this.Maintab.Controls.Add(this.Main_Page1);
            this.Maintab.Controls.Add(this.Main_Page2);
            this.Maintab.Controls.Add(this.Main_Page3);
            this.Maintab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maintab.ItemSize = new System.Drawing.Size(72, 23);
            this.Maintab.Location = new System.Drawing.Point(0, 0);
            this.Maintab.Multiline = true;
            this.Maintab.Name = "Maintab";
            this.Maintab.SelectedIndex = 0;
            this.Maintab.Size = new System.Drawing.Size(1079, 652);
            this.Maintab.TabIndex = 3;
            this.Maintab.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // Main_Page1
            // 
            this.Main_Page1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Page1.Controls.Add(this.tabControl1);
            this.Main_Page1.Location = new System.Drawing.Point(4, 27);
            this.Main_Page1.Name = "Main_Page1";
            this.Main_Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page1.Size = new System.Drawing.Size(1071, 621);
            this.Main_Page1.TabIndex = 0;
            this.Main_Page1.Text = "   Command  ";
            this.Main_Page1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Basic);
            this.tabControl1.Controls.Add(this.tabPage_Mx);
            this.tabControl1.Controls.Add(this.tabPage_Module);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(84, 23);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 615);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_Basic
            // 
            this.tabPage_Basic.Controls.Add(this.gbReturnLoss);
            this.tabPage_Basic.Controls.Add(this.gbCmdTemperature);
            this.tabPage_Basic.Controls.Add(this.gbp_DRM);
            this.tabPage_Basic.Controls.Add(this.gbp_Retry);
            this.tabPage_Basic.Controls.Add(this.gbp_wpower);
            this.tabPage_Basic.Controls.Add(this.group_maxtime);
            this.tabPage_Basic.Controls.Add(this.gbp_buff);
            this.tabPage_Basic.Controls.Add(this.btGetInformation);
            this.tabPage_Basic.Controls.Add(this.btDefault);
            this.tabPage_Basic.Controls.Add(this.btFlashROM);
            this.tabPage_Basic.Controls.Add(this.gpb_clock);
            this.tabPage_Basic.Controls.Add(this.gpb_antconfig);
            this.tabPage_Basic.Controls.Add(this.gpb_checkant);
            this.tabPage_Basic.Controls.Add(this.gpb_GPIO);
            this.tabPage_Basic.Controls.Add(this.gpb_OutputRep);
            this.tabPage_Basic.Controls.Add(this.gpb_Relay);
            this.tabPage_Basic.Controls.Add(this.gpb_baud);
            this.tabPage_Basic.Controls.Add(this.gpb_DBM);
            this.tabPage_Basic.Controls.Add(this.gpb_Freq);
            this.tabPage_Basic.Controls.Add(this.gpb_beep);
            this.tabPage_Basic.Controls.Add(this.gpb_RDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_MDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_Serial);
            this.tabPage_Basic.Controls.Add(this.gpb_address);
            this.tabPage_Basic.Controls.Add(this.gpb_tcp);
            this.tabPage_Basic.Controls.Add(this.gpb_rs232);
            this.tabPage_Basic.Controls.Add(this.groupBox1);
            this.tabPage_Basic.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Basic.Name = "tabPage_Basic";
            this.tabPage_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Basic.Size = new System.Drawing.Size(1057, 584);
            this.tabPage_Basic.TabIndex = 0;
            this.tabPage_Basic.Text = "  Basic  ";
            this.tabPage_Basic.UseVisualStyleBackColor = true;
            // 
            // gbReturnLoss
            // 
            this.gbReturnLoss.BackColor = System.Drawing.Color.Transparent;
            this.gbReturnLoss.Controls.Add(this.cbbAnt);
            this.gbReturnLoss.Controls.Add(this.label120);
            this.gbReturnLoss.Controls.Add(this.label121);
            this.gbReturnLoss.Controls.Add(this.cmbReturnLossFreq);
            this.gbReturnLoss.Controls.Add(this.label122);
            this.gbReturnLoss.Controls.Add(this.textReturnLoss);
            this.gbReturnLoss.Controls.Add(this.btReturnLoss);
            this.gbReturnLoss.ForeColor = System.Drawing.Color.Black;
            this.gbReturnLoss.Location = new System.Drawing.Point(704, 365);
            this.gbReturnLoss.Name = "gbReturnLoss";
            this.gbReturnLoss.Size = new System.Drawing.Size(341, 50);
            this.gbReturnLoss.TabIndex = 77;
            this.gbReturnLoss.TabStop = false;
            this.gbReturnLoss.Text = "Measuring antenna ports Return Loss";
            // 
            // cbbAnt
            // 
            this.cbbAnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnt.FormattingEnabled = true;
            this.cbbAnt.Items.AddRange(new object[] {
            "Ant1",
            "Ant2",
            "Ant3",
            "Ant4"});
            this.cbbAnt.Location = new System.Drawing.Point(198, 20);
            this.cbbAnt.Name = "cbbAnt";
            this.cbbAnt.Size = new System.Drawing.Size(70, 21);
            this.cbbAnt.TabIndex = 16;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(86, 24);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(18, 13);
            this.label120.TabIndex = 15;
            this.label120.Text = "@";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(170, 24);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(29, 13);
            this.label121.TabIndex = 14;
            this.label121.Text = "MHz";
            // 
            // cmbReturnLossFreq
            // 
            this.cmbReturnLossFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnLossFreq.FormattingEnabled = true;
            this.cmbReturnLossFreq.Location = new System.Drawing.Point(97, 20);
            this.cmbReturnLossFreq.Name = "cmbReturnLossFreq";
            this.cmbReturnLossFreq.Size = new System.Drawing.Size(71, 21);
            this.cmbReturnLossFreq.TabIndex = 13;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(11, 24);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(24, 13);
            this.label122.TabIndex = 12;
            this.label122.Text = "RL:";
            // 
            // textReturnLoss
            // 
            this.textReturnLoss.Location = new System.Drawing.Point(40, 20);
            this.textReturnLoss.Name = "textReturnLoss";
            this.textReturnLoss.ReadOnly = true;
            this.textReturnLoss.Size = new System.Drawing.Size(44, 20);
            this.textReturnLoss.TabIndex = 11;
            this.textReturnLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReturnLoss
            // 
            this.btReturnLoss.Location = new System.Drawing.Point(276, 16);
            this.btReturnLoss.Name = "btReturnLoss";
            this.btReturnLoss.Size = new System.Drawing.Size(55, 25);
            this.btReturnLoss.TabIndex = 10;
            this.btReturnLoss.Text = "Get";
            this.btReturnLoss.UseVisualStyleBackColor = true;
            this.btReturnLoss.Click += new System.EventHandler(this.btReturnLoss_Click);
            // 
            // gbCmdTemperature
            // 
            this.gbCmdTemperature.Controls.Add(this.btnGetReaderTemperature);
            this.gbCmdTemperature.Controls.Add(this.txtReaderTemperature);
            this.gbCmdTemperature.ForeColor = System.Drawing.Color.Black;
            this.gbCmdTemperature.Location = new System.Drawing.Point(702, 302);
            this.gbCmdTemperature.Name = "gbCmdTemperature";
            this.gbCmdTemperature.Size = new System.Drawing.Size(342, 53);
            this.gbCmdTemperature.TabIndex = 76;
            this.gbCmdTemperature.TabStop = false;
            this.gbCmdTemperature.Text = "Working temperature monitoring";
            // 
            // btnGetReaderTemperature
            // 
            this.btnGetReaderTemperature.Location = new System.Drawing.Point(233, 20);
            this.btnGetReaderTemperature.Name = "btnGetReaderTemperature";
            this.btnGetReaderTemperature.Size = new System.Drawing.Size(90, 25);
            this.btnGetReaderTemperature.TabIndex = 0;
            this.btnGetReaderTemperature.Text = "Get";
            this.btnGetReaderTemperature.UseVisualStyleBackColor = true;
            this.btnGetReaderTemperature.Click += new System.EventHandler(this.btnGetReaderTemperature_Click);
            // 
            // txtReaderTemperature
            // 
            this.txtReaderTemperature.Location = new System.Drawing.Point(6, 22);
            this.txtReaderTemperature.Name = "txtReaderTemperature";
            this.txtReaderTemperature.ReadOnly = true;
            this.txtReaderTemperature.Size = new System.Drawing.Size(120, 20);
            this.txtReaderTemperature.TabIndex = 1;
            this.txtReaderTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbp_DRM
            // 
            this.gbp_DRM.Controls.Add(this.DRM_CLOSE);
            this.gbp_DRM.Controls.Add(this.DRM_OPEN);
            this.gbp_DRM.Controls.Add(this.bt_GetDRM);
            this.gbp_DRM.Controls.Add(this.bt_setDRM);
            this.gbp_DRM.Location = new System.Drawing.Point(355, 467);
            this.gbp_DRM.Name = "gbp_DRM";
            this.gbp_DRM.Size = new System.Drawing.Size(343, 52);
            this.gbp_DRM.TabIndex = 75;
            this.gbp_DRM.TabStop = false;
            this.gbp_DRM.Text = "DRM status";
            // 
            // DRM_CLOSE
            // 
            this.DRM_CLOSE.AutoSize = true;
            this.DRM_CLOSE.Location = new System.Drawing.Point(103, 22);
            this.DRM_CLOSE.Name = "DRM_CLOSE";
            this.DRM_CLOSE.Size = new System.Drawing.Size(51, 17);
            this.DRM_CLOSE.TabIndex = 12;
            this.DRM_CLOSE.Text = "Close";
            this.DRM_CLOSE.UseVisualStyleBackColor = true;
            // 
            // DRM_OPEN
            // 
            this.DRM_OPEN.AutoSize = true;
            this.DRM_OPEN.Location = new System.Drawing.Point(13, 22);
            this.DRM_OPEN.Name = "DRM_OPEN";
            this.DRM_OPEN.Size = new System.Drawing.Size(51, 17);
            this.DRM_OPEN.TabIndex = 11;
            this.DRM_OPEN.Text = "Open";
            this.DRM_OPEN.UseVisualStyleBackColor = true;
            // 
            // bt_GetDRM
            // 
            this.bt_GetDRM.Location = new System.Drawing.Point(247, 18);
            this.bt_GetDRM.Name = "bt_GetDRM";
            this.bt_GetDRM.Size = new System.Drawing.Size(77, 25);
            this.bt_GetDRM.TabIndex = 9;
            this.bt_GetDRM.Text = "Get";
            this.bt_GetDRM.UseVisualStyleBackColor = true;
            this.bt_GetDRM.Click += new System.EventHandler(this.bt_GetDRM_Click);
            // 
            // bt_setDRM
            // 
            this.bt_setDRM.Location = new System.Drawing.Point(158, 18);
            this.bt_setDRM.Name = "bt_setDRM";
            this.bt_setDRM.Size = new System.Drawing.Size(77, 25);
            this.bt_setDRM.TabIndex = 8;
            this.bt_setDRM.Text = "Set";
            this.bt_setDRM.UseVisualStyleBackColor = true;
            this.bt_setDRM.Click += new System.EventHandler(this.bt_setDRM_Click);
            // 
            // gbp_Retry
            // 
            this.gbp_Retry.Controls.Add(this.com_retrytimes);
            this.gbp_Retry.Controls.Add(this.bt_Getretry);
            this.gbp_Retry.Controls.Add(this.bt_Setretry);
            this.gbp_Retry.Location = new System.Drawing.Point(354, 410);
            this.gbp_Retry.Name = "gbp_Retry";
            this.gbp_Retry.Size = new System.Drawing.Size(343, 52);
            this.gbp_Retry.TabIndex = 74;
            this.gbp_Retry.TabStop = false;
            this.gbp_Retry.Text = "Retry write times set and get";
            // 
            // com_retrytimes
            // 
            this.com_retrytimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_retrytimes.FormattingEnabled = true;
            this.com_retrytimes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.com_retrytimes.Location = new System.Drawing.Point(14, 21);
            this.com_retrytimes.Name = "com_retrytimes";
            this.com_retrytimes.Size = new System.Drawing.Size(100, 21);
            this.com_retrytimes.TabIndex = 26;
            // 
            // bt_Getretry
            // 
            this.bt_Getretry.Location = new System.Drawing.Point(247, 18);
            this.bt_Getretry.Name = "bt_Getretry";
            this.bt_Getretry.Size = new System.Drawing.Size(77, 25);
            this.bt_Getretry.TabIndex = 9;
            this.bt_Getretry.Text = "Get";
            this.bt_Getretry.UseVisualStyleBackColor = true;
            this.bt_Getretry.Click += new System.EventHandler(this.bt_Getretry_Click);
            // 
            // bt_Setretry
            // 
            this.bt_Setretry.Location = new System.Drawing.Point(158, 18);
            this.bt_Setretry.Name = "bt_Setretry";
            this.bt_Setretry.Size = new System.Drawing.Size(77, 25);
            this.bt_Setretry.TabIndex = 8;
            this.bt_Setretry.Text = "Set";
            this.bt_Setretry.UseVisualStyleBackColor = true;
            this.bt_Setretry.Click += new System.EventHandler(this.bt_Setretry_Click);
            // 
            // gbp_wpower
            // 
            this.gbp_wpower.Controls.Add(this.label112);
            this.gbp_wpower.Controls.Add(this.com_wpower);
            this.gbp_wpower.Controls.Add(this.rb_wp2);
            this.gbp_wpower.Controls.Add(this.rb_wp1);
            this.gbp_wpower.Controls.Add(this.bt_GetWpower);
            this.gbp_wpower.Controls.Add(this.bt_SetWpower);
            this.gbp_wpower.Location = new System.Drawing.Point(6, 425);
            this.gbp_wpower.Name = "gbp_wpower";
            this.gbp_wpower.Size = new System.Drawing.Size(343, 74);
            this.gbp_wpower.TabIndex = 73;
            this.gbp_wpower.TabStop = false;
            this.gbp_wpower.Text = "Write Power Set and get";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(120, 48);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(28, 13);
            this.label112.TabIndex = 27;
            this.label112.Text = "dBm";
            // 
            // com_wpower
            // 
            this.com_wpower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_wpower.FormattingEnabled = true;
            this.com_wpower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.com_wpower.Location = new System.Drawing.Point(14, 44);
            this.com_wpower.Name = "com_wpower";
            this.com_wpower.Size = new System.Drawing.Size(100, 21);
            this.com_wpower.TabIndex = 26;
            // 
            // rb_wp2
            // 
            this.rb_wp2.AutoSize = true;
            this.rb_wp2.Location = new System.Drawing.Point(157, 20);
            this.rb_wp2.Name = "rb_wp2";
            this.rb_wp2.Size = new System.Drawing.Size(58, 17);
            this.rb_wp2.TabIndex = 11;
            this.rb_wp2.Text = "Enable";
            this.rb_wp2.UseVisualStyleBackColor = true;
            // 
            // rb_wp1
            // 
            this.rb_wp1.AutoSize = true;
            this.rb_wp1.Checked = true;
            this.rb_wp1.Location = new System.Drawing.Point(15, 20);
            this.rb_wp1.Name = "rb_wp1";
            this.rb_wp1.Size = new System.Drawing.Size(60, 17);
            this.rb_wp1.TabIndex = 10;
            this.rb_wp1.TabStop = true;
            this.rb_wp1.Text = "Disable";
            this.rb_wp1.UseVisualStyleBackColor = true;
            // 
            // bt_GetWpower
            // 
            this.bt_GetWpower.Location = new System.Drawing.Point(247, 42);
            this.bt_GetWpower.Name = "bt_GetWpower";
            this.bt_GetWpower.Size = new System.Drawing.Size(77, 25);
            this.bt_GetWpower.TabIndex = 9;
            this.bt_GetWpower.Text = "Get";
            this.bt_GetWpower.UseVisualStyleBackColor = true;
            this.bt_GetWpower.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_SetWpower
            // 
            this.bt_SetWpower.Location = new System.Drawing.Point(158, 42);
            this.bt_SetWpower.Name = "bt_SetWpower";
            this.bt_SetWpower.Size = new System.Drawing.Size(77, 25);
            this.bt_SetWpower.TabIndex = 8;
            this.bt_SetWpower.Text = "Set";
            this.bt_SetWpower.UseVisualStyleBackColor = true;
            this.bt_SetWpower.Click += new System.EventHandler(this.button2_Click);
            // 
            // group_maxtime
            // 
            this.group_maxtime.Controls.Add(this.comboBox_maxtime);
            this.group_maxtime.Controls.Add(this.btSetMaxtime);
            this.group_maxtime.Location = new System.Drawing.Point(6, 314);
            this.group_maxtime.Name = "group_maxtime";
            this.group_maxtime.Size = new System.Drawing.Size(342, 44);
            this.group_maxtime.TabIndex = 72;
            this.group_maxtime.TabStop = false;
            this.group_maxtime.Text = "Max inventory time";
            // 
            // comboBox_maxtime
            // 
            this.comboBox_maxtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maxtime.FormattingEnabled = true;
            this.comboBox_maxtime.Location = new System.Drawing.Point(94, 16);
            this.comboBox_maxtime.Name = "comboBox_maxtime";
            this.comboBox_maxtime.Size = new System.Drawing.Size(122, 21);
            this.comboBox_maxtime.TabIndex = 26;
            // 
            // btSetMaxtime
            // 
            this.btSetMaxtime.Location = new System.Drawing.Point(233, 15);
            this.btSetMaxtime.Name = "btSetMaxtime";
            this.btSetMaxtime.Size = new System.Drawing.Size(90, 25);
            this.btSetMaxtime.TabIndex = 23;
            this.btSetMaxtime.Text = "Set";
            this.btSetMaxtime.UseVisualStyleBackColor = true;
            this.btSetMaxtime.Click += new System.EventHandler(this.btSetMaxtime_Click);
            // 
            // gbp_buff
            // 
            this.gbp_buff.Controls.Add(this.rb496);
            this.gbp_buff.Controls.Add(this.rb128);
            this.gbp_buff.Controls.Add(this.btGetEPCandTIDLen);
            this.gbp_buff.Controls.Add(this.btSetEPCandTIDLen);
            this.gbp_buff.Location = new System.Drawing.Point(5, 363);
            this.gbp_buff.Name = "gbp_buff";
            this.gbp_buff.Size = new System.Drawing.Size(343, 60);
            this.gbp_buff.TabIndex = 71;
            this.gbp_buff.TabStop = false;
            this.gbp_buff.Text = "Saved EPC/TID length";
            // 
            // rb496
            // 
            this.rb496.AutoSize = true;
            this.rb496.Location = new System.Drawing.Point(93, 27);
            this.rb496.Name = "rb496";
            this.rb496.Size = new System.Drawing.Size(54, 17);
            this.rb496.TabIndex = 11;
            this.rb496.Text = "496bit";
            this.rb496.UseVisualStyleBackColor = true;
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Checked = true;
            this.rb128.Location = new System.Drawing.Point(15, 27);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(54, 17);
            this.rb128.TabIndex = 10;
            this.rb128.TabStop = true;
            this.rb128.Text = "128bit";
            this.rb128.UseVisualStyleBackColor = true;
            // 
            // btGetEPCandTIDLen
            // 
            this.btGetEPCandTIDLen.Location = new System.Drawing.Point(247, 24);
            this.btGetEPCandTIDLen.Name = "btGetEPCandTIDLen";
            this.btGetEPCandTIDLen.Size = new System.Drawing.Size(77, 25);
            this.btGetEPCandTIDLen.TabIndex = 9;
            this.btGetEPCandTIDLen.Text = "Get";
            this.btGetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btGetEPCandTIDLen.Click += new System.EventHandler(this.btGetEPCandTIDLen_Click);
            // 
            // btSetEPCandTIDLen
            // 
            this.btSetEPCandTIDLen.Location = new System.Drawing.Point(158, 24);
            this.btSetEPCandTIDLen.Name = "btSetEPCandTIDLen";
            this.btSetEPCandTIDLen.Size = new System.Drawing.Size(77, 25);
            this.btSetEPCandTIDLen.TabIndex = 8;
            this.btSetEPCandTIDLen.Text = "Set";
            this.btSetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btSetEPCandTIDLen.Click += new System.EventHandler(this.btSetEPCandTIDLen_Click);
            // 
            // btGetInformation
            // 
            this.btGetInformation.Location = new System.Drawing.Point(538, 529);
            this.btGetInformation.Name = "btGetInformation";
            this.btGetInformation.Size = new System.Drawing.Size(169, 47);
            this.btGetInformation.TabIndex = 58;
            this.btGetInformation.Text = "Get reader information";
            this.btGetInformation.UseVisualStyleBackColor = true;
            this.btGetInformation.Click += new System.EventHandler(this.btGetInformation_Click);
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(717, 529);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(169, 47);
            this.btDefault.TabIndex = 57;
            this.btDefault.Text = "Default setting";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btFlashROM
            // 
            this.btFlashROM.Location = new System.Drawing.Point(355, 529);
            this.btFlashROM.Name = "btFlashROM";
            this.btFlashROM.Size = new System.Drawing.Size(169, 47);
            this.btFlashROM.TabIndex = 56;
            this.btFlashROM.Text = "Change to update mode";
            this.btFlashROM.UseVisualStyleBackColor = true;
            this.btFlashROM.Click += new System.EventHandler(this.btFlashROM_Click);
            // 
            // gpb_clock
            // 
            this.gpb_clock.Controls.Add(this.textBox1);
            this.gpb_clock.Controls.Add(this.Text_sec);
            this.gpb_clock.Controls.Add(this.Text_min);
            this.gpb_clock.Controls.Add(this.Text_hour);
            this.gpb_clock.Controls.Add(this.Text_day);
            this.gpb_clock.Controls.Add(this.Text_month);
            this.gpb_clock.Controls.Add(this.Text_year);
            this.gpb_clock.Controls.Add(this.ClockCMD);
            this.gpb_clock.Controls.Add(this.GetClock);
            this.gpb_clock.Controls.Add(this.SetClock);
            this.gpb_clock.Controls.Add(this.label11);
            this.gpb_clock.Controls.Add(this.label40);
            this.gpb_clock.Controls.Add(this.label41);
            this.gpb_clock.Controls.Add(this.label42);
            this.gpb_clock.Controls.Add(this.label45);
            this.gpb_clock.Controls.Add(this.label46);
            this.gpb_clock.Location = new System.Drawing.Point(706, 421);
            this.gpb_clock.Name = "gpb_clock";
            this.gpb_clock.Size = new System.Drawing.Size(342, 102);
            this.gpb_clock.TabIndex = 55;
            this.gpb_clock.TabStop = false;
            this.gpb_clock.Text = "Real time clock setting";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(46, 35);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "20";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_sec
            // 
            this.Text_sec.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_sec.ForeColor = System.Drawing.Color.Crimson;
            this.Text_sec.Location = new System.Drawing.Point(290, 30);
            this.Text_sec.MaxLength = 2;
            this.Text_sec.Name = "Text_sec";
            this.Text_sec.Size = new System.Drawing.Size(46, 35);
            this.Text_sec.TabIndex = 37;
            this.Text_sec.Text = "00";
            this.Text_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_min
            // 
            this.Text_min.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_min.ForeColor = System.Drawing.Color.Crimson;
            this.Text_min.Location = new System.Drawing.Point(242, 30);
            this.Text_min.MaxLength = 2;
            this.Text_min.Name = "Text_min";
            this.Text_min.Size = new System.Drawing.Size(46, 35);
            this.Text_min.TabIndex = 36;
            this.Text_min.Text = "00";
            this.Text_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_hour
            // 
            this.Text_hour.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_hour.ForeColor = System.Drawing.Color.Crimson;
            this.Text_hour.Location = new System.Drawing.Point(194, 30);
            this.Text_hour.MaxLength = 2;
            this.Text_hour.Name = "Text_hour";
            this.Text_hour.Size = new System.Drawing.Size(46, 35);
            this.Text_hour.TabIndex = 35;
            this.Text_hour.Text = "00";
            this.Text_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_day
            // 
            this.Text_day.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_day.ForeColor = System.Drawing.Color.Crimson;
            this.Text_day.Location = new System.Drawing.Point(145, 29);
            this.Text_day.MaxLength = 2;
            this.Text_day.Name = "Text_day";
            this.Text_day.Size = new System.Drawing.Size(46, 35);
            this.Text_day.TabIndex = 34;
            this.Text_day.Text = "00";
            this.Text_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_month
            // 
            this.Text_month.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_month.ForeColor = System.Drawing.Color.Crimson;
            this.Text_month.Location = new System.Drawing.Point(97, 29);
            this.Text_month.MaxLength = 2;
            this.Text_month.Name = "Text_month";
            this.Text_month.Size = new System.Drawing.Size(46, 35);
            this.Text_month.TabIndex = 33;
            this.Text_month.Text = "00";
            this.Text_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_year
            // 
            this.Text_year.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_year.ForeColor = System.Drawing.Color.Crimson;
            this.Text_year.Location = new System.Drawing.Point(49, 29);
            this.Text_year.MaxLength = 2;
            this.Text_year.Name = "Text_year";
            this.Text_year.Size = new System.Drawing.Size(46, 35);
            this.Text_year.TabIndex = 32;
            this.Text_year.Text = "00";
            this.Text_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ClockCMD
            // 
            this.ClockCMD.Location = new System.Drawing.Point(233, 70);
            this.ClockCMD.Name = "ClockCMD";
            this.ClockCMD.Size = new System.Drawing.Size(90, 30);
            this.ClockCMD.TabIndex = 15;
            this.ClockCMD.Text = "Do";
            this.ClockCMD.UseVisualStyleBackColor = true;
            this.ClockCMD.Click += new System.EventHandler(this.ClockCMD_Click);
            // 
            // GetClock
            // 
            this.GetClock.AutoSize = true;
            this.GetClock.Checked = true;
            this.GetClock.Location = new System.Drawing.Point(131, 78);
            this.GetClock.Name = "GetClock";
            this.GetClock.Size = new System.Drawing.Size(53, 17);
            this.GetClock.TabIndex = 14;
            this.GetClock.TabStop = true;
            this.GetClock.Text = "Query";
            this.GetClock.UseVisualStyleBackColor = true;
            // 
            // SetClock
            // 
            this.SetClock.AutoSize = true;
            this.SetClock.Location = new System.Drawing.Point(17, 78);
            this.SetClock.Name = "SetClock";
            this.SetClock.Size = new System.Drawing.Size(58, 17);
            this.SetClock.TabIndex = 13;
            this.SetClock.Text = "Setting";
            this.SetClock.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sec";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(253, 14);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 13);
            this.label40.TabIndex = 11;
            this.label40.Text = "Min";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(204, 14);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 10;
            this.label41.Text = "Hour";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(157, 15);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(26, 13);
            this.label42.TabIndex = 9;
            this.label42.Text = "Day";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(106, 15);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(37, 13);
            this.label45.TabIndex = 8;
            this.label45.Text = "Month";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(62, 15);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 13);
            this.label46.TabIndex = 2;
            this.label46.Text = "Year";
            // 
            // gpb_antconfig
            // 
            this.gpb_antconfig.Controls.Add(this.Button_Ant);
            this.gpb_antconfig.Controls.Add(this.checkant4);
            this.gpb_antconfig.Controls.Add(this.checkant3);
            this.gpb_antconfig.Controls.Add(this.checkant2);
            this.gpb_antconfig.Controls.Add(this.checkant1);
            this.gpb_antconfig.Location = new System.Drawing.Point(354, 359);
            this.gpb_antconfig.Name = "gpb_antconfig";
            this.gpb_antconfig.Size = new System.Drawing.Size(342, 46);
            this.gpb_antconfig.TabIndex = 54;
            this.gpb_antconfig.TabStop = false;
            this.gpb_antconfig.Text = "Antenna config";
            // 
            // Button_Ant
            // 
            this.Button_Ant.Location = new System.Drawing.Point(233, 13);
            this.Button_Ant.Name = "Button_Ant";
            this.Button_Ant.Size = new System.Drawing.Size(90, 25);
            this.Button_Ant.TabIndex = 5;
            this.Button_Ant.Text = "Set";
            this.Button_Ant.UseVisualStyleBackColor = true;
            this.Button_Ant.Click += new System.EventHandler(this.Button_Ant_Click);
            // 
            // checkant4
            // 
            this.checkant4.AutoSize = true;
            this.checkant4.Location = new System.Drawing.Point(177, 16);
            this.checkant4.Name = "checkant4";
            this.checkant4.Size = new System.Drawing.Size(54, 17);
            this.checkant4.TabIndex = 4;
            this.checkant4.Text = "ANT4";
            this.checkant4.UseVisualStyleBackColor = true;
            // 
            // checkant3
            // 
            this.checkant3.AutoSize = true;
            this.checkant3.Location = new System.Drawing.Point(120, 16);
            this.checkant3.Name = "checkant3";
            this.checkant3.Size = new System.Drawing.Size(54, 17);
            this.checkant3.TabIndex = 3;
            this.checkant3.Text = "ANT3";
            this.checkant3.UseVisualStyleBackColor = true;
            // 
            // checkant2
            // 
            this.checkant2.AutoSize = true;
            this.checkant2.Location = new System.Drawing.Point(62, 16);
            this.checkant2.Name = "checkant2";
            this.checkant2.Size = new System.Drawing.Size(54, 17);
            this.checkant2.TabIndex = 2;
            this.checkant2.Text = "ANT2";
            this.checkant2.UseVisualStyleBackColor = true;
            // 
            // checkant1
            // 
            this.checkant1.AutoSize = true;
            this.checkant1.Location = new System.Drawing.Point(8, 16);
            this.checkant1.Name = "checkant1";
            this.checkant1.Size = new System.Drawing.Size(54, 17);
            this.checkant1.TabIndex = 1;
            this.checkant1.Text = "ANT1";
            this.checkant1.UseVisualStyleBackColor = true;
            // 
            // gpb_checkant
            // 
            this.gpb_checkant.Controls.Add(this.btSetcheckant);
            this.gpb_checkant.Controls.Add(this.rb_Closecheckant);
            this.gpb_checkant.Controls.Add(this.rb_Opencheckant);
            this.gpb_checkant.Location = new System.Drawing.Point(354, 301);
            this.gpb_checkant.Name = "gpb_checkant";
            this.gpb_checkant.Size = new System.Drawing.Size(342, 55);
            this.gpb_checkant.TabIndex = 53;
            this.gpb_checkant.TabStop = false;
            this.gpb_checkant.Text = "Antenna checked";
            // 
            // btSetcheckant
            // 
            this.btSetcheckant.Location = new System.Drawing.Point(233, 21);
            this.btSetcheckant.Name = "btSetcheckant";
            this.btSetcheckant.Size = new System.Drawing.Size(90, 25);
            this.btSetcheckant.TabIndex = 2;
            this.btSetcheckant.Text = "Set";
            this.btSetcheckant.UseVisualStyleBackColor = true;
            this.btSetcheckant.Click += new System.EventHandler(this.btSetcheckant_Click);
            // 
            // rb_Closecheckant
            // 
            this.rb_Closecheckant.AutoSize = true;
            this.rb_Closecheckant.Location = new System.Drawing.Point(7, 35);
            this.rb_Closecheckant.Name = "rb_Closecheckant";
            this.rb_Closecheckant.Size = new System.Drawing.Size(149, 17);
            this.rb_Closecheckant.TabIndex = 1;
            this.rb_Closecheckant.Text = "Disable antenna detection";
            this.rb_Closecheckant.UseVisualStyleBackColor = true;
            // 
            // rb_Opencheckant
            // 
            this.rb_Opencheckant.AutoSize = true;
            this.rb_Opencheckant.Checked = true;
            this.rb_Opencheckant.Location = new System.Drawing.Point(7, 15);
            this.rb_Opencheckant.Name = "rb_Opencheckant";
            this.rb_Opencheckant.Size = new System.Drawing.Size(147, 17);
            this.rb_Opencheckant.TabIndex = 0;
            this.rb_Opencheckant.TabStop = true;
            this.rb_Opencheckant.Text = "Enable antenna detection";
            this.rb_Opencheckant.UseVisualStyleBackColor = true;
            // 
            // gpb_GPIO
            // 
            this.gpb_GPIO.Controls.Add(this.Button_GetGPIO);
            this.gpb_GPIO.Controls.Add(this.Button_SetGPIO);
            this.gpb_GPIO.Controls.Add(this.check_int4);
            this.gpb_GPIO.Controls.Add(this.check_int3);
            this.gpb_GPIO.Controls.Add(this.check_int2);
            this.gpb_GPIO.Controls.Add(this.check_int1);
            this.gpb_GPIO.Controls.Add(this.check_out4);
            this.gpb_GPIO.Controls.Add(this.check_out3);
            this.gpb_GPIO.Controls.Add(this.check_out2);
            this.gpb_GPIO.Controls.Add(this.check_out1);
            this.gpb_GPIO.Location = new System.Drawing.Point(354, 252);
            this.gpb_GPIO.Name = "gpb_GPIO";
            this.gpb_GPIO.Size = new System.Drawing.Size(693, 47);
            this.gpb_GPIO.TabIndex = 49;
            this.gpb_GPIO.TabStop = false;
            this.gpb_GPIO.Text = "GPIO Operation";
            // 
            // Button_GetGPIO
            // 
            this.Button_GetGPIO.Location = new System.Drawing.Point(585, 15);
            this.Button_GetGPIO.Name = "Button_GetGPIO";
            this.Button_GetGPIO.Size = new System.Drawing.Size(90, 25);
            this.Button_GetGPIO.TabIndex = 9;
            this.Button_GetGPIO.Text = "Get";
            this.Button_GetGPIO.UseVisualStyleBackColor = true;
            this.Button_GetGPIO.Click += new System.EventHandler(this.Button_GetGPIO_Click);
            // 
            // Button_SetGPIO
            // 
            this.Button_SetGPIO.Location = new System.Drawing.Point(483, 15);
            this.Button_SetGPIO.Name = "Button_SetGPIO";
            this.Button_SetGPIO.Size = new System.Drawing.Size(90, 25);
            this.Button_SetGPIO.TabIndex = 8;
            this.Button_SetGPIO.Text = "Set";
            this.Button_SetGPIO.UseVisualStyleBackColor = true;
            this.Button_SetGPIO.Click += new System.EventHandler(this.Button_SetGPIO_Click);
            // 
            // check_int4
            // 
            this.check_int4.AutoSize = true;
            this.check_int4.Enabled = false;
            this.check_int4.Location = new System.Drawing.Point(392, 20);
            this.check_int4.Name = "check_int4";
            this.check_int4.Size = new System.Drawing.Size(43, 17);
            this.check_int4.TabIndex = 7;
            this.check_int4.Text = "IN4";
            this.check_int4.UseVisualStyleBackColor = true;
            // 
            // check_int3
            // 
            this.check_int3.AutoSize = true;
            this.check_int3.Enabled = false;
            this.check_int3.Location = new System.Drawing.Point(338, 20);
            this.check_int3.Name = "check_int3";
            this.check_int3.Size = new System.Drawing.Size(43, 17);
            this.check_int3.TabIndex = 6;
            this.check_int3.Text = "IN3";
            this.check_int3.UseVisualStyleBackColor = true;
            // 
            // check_int2
            // 
            this.check_int2.AutoSize = true;
            this.check_int2.Enabled = false;
            this.check_int2.Location = new System.Drawing.Point(281, 20);
            this.check_int2.Name = "check_int2";
            this.check_int2.Size = new System.Drawing.Size(43, 17);
            this.check_int2.TabIndex = 5;
            this.check_int2.Text = "IN2";
            this.check_int2.UseVisualStyleBackColor = true;
            this.check_int2.CheckedChanged += new System.EventHandler(this.check_int2_CheckedChanged);
            // 
            // check_int1
            // 
            this.check_int1.AutoSize = true;
            this.check_int1.Enabled = false;
            this.check_int1.Location = new System.Drawing.Point(227, 20);
            this.check_int1.Name = "check_int1";
            this.check_int1.Size = new System.Drawing.Size(43, 17);
            this.check_int1.TabIndex = 4;
            this.check_int1.Text = "IN1";
            this.check_int1.UseVisualStyleBackColor = true;
            // 
            // check_out4
            // 
            this.check_out4.AutoSize = true;
            this.check_out4.Location = new System.Drawing.Point(170, 20);
            this.check_out4.Name = "check_out4";
            this.check_out4.Size = new System.Drawing.Size(55, 17);
            this.check_out4.TabIndex = 3;
            this.check_out4.Text = "OUT4";
            this.check_out4.UseVisualStyleBackColor = true;
            // 
            // check_out3
            // 
            this.check_out3.AutoSize = true;
            this.check_out3.Location = new System.Drawing.Point(116, 20);
            this.check_out3.Name = "check_out3";
            this.check_out3.Size = new System.Drawing.Size(55, 17);
            this.check_out3.TabIndex = 2;
            this.check_out3.Text = "OUT3";
            this.check_out3.UseVisualStyleBackColor = true;
            // 
            // check_out2
            // 
            this.check_out2.AutoSize = true;
            this.check_out2.Location = new System.Drawing.Point(62, 20);
            this.check_out2.Name = "check_out2";
            this.check_out2.Size = new System.Drawing.Size(55, 17);
            this.check_out2.TabIndex = 1;
            this.check_out2.Text = "OUT2";
            this.check_out2.UseVisualStyleBackColor = true;
            // 
            // check_out1
            // 
            this.check_out1.AutoSize = true;
            this.check_out1.Location = new System.Drawing.Point(8, 20);
            this.check_out1.Name = "check_out1";
            this.check_out1.Size = new System.Drawing.Size(55, 17);
            this.check_out1.TabIndex = 0;
            this.check_out1.Text = "OUT1";
            this.check_out1.UseVisualStyleBackColor = true;
            // 
            // gpb_OutputRep
            // 
            this.gpb_OutputRep.Controls.Add(this.btOutputRep);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep4);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep3);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep2);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep1);
            this.gpb_OutputRep.Location = new System.Drawing.Point(705, 205);
            this.gpb_OutputRep.Name = "gpb_OutputRep";
            this.gpb_OutputRep.Size = new System.Drawing.Size(342, 46);
            this.gpb_OutputRep.TabIndex = 48;
            this.gpb_OutputRep.TabStop = false;
            this.gpb_OutputRep.Text = "Set notification pluse output";
            // 
            // btOutputRep
            // 
            this.btOutputRep.Location = new System.Drawing.Point(234, 14);
            this.btOutputRep.Name = "btOutputRep";
            this.btOutputRep.Size = new System.Drawing.Size(90, 25);
            this.btOutputRep.TabIndex = 5;
            this.btOutputRep.Text = "Set";
            this.btOutputRep.UseVisualStyleBackColor = true;
            this.btOutputRep.Click += new System.EventHandler(this.btOutputRep_Click);
            // 
            // check_OutputRep4
            // 
            this.check_OutputRep4.AutoSize = true;
            this.check_OutputRep4.Location = new System.Drawing.Point(184, 17);
            this.check_OutputRep4.Name = "check_OutputRep4";
            this.check_OutputRep4.Size = new System.Drawing.Size(55, 17);
            this.check_OutputRep4.TabIndex = 4;
            this.check_OutputRep4.Text = "OUT4";
            this.check_OutputRep4.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep3
            // 
            this.check_OutputRep3.AutoSize = true;
            this.check_OutputRep3.Location = new System.Drawing.Point(125, 17);
            this.check_OutputRep3.Name = "check_OutputRep3";
            this.check_OutputRep3.Size = new System.Drawing.Size(55, 17);
            this.check_OutputRep3.TabIndex = 3;
            this.check_OutputRep3.Text = "OUT3";
            this.check_OutputRep3.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep2
            // 
            this.check_OutputRep2.AutoSize = true;
            this.check_OutputRep2.Location = new System.Drawing.Point(66, 17);
            this.check_OutputRep2.Name = "check_OutputRep2";
            this.check_OutputRep2.Size = new System.Drawing.Size(55, 17);
            this.check_OutputRep2.TabIndex = 2;
            this.check_OutputRep2.Text = "OUT2";
            this.check_OutputRep2.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep1
            // 
            this.check_OutputRep1.AutoSize = true;
            this.check_OutputRep1.Location = new System.Drawing.Point(8, 17);
            this.check_OutputRep1.Name = "check_OutputRep1";
            this.check_OutputRep1.Size = new System.Drawing.Size(55, 17);
            this.check_OutputRep1.TabIndex = 1;
            this.check_OutputRep1.Text = "OUT1";
            this.check_OutputRep1.UseVisualStyleBackColor = true;
            // 
            // gpb_Relay
            // 
            this.gpb_Relay.Controls.Add(this.label38);
            this.gpb_Relay.Controls.Add(this.ComboBox_RelayTime);
            this.gpb_Relay.Controls.Add(this.label37);
            this.gpb_Relay.Controls.Add(this.btRelay);
            this.gpb_Relay.Location = new System.Drawing.Point(354, 205);
            this.gpb_Relay.Name = "gpb_Relay";
            this.gpb_Relay.Size = new System.Drawing.Size(342, 46);
            this.gpb_Relay.TabIndex = 31;
            this.gpb_Relay.TabStop = false;
            this.gpb_Relay.Text = "Relay control";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(182, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 13);
            this.label38.TabIndex = 26;
            this.label38.Text = "*50ms";
            // 
            // ComboBox_RelayTime
            // 
            this.ComboBox_RelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_RelayTime.FormattingEnabled = true;
            this.ComboBox_RelayTime.Location = new System.Drawing.Point(82, 16);
            this.ComboBox_RelayTime.Name = "ComboBox_RelayTime";
            this.ComboBox_RelayTime.Size = new System.Drawing.Size(96, 21);
            this.ComboBox_RelayTime.TabIndex = 25;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(4, 21);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 13);
            this.label37.TabIndex = 24;
            this.label37.Text = "Release time:";
            // 
            // btRelay
            // 
            this.btRelay.Location = new System.Drawing.Point(233, 14);
            this.btRelay.Name = "btRelay";
            this.btRelay.Size = new System.Drawing.Size(90, 25);
            this.btRelay.TabIndex = 23;
            this.btRelay.Text = "Set";
            this.btRelay.UseVisualStyleBackColor = true;
            this.btRelay.Click += new System.EventHandler(this.btRelay_Click);
            // 
            // gpb_baud
            // 
            this.gpb_baud.Controls.Add(this.ComboBox_baud);
            this.gpb_baud.Controls.Add(this.btBaudRate);
            this.gpb_baud.Location = new System.Drawing.Point(706, 133);
            this.gpb_baud.Name = "gpb_baud";
            this.gpb_baud.Size = new System.Drawing.Size(342, 65);
            this.gpb_baud.TabIndex = 30;
            this.gpb_baud.TabStop = false;
            this.gpb_baud.Text = "RS232/485 baud rate";
            // 
            // ComboBox_baud
            // 
            this.ComboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud.FormattingEnabled = true;
            this.ComboBox_baud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud.Location = new System.Drawing.Point(69, 27);
            this.ComboBox_baud.Name = "ComboBox_baud";
            this.ComboBox_baud.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_baud.TabIndex = 24;
            // 
            // btBaudRate
            // 
            this.btBaudRate.Location = new System.Drawing.Point(233, 24);
            this.btBaudRate.Name = "btBaudRate";
            this.btBaudRate.Size = new System.Drawing.Size(90, 25);
            this.btBaudRate.TabIndex = 23;
            this.btBaudRate.Text = "Set";
            this.btBaudRate.UseVisualStyleBackColor = true;
            this.btBaudRate.Click += new System.EventHandler(this.btBaudRate_Click);
            // 
            // gpb_DBM
            // 
            this.gpb_DBM.Controls.Add(this.label10);
            this.gpb_DBM.Controls.Add(this.ComboBox_PowerDbm);
            this.gpb_DBM.Controls.Add(this.BT_DBM);
            this.gpb_DBM.Location = new System.Drawing.Point(354, 133);
            this.gpb_DBM.Name = "gpb_DBM";
            this.gpb_DBM.Size = new System.Drawing.Size(342, 67);
            this.gpb_DBM.TabIndex = 29;
            this.gpb_DBM.TabStop = false;
            this.gpb_DBM.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "dBm";
            // 
            // ComboBox_PowerDbm
            // 
            this.ComboBox_PowerDbm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PowerDbm.FormattingEnabled = true;
            this.ComboBox_PowerDbm.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ComboBox_PowerDbm.Location = new System.Drawing.Point(51, 25);
            this.ComboBox_PowerDbm.Name = "ComboBox_PowerDbm";
            this.ComboBox_PowerDbm.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_PowerDbm.TabIndex = 24;
            // 
            // BT_DBM
            // 
            this.BT_DBM.Location = new System.Drawing.Point(233, 25);
            this.BT_DBM.Name = "BT_DBM";
            this.BT_DBM.Size = new System.Drawing.Size(90, 25);
            this.BT_DBM.TabIndex = 23;
            this.BT_DBM.Text = "Set";
            this.BT_DBM.UseVisualStyleBackColor = true;
            this.BT_DBM.Click += new System.EventHandler(this.BT_DBM_Click);
            // 
            // gpb_Freq
            // 
            this.gpb_Freq.Controls.Add(this.radioButton_band12);
            this.gpb_Freq.Controls.Add(this.radioButton_band8);
            this.gpb_Freq.Controls.Add(this.CheckBox_SameFre);
            this.gpb_Freq.Controls.Add(this.radioButton_band4);
            this.gpb_Freq.Controls.Add(this.radioButton_band3);
            this.gpb_Freq.Controls.Add(this.radioButton_band2);
            this.gpb_Freq.Controls.Add(this.radioButton_band1);
            this.gpb_Freq.Controls.Add(this.btFreq);
            this.gpb_Freq.Controls.Add(this.ComboBox_dmaxfre);
            this.gpb_Freq.Controls.Add(this.label15);
            this.gpb_Freq.Controls.Add(this.ComboBox_dminfre);
            this.gpb_Freq.Controls.Add(this.label14);
            this.gpb_Freq.Location = new System.Drawing.Point(354, 55);
            this.gpb_Freq.Name = "gpb_Freq";
            this.gpb_Freq.Size = new System.Drawing.Size(695, 76);
            this.gpb_Freq.TabIndex = 28;
            this.gpb_Freq.TabStop = false;
            this.gpb_Freq.Text = "Region";
            // 
            // radioButton_band12
            // 
            this.radioButton_band12.AutoSize = true;
            this.radioButton_band12.Location = new System.Drawing.Point(248, 48);
            this.radioButton_band12.Name = "radioButton_band12";
            this.radioButton_band12.Size = new System.Drawing.Size(73, 17);
            this.radioButton_band12.TabIndex = 18;
            this.radioButton_band12.TabStop = true;
            this.radioButton_band12.Text = "US band3";
            this.radioButton_band12.UseVisualStyleBackColor = true;
            this.radioButton_band12.CheckedChanged += new System.EventHandler(this.radioButton_band12_CheckedChanged);
            // 
            // radioButton_band8
            // 
            this.radioButton_band8.AutoSize = true;
            this.radioButton_band8.Location = new System.Drawing.Point(10, 18);
            this.radioButton_band8.Name = "radioButton_band8";
            this.radioButton_band8.Size = new System.Drawing.Size(96, 17);
            this.radioButton_band8.TabIndex = 17;
            this.radioButton_band8.TabStop = true;
            this.radioButton_band8.Text = "Chinese band1";
            this.radioButton_band8.UseVisualStyleBackColor = true;
            this.radioButton_band8.CheckedChanged += new System.EventHandler(this.radioButton_band8_CheckedChanged);
            // 
            // CheckBox_SameFre
            // 
            this.CheckBox_SameFre.AutoSize = true;
            this.CheckBox_SameFre.Location = new System.Drawing.Point(585, 17);
            this.CheckBox_SameFre.Name = "CheckBox_SameFre";
            this.CheckBox_SameFre.Size = new System.Drawing.Size(55, 17);
            this.CheckBox_SameFre.TabIndex = 16;
            this.CheckBox_SameFre.Text = "Single";
            this.CheckBox_SameFre.UseVisualStyleBackColor = true;
            this.CheckBox_SameFre.CheckedChanged += new System.EventHandler(this.CheckBox_SameFre_CheckedChanged);
            // 
            // radioButton_band4
            // 
            this.radioButton_band4.AutoSize = true;
            this.radioButton_band4.Location = new System.Drawing.Point(127, 48);
            this.radioButton_band4.Name = "radioButton_band4";
            this.radioButton_band4.Size = new System.Drawing.Size(67, 17);
            this.radioButton_band4.TabIndex = 15;
            this.radioButton_band4.TabStop = true;
            this.radioButton_band4.Text = "EU band";
            this.radioButton_band4.UseVisualStyleBackColor = true;
            this.radioButton_band4.CheckedChanged += new System.EventHandler(this.radioButton_band4_CheckedChanged);
            // 
            // radioButton_band3
            // 
            this.radioButton_band3.AutoSize = true;
            this.radioButton_band3.Location = new System.Drawing.Point(10, 47);
            this.radioButton_band3.Name = "radioButton_band3";
            this.radioButton_band3.Size = new System.Drawing.Size(86, 17);
            this.radioButton_band3.TabIndex = 14;
            this.radioButton_band3.TabStop = true;
            this.radioButton_band3.Text = "Korean band";
            this.radioButton_band3.UseVisualStyleBackColor = true;
            this.radioButton_band3.CheckedChanged += new System.EventHandler(this.radioButton_band3_CheckedChanged);
            // 
            // radioButton_band2
            // 
            this.radioButton_band2.AutoSize = true;
            this.radioButton_band2.Location = new System.Drawing.Point(248, 18);
            this.radioButton_band2.Name = "radioButton_band2";
            this.radioButton_band2.Size = new System.Drawing.Size(67, 17);
            this.radioButton_band2.TabIndex = 13;
            this.radioButton_band2.TabStop = true;
            this.radioButton_band2.Text = "US band";
            this.radioButton_band2.UseVisualStyleBackColor = true;
            this.radioButton_band2.CheckedChanged += new System.EventHandler(this.radioButton_band2_CheckedChanged);
            // 
            // radioButton_band1
            // 
            this.radioButton_band1.AutoSize = true;
            this.radioButton_band1.Location = new System.Drawing.Point(127, 18);
            this.radioButton_band1.Name = "radioButton_band1";
            this.radioButton_band1.Size = new System.Drawing.Size(96, 17);
            this.radioButton_band1.TabIndex = 12;
            this.radioButton_band1.TabStop = true;
            this.radioButton_band1.Text = "Chinese band2";
            this.radioButton_band1.UseVisualStyleBackColor = true;
            this.radioButton_band1.CheckedChanged += new System.EventHandler(this.radioButton_band1_CheckedChanged);
            // 
            // btFreq
            // 
            this.btFreq.Location = new System.Drawing.Point(585, 40);
            this.btFreq.Name = "btFreq";
            this.btFreq.Size = new System.Drawing.Size(90, 25);
            this.btFreq.TabIndex = 11;
            this.btFreq.Text = "Set";
            this.btFreq.UseVisualStyleBackColor = true;
            this.btFreq.Click += new System.EventHandler(this.btFreq_Click);
            // 
            // ComboBox_dmaxfre
            // 
            this.ComboBox_dmaxfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dmaxfre.FormattingEnabled = true;
            this.ComboBox_dmaxfre.Location = new System.Drawing.Point(421, 46);
            this.ComboBox_dmaxfre.Name = "ComboBox_dmaxfre";
            this.ComboBox_dmaxfre.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_dmaxfre.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(332, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Maxfre:";
            // 
            // ComboBox_dminfre
            // 
            this.ComboBox_dminfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dminfre.FormattingEnabled = true;
            this.ComboBox_dminfre.Location = new System.Drawing.Point(421, 14);
            this.ComboBox_dminfre.Name = "ComboBox_dminfre";
            this.ComboBox_dminfre.Size = new System.Drawing.Size(100, 21);
            this.ComboBox_dminfre.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Minfre:";
            // 
            // gpb_beep
            // 
            this.gpb_beep.Controls.Add(this.Radio_beepDis);
            this.gpb_beep.Controls.Add(this.Radio_beepEn);
            this.gpb_beep.Controls.Add(this.Button_Beep);
            this.gpb_beep.Location = new System.Drawing.Point(707, 5);
            this.gpb_beep.Name = "gpb_beep";
            this.gpb_beep.Size = new System.Drawing.Size(342, 48);
            this.gpb_beep.TabIndex = 27;
            this.gpb_beep.TabStop = false;
            this.gpb_beep.Text = "Beep";
            // 
            // Radio_beepDis
            // 
            this.Radio_beepDis.AutoSize = true;
            this.Radio_beepDis.Checked = true;
            this.Radio_beepDis.Location = new System.Drawing.Point(123, 20);
            this.Radio_beepDis.Name = "Radio_beepDis";
            this.Radio_beepDis.Size = new System.Drawing.Size(51, 17);
            this.Radio_beepDis.TabIndex = 10;
            this.Radio_beepDis.TabStop = true;
            this.Radio_beepDis.Text = "Close";
            this.Radio_beepDis.UseVisualStyleBackColor = true;
            // 
            // Radio_beepEn
            // 
            this.Radio_beepEn.AutoSize = true;
            this.Radio_beepEn.Location = new System.Drawing.Point(33, 20);
            this.Radio_beepEn.Name = "Radio_beepEn";
            this.Radio_beepEn.Size = new System.Drawing.Size(51, 17);
            this.Radio_beepEn.TabIndex = 9;
            this.Radio_beepEn.Text = "Open";
            this.Radio_beepEn.UseVisualStyleBackColor = true;
            // 
            // Button_Beep
            // 
            this.Button_Beep.Location = new System.Drawing.Point(232, 15);
            this.Button_Beep.Name = "Button_Beep";
            this.Button_Beep.Size = new System.Drawing.Size(90, 25);
            this.Button_Beep.TabIndex = 8;
            this.Button_Beep.Text = "Set";
            this.Button_Beep.UseVisualStyleBackColor = true;
            this.Button_Beep.Click += new System.EventHandler(this.Button_Beep_Click);
            // 
            // gpb_RDVersion
            // 
            this.gpb_RDVersion.Controls.Add(this.text_RDVersion);
            this.gpb_RDVersion.Location = new System.Drawing.Point(354, 5);
            this.gpb_RDVersion.Name = "gpb_RDVersion";
            this.gpb_RDVersion.Size = new System.Drawing.Size(342, 48);
            this.gpb_RDVersion.TabIndex = 26;
            this.gpb_RDVersion.TabStop = false;
            this.gpb_RDVersion.Text = "Firmware version";
            // 
            // text_RDVersion
            // 
            this.text_RDVersion.Location = new System.Drawing.Point(95, 16);
            this.text_RDVersion.MaxLength = 2;
            this.text_RDVersion.Name = "text_RDVersion";
            this.text_RDVersion.ReadOnly = true;
            this.text_RDVersion.Size = new System.Drawing.Size(160, 20);
            this.text_RDVersion.TabIndex = 24;
            // 
            // gpb_MDVersion
            // 
            this.gpb_MDVersion.Controls.Add(this.text_MDVersion);
            this.gpb_MDVersion.Controls.Add(this.btMDVersion);
            this.gpb_MDVersion.Location = new System.Drawing.Point(6, 506);
            this.gpb_MDVersion.Name = "gpb_MDVersion";
            this.gpb_MDVersion.Size = new System.Drawing.Size(342, 64);
            this.gpb_MDVersion.TabIndex = 25;
            this.gpb_MDVersion.TabStop = false;
            this.gpb_MDVersion.Text = "R2000 Module version";
            // 
            // text_MDVersion
            // 
            this.text_MDVersion.Location = new System.Drawing.Point(95, 25);
            this.text_MDVersion.MaxLength = 2;
            this.text_MDVersion.Name = "text_MDVersion";
            this.text_MDVersion.ReadOnly = true;
            this.text_MDVersion.Size = new System.Drawing.Size(121, 20);
            this.text_MDVersion.TabIndex = 24;
            // 
            // btMDVersion
            // 
            this.btMDVersion.Location = new System.Drawing.Point(233, 25);
            this.btMDVersion.Name = "btMDVersion";
            this.btMDVersion.Size = new System.Drawing.Size(90, 25);
            this.btMDVersion.TabIndex = 23;
            this.btMDVersion.Text = "Get";
            this.btMDVersion.UseVisualStyleBackColor = true;
            this.btMDVersion.Click += new System.EventHandler(this.btMDVersion_Click);
            // 
            // gpb_Serial
            // 
            this.gpb_Serial.Controls.Add(this.text_Serial);
            this.gpb_Serial.Controls.Add(this.btSerial);
            this.gpb_Serial.Location = new System.Drawing.Point(6, 263);
            this.gpb_Serial.Name = "gpb_Serial";
            this.gpb_Serial.Size = new System.Drawing.Size(342, 47);
            this.gpb_Serial.TabIndex = 6;
            this.gpb_Serial.TabStop = false;
            this.gpb_Serial.Text = "Reader serial number\n";
            // 
            // text_Serial
            // 
            this.text_Serial.Location = new System.Drawing.Point(95, 14);
            this.text_Serial.MaxLength = 8;
            this.text_Serial.Name = "text_Serial";
            this.text_Serial.ReadOnly = true;
            this.text_Serial.Size = new System.Drawing.Size(121, 20);
            this.text_Serial.TabIndex = 24;
            // 
            // btSerial
            // 
            this.btSerial.Location = new System.Drawing.Point(233, 14);
            this.btSerial.Name = "btSerial";
            this.btSerial.Size = new System.Drawing.Size(90, 25);
            this.btSerial.TabIndex = 23;
            this.btSerial.Text = "Get";
            this.btSerial.UseVisualStyleBackColor = true;
            this.btSerial.Click += new System.EventHandler(this.btSerial_Click);
            // 
            // gpb_address
            // 
            this.gpb_address.Controls.Add(this.text_address);
            this.gpb_address.Controls.Add(this.btaddress);
            this.gpb_address.Location = new System.Drawing.Point(6, 212);
            this.gpb_address.Name = "gpb_address";
            this.gpb_address.Size = new System.Drawing.Size(342, 49);
            this.gpb_address.TabIndex = 5;
            this.gpb_address.TabStop = false;
            this.gpb_address.Text = "Reader address";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(95, 15);
            this.text_address.MaxLength = 2;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(121, 20);
            this.text_address.TabIndex = 24;
            this.text_address.Text = "00";
            this.text_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btaddress
            // 
            this.btaddress.Location = new System.Drawing.Point(233, 15);
            this.btaddress.Name = "btaddress";
            this.btaddress.Size = new System.Drawing.Size(90, 25);
            this.btaddress.TabIndex = 23;
            this.btaddress.Text = "Set";
            this.btaddress.UseVisualStyleBackColor = true;
            this.btaddress.Click += new System.EventHandler(this.btaddress_Click);
            // 
            // gpb_tcp
            // 
            this.gpb_tcp.Controls.Add(this.tb_Port);
            this.gpb_tcp.Controls.Add(this.ipServerIP);
            this.gpb_tcp.Controls.Add(this.btDisConnectTcp);
            this.gpb_tcp.Controls.Add(this.btConnectTcp);
            this.gpb_tcp.Controls.Add(this.label2);
            this.gpb_tcp.Controls.Add(this.label4);
            this.gpb_tcp.Location = new System.Drawing.Point(5, 133);
            this.gpb_tcp.Name = "gpb_tcp";
            this.gpb_tcp.Size = new System.Drawing.Size(343, 77);
            this.gpb_tcp.TabIndex = 4;
            this.gpb_tcp.TabStop = false;
            this.gpb_tcp.Text = "TCP/IP";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(96, 43);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(121, 20);
            this.tb_Port.TabIndex = 22;
            this.tb_Port.Text = "27011";
            this.tb_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ipServerIP
            // 
            this.ipServerIP.IpAddressStr = "192.168.0.250";
            this.ipServerIP.Location = new System.Drawing.Point(96, 16);
            this.ipServerIP.Name = "ipServerIP";
            this.ipServerIP.Size = new System.Drawing.Size(121, 23);
            this.ipServerIP.TabIndex = 21;
            this.ipServerIP.Tag = "";
            // 
            // btDisConnectTcp
            // 
            this.btDisConnectTcp.Enabled = false;
            this.btDisConnectTcp.Location = new System.Drawing.Point(234, 43);
            this.btDisConnectTcp.Name = "btDisConnectTcp";
            this.btDisConnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btDisConnectTcp.TabIndex = 20;
            this.btDisConnectTcp.Text = "Disconnect";
            this.btDisConnectTcp.UseVisualStyleBackColor = true;
            this.btDisConnectTcp.Click += new System.EventHandler(this.btDisConnectTcp_Click);
            // 
            // btConnectTcp
            // 
            this.btConnectTcp.Location = new System.Drawing.Point(234, 14);
            this.btConnectTcp.Name = "btConnectTcp";
            this.btConnectTcp.Size = new System.Drawing.Size(90, 25);
            this.btConnectTcp.TabIndex = 19;
            this.btConnectTcp.Text = "Connect";
            this.btConnectTcp.UseVisualStyleBackColor = true;
            this.btConnectTcp.Click += new System.EventHandler(this.btConnectTcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP Addr:";
            // 
            // gpb_rs232
            // 
            this.gpb_rs232.Controls.Add(this.btDisConnect232);
            this.gpb_rs232.Controls.Add(this.btConnect232);
            this.gpb_rs232.Controls.Add(this.ComboBox_baud2);
            this.gpb_rs232.Controls.Add(this.label47);
            this.gpb_rs232.Controls.Add(this.ComboBox_COM);
            this.gpb_rs232.Controls.Add(this.label3);
            this.gpb_rs232.Location = new System.Drawing.Point(5, 55);
            this.gpb_rs232.Name = "gpb_rs232";
            this.gpb_rs232.Size = new System.Drawing.Size(343, 76);
            this.gpb_rs232.TabIndex = 3;
            this.gpb_rs232.TabStop = false;
            this.gpb_rs232.Text = "RS232";
            // 
            // btDisConnect232
            // 
            this.btDisConnect232.Enabled = false;
            this.btDisConnect232.Location = new System.Drawing.Point(234, 44);
            this.btDisConnect232.Name = "btDisConnect232";
            this.btDisConnect232.Size = new System.Drawing.Size(90, 25);
            this.btDisConnect232.TabIndex = 20;
            this.btDisConnect232.Text = "Disconnect";
            this.btDisConnect232.UseVisualStyleBackColor = true;
            this.btDisConnect232.Click += new System.EventHandler(this.btDisConnect232_Click);
            // 
            // btConnect232
            // 
            this.btConnect232.Location = new System.Drawing.Point(234, 14);
            this.btConnect232.Name = "btConnect232";
            this.btConnect232.Size = new System.Drawing.Size(90, 25);
            this.btConnect232.TabIndex = 19;
            this.btConnect232.Text = "Connect";
            this.btConnect232.UseVisualStyleBackColor = true;
            this.btConnect232.Click += new System.EventHandler(this.btConnect232_Click);
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(96, 47);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_baud2.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(21, 52);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 13);
            this.label47.TabIndex = 17;
            this.label47.Text = "Baud rate:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBox_COM.Location = new System.Drawing.Point(96, 16);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_COM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tcp);
            this.groupBox1.Controls.Add(this.rb_rs232);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Type";
            // 
            // rb_tcp
            // 
            this.rb_tcp.AutoSize = true;
            this.rb_tcp.Location = new System.Drawing.Point(190, 20);
            this.rb_tcp.Name = "rb_tcp";
            this.rb_tcp.Size = new System.Drawing.Size(61, 17);
            this.rb_tcp.TabIndex = 1;
            this.rb_tcp.Text = "TCP/IP";
            this.rb_tcp.UseVisualStyleBackColor = true;
            this.rb_tcp.CheckedChanged += new System.EventHandler(this.rb_tcp_CheckedChanged);
            // 
            // rb_rs232
            // 
            this.rb_rs232.AutoSize = true;
            this.rb_rs232.Location = new System.Drawing.Point(33, 20);
            this.rb_rs232.Name = "rb_rs232";
            this.rb_rs232.Size = new System.Drawing.Size(58, 17);
            this.rb_rs232.TabIndex = 0;
            this.rb_rs232.Text = "RS232";
            this.rb_rs232.UseVisualStyleBackColor = true;
            this.rb_rs232.CheckedChanged += new System.EventHandler(this.rb_rs232_CheckedChanged);
            // 
            // tabPage_Mx
            // 
            this.tabPage_Mx.Controls.Add(this.panel2);
            this.tabPage_Mx.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Mx.Name = "tabPage_Mx";
            this.tabPage_Mx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Mx.Size = new System.Drawing.Size(1057, 584);
            this.tabPage_Mx.TabIndex = 1;
            this.tabPage_Mx.Text = "Auto-running setting";
            this.tabPage_Mx.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbp_trigger);
            this.panel2.Controls.Add(this.groupBox43);
            this.panel2.Controls.Add(this.groupBox44);
            this.panel2.Controls.Add(this.btGetWorkmodepara);
            this.panel2.Controls.Add(this.groupBox37);
            this.panel2.Controls.Add(this.groupBox36);
            this.panel2.Controls.Add(this.gbp_tagType);
            this.panel2.Controls.Add(this.gbp_Response);
            this.panel2.Controls.Add(this.gbp_mask);
            this.panel2.Controls.Add(this.gbp_EASAcc);
            this.panel2.Location = new System.Drawing.Point(-3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 610);
            this.panel2.TabIndex = 0;
            // 
            // gbp_trigger
            // 
            this.gbp_trigger.Controls.Add(this.label84);
            this.gbp_trigger.Controls.Add(this.bttrigger);
            this.gbp_trigger.Controls.Add(this.comboBox_trigger);
            this.gbp_trigger.Controls.Add(this.label85);
            this.gbp_trigger.Location = new System.Drawing.Point(709, 107);
            this.gbp_trigger.Name = "gbp_trigger";
            this.gbp_trigger.Size = new System.Drawing.Size(340, 73);
            this.gbp_trigger.TabIndex = 84;
            this.gbp_trigger.TabStop = false;
            this.gbp_trigger.Text = "Set Trigger-Time";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(183, 37);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(22, 13);
            this.label84.TabIndex = 5;
            this.label84.Text = "*1s";
            // 
            // bttrigger
            // 
            this.bttrigger.Location = new System.Drawing.Point(244, 31);
            this.bttrigger.Name = "bttrigger";
            this.bttrigger.Size = new System.Drawing.Size(90, 25);
            this.bttrigger.TabIndex = 2;
            this.bttrigger.Text = "Set";
            this.bttrigger.UseVisualStyleBackColor = true;
            this.bttrigger.Click += new System.EventHandler(this.bttrigger_Click);
            // 
            // comboBox_trigger
            // 
            this.comboBox_trigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trigger.FormattingEnabled = true;
            this.comboBox_trigger.Location = new System.Drawing.Point(90, 31);
            this.comboBox_trigger.Name = "comboBox_trigger";
            this.comboBox_trigger.Size = new System.Drawing.Size(91, 21);
            this.comboBox_trigger.TabIndex = 1;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(5, 35);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(69, 13);
            this.label85.TabIndex = 0;
            this.label85.Text = "Trigger Time:";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.btGetQS);
            this.groupBox43.Controls.Add(this.btSetQS);
            this.groupBox43.Controls.Add(this.com_acS);
            this.groupBox43.Controls.Add(this.label65);
            this.groupBox43.Controls.Add(this.com_acQ);
            this.groupBox43.Controls.Add(this.label64);
            this.groupBox43.Location = new System.Drawing.Point(444, 186);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Size = new System.Drawing.Size(606, 61);
            this.groupBox43.TabIndex = 83;
            this.groupBox43.TabStop = false;
            this.groupBox43.Text = "Mutiple query parameter";
            // 
            // btGetQS
            // 
            this.btGetQS.Location = new System.Drawing.Point(509, 22);
            this.btGetQS.Name = "btGetQS";
            this.btGetQS.Size = new System.Drawing.Size(90, 25);
            this.btGetQS.TabIndex = 7;
            this.btGetQS.Text = "Get";
            this.btGetQS.UseVisualStyleBackColor = true;
            this.btGetQS.Click += new System.EventHandler(this.btGetQS_Click);
            // 
            // btSetQS
            // 
            this.btSetQS.Location = new System.Drawing.Point(397, 22);
            this.btSetQS.Name = "btSetQS";
            this.btSetQS.Size = new System.Drawing.Size(90, 25);
            this.btSetQS.TabIndex = 6;
            this.btSetQS.Text = "Set";
            this.btSetQS.UseVisualStyleBackColor = true;
            this.btSetQS.Click += new System.EventHandler(this.btSetQS_Click);
            // 
            // com_acS
            // 
            this.com_acS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acS.FormattingEnabled = true;
            this.com_acS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.com_acS.Location = new System.Drawing.Point(269, 24);
            this.com_acS.Name = "com_acS";
            this.com_acS.Size = new System.Drawing.Size(91, 21);
            this.com_acS.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(187, 28);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(50, 13);
            this.label65.TabIndex = 4;
            this.label65.Text = "Session：";
            // 
            // com_acQ
            // 
            this.com_acQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acQ.FormattingEnabled = true;
            this.com_acQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_acQ.Location = new System.Drawing.Point(67, 25);
            this.com_acQ.Name = "com_acQ";
            this.com_acQ.Size = new System.Drawing.Size(91, 21);
            this.com_acQ.TabIndex = 3;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(18, 28);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(21, 13);
            this.label64.TabIndex = 2;
            this.label64.Text = "Q：";
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.text_tidlen);
            this.groupBox44.Controls.Add(this.label67);
            this.groupBox44.Controls.Add(this.text_tidaddr);
            this.groupBox44.Controls.Add(this.btTIDpara);
            this.groupBox44.Controls.Add(this.label66);
            this.groupBox44.Location = new System.Drawing.Point(8, 186);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(430, 61);
            this.groupBox44.TabIndex = 82;
            this.groupBox44.TabStop = false;
            this.groupBox44.Text = "TID Parameter Setting";
            // 
            // text_tidlen
            // 
            this.text_tidlen.Location = new System.Drawing.Point(238, 25);
            this.text_tidlen.MaxLength = 2;
            this.text_tidlen.Name = "text_tidlen";
            this.text_tidlen.Size = new System.Drawing.Size(69, 20);
            this.text_tidlen.TabIndex = 5;
            this.text_tidlen.Text = "04";
            this.text_tidlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(167, 28);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(43, 13);
            this.label67.TabIndex = 4;
            this.label67.Text = "Length:";
            // 
            // text_tidaddr
            // 
            this.text_tidaddr.Location = new System.Drawing.Point(87, 25);
            this.text_tidaddr.MaxLength = 2;
            this.text_tidaddr.Name = "text_tidaddr";
            this.text_tidaddr.Size = new System.Drawing.Size(69, 20);
            this.text_tidaddr.TabIndex = 3;
            this.text_tidaddr.Text = "02";
            this.text_tidaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btTIDpara
            // 
            this.btTIDpara.Location = new System.Drawing.Point(321, 24);
            this.btTIDpara.Name = "btTIDpara";
            this.btTIDpara.Size = new System.Drawing.Size(90, 25);
            this.btTIDpara.TabIndex = 2;
            this.btTIDpara.Text = "Set";
            this.btTIDpara.UseVisualStyleBackColor = true;
            this.btTIDpara.Click += new System.EventHandler(this.btTIDpara_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(0, 28);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(73, 13);
            this.label66.TabIndex = 0;
            this.label66.Text = "Start Address:";
            // 
            // btGetWorkmodepara
            // 
            this.btGetWorkmodepara.Location = new System.Drawing.Point(732, 262);
            this.btGetWorkmodepara.Name = "btGetWorkmodepara";
            this.btGetWorkmodepara.Size = new System.Drawing.Size(320, 43);
            this.btGetWorkmodepara.TabIndex = 80;
            this.btGetWorkmodepara.Text = "Get System Parameter";
            this.btGetWorkmodepara.UseVisualStyleBackColor = true;
            this.btGetWorkmodepara.Click += new System.EventHandler(this.btGetWorkmodepara_Click);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.btworkmode);
            this.groupBox37.Controls.Add(this.comboBox_mode);
            this.groupBox37.Controls.Add(this.label59);
            this.groupBox37.Location = new System.Drawing.Point(345, 249);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(380, 61);
            this.groupBox37.TabIndex = 79;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Work Mode";
            // 
            // btworkmode
            // 
            this.btworkmode.Location = new System.Drawing.Point(273, 22);
            this.btworkmode.Name = "btworkmode";
            this.btworkmode.Size = new System.Drawing.Size(90, 25);
            this.btworkmode.TabIndex = 2;
            this.btworkmode.Text = "Set";
            this.btworkmode.UseVisualStyleBackColor = true;
            this.btworkmode.Click += new System.EventHandler(this.btworkmode_Click);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "Answer Mode",
            "Auto_running mode",
            "Trigger mode(Low)",
            "Trigger mode(High)"});
            this.comboBox_mode.Location = new System.Drawing.Point(92, 25);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(168, 21);
            this.comboBox_mode.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(7, 28);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(70, 13);
            this.label59.TabIndex = 0;
            this.label59.Text = "Mode Select:";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.btInterval);
            this.groupBox36.Controls.Add(this.comboBox_intervalT);
            this.groupBox36.Controls.Add(this.label58);
            this.groupBox36.Location = new System.Drawing.Point(8, 249);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(331, 61);
            this.groupBox36.TabIndex = 78;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Pulse interval";
            // 
            // btInterval
            // 
            this.btInterval.Location = new System.Drawing.Point(217, 22);
            this.btInterval.Name = "btInterval";
            this.btInterval.Size = new System.Drawing.Size(90, 25);
            this.btInterval.TabIndex = 2;
            this.btInterval.Text = "Set";
            this.btInterval.UseVisualStyleBackColor = true;
            this.btInterval.Click += new System.EventHandler(this.btInterval_Click);
            // 
            // comboBox_intervalT
            // 
            this.comboBox_intervalT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_intervalT.FormattingEnabled = true;
            this.comboBox_intervalT.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.comboBox_intervalT.Location = new System.Drawing.Point(73, 25);
            this.comboBox_intervalT.Name = "comboBox_intervalT";
            this.comboBox_intervalT.Size = new System.Drawing.Size(131, 21);
            this.comboBox_intervalT.TabIndex = 1;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(7, 28);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(62, 13);
            this.label58.TabIndex = 0;
            this.label58.Text = "Pulse Time:";
            // 
            // gbp_tagType
            // 
            this.gbp_tagType.Controls.Add(this.rb_G2TID);
            this.gbp_tagType.Controls.Add(this.bt_typeTag);
            this.gbp_tagType.Controls.Add(this.rb_EAS);
            this.gbp_tagType.Controls.Add(this.rb_G2);
            this.gbp_tagType.Controls.Add(this.groupBox35);
            this.gbp_tagType.Location = new System.Drawing.Point(8, 105);
            this.gbp_tagType.Name = "gbp_tagType";
            this.gbp_tagType.Size = new System.Drawing.Size(695, 75);
            this.gbp_tagType.TabIndex = 77;
            this.gbp_tagType.TabStop = false;
            this.gbp_tagType.Text = "Query Tag Type";
            // 
            // rb_G2TID
            // 
            this.rb_G2TID.AutoSize = true;
            this.rb_G2TID.Location = new System.Drawing.Point(460, 34);
            this.rb_G2TID.Name = "rb_G2TID";
            this.rb_G2TID.Size = new System.Drawing.Size(120, 17);
            this.rb_G2TID.TabIndex = 5;
            this.rb_G2TID.Text = "Query G2 Tag\'s TID";
            this.rb_G2TID.UseVisualStyleBackColor = true;
            // 
            // bt_typeTag
            // 
            this.bt_typeTag.Location = new System.Drawing.Point(599, 30);
            this.bt_typeTag.Name = "bt_typeTag";
            this.bt_typeTag.Size = new System.Drawing.Size(90, 25);
            this.bt_typeTag.TabIndex = 4;
            this.bt_typeTag.Text = "Set";
            this.bt_typeTag.UseVisualStyleBackColor = true;
            this.bt_typeTag.Click += new System.EventHandler(this.bt_typeTag_Click);
            // 
            // rb_EAS
            // 
            this.rb_EAS.AutoSize = true;
            this.rb_EAS.Location = new System.Drawing.Point(358, 34);
            this.rb_EAS.Name = "rb_EAS";
            this.rb_EAS.Size = new System.Drawing.Size(81, 17);
            this.rb_EAS.TabIndex = 3;
            this.rb_EAS.Text = "Detect EAS";
            this.rb_EAS.UseVisualStyleBackColor = true;
            // 
            // rb_G2
            // 
            this.rb_G2.AutoSize = true;
            this.rb_G2.Checked = true;
            this.rb_G2.Location = new System.Drawing.Point(247, 34);
            this.rb_G2.Name = "rb_G2";
            this.rb_G2.Size = new System.Drawing.Size(92, 17);
            this.rb_G2.TabIndex = 1;
            this.rb_G2.TabStop = true;
            this.rb_G2.Text = "Query G2 Tag";
            this.rb_G2.UseVisualStyleBackColor = true;
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.rb_180006B);
            this.groupBox35.Controls.Add(this.rb_180006c);
            this.groupBox35.Location = new System.Drawing.Point(6, 15);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(200, 52);
            this.groupBox35.TabIndex = 0;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Protocl";
            // 
            // rb_180006B
            // 
            this.rb_180006B.AutoSize = true;
            this.rb_180006B.Location = new System.Drawing.Point(106, 22);
            this.rb_180006B.Name = "rb_180006B";
            this.rb_180006B.Size = new System.Drawing.Size(71, 17);
            this.rb_180006B.TabIndex = 1;
            this.rb_180006B.Text = "18000-6B";
            this.rb_180006B.UseVisualStyleBackColor = true;
            // 
            // rb_180006c
            // 
            this.rb_180006c.AutoSize = true;
            this.rb_180006c.Checked = true;
            this.rb_180006c.Location = new System.Drawing.Point(10, 22);
            this.rb_180006c.Name = "rb_180006c";
            this.rb_180006c.Size = new System.Drawing.Size(76, 17);
            this.rb_180006c.TabIndex = 0;
            this.rb_180006c.TabStop = true;
            this.rb_180006c.Text = "EPCC1-G2";
            this.rb_180006c.UseVisualStyleBackColor = true;
            // 
            // gbp_Response
            // 
            this.gbp_Response.Controls.Add(this.btResponse);
            this.gbp_Response.Controls.Add(this.label57);
            this.gbp_Response.Controls.Add(this.comboBox_RespTime);
            this.gbp_Response.Controls.Add(this.label56);
            this.gbp_Response.Controls.Add(this.comboBox_Resp);
            this.gbp_Response.Controls.Add(this.label55);
            this.gbp_Response.Location = new System.Drawing.Point(746, 4);
            this.gbp_Response.Name = "gbp_Response";
            this.gbp_Response.Size = new System.Drawing.Size(305, 94);
            this.gbp_Response.TabIndex = 76;
            this.gbp_Response.TabStop = false;
            this.gbp_Response.Text = "Response conditions  Setting";
            // 
            // btResponse
            // 
            this.btResponse.Location = new System.Drawing.Point(207, 54);
            this.btResponse.Name = "btResponse";
            this.btResponse.Size = new System.Drawing.Size(90, 25);
            this.btResponse.TabIndex = 5;
            this.btResponse.Text = "Set";
            this.btResponse.UseVisualStyleBackColor = true;
            this.btResponse.Click += new System.EventHandler(this.btResponse_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(173, 63);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(22, 13);
            this.label57.TabIndex = 4;
            this.label57.Text = "*1s";
            // 
            // comboBox_RespTime
            // 
            this.comboBox_RespTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RespTime.FormattingEnabled = true;
            this.comboBox_RespTime.Location = new System.Drawing.Point(95, 55);
            this.comboBox_RespTime.Name = "comboBox_RespTime";
            this.comboBox_RespTime.Size = new System.Drawing.Size(77, 21);
            this.comboBox_RespTime.TabIndex = 3;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 63);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(83, 13);
            this.label56.TabIndex = 2;
            this.label56.Text = "RepPauseTime:";
            // 
            // comboBox_Resp
            // 
            this.comboBox_Resp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Resp.FormattingEnabled = true;
            this.comboBox_Resp.Items.AddRange(new object[] {
            "Command notify",
            "Timer notify",
            "Add-in notify",
            "Delete notify",
            "Change notify"});
            this.comboBox_Resp.Location = new System.Drawing.Point(95, 24);
            this.comboBox_Resp.Name = "comboBox_Resp";
            this.comboBox_Resp.Size = new System.Drawing.Size(202, 21);
            this.comboBox_Resp.TabIndex = 1;
            this.comboBox_Resp.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resp_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 28);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(74, 13);
            this.label55.TabIndex = 0;
            this.label55.Text = "RepCondition:";
            // 
            // gbp_mask
            // 
            this.gbp_mask.Controls.Add(this.btMaskSet);
            this.gbp_mask.Controls.Add(this.text_mdata);
            this.gbp_mask.Controls.Add(this.label54);
            this.gbp_mask.Controls.Add(this.text_mlen);
            this.gbp_mask.Controls.Add(this.label53);
            this.gbp_mask.Controls.Add(this.text_madds);
            this.gbp_mask.Controls.Add(this.label81);
            this.gbp_mask.Controls.Add(this.rb_MaskUser);
            this.gbp_mask.Controls.Add(this.rb_MaskTID);
            this.gbp_mask.Controls.Add(this.rb_MaskEPC);
            this.gbp_mask.Location = new System.Drawing.Point(346, 4);
            this.gbp_mask.Name = "gbp_mask";
            this.gbp_mask.Size = new System.Drawing.Size(384, 94);
            this.gbp_mask.TabIndex = 75;
            this.gbp_mask.TabStop = false;
            this.gbp_mask.Text = "Mask setting";
            // 
            // btMaskSet
            // 
            this.btMaskSet.Location = new System.Drawing.Point(285, 64);
            this.btMaskSet.Name = "btMaskSet";
            this.btMaskSet.Size = new System.Drawing.Size(90, 25);
            this.btMaskSet.TabIndex = 9;
            this.btMaskSet.Text = "Set";
            this.btMaskSet.UseVisualStyleBackColor = true;
            this.btMaskSet.Click += new System.EventHandler(this.btMaskSet_Click);
            // 
            // text_mdata
            // 
            this.text_mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mdata.Location = new System.Drawing.Point(94, 66);
            this.text_mdata.Name = "text_mdata";
            this.text_mdata.Size = new System.Drawing.Size(177, 20);
            this.text_mdata.TabIndex = 8;
            this.text_mdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 73);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(85, 13);
            this.label54.TabIndex = 7;
            this.label54.Text = "Mask data(Hex):";
            // 
            // text_mlen
            // 
            this.text_mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mlen.Location = new System.Drawing.Point(313, 36);
            this.text_mlen.MaxLength = 2;
            this.text_mlen.Name = "text_mlen";
            this.text_mlen.Size = new System.Drawing.Size(62, 20);
            this.text_mlen.TabIndex = 6;
            this.text_mlen.Text = "00";
            this.text_mlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(204, 43);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(93, 13);
            this.label53.TabIndex = 5;
            this.label53.Text = "Mask length(Hex):";
            // 
            // text_madds
            // 
            this.text_madds.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_madds.Location = new System.Drawing.Point(137, 36);
            this.text_madds.MaxLength = 4;
            this.text_madds.Name = "text_madds";
            this.text_madds.Size = new System.Drawing.Size(55, 20);
            this.text_madds.TabIndex = 4;
            this.text_madds.Text = "0000";
            this.text_madds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(6, 43);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(101, 13);
            this.label81.TabIndex = 3;
            this.label81.Text = "Mask address(Hex):";
            // 
            // rb_MaskUser
            // 
            this.rb_MaskUser.AutoSize = true;
            this.rb_MaskUser.Location = new System.Drawing.Point(214, 15);
            this.rb_MaskUser.Name = "rb_MaskUser";
            this.rb_MaskUser.Size = new System.Drawing.Size(47, 17);
            this.rb_MaskUser.TabIndex = 2;
            this.rb_MaskUser.Text = "User";
            this.rb_MaskUser.UseVisualStyleBackColor = true;
            // 
            // rb_MaskTID
            // 
            this.rb_MaskTID.AutoSize = true;
            this.rb_MaskTID.Location = new System.Drawing.Point(110, 15);
            this.rb_MaskTID.Name = "rb_MaskTID";
            this.rb_MaskTID.Size = new System.Drawing.Size(43, 17);
            this.rb_MaskTID.TabIndex = 1;
            this.rb_MaskTID.Text = "TID";
            this.rb_MaskTID.UseVisualStyleBackColor = true;
            // 
            // rb_MaskEPC
            // 
            this.rb_MaskEPC.AutoSize = true;
            this.rb_MaskEPC.Checked = true;
            this.rb_MaskEPC.Location = new System.Drawing.Point(6, 15);
            this.rb_MaskEPC.Name = "rb_MaskEPC";
            this.rb_MaskEPC.Size = new System.Drawing.Size(46, 17);
            this.rb_MaskEPC.TabIndex = 0;
            this.rb_MaskEPC.TabStop = true;
            this.rb_MaskEPC.Text = "EPC";
            this.rb_MaskEPC.UseVisualStyleBackColor = true;
            // 
            // gbp_EASAcc
            // 
            this.gbp_EASAcc.Controls.Add(this.btAccuracy);
            this.gbp_EASAcc.Controls.Add(this.ComboBox_Accuracy);
            this.gbp_EASAcc.Controls.Add(this.label82);
            this.gbp_EASAcc.Controls.Add(this.rbNone);
            this.gbp_EASAcc.Controls.Add(this.rbEASAcc);
            this.gbp_EASAcc.Location = new System.Drawing.Point(8, 4);
            this.gbp_EASAcc.Name = "gbp_EASAcc";
            this.gbp_EASAcc.Size = new System.Drawing.Size(330, 94);
            this.gbp_EASAcc.TabIndex = 74;
            this.gbp_EASAcc.TabStop = false;
            this.gbp_EASAcc.Text = "EAS Sensitivity ";
            // 
            // btAccuracy
            // 
            this.btAccuracy.Location = new System.Drawing.Point(217, 53);
            this.btAccuracy.Name = "btAccuracy";
            this.btAccuracy.Size = new System.Drawing.Size(90, 25);
            this.btAccuracy.TabIndex = 4;
            this.btAccuracy.Text = "Set";
            this.btAccuracy.UseVisualStyleBackColor = true;
            this.btAccuracy.Click += new System.EventHandler(this.btAccuracy_Click);
            // 
            // ComboBox_Accuracy
            // 
            this.ComboBox_Accuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Accuracy.FormattingEnabled = true;
            this.ComboBox_Accuracy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ComboBox_Accuracy.Location = new System.Drawing.Point(94, 56);
            this.ComboBox_Accuracy.Name = "ComboBox_Accuracy";
            this.ComboBox_Accuracy.Size = new System.Drawing.Size(79, 21);
            this.ComboBox_Accuracy.TabIndex = 3;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(12, 60);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(79, 13);
            this.label82.TabIndex = 2;
            this.label82.Text = "EAS Accuracy:";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(244, 24);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 1;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbEASAcc
            // 
            this.rbEASAcc.AutoSize = true;
            this.rbEASAcc.Checked = true;
            this.rbEASAcc.Location = new System.Drawing.Point(12, 24);
            this.rbEASAcc.Name = "rbEASAcc";
            this.rbEASAcc.Size = new System.Drawing.Size(201, 17);
            this.rbEASAcc.TabIndex = 0;
            this.rbEASAcc.TabStop = true;
            this.rbEASAcc.Text = "Relay release 3s when detected EAS";
            this.rbEASAcc.UseVisualStyleBackColor = true;
            // 
            // tabPage_Module
            // 
            this.tabPage_Module.Controls.Add(this.panel9);
            this.tabPage_Module.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Module.Name = "tabPage_Module";
            this.tabPage_Module.Size = new System.Drawing.Size(1057, 584);
            this.tabPage_Module.TabIndex = 2;
            this.tabPage_Module.Text = "Real-time-inventory setting";
            this.tabPage_Module.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btMSetParameter);
            this.panel9.Controls.Add(this.btMGetParameter);
            this.panel9.Controls.Add(this.groupBox39);
            this.panel9.Controls.Add(this.groupBox38);
            this.panel9.Controls.Add(this.groupBox34);
            this.panel9.Controls.Add(this.groupBox33);
            this.panel9.Controls.Add(this.groupBox32);
            this.panel9.Controls.Add(this.groupBox28);
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1059, 548);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btMSetParameter
            // 
            this.btMSetParameter.Location = new System.Drawing.Point(928, 128);
            this.btMSetParameter.Name = "btMSetParameter";
            this.btMSetParameter.Size = new System.Drawing.Size(119, 36);
            this.btMSetParameter.TabIndex = 86;
            this.btMSetParameter.Text = "Set Parameter";
            this.btMSetParameter.UseVisualStyleBackColor = true;
            this.btMSetParameter.Click += new System.EventHandler(this.btMSetParameter_Click);
            // 
            // btMGetParameter
            // 
            this.btMGetParameter.Location = new System.Drawing.Point(928, 80);
            this.btMGetParameter.Name = "btMGetParameter";
            this.btMGetParameter.Size = new System.Drawing.Size(119, 36);
            this.btMGetParameter.TabIndex = 85;
            this.btMGetParameter.Text = "Get Parameter";
            this.btMGetParameter.UseVisualStyleBackColor = true;
            this.btMGetParameter.Click += new System.EventHandler(this.btMGetParameter_Click);
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.btSetMmode);
            this.groupBox39.Controls.Add(this.com_Mmode);
            this.groupBox39.Controls.Add(this.label111);
            this.groupBox39.Location = new System.Drawing.Point(656, 75);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(265, 94);
            this.groupBox39.TabIndex = 84;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Work Mode";
            // 
            // btSetMmode
            // 
            this.btSetMmode.Location = new System.Drawing.Point(170, 61);
            this.btSetMmode.Name = "btSetMmode";
            this.btSetMmode.Size = new System.Drawing.Size(90, 25);
            this.btSetMmode.TabIndex = 2;
            this.btSetMmode.Text = "Set";
            this.btSetMmode.UseVisualStyleBackColor = true;
            this.btSetMmode.Click += new System.EventHandler(this.btSetMmode_Click);
            // 
            // com_Mmode
            // 
            this.com_Mmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Mmode.FormattingEnabled = true;
            this.com_Mmode.Items.AddRange(new object[] {
            "Answer mode",
            "Real-time-inventory mode",
            "trigger-mode"});
            this.com_Mmode.Location = new System.Drawing.Point(92, 25);
            this.com_Mmode.Name = "com_Mmode";
            this.com_Mmode.Size = new System.Drawing.Size(168, 21);
            this.com_Mmode.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(7, 28);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(70, 13);
            this.label111.TabIndex = 0;
            this.label111.Text = "Mode Select:";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.checkBox_tid);
            this.groupBox38.Controls.Add(this.txt_Mtidlen);
            this.groupBox38.Controls.Add(this.label103);
            this.groupBox38.Controls.Add(this.txt_mtidaddr);
            this.groupBox38.Controls.Add(this.label104);
            this.groupBox38.Location = new System.Drawing.Point(436, 75);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(214, 94);
            this.groupBox38.TabIndex = 83;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "TID Parameter Setting";
            // 
            // checkBox_tid
            // 
            this.checkBox_tid.AutoSize = true;
            this.checkBox_tid.Location = new System.Drawing.Point(160, 65);
            this.checkBox_tid.Name = "checkBox_tid";
            this.checkBox_tid.Size = new System.Drawing.Size(59, 17);
            this.checkBox_tid.TabIndex = 10;
            this.checkBox_tid.Text = "Enable";
            this.checkBox_tid.UseVisualStyleBackColor = true;
            // 
            // txt_Mtidlen
            // 
            this.txt_Mtidlen.Location = new System.Drawing.Point(87, 63);
            this.txt_Mtidlen.MaxLength = 2;
            this.txt_Mtidlen.Name = "txt_Mtidlen";
            this.txt_Mtidlen.Size = new System.Drawing.Size(60, 20);
            this.txt_Mtidlen.TabIndex = 5;
            this.txt_Mtidlen.Text = "04";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(13, 66);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(68, 13);
            this.label103.TabIndex = 4;
            this.label103.Text = "Length(Hex):";
            // 
            // txt_mtidaddr
            // 
            this.txt_mtidaddr.Location = new System.Drawing.Point(138, 25);
            this.txt_mtidaddr.MaxLength = 2;
            this.txt_mtidaddr.Name = "txt_mtidaddr";
            this.txt_mtidaddr.Size = new System.Drawing.Size(64, 20);
            this.txt_mtidaddr.TabIndex = 3;
            this.txt_mtidaddr.Text = "02";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(13, 28);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(97, 13);
            this.label104.TabIndex = 0;
            this.label104.Text = "Start address(Hex):";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.checkBox_mask);
            this.groupBox34.Controls.Add(this.txt_Mdata);
            this.groupBox34.Controls.Add(this.label100);
            this.groupBox34.Controls.Add(this.txt_Mlen);
            this.groupBox34.Controls.Add(this.label101);
            this.groupBox34.Controls.Add(this.txt_Maddr);
            this.groupBox34.Controls.Add(this.label102);
            this.groupBox34.Controls.Add(this.RBM_USER);
            this.groupBox34.Controls.Add(this.RBM_TID);
            this.groupBox34.Controls.Add(this.RBM_EPC);
            this.groupBox34.Location = new System.Drawing.Point(8, 75);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(420, 94);
            this.groupBox34.TabIndex = 82;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Mask setting";
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Location = new System.Drawing.Point(323, 14);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(59, 17);
            this.checkBox_mask.TabIndex = 9;
            this.checkBox_mask.Text = "Enable";
            this.checkBox_mask.UseVisualStyleBackColor = true;
            // 
            // txt_Mdata
            // 
            this.txt_Mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mdata.Location = new System.Drawing.Point(94, 66);
            this.txt_Mdata.Name = "txt_Mdata";
            this.txt_Mdata.Size = new System.Drawing.Size(316, 20);
            this.txt_Mdata.TabIndex = 8;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(6, 73);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(58, 13);
            this.label100.TabIndex = 7;
            this.label100.Text = "Data(Hex):";
            // 
            // txt_Mlen
            // 
            this.txt_Mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mlen.Location = new System.Drawing.Point(348, 36);
            this.txt_Mlen.MaxLength = 2;
            this.txt_Mlen.Name = "txt_Mlen";
            this.txt_Mlen.Size = new System.Drawing.Size(62, 20);
            this.txt_Mlen.TabIndex = 6;
            this.txt_Mlen.Text = "00";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(247, 43);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(68, 13);
            this.label101.TabIndex = 5;
            this.label101.Text = "Length(Hex):";
            // 
            // txt_Maddr
            // 
            this.txt_Maddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Maddr.Location = new System.Drawing.Point(137, 36);
            this.txt_Maddr.MaxLength = 4;
            this.txt_Maddr.Name = "txt_Maddr";
            this.txt_Maddr.Size = new System.Drawing.Size(55, 20);
            this.txt_Maddr.TabIndex = 4;
            this.txt_Maddr.Text = "0000";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(6, 43);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(97, 13);
            this.label102.TabIndex = 3;
            this.label102.Text = "Start address(Hex):";
            // 
            // RBM_USER
            // 
            this.RBM_USER.AutoSize = true;
            this.RBM_USER.Location = new System.Drawing.Point(247, 15);
            this.RBM_USER.Name = "RBM_USER";
            this.RBM_USER.Size = new System.Drawing.Size(47, 17);
            this.RBM_USER.TabIndex = 2;
            this.RBM_USER.Text = "User";
            this.RBM_USER.UseVisualStyleBackColor = true;
            // 
            // RBM_TID
            // 
            this.RBM_TID.AutoSize = true;
            this.RBM_TID.Location = new System.Drawing.Point(136, 15);
            this.RBM_TID.Name = "RBM_TID";
            this.RBM_TID.Size = new System.Drawing.Size(43, 17);
            this.RBM_TID.TabIndex = 1;
            this.RBM_TID.Text = "TID";
            this.RBM_TID.UseVisualStyleBackColor = true;
            // 
            // RBM_EPC
            // 
            this.RBM_EPC.AutoSize = true;
            this.RBM_EPC.Checked = true;
            this.RBM_EPC.Location = new System.Drawing.Point(20, 15);
            this.RBM_EPC.Name = "RBM_EPC";
            this.RBM_EPC.Size = new System.Drawing.Size(46, 17);
            this.RBM_EPC.TabIndex = 0;
            this.RBM_EPC.TabStop = true;
            this.RBM_EPC.Text = "EPC";
            this.RBM_EPC.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.com_MS);
            this.groupBox33.Controls.Add(this.label99);
            this.groupBox33.Controls.Add(this.com_MQ);
            this.groupBox33.Controls.Add(this.label98);
            this.groupBox33.Location = new System.Drawing.Point(656, 7);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(394, 61);
            this.groupBox33.TabIndex = 81;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Mutiple query parameter";
            // 
            // com_MS
            // 
            this.com_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MS.FormattingEnabled = true;
            this.com_MS.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3",
            "AUTO"});
            this.com_MS.Location = new System.Drawing.Point(267, 25);
            this.com_MS.Name = "com_MS";
            this.com_MS.Size = new System.Drawing.Size(117, 21);
            this.com_MS.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(194, 28);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(50, 13);
            this.label99.TabIndex = 2;
            this.label99.Text = "Session：";
            // 
            // com_MQ
            // 
            this.com_MQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MQ.FormattingEnabled = true;
            this.com_MQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_MQ.Location = new System.Drawing.Point(47, 25);
            this.com_MQ.Name = "com_MQ";
            this.com_MQ.Size = new System.Drawing.Size(117, 21);
            this.com_MQ.TabIndex = 1;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(7, 28);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(21, 13);
            this.label98.TabIndex = 0;
            this.label98.Text = "Q：";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.com_MFliterTime);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Location = new System.Drawing.Point(436, 7);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(214, 61);
            this.groupBox32.TabIndex = 80;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Tag Filter";
            // 
            // com_MFliterTime
            // 
            this.com_MFliterTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MFliterTime.FormattingEnabled = true;
            this.com_MFliterTime.Location = new System.Drawing.Point(87, 25);
            this.com_MFliterTime.Name = "com_MFliterTime";
            this.com_MFliterTime.Size = new System.Drawing.Size(117, 21);
            this.com_MFliterTime.TabIndex = 1;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(7, 28);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(54, 13);
            this.label97.TabIndex = 0;
            this.label97.Text = "Filter time:";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.COM_MRPTime);
            this.groupBox28.Controls.Add(this.label96);
            this.groupBox28.Location = new System.Drawing.Point(214, 7);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(214, 61);
            this.groupBox28.TabIndex = 79;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Pulse interval";
            // 
            // COM_MRPTime
            // 
            this.COM_MRPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_MRPTime.FormattingEnabled = true;
            this.COM_MRPTime.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.COM_MRPTime.Location = new System.Drawing.Point(73, 25);
            this.COM_MRPTime.Name = "COM_MRPTime";
            this.COM_MRPTime.Size = new System.Drawing.Size(131, 21);
            this.COM_MRPTime.TabIndex = 1;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(7, 28);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(62, 13);
            this.label96.TabIndex = 0;
            this.label96.Text = "Pulse Time:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MRB_6B);
            this.groupBox3.Controls.Add(this.MRB_G2);
            this.groupBox3.Location = new System.Drawing.Point(8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Protocl";
            // 
            // MRB_6B
            // 
            this.MRB_6B.AutoSize = true;
            this.MRB_6B.Location = new System.Drawing.Point(106, 22);
            this.MRB_6B.Name = "MRB_6B";
            this.MRB_6B.Size = new System.Drawing.Size(71, 17);
            this.MRB_6B.TabIndex = 1;
            this.MRB_6B.Text = "18000-6B";
            this.MRB_6B.UseVisualStyleBackColor = true;
            // 
            // MRB_G2
            // 
            this.MRB_G2.AutoSize = true;
            this.MRB_G2.Checked = true;
            this.MRB_G2.Location = new System.Drawing.Point(10, 22);
            this.MRB_G2.Name = "MRB_G2";
            this.MRB_G2.Size = new System.Drawing.Size(76, 17);
            this.MRB_G2.TabIndex = 0;
            this.MRB_G2.TabStop = true;
            this.MRB_G2.Text = "EPCC1-G2";
            this.MRB_G2.UseVisualStyleBackColor = true;
            // 
            // Main_Page2
            // 
            this.Main_Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_Page2.Controls.Add(this.tabControl2);
            this.Main_Page2.Location = new System.Drawing.Point(4, 27);
            this.Main_Page2.Name = "Main_Page2";
            this.Main_Page2.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page2.Size = new System.Drawing.Size(1071, 621);
            this.Main_Page2.TabIndex = 1;
            this.Main_Page2.Text = "EPCC1-G2 Test";
            this.Main_Page2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_answer);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.ItemSize = new System.Drawing.Size(120, 23);
            this.tabControl2.Location = new System.Drawing.Point(-1, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1071, 612);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_answer
            // 
            this.tabPage_answer.Controls.Add(this.panel1);
            this.tabPage_answer.Location = new System.Drawing.Point(4, 27);
            this.tabPage_answer.Name = "tabPage_answer";
            this.tabPage_answer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_answer.Size = new System.Drawing.Size(1063, 581);
            this.tabPage_answer.TabIndex = 0;
            this.tabPage_answer.Text = "Registro";
            this.tabPage_answer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbp_MixRead);
            this.panel1.Controls.Add(this.lxLedControl5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lxLedControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.group_ant1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 574);
            this.panel1.TabIndex = 0;
            // 
            // gbp_MixRead
            // 
            this.gbp_MixRead.Controls.Add(this.text_readpsd);
            this.gbp_MixRead.Controls.Add(this.label118);
            this.gbp_MixRead.Controls.Add(this.text_readLen);
            this.gbp_MixRead.Controls.Add(this.label117);
            this.gbp_MixRead.Controls.Add(this.text_readadr);
            this.gbp_MixRead.Controls.Add(this.label115);
            this.gbp_MixRead.Controls.Add(this.com_MixMem);
            this.gbp_MixRead.Controls.Add(this.label114);
            this.gbp_MixRead.Enabled = false;
            this.gbp_MixRead.Location = new System.Drawing.Point(396, 1);
            this.gbp_MixRead.Name = "gbp_MixRead";
            this.gbp_MixRead.Size = new System.Drawing.Size(222, 77);
            this.gbp_MixRead.TabIndex = 29;
            this.gbp_MixRead.TabStop = false;
            this.gbp_MixRead.Text = "Mix";
            // 
            // text_readpsd
            // 
            this.text_readpsd.Location = new System.Drawing.Point(64, 46);
            this.text_readpsd.MaxLength = 8;
            this.text_readpsd.Name = "text_readpsd";
            this.text_readpsd.Size = new System.Drawing.Size(65, 20);
            this.text_readpsd.TabIndex = 7;
            this.text_readpsd.Text = "00000000";
            this.text_readpsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(6, 50);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(56, 13);
            this.label118.TabIndex = 6;
            this.label118.Text = "Password:";
            // 
            // text_readLen
            // 
            this.text_readLen.Location = new System.Drawing.Point(176, 48);
            this.text_readLen.MaxLength = 2;
            this.text_readLen.Name = "text_readLen";
            this.text_readLen.Size = new System.Drawing.Size(41, 20);
            this.text_readLen.TabIndex = 5;
            this.text_readLen.Text = "04";
            this.text_readLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(136, 52);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(28, 13);
            this.label117.TabIndex = 4;
            this.label117.Text = "Len:";
            // 
            // text_readadr
            // 
            this.text_readadr.Location = new System.Drawing.Point(176, 14);
            this.text_readadr.MaxLength = 4;
            this.text_readadr.Name = "text_readadr";
            this.text_readadr.Size = new System.Drawing.Size(41, 20);
            this.text_readadr.TabIndex = 3;
            this.text_readadr.Text = "0002";
            this.text_readadr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(136, 18);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(32, 13);
            this.label115.TabIndex = 2;
            this.label115.Text = "Addr:";
            // 
            // com_MixMem
            // 
            this.com_MixMem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MixMem.FormattingEnabled = true;
            this.com_MixMem.Items.AddRange(new object[] {
            "Password",
            "EPC",
            "TID",
            "User"});
            this.com_MixMem.Location = new System.Drawing.Point(64, 13);
            this.com_MixMem.Name = "com_MixMem";
            this.com_MixMem.Size = new System.Drawing.Size(66, 21);
            this.com_MixMem.TabIndex = 1;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(5, 17);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(33, 13);
            this.label114.TabIndex = 0;
            this.label114.Text = "Mem:";
            // 
            // lxLedControl5
            // 
            this.lxLedControl5.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl5.BevelRate = 0.5F;
            this.lxLedControl5.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl5.BorderWidth = 3;
            this.lxLedControl5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl5.HighlightOpaque = ((byte)(50));
            this.lxLedControl5.Location = new System.Drawing.Point(712, 247);
            this.lxLedControl5.Name = "lxLedControl5";
            this.lxLedControl5.RoundCorner = true;
            this.lxLedControl5.ShowHighlight = true;
            this.lxLedControl5.Size = new System.Drawing.Size(154, 43);
            this.lxLedControl5.TabIndex = 28;
            this.lxLedControl5.Text = "0";
            this.lxLedControl5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl5.TotalCharCount = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(710, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total-cmd-time(ms):";
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl1.BevelRate = 0.5F;
            this.lxLedControl1.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl1.BorderWidth = 3;
            this.lxLedControl1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(712, 119);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.RoundCorner = true;
            this.lxLedControl1.ShowHighlight = true;
            this.lxLedControl1.Size = new System.Drawing.Size(328, 92);
            this.lxLedControl1.TabIndex = 20;
            this.lxLedControl1.Text = "0";
            this.lxLedControl1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl1.TotalCharCount = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "EPC Number:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(4, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 482);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tag list(No Repeat)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_rate);
            this.groupBox4.Controls.Add(this.label80);
            this.groupBox4.Controls.Add(this.text_target);
            this.groupBox4.Controls.Add(this.check_num);
            this.groupBox4.Controls.Add(this.com_Target);
            this.groupBox4.Controls.Add(this.label79);
            this.groupBox4.Controls.Add(this.com_scantime);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.com_S);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.com_Q);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Location = new System.Drawing.Point(624, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 77);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // checkBox_rate
            // 
            this.checkBox_rate.AutoSize = true;
            this.checkBox_rate.Location = new System.Drawing.Point(317, 50);
            this.checkBox_rate.Name = "checkBox_rate";
            this.checkBox_rate.Size = new System.Drawing.Size(92, 17);
            this.checkBox_rate.TabIndex = 37;
            this.checkBox_rate.Text = "Return Speed";
            this.checkBox_rate.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(102, 52);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(168, 13);
            this.label80.TabIndex = 36;
            this.label80.Text = "times no tag.then A/B conversion ";
            // 
            // text_target
            // 
            this.text_target.ForeColor = System.Drawing.Color.Red;
            this.text_target.Location = new System.Drawing.Point(55, 46);
            this.text_target.MaxLength = 2;
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(43, 20);
            this.text_target.TabIndex = 35;
            this.text_target.Text = "5";
            this.text_target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // check_num
            // 
            this.check_num.AutoSize = true;
            this.check_num.Checked = true;
            this.check_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_num.Location = new System.Drawing.Point(7, 50);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(52, 17);
            this.check_num.TabIndex = 34;
            this.check_num.Text = "Read";
            this.check_num.UseVisualStyleBackColor = true;
            // 
            // com_Target
            // 
            this.com_Target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Target.FormattingEnabled = true;
            this.com_Target.Items.AddRange(new object[] {
            "A",
            "B"});
            this.com_Target.Location = new System.Drawing.Point(384, 15);
            this.com_Target.Name = "com_Target";
            this.com_Target.Size = new System.Drawing.Size(51, 21);
            this.com_Target.TabIndex = 33;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(339, 20);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(41, 13);
            this.label79.TabIndex = 32;
            this.label79.Text = "Target:";
            // 
            // com_scantime
            // 
            this.com_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_scantime.FormattingEnabled = true;
            this.com_scantime.Location = new System.Drawing.Point(258, 15);
            this.com_scantime.Name = "com_scantime";
            this.com_scantime.Size = new System.Drawing.Size(77, 21);
            this.com_scantime.TabIndex = 31;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(191, 20);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 30;
            this.label39.Text = "ScanTime:";
            // 
            // com_S
            // 
            this.com_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_S.FormattingEnabled = true;
            this.com_S.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "AUTO"});
            this.com_S.Location = new System.Drawing.Point(125, 21);
            this.com_S.Name = "com_S";
            this.com_S.Size = new System.Drawing.Size(59, 21);
            this.com_S.TabIndex = 29;
            this.com_S.SelectedIndexChanged += new System.EventHandler(this.com_S_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(71, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 13);
            this.label32.TabIndex = 28;
            this.label32.Text = "Session：";
            // 
            // com_Q
            // 
            this.com_Q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Q.FormattingEnabled = true;
            this.com_Q.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_Q.Location = new System.Drawing.Point(18, 15);
            this.com_Q.Name = "com_Q";
            this.com_Q.Size = new System.Drawing.Size(51, 21);
            this.com_Q.TabIndex = 27;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(18, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = "Q:";
            // 
            // group_ant1
            // 
            this.group_ant1.Controls.Add(this.check_ant4);
            this.group_ant1.Controls.Add(this.check_ant3);
            this.group_ant1.Controls.Add(this.check_ant2);
            this.group_ant1.Controls.Add(this.check_ant1);
            this.group_ant1.Location = new System.Drawing.Point(262, 1);
            this.group_ant1.Name = "group_ant1";
            this.group_ant1.Size = new System.Drawing.Size(135, 77);
            this.group_ant1.TabIndex = 16;
            this.group_ant1.TabStop = false;
            // 
            // check_ant4
            // 
            this.check_ant4.AutoSize = true;
            this.check_ant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant4.Location = new System.Drawing.Point(80, 47);
            this.check_ant4.Name = "check_ant4";
            this.check_ant4.Size = new System.Drawing.Size(54, 17);
            this.check_ant4.TabIndex = 37;
            this.check_ant4.Text = "ANT4";
            this.check_ant4.UseVisualStyleBackColor = true;
            // 
            // check_ant3
            // 
            this.check_ant3.AutoSize = true;
            this.check_ant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant3.Location = new System.Drawing.Point(20, 47);
            this.check_ant3.Name = "check_ant3";
            this.check_ant3.Size = new System.Drawing.Size(54, 17);
            this.check_ant3.TabIndex = 36;
            this.check_ant3.Text = "ANT3";
            this.check_ant3.UseVisualStyleBackColor = true;
            // 
            // check_ant2
            // 
            this.check_ant2.AutoSize = true;
            this.check_ant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant2.Location = new System.Drawing.Point(80, 17);
            this.check_ant2.Name = "check_ant2";
            this.check_ant2.Size = new System.Drawing.Size(54, 17);
            this.check_ant2.TabIndex = 35;
            this.check_ant2.Text = "ANT2";
            this.check_ant2.UseVisualStyleBackColor = true;
            // 
            // check_ant1
            // 
            this.check_ant1.AutoSize = true;
            this.check_ant1.Checked = true;
            this.check_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant1.Location = new System.Drawing.Point(20, 17);
            this.check_ant1.Name = "check_ant1";
            this.check_ant1.Size = new System.Drawing.Size(54, 17);
            this.check_ant1.TabIndex = 34;
            this.check_ant1.Text = "ANT1";
            this.check_ant1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_fastid);
            this.groupBox2.Controls.Add(this.rb_mix);
            this.groupBox2.Controls.Add(this.rb_tid);
            this.groupBox2.Controls.Add(this.rb_epc);
            this.groupBox2.Controls.Add(this.btIventoryG2);
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 77);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // rb_fastid
            // 
            this.rb_fastid.AutoSize = true;
            this.rb_fastid.Location = new System.Drawing.Point(123, 47);
            this.rb_fastid.Name = "rb_fastid";
            this.rb_fastid.Size = new System.Drawing.Size(56, 17);
            this.rb_fastid.TabIndex = 4;
            this.rb_fastid.Text = "FastID";
            this.rb_fastid.UseVisualStyleBackColor = true;
            this.rb_fastid.CheckedChanged += new System.EventHandler(this.rb_fastid_CheckedChanged);
            // 
            // rb_mix
            // 
            this.rb_mix.AutoSize = true;
            this.rb_mix.Location = new System.Drawing.Point(207, 47);
            this.rb_mix.Name = "rb_mix";
            this.rb_mix.Size = new System.Drawing.Size(44, 17);
            this.rb_mix.TabIndex = 3;
            this.rb_mix.Text = "MIX";
            this.rb_mix.UseVisualStyleBackColor = true;
            this.rb_mix.CheckedChanged += new System.EventHandler(this.rb_mix_CheckedChanged);
            this.rb_mix.Click += new System.EventHandler(this.rb_mix_Click);
            // 
            // rb_tid
            // 
            this.rb_tid.AutoSize = true;
            this.rb_tid.Location = new System.Drawing.Point(207, 21);
            this.rb_tid.Name = "rb_tid";
            this.rb_tid.Size = new System.Drawing.Size(43, 17);
            this.rb_tid.TabIndex = 2;
            this.rb_tid.Text = "TID";
            this.rb_tid.UseVisualStyleBackColor = true;
            this.rb_tid.CheckedChanged += new System.EventHandler(this.rb_tid_CheckedChanged);
            // 
            // rb_epc
            // 
            this.rb_epc.AutoSize = true;
            this.rb_epc.Checked = true;
            this.rb_epc.Location = new System.Drawing.Point(123, 22);
            this.rb_epc.Name = "rb_epc";
            this.rb_epc.Size = new System.Drawing.Size(46, 17);
            this.rb_epc.TabIndex = 1;
            this.rb_epc.TabStop = true;
            this.rb_epc.Text = "EPC";
            this.rb_epc.UseVisualStyleBackColor = true;
            this.rb_epc.CheckedChanged += new System.EventHandler(this.rb_epc_CheckedChanged);
            // 
            // btIventoryG2
            // 
            this.btIventoryG2.BackColor = System.Drawing.Color.Transparent;
            this.btIventoryG2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btIventoryG2.ForeColor = System.Drawing.Color.DarkBlue;
            this.btIventoryG2.Location = new System.Drawing.Point(6, 22);
            this.btIventoryG2.Name = "btIventoryG2";
            this.btIventoryG2.Size = new System.Drawing.Size(109, 43);
            this.btIventoryG2.TabIndex = 0;
            this.btIventoryG2.Text = "Start";
            this.btIventoryG2.UseVisualStyleBackColor = false;
            this.btIventoryG2.Click += new System.EventHandler(this.btIventoryG2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1063, 581);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Carrera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dataGridView2);
            this.groupBox10.Location = new System.Drawing.Point(11, 83);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(678, 482);
            this.groupBox10.TabIndex = 32;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tag list(No Repeat)";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(664, 456);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox5);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.textBox5);
            this.groupBox9.Controls.Add(this.checkBox6);
            this.groupBox9.Controls.Add(this.comboBox2);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.comboBox3);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.comboBox4);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.comboBox5);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Location = new System.Drawing.Point(621, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(437, 77);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(317, 50);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(92, 17);
            this.checkBox5.TabIndex = 37;
            this.checkBox5.Text = "Return Speed";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(102, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "times no tag.then A/B conversion ";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Red;
            this.textBox5.Location = new System.Drawing.Point(55, 46);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 35;
            this.textBox5.Text = "5";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(7, 50);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(52, 17);
            this.checkBox6.TabIndex = 34;
            this.checkBox6.Text = "Read";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B"});
            this.comboBox2.Location = new System.Drawing.Point(384, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(339, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Target:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(258, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(77, 21);
            this.comboBox3.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(191, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "ScanTime:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "AUTO"});
            this.comboBox4.Location = new System.Drawing.Point(125, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(59, 21);
            this.comboBox4.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(71, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Session：";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox5.Location = new System.Drawing.Point(18, 15);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(51, 21);
            this.comboBox5.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Q:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox2);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.textBox3);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.comboBox1);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Enabled = false;
            this.groupBox8.Location = new System.Drawing.Point(398, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(222, 77);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mix";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 46);
            this.textBox2.MaxLength = 8;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "00000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 48);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "04";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Len:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 14);
            this.textBox4.MaxLength = 4;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0002";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(136, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Addr:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "EPC",
            "TID",
            "User"});
            this.comboBox1.Location = new System.Drawing.Point(64, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mem:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.checkBox3);
            this.groupBox7.Controls.Add(this.checkBox4);
            this.groupBox7.Location = new System.Drawing.Point(262, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(135, 77);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox1.Location = new System.Drawing.Point(80, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "ANT4";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox2.Location = new System.Drawing.Point(20, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.Text = "ANT3";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox3.Location = new System.Drawing.Point(80, 17);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 17);
            this.checkBox3.TabIndex = 35;
            this.checkBox3.Text = "ANT2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox4.Location = new System.Drawing.Point(20, 17);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 17);
            this.checkBox4.TabIndex = 34;
            this.checkBox4.Text = "ANT1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(5, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(257, 77);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "FastID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(207, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "MIX";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(207, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "TID";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(123, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "EPC";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Main_Page3
            // 
            this.Main_Page3.Controls.Add(this.panel5);
            this.Main_Page3.Location = new System.Drawing.Point(4, 27);
            this.Main_Page3.Name = "Main_Page3";
            this.Main_Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Main_Page3.Size = new System.Drawing.Size(1071, 621);
            this.Main_Page3.TabIndex = 2;
            this.Main_Page3.Text = "18000-6B Test";
            this.Main_Page3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox23);
            this.panel5.Controls.Add(this.groupBox22);
            this.panel5.Controls.Add(this.text_6BUID);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.ListView_ID_6B);
            this.panel5.Controls.Add(this.groupBox19);
            this.panel5.Location = new System.Drawing.Point(-1, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1069, 616);
            this.panel5.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.text_Statu6B);
            this.groupBox23.Controls.Add(this.btCheckLock6B);
            this.groupBox23.Controls.Add(this.btLock6B);
            this.groupBox23.Controls.Add(this.text_checkaddr);
            this.groupBox23.Controls.Add(this.label52);
            this.groupBox23.Controls.Add(this.text_lock6b);
            this.groupBox23.Controls.Add(this.label51);
            this.groupBox23.Location = new System.Drawing.Point(561, 465);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(495, 119);
            this.groupBox23.TabIndex = 21;
            this.groupBox23.TabStop = false;
            // 
            // text_Statu6B
            // 
            this.text_Statu6B.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_Statu6B.ForeColor = System.Drawing.Color.Red;
            this.text_Statu6B.Location = new System.Drawing.Point(252, 81);
            this.text_Statu6B.MaxLength = 2;
            this.text_Statu6B.Name = "text_Statu6B";
            this.text_Statu6B.ReadOnly = true;
            this.text_Statu6B.Size = new System.Drawing.Size(111, 20);
            this.text_Statu6B.TabIndex = 19;
            // 
            // btCheckLock6B
            // 
            this.btCheckLock6B.Location = new System.Drawing.Point(383, 72);
            this.btCheckLock6B.Name = "btCheckLock6B";
            this.btCheckLock6B.Size = new System.Drawing.Size(100, 33);
            this.btCheckLock6B.TabIndex = 18;
            this.btCheckLock6B.Text = "Check lock";
            this.btCheckLock6B.UseVisualStyleBackColor = true;
            this.btCheckLock6B.Click += new System.EventHandler(this.btCheckLock6B_Click);
            // 
            // btLock6B
            // 
            this.btLock6B.Location = new System.Drawing.Point(383, 22);
            this.btLock6B.Name = "btLock6B";
            this.btLock6B.Size = new System.Drawing.Size(100, 33);
            this.btLock6B.TabIndex = 17;
            this.btLock6B.Text = "Lock";
            this.btLock6B.UseVisualStyleBackColor = true;
            this.btLock6B.Click += new System.EventHandler(this.btLock6B_Click);
            // 
            // text_checkaddr
            // 
            this.text_checkaddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_checkaddr.Location = new System.Drawing.Point(202, 81);
            this.text_checkaddr.MaxLength = 2;
            this.text_checkaddr.Name = "text_checkaddr";
            this.text_checkaddr.Size = new System.Drawing.Size(44, 20);
            this.text_checkaddr.TabIndex = 16;
            this.text_checkaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(47, 85);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(129, 13);
            this.label52.TabIndex = 15;
            this.label52.Text = "Check lock address(Hex):";
            // 
            // text_lock6b
            // 
            this.text_lock6b.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_lock6b.Location = new System.Drawing.Point(202, 31);
            this.text_lock6b.MaxLength = 2;
            this.text_lock6b.Name = "text_lock6b";
            this.text_lock6b.Size = new System.Drawing.Size(44, 20);
            this.text_lock6b.TabIndex = 14;
            this.text_lock6b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(71, 35);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(99, 13);
            this.label51.TabIndex = 0;
            this.label51.Text = "Lock address(Hex):";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.text_W6B);
            this.groupBox22.Controls.Add(this.label48);
            this.groupBox22.Controls.Add(this.btWrite6B);
            this.groupBox22.Controls.Add(this.text_W6BLen);
            this.groupBox22.Controls.Add(this.label49);
            this.groupBox22.Controls.Add(this.text_W6BAddr);
            this.groupBox22.Controls.Add(this.label50);
            this.groupBox22.Controls.Add(this.text_R6B);
            this.groupBox22.Controls.Add(this.label36);
            this.groupBox22.Controls.Add(this.btRead6B);
            this.groupBox22.Controls.Add(this.text_R6BLen);
            this.groupBox22.Controls.Add(this.label35);
            this.groupBox22.Controls.Add(this.text_R6BAddr);
            this.groupBox22.Controls.Add(this.label30);
            this.groupBox22.Location = new System.Drawing.Point(563, 76);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(495, 389);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Read/Write Data";
            // 
            // text_W6B
            // 
            this.text_W6B.Location = new System.Drawing.Point(122, 254);
            this.text_W6B.Multiline = true;
            this.text_W6B.Name = "text_W6B";
            this.text_W6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_W6B.Size = new System.Drawing.Size(359, 128);
            this.text_W6B.TabIndex = 18;
            this.text_W6B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(18, 254);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(93, 13);
            this.label48.TabIndex = 17;
            this.label48.Text = "Write data(Hex):   ";
            // 
            // btWrite6B
            // 
            this.btWrite6B.Location = new System.Drawing.Point(381, 210);
            this.btWrite6B.Name = "btWrite6B";
            this.btWrite6B.Size = new System.Drawing.Size(100, 33);
            this.btWrite6B.TabIndex = 16;
            this.btWrite6B.Text = "Write";
            this.btWrite6B.UseVisualStyleBackColor = true;
            this.btWrite6B.Click += new System.EventHandler(this.btWrite6B_Click);
            // 
            // text_W6BLen
            // 
            this.text_W6BLen.Location = new System.Drawing.Point(294, 216);
            this.text_W6BLen.MaxLength = 2;
            this.text_W6BLen.Name = "text_W6BLen";
            this.text_W6BLen.Size = new System.Drawing.Size(44, 20);
            this.text_W6BLen.TabIndex = 15;
            this.text_W6BLen.TextChanged += new System.EventHandler(this.text_W6BLen_TextChanged);
            this.text_W6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(187, 220);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(92, 13);
            this.label49.TabIndex = 14;
            this.label49.Text = "Write length(Hex):";
            // 
            // text_W6BAddr
            // 
            this.text_W6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_W6BAddr.Location = new System.Drawing.Point(133, 217);
            this.text_W6BAddr.MaxLength = 2;
            this.text_W6BAddr.Name = "text_W6BAddr";
            this.text_W6BAddr.Size = new System.Drawing.Size(44, 20);
            this.text_W6BAddr.TabIndex = 13;
            this.text_W6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(18, 220);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(106, 13);
            this.label50.TabIndex = 12;
            this.label50.Text = "Start address(Hex):   ";
            // 
            // text_R6B
            // 
            this.text_R6B.Location = new System.Drawing.Point(122, 67);
            this.text_R6B.Multiline = true;
            this.text_R6B.Name = "text_R6B";
            this.text_R6B.ReadOnly = true;
            this.text_R6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_R6B.Size = new System.Drawing.Size(359, 128);
            this.text_R6B.TabIndex = 11;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(18, 67);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(94, 13);
            this.label36.TabIndex = 10;
            this.label36.Text = "Read data(Hex):   ";
            // 
            // btRead6B
            // 
            this.btRead6B.Location = new System.Drawing.Point(381, 22);
            this.btRead6B.Name = "btRead6B";
            this.btRead6B.Size = new System.Drawing.Size(100, 33);
            this.btRead6B.TabIndex = 9;
            this.btRead6B.Text = "read";
            this.btRead6B.UseVisualStyleBackColor = true;
            this.btRead6B.Click += new System.EventHandler(this.btRead6B_Click);
            // 
            // text_R6BLen
            // 
            this.text_R6BLen.Location = new System.Drawing.Point(294, 27);
            this.text_R6BLen.MaxLength = 2;
            this.text_R6BLen.Name = "text_R6BLen";
            this.text_R6BLen.Size = new System.Drawing.Size(44, 20);
            this.text_R6BLen.TabIndex = 8;
            this.text_R6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(193, 31);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 13);
            this.label35.TabIndex = 7;
            this.label35.Text = "Read length(Hex):";
            // 
            // text_R6BAddr
            // 
            this.text_R6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_R6BAddr.Location = new System.Drawing.Point(133, 27);
            this.text_R6BAddr.MaxLength = 2;
            this.text_R6BAddr.Name = "text_R6BAddr";
            this.text_R6BAddr.Size = new System.Drawing.Size(44, 20);
            this.text_R6BAddr.TabIndex = 6;
            this.text_R6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 31);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 13);
            this.label30.TabIndex = 5;
            this.label30.Text = "Start address(Hex):   ";
            // 
            // text_6BUID
            // 
            this.text_6BUID.Location = new System.Drawing.Point(696, 42);
            this.text_6BUID.Name = "text_6BUID";
            this.text_6BUID.ReadOnly = true;
            this.text_6BUID.Size = new System.Drawing.Size(214, 20);
            this.text_6BUID.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(559, 48);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "Current Selected UID:";
            // 
            // ListView_ID_6B
            // 
            this.ListView_ID_6B.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ID_6B.AllowDrop = true;
            this.ListView_ID_6B.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_ID_6B.FullRowSelect = true;
            this.ListView_ID_6B.GridLines = true;
            this.ListView_ID_6B.HideSelection = false;
            this.ListView_ID_6B.HotTracking = true;
            this.ListView_ID_6B.HoverSelection = true;
            this.ListView_ID_6B.Location = new System.Drawing.Point(10, 89);
            this.ListView_ID_6B.Name = "ListView_ID_6B";
            this.ListView_ID_6B.Size = new System.Drawing.Size(524, 522);
            this.ListView_ID_6B.TabIndex = 17;
            this.ListView_ID_6B.UseCompatibleStateImageBehavior = false;
            this.ListView_ID_6B.View = System.Windows.Forms.View.Details;
            this.ListView_ID_6B.DoubleClick += new System.EventHandler(this.ListView_ID_6B_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ant(4,3,2,1)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rb_mutiple);
            this.groupBox19.Controls.Add(this.rb_single);
            this.groupBox19.Controls.Add(this.btInventory6B);
            this.groupBox19.Location = new System.Drawing.Point(10, 5);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(524, 77);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            // 
            // rb_mutiple
            // 
            this.rb_mutiple.AutoSize = true;
            this.rb_mutiple.Location = new System.Drawing.Point(377, 38);
            this.rb_mutiple.Name = "rb_mutiple";
            this.rb_mutiple.Size = new System.Drawing.Size(59, 17);
            this.rb_mutiple.TabIndex = 2;
            this.rb_mutiple.Text = "Mutiple";
            this.rb_mutiple.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(246, 38);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(54, 17);
            this.rb_single.TabIndex = 1;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // btInventory6B
            // 
            this.btInventory6B.BackColor = System.Drawing.Color.Transparent;
            this.btInventory6B.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventory6B.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventory6B.Location = new System.Drawing.Point(18, 22);
            this.btInventory6B.Name = "btInventory6B";
            this.btInventory6B.Size = new System.Drawing.Size(171, 43);
            this.btInventory6B.TabIndex = 0;
            this.btInventory6B.Text = "Start";
            this.btInventory6B.UseVisualStyleBackColor = false;
            this.btInventory6B.Click += new System.EventHandler(this.btInventory6B_Click);
            // 
            // btFlashCl
            // 
            this.btFlashCl.Location = new System.Drawing.Point(939, 653);
            this.btFlashCl.Name = "btFlashCl";
            this.btFlashCl.Size = new System.Drawing.Size(100, 25);
            this.btFlashCl.TabIndex = 5;
            this.btFlashCl.Text = "Refresh";
            this.btFlashCl.UseVisualStyleBackColor = true;
            this.btFlashCl.Click += new System.EventHandler(this.btFlashCl_Click);
            // 
            // timer_answer
            // 
            this.timer_answer.Interval = 50;
            this.timer_answer.Tick += new System.EventHandler(this.timer_answer_Tick);
            // 
            // timer_runmode
            // 
            this.timer_runmode.Interval = 50;
            this.timer_runmode.Tick += new System.EventHandler(this.timer_runmode_Tick);
            // 
            // Timer_Test_6B
            // 
            this.Timer_Test_6B.Tick += new System.EventHandler(this.Timer_Test_6B_Tick);
            // 
            // timer_Buff
            // 
            this.timer_Buff.Interval = 50;
            // 
            // timer_RealTime
            // 
            this.timer_RealTime.Interval = 50;
            this.timer_RealTime.Tick += new System.EventHandler(this.timer_RealTime_Tick);
            // 
            // ckClearOperationRec
            // 
            this.ckClearOperationRec.AutoSize = true;
            this.ckClearOperationRec.Checked = true;
            this.ckClearOperationRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckClearOperationRec.Location = new System.Drawing.Point(134, 659);
            this.ckClearOperationRec.Name = "ckClearOperationRec";
            this.ckClearOperationRec.Size = new System.Drawing.Size(75, 17);
            this.ckClearOperationRec.TabIndex = 18;
            this.ckClearOperationRec.Text = "Auto-Clear";
            this.ckClearOperationRec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 749);
            this.Controls.Add(this.ckClearOperationRec);
            this.Controls.Add(this.btFlashCl);
            this.Controls.Add(this.Maintab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrtxtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UHFReader288 Demo V2.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Maintab.ResumeLayout(false);
            this.Main_Page1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Basic.ResumeLayout(false);
            this.gbReturnLoss.ResumeLayout(false);
            this.gbReturnLoss.PerformLayout();
            this.gbCmdTemperature.ResumeLayout(false);
            this.gbCmdTemperature.PerformLayout();
            this.gbp_DRM.ResumeLayout(false);
            this.gbp_DRM.PerformLayout();
            this.gbp_Retry.ResumeLayout(false);
            this.gbp_wpower.ResumeLayout(false);
            this.gbp_wpower.PerformLayout();
            this.group_maxtime.ResumeLayout(false);
            this.gbp_buff.ResumeLayout(false);
            this.gbp_buff.PerformLayout();
            this.gpb_clock.ResumeLayout(false);
            this.gpb_clock.PerformLayout();
            this.gpb_antconfig.ResumeLayout(false);
            this.gpb_antconfig.PerformLayout();
            this.gpb_checkant.ResumeLayout(false);
            this.gpb_checkant.PerformLayout();
            this.gpb_GPIO.ResumeLayout(false);
            this.gpb_GPIO.PerformLayout();
            this.gpb_OutputRep.ResumeLayout(false);
            this.gpb_OutputRep.PerformLayout();
            this.gpb_Relay.ResumeLayout(false);
            this.gpb_Relay.PerformLayout();
            this.gpb_baud.ResumeLayout(false);
            this.gpb_DBM.ResumeLayout(false);
            this.gpb_DBM.PerformLayout();
            this.gpb_Freq.ResumeLayout(false);
            this.gpb_Freq.PerformLayout();
            this.gpb_beep.ResumeLayout(false);
            this.gpb_beep.PerformLayout();
            this.gpb_RDVersion.ResumeLayout(false);
            this.gpb_RDVersion.PerformLayout();
            this.gpb_MDVersion.ResumeLayout(false);
            this.gpb_MDVersion.PerformLayout();
            this.gpb_Serial.ResumeLayout(false);
            this.gpb_Serial.PerformLayout();
            this.gpb_address.ResumeLayout(false);
            this.gpb_address.PerformLayout();
            this.gpb_tcp.ResumeLayout(false);
            this.gpb_tcp.PerformLayout();
            this.gpb_rs232.ResumeLayout(false);
            this.gpb_rs232.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Mx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbp_trigger.ResumeLayout(false);
            this.gbp_trigger.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.gbp_tagType.ResumeLayout(false);
            this.gbp_tagType.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.gbp_Response.ResumeLayout(false);
            this.gbp_Response.PerformLayout();
            this.gbp_mask.ResumeLayout(false);
            this.gbp_mask.PerformLayout();
            this.gbp_EASAcc.ResumeLayout(false);
            this.gbp_EASAcc.PerformLayout();
            this.tabPage_Module.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Main_Page2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_answer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbp_MixRead.ResumeLayout(false);
            this.gbp_MixRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.group_ant1.ResumeLayout(false);
            this.group_ant1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Main_Page3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Maintab;
        private System.Windows.Forms.TabPage Main_Page1;
        private System.Windows.Forms.TabPage Main_Page2;
        private System.Windows.Forms.TabPage Main_Page3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Basic;
        private System.Windows.Forms.GroupBox gpb_rs232;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tcp;
        private System.Windows.Forms.RadioButton rb_rs232;
        private System.Windows.Forms.TabPage tabPage_Mx;
        private System.Windows.Forms.Button btDisConnect232;
        private System.Windows.Forms.Button btConnect232;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_tcp;
        private System.Windows.Forms.Button btDisConnectTcp;
        private System.Windows.Forms.Button btConnectTcp;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Port;
        private CustomControl.IpAddressTextBox ipServerIP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_answer;
        private System.Windows.Forms.Button btFlashCl;
        private System.Windows.Forms.Timer timer_answer;
        private System.Windows.Forms.Panel panel1;
        private LxControl.LxLedControl lxLedControl5;
        private System.Windows.Forms.Label label9;
        private LxControl.LxLedControl lxLedControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox com_scantime;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox com_S;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox com_Q;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox group_ant1;
        public System.Windows.Forms.CheckBox check_ant4;
        public System.Windows.Forms.CheckBox check_ant3;
        public System.Windows.Forms.CheckBox check_ant2;
        public System.Windows.Forms.CheckBox check_ant1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tid;
        private System.Windows.Forms.RadioButton rb_epc;
        private System.Windows.Forms.Button btIventoryG2;
        private System.Windows.Forms.GroupBox gpb_address;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Button btaddress;
        private System.Windows.Forms.GroupBox gpb_MDVersion;
        private System.Windows.Forms.TextBox text_MDVersion;
        private System.Windows.Forms.Button btMDVersion;
        private System.Windows.Forms.GroupBox gpb_Serial;
        private System.Windows.Forms.TextBox text_Serial;
        private System.Windows.Forms.Button btSerial;
        private System.Windows.Forms.GroupBox gpb_beep;
        private System.Windows.Forms.GroupBox gpb_RDVersion;
        private System.Windows.Forms.TextBox text_RDVersion;
        private System.Windows.Forms.RadioButton Radio_beepDis;
        private System.Windows.Forms.RadioButton Radio_beepEn;
        private System.Windows.Forms.Button Button_Beep;
        private System.Windows.Forms.GroupBox gpb_Freq;
        private System.Windows.Forms.RadioButton radioButton_band4;
        private System.Windows.Forms.RadioButton radioButton_band3;
        private System.Windows.Forms.RadioButton radioButton_band2;
        private System.Windows.Forms.RadioButton radioButton_band1;
        private System.Windows.Forms.Button btFreq;
        private System.Windows.Forms.ComboBox ComboBox_dmaxfre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboBox_dminfre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckBox_SameFre;
        private System.Windows.Forms.GroupBox gpb_DBM;
        private System.Windows.Forms.Button BT_DBM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBox_PowerDbm;
        private System.Windows.Forms.GroupBox gpb_baud;
        private System.Windows.Forms.Button btBaudRate;
        private System.Windows.Forms.ComboBox ComboBox_baud;
        private System.Windows.Forms.GroupBox gpb_Relay;
        private System.Windows.Forms.Button btRelay;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox ComboBox_RelayTime;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox gpb_OutputRep;
        private System.Windows.Forms.Button btOutputRep;
        private System.Windows.Forms.CheckBox check_OutputRep4;
        private System.Windows.Forms.CheckBox check_OutputRep3;
        private System.Windows.Forms.CheckBox check_OutputRep2;
        private System.Windows.Forms.CheckBox check_OutputRep1;
        private System.Windows.Forms.GroupBox gpb_antconfig;
        private System.Windows.Forms.Button Button_Ant;
        private System.Windows.Forms.CheckBox checkant4;
        private System.Windows.Forms.CheckBox checkant3;
        private System.Windows.Forms.CheckBox checkant2;
        private System.Windows.Forms.CheckBox checkant1;
        private System.Windows.Forms.GroupBox gpb_checkant;
        private System.Windows.Forms.Button btSetcheckant;
        private System.Windows.Forms.RadioButton rb_Closecheckant;
        private System.Windows.Forms.RadioButton rb_Opencheckant;
        private System.Windows.Forms.GroupBox gpb_GPIO;
        private System.Windows.Forms.Button Button_GetGPIO;
        private System.Windows.Forms.Button Button_SetGPIO;
        private System.Windows.Forms.CheckBox check_int4;
        private System.Windows.Forms.CheckBox check_int3;
        private System.Windows.Forms.CheckBox check_int2;
        private System.Windows.Forms.CheckBox check_int1;
        private System.Windows.Forms.CheckBox check_out4;
        private System.Windows.Forms.CheckBox check_out3;
        private System.Windows.Forms.CheckBox check_out2;
        private System.Windows.Forms.CheckBox check_out1;
        internal System.Windows.Forms.GroupBox gpb_clock;
        internal System.Windows.Forms.Button ClockCMD;
        internal System.Windows.Forms.RadioButton GetClock;
        internal System.Windows.Forms.RadioButton SetClock;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label40;
        internal System.Windows.Forms.Label label41;
        internal System.Windows.Forms.Label label42;
        internal System.Windows.Forms.Label label45;
        internal System.Windows.Forms.Label label46;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox Text_sec;
        internal System.Windows.Forms.TextBox Text_min;
        internal System.Windows.Forms.TextBox Text_hour;
        internal System.Windows.Forms.TextBox Text_day;
        internal System.Windows.Forms.TextBox Text_month;
        internal System.Windows.Forms.TextBox Text_year;
        private System.Windows.Forms.Button btGetInformation;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btFlashROM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbp_trigger;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button bttrigger;
        private System.Windows.Forms.ComboBox comboBox_trigger;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox43;
        private System.Windows.Forms.Button btGetQS;
        private System.Windows.Forms.Button btSetQS;
        private System.Windows.Forms.ComboBox com_acS;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox com_acQ;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox44;
        private System.Windows.Forms.TextBox text_tidlen;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox text_tidaddr;
        private System.Windows.Forms.Button btTIDpara;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btGetWorkmodepara;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button btworkmode;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Button btInterval;
        private System.Windows.Forms.ComboBox comboBox_intervalT;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.GroupBox gbp_tagType;
        private System.Windows.Forms.RadioButton rb_G2TID;
        private System.Windows.Forms.Button bt_typeTag;
        private System.Windows.Forms.RadioButton rb_EAS;
        private System.Windows.Forms.RadioButton rb_G2;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.RadioButton rb_180006B;
        private System.Windows.Forms.RadioButton rb_180006c;
        private System.Windows.Forms.GroupBox gbp_Response;
        private System.Windows.Forms.Button btResponse;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox comboBox_RespTime;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBox_Resp;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox gbp_mask;
        private System.Windows.Forms.Button btMaskSet;
        private System.Windows.Forms.TextBox text_mdata;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox text_mlen;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox text_madds;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.RadioButton rb_MaskUser;
        private System.Windows.Forms.RadioButton rb_MaskTID;
        private System.Windows.Forms.RadioButton rb_MaskEPC;
        private System.Windows.Forms.GroupBox gbp_EASAcc;
        private System.Windows.Forms.Button btAccuracy;
        private System.Windows.Forms.ComboBox ComboBox_Accuracy;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbEASAcc;
        private System.Windows.Forms.Timer timer_runmode;
        private System.Windows.Forms.Timer timer_EAS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ListView_ID_6B;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rb_mutiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Button btInventory6B;
        private System.Windows.Forms.Timer Timer_Test_6B;
        private System.Windows.Forms.TextBox text_6BUID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox text_R6BLen;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox text_R6BAddr;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox text_R6B;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btRead6B;
        private System.Windows.Forms.TextBox text_W6B;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btWrite6B;
        private System.Windows.Forms.TextBox text_W6BLen;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox text_W6BAddr;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox text_lock6b;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox text_Statu6B;
        private System.Windows.Forms.Button btCheckLock6B;
        private System.Windows.Forms.Button btLock6B;
        private System.Windows.Forms.TextBox text_checkaddr;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.CheckBox check_num;
        private System.Windows.Forms.ComboBox com_Target;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.GroupBox gbp_buff;
        private System.Windows.Forms.RadioButton rb496;
        private System.Windows.Forms.RadioButton rb128;
        private System.Windows.Forms.Button btGetEPCandTIDLen;
        private System.Windows.Forms.Button btSetEPCandTIDLen;
        private System.Windows.Forms.Timer timer_Buff;
        private System.Windows.Forms.GroupBox group_maxtime;
        private System.Windows.Forms.Button btSetMaxtime;
        private System.Windows.Forms.ComboBox comboBox_maxtime;
        private System.Windows.Forms.CheckBox checkBox_rate;
        private System.Windows.Forms.TabPage tabPage_Module;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox com_MFliterTime;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ComboBox COM_MRPTime;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MRB_6B;
        private System.Windows.Forms.RadioButton MRB_G2;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ComboBox com_MS;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox com_MQ;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.TextBox txt_Mtidlen;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox txt_mtidaddr;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TextBox txt_Mdata;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txt_Mlen;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_Maddr;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.RadioButton RBM_USER;
        private System.Windows.Forms.RadioButton RBM_TID;
        private System.Windows.Forms.RadioButton RBM_EPC;
        private System.Windows.Forms.Button btMGetParameter;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.Button btSetMmode;
        private System.Windows.Forms.ComboBox com_Mmode;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button btMSetParameter;
        private System.Windows.Forms.Timer timer_RealTime;
        private System.Windows.Forms.CheckBox checkBox_tid;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.RadioButton radioButton_band8;
        private System.Windows.Forms.GroupBox gbp_wpower;
        private System.Windows.Forms.RadioButton rb_wp2;
        private System.Windows.Forms.RadioButton rb_wp1;
        private System.Windows.Forms.Button bt_GetWpower;
        private System.Windows.Forms.Button bt_SetWpower;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.ComboBox com_wpower;
        private System.Windows.Forms.GroupBox gbp_Retry;
        private System.Windows.Forms.ComboBox com_retrytimes;
        private System.Windows.Forms.Button bt_Getretry;
        private System.Windows.Forms.Button bt_Setretry;
        private System.Windows.Forms.GroupBox gbp_MixRead;
        private System.Windows.Forms.ComboBox com_MixMem;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.RadioButton rb_mix;
        private System.Windows.Forms.TextBox text_readpsd;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox text_readLen;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox text_readadr;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.RadioButton rb_fastid;
        private System.Windows.Forms.GroupBox gbp_DRM;
        private System.Windows.Forms.RadioButton DRM_CLOSE;
        private System.Windows.Forms.RadioButton DRM_OPEN;
        private System.Windows.Forms.Button bt_GetDRM;
        private System.Windows.Forms.Button bt_setDRM;
        private System.Windows.Forms.GroupBox gbReturnLoss;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox cmbReturnLossFreq;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox textReturnLoss;
        private System.Windows.Forms.Button btReturnLoss;
        private System.Windows.Forms.GroupBox gbCmdTemperature;
        private System.Windows.Forms.Button btnGetReaderTemperature;
        private System.Windows.Forms.TextBox txtReaderTemperature;
        private System.Windows.Forms.ComboBox cbbAnt;
        private System.Windows.Forms.CheckBox ckClearOperationRec;
        private System.Windows.Forms.RadioButton radioButton_band12;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

