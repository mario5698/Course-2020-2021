using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M_E_S_S_I;
using Acceso_Dades;

namespace MESSI
{
    public partial class Encriptar : Form_Base
    {
        Acceso dat = new Acceso();
        public Encriptar()
        {
            InitializeComponent();
        }

        private void op1_c1_Click(object sender, EventArgs e)
        {
            dat.Encriptar();
            encrypt_lbl.Text = "ENCRIPTED";
            Centrar(encrypt_lbl);
        }

        private void Encriptar_Load(object sender, EventArgs e)
        {
            encrypt_lbl.Text = "NO ENCRIPTED";
            Centrar(encrypt_lbl);
        }

        private int Centrar(Control texto) => texto.Left = (panel1.Width - texto.Width) / 2;
    }
}
