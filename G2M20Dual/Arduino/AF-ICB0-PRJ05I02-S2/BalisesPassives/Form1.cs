using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace BalisesPassives
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort arduino = new System.IO.Ports.SerialPort();
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
                comboBox2.Items.Add(puertosDisponibles[i]);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void Connect()
        {
            try
            {
                if (!connected)
                {
                    arduino.PortName = comboBox2.SelectedItem.ToString();
                    arduino.BaudRate = 9600;
                    arduino.Open();
                    arduino.Write("0");
                    connected = true;
                }
                else
                {
                    arduino.Write("0");
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ComprobarDades();
        }
        private void ComprobarDades()
        {
            int cicles = Int32.Parse(textBox1.Text);
            int divisor = Int32.Parse(textBox2.Text);

            try
            {
                if (cicles <= 20 && cicles >= 5)
                {
                    if (divisor <= 7 && divisor >= 2)
                    {
                       
                       arduino.Write(cicles.ToString()+";"+divisor.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error en divisor// Numeros validos Entre 2 y 7 ");
                    }
                }
                else
                {
                    MessageBox.Show("Error en numero de ciclos// Numeros validos Entre 5 y 20 ");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error en los valores introducidos, El divisor a de ser mayor de 5 y menor de 20. El numero de ciclos tiene que estar dentro del rango de 2 a 7");
            }
        }
    }
}
