
namespace UDPProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Sistema = new System.Windows.Forms.Button();
            this.btn_Base = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sistema
            // 
            this.btn_Sistema.Location = new System.Drawing.Point(425, 185);
            this.btn_Sistema.Name = "btn_Sistema";
            this.btn_Sistema.Size = new System.Drawing.Size(122, 80);
            this.btn_Sistema.TabIndex = 3;
            this.btn_Sistema.Text = "SistemaStarkiller";
            this.btn_Sistema.UseVisualStyleBackColor = true;
            this.btn_Sistema.Click += new System.EventHandler(this.btn_Sistema_Click);
            // 
            // btn_Base
            // 
            this.btn_Base.Location = new System.Drawing.Point(254, 185);
            this.btn_Base.Name = "btn_Base";
            this.btn_Base.Size = new System.Drawing.Size(122, 80);
            this.btn_Base.TabIndex = 2;
            this.btn_Base.Text = "BaseStarkiller";
            this.btn_Base.UseVisualStyleBackColor = true;
            this.btn_Base.Click += new System.EventHandler(this.btn_Base_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sistema);
            this.Controls.Add(this.btn_Base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sistema;
        private System.Windows.Forms.Button btn_Base;
    }
}

