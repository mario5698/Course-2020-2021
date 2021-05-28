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
using Acceso_Dades;

namespace Formularios
{
    public partial class normal_users : Form_Base.Form_base
    {
        DataGridView dtgUsers;
        Acceso con = new Acceso();
        public normal_users()
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
                        dtgUsers = (DataGridView)ctr;
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

                    if (nuevo) row["photo"] = imgBytes;
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
        }
    }