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
    public partial class Welcome : Form
    {
        public Welcome(String nombre)
        {
            InitializeComponent();
            Logged_User_Name.Text = "Welcome " + nombre;
        }
    }
}
