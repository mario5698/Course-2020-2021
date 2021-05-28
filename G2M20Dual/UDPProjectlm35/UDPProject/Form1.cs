using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Base_Click(object sender, EventArgs e)
        {
            BaseStarkiller frm = new BaseStarkiller();
            frm.Show();
        }

        private void btn_Sistema_Click(object sender, EventArgs e)
        {
            SistemaStarkiller frm = new SistemaStarkiller();
            frm.Show();
        }
    }
}
