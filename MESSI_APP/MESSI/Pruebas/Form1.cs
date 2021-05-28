using BlibliotecaG2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Linq;



namespace Pruebas
{
    public partial class Form1 : Form
    {
        int contador;


        private void Form1_Load(object sender, EventArgs e)
        {
                this.chart1.Series.Clear();
                Series serie = this.chart1.Series.Add("Resultado");
                serie.ChartType = SeriesChartType.Spline;
                chart1.ChartAreas[0].AxisX.Maximum = 1100;
                chart1.ChartAreas[0].AxisY.Maximum = 30000;
        }
        private double math(double x)
        {
           return (Math.Pow(Math.E, x / 100.0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          contador++;
           if (contador <25)
           {
                MessageBox.Show(math(contador).ToString());
            }
            else if (contador ==25)
            {
                MessageBox.Show(math(contador).ToString());
                contador = 0;
            }
        }
    }
}

    