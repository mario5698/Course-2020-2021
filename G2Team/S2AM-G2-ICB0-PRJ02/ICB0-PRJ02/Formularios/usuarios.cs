using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Dades;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;


namespace Formularios
{
    public partial class usuarios : Form_Base.Form_base
    {
        DataGridView dtgUsers;
        Acceso con = new Acceso();
        public usuarios()
        {
            InitializeComponent();
            tabla = "users";
            has_pass = true;
            dtg_head = new string[11] { "Id", "Codigo", "Nombre", "Login", "Contraseña", "Sal",
                "Rango", "Id Categoria", "Imagen", "Id Planeta", "Id Specie"};

            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(DataGridView))
                {
                    dtgUsers = (DataGridView) ctr;
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenImage(nuevo);
        }

        private void OpenImage(bool nuevo)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                byte[] imgBytes = imageToByteArray(img);

                if(nuevo) row["photo"] = imgBytes;
                else infotabla.Rows[dtgUsers.CurrentCell.RowIndex]["photo"] = imgBytes;

                foreach (Control ctr in Controls)
                {
                    if (ctr.GetType() == typeof(PictureBox))
                    {
                        ctr.BackgroundImage = img;
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            ConnectionInfo connectionInfo = new ConnectionInfo();
            TableLogOnInfo logonInfo = new TableLogOnInfo();
            int printerId = 0;

            string path = (Path.GetFullPath("."));
            report.Load(path + "\\card.rpt");
            connectionInfo.ServerName = "DESKTOP-2991IQ4\\SQLEXPRESS";
            connectionInfo.DatabaseName = "SecureCore";
            connectionInfo.IntegratedSecurity = true;
            Tables tables = report.Database.Tables;

            foreach (Table table in tables)
            {
                logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(logonInfo);
            }

            report.RecordSelectionFormula = "{Command.idUser} = " + int.Parse(infotabla.Rows[dtgUsers.CurrentRow.Index][0].ToString());

            do printerId++;
            while (PrinterSettings.InstalledPrinters[printerId] != "Microsoft Print to PDF");

            report.ExportToDisk(ExportFormatType.PortableDocFormat, ".\\card.pdf");
        }
    }
}
