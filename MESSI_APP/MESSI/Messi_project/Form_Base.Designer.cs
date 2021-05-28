namespace M_E_S_S_I
{
    partial class Form_Base
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
            this.retroceder = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Pnl_top.SuspendLayout();
            this.SuspendLayout();
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
            this.retroceder.Margin = new System.Windows.Forms.Padding(2);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(46, 32);
            this.retroceder.TabIndex = 119;
            this.retroceder.Text = "↩";
            this.retroceder.UseVisualStyleBackColor = false;
            this.retroceder.Click += new System.EventHandler(this.retroceder_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.Brown;
            this.CloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApp.ForeColor = System.Drawing.Color.White;
            this.CloseApp.Location = new System.Drawing.Point(487, 0);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(2);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(46, 32);
            this.CloseApp.TabIndex = 120;
            this.CloseApp.Text = "✖";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.Color.Brown;
            this.Pnl_top.Controls.Add(this.CloseApp);
            this.Pnl_top.Controls.Add(this.retroceder);
            this.Pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_top.Name = "Pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(533, 32);
            this.Pnl_top.TabIndex = 1;
            // 
            // Form_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Base";
            this.Text = "Form_Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Pnl_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Panel Pnl_top;
    }
}