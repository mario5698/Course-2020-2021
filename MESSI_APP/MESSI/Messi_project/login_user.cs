using System;
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


namespace M_E_S_S_I
{
    public partial class login_user : Form
    {
        public login_user()
        {
            InitializeComponent();
        }
        static bool ReadSetting(string key, string user)
        {
            bool exist = false;
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key];

            if (result == user)
            {
                exist = true;
            }
            else

            {
                MessageBox.Show("NO ACCESS ALLOWED");
            }
            return exist;
        }

        int intentos = 0, max_intentos = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "select* from users where codeUser = '" + txtUsername.Text +"' and password = '" + txtPassword.Text + "'";
            Acceso acc = new Acceso();
            string key = "TrustedUser", tabla = "users";
            if (acc.Verficar_User(consulta, tabla) && ReadSetting(key, txtUsername.Text))
            {
                menu obj = new menu(txtUsername.Text);
                this.Hide();
                obj.Show();
            } else
            {
                if (intentos <= max_intentos)
                {
                    txtPassword.Clear();
                    String path = @"..\MESSI\Messi_project\log\user_logs.txt";
                    using (StreamWriter sr = File.AppendText(path))

                    {
                        DateTime date = DateTime.Now;
                        string fecha = date.ToString("yyyyMMdd:HHmmss: ");
                        sr.WriteLine(fecha + txtUsername.Text);
                        sr.Close();
                    }
                    intentos++;

                    if (intentos == max_intentos)
                    {
                        MessageBox.Show("Demasiados intentos.");
                        Application.Exit();
                    }
                } 
            }
        }

    
        private void retroceder_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void login_user_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '✱';
        }
    }
}
