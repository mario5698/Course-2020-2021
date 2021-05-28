using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Arduino
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort arduino = new System.IO.Ports.SerialPort();
        Thread hilo1;
        bool connected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] puertosDisponibles = SerialPort.GetPortNames();
            for (int i = 0; i < puertosDisponibles.Length; i++)
            {
                comboBox1.Items.Add(puertosDisponibles[i]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Connect()
        {
            try
            {
                if (!connected)
                {
                    arduino.PortName = comboBox1.SelectedItem.ToString();
                    arduino.BaudRate = 38400;
                    arduino.Open();
                    connected = true;
                    hilo1 = new Thread(Listen);
                    hilo1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listen()
        {
            while (true)
            {
                if (arduino.BytesToRead > 0)
                {
                    if (InvokeRequired)
                    {
                        textBox1.Invoke(new MethodInvoker(delegate () {
                            textBox1.Text = arduino.ReadLine();
                        }));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connected = false;
            hilo1.Abort();
            arduino.Close();
        }
    }
}
