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

namespace planets
{
    public partial class planets : Form_Base.Form_base
    {
        public planets()
        {
            InitializeComponent();
            tabla = "planets";
            dtg_head = new string[13] { "Id", "Codigo", "Descripcion", "Id Sector", "Longitud", "Latitud", "Parsecs",
                "Id Specie", "Id Filiacion", "Imagen", "IP", "Puerto", "Puerto*"};
        }
    }
}
