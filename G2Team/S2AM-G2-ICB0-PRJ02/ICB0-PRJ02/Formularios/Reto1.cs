using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Reto1 : Form
    {
        public Reto1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numBestreta = 0;
            int numDespesa = 0;

            if (txtBestreta.Text != "")
            {
                numBestreta = int.Parse( txtBestreta.Text);
            }

            if (txtDespesa.Text != "")
            {
                numDespesa = int.Parse(txtDespesa.Text);
            }

            int resultado = numDespesa - numBestreta;

            txtResult.Text = resultado.ToString();

            if (resultado > 200)
            {
                txtResult.ForeColor = Color.White;
                txtResult.BackColor = Color.Orange;
            }
            else if (resultado >= 0)
            {
                txtResult.ForeColor = Color.Black;
                txtResult.BackColor = Color.Yellow;
            }
            else
            {
                txtResult.ForeColor = Color.White;
                txtResult.BackColor = Color.Red;
            }

            if (numBestreta > numDespesa)
            {
                txtBestreta.ForeColor = Color.White;
                txtBestreta.BackColor = Color.Red;
            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text == "MAGA")
            {
                txtNombre.Text = "Manuel garcía Viu";
                txtDepratamento.Text = "Comercial";
                txtBestreta.Text = "120";
                e.Cancel = true;
            }
            else
            {
                txtNombre.Text = "Usuari desconegut";
                txtDepratamento.Text = "";
                e.Cancel = false;
            }
        }

        private void txtBestreta_Validating(object sender, CancelEventArgs e)
        {
           if (txtBestreta.Text != "") {
                if (int.Parse(txtBestreta.Text) > 120)
                {
                    txtBestreta.ForeColor = Color.White;
                    txtBestreta.BackColor = Color.Red;
                }
            }
        }
    }
}
