using System;
using MESSI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Acceso_Dades;
using System.Configuration;
using BlibliotecaG2;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace M_E_S_S_I
{

    public partial class menu : Form
    {
        string titulo, infor;
        public menu(String usuario)
        {
            InitializeComponent();
            this.Name = usuario;
            label1.Text = "WELCOME " + Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            login_user obj = new login_user();
            this.Hide();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 1 CAT 1";
            infor = "INFORMACION 1.1";
            Show_Info(titulo, infor);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 2 CAT 1";
            infor = "INFORMACION 1.2";
            Show_Info(titulo, infor);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 3 CAT 1";
            infor = "INFORMACION 1.3";
            Show_Info(titulo, infor);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 4 CAT 1";
            infor = "INFORMACION 1.4";
            Show_Info(titulo, infor);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            info.Hide();
        }

        private void op1_c1_Click(object sender, EventArgs e)
        {
            Blueprints frm = new Blueprints();
            this.Hide();
            frm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 1 CAT 2";
            infor = "INFORMACION 2.1";
            Show_Info(titulo, infor);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 2 CAT 2";
            infor = "INFORMACION 2.4";
            Show_Info(titulo, infor);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 3 CAT 2";
            infor = "INFORMACION 2.3";
            Show_Info(titulo, infor);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 4 CAT 2";
            infor = "INFORMACION 2.4";
            Show_Info(titulo, infor);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void op3_c1_Click(object sender, EventArgs e)
        {
            ConseguirMac();
        }



        private void ConseguirMac()
        {
            string mac = "", new_mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
            new_mac = mac.Substring(0, 2);
            for (int n = 4; n < mac.Length + 2; n= n + 2)
            {
                new_mac = new_mac + "-" + mac.Substring(n - 2, 2);

            }
            MessageBox.Show(new_mac);
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void op2_c1_Click(object sender, EventArgs e)
        {
            Info_Options frm = new Info_Options();
            this.Hide();
            frm.Show();
        }

        private void Show_Info(String titulo, String infor)
        {
            label4.Text = titulo;
            label5.Text = infor;
            info.Show();
        }

     
    }
}
