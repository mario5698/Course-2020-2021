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

namespace menuOptions
{
    public partial class menuOptions : Form_Base.Form_base
    {
        public menuOptions()
        {
            InitializeComponent();
            tabla = "forms";
            dtg_head = new string[6] { "Id", "Rango", "NameSpace", "Form", "Nombre", "Descripcion"};
        }
    }
}
