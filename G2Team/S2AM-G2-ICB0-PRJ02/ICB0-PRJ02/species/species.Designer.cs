namespace species
{
    partial class species
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.user_cod_swtxb = new BlibliotecaG2.SWTextbox();
            this.desc_planet_swtxb = new BlibliotecaG2.SWTextbox();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl2.Location = new System.Drawing.Point(318, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 29);
            this.lbl2.TabIndex = 233;
            this.lbl2.Text = "Specie_Code";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl3.Location = new System.Drawing.Point(326, 258);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(157, 29);
            this.lbl3.TabIndex = 235;
            this.lbl3.Text = "Desc_Specie";
            // 
            // user_cod_swtxb
            // 
            this.user_cod_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user_cod_swtxb.ControllID = null;
            this.user_cod_swtxb.dada = null;
            this.user_cod_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.user_cod_swtxb.Foranea = false;
            this.user_cod_swtxb.Location = new System.Drawing.Point(519, 195);
            this.user_cod_swtxb.Name = "user_cod_swtxb";
            this.user_cod_swtxb.Nom_BBDD = "codespecie";
            this.user_cod_swtxb.obligatorio = false;
            this.user_cod_swtxb.Size = new System.Drawing.Size(127, 26);
            this.user_cod_swtxb.TabIndex = 224;
            this.user_cod_swtxb.Tag = "";
            // 
            // desc_planet_swtxb
            // 
            this.desc_planet_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.desc_planet_swtxb.ControllID = null;
            this.desc_planet_swtxb.dada = null;
            this.desc_planet_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.desc_planet_swtxb.Foranea = false;
            this.desc_planet_swtxb.Location = new System.Drawing.Point(519, 259);
            this.desc_planet_swtxb.Name = "desc_planet_swtxb";
            this.desc_planet_swtxb.Nom_BBDD = "descspecie";
            this.desc_planet_swtxb.obligatorio = false;
            this.desc_planet_swtxb.Size = new System.Drawing.Size(127, 26);
            this.desc_planet_swtxb.TabIndex = 225;
            this.desc_planet_swtxb.Tag = "";
            // 
            // species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.user_cod_swtxb);
            this.Controls.Add(this.desc_planet_swtxb);
            this.Name = "species";
            this.Text = "species";
            this.Controls.SetChildIndex(this.desc_planet_swtxb, 0);
            this.Controls.SetChildIndex(this.user_cod_swtxb, 0);
            this.Controls.SetChildIndex(this.lbl3, 0);
            this.Controls.SetChildIndex(this.lbl2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private BlibliotecaG2.SWTextbox user_cod_swtxb;
        private BlibliotecaG2.SWTextbox desc_planet_swtxb;
    }
}