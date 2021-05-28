using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Acceso_Dades;

namespace M_E_S_S_I
{
    public partial class GestionDispositivos : Form_Base
    {
        Acceso obj = new Acceso();
        
        public GestionDispositivos(String Option)
        {
            InitializeComponent();
        }

        private void GestionDispositivos_Load(object sender, EventArgs e)
        {
            Obtener_Info_Sistema acc = new Obtener_Info_Sistema();
            textBox2.Text = acc.ObtenerHostname();
            textBox1.Text = acc.ObtenerMac();
            Actualizar_Midas();
        }


        private void Actualizar_Midas()
        {
               int long_textbox = textBox2.TextLength * 19;
               textBox1.Width = long_textbox;
               textBox2.Width = long_textbox;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string tabla = "trusteddevices";
            string consulta = "select * from " + tabla + " where MAC = '" + textBox1.Text + "' AND HostName = '" + textBox2.Text + "'";
            DataTable infotabla = obj.PortarPerConsulta(consulta).Tables[0];

            if (Trusted_Device(infotabla))
            {
                DataRow row;
                row = infotabla.NewRow();
                row["MAC"] = textBox1.Text;
                row["HostName"] = textBox2.Text;
                infotabla.Rows.Add(row);
                obj.Actualitzar(consulta);
            } else
            {
                MessageBox.Show("ALREADY EXISTS");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tabla = "trusteddevices";
            string consulta = "select * from " + tabla + " where MAC = '" + textBox1.Text + "' AND HostName = '" + textBox2.Text + "'";
            string delete = "delete from " + tabla + " where MAC = '" + textBox1.Text + "' AND HostName = '" + textBox2.Text + "'";
            DataTable infotabla = obj.PortarPerConsulta(consulta).Tables[0];

            if (Trusted_Device(infotabla))
            {
                MessageBox.Show("DOESN'T EXISTS");
            }
            else
            {
                obj.Ejecutar(delete);
            }
        }

        private bool Trusted_Device(DataTable infotabla)
        {
            if (infotabla.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
