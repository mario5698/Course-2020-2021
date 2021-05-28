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
using System.Timers;


namespace UDPProject
{
    public partial class BaseStarkiller : Form
    {
        Thread TReceive;

        public BaseStarkiller()
        {
            InitializeComponent();
            introducirDatos();

        }
        private void introducirDatos()
        {
            txt_IPSistema.Text = "127.0.0.1";
            txt_PortSistema.Text = "1234";
            txt_PortBase.Text = "4321";
        }

        private void StartProcces()
        {
            SendUdp("IAR");
            SendUdp("SLP");
            SendUdp("SDK");
            SendSDKData();
        }

        private void SendSDKData()
        {
            
            string valorSdk;
            double temp;
            for (int i = 0; i < 30; i++)
            {
                temp = Math.Pow(Math.E, i/ 100.00);
                valorSdk = "SDK|" + i + "|" + temp.ToString();
                SendUdp(valorSdk);
            }
            SendUdp("FLP");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            TReceive = new Thread(new ThreadStart(TReceiveUpd));
            TReceive.Start();
        }

        private void TReceiveUpd()
        {
            UdpClient udpServer = new UdpClient(Int32.Parse(txt_PortBase.Text));
            string Data;
            while (true)
            {
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                byte[] BytesIn = udpServer.Receive(ref IeP);
                Data = Encoding.ASCII.GetString(BytesIn);
                AddTextlbx(Data);
              
            }
        }

        private void SendUdp(string message)
        {
            UdpClient udpCli = new UdpClient();
            udpCli.Connect(txt_IPSistema.Text, Int32.Parse(txt_PortSistema.Text));
            Byte[] sendData = Encoding.ASCII.GetBytes(message);
            udpCli.Send(sendData, sendData.Length);
        }
        private void AddTextlbx(string message)
        {
            if (InvokeRequired)
            {
                lbx_ReceivedMessage.Invoke(new MethodInvoker(delegate () { lbx_ReceivedMessage.Items.Add(message); }));
            }
        }
        private void btn_Disconnect_Click(object sender, EventArgs e)
        {

        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            StartProcces();

        }

        

       
    }
}
