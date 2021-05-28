using Acceso_Dades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlibliotecaG2;
using Controles_Usuario;
using System.IO;

namespace Form_Base
{
    public partial class Form_base : Form
    {
        Acceso obj;
        Encrypt cry;
        public DataTable infotabla;
        protected string tabla;
        protected bool has_pass = false;
        protected bool nuevo = false;
        protected DataRow row;
        string pass_orig;
        protected string[] dtg_head;

        public Form_base()
        {
            InitializeComponent();   
        }

        private void Users_Load(object sender, EventArgs e)
        {

            if (DesignMode) return;
            obj = new Acceso();
            cry = new Encrypt(); 
            Portar_Dades();
            Info_Textbox();
            Dtg_header();
            cancel.Hide();
        }

        private void Portar_Dades()
        {
            infotabla = obj.PortarTaula(tabla);
            dtgUsers.DataSource = infotabla;
        }

        private void Dtg_header()
        {
            for (int i = 0; i < dtg_head.Length; i++)
            {
                dtgUsers.Columns[i].HeaderText = dtg_head[i].ToString();
            }
        }

        private void Info_Textbox()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.BackColor = Color.PaleGreen;
                    ctr.ForeColor = Color.FromArgb(50, 60, 70);
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", infotabla, ((SWTextbox)ctr).Nom_BBDD.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }
        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!nuevo)
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            cancel.Show();
            row = infotabla.NewRow();
            nuevo = true;
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty; 
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Info_Textbox();
            cancel.Hide();
        }

        private void Actualizar_Base_Click(object sender, EventArgs e)
        {
            bool vacios = false;
            if (nuevo)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.GetType() == typeof(SWTextbox))
                    {
                        if (((SWTextbox)ctr).obligatorio && ctr.Text == string.Empty)
                        {
                            vacios = true;
                        }
                        else
                        {
                            row[((SWTextbox)ctr).Nom_BBDD.ToString()] = ctr.Text;
                        }
                    }
                }
                if (!vacios)
                {
                    infotabla.Rows.Add(row);
                    Hash_Pass();
                    nuevo = false;
                    obj.Actualitzar();
                    Portar_Dades();
                    Info_Textbox();
                    cancel.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "CAMPOS OBLIGATORIOS VACIOS O TIPO DE DATO INCORRECTO",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                nuevo = false;
                Hash_Pass();
                obj.Actualitzar();
                Portar_Dades();
                Info_Textbox();
            }
        }

        private void Hash_Pass()
        {
            if (has_pass)
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr.Name == "password_swtxb" && ctr.Text != pass_orig)
                    {
                        byte[] sal = cry.Sal();
                        byte[] pass = cry.Hash(ctr.Text, sal);
                        if (nuevo)
                        {
                            infotabla.Rows[dtgUsers.Rows.Count - 1]["salt"] = cry.ToString(sal);
                            infotabla.Rows[dtgUsers.Rows.Count - 1]["Password"] = cry.ToString(pass);
                            pass_orig = infotabla.Rows[dtgUsers.Rows.Count - 1]["Password"].ToString();
                        }
                        else
                        {
                            infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["salt"] = cry.ToString(sal);
                            infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"] = cry.ToString(pass);
                            pass_orig = infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"].ToString();
                        }
                    }
                }
            }
        }

        private void dtgUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (has_pass)
            {
                pass_orig = infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["Password"].ToString();
            }
        }

        public byte[] imageToByteArray(Image i)
        {
            using (var ms = new MemoryStream())
            {
                i.Save(ms, i.RawFormat);
                return ms.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return Image.FromStream(ms);
            }
        }

        protected void OpenImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                byte[] imgBytes = imageToByteArray(img);
                infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] = imgBytes;

                foreach (Control ctr in Controls)
                {
                    if (ctr.GetType() == typeof(PictureBox))
                    {
                        ctr.BackgroundImage = img;
                    }
                }
            }
        }

        private void ChangeImage(Object sender, EventArgs e)
        {

            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(PictureBox) && dtgUsers.CurrentCell != null &&
                    infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] != DBNull.Value)
                {
                    byte[] b = (byte[])infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"];
                    ctr.BackgroundImage = byteArrayToImage(b);
                }
            }
        }
    }
}
    
