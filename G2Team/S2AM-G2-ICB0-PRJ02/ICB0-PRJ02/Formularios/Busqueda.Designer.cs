namespace Formularios
{
    partial class Busqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.swtxt1 = new BlibliotecaG2.SWTextbox();
            this.dgw = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.swtxt3 = new BlibliotecaG2.SWTextbox();
            this.swtxt2 = new BlibliotecaG2.SWTextbox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // swtxt1
            // 
            this.swtxt1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swtxt1.BackColor = System.Drawing.Color.PaleGreen;
            this.swtxt1.ControllID = null;
            this.swtxt1.dada = null;
            this.swtxt1.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.swtxt1.Foranea = false;
            this.swtxt1.Location = new System.Drawing.Point(285, 229);
            this.swtxt1.Name = "swtxt1";
            this.swtxt1.Nom_BBDD = "idSpecie";
            this.swtxt1.obligatorio = false;
            this.swtxt1.Size = new System.Drawing.Size(127, 26);
            this.swtxt1.TabIndex = 2;
            this.swtxt1.Tag = "";
            // 
            // dgw
            // 
            this.dgw.AllowUserToAddRows = false;
            this.dgw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw.EnableHeadersVisualStyles = false;
            this.dgw.GridColor = System.Drawing.Color.PaleGreen;
            this.dgw.Location = new System.Drawing.Point(0, 282);
            this.dgw.Name = "dgw";
            this.dgw.ReadOnly = true;
            this.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgw.RowHeadersWidth = 62;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.PaleGreen;
            this.dgw.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(1200, 410);
            this.dgw.TabIndex = 94;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnBuscar.Location = new System.Drawing.Point(626, 165);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(300, 122);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // swtxt3
            // 
            this.swtxt3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swtxt3.BackColor = System.Drawing.Color.PaleGreen;
            this.swtxt3.ControllID = null;
            this.swtxt3.dada = null;
            this.swtxt3.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.swtxt3.Foranea = false;
            this.swtxt3.Location = new System.Drawing.Point(285, 320);
            this.swtxt3.Name = "swtxt3";
            this.swtxt3.Nom_BBDD = "DescSpecie";
            this.swtxt3.obligatorio = false;
            this.swtxt3.Size = new System.Drawing.Size(127, 26);
            this.swtxt3.TabIndex = 85;
            this.swtxt3.Tag = "";
            // 
            // swtxt2
            // 
            this.swtxt2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swtxt2.BackColor = System.Drawing.Color.PaleGreen;
            this.swtxt2.ControllID = null;
            this.swtxt2.dada = null;
            this.swtxt2.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.swtxt2.Foranea = false;
            this.swtxt2.Location = new System.Drawing.Point(285, 274);
            this.swtxt2.Name = "swtxt2";
            this.swtxt2.Nom_BBDD = "CodeSpecie";
            this.swtxt2.obligatorio = false;
            this.swtxt2.Size = new System.Drawing.Size(127, 26);
            this.swtxt2.TabIndex = 83;
            this.swtxt2.Tag = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(626, 321);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(300, 122);
            this.btnLimpiar.TabIndex = 95;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl2.Location = new System.Drawing.Point(66, 270);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(161, 29);
            this.lbl2.TabIndex = 236;
            this.lbl2.Text = "Code_Specie";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl3.Location = new System.Drawing.Point(70, 316);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(157, 29);
            this.lbl3.TabIndex = 237;
            this.lbl3.Text = "Desc_Specie";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(105, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 238;
            this.label1.Text = "Id_Specie";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.swtxt3);
            this.Controls.Add(this.swtxt2);
            this.Controls.Add(this.swtxt1);
            this.Controls.Add(this.dgw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlibliotecaG2.SWTextbox swtxt1;
        private System.Windows.Forms.DataGridView dgw;
        private BlibliotecaG2.SWTextbox swtxt3;
        private BlibliotecaG2.SWTextbox swtxt2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
    }
}