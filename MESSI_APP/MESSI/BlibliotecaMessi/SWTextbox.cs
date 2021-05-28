using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlibliotecaG2
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
             
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.GotFocus += new System.EventHandler(this.SWTextbox_Enter);
            this.LostFocus += new System.EventHandler(this.SWTextbox_leave);
            this.ResumeLayout(false);
            }

        #region Declaracion Variables
        public enum TipusDada
        {
            Text,
            Data,
            Codi
        }
        bool _Foranea,_Obligatorio; 

        TipusDada TipusData;
        private TipusDada _DadaPermesa;
        private string datos;
        String _NombreBBDD;

        #endregion

        #region Entrada Eventos
        public bool obligatorio
        {
            get { return _Obligatorio; }
            set { _Obligatorio = value; }
        }

        public String Nom_BBDD
        {
            get { return _NombreBBDD; }
            set { _NombreBBDD = value; }
        }

        public bool Foranea
        {
            get { return _Foranea; }
            set { _Foranea = value; }
        }

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
                TipusData = value;
            }
        }

        public String _dada
        {
            get { return datos; }
            set { datos = value; }
        }
        #endregion 



        #region Validacion de entrada
        private void SWTextbox_Validate(TipusDada dada)
        {
            if (dada == TipusDada.Data)
            {
                DateTime _val;
                bool fecha = DateTime.TryParse(datos, out _val);
            
                if (!fecha)
                {                  
                  MessageBox.Show("data invalida");
                }
            }
           
        }
        #endregion

        private void SWTextbox_leave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            if (_Obligatorio && (_dada == ""))
            {
                MessageBox.Show("obligatorio");
            }
            else
            {
                SWTextbox_Validate(TipusData);

            }
        }
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
