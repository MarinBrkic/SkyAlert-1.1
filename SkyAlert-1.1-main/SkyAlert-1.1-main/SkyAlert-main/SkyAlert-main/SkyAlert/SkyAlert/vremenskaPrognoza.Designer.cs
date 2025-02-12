namespace SkyAlert
{
    partial class vremenskaPrognoza
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.imeGrada = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtRain = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtVjetar = new System.Windows.Forms.TextBox();
            this.txtUVIndeks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(84, 18);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(148, 73);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(401, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 188);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mapa/Vremenski radar";
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(241, 329);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(207, 30);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Povratak na na odabir grada";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // imeGrada
            // 
            this.imeGrada.AutoSize = true;
            this.imeGrada.Location = new System.Drawing.Point(335, 9);
            this.imeGrada.Name = "imeGrada";
            this.imeGrada.Size = new System.Drawing.Size(37, 16);
            this.imeGrada.TabIndex = 14;
            this.imeGrada.Text = "Grad";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(44, 118);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(275, 189);
            this.dataGridViewUser.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Temperatura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mogucnost kise:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vlaznost zraka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vjetar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "UV Indeks:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(163, 134);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.ReadOnly = true;
            this.txtTemperature.Size = new System.Drawing.Size(143, 22);
            this.txtTemperature.TabIndex = 21;
            // 
            // txtRain
            // 
            this.txtRain.Location = new System.Drawing.Point(163, 171);
            this.txtRain.Name = "txtRain";
            this.txtRain.ReadOnly = true;
            this.txtRain.Size = new System.Drawing.Size(143, 22);
            this.txtRain.TabIndex = 22;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(163, 208);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.ReadOnly = true;
            this.txtHumidity.Size = new System.Drawing.Size(143, 22);
            this.txtHumidity.TabIndex = 23;
            // 
            // txtVjetar
            // 
            this.txtVjetar.Location = new System.Drawing.Point(163, 243);
            this.txtVjetar.Name = "txtVjetar";
            this.txtVjetar.ReadOnly = true;
            this.txtVjetar.Size = new System.Drawing.Size(143, 22);
            this.txtVjetar.TabIndex = 24;
            // 
            // txtUVIndeks
            // 
            this.txtUVIndeks.Location = new System.Drawing.Point(163, 277);
            this.txtUVIndeks.Name = "txtUVIndeks";
            this.txtUVIndeks.ReadOnly = true;
            this.txtUVIndeks.Size = new System.Drawing.Size(143, 22);
            this.txtUVIndeks.TabIndex = 25;
            // 
            // vremenskaPrognoza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 382);
            this.Controls.Add(this.txtUVIndeks);
            this.Controls.Add(this.txtVjetar);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtRain);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.imeGrada);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "vremenskaPrognoza";
            this.Text = "vremenskaPrognoza";
            this.Load += new System.EventHandler(this.vremenskaPrognoza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label imeGrada;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtRain;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtVjetar;
        private System.Windows.Forms.TextBox txtUVIndeks;
    }
}