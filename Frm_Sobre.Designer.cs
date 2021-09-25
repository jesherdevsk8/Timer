
namespace Timer
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.pcbTimePhoto = new System.Windows.Forms.PictureBox();
            this.listBoxSobre = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTimePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbTimePhoto
            // 
            this.pcbTimePhoto.Image = global::Timer.Properties.Resources.Time;
            this.pcbTimePhoto.Location = new System.Drawing.Point(12, 12);
            this.pcbTimePhoto.Name = "pcbTimePhoto";
            this.pcbTimePhoto.Size = new System.Drawing.Size(207, 274);
            this.pcbTimePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTimePhoto.TabIndex = 0;
            this.pcbTimePhoto.TabStop = false;
            // 
            // listBoxSobre
            // 
            this.listBoxSobre.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxSobre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSobre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxSobre.FormattingEnabled = true;
            this.listBoxSobre.Items.AddRange(new object[] {
            "Software desenvolvido em aula, do curso de",
            "Análise e Desenvolvimento de Sistemas na",
            "Etec Antônio de Pádua Cardoso",
            "Setembro de 2021.",
            "",
            "Desenvolvido por Jesher Minelli Alves",
            "jesherdevsk8@gmail.com",
            "jesher.alves@etec.sp.gov.br",
            "",
            "https://github.com/jesherdevsk8",
            "https://www.linkedin.com/in/jesher-minelli-913391220/"});
            this.listBoxSobre.Location = new System.Drawing.Point(232, 109);
            this.listBoxSobre.Name = "listBoxSobre";
            this.listBoxSobre.Size = new System.Drawing.Size(408, 147);
            this.listBoxSobre.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Timer Run - Jesher",
            "",
            "Versão 1.0",
            "",
            "Free Software"});
            this.listBox1.Location = new System.Drawing.Point(232, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 82);
            this.listBox1.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(572, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 300);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxSobre);
            this.Controls.Add(this.pcbTimePhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSobre";
            this.Text = "Sobre o Software";
            ((System.ComponentModel.ISupportInitialize)(this.pcbTimePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTimePhoto;
        private System.Windows.Forms.ListBox listBoxSobre;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOK;
    }
}