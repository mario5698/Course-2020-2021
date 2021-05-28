namespace MESSI
{
    partial class Reg_Coord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Coord));
            this.gen_btn = new System.Windows.Forms.Button();
            this.retroceder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtg_coord = new System.Windows.Forms.DataGridView();
            this.last_gen = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_coord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // gen_btn
            // 
            this.gen_btn.BackColor = System.Drawing.Color.Brown;
            this.gen_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gen_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.gen_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.gen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gen_btn.ForeColor = System.Drawing.Color.White;
            this.gen_btn.Location = new System.Drawing.Point(211, 100);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(156, 44);
            this.gen_btn.TabIndex = 117;
            this.gen_btn.Text = "GENERATE";
            this.gen_btn.UseVisualStyleBackColor = false;
            this.gen_btn.Click += new System.EventHandler(this.gen_btn_Click);
            // 
            // retroceder
            // 
            this.retroceder.BackColor = System.Drawing.Color.Brown;
            this.retroceder.Dock = System.Windows.Forms.DockStyle.Left;
            this.retroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroceder.ForeColor = System.Drawing.Color.White;
            this.retroceder.Location = new System.Drawing.Point(0, 0);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(69, 49);
            this.retroceder.TabIndex = 119;
            this.retroceder.Text = "↩";
            this.retroceder.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 44);
            this.button2.TabIndex = 120;
            this.button2.Text = "SHOW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MESSI.Properties.Resources.coordenates;
            this.pictureBox1.Location = new System.Drawing.Point(795, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 1000);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // dtg_coord
            // 
            this.dtg_coord.AllowUserToAddRows = false;
            this.dtg_coord.AllowUserToDeleteRows = false;
            this.dtg_coord.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_coord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_coord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_coord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_coord.GridColor = System.Drawing.Color.Brown;
            this.dtg_coord.Location = new System.Drawing.Point(230, 173);
            this.dtg_coord.Name = "dtg_coord";
            this.dtg_coord.ReadOnly = true;
            this.dtg_coord.RowHeadersVisible = false;
            this.dtg_coord.RowHeadersWidth = 62;
            this.dtg_coord.RowTemplate.Height = 28;
            this.dtg_coord.Size = new System.Drawing.Size(340, 895);
            this.dtg_coord.TabIndex = 122;
            // 
            // last_gen
            // 
            this.last_gen.AutoSize = true;
            this.last_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_gen.ForeColor = System.Drawing.Color.White;
            this.last_gen.Location = new System.Drawing.Point(134, 339);
            this.last_gen.Name = "last_gen";
            this.last_gen.Size = new System.Drawing.Size(522, 36);
            this.last_gen.TabIndex = 123;
            this.last_gen.Text = "LAST COORDINATES GENERATION\r\n";
            this.last_gen.Click += new System.EventHandler(this.last_gen_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(226, 493);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 36);
            this.date.TabIndex = 124;
            this.date.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(65, 237);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(640, 340);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 125;
            this.loading.TabStop = false;
            // 
            // Reg_Coord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.date);
            this.Controls.Add(this.last_gen);
            this.Controls.Add(this.dtg_coord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gen_btn);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Reg_Coord";
            this.Text = "Reg_Coord";
            this.Load += new System.EventHandler(this.Reg_Coord_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.gen_btn, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.dtg_coord, 0);
            this.Controls.SetChildIndex(this.last_gen, 0);
            this.Controls.SetChildIndex(this.date, 0);
            this.Controls.SetChildIndex(this.loading, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_coord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gen_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.DataGridView dtg_coord;
        private System.Windows.Forms.Label last_gen;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox loading;
    }
}