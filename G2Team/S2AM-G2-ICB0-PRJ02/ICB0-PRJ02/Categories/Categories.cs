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

namespace Categories
{
    public partial class Categories : Form
    {
        CategoriesEntities db;
        List<UserCategory> rn;
        bool nuevo = false;
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            Carregar_Dades();
            Fer_Binding();
        }
        private void Carregar_Dades()
        {
            db = new CategoriesEntities();
            rn = db.UserCategories.ToList();
            dtgUsers.DataSource = rn;
        }

        private void Treu_Binding()
        {
            cancel.Show();
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                }
            }
        }

        private void Fer_Binding()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", rn, ((SWTextbox)ctr).Nom_BBDD.ToString());
                    ctr.Validated += new System.EventHandler(this.ValidarTextBox);
                }
            }
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!nuevo)
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void Actualizar_Base_Click(object sender, EventArgs e)
        {
            UserCategory cat = null;
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
                            cat = new UserCategory
                            {
                                CodeCategory = code_swtbx.Text,
                                DescCategory = desc_swtbx.Text,
                                AccessLevel = int.Parse(access_swtbx.Text)
                            };
                        }
                    }
                }
                if (!vacios)
                {
                    db.UserCategories.Add(cat);
                    nuevo = false;
                    db.SaveChanges();
                    Carregar_Dades();
                    Fer_Binding();
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
                db.SaveChanges();
                Carregar_Dades();
                Fer_Binding();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            nuevo = true;
            Treu_Binding();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Fer_Binding();
            cancel.Hide();
        }
    }
}
