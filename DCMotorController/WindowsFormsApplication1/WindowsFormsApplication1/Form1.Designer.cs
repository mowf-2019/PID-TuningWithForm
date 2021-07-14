namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtproductid = new System.Windows.Forms.ComboBox();
            this.txtvendorid = new System.Windows.Forms.ComboBox();
            this.txtproductname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimeStop = new System.Windows.Forms.TextBox();
            this.ckbManual = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtslide1 = new System.Windows.Forms.TextBox();
            this.slide1 = new NationalInstruments.UI.WindowsForms.Slide();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtAmpilute = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSpeed2 = new System.Windows.Forms.TextBox();
            this.txtUdk = new System.Windows.Forms.TextBox();
            this.txtSetpoint2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.zedGraph2 = new ZedGraph.ZedGraphControl();
            this.zedGraph1 = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.txtPOT = new System.Windows.Forms.TextBox();
            this.txtTimeSetting = new System.Windows.Forms.TextBox();
            this.txtTimeRise = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStopTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor1 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor2 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor3 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripPropertyEditor4 = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.groupBox1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDisconnect);
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.tabMenu);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface Setup";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(129, 156);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(97, 35);
            this.btDisconnect.TabIndex = 1;
            this.btDisconnect.Text = "DISCONNECT";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(14, 156);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(96, 35);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Controls.Add(this.tabPage2);
            this.tabMenu.Controls.Add(this.tabPage3);
            this.tabMenu.Location = new System.Drawing.Point(5, 19);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(231, 127);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMenu_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbBaudRate);
            this.tabPage1.Controls.Add(this.cbComPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 101);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RS232";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200",
            "128000",
            "256000"});
            this.cbBaudRate.Location = new System.Drawing.Point(77, 47);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(109, 21);
            this.cbBaudRate.TabIndex = 4;
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(77, 11);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(109, 21);
            this.cbComPort.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtproductid);
            this.tabPage2.Controls.Add(this.txtvendorid);
            this.tabPage2.Controls.Add(this.txtproductname);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 101);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtproductid
            // 
            this.txtproductid.FormattingEnabled = true;
            this.txtproductid.Location = new System.Drawing.Point(78, 72);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(139, 21);
            this.txtproductid.TabIndex = 4;
            // 
            // txtvendorid
            // 
            this.txtvendorid.FormattingEnabled = true;
            this.txtvendorid.Location = new System.Drawing.Point(78, 41);
            this.txtvendorid.Name = "txtvendorid";
            this.txtvendorid.Size = new System.Drawing.Size(139, 21);
            this.txtvendorid.TabIndex = 4;
            // 
            // txtproductname
            // 
            this.txtproductname.FormattingEnabled = true;
            this.txtproductname.Location = new System.Drawing.Point(78, 12);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(139, 21);
            this.txtproductname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vender ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox7);
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(223, 101);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCP/IP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(74, 51);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(134, 21);
            this.comboBox7.TabIndex = 4;
            this.comboBox7.Text = "255.255.255.0";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(74, 15);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(134, 21);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.Text = "192.168.0.10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Subnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimeStop);
            this.groupBox2.Controls.Add(this.ckbManual);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(252, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 483);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Controller Parameters";
            // 
            // txtTimeStop
            // 
            this.txtTimeStop.Location = new System.Drawing.Point(29, 407);
            this.txtTimeStop.Name = "txtTimeStop";
            this.txtTimeStop.Size = new System.Drawing.Size(96, 20);
            this.txtTimeStop.TabIndex = 0;
            this.txtTimeStop.Text = "20";
            this.txtTimeStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeStop.TextChanged += new System.EventHandler(this.txtTimeStop_TextChanged);
            // 
            // ckbManual
            // 
            this.ckbManual.AutoSize = true;
            this.ckbManual.Location = new System.Drawing.Point(31, 455);
            this.ckbManual.Name = "ckbManual";
            this.ckbManual.Size = new System.Drawing.Size(92, 17);
            this.ckbManual.TabIndex = 6;
            this.ckbManual.Text = "Manual/Pulse";
            this.ckbManual.UseVisualStyleBackColor = true;
            this.ckbManual.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtslide1);
            this.groupBox7.Controls.Add(this.slide1);
            this.groupBox7.Location = new System.Drawing.Point(151, 213);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(93, 264);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Manual";
            // 
            // txtslide1
            // 
            this.txtslide1.Location = new System.Drawing.Point(13, 244);
            this.txtslide1.Name = "txtslide1";
            this.txtslide1.ReadOnly = true;
            this.txtslide1.Size = new System.Drawing.Size(71, 20);
            this.txtslide1.TabIndex = 0;
            this.txtslide1.Text = "0";
            this.txtslide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slide1
            // 
            this.slide1.Border = NationalInstruments.UI.Border.Raised;
            this.slide1.Enabled = false;
            this.slide1.FillColor = System.Drawing.Color.Red;
            this.slide1.Location = new System.Drawing.Point(13, 15);
            this.slide1.Name = "slide1";
            this.slide1.PointerColor = System.Drawing.SystemColors.MenuHighlight;
            this.slide1.Range = new NationalInstruments.UI.Range(0D, 2400D);
            this.slide1.Size = new System.Drawing.Size(71, 226);
            this.slide1.TabIndex = 1;
            this.slide1.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.slide1_AfterChangeValue);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPulse);
            this.groupBox6.Controls.Add(this.txtPeriod);
            this.groupBox6.Controls.Add(this.txtAmpilute);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(12, 214);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 160);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pulse Generator";
            // 
            // txtPulse
            // 
            this.txtPulse.Location = new System.Drawing.Point(18, 131);
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(96, 20);
            this.txtPulse.TabIndex = 0;
            this.txtPulse.Text = "50";
            this.txtPulse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPulse.TextChanged += new System.EventHandler(this.txtPulse_TextChanged);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(18, 83);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(96, 20);
            this.txtPeriod.TabIndex = 0;
            this.txtPeriod.Text = "4";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeriod.TextChanged += new System.EventHandler(this.txtPeriod_TextChanged);
            // 
            // txtAmpilute
            // 
            this.txtAmpilute.Location = new System.Drawing.Point(18, 39);
            this.txtAmpilute.Name = "txtAmpilute";
            this.txtAmpilute.Size = new System.Drawing.Size(96, 20);
            this.txtAmpilute.TabIndex = 0;
            this.txtAmpilute.Text = "2000";
            this.txtAmpilute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmpilute.TextChanged += new System.EventHandler(this.txtAmpilute_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Pulse Width (% of period)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Period (secs)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Amplitude (rpm)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtKp);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtTs);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtKi);
            this.groupBox5.Controls.Add(this.txtKd);
            this.groupBox5.Location = new System.Drawing.Point(3, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 196);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(125, 97);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(111, 20);
            this.txtKp.TabIndex = 0;
            this.txtKp.Text = "0.069066251961963";
            this.txtKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.PIDC;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kd - Derivative Gain";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ts - Sample time (ms)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ki - Integral Gain";
            // 
            // txtTs
            // 
            this.txtTs.Location = new System.Drawing.Point(125, 64);
            this.txtTs.Name = "txtTs";
            this.txtTs.Size = new System.Drawing.Size(111, 20);
            this.txtTs.TabIndex = 0;
            this.txtTs.Text = "5";
            this.txtTs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTs.TextChanged += new System.EventHandler(this.txtTs_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kp - Proportional Gain";
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(125, 130);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(111, 20);
            this.txtKi.TabIndex = 0;
            this.txtKi.Text = "4.2249318902055";
            this.txtKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKi.TextChanged += new System.EventHandler(this.txtKi_TextChanged);
            // 
            // txtKd
            // 
            this.txtKd.Location = new System.Drawing.Point(125, 163);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(111, 20);
            this.txtKd.TabIndex = 0;
            this.txtKd.Text = "0.000282261778653273";
            this.txtKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKd.TextChanged += new System.EventHandler(this.txtKd_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Select source Setpoint:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Stop time (sec)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpeed2);
            this.groupBox3.Controls.Add(this.txtUdk);
            this.groupBox3.Controls.Add(this.txtSetpoint2);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.zedGraph2);
            this.groupBox3.Controls.Add(this.zedGraph1);
            this.groupBox3.Location = new System.Drawing.Point(508, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 620);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response Graph";
            // 
            // txtSpeed2
            // 
            this.txtSpeed2.ForeColor = System.Drawing.Color.Blue;
            this.txtSpeed2.Location = new System.Drawing.Point(578, 44);
            this.txtSpeed2.Name = "txtSpeed2";
            this.txtSpeed2.ReadOnly = true;
            this.txtSpeed2.Size = new System.Drawing.Size(71, 20);
            this.txtSpeed2.TabIndex = 0;
            this.txtSpeed2.Text = "0";
            this.txtSpeed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUdk
            // 
            this.txtUdk.ForeColor = System.Drawing.Color.Red;
            this.txtUdk.Location = new System.Drawing.Point(578, 326);
            this.txtUdk.Name = "txtUdk";
            this.txtUdk.ReadOnly = true;
            this.txtUdk.Size = new System.Drawing.Size(71, 20);
            this.txtUdk.TabIndex = 0;
            this.txtUdk.Text = "0";
            this.txtUdk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetpoint2
            // 
            this.txtSetpoint2.ForeColor = System.Drawing.Color.Red;
            this.txtSetpoint2.Location = new System.Drawing.Point(578, 21);
            this.txtSetpoint2.Name = "txtSetpoint2";
            this.txtSetpoint2.ReadOnly = true;
            this.txtSetpoint2.Size = new System.Drawing.Size(71, 20);
            this.txtSetpoint2.TabIndex = 0;
            this.txtSetpoint2.Text = "0";
            this.txtSetpoint2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(514, 329);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Udk (pwm)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(510, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Speed (rpm)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(506, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Setpoint(rpm)";
            // 
            // zedGraph2
            // 
            this.zedGraph2.Location = new System.Drawing.Point(6, 319);
            this.zedGraph2.Name = "zedGraph2";
            this.zedGraph2.ScrollGrace = 0D;
            this.zedGraph2.ScrollMaxX = 0D;
            this.zedGraph2.ScrollMaxY = 0D;
            this.zedGraph2.ScrollMaxY2 = 0D;
            this.zedGraph2.ScrollMinX = 0D;
            this.zedGraph2.ScrollMinY = 0D;
            this.zedGraph2.ScrollMinY2 = 0D;
            this.zedGraph2.Size = new System.Drawing.Size(661, 291);
            this.zedGraph2.TabIndex = 0;
            this.zedGraph2.UseExtendedPrintDialog = true;
            // 
            // zedGraph1
            // 
            this.zedGraph1.Location = new System.Drawing.Point(6, 19);
            this.zedGraph1.Name = "zedGraph1";
            this.zedGraph1.ScrollGrace = 0D;
            this.zedGraph1.ScrollMaxX = 0D;
            this.zedGraph1.ScrollMaxY = 0D;
            this.zedGraph1.ScrollMaxY2 = 0D;
            this.zedGraph1.ScrollMinX = 0D;
            this.zedGraph1.ScrollMinY = 0D;
            this.zedGraph1.ScrollMinY2 = 0D;
            this.zedGraph1.Size = new System.Drawing.Size(660, 294);
            this.zedGraph1.TabIndex = 0;
            this.zedGraph1.UseExtendedPrintDialog = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btStop);
            this.groupBox4.Controls.Add(this.btStart);
            this.groupBox4.Location = new System.Drawing.Point(7, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controller";
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(129, 28);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(97, 41);
            this.btStop.TabIndex = 0;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Enabled = false;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(14, 28);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(96, 41);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Plant;
            this.pictureBox2.Location = new System.Drawing.Point(7, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(495, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rise time (sec)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Setting time (sec)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Overshoot (POT%)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Peak (rpm)";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.txtPeak);
            this.groupBox8.Controls.Add(this.txtPOT);
            this.groupBox8.Controls.Add(this.txtTimeSetting);
            this.groupBox8.Controls.Add(this.txtTimeRise);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Location = new System.Drawing.Point(7, 330);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(232, 164);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Measurement: Performance and Robustness";
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(120, 133);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.ReadOnly = true;
            this.txtPeak.Size = new System.Drawing.Size(96, 20);
            this.txtPeak.TabIndex = 0;
            this.txtPeak.Text = "0.0";
            this.txtPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPOT
            // 
            this.txtPOT.Location = new System.Drawing.Point(121, 97);
            this.txtPOT.Name = "txtPOT";
            this.txtPOT.ReadOnly = true;
            this.txtPOT.Size = new System.Drawing.Size(96, 20);
            this.txtPOT.TabIndex = 0;
            this.txtPOT.Text = "0.0";
            this.txtPOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeSetting
            // 
            this.txtTimeSetting.Location = new System.Drawing.Point(122, 61);
            this.txtTimeSetting.Name = "txtTimeSetting";
            this.txtTimeSetting.ReadOnly = true;
            this.txtTimeSetting.Size = new System.Drawing.Size(96, 20);
            this.txtTimeSetting.TabIndex = 0;
            this.txtTimeSetting.Text = "0.0";
            this.txtTimeSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeRise
            // 
            this.txtTimeRise.Location = new System.Drawing.Point(122, 25);
            this.txtTimeRise.Name = "txtTimeRise";
            this.txtTimeRise.ReadOnly = true;
            this.txtTimeRise.Size = new System.Drawing.Size(96, 20);
            this.txtTimeRise.TabIndex = 0;
            this.txtTimeRise.Text = "0.0";
            this.txtTimeRise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnect,
            this.toolStripStatus,
            this.toolStripStopTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripConnect
            // 
            this.toolStripConnect.Name = "toolStripConnect";
            this.toolStripConnect.Size = new System.Drawing.Size(97, 17);
            this.toolStripConnect.Text = "toolStripConnect";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatus.Text = "toolStripStatus";
            // 
            // toolStripStopTime
            // 
            this.toolStripStopTime.Name = "toolStripStopTime";
            this.toolStripStopTime.Size = new System.Drawing.Size(102, 17);
            this.toolStripStopTime.Text = "toolStripStopTime";
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel1.Text = "InteractionMode:";
            // 
            // toolStripPropertyEditor1
            // 
            this.toolStripPropertyEditor1.AutoSize = false;
            this.toolStripPropertyEditor1.Name = "toolStripPropertyEditor1";
            this.toolStripPropertyEditor1.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor1.Size = new System.Drawing.Size(120, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel2.Text = "Cursors:";
            // 
            // toolStripPropertyEditor2
            // 
            this.toolStripPropertyEditor2.AutoSize = false;
            this.toolStripPropertyEditor2.Name = "toolStripPropertyEditor2";
            this.toolStripPropertyEditor2.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor2.Size = new System.Drawing.Size(120, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(75, 22);
            this.toolStripLabel3.Text = "Annotations:";
            // 
            // toolStripPropertyEditor3
            // 
            this.toolStripPropertyEditor3.AutoSize = false;
            this.toolStripPropertyEditor3.Name = "toolStripPropertyEditor3";
            this.toolStripPropertyEditor3.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor3.Size = new System.Drawing.Size(120, 23);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(36, 15);
            this.toolStripLabel4.Text = "Plots:";
            // 
            // toolStripPropertyEditor4
            // 
            this.toolStripPropertyEditor4.AutoSize = false;
            this.toolStripPropertyEditor4.Name = "toolStripPropertyEditor4";
            this.toolStripPropertyEditor4.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.toolStripPropertyEditor4.Size = new System.Drawing.Size(120, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 646);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PID - DC Motor Controller -Lớp KTBS - HCMUT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox txtproductname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox txtproductid;
        private System.Windows.Forms.ComboBox txtvendorid;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.IO.Ports.SerialPort serialPort1;
        private NationalInstruments.UI.WindowsForms.Slide slide1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtTs;
        private System.Windows.Forms.TextBox txtAmpilute;
        private System.Windows.Forms.TextBox txtPulse;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox ckbManual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.TextBox txtPOT;
        private System.Windows.Forms.TextBox txtTimeSetting;
        private System.Windows.Forms.TextBox txtTimeRise;
        private System.Windows.Forms.TextBox txtTimeStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor toolStripPropertyEditor4;
        private ZedGraph.ZedGraphControl zedGraph1;
        private System.Windows.Forms.TextBox txtslide1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripConnect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStopTime;
        private System.Windows.Forms.TextBox txtSetpoint2;
        private System.Windows.Forms.TextBox txtSpeed2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtUdk;
        private System.Windows.Forms.Label label24;
        private ZedGraph.ZedGraphControl zedGraph2;
    }
}

