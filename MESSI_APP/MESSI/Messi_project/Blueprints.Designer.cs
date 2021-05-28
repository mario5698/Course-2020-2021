namespace MESSI
{
    partial class Blueprints
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blueprints));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_C3 = new BlibliotecaG2.Panel_C(this.components);
            this.panel_C1 = new BlibliotecaG2.Panel_C(this.components);
            this.panel_C2 = new BlibliotecaG2.Panel_C(this.components);
            this.C1_img = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_img)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(134, 736);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1573, 325);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1207, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 69);
            this.label1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1156, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel_C3
            // 
            this.panel_C3.BackColor = System.Drawing.Color.Brown;
            this.panel_C3.Location = new System.Drawing.Point(425, 296);
            this.panel_C3.Name = "panel_C3";
            this.panel_C3.Opacity = 60;
            this.panel_C3.Size = new System.Drawing.Size(154, 154);
            this.panel_C3.TabIndex = 16;
            this.panel_C3.Click += new System.EventHandler(this.panel_C3_Click);
            this.panel_C3.MouseLeave += new System.EventHandler(this.panel_C3_MouseLeave);
            this.panel_C3.MouseHover += new System.EventHandler(this.panel_C3_MouseHover);
            // 
            // panel_C1
            // 
            this.panel_C1.BackColor = System.Drawing.Color.Brown;
            this.panel_C1.Location = new System.Drawing.Point(674, 198);
            this.panel_C1.Name = "panel_C1";
            this.panel_C1.Opacity = 60;
            this.panel_C1.Size = new System.Drawing.Size(147, 154);
            this.panel_C1.TabIndex = 15;
            this.panel_C1.Click += new System.EventHandler(this.panel_C1_Click);
            this.panel_C1.MouseLeave += new System.EventHandler(this.panel_C1_MouseLeave);
            this.panel_C1.MouseHover += new System.EventHandler(this.panel_C1_MouseHover);
            // 
            // panel_C2
            // 
            this.panel_C2.BackColor = System.Drawing.Color.Brown;
            this.panel_C2.Location = new System.Drawing.Point(141, 90);
            this.panel_C2.Name = "panel_C2";
            this.panel_C2.Opacity = 60;
            this.panel_C2.Size = new System.Drawing.Size(91, 81);
            this.panel_C2.TabIndex = 14;
            this.panel_C2.Click += new System.EventHandler(this.panel_C2_Click);
            this.panel_C2.MouseLeave += new System.EventHandler(this.panel_C2_MouseLeave);
            this.panel_C2.MouseHover += new System.EventHandler(this.panel_C2_MouseHover);
            // 
            // C1_img
            // 
            this.C1_img.BackColor = System.Drawing.Color.Black;
            this.C1_img.Image = ((System.Drawing.Image)(resources.GetObject("C1_img.Image")));
            this.C1_img.Location = new System.Drawing.Point(134, 79);
            this.C1_img.Name = "C1_img";
            this.C1_img.Size = new System.Drawing.Size(739, 592);
            this.C1_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.C1_img.TabIndex = 13;
            this.C1_img.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Blueprints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_C3);
            this.Controls.Add(this.panel_C1);
            this.Controls.Add(this.panel_C2);
            this.Controls.Add(this.C1_img);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Blueprints";
            this.Text = "Blueprints";
            this.Load += new System.EventHandler(this.Blueprints_Load);
            this.Controls.SetChildIndex(this.C1_img, 0);
            this.Controls.SetChildIndex(this.panel_C2, 0);
            this.Controls.SetChildIndex(this.panel_C1, 0);
            this.Controls.SetChildIndex(this.panel_C3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C1_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BlibliotecaG2.Panel_C panel_C3;
        private BlibliotecaG2.Panel_C panel_C1;
        private BlibliotecaG2.Panel_C panel_C2;
        private System.Windows.Forms.PictureBox C1_img;
        private System.Windows.Forms.Timer timer1;
    }
}