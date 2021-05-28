namespace SecureCore
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_rigth = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_HideLeftPanel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_rigth);
            this.panel2.Controls.Add(this.pnl_left);
            this.panel2.Controls.Add(this.pnl_top);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 788);
            this.panel2.TabIndex = 2;
            // 
            // pnl_rigth
            // 
            this.pnl_rigth.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_rigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_rigth.Location = new System.Drawing.Point(200, 29);
            this.pnl_rigth.Name = "pnl_rigth";
            this.pnl_rigth.Size = new System.Drawing.Size(1186, 759);
            this.pnl_rigth.TabIndex = 2;
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 29);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(200, 759);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnl_top.Controls.Add(this.lblUser);
            this.pnl_top.Controls.Add(this.button1);
            this.pnl_top.Controls.Add(this.btn_HideLeftPanel);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1386, 29);
            this.pnl_top.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblUser.Location = new System.Drawing.Point(49, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "user";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1346, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_HideLeftPanel
            // 
            this.btn_HideLeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HideLeftPanel.BackgroundImage")));
            this.btn_HideLeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HideLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_HideLeftPanel.FlatAppearance.BorderSize = 0;
            this.btn_HideLeftPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideLeftPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HideLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.btn_HideLeftPanel.Name = "btn_HideLeftPanel";
            this.btn_HideLeftPanel.Size = new System.Drawing.Size(40, 29);
            this.btn_HideLeftPanel.TabIndex = 0;
            this.btn_HideLeftPanel.UseVisualStyleBackColor = true;
            this.btn_HideLeftPanel.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_rigth;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_HideLeftPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUser;
    }
}