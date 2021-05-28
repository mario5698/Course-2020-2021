using Acceso_Dades;
using BlibliotecaG2;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Busqueda : Form
    {
        Acceso obj;
        string consulta;
        string tabla;
        bool nuevo = false;
        DataTable infotabla;

        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            obj = new Acceso();
            infotabla = obj.PortarPerConsulta("select * from species").Tables[0];
            dgw.DataSource = infotabla;
            tabla = "species";
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!nuevo)
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
        }

        private void Bind()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(SWTextbox))
                {
                    ctr.BackColor = Color.PaleGreen;
                    ctr.ForeColor = Color.FromArgb(50, 60, 70);
                    ctr.DataBindings.Clear();
                    ctr.Text = string.Empty;
                    ctr.DataBindings.Add("Text", infotabla, ((SWTextbox)ctr).Nom_BBDD.ToString()); //((SWTextbox)ctr).Nom_BBDD.ToString());
                    ctr.Validated += new System.EventHandler(ValidarTextBox);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool where = true;
            consulta = "select * from " + tabla;
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(SWTextbox))
                {
                    if (c.Text != "")
                    {
                        consulta += where ? " where " : " and ";
                        consulta += ((SWTextbox)c).Nom_BBDD.ToString() + " = " + "'" + c.Text + "'";
                        if (where) where = false;
                    }
                }
            }
            infotabla = obj.PortarPerConsulta(consulta).Tables[0];
            dgw.DataSource = infotabla;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(SWTextbox)) c.Text = "";
            }
        }
    }
}
