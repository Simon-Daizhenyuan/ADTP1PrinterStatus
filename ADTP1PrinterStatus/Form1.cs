using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;

namespace ADTP1PrinterStatus
{
    public partial class Form1 : Form
    {
        System.IO.Stream Stm = null;
        TcpClient tcpClnt;
        SerialPort serialPort;
        Byte[] data = new Byte[256];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipAddressTB.Text = Properties.Settings.Default.IPAddress;
            comPortTB.Text = Properties.Settings.Default.COMPort;
            portCB.Text = Properties.Settings.Default.Port;
            toolStripStatusLabel1.Text = "";
        }

        private void DecodeStatus(byte[] data, int bytes)
        {
            if (data[0] == 5) //First byte is ENQ ?
            {
                if ( data.Length >=3)
                {
                    enqResponseLbl.Text = "";
                    for (int x = 0; x < bytes; x++)
                    {
                        switch (data[x])
                        {
                            case 5:
                                enqResponseLbl.Text += "<ENQ>";
                                break;
                            case 13:
                                enqResponseLbl.Text += "<CR>";
                                break;
                            default:
                                enqResponseLbl.Text += System.Text.Encoding.ASCII.GetString(data, x, 1);
                                break;
                        }
                    }
                    enqResponseLbl.Text += " ( ";
                    for (int x = 0; x < bytes; x++)
                    {
                        enqResponseLbl.Text += data[x].ToString() + " ";
                    }
                    enqResponseLbl.Text += " )";

                    hardwareFailureLbl.Enabled = false;
                    operatorCorrectableErrorLbl.Enabled = false;
                    onlineDataErrorLbl.Enabled = false;
                    busyLbl.Enabled = false;
                    activeLbl.Enabled = false;
                    onlineLbl.Enabled = false;
                    lowBatteryLbl.Enabled = false;
                    formatErrorLbl.Enabled = false;
                    waitingToDispenseLabelLbl.Enabled = false;
                    ribbonErrorLbl.Enabled = false;
                    stockErrorLbl.Enabled = false;
                    onlineErrorLbl.Enabled = false;
                    string statusString = "";
                    string secondByteBinay = Convert.ToString(data[1], 2).PadLeft(8,'0');
                    string thirdByteBinay = Convert.ToString(data[2], 2).PadLeft(8, '0');
                    for (int x = secondByteBinay.Length-1; x > 2; x--)
                    {
                        if (secondByteBinay.Substring(x, 1) == "1")
                        {
                            switch (x)
                            {
                                case 2:
                                    hardwareFailureLbl.Enabled = true;
                                    statusString += "Hardware Failure, ";
                                    break;
                                case 3:
                                    operatorCorrectableErrorLbl.Enabled = true;
                                    statusString += "Operator Correctable Error, ";
                                    break;
                                case 4:
                                    onlineDataErrorLbl.Enabled = true;
                                    statusString += "Online Data Error, ";
                                    break;
                                case 5:
                                    busyLbl.Enabled = true;
                                    statusString += "Busy, ";
                                    break;
                                case 6:
                                    activeLbl.Enabled = true;
                                    statusString += "Active, ";
                                    break;
                                case 7:
                                    onlineLbl.Enabled = true;
                                    statusString += "Online, ";
                                    break;
                            }                       
                        }                       
                    }
                    for (int x = thirdByteBinay.Length - 1; x > 2; x--)
                    {
                        if (thirdByteBinay.Substring(x, 1) == "1")
                        {
                            switch (x)
                            {
                                case 2:
                                    lowBatteryLbl.Enabled = true;
                                    statusString += "Low Battery, ";
                                    break;
                                case 3:
                                    formatErrorLbl.Enabled = true;
                                    statusString += "Format Error, ";
                                    break;
                                case 4:
                                    waitingToDispenseLabelLbl.Enabled = true;
                                    statusString += "Waiting To Dispense Label, ";
                                    break;
                                case 5:
                                    ribbonErrorLbl.Enabled = true;
                                    statusString += "Ribbon Error, ";
                                    break;
                                case 6:
                                    stockErrorLbl.Enabled = true;
                                    statusString += "Stock Error, ";
                                    break;
                                case 7:
                                    onlineErrorLbl.Enabled = true;
                                    statusString += "Online Error, ";
                                    break;
                            }
                        }
                    }
                    toolStripStatusLabel1.Text = statusString;
                }                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Byte[] bufferEscritura = new Byte[1];
            bufferEscritura[0] = 5; // <ENQ>
            if (portCB.Text == "TCP/IP") 
            {                
                if (Stm.CanWrite)
                {
                    if ((Stm != null))
                    {
                        //Envio los datos al Servidor
                        Stm.Write(bufferEscritura, 0, bufferEscritura.Length);
                    }
                }

                try
                {
                    if (tcpClnt.Available > 0)
                    {
                        int bytes = Stm.Read(data, 0, data.Length);
                        DecodeStatus(data,bytes);
                    }
                }
                catch (IOException ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Time out");
                }
            }
            else // COM port
            {               
                if (serialPort.IsOpen)
                {                   
                    serialPort.Write(bufferEscritura, 0, bufferEscritura.Length);
                    try
                    {
                        int bytes;
                        do
                        {
                            bytes = serialPort.BytesToRead;
                            if (bytes > 0)
                            {
                                serialPort.Read(data, 0, bytes);
                                DecodeStatus(data, bytes);
                            }
                        } while (bytes == 0);
                    }
                    catch (IOException ex)
                    {
                        DialogResult dialogResult = MessageBox.Show("Time out");
                    }
                    
                }
            }
        }

        private void printerStatusCB_CheckedChanged(object sender, EventArgs e)
        {
            if (printerStatusCB.Checked)
            {
                portCB.Enabled = false;
                ipAddressTB.Enabled = false;
                comPortTB.Enabled = false;

                if (portCB.Text == "TCP/IP")
                {
                    try
                    {
                        tcpClnt = new TcpClient();
                        tcpClnt.ReceiveTimeout = 2000; // 2 segons de time out
                        tcpClnt.Connect(ipAddressTB.Text, 9100);
                        Stm = tcpClnt.GetStream();

                        timer1.Enabled = true;
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        tcpClnt.Close();
                        tcpClnt = null;
                        printerStatusCB.Checked = false;
                    }
                }
                else // Serial port
                {
                    serialPort = new SerialPort();
                    serialPort.PortName = Properties.Settings.Default.COMPort; ;
                    serialPort.BaudRate = 9600;
                    serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                    serialPort.Open();
                    timer1.Enabled = true;
                }
            }
            else
            {
                timer1.Enabled = false;
                portCB.Enabled = true;
                ipAddressTB.Enabled = true;
                comPortTB.Enabled = true;
                hardwareFailureLbl.Enabled = false;
                operatorCorrectableErrorLbl.Enabled = false;
                onlineDataErrorLbl.Enabled = false;
                busyLbl.Enabled = false;
                activeLbl.Enabled = false;
                onlineLbl.Enabled = false;
                lowBatteryLbl.Enabled = false;
                formatErrorLbl.Enabled = false;
                waitingToDispenseLabelLbl.Enabled = false;
                ribbonErrorLbl.Enabled = false;
                stockErrorLbl.Enabled = false;
                onlineErrorLbl.Enabled = false;
                enqResponseLbl.Text = "";
                if (portCB.Text == "TCP/IP")
                {
                    tcpClnt.Close();
                    tcpClnt = null;
                }
                else
                {
                    serialPort.Close();
                }
            }
        }

        private void ipAddressTB_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPAddress = ipAddressTB.Text;
            Properties.Settings.Default.Save();
        }

        private void portCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Port = portCB.Text;
            Properties.Settings.Default.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enqResponseLbl_Click(object sender, EventArgs e)
        {

        }

        private void comPortTB_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.COMPort = comPortTB.Text;
            Properties.Settings.Default.Save();
        }
    }
                
}
