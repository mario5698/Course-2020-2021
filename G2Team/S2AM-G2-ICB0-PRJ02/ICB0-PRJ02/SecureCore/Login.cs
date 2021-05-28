using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;
using System.IO;
using System.Data.SqlClient;

namespace SecureCore
{
    public partial class Login : Form
    {
        Encrypt cry;
        Acceso acc;

        public Login()
        {
            InitializeComponent();
        }

        void LogIn(object sender, EventArgs e)
        {
            acc = new Acceso();
            cry = new Encrypt();

            string user = txtUsername.Text;
            string password = txtPassword.Text;
            
            string rango = "", acc_level = "";
            string tabla = "users";

            string query = "select * from " + tabla + " where login = '" + user + "'";
            DataSet set = acc.PortarPerConsulta(query, tabla);
            string salDB = set.Tables[0].Rows[0]["salt"].ToString();
            string passwordDB = set.Tables[0].Rows[0]["Password"].ToString();

            byte[] bSal = cry.ToBytes(salDB);
            byte[] bPassLocal = cry.Hash(txtPassword.Text, bSal);

            string passwordHash = cry.ToString(bPassLocal);
            bool log = passwordHash == passwordDB;

            if (acc.LoginCorrecto(user, passwordHash))
            {
                string consulta = String.Format(
                "select * from {0} where login = '{1}' and password = '{2}'",
                tabla, user, passwordHash);
                DataSet dts = acc.PortarPerConsulta(consulta, tabla);
                rango = dts.Tables[0].Rows[0]["idUserCategory"].ToString();
                string table = "UserCategories";
                string cons = "select AccessLevel from " + table + " where idUserCategory = " + rango;
                DataSet dt = acc.PortarPerConsulta(cons, table);
                acc_level = dt.Tables[0].Rows[0]["AccessLevel"].ToString();
                Splash obj = new Splash(user, acc_level);
                this.Hide();
                obj.Show();
            }
            else
            {
                System.IO.Stream str = Properties.Resources.alert;
                SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show(
                    "Usuario o Contraseña incorrecta",
                    "ERROR",
                    MessageBoxButtons.OK
                );
            }
        }

        void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private new void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) LogIn(sender, e);
        }

        private void ShowPassword(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void StartTimer(object sender, MouseEventArgs e)
        {
            timerPassword.Enabled = true;
        }

        private void StopTimer(object sender, MouseEventArgs e)
        {
            timerPassword.Enabled = false;
            txtPassword.PasswordChar = 'Ω';
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetFullPath("."));
        }
    }
}
