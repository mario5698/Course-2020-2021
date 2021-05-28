using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Base;

namespace species
{
    public partial class species : Form_Base.Form_base
    {
        public species()
        {
            InitializeComponent();
            tabla = "species";
            dtg_head = new string[2] { "Codigo Specie", "Descripcion Specie" };
            has_pass = false;
        }
    }
}
