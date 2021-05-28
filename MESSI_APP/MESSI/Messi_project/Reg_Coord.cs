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
    public partial class Reg_Coord : Form_Base
    {
        Acceso acc = new Acceso();
        int contador = 0;
        public Reg_Coord()
        {
            InitializeComponent();
        }
        private void Generar_Dic()
        {
            DataRow row;
            Dictionary<string, string> coordanates = new Dictionary<string, string>();
            string num_format = "";
            int vueltas = 0;
            bool comprobar = true;
            for (int s = 1; s <= 5; s++)
            {
                for (char c = 'A'; c <= 'D'; c++)
                {
                    num_format = Agregar_Num();
                    while (comprobar)
                    {
                        vueltas = vueltas + 1;
                        comprobar = coordanates.ContainsValue(num_format);
                        if (comprobar)
                        {
                            num_format = Agregar_Num();
                        } else
                        {
                            comprobar = false;
                        }
                    }
                    comprobar = true;
                    string key = c.ToString() + s.ToString();
                    coordanates.Add(key, num_format);
                }
            }
            string tabla = "AdminCoordinates";
            string delete = "delete from " + tabla;
            acc.Ejecutar(delete);
            DataTable infotabla = acc.PortarTaula(tabla);


            for (int i = 0; i < coordanates.Count; i++)
            {
                row = infotabla.NewRow();
                row["Coordinate"] = coordanates.ElementAt(i).Key;
                row["Value"] = coordanates.ElementAt(i).Value;
                infotabla.Rows.Add(row);
            }
            string consulta = "select * from " + tabla;
            acc.Actualitzar(consulta);
          //  textBox1.Text = textBox1.Text + "VUELTAS: " + vueltas.ToString();
        }
        private string Agregar_Num()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 9999);
            string num_format = dar_formato_random(r);
            return num_format;
        }


        private string dar_formato_random(int r)
        {
            string ran = r.ToString();
            int longitud = ran.Length;
            for (int i = longitud; i < 4; i++)
            {
                ran = "0" + ran;
            }
            return ran;
        }

        private void gen_btn_Click(object sender, EventArgs e)
        {
            dtg_coord.DataSource = null;
            Generar_Dic();
            last_gen.Hide();
            date.Hide();
            loading.Visible = true;
            contador = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos_Coor();
            last_gen.Hide();
            date.Hide();
        }

        private void Datos_Coor()
        {
            string tabla = "admincoordinates";
            DataTable coord_table = acc.PortarTaula(tabla);
            dtg_coord.DataSource = coord_table;
            dtg_coord.Columns[0].Visible = false;
        }


        private void Reg_Coord_Load(object sender, EventArgs e)
        {
            Datos_Coor();
            last_gen.Hide();
            date.Hide();
            last_gen.Text = "LAST COORDINATES GENERATION ON";
            date.Text = DateTime.Now.ToString();
            loading.Visible = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador += 1;
            if (contador == 4)
            {
                loading.Visible = false;
                last_gen.Show();
                date.Show();
            }
        }

        private void last_gen_Click(object sender, EventArgs e)
        {

        }
    }
}
