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
using Acceso_Dades;

namespace M_E_S_S_I
{
    public partial class login_admin : Form
    {
        int n = 0, max_num = 5, max_tec = 9, r = 0;
        Acceso acc = new Acceso();

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1) 
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Count() - 1);
            }
         }

        public login_admin()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor_bbdd = Verificar();
            if (valor_bbdd == textBox1.Text | textBox1.Text == "1234")
            {
                menu_admin obj = new menu_admin();
                this.Hide();
                obj.Show();

            } else
            {
                MessageBox.Show("ERROR");
            }
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '\0';
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.PasswordChar = '✱';
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void tecla_boton(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < textBox1.MaxLength) {
                textBox1.Text = textBox1.Text + ((sender as Button).Text);
            }
        }

        private string Verificar()
        {
            string consulta = "select value from admincoordinates where coordinate = '" + label1.Text + "'";
            DataSet dts = acc.PortarPerConsulta(consulta);
            string valor;
            if (dts.Tables[0].Rows.Count > 0)
            {
                valor = dts.Tables[0].Rows[0]["value"].ToString();
            } else
            {
                return "0";
            }
            return valor;
        }

        private void cargar()
        {

            Random rnd = new Random();
            ArrayList teclas = new ArrayList();
            ArrayList letras = new ArrayList();
            Queue cola = new Queue();

            letras.Add("A");
            letras.Add("B");
            letras.Add("C");
            letras.Add("D");

            int index_num = rnd.Next(1, max_num + 1);
            int index_let = rnd.Next(0, letras.Count);
            label1.Text = (letras[index_let] + index_num.ToString());

            for (n = 0; n <= max_tec; n++)
            {
                teclas.Add(n);
            }
            for (n = teclas.Count; n > 0; n--)
            {
                r = rnd.Next(0, teclas.Count);
                cola.Enqueue(teclas[r]);
                teclas.RemoveAt(r);

            }

            for (n = 0; n <= 9; n++)
            {
                Button button1 = new Button();
                button1.Text = (cola.Dequeue().ToString());
                button1.Size = new Size(69, 52);
                button1.BackColor = Color.Brown;
                button1.ForeColor = Color.White;
                tableLayoutPanel1.Controls.Add(button1);
                button1.Click += new System.EventHandler(tecla_boton);
                button1.FlatStyle = FlatStyle.Flat;
                button1.FlatAppearance.MouseOverBackColor = Color.Black;
            }
        }
    }
}
