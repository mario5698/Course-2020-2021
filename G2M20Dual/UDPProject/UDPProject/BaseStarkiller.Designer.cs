
namespace UDPProject
{
    partial class BaseStarkiller
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
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_PortBase = new System.Windows.Forms.TextBox();
            this.txt_PortSistema = new System.Windows.Forms.TextBox();
            this.txt_IPSistema = new System.Windows.Forms.TextBox();
            this.lbx_ReceivedMessage = new System.Windows.Forms.ListBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_ReceivedMessage = new System.Windows.Forms.Label();
            this.lbl_SendMesage = new System.Windows.Forms.Label();
            this.lbl_PortBase = new System.Windows.Forms.Label();
            this.lbl_PortSistema = new System.Windows.Forms.Label();
            this.lbl_IPSistema = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(88, 238);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(143, 20);
            this.txt_Message.TabIndex = 28;
            // 
            // txt_PortBase
            // 
            this.txt_PortBase.Location = new System.Drawing.Point(301, 161);
            this.txt_PortBase.Name = "txt_PortBase";
            this.txt_PortBase.Size = new System.Drawing.Size(139, 20);
            this.txt_PortBase.TabIndex = 27;
            // 
            // txt_PortSistema
            // 
            this.txt_PortSistema.Location = new System.Drawing.Point(301, 87);
            this.txt_PortSistema.Name = "txt_PortSistema";
            this.txt_PortSistema.Size = new System.Drawing.Size(139, 20);
            this.txt_PortSistema.TabIndex = 26;
            // 
            // txt_IPSistema
            // 
            this.txt_IPSistema.Location = new System.Drawing.Point(88, 87);
            this.txt_IPSistema.Name = "txt_IPSistema";
            this.txt_IPSistema.Size = new System.Drawing.Size(143, 20);
            this.txt_IPSistema.TabIndex = 25;
            // 
            // lbx_ReceivedMessage
            // 
            this.lbx_ReceivedMessage.FormattingEnabled = true;
            this.lbx_ReceivedMessage.Location = new System.Drawing.Point(88, 313);
            this.lbx_ReceivedMessage.Name = "lbx_ReceivedMessage";
            this.lbx_ReceivedMessage.Size = new System.Drawing.Size(242, 160);
            this.lbx_ReceivedMessage.TabIndex = 24;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(276, 238);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMessage.TabIndex = 23;
            this.btn_SendMessage.Text = "Send";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(479, 136);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_Disconnect.TabIndex = 22;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(479, 88);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 21;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_ReceivedMessage
            // 
            this.lbl_ReceivedMessage.AutoSize = true;
            this.lbl_ReceivedMessage.Location = new System.Drawing.Point(88, 295);
            this.lbl_ReceivedMessage.Name = "lbl_ReceivedMessage";
            this.lbl_ReceivedMessage.Size = new System.Drawing.Size(99, 13);
            this.lbl_ReceivedMessage.TabIndex = 20;
            this.lbl_ReceivedMessage.Text = "Received Message";
            // 
            // lbl_SendMesage
            // 
            this.lbl_SendMesage.AutoSize = true;
            this.lbl_SendMesage.Location = new System.Drawing.Point(88, 220);
            this.lbl_SendMesage.Name = "lbl_SendMesage";
            this.lbl_SendMesage.Size = new System.Drawing.Size(78, 13);
            this.lbl_SendMesage.TabIndex = 19;
            this.lbl_SendMesage.Text = "Send Message";
            // 
            // lbl_PortBase
            // 
            this.lbl_PortBase.AutoSize = true;
            this.lbl_PortBase.Location = new System.Drawing.Point(301, 143);
            this.lbl_PortBase.Name = "lbl_PortBase";
            this.lbl_PortBase.Size = new System.Drawing.Size(53, 13);
            this.lbl_PortBase.TabIndex = 18;
            this.lbl_PortBase.Text = "Port Base";
            // 
            // lbl_PortSistema
            // 
            this.lbl_PortSistema.AutoSize = true;
            this.lbl_PortSistema.Location = new System.Drawing.Point(301, 69);
            this.lbl_PortSistema.Name = "lbl_PortSistema";
            this.lbl_PortSistema.Size = new System.Drawing.Size(66, 13);
            this.lbl_PortSistema.TabIndex = 17;
            this.lbl_PortSistema.Text = "Port Sistema";
            // 
            // lbl_IPSistema
            // 
            this.lbl_IPSistema.AutoSize = true;
            this.lbl_IPSistema.Location = new System.Drawing.Point(88, 69);
            this.lbl_IPSistema.Name = "lbl_IPSistema";
            this.lbl_IPSistema.Size = new System.Drawing.Size(57, 13);
            this.lbl_IPSistema.TabIndex = 16;
            this.lbl_IPSistema.Text = "IP Sistema";
            // 
            // BaseStarkiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 597);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_PortBase);
            this.Controls.Add(this.txt_PortSistema);
            this.Controls.Add(this.txt_IPSistema);
            this.Controls.Add(this.lbx_ReceivedMessage);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_ReceivedMessage);
            this.Controls.Add(this.lbl_SendMesage);
            this.Controls.Add(this.lbl_PortBase);
            this.Controls.Add(this.lbl_PortSistema);
            this.Controls.Add(this.lbl_IPSistema);
            this.Name = "BaseStarkiller";
            this.Text = "BaseStarkiller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_PortBase;
        private System.Windows.Forms.TextBox txt_PortSistema;
        private System.Windows.Forms.TextBox txt_IPSistema;
        private System.Windows.Forms.ListBox lbx_ReceivedMessage;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_ReceivedMessage;
        private System.Windows.Forms.Label lbl_SendMesage;
        private System.Windows.Forms.Label lbl_PortBase;
        private System.Windows.Forms.Label lbl_PortSistema;
        private System.Windows.Forms.Label lbl_IPSistema;
        private System.Windows.Forms.Timer timer1;
    }
}