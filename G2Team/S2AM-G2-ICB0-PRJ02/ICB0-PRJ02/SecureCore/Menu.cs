using Acceso_Dades;
using BlibliotecaG2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios; 

namespace SecureCore
{
    public partial class Menu : Form
    {
        Acceso acc = new Acceso();
        // Declaracion de variables 
        bool Hide_Panel = false;
        int Max_Size = 200, Min_Size = 0;
        Form Inuse;
        public Menu(String user, String rango)
        {
            InitializeComponent();
            traerForms(rango);
            lblUser.Text = user;
            Welcome myForm = new Welcome(user);
            Inuse = myForm;
            ShowFroms(myForm);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Hide_panel_left(Hide_Panel);
        }

        private void traerForms(string rango)
        {
            string tabla = "forms";
            string consulta = "select * from " + tabla + " where Rank <= " + rango;
            DataSet dts = acc.PortarPerConsulta(consulta, tabla);
            int numeroForms = dts.Tables[tabla].Rows.Count;
            string dll , FormName ,Nombre ;

            for (int i = 0; i < numeroForms; i++)
            {
                dll = dts.Tables[0].Rows[i]["Namespace"].ToString();
                FormName = dts.Tables[0].Rows[i]["Form"].ToString();
                Nombre = dts.Tables[0].Rows[i]["Name"].ToString();
                if (!(Int32.Parse(rango) >= 100 && FormName == "normal_users"))
                {
                    loadForm(dll, FormName, Nombre);
                }
            }
        }

        private void loadForm(string dll, string FormName, string Nombre)
        {
            Object dllBD;
            Assembly ensamblat = Assembly.LoadFrom(dll + " .dll");
            Type tipus = ensamblat.GetType(dll + "." + FormName);
            dllBD = Activator.CreateInstance(tipus);
            Form formulario = (Form)dllBD;
            create(formulario, Nombre);
        }

        Button create(Form newFormulario, string Nombre)
        {
            Button myButton = new Button();
            myButton.Text = Nombre;
            pnl_left.Controls.Add(myButton);
            myButton.Dock = DockStyle.Top;
            myButton.FlatStyle = FlatStyle.Flat;
            myButton.ForeColor = Color.PaleGreen;
            myButton.Size = new Size(200, 79);
            myButton.Click += new EventHandler((sender, e) => myButton_click(sender, e, newFormulario));
            return myButton;
        }

        private void myButton_click (object sender, EventArgs e, Form frm)
        {
            ShowFroms(frm);
        }

        private void Hide_panel_left(bool  hide_panel) 
        {
            int speed = 25;

            if (hide_panel != true)
            {
                for (int i = Max_Size; i >= Min_Size; i-=speed)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                    Inuse.Size = new Size(pnl_rigth.Width + i+1, pnl_rigth.Height);
                }
                
                Hide_Panel = true;
            }
            else
            {
                for (int i = Min_Size; i <= Max_Size; i+=speed)
                {
                    pnl_left.Size = new Size(i, pnl_left.Height);
                }
                Hide_Panel = false;
            }
        }

        private void ShowFroms( Form myForm ) 
        {
            Inuse = myForm;
            pnl_rigth.Controls.Clear();
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            myForm.Size = new Size(pnl_rigth.Width, pnl_rigth.Height);
            pnl_rigth.Controls.Add(myForm);
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.Busqueda formulario = new Formularios.Busqueda();
            ShowFroms(formulario);
        }
    }
}
