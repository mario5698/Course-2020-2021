using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTPServer;
using DownloadFromFtp;
using System.Diagnostics;
using System.IO;
namespace Edi_Proces
{
    public partial class Edi : Form
    {
        FTP_Propierties ftp_p = new FTP_Propierties();
        Program dwnl = new Program();

        public Edi()
        {
            InitializeComponent();
        }
        //upload
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ftp_p.upload(ofd.FileName, ofd.SafeFileName);
                    MessageBox.Show("Upload Complete");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to Upload file", "Something has gone wrong",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //descarga
        private void button2_Click(object sender, EventArgs e)
        {
            string path = (Path.GetFullPath("."));
            Process.Start(path + "\\DownloadFromFtp.exe");
        }

        private void Edi_Load(object sender, EventArgs e)
        {

        }
        //process
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog prc = new OpenFileDialog();

            try
            {
                if (prc.ShowDialog() == DialogResult.OK)
                {
                    ftp_p.Split(prc.SafeFileName, prc.FileName);
                }
                MessageBox.Show("Process Complete");
            }
            catch (Exception)
            {
                MessageBox.Show("Error to process file", "Something has gone wrong",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}