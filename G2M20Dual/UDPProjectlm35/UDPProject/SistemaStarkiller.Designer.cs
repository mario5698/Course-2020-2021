
namespace UDPProject
{
    partial class SistemaStarkiller
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PortBase = new System.Windows.Forms.Label();
            this.lbl_PortSitema = new System.Windows.Forms.Label();
            this.lbl_SendMesage = new System.Windows.Forms.Label();
            this.lbl_ReceivedMessage = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.pnl_StatusColor = new System.Windows.Forms.Panel();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.lbx_ReceivedMessage = new System.Windows.Forms.ListBox();
            this.txt_IPBase = new System.Windows.Forms.TextBox();
            this.txt_PortBase = new System.Windows.Forms.TextBox();
            this.txt_PortSistema = new System.Windows.Forms.TextBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Base";
            // 
            // lbl_PortBase
            // 
            this.lbl_PortBase.AutoSize = true;
            this.lbl_PortBase.Location = new System.Drawing.Point(295, 81);
            this.lbl_PortBase.Name = "lbl_PortBase";
            this.lbl_PortBase.Size = new System.Drawing.Size(53, 13);
            this.lbl_PortBase.TabIndex = 1;
            this.lbl_PortBase.Text = "Port Base";
            // 
            // lbl_PortSitema
            // 
            this.lbl_PortSitema.AutoSize = true;
            this.lbl_PortSitema.Location = new System.Drawing.Point(295, 155);
            this.lbl_PortSitema.Name = "lbl_PortSitema";
            this.lbl_PortSitema.Size = new System.Drawing.Size(66, 13);
            this.lbl_PortSitema.TabIndex = 2;
            this.lbl_PortSitema.Text = "Port Sistema";
            // 
            // lbl_SendMesage
            // 
            this.lbl_SendMesage.AutoSize = true;
            this.lbl_SendMesage.Location = new System.Drawing.Point(82, 232);
            this.lbl_SendMesage.Name = "lbl_SendMesage";
            this.lbl_SendMesage.Size = new System.Drawing.Size(78, 13);
            this.lbl_SendMesage.TabIndex = 3;
            this.lbl_SendMesage.Text = "Send Message";
            // 
            // lbl_ReceivedMessage
            // 
            this.lbl_ReceivedMessage.AutoSize = true;
            this.lbl_ReceivedMessage.Location = new System.Drawing.Point(82, 307);
            this.lbl_ReceivedMessage.Name = "lbl_ReceivedMessage";
            this.lbl_ReceivedMessage.Size = new System.Drawing.Size(99, 13);
            this.lbl_ReceivedMessage.TabIndex = 4;
            this.lbl_ReceivedMessage.Text = "Received Message";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(818, 369);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "Status";
            // 
            // pnl_StatusColor
            // 
            this.pnl_StatusColor.Location = new System.Drawing.Point(818, 307);
            this.pnl_StatusColor.Name = "pnl_StatusColor";
            this.pnl_StatusColor.Size = new System.Drawing.Size(63, 59);
            this.pnl_StatusColor.TabIndex = 6;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(473, 100);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(473, 148);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 8;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(270, 250);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMessage.TabIndex = 9;
            this.btn_SendMessage.Text = "Send";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // lbx_ReceivedMessage
            // 
            this.lbx_ReceivedMessage.FormattingEnabled = true;
            this.lbx_ReceivedMessage.Location = new System.Drawing.Point(82, 325);
            this.lbx_ReceivedMessage.Name = "lbx_ReceivedMessage";
            this.lbx_ReceivedMessage.Size = new System.Drawing.Size(242, 160);
            this.lbx_ReceivedMessage.TabIndex = 10;
            // 
            // txt_IPBase
            // 
            this.txt_IPBase.Location = new System.Drawing.Point(82, 99);
            this.txt_IPBase.Name = "txt_IPBase";
            this.txt_IPBase.Size = new System.Drawing.Size(143, 20);
            this.txt_IPBase.TabIndex = 11;
            // 
            // txt_PortBase
            // 
            this.txt_PortBase.Location = new System.Drawing.Point(295, 99);
            this.txt_PortBase.Name = "txt_PortBase";
            this.txt_PortBase.Size = new System.Drawing.Size(139, 20);
            this.txt_PortBase.TabIndex = 12;
            // 
            // txt_PortSistema
            // 
            this.txt_PortSistema.Location = new System.Drawing.Point(295, 173);
            this.txt_PortSistema.Name = "txt_PortSistema";
            this.txt_PortSistema.Size = new System.Drawing.Size(139, 20);
            this.txt_PortSistema.TabIndex = 13;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(82, 250);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(143, 20);
            this.txt_Message.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(374, 199);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(399, 286);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Temperatura mas alta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(448, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Media";
            // 
            // SistemaStarkiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 597);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_PortSistema);
            this.Controls.Add(this.txt_PortBase);
            this.Controls.Add(this.txt_IPBase);
            this.Controls.Add(this.lbx_ReceivedMessage);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.pnl_StatusColor);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_ReceivedMessage);
            this.Controls.Add(this.lbl_SendMesage);
            this.Controls.Add(this.lbl_PortSitema);
            this.Controls.Add(this.lbl_PortBase);
            this.Controls.Add(this.label1);
            this.Name = "SistemaStarkiller";
            this.Text = "SistemaStarkiller";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PortBase;
        private System.Windows.Forms.Label lbl_PortSitema;
        private System.Windows.Forms.Label lbl_SendMesage;
        private System.Windows.Forms.Label lbl_ReceivedMessage;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Panel pnl_StatusColor;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.ListBox lbx_ReceivedMessage;
        private System.Windows.Forms.TextBox txt_IPBase;
        private System.Windows.Forms.TextBox txt_PortBase;
        private System.Windows.Forms.TextBox txt_PortSistema;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}