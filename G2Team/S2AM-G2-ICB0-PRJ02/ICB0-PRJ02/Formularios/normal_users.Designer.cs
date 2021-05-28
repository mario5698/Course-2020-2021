namespace Formularios
{
    partial class normal_users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl3 = new System.Windows.Forms.Label();
            this.user_name_swtxb = new BlibliotecaG2.SWTextbox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl3.Location = new System.Drawing.Point(350, 268);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(142, 29);
            this.lbl3.TabIndex = 186;
            this.lbl3.Text = "User_Name";
            // 
            // user_name_swtxb
            // 
            this.user_name_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_name_swtxb.ControllID = null;
            this.user_name_swtxb.dada = null;
            this.user_name_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.user_name_swtxb.Foranea = false;
            this.user_name_swtxb.Location = new System.Drawing.Point(532, 269);
            this.user_name_swtxb.Name = "user_name_swtxb";
            this.user_name_swtxb.Nom_BBDD = "username";
            this.user_name_swtxb.obligatorio = false;
            this.user_name_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_name_swtxb.TabIndex = 185;
            this.user_name_swtxb.Tag = "";
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Location = new System.Drawing.Point(857, 14);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(388, 325);
            this.pic.TabIndex = 187;
            this.pic.TabStop = false;
            // 
            // normal_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.user_name_swtxb);
            this.Controls.Add(this.pic);
            this.Name = "normal_users";
            this.Text = "normal_users";
            this.Controls.SetChildIndex(this.pic, 0);
            this.Controls.SetChildIndex(this.user_name_swtxb, 0);
            this.Controls.SetChildIndex(this.lbl3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private BlibliotecaG2.SWTextbox user_name_swtxb;
        private System.Windows.Forms.PictureBox pic;
    }
}