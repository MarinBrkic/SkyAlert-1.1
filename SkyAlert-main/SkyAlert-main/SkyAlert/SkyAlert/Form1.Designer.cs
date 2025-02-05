namespace SkyAlert
{
    partial class Form1
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
            this.btnDohvatiPrognozu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeGrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDohvatiPrognozu
            // 
            this.btnDohvatiPrognozu.Location = new System.Drawing.Point(284, 193);
            this.btnDohvatiPrognozu.Name = "btnDohvatiPrognozu";
            this.btnDohvatiPrognozu.Size = new System.Drawing.Size(243, 37);
            this.btnDohvatiPrognozu.TabIndex = 0;
            this.btnDohvatiPrognozu.Text = "Dohvati vremensku prognozu";
            this.btnDohvatiPrognozu.UseVisualStyleBackColor = true;
            this.btnDohvatiPrognozu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ime grada čiju vremensku prognozu želite saznati:";
            // 
            // textBoxImeGrada
            // 
            this.textBoxImeGrada.Location = new System.Drawing.Point(208, 149);
            this.textBoxImeGrada.Name = "textBoxImeGrada";
            this.textBoxImeGrada.Size = new System.Drawing.Size(413, 26);
            this.textBoxImeGrada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxImeGrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDohvatiPrognozu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDohvatiPrognozu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeGrada;
    }
}

