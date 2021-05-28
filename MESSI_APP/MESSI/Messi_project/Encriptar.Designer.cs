namespace MESSI
{
    partial class Encriptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encriptar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.encrypt_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.op1_c1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 1000);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // encrypt_lbl
            // 
            this.encrypt_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encrypt_lbl.AutoSize = true;
            this.encrypt_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.encrypt_lbl.ForeColor = System.Drawing.Color.White;
            this.encrypt_lbl.Location = new System.Drawing.Point(833, 232);
            this.encrypt_lbl.Name = "encrypt_lbl";
            this.encrypt_lbl.Size = new System.Drawing.Size(0, 46);
            this.encrypt_lbl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.op1_c1);
            this.panel1.Controls.Add(this.encrypt_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 300);
            this.panel1.TabIndex = 35;
            // 
            // op1_c1
            // 
            this.op1_c1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.op1_c1.BackColor = System.Drawing.Color.Brown;
            this.op1_c1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.op1_c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.op1_c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.op1_c1.ForeColor = System.Drawing.Color.White;
            this.op1_c1.Location = new System.Drawing.Point(763, 14);
            this.op1_c1.Name = "op1_c1";
            this.op1_c1.Size = new System.Drawing.Size(394, 200);
            this.op1_c1.TabIndex = 36;
            this.op1_c1.Text = "ENCRYPT";
            this.op1_c1.UseVisualStyleBackColor = false;
            this.op1_c1.Click += new System.EventHandler(this.op1_c1_Click);
            // 
            // Encriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Encriptar";
            this.Text = "Encriptar";
            this.Load += new System.EventHandler(this.Encriptar_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label encrypt_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button op1_c1;
    }
}