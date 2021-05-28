using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Acceso_Dades;
using System.Net.Mail;
using M_E_S_S_I;

namespace MESSI
{
    public partial class Trusted_Users : Form_Base
    {
        Obtener_Info_Sistema acc = new Obtener_Info_Sistema();
        Acceso dat = new Acceso();
        string iddevice = "", iduser = "", email = "";

        public Trusted_Users()
        {
            InitializeComponent();
        }

        private void Trusted_Users_Load(object sender, EventArgs e)
        {
            delete_btn.Visible = false;
            reg_btn.Visible = false;
            textBox2.Text = acc.ObtenerHostname();
            textBox1.Text = acc.ObtenerMac();
            Actualizar_Midas();
            Fill_Combo_Box();
        }
        private void Actualizar_Midas()
        {
            int long_textbox = textBox2.TextLength * 19;
            textBox1.Width = long_textbox;
            textBox2.Width = long_textbox;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = "TrustedUser", value = comboBox1.Text;
            AddSetting(key, value);
            Add_BBDD();
            Email();
            string titulo = "USER REGISTERED", texto = "User: " + value + " has been registered succesfully";
            MessageBox.Show(texto, titulo);
            this.Close();
        }

        private void Email()
        {
            string password = "g2123456";
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(email);
            mail.To.Add("ruben.perez.rodriguez@sarria.salesians.cat");
            mail.Subject = "WELCOME TO MESSI USERS";
            mail.Body = "Welcome " + comboBox1.Text + " to the Dark Side. You have been registered in our Database as a MessiUser.";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(email, password);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
            MessageBox.Show("Mail Send");

        }

        static void AddSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(key);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private void Add_BBDD()
        {
            string tabla = "messiusers";
            string consulta = "select * from " + tabla;
            DataTable infotabla = dat.PortarPerConsulta(consulta).Tables[0];
            DataRow row;
            row = infotabla.NewRow();
            row["iduser"] = iduser;
            row["iddevice"] = iddevice;
            infotabla.Rows.Add(row);
            dat.Actualitzar(consulta);
        }

        private void Fill_Combo_Box()
        {
            string tabla = "users";
            DataTable infotabla = dat.PortarTaula(tabla);
            comboBox1.DataSource = infotabla;
            iduser = infotabla.Rows[0]["iduser"].ToString();
            email = infotabla.Rows[0]["email"].ToString();
            comboBox1.DisplayMember = "codeUser";
            comboBox1.ValueMember = "idUser";
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            if (Comprobar_AppConf() && Comprobar_BBDD())
            {
                delete_btn.Visible = true;
            }
            else if (Comprobar_BBDD())
            {
                reg_btn.Visible = true;
            } else
            {
                this.Close();
            }
        }


        private bool Comprobar_AppConf()
        {
            string key = "TrustedUser", value = comboBox1.Text;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            check_btn.Visible = false;
            if (config.AppSettings.Settings[key].Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Comprobar_BBDD()
        {
            string tabla = "trusteddevices";
            string consulta = "select * from " + tabla + " where MAC = '" + textBox1.Text + "' AND HostName = '" + textBox2.Text + "'";
            DataTable table_bbdd = dat.PortarPerConsulta(consulta).Tables[0];

            if (table_bbdd.Rows.Count > 0)
            {
                iddevice = table_bbdd.Rows[0]["iddevice"].ToString();
                return true;
            }
            else
            {               
                return false;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string key = "TrustedUser", value = "";
            string user = comboBox1.Text;
            AddSetting(key, value);
            string titulo = "USER DELETED", texto = "User: " + user + " has been deleted succesfully";
            MessageBox.Show(texto, titulo);
            this.Close();
        }
    }
}
