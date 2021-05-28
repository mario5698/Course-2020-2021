namespace Pruebas
{
    partial class Prueba
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
            this.button1 = new System.Windows.Forms.Button();
            this.swCodi1 = new Controles_Usuario.SWCodi();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // swCodi1
            // 
            this.swCodi1.BackColor = System.Drawing.Color.Transparent;
            this.swCodi1.ClasseCS = null;
            this.swCodi1.ControlID = null;
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(169, 133);
            this.swCodi1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.NomCodi = "codespecie";
            this.swCodi1.NomDesc = "descspecie";
            this.swCodi1.NomId = null;
            this.swCodi1.NomTaula = "species";
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(518, 82);
            this.swCodi1.TabIndex = 0;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swCodi1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles_Usuario.SWCodi swCodi1;
        private System.Windows.Forms.Button button1;
    }
}