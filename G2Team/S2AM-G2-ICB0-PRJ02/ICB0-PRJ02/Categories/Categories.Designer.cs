namespace Categories
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancel = new System.Windows.Forms.Button();
            this.Actualizar_Base = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.access_swtbx = new BlibliotecaG2.SWTextbox();
            this.desc_swtbx = new BlibliotecaG2.SWTextbox();
            this.code_swtbx = new BlibliotecaG2.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.Color.PaleGreen;
            this.cancel.Location = new System.Drawing.Point(493, 405);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 43);
            this.cancel.TabIndex = 112;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Actualizar_Base
            // 
            this.Actualizar_Base.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Actualizar_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Actualizar_Base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.Actualizar_Base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar_Base.ForeColor = System.Drawing.Color.PaleGreen;
            this.Actualizar_Base.Location = new System.Drawing.Point(673, 405);
            this.Actualizar_Base.Name = "Actualizar_Base";
            this.Actualizar_Base.Size = new System.Drawing.Size(114, 43);
            this.Actualizar_Base.TabIndex = 110;
            this.Actualizar_Base.Text = "SAVE";
            this.Actualizar_Base.UseVisualStyleBackColor = false;
            this.Actualizar_Base.Click += new System.EventHandler(this.Actualizar_Base_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.PaleGreen;
            this.add.Location = new System.Drawing.Point(311, 405);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 43);
            this.add.TabIndex = 111;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dtgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgUsers.EnableHeadersVisualStyles = false;
            this.dtgUsers.GridColor = System.Drawing.Color.PaleGreen;
            this.dtgUsers.Location = new System.Drawing.Point(0, 351);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgUsers.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.PaleGreen;
            this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgUsers.RowTemplate.Height = 28;
            this.dtgUsers.Size = new System.Drawing.Size(1386, 437);
            this.dtgUsers.TabIndex = 109;
            // 
            // access_swtbx
            // 
            this.access_swtbx.BackColor = System.Drawing.Color.PaleGreen;
            this.access_swtbx.ControllID = null;
            this.access_swtbx.dada = null;
            this.access_swtbx.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.access_swtbx.Foranea = false;
            this.access_swtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.access_swtbx.Location = new System.Drawing.Point(673, 232);
            this.access_swtbx.Name = "access_swtbx";
            this.access_swtbx.Nom_BBDD = "accesslevel";
            this.access_swtbx.obligatorio = false;
            this.access_swtbx.Size = new System.Drawing.Size(100, 26);
            this.access_swtbx.TabIndex = 115;
            // 
            // desc_swtbx
            // 
            this.desc_swtbx.BackColor = System.Drawing.Color.PaleGreen;
            this.desc_swtbx.ControllID = null;
            this.desc_swtbx.dada = null;
            this.desc_swtbx.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.desc_swtbx.Foranea = false;
            this.desc_swtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.desc_swtbx.Location = new System.Drawing.Point(673, 190);
            this.desc_swtbx.Name = "desc_swtbx";
            this.desc_swtbx.Nom_BBDD = "DescCategory";
            this.desc_swtbx.obligatorio = false;
            this.desc_swtbx.Size = new System.Drawing.Size(100, 26);
            this.desc_swtbx.TabIndex = 114;
            // 
            // code_swtbx
            // 
            this.code_swtbx.BackColor = System.Drawing.Color.PaleGreen;
            this.code_swtbx.ControllID = null;
            this.code_swtbx.dada = null;
            this.code_swtbx.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.code_swtbx.Foranea = false;
            this.code_swtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.code_swtbx.Location = new System.Drawing.Point(673, 147);
            this.code_swtbx.Name = "code_swtbx";
            this.code_swtbx.Nom_BBDD = "CodeCategory";
            this.code_swtbx.obligatorio = false;
            this.code_swtbx.Size = new System.Drawing.Size(100, 26);
            this.code_swtbx.TabIndex = 113;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.access_swtbx);
            this.Controls.Add(this.desc_swtbx);
            this.Controls.Add(this.code_swtbx);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Actualizar_Base);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dtgUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Actualizar_Base;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dtgUsers;
        private BlibliotecaG2.SWTextbox code_swtbx;
        private BlibliotecaG2.SWTextbox desc_swtbx;
        private BlibliotecaG2.SWTextbox access_swtbx;
    }
}