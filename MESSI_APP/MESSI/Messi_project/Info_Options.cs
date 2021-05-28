using BlibliotecaG2;
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
using System.Xml;
using System.Xml.Linq;
using M_E_S_S_I;
using System.Windows;

namespace MESSI
{
    public partial class Info_Options : Form_Base
    {
        string folder = "";
        public Info_Options()
        {
            InitializeComponent();
        }
        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();

            foreach (DataTable dt in my_DataSet.Tables)
            {
                DataTable table = new DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                { table.Columns.Add(Convert.ToString(i)); }

                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    { r[j] = dt.Rows[j - 1][k]; }
                    table.Rows.Add(r);
                }
                ds.Tables.Add(table);
            }

            return ds;
        }

        private void InfoOption(int id)
        {
            string identificador_titulo = "idOption", padre_titulo = "InfoOption";
            string identificador_texto = "idInfoDetail", padre_texto = "InfoDetail";
            textOption.Text = XML(id, textOption.Tag.ToString(), identificador_titulo, padre_titulo);
            text_info.Text = XML(id, text_info.Tag.ToString(), identificador_texto, padre_texto);
     
        }

        private void ListBox_Fill()
        {
            XElement options = XElement.Load("..\\MESSI\\images\\Info.xml");
            foreach (XElement xEle in options.Descendants("textOption"))
            {
                listBox1.Items.Add(xEle.Value);
            }
        }

        private void InfoDetail(int id)
        {
            string identificador = "idInfoDetail", padre = "InfoDetail";
            string image;
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(PictureBox))
                {

                    if (ctr.Tag.ToString() == "View360")
                    {
                        String video;
                        image = XML(id, ctr.Tag.ToString(), identificador, padre);
                        ((PictureBox)ctr).Image = Image.FromFile("..\\MESSI\\images\\" + folder + "\\" + image);

                        video = XML(id, "GeneralView", identificador, padre);
                        ctr.Click += new EventHandler((sender, e) => PlayVideo(sender, e, video));

                    }
                    else
                    {
                        image = XML(id, ctr.Tag.ToString(), identificador, padre);
                        ((PictureBox)ctr).Image = Image.FromFile("..\\MESSI\\images\\" + folder + "\\" + image);
                        ctr.Click += new EventHandler((sender, e) => ctr_click(sender, e, ((PictureBox)ctr).Image));

                    }



                }
            }
        }

        private void PlayVideo(object sender, EventArgs e, String video)
        {
            String ruta = Application.StartupPath;
            ruta += "Videos" + video;
            MessageBox.Show(video);
            axWindowsMediaPlayer1.URL = ruta;            
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void ctr_click(object sender, EventArgs e, Image imagen)
        {
            big_image.Image = imagen;
        }
        private void Data(int id)
        {
            Data_Linq(id);
            DataSet dts = new DataSet();
            dts.ReadXml("..\\ejecutables\\Data_" + id + ".xml");
            dataGridView1.DataSource = FlipDataSet(dts).Tables[0];
            dataGridView1.Columns[0].HeaderText = "DATA";
            dataGridView1.Columns[1].HeaderText = "VALUE";
        }

        private string XML(int id, string campo, string identificador, string padre)
        {
            XElement doc = null;
            doc = XElement.Load("..\\MESSI\\images\\Info.xml");

            string alu = (from a in doc.Descendants(padre)
                          where (int)a.Element(identificador) == id
                          select a.Element(campo).Value).SingleOrDefault();
            return alu;
        }

        private void Data_Linq(int id)
        {
            XElement doc = null;
            doc = XElement.Load("..\\MESSI\\images\\Info.xml");

            XElement alu = (from a in doc.Descendants("InfoDetail")
                            where (int)a.Element("idInfoDetail") == id
                            select a.Element("Data")).SingleOrDefault();

            alu.Save("Data_" + id + ".xml");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Info_Options_Load(object sender, EventArgs e)
        {
            ListBox_Fill();
            axWindowsMediaPlayer1.uiMode = "None";
            axWindowsMediaPlayer1.URL = @"C:\Users\Miguel\Desktop\GitHub\MESSI_APP\MESSI\images\Tie-Advanced\TieAdvadced.mp4";
            axWindowsMediaPlayer1.settings.setMode("Loop", true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBox1.SelectedIndex;
            folder = listBox1.SelectedItem.ToString();
            InfoOption(id);
            InfoDetail(id);
            Data(id);
            GetPdf(folder, id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {}

        

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }


        private void GetPdf(String carpeta, int id)
        {
            string identificador = "idInfoDetail", padre = "InfoDetail";
            string pdf;
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(PictureBox))
                {
                    pdf = XML(id, "pdfFile", identificador, padre);
                    axAcroPDF1.LoadFile("..\\MESSI\\images\\" + carpeta + "\\" + pdf);
                }
            }
        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void text_info_TextChanged(object sender, EventArgs e)
        {

        }
    }
}