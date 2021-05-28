using BlibliotecaG2;
using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using M_E_S_S_I;

namespace MESSI
{
    public partial class Blueprints : Form_Base
    {
        int contador = 1;
        ArrayList Img = new ArrayList();
        ArrayList Title = new ArrayList();
        ArrayList Txt = new ArrayList();

        public Blueprints()
        {
            InitializeComponent();
        }

        private void Blueprints_Load(object sender, EventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(Panel_C))
                {
                    ctr.Hide();
                }
            }
            XML();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(Panel_C))
                {
                    if (contador % 2 == 0)
                    {
                        ctr.Show();
                    }
                    else
                    {
                        ctr.Hide();
                    }
                }
            }
        }

        private void panel_C1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel_C2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void panel_C3_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel_C2_MouseHover(object sender, EventArgs e)
        {
            Control_Paneles();
        }

        private void panel_C3_MouseHover(object sender, EventArgs e)
        {
            Control_Paneles();
        }

        private void panel_C1_MouseHover(object sender, EventArgs e)
        {
            Control_Paneles();
        }

        private void Control_Paneles()
        {
            timer1.Stop();
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(Panel_C))
                {
                    ctr.Show();
                }
            }
            panel_C2.Show();
            panel_C1.Show();
        }

        private void panel_C1_Click(object sender, EventArgs e)
        {
            Imagen(Img[0].ToString(), Title[0].ToString(), Txt[0].ToString());
        }

        private void panel_C2_Click(object sender, EventArgs e)
        {
            Imagen(Img[2].ToString(), Title[2].ToString(), Txt[2].ToString());
        }

        private void panel_C3_Click(object sender, EventArgs e)
        {
            Imagen(Img[1].ToString(), Title[1].ToString(), Txt[1].ToString());
        }

        private void Imagen(string img, string titulo, string texto)
        {
            pictureBox1.Image = Image.FromFile("..\\MESSI\\images\\StarKiller\\" + img);
            label1.Text = titulo;
            textBox1.Text = texto;
        }

        private void XML()
        {
            Img = Array_List("imageDetail");
            Title = Array_List("title");
            Txt = Array_List("textDetail");
        }

        private ArrayList Array_List(string elemento)
        {
            int i = 0;
            ArrayList array = new ArrayList();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\MESSI\\images\\Info.xml");
            XmlNodeList xPersonas = xDoc.GetElementsByTagName("Details");
            XmlNodeList xLista = ((XmlElement)xPersonas[0]).GetElementsByTagName("Detail");

            foreach (XmlElement nodo in xLista)
            {
                XmlNodeList xelement = ((XmlElement)xLista[i]).GetElementsByTagName(elemento);
                i++;
                foreach (XmlElement el in xelement)
                {
                    string xNombre = el.InnerText;
                    array.Add(xNombre);
                }
            }
            return array;
        }
    }
}
