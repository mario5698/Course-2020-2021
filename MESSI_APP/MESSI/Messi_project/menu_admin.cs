using MESSI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_E_S_S_I
{
    public partial class menu_admin : Form
    {
        String titulo, infor;
      
        public menu_admin()
        {
            String name = "Administrator";
            InitializeComponent();
            bnt_Username1.Text = "Welcome "+ name;
            Nombrar_Botones();
        }

        private void Nombrar_Botones()
        {
            op1_c1.Text = "Device Management";
            op2_c1.Text = "Admin Coordenates";
            op3_c1.Text = "Trusted Users";
            op4_c1.Text = "Encrypt ConnexionString";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void retroceder_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 1 ADMIN";
            infor = "INFORMACION 1 ADMIN";
            Show_Info(titulo, infor);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 2 ADMIN";
            infor = "INFORMACION 2 ADMIN";
            Show_Info(titulo, infor);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 3 ADMIN";
            infor = "INFORMACION 3 ADMIN";
            Show_Info(titulo, infor);
        }

        private void menu_admin_Load(object sender, EventArgs e)
        {
            info.Hide();
        }

        private void bnt_Username1_Click(object sender, EventArgs e)
        {

        }

        private void op3_c1_Click(object sender, EventArgs e)
        {
            Trusted_Users obj = new Trusted_Users();
            obj.Show();
            info.Hide();
        }


        private void op1_c1_Click(object sender, EventArgs e)
        {
           GestionDispositivos obj = new GestionDispositivos(op1_c1.Text);
            obj.Show();
            info.Hide();
        }

        private void op2_c1_Click(object sender, EventArgs e)
        {
            Reg_Coord reg = new Reg_Coord();
            info.Hide();
            reg.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            titulo = "TITULO OPCION 4 ADMIN";
            infor = "INFORMACION 4 ADMIN";
            Show_Info(titulo, infor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encriptar reg = new Encriptar();
            info.Hide();
            reg.Show();
        }

        private void Show_Info(String titulo, String infor)
        {
            label6.Text = titulo;
            label5.Text = infor;
            info.Show();
        }
    }
}
