using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //GetPortname
using ZedGraph;     //GraphPane
using LibUsbDotNet; //add
using LibUsbDotNet.Main;//add

using System.Net; //add
using System.Net.Sockets;//add
using System.IO; //Stream

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //For USB
        public static UsbDevice myUsbDevice;
        UsbEndpointReader reader;
        UsbEndpointWriter writer;
        //----->End
        //--> For LAN
        TcpClient client = null;
        Stream stream = null; // client.GetStream();
        //--> LAN End
        bool ckConnect = false;
        int connectType = 0; //0=rs232|1=USB|2=LAN
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedIndex == 0) //RS232
            {   
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Int32.Parse(cbBaudRate.Text);
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open(); ckConnect = true;
                    SaveSetting(); // Lưu cổng COM vào ComName
                    //
                    connectType = 0;
                    toolStripConnect.Text = "Connected via :" + cbComPort.Text + "," 
                        + cbBaudRate.Text + ",8,1,N";
                }
            }
            else if (tabMenu.SelectedIndex == 1) //USB
            {
                if (myUsbDevice == null)
                {
                    UsbRegDeviceList allDevices = UsbDevice.AllDevices;
                    foreach (UsbRegistry usbRegistry in allDevices)
                    {
                        if (usbRegistry.Open(out myUsbDevice))
                        {
                            txtproductname.Text = myUsbDevice.Info.ProductString;
                            txtvendorid.Text = myUsbDevice.Info.Descriptor.VendorID.ToString();
                            txtproductid.Text = myUsbDevice.Info.Descriptor.ProductID.ToString();
                        }
                    }
                }
                //USB - Connect
                IUsbDevice wholeUsbDevice = myUsbDevice as IUsbDevice;
                if (!ReferenceEquals(wholeUsbDevice, null))
                {
                    // Select config #1
                    wholeUsbDevice.SetConfiguration(1);
                    // Claim interface #0.
                    wholeUsbDevice.ClaimInterface(0);
                }
                //Open usb end point reader and writer
                reader = myUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01); // open read endpoint 1.
                writer = myUsbDevice.OpenEndpointWriter(WriteEndpointID.Ep01);// open write endpoint 1.
                //
                ckConnect = true;
                connectType = 1;
                //
                toolStripConnect.Text = "Connected via : USB " + " with VID: "
                        + txtvendorid.Text + ", PID: " + txtproductid.Text;
            }
            else if (tabMenu.SelectedIndex == 2) { //LAN
                // 1. connect
                //if (!client.Connected) 
                client = new TcpClient();
                client.Connect("192.168.0.10", 7);

                stream = client.GetStream();
                //
                ckConnect = true;
                connectType = 2;
                //
                toolStripConnect.Text = "Connected via : TCP/IP at IP 192.168.0.10";
            }
            //
            if (ckConnect) {
                btDisconnect.Enabled = true;
                btConnect.Enabled = false;
                btStart.Enabled = true;
                btStop.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!slide1.Enabled)   slide1.Enabled = true;
            else slide1.Enabled = false;
            if (ckbManual.Checked) txbuff[33] = 1; else txbuff[33] = 0;
           
            //Send Data--->
            if (connectType == 0) { if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36); }
            else if (connectType == 1)
            { }
            if (connectType == 2) { }
            //--->End

        }
        //Choose Mode Compact or Scroll --> related to Graph display   
        int TickStart, intMode = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Init
            toolStripConnect.Text = "No Connect !";
            toolStripStatus.Text = "System is Normal";
            toolStripStopTime.Text = "";
            string[] port = SerialPort.GetPortNames(); //using System.IO.Ports;
            cbComPort.Items.AddRange(port);
            //cbComPort.SelectedIndex = 0;
            cbComPort.Text = Properties.Settings.Default.ComName;
            cbBaudRate.Text = "256000";
            //
            GraphPane myPaneYk = zedGraph1.GraphPane; //using ZedGraph;
            myPaneYk.Title.Text = "Speed Response (DC Motor Servo)";
            myPaneYk.XAxis.Title.Text = "Time (sec)";
            myPaneYk.YAxis.Title.Text = "Speed (RPM)";
            //
            GraphPane myPaneUk = zedGraph2.GraphPane; //using ZedGraph;
            myPaneUk.Title.Text = "Control Signal (100% = 1000 pwm)";
            myPaneUk.XAxis.Title.Text = "Time (sec)";
            myPaneUk.YAxis.Title.Text = "Udk (PWM)";
            //
            // Save 60000 points. At 5 ms sample rate, this is one minute
            RollingPointPairList list = new RollingPointPairList(600000);
            RollingPointPairList list1 = new RollingPointPairList(600000);
            RollingPointPairList list2 = new RollingPointPairList(600000);

            // Initially, a curve is added with no data points (list is empty)
            // Color is blue, and there will be no symbols
            LineItem curve = myPaneYk.AddCurve("SetPoint", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPaneYk.AddCurve("RealSpeed", list1, Color.Blue, SymbolType.None);
            // instead of discrete step-sized jumps
            myPaneYk.XAxis.Scale.Min = 0;
            myPaneYk.XAxis.Scale.Max = 20.0;
            myPaneYk.XAxis.Scale.MinorStep = 1;
            myPaneYk.XAxis.Scale.MajorStep = 5;
            // Scale the axes
            zedGraph1.AxisChange();

            //
            LineItem curve2 = myPaneUk.AddCurve("Udk (PWM)", list, Color.Red, SymbolType.None);
            //instead of discrete step-sized jumps
            myPaneUk.XAxis.Scale.Min = 0;
            myPaneUk.XAxis.Scale.Max = 20.0;
            myPaneUk.XAxis.Scale.MinorStep = 1;
            myPaneUk.XAxis.Scale.MajorStep = 5;
            // Scale the axes
            zedGraph2.AxisChange();

            // Save the beginning time for reference
            TickStart = Environment.TickCount;
        }
        private void SaveSetting()
        {
            Properties.Settings.Default.ComName = cbComPort.Text;
            Properties.Settings.Default.Save();
        }
        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if (txbuff[0]==1) btStop_Click(sender, e);
            if (serialPort1.IsOpen) {
                serialPort1.Close();
                ckConnect = false;
            }
            //
            if (myUsbDevice != null) //USB
            {
                if (myUsbDevice.IsOpen)
                {
                    IUsbDevice wholeUsbDevice = myUsbDevice as IUsbDevice;
                    if (!ReferenceEquals(wholeUsbDevice, null))
                    {
                        // Release interface #0.
                        wholeUsbDevice.ReleaseInterface(0);
                    }
                    //reader.Dispose();
                    //writer.Dispose();

                    myUsbDevice.Close();
                    myUsbDevice = null;

                    txtproductname.Text = "";
                    txtvendorid.Text = "";
                    txtproductid.Text = "";
                    //
                    ckConnect = false;
                }
            }
            //
            if (client.Connected) {
                // 4. Close
                stream.Close();
                client.Close();
                ckConnect = false;
            }
            if (!ckConnect) {
                btDisconnect.Enabled = false; btConnect.Enabled = true;
                btStart.Enabled = false; btStop.Enabled = false;
                toolStripConnect.Text = "Diconnected";
                toolStripStatus.Text = "";
                toolStripStopTime.Text = "";
            }
        }
        //Drawing --> related to Graph display

        Int16 preSlide = 0;
        bool ckSlide = false;
        private void slide1_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if ((Int16)slide1.Value - preSlide > 0) ckSlide = true; else ckSlide = false;
            txtslide1.Text = ((Int16)slide1.Value).ToString();
            byte[] bSlide = BitConverter.GetBytes((Int16)slide1.Value);
            txbuff[34] = bSlide[0];
            txbuff[35] = bSlide[1];

            //reset
            tcount = tRise = 0;
            dPeak1 = dpeak = 0;
            dbPOT = -1;
            //Send
            //Send Data--->
            if (connectType == 0) { serialPort1.Write(txbuff, 0, 36); }
            else if (connectType == 1)
            {
            }
            if (connectType == 2) { }
            //--->End
            preSlide = (Int16)slide1.Value;
            //Reset
            if (slide1.Value == 0.0) {
                txtPOT.Text = "0.0";
                txtTimeSetting.Text = "0.0";
                txtTimeRise.Text = "0.0";
                txtTimeSetting.Text = "0.0";
                txtPeak.Text = "0.0";
            }
        }

        double intcurrent;
        double intsetpoint;
        double intudk;

        double dbPOT = -1, dbPOT1 = 0;
        double dpeak = 0, dPeak1 = 0;
        double tcount = 0, tRise = 0;
        bool ckTxl = false;
        //
        private void timer2_Tick(object sender, EventArgs e) //5ms (get Data via communacation)
        {
            nTimeStopCount +=5; //5ms
            //Send Data--->
            if (connectType == 0) {
                //serialPort1.Write(txbuff, 0, 36);
                if (serialPort1.IsOpen)
                {
                    if (serialPort1.BytesToRead > 8)   //Số byte đã nhận được trong bộ đệm
                    {
                        string data = serialPort1.ReadLine();
                        serialPort1.DiscardInBuffer();
                        string[] subdata = data.Split(',');

                        if (subdata.Length < 4) return;
                        //txtResult.Text = data;

                        //
                        if (subdata[0] == "A")
                        {
                            string realSpeed, setpoint, udk;
                            setpoint = subdata[1];
                            realSpeed = subdata[2];
                            udk = subdata[3];
                            Draw(setpoint, realSpeed, udk);
                        }                  
                    }
                }
            }
            else if (connectType == 1)
            {
                //Send
                try
                {
                    int bytesWritten;
                    writer.Write(txbuff, 1000, out bytesWritten);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Can Not Send Data To USB Device\nDetails: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Receive
                try
                {
                    int bytesRead = 0;
                    byte[] readBuffer = new byte[64];
                    reader.Read(readBuffer, 1000, out bytesRead);
                    //txtLog.Text = Encoding.Default.GetString(readBuffer);
                    string data = Encoding.Default.GetString(readBuffer);
                    string[] subdata = data.Split(',');
                    if (subdata.Length < 3) return;
                    string realSpeed, setpoint, udk;
                    setpoint = subdata[0];
                    realSpeed = subdata[1];
                    udk = subdata[2];
                    Draw(setpoint, realSpeed, udk);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Can Not Receive Data From USB Device\nDetails: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (connectType == 2) { //LAN
                // 2. send
                stream.Write(txbuff, 0, 36);
                // 3. receive
                byte[] readBuffer = new byte[64];
                stream.Read(readBuffer, 0, 64);
                //process
                string data = Encoding.Default.GetString(readBuffer);
                string[] subdata = data.Split(',');
                if (subdata.Length < 3) return;
                string realSpeed, setpoint, udk;
                setpoint = subdata[0];
                realSpeed = subdata[1];
                udk = subdata[2];
                Draw(setpoint, realSpeed, udk);
            }
            //--->End
            // Tinh toan thoi gian trong nay
            // TH Xung: 2 giá trị, 0 và max
            // TH Manual: Kéo lên, kéo xuống
           
            //... TH1 ...setpoint="2000" = txtAmpilute.Text
            //... TH1 ...setpoint="0" = //txtAmpilute.Text 
            if (!ckbManual.Checked)
            {
                //No checked
                if (intsetpoint > 0)
                { //MAX (len)
                    tcount += 5;
                    //Cal POT %
                    dbPOT1 = (intcurrent - intsetpoint) / intsetpoint * 100.0;
                    if (dbPOT <= dbPOT1) dbPOT = dbPOT1;
                    if (Math.Abs(dbPOT)<0.5) txtPOT.Text = dbPOT.ToString();
                    // Cal Peak
                    dPeak1 = intcurrent;
                    if (dpeak <= dPeak1) dpeak = dPeak1;
                    txtPeak.Text = dpeak.ToString();
                    // Cal txl
                    if (ckTxl == false)
                    {
                        if (Math.Abs(intsetpoint - intcurrent) / 100.0 < 0.05) // tieu chuan 5%
                        {
                            txtTimeSetting.Text = (tcount / 1000.0).ToString();
                            ckTxl = true;
                        }
                    }
                    //cal tRise (Rise time)
                    if ((intcurrent > intsetpoint * 0.1)&&(intcurrent < intsetpoint * 0.9)) {
                        tRise += 5;
                        txtTimeRise.Text = (tRise/1000.0).ToString();
                    }
                }
                else
                { //Min = 0 (xuong) -> Cho reset
                    tcount = tRise = 0;
                    dPeak1 = dpeak = 0;
                    dbPOT = -1;
                    ckTxl = false;
                }
            }
            else { // Silde Manual
                if (ckSlide)
                { //MAX (len)
                    tcount += 5;
                    //Cal POT %
                    dbPOT1 = (intcurrent - intsetpoint) / intsetpoint * 100.0;
                    if (dbPOT <= dbPOT1) dbPOT = dbPOT1;
                    if (Math.Abs(dbPOT) < 0.5) txtPOT.Text = dbPOT.ToString();
                    // Cal Peak
                    dPeak1 = intcurrent;
                    if (dpeak <= dPeak1) dpeak = dPeak1;
                    txtPeak.Text = dpeak.ToString();
                    // Cal txl
                    if (ckTxl == false)
                    {
                        if (Math.Abs(intsetpoint - intcurrent) / 100.0 < 0.05) // tieu chuan 5%
                        {
                            txtTimeSetting.Text = (tcount / 1000.0).ToString();
                            ckTxl = true;
                        }
                    }
                    //cal tRise (Rise time)
                    if ((intcurrent > intsetpoint * 0.1) && (intcurrent < intsetpoint * 0.9))
                    {
                        tRise += 5;
                        txtTimeRise.Text = (tRise / 1000.0).ToString();
                    }
                }
                else { }
            }
            // Display Time Stop (seconds)
            toolStripStopTime.Text = "Time Stop is : " + (nTimeStopCount/1000).ToString() +" / "+ nTimeStop.ToString() + " (seconds)";
            if (nTimeStopCount / 1000 >= nTimeStop) btStop_Click(sender,e);              
        }

        private void txtAmpilute_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmpilute.Text)) {
                byte[] bAmp = BitConverter.GetBytes(Int16.Parse(txtAmpilute.Text));
                txbuff[27] = bAmp[0];
                txbuff[28] = bAmp[1];
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPeriod.Text))
            {
                txbuff[29] = byte.Parse(txtPeriod.Text);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }

        private void txtPulse_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPulse.Text))
            {
                txbuff[30] = byte.Parse(txtPulse.Text);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }
        int nTimeStop = 0;
        private void txtTimeStop_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTimeStop.Text))
            {
                nTimeStop = Int16.Parse(txtTimeStop.Text);
                byte[] bTstop = BitConverter.GetBytes(nTimeStop);
                txbuff[31] = bTstop[0];
                txbuff[32] = bTstop[1];     
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }

        private void txtTs_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTs.Text)) { 
                txbuff[2] = byte.Parse(txtTs.Text);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }

        private void txtKp_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKp.Text))
            {
                byte[] bKp = BitConverter.GetBytes(double.Parse(txtKp.Text));
                Array.Copy(bKp, 0, txbuff, 3, 8);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }
        private void txtKi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtKi.Text))
            {
                byte[] bKi = BitConverter.GetBytes(double.Parse(txtKi.Text));
                Array.Copy(bKi, 0, txbuff, 11, 8);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }

        private void txtKd_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtKd.Text))
            {
                byte[] bKd = BitConverter.GetBytes(double.Parse(txtKd.Text));
                Array.Copy(bKd, 0, txbuff, 19, 8);
            }
            if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36);
        }
        private void tabMenu_Selected(object sender, TabControlEventArgs e)
        {
            if (tabMenu.SelectedIndex == 0) {
            }
            else if (tabMenu.SelectedIndex == 1) {
                if (myUsbDevice == null)
                {
                    UsbRegDeviceList allDevices = UsbDevice.AllDevices;
                    foreach (UsbRegistry usbRegistry in allDevices)
                    {
                        if (usbRegistry.Open(out myUsbDevice))
                        {
                            txtproductname.Text = myUsbDevice.Info.ProductString;
                            txtvendorid.Text = myUsbDevice.Info.Descriptor.VendorID.ToString();
                            txtproductid.Text = myUsbDevice.Info.Descriptor.ProductID.ToString();
                            //
                        }
                    }
                }
                if (myUsbDevice == null)
                {
                    MessageBox.Show("Device Not Found !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tabMenu.SelectedIndex == 2) {
            }
        }

        //UART
        byte[] txbuff = new byte[64];
        int nTimeStopCount = 0;
        private void btStart_Click(object sender, EventArgs e)
        {
            //0.Init
            dbPOT = 0;
            dpeak = 0;
            tcount = 0;
            nTimeStopCount = 0;
            nTimeStop = Int16.Parse(txtTimeStop.Text);

            //1.Send UART..
            //Byte:      0|1  |2 |3-10|11-18|19-26|27-28|29    |30 |31-32|33    |34-35|
            // |Start/Stop|Com|Ts|Kp1 |Ki   |Kd   |Amp  |Period|50%|Tstop|M/Auto|Silde|
            //Com = comuncation: 0:rs232, 1:usb, 2: LAN
            txbuff[0] = 1; //start
            txbuff[1] = (byte)tabMenu.SelectedIndex;
            txbuff[2] = byte.Parse(txtTs.Text);
            byte[] bKp = BitConverter.GetBytes(double.Parse(txtKp.Text));
            Array.Copy(bKp, 0, txbuff, 3, 8);

            byte[] bKi = BitConverter.GetBytes(double.Parse(txtKi.Text));
            Array.Copy(bKi, 0, txbuff, 11, 8);

            byte[] bKd = BitConverter.GetBytes(double.Parse(txtKd.Text));
            Array.Copy(bKd, 0, txbuff, 19, 8);

            byte[] bAmp = BitConverter.GetBytes(Int16.Parse(txtAmpilute.Text));
            txbuff[27] = bAmp[0];
            txbuff[28] = bAmp[1];
            txbuff[29] = byte.Parse(txtPeriod.Text);
            txbuff[30] = byte.Parse(txtPulse.Text);
            byte[] bTstop = BitConverter.GetBytes(Int16.Parse(txtTimeStop.Text));
            txbuff[31] = bTstop[0];
            txbuff[32] = bTstop[1];

            if (ckbManual.Checked) txbuff[33] = 1; else txbuff[33] = 0;
            byte[] bSlide = BitConverter.GetBytes((Int16)slide1.Value);
            txbuff[34] = bSlide[0];
            txbuff[35] = bSlide[1];
            //Send Data--->
            if (connectType == 0) { if (serialPort1.IsOpen) serialPort1.Write(txbuff, 0, 36); } 
            else if (connectType == 1) {
            }
            if (connectType == 2) { }
            //--->End
           //RS232 | USB | LAN
            //2.Reset ZedGraph
            zedGraph1.GraphPane.CurveList.Clear();
            zedGraph1.GraphPane.GraphObjList.Clear(); ;
            zedGraph1.Invalidate();
            GraphPane myPaneYk = zedGraph1.GraphPane;
            myPaneYk.Title.Text = "Speed Response (DC Motor Servo)";
            myPaneYk.XAxis.Title.Text = "Time (sec)";
            myPaneYk.YAxis.Title.Text = "Speed (RPM)";
            RollingPointPairList list = new RollingPointPairList(600000);
            RollingPointPairList list1 = new RollingPointPairList(600000); 
            LineItem curve = myPaneYk.AddCurve("SetPoint", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPaneYk.AddCurve("RealSpeed", list1, Color.Blue, SymbolType.None);
            myPaneYk.XAxis.Scale.Min = 0;
            myPaneYk.XAxis.Scale.Max = 20.0;
            myPaneYk.YAxis.Scale.Min = 0;
            myPaneYk.YAxis.Scale.Max = 2500.0;
            myPaneYk.XAxis.Scale.MinorStep = 1;
            myPaneYk.XAxis.Scale.MajorStep = 5;
            zedGraph1.AxisChange();
            //
            zedGraph2.GraphPane.CurveList.Clear();
            zedGraph2.GraphPane.GraphObjList.Clear(); ;
            zedGraph2.Invalidate();
            GraphPane myPaneUk = zedGraph2.GraphPane; 
            myPaneUk.Title.Text = "Control Signal (100% = 1000 pwm)";
            myPaneUk.XAxis.Title.Text = "Time (sec)";
            myPaneUk.YAxis.Title.Text = "Udk (PWM)";
            RollingPointPairList list2 = new RollingPointPairList(600000);
            LineItem curve2 = myPaneUk.AddCurve("Udk (PWM)", list2, Color.Red, SymbolType.None);
            myPaneUk.XAxis.Scale.Min = 0;
            myPaneUk.XAxis.Scale.Max = 20.0;
            myPaneUk.YAxis.Scale.Min = 0;
            myPaneUk.YAxis.Scale.Max = 1000.0;
            myPaneUk.XAxis.Scale.MinorStep = 1;
            myPaneUk.XAxis.Scale.MajorStep = 5;
            zedGraph2.AxisChange();
            //
            TickStart = Environment.TickCount;
            //timer1.Enabled = true;
            timer2.Enabled = true; //5ms (get Data)
            //
            toolStripStatus.Text = " System is Running ";
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            //toolStripStopTime.Text = "";
            //1. UART
            txbuff[0] = 0; //stop
            //
            if (connectType == 0) { serialPort1.Write(txbuff, 0, 36); }
            else if (connectType == 1)
            {   //USB
                try{
                    int bytesWritten;
                    writer.Write(txbuff, 1000, out bytesWritten);
                }
                catch (Exception err) { 
                    MessageBox.Show("Can Not Send Data To USB Device\nDetails: " + err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (connectType == 2) { //LAN
                stream.Write(txbuff, 0, 36);
            }
            //---->ENd
            //
            timer2.Enabled = false;
            toolStripStatus.Text = " System is Stop ";
            //

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
        }

        private void Draw(string setpoint, string current, string udk)
        {
            // Make sure that the curvelist has at least one curve  
            double.TryParse(setpoint, out intsetpoint);
            double.TryParse(current, out intcurrent);
            double.TryParse(udk, out intudk); //add
            if (zedGraph1.GraphPane.CurveList.Count <= 0)
                return;

            // Get the first CurveItem in the graph
            LineItem curve = zedGraph1.GraphPane.CurveList[0] as LineItem;
            LineItem curve1 = zedGraph1.GraphPane.CurveList[1] as LineItem;
            LineItem curve2 = zedGraph2.GraphPane.CurveList[0] as LineItem; //add
            if (curve == null)
                return;
            if (curve1 == null)
                return;

            // Get the PointPairList
            IPointListEdit list = curve.Points as IPointListEdit;
            IPointListEdit list1 = curve1.Points as IPointListEdit;
            IPointListEdit list2 = curve2.Points as IPointListEdit; //add
            // If this is null, it means the reference at curve.Points does not
            // support IPointListEdit, so we won't be able to modify it
            if (list == null)
                return;
            if (list1 == null)
                return;

            // Time is measured in seconds
            double time = (Environment.TickCount - TickStart) / 1000.0;

            list.Add(time, intsetpoint);
            list1.Add(time, intcurrent);
            list2.Add(time, intudk);
            // Keep the X scale at a rolling 30 second interval, with one
            // major step between the max X value and the end of the axis
            Scale xScale = zedGraph1.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                if (intMode == 1)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 20.0;
                }
                else
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = 0;
                }
            }
            //
            Scale xScale1 = zedGraph2.GraphPane.XAxis.Scale;
            if (time > xScale1.Max - xScale1.MajorStep)
            {
                if (intMode == 1)
                {
                    xScale1.Max = time + xScale1.MajorStep;
                    xScale1.Min = xScale1.Max - 20.0; 
                }
                else
                {
                    xScale1.Max = time + xScale1.MajorStep;
                    xScale1.Min = 0;
                }
            }

            // Make sure the Y axis is rescaled to accommodate actual data
            zedGraph1.AxisChange();
            zedGraph2.AxisChange();
            // Force a redraw
            zedGraph1.Invalidate();
            zedGraph2.Invalidate();
            zedGraph1.Refresh(); //add
            zedGraph2.Refresh(); //add
            //Add
            txtSpeed2.Text = intcurrent.ToString();
            txtSetpoint2.Text = intsetpoint.ToString();
            txtUdk.Text = intudk.ToString();
        }
        //--> related to Graph display
    }
}
