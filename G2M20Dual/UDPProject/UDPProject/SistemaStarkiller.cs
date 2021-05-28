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
using System.Net;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace UDPProject
{
    public partial class SistemaStarkiller : Form
    {
        Thread TReceive;
        //Series series1;
        public SistemaStarkiller()
        {
            InitializeComponent();
            introducirDatos();
            //chart1.Series.Clear();
        }
        private void introducirDatos()
        {
            txt_IPBase.Text = "127.0.0.1";
            txt_PortBase.Text = "4321";
            txt_PortSistema.Text = "1234";
            txt_Message.Text = "AYH";
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            TReceive = new Thread(new ThreadStart(TReceiveUpd));
            TReceive.Start();
        }

        private void TReceiveUpd()
        {
            UdpClient udpServer = new UdpClient(Int32.Parse(txt_PortSistema.Text));
            string Data;
            while (true)
            {
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                byte[] BytesIn = udpServer.Receive(ref IeP);
                Data = Encoding.ASCII.GetString(BytesIn);

                if (Data == "SDK")
                {
                    ChangeColorPanel(true);
                    //series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                    //{
                    //    Name = "Series1",
                    //    Color = System.Drawing.Color.Red,
                    //    ChartType = SeriesChartType.Line
                    //};
                    //if (InvokeRequired)
                    //{
                    //    //chart1.Invoke(new MethodInvoker(delegate () { chart1.Series[0].Add(series1); }));
                    //}
                }

                if (Data.Length > 4)
                {
                    string[] sdkDivider=null;
                    for (int i = 0; i < Data.Length; i++)
                    {
                        sdkDivider = Data.Split('|');
                    }
                    
                    string type, number, value;
                    type = sdkDivider[0];
                    number = sdkDivider[1];
                    value = sdkDivider[2];
                   // MessageBox.Show(type + "  " + number + "  " + value);
                    if (InvokeRequired)
                    {
                        chart1.Invoke(new MethodInvoker(delegate () { chart1.Series[0].Points.AddXY(double.Parse(number), double.Parse(value) ); }));
                    }
                }
                if (Data == "FLP")
                {
                    ChangeColorPanel(false);
                }
                if (Data.Length > 0)
                {
                    AddTextlbx(Data);
                }
                else
                {
                    Data = null;
                }
            }
        }

        private void ChangeColorPanel(bool Status)
        {
            if (Status)
            {
                pnl_StatusColor.BackColor = Color.Yellow;
            }
            if (Status)
            {
                pnl_StatusColor.BackColor = Color.Red;
            }
        }
        private void AddTextlbx(string message)
        {
            if (InvokeRequired)
            {
                lbx_ReceivedMessage.Invoke(new MethodInvoker(delegate () { lbx_ReceivedMessage.Items.Add(message); }));
            }
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            SendUdp(txt_Message.Text);
        }

        private void SendUdp(string message)
        {
            UdpClient udpCli = new UdpClient();
            udpCli.Connect(txt_IPBase.Text, Int32.Parse(txt_PortBase.Text));
            Byte[] sendData = Encoding.ASCII.GetBytes(message);
            udpCli.Send(sendData, sendData.Length);
        }

       
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
