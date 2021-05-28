using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form2 : Form
    {
        int contador;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

        private double math(double x)
        {
            return (Math.Pow(Math.E, x / 100.0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador < 25)
            {
                Console.WriteLine(math(contador).ToString());
            }
            else if (contador == 25)
            {
                Console.WriteLine(math(contador).ToString());
                contador = 0;
            }
        }
    }
}
