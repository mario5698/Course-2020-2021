using System;
using System.Collections;
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
    public partial class load_splash : Form
    {
        int contador = 1;
        public load_splash()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Black;
            progressBar1.BackColor = Color.DarkGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt) // && e.KeyCode == Keys.F2)
            {
                login_admin obj = new login_admin();
                this.Hide();
                obj.Show();
                timer1.Stop();
            }
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador += 1;
            progressBar1.Increment(4);
            pictureBox2.Location = new Point(pictureBox2.Location.X + 14, pictureBox2.Location.Y);
            pictureBox3.Width = pictureBox3.Width + 15;
            if (contador == 32)
            {
                login_user obj = new login_user();
                this.Hide();
                obj.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

