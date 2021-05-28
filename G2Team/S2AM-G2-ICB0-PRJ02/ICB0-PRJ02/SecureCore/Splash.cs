using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCore
{
    public partial class Splash : Form
    {
        String user;
        int contador = 1;
        public Splash(String user, String rango)
        {
            InitializeComponent();
            this.user = user;
            this.Name = rango;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contador += 1;
            progressBar.Increment(4);
            if (contador == 31)
            {
                Menu menu = new Menu(user, Name);
                this.Hide();
                menu.Show();
                timer.Enabled = false;
            }
        }
    }
}
